[CmdletBinding()]
param(
    [Parameter(Mandatory=$true)]
    $package
)

function Get-LevenshteinDistance {
    <#
        .SYNOPSIS
            Get the Levenshtein distance between two strings.
        .DESCRIPTION
            The Levenshtein Distance is a way of quantifying how dissimilar two strings (e.g., words) are to one another by counting the minimum number of operations required to transform one string into the other.
        .EXAMPLE
            Get-LevenshteinDistance 'kitten' 'sitting'
        .LINK
            http://en.wikibooks.org/wiki/Algorithm_Implementation/Strings/Levenshtein_distance#C.23
            http://en.wikipedia.org/wiki/Edit_distance
            https://communary.wordpress.com/
            https://github.com/gravejester/Communary.PASM
        .NOTES
            Author: Ã˜yvind Kallstad
            Date: 07.11.2014
            Version: 1.0
    #>
    [CmdletBinding()]
    param(
        [Parameter(Position = 0)]
        [string]$String1,

        [Parameter(Position = 1)]
        [string]$String2,

        # Makes matches case-sensitive. By default, matches are not case-sensitive.
        [Parameter()]
        [switch] $CaseSensitive,

        # A normalized output will fall in the range 0 (perfect match) to 1 (no match).
        [Parameter()]
        [switch] $NormalizeOutput
    )

    if (-not($CaseSensitive)) {
        $String1 = $String1.ToLowerInvariant()
        $String2 = $String2.ToLowerInvariant()
    }

    $d = New-Object 'Int[,]' ($String1.Length + 1), ($String2.Length + 1)
    for ($i = 0; $i -le $d.GetUpperBound(0); $i++) {
        $d[$i,0] = $i
    }

    for ($i = 0; $i -le $d.GetUpperBound(1); $i++) {
        $d[0,$i] = $i
    }

    for ($i = 1; $i -le $d.GetUpperBound(0); $i++) {
        for ($j = 1; $j -le $d.GetUpperBound(1); $j++) {
            $cost = [Convert]::ToInt32((-not($String1[$i–1] -ceq $String2[$j–1])))
            $min1 = $d[($i–1),$j] + 1
            $min2 = $d[$i,($j–1)] + 1
            $min3 = $d[($i–1),($j–1)] + $cost
            $d[$i,$j] = [Math]::Min([Math]::Min($min1,$min2),$min3)
        }
    }

    $distance = ($d[$d.GetUpperBound(0),$d.GetUpperBound(1)])

    if ($NormalizeOutput) {
        return (1 – ($distance) / ([Math]::Max($String1.Length,$String2.Length)))
    }

    else {
        return $distance
    }
}

$ErrorPreference = 'Stop'
$repoRoot = Resolve-Path "$PSScriptRoot/../..";

if (!(Get-Command az)) {
  throw 'You must have the Azure CLI installed: https://aka.ms/azure-cli'
}

az extension show -n azure-devops > $null

if (!$?){
  throw 'You must have the azure-devops extension run `az extension add --name azure-devops`'
}

. ${repoRoot}\eng\common\scripts\SemVer.ps1
. ${repoRoot}\eng\common\scripts\ChangeLog-Operations.ps1

$packageDirectory = Get-ChildItem "$repoRoot/sdk" -Directory -Recurse -Depth 2 -Filter $package
$serviceDirectory = $packageDirectory.Parent.Name

Write-Host "Source directory $serviceDirectory"

try
{
    $existing = Invoke-WebRequest "https://api.nuget.org/v3-flatcontainer/$($package.ToLower())/index.json" | ConvertFrom-Json;
}
catch
{
    $existing = @()
}

$libraryType = "Preview";
$latestVersion = $null;
foreach ($existingVersion in $existing.versions)
{
    $parsedVersion = [AzureEngSemanticVersion]::new($existingVersion)
    if (!$parsedVersion.IsPrerelease)
    {
        $libraryType = "GA"
    }

    $latestVersion = $existingVersion;
}

$currentProjectVersion = ([xml](Get-Content "$packageDirectory/src/*.csproj")).Project.PropertyGroup.Version

if ($latestVersion)
{
    $releaseType = "None";
    $parsedNewVersion = [AzureEngSemanticVersion]::new($newVersion)
    if ($parsedNewVersion.Major -ne $parsedVersion.Major)
    {
        $releaseType = "Major"
    }
    elseif ($parsedNewVersion.Minor -ne $parsedVersion.Minor)
    {
        $releaseType = "Minor"
    }
    elseif ($parsedNewVersion.Patch -ne $parsedVersion.Patch)
    {
        $releaseType = "Bugfix"
    }
    elseif ($parsedNewVersion.IsPrerelease)
    {
        $releaseType = "Bugfix"
    }


    Write-Host
    Write-Host "Latest released version $latestVersion, library type $libraryType" -ForegroundColor Green
}
else
{
    $releaseType = "Major";
    Write-Host
    Write-Host "No released version, library type $libraryType" -ForegroundColor Green
}

$newVersion = Read-Host -Prompt "Input the new version or press Enter to use use current project version '$currentProjectVersion'"

if (!$newVersion)
{
    $newVersion = $currentProjectVersion;
}

Write-Host
Write-Host "Detected released type $releaseType" -ForegroundColor Green

Write-Host
Write-Host "Updating versions" -ForegroundColor Green

& "$repoRoot\eng\scripts\Update-PkgVersion.ps1" -ServiceDirectory $serviceDirectory -PackageName $package -NewVersionString $newVersion

$date = Get-Date
$month = $date.ToString("MMMM")
if ($date.Day -gt 15)
{
    $month = $date.AddMonths(1).ToString("MMMM")
}
Write-Host
Write-Host "Assuming release is in $month" -ForegroundColor Green

$commonParameter = @("--organization", "https://dev.azure.com/azure-sdk", "-o", "json", "--only-show-errors")

$workItems = az boards query @commonParameter --project Release --wiql "SELECT [ID], [State], [Iteration Path], [Title] FROM WorkItems WHERE [State] <> 'Closed' AND [Iteration Path] under 'Release\2020\$month' AND [Title] contains '.NET'" | ConvertFrom-Json;

Write-Host
Write-Host "The following work items exist:"
foreach ($item in $workItems)
{
    $id = $item.fields."System.ID";
    $title = $item.fields."System.Title";
    $path = $item.fields."System.IterationPath";
    Write-Host "$id - $path - $title" 
}

# Sort using fuzzy match
$workItems = $workItems | Sort-Object -property @{Expression = { Get-LevenshteinDistance $_.fields."System.Title" $package -NormalizeOutput }}
$mostProbable = $workItems | Select-Object -Last 1

$issueId = Read-Host -Prompt "Input the work item ID or press Enter to use '$($mostProbable.fields."System.ID") - $($mostProbable.fields."System.Title")' (fuzzy matched based on title)"

if (!$issueId)
{
    $issueId = $mostProbable.fields."System.ID"
}

$fields = @{
    "Permalink usetag"="https://github.com/Azure/azure-sdk-for-net/sdk/$serviceDirectory/$package/README.md"
    "Package Registry Permalink"="https://nuget.org/packages/$package/$newVersion"
    "Library Type"=$libraryType
    "Release Type"=$releaseType
    "Version Number"=$newVersion
}

Write-Host
Write-Host "Going to set the following fields:" -ForegroundColor Green

foreach ($field in $fields.Keys)
{
    Write-Host "    $field = $($fields[$field])"
}

$decision = $Host.UI.PromptForChoice("Updating work item https://dev.azure.com/azure-sdk/Release/_workitems/edit/$issueId", 'Are you sure you want to proceed?', @('&Yes'; '&No'), 0)

if ($decision -eq 0)
{
    az boards work-item update @commonParameter --id $issueId --state Active > $null
    foreach ($field in $fields.Keys)
    {
        az boards work-item update @commonParameter --id $issueId -f "$field=$($fields[$field])" > $null
    }
}

$changeLogEntry = Get-ChangeLogEntry -ChangeLogLocation "$packageDirectory/CHANGELOG.md" -VersionString $newVersion

$githubAnchor = $changeLogEntry.ReleaseTitle.Replace("## ", "").Replace(".", "").Replace("(", "").Replace(")", "").Replace(" ", "-")
Write-Host
Write-Host "Snippet for the centralized CHANGELOG:" -ForegroundColor Green
Write-Host "dotnet add package $package --version $newVersion"
Write-Host "### $package [Changelog](https://github.com/Azure/azure-sdk-for-net/blob/master/sdk/$serviceDirectory/$package/CHANGELOG.md#$githubAnchor)"
$changeLogEntry.ReleaseContent | Write-Host 

