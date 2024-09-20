// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Automation.Models;

namespace Azure.ResourceManager.Automation.Samples
{
    public partial class Sample_DscConfigurationResource
    {
        // Delete DSC Configuration
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteDSCConfiguration()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/stable/2019-06-01/examples/deleteDscConfiguration.json
            // this example is just showing the usage of "DscConfiguration_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DscConfigurationResource created on azure
            // for more information of creating DscConfigurationResource, please refer to the document of DscConfigurationResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg";
            string automationAccountName = "myAutomationAccount33";
            string configurationName = "TemplateBasic";
            ResourceIdentifier dscConfigurationResourceId = DscConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName, configurationName);
            DscConfigurationResource dscConfiguration = client.GetDscConfigurationResource(dscConfigurationResourceId);

            // invoke the operation
            await dscConfiguration.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Get a DSC Configuration
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetADSCConfiguration()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/stable/2019-06-01/examples/getDscConfiguration.json
            // this example is just showing the usage of "DscConfiguration_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DscConfigurationResource created on azure
            // for more information of creating DscConfigurationResource, please refer to the document of DscConfigurationResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg";
            string automationAccountName = "myAutomationAccount33";
            string configurationName = "TemplateBasic";
            ResourceIdentifier dscConfigurationResourceId = DscConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName, configurationName);
            DscConfigurationResource dscConfiguration = client.GetDscConfigurationResource(dscConfigurationResourceId);

            // invoke the operation
            DscConfigurationResource result = await dscConfiguration.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DscConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create or Update Configuration
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreateOrUpdateConfiguration()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/stable/2019-06-01/examples/updateDscConfiguration.json
            // this example is just showing the usage of "DscConfiguration_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DscConfigurationResource created on azure
            // for more information of creating DscConfigurationResource, please refer to the document of DscConfigurationResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg";
            string automationAccountName = "myAutomationAccount18";
            string configurationName = "SetupServer";
            ResourceIdentifier dscConfigurationResourceId = DscConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName, configurationName);
            DscConfigurationResource dscConfiguration = client.GetDscConfigurationResource(dscConfigurationResourceId);

            // invoke the operation
            DscConfigurationPatch patch = new DscConfigurationPatch()
            {
                Name = "SetupServer",
                Tags =
{
["Hello"] = "World",
},
            };
            DscConfigurationResource result = await dscConfiguration.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DscConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get DSC Configuration content
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetContent_GetDSCConfigurationContent()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/stable/2019-06-01/examples/getDscConfigurationContent.json
            // this example is just showing the usage of "DscConfiguration_GetContent" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DscConfigurationResource created on azure
            // for more information of creating DscConfigurationResource, please refer to the document of DscConfigurationResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg";
            string automationAccountName = "myAutomationAccount33";
            string configurationName = "ConfigName";
            ResourceIdentifier dscConfigurationResourceId = DscConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName, configurationName);
            DscConfigurationResource dscConfiguration = client.GetDscConfigurationResource(dscConfigurationResourceId);

            // invoke the operation
            string result = await dscConfiguration.GetContentAsync();

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
