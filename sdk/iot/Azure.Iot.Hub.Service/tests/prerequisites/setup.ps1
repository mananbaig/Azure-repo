param(
    [Parameter(Mandatory)]
    [string] $Region,

    [Parameter(Mandatory)]
    [string] $ResourceGroup,
    
    [Parameter(Mandatory)]
    [string] $SubscriptionId,

    [Parameter()]
    [string] $IotHubName,

    [Parameter()]
    [string] $AppRegistrationName
)

Function Connect-AzureSubscription()
{
    # Ensure the user is logged in
    try
    {
        $azureContext = az account show
    }
    catch { }

    if (-not $azureContext)
    {
        Write-Host "`nPlease login to Azure..."
        az login
        $azureContext = az account show
    }

    # Ensure the desired subscription is selected
    $sub = az account show --output tsv --query id
    if ($sub -ne $SubscriptionId)
    {
        Write-Host "`nSelecting subscription $SubscriptionId"
        az account set --subscription $SubscriptionId
    }

    return $azureContext
}

$isAdmin = ([Security.Principal.WindowsPrincipal] [Security.Principal.WindowsIdentity]::GetCurrent()).IsInRole([Security.Principal.WindowsBuiltInRole] "Administrator")
if (-not $isAdmin)
{
    throw "This script must be run in administrative mode."
}

Connect-AzureSubscription

$Region = $Region.Replace(' ', '')

if (-not $IotHubName)
{
    $IotHubName = $ResourceGroup
}

if (-not $AppRegistrationName)
{
    $AppRegistrationName = $ResourceGroup
}

$appId = az ad app list --show-mine --query "[?displayName=='$AppRegistrationName'].appId" --output tsv
if (-not $appId)
{
    Write-Host "`nCreating App Registration $AppRegistrationName`n"
    $appId = az ad app create --display-name $AppRegistrationName --native-app --query 'appId' --output tsv
}

$sp = az ad sp list --show-mine --query "[?appId=='$appId'].appId" --output tsv
if (-not $sp)
{
    Write-Host "`nCreating service principal for app $appId`n"
    az ad sp create --id $appId --output none
}

# Get test application OID from the service principal
$applicationOId = az ad sp show --id $sp --query "objectId" --output tsv

$rgExists = az group exists --name $ResourceGroup
if ($rgExists -eq "False")
{
    Write-Host "`nCreating Resource Group $ResourceGroup in $Region`n"
    az group create --name $ResourceGroup --location $Region --output none
}

Write-Host "`nDeploying resources to $ResourceGroup in $Region`n"

$armTemplateFile = Join-Path -Path $PSScriptRoot -ChildPath "../../../test-resources.json"

if (-not (Test-Path $armTemplateFile -PathType leaf))
{
    throw "`nARM template was not found. Please make sure you have an ARM template file named test-resources.json in the root of the service directory`n"
}

# Deploy test-resources.json ARM template.
az deployment group create --resource-group $ResourceGroup --name $IotHubName --template-file $armTemplateFile --parameters `
    baseName=$IotHubName `
    testApplicationOid=$applicationOId

# Even though the output variable names are all capital letters in the script, ARM turns them into a strange casing
# and we have to use that casing in order to get them from the deployment outputs.
$iotHubConnectionString = az deployment group show -g $ResourceGroup -n $IotHubName --query 'properties.outputs.ioT_HUB_CONNECTIONSTRING.value' --output tsv
$iotHubHostName = az deployment group show -g $ResourceGroup -n $IotHubName --query 'properties.outputs.ioT_HUB_ENDPOINT_URL.value' --output tsv

Write-Host("Set a new client secret for $appId`n")
$appSecret = az ad app credential reset --id $appId --years 2 --query 'password' --output tsv

$user = $env:UserName
$fileName = "$user.config.json"
Write-Host("Writing user config file - $fileName`n")
$appSecretJsonEscaped = ConvertTo-Json $appSecret
$config = @"
{
    "IotHubConnectionString": "$iotHubConnectionString",
    "IotHubHostName": "$iotHubHostName",
    "ApplicationId": "$appId",
    "ClientSecret": $appSecretJsonEscaped,
    "TestMode":  "Live"
}
"@

$config | Out-File "$PSScriptRoot\..\config\$fileName"

Write-Host "Done!"
