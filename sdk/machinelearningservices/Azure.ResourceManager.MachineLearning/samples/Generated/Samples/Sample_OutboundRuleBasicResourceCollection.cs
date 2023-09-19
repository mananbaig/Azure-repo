// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.MachineLearning;
using Azure.ResourceManager.MachineLearning.Models;

namespace Azure.ResourceManager.MachineLearning.Samples
{
    public partial class Sample_OutboundRuleBasicResourceCollection
    {
        // List ManagedNetworkSettingsRule
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListManagedNetworkSettingsRule()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2023-06-01-preview/examples/ManagedNetwork/listRule.json
            // this example is just showing the usage of "ManagedNetworkSettingsRule_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningWorkspaceResource created on azure
            // for more information of creating MachineLearningWorkspaceResource, please refer to the document of MachineLearningWorkspaceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "aml-workspace-name";
            ResourceIdentifier machineLearningWorkspaceResourceId = MachineLearningWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            MachineLearningWorkspaceResource machineLearningWorkspace = client.GetMachineLearningWorkspaceResource(machineLearningWorkspaceResourceId);

            // get the collection of this OutboundRuleBasicResource
            OutboundRuleBasicResourceCollection collection = machineLearningWorkspace.GetOutboundRuleBasicResources();

            // invoke the operation and iterate over the result
            await foreach (OutboundRuleBasicResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                OutboundRuleBasicResourceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get ManagedNetworkSettingsRule
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetManagedNetworkSettingsRule()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2023-06-01-preview/examples/ManagedNetwork/getRule.json
            // this example is just showing the usage of "ManagedNetworkSettingsRule_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningWorkspaceResource created on azure
            // for more information of creating MachineLearningWorkspaceResource, please refer to the document of MachineLearningWorkspaceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "aml-workspace-name";
            ResourceIdentifier machineLearningWorkspaceResourceId = MachineLearningWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            MachineLearningWorkspaceResource machineLearningWorkspace = client.GetMachineLearningWorkspaceResource(machineLearningWorkspaceResourceId);

            // get the collection of this OutboundRuleBasicResource
            OutboundRuleBasicResourceCollection collection = machineLearningWorkspace.GetOutboundRuleBasicResources();

            // invoke the operation
            string ruleName = "some_string";
            OutboundRuleBasicResource result = await collection.GetAsync(ruleName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            OutboundRuleBasicResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get ManagedNetworkSettingsRule
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetManagedNetworkSettingsRule()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2023-06-01-preview/examples/ManagedNetwork/getRule.json
            // this example is just showing the usage of "ManagedNetworkSettingsRule_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningWorkspaceResource created on azure
            // for more information of creating MachineLearningWorkspaceResource, please refer to the document of MachineLearningWorkspaceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "aml-workspace-name";
            ResourceIdentifier machineLearningWorkspaceResourceId = MachineLearningWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            MachineLearningWorkspaceResource machineLearningWorkspace = client.GetMachineLearningWorkspaceResource(machineLearningWorkspaceResourceId);

            // get the collection of this OutboundRuleBasicResource
            OutboundRuleBasicResourceCollection collection = machineLearningWorkspace.GetOutboundRuleBasicResources();

            // invoke the operation
            string ruleName = "some_string";
            bool result = await collection.ExistsAsync(ruleName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // CreateOrUpdate ManagedNetworkSettingsRule
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateManagedNetworkSettingsRule()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2023-06-01-preview/examples/ManagedNetwork/createOrUpdateRule.json
            // this example is just showing the usage of "ManagedNetworkSettingsRule_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningWorkspaceResource created on azure
            // for more information of creating MachineLearningWorkspaceResource, please refer to the document of MachineLearningWorkspaceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "aml-workspace-name";
            ResourceIdentifier machineLearningWorkspaceResourceId = MachineLearningWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            MachineLearningWorkspaceResource machineLearningWorkspace = client.GetMachineLearningWorkspaceResource(machineLearningWorkspaceResourceId);

            // get the collection of this OutboundRuleBasicResource
            OutboundRuleBasicResourceCollection collection = machineLearningWorkspace.GetOutboundRuleBasicResources();

            // invoke the operation
            string ruleName = "some_string";
            OutboundRuleBasicResourceData data = new OutboundRuleBasicResourceData(new FqdnOutboundRule()
            {
                Destination = "some_string",
                Category = RuleCategory.UserDefined,
                Status = RuleStatus.Active,
            });
            ArmOperation<OutboundRuleBasicResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, ruleName, data);
            OutboundRuleBasicResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            OutboundRuleBasicResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
