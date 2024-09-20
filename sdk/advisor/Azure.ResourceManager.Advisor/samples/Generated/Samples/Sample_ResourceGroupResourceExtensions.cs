// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Advisor.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Advisor.Samples
{
    public partial class Sample_ResourceGroupResourceExtensions
    {
        // GetConfigurations
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetConfigurations_GetConfigurations()
        {
            // Generated from example definition: specification/advisor/resource-manager/Microsoft.Advisor/stable/2020-01-01/examples/ListConfigurations.json
            // this example is just showing the usage of "Configurations_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroup = "resourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroup);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // invoke the operation and iterate over the result
            await foreach (ConfigData item in resourceGroupResource.GetConfigurationsAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // PutConfigurations
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateConfiguration_PutConfigurations()
        {
            // Generated from example definition: specification/advisor/resource-manager/Microsoft.Advisor/stable/2020-01-01/examples/CreateConfiguration.json
            // this example is just showing the usage of "Configurations_CreateInResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroup = "resourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroup);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // invoke the operation
            ConfigurationName configurationName = ConfigurationName.Default;
            ConfigData data = new ConfigData()
            {
                Exclude = true,
                LowCpuThreshold = CpuThreshold.Five,
                Digests =
{
new DigestConfig()
{
Name = "digestConfigName",
ActionGroupResourceId = "/subscriptions/subscriptionId/resourceGroups/resourceGroup/providers/microsoft.insights/actionGroups/actionGroupName",
Frequency = 30,
Categories =
{
Category.HighAvailability,Category.Security,Category.Performance,Category.Cost,Category.OperationalExcellence
},
Language = "en",
State = DigestConfigState.Active,
}
},
            };
            ConfigData result = await resourceGroupResource.CreateConfigurationAsync(configurationName, data);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
