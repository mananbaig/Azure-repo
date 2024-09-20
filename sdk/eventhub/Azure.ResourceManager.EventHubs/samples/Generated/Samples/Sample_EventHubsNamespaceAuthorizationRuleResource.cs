// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.EventHubs.Models;

namespace Azure.ResourceManager.EventHubs.Samples
{
    public partial class Sample_EventHubsNamespaceAuthorizationRuleResource
    {
        // NameSpaceAuthorizationRuleCreate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_NameSpaceAuthorizationRuleCreate()
        {
            // Generated from example definition: specification/eventhub/resource-manager/Microsoft.EventHub/stable/2024-01-01/examples/NameSpaces/EHNameSpaceAuthorizationRuleCreate.json
            // this example is just showing the usage of "Namespaces_CreateOrUpdateAuthorizationRule" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventHubsNamespaceAuthorizationRuleResource created on azure
            // for more information of creating EventHubsNamespaceAuthorizationRuleResource, please refer to the document of EventHubsNamespaceAuthorizationRuleResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            string resourceGroupName = "ArunMonocle";
            string namespaceName = "sdk-Namespace-2702";
            string authorizationRuleName = "sdk-Authrules-1746";
            ResourceIdentifier eventHubsNamespaceAuthorizationRuleResourceId = EventHubsNamespaceAuthorizationRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, authorizationRuleName);
            EventHubsNamespaceAuthorizationRuleResource eventHubsNamespaceAuthorizationRule = client.GetEventHubsNamespaceAuthorizationRuleResource(eventHubsNamespaceAuthorizationRuleResourceId);

            // invoke the operation
            EventHubsAuthorizationRuleData data = new EventHubsAuthorizationRuleData()
            {
                Rights =
{
EventHubsAccessRight.Listen,EventHubsAccessRight.Send
},
            };
            ArmOperation<EventHubsNamespaceAuthorizationRuleResource> lro = await eventHubsNamespaceAuthorizationRule.UpdateAsync(WaitUntil.Completed, data);
            EventHubsNamespaceAuthorizationRuleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            EventHubsAuthorizationRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // NameSpaceAuthorizationRuleDelete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_NameSpaceAuthorizationRuleDelete()
        {
            // Generated from example definition: specification/eventhub/resource-manager/Microsoft.EventHub/stable/2024-01-01/examples/NameSpaces/EHNameSpaceAuthorizationRuleDelete.json
            // this example is just showing the usage of "Namespaces_DeleteAuthorizationRule" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventHubsNamespaceAuthorizationRuleResource created on azure
            // for more information of creating EventHubsNamespaceAuthorizationRuleResource, please refer to the document of EventHubsNamespaceAuthorizationRuleResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            string resourceGroupName = "ArunMonocle";
            string namespaceName = "sdk-Namespace-8980";
            string authorizationRuleName = "sdk-Authrules-8929";
            ResourceIdentifier eventHubsNamespaceAuthorizationRuleResourceId = EventHubsNamespaceAuthorizationRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, authorizationRuleName);
            EventHubsNamespaceAuthorizationRuleResource eventHubsNamespaceAuthorizationRule = client.GetEventHubsNamespaceAuthorizationRuleResource(eventHubsNamespaceAuthorizationRuleResourceId);

            // invoke the operation
            await eventHubsNamespaceAuthorizationRule.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // NameSpaceAuthorizationRuleGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_NameSpaceAuthorizationRuleGet()
        {
            // Generated from example definition: specification/eventhub/resource-manager/Microsoft.EventHub/stable/2024-01-01/examples/NameSpaces/EHNameSpaceAuthorizationRuleGet.json
            // this example is just showing the usage of "Namespaces_GetAuthorizationRule" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventHubsNamespaceAuthorizationRuleResource created on azure
            // for more information of creating EventHubsNamespaceAuthorizationRuleResource, please refer to the document of EventHubsNamespaceAuthorizationRuleResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            string resourceGroupName = "ArunMonocle";
            string namespaceName = "sdk-Namespace-2702";
            string authorizationRuleName = "sdk-Authrules-1746";
            ResourceIdentifier eventHubsNamespaceAuthorizationRuleResourceId = EventHubsNamespaceAuthorizationRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, authorizationRuleName);
            EventHubsNamespaceAuthorizationRuleResource eventHubsNamespaceAuthorizationRule = client.GetEventHubsNamespaceAuthorizationRuleResource(eventHubsNamespaceAuthorizationRuleResourceId);

            // invoke the operation
            EventHubsNamespaceAuthorizationRuleResource result = await eventHubsNamespaceAuthorizationRule.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            EventHubsAuthorizationRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // NameSpaceAuthorizationRuleListKey
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetKeys_NameSpaceAuthorizationRuleListKey()
        {
            // Generated from example definition: specification/eventhub/resource-manager/Microsoft.EventHub/stable/2024-01-01/examples/NameSpaces/EHNameSpaceAuthorizationRuleListKey.json
            // this example is just showing the usage of "Namespaces_ListKeys" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventHubsNamespaceAuthorizationRuleResource created on azure
            // for more information of creating EventHubsNamespaceAuthorizationRuleResource, please refer to the document of EventHubsNamespaceAuthorizationRuleResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            string resourceGroupName = "ArunMonocle";
            string namespaceName = "sdk-Namespace-2702";
            string authorizationRuleName = "sdk-Authrules-1746";
            ResourceIdentifier eventHubsNamespaceAuthorizationRuleResourceId = EventHubsNamespaceAuthorizationRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, authorizationRuleName);
            EventHubsNamespaceAuthorizationRuleResource eventHubsNamespaceAuthorizationRule = client.GetEventHubsNamespaceAuthorizationRuleResource(eventHubsNamespaceAuthorizationRuleResourceId);

            // invoke the operation
            EventHubsAccessKeys result = await eventHubsNamespaceAuthorizationRule.GetKeysAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        // NameSpaceAuthorizationRuleRegenerateKey
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task RegenerateKeys_NameSpaceAuthorizationRuleRegenerateKey()
        {
            // Generated from example definition: specification/eventhub/resource-manager/Microsoft.EventHub/stable/2024-01-01/examples/NameSpaces/EHNameSpaceAuthorizationRuleRegenerateKey.json
            // this example is just showing the usage of "Namespaces_RegenerateKeys" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventHubsNamespaceAuthorizationRuleResource created on azure
            // for more information of creating EventHubsNamespaceAuthorizationRuleResource, please refer to the document of EventHubsNamespaceAuthorizationRuleResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            string resourceGroupName = "ArunMonocle";
            string namespaceName = "sdk-Namespace-8980";
            string authorizationRuleName = "sdk-Authrules-8929";
            ResourceIdentifier eventHubsNamespaceAuthorizationRuleResourceId = EventHubsNamespaceAuthorizationRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, authorizationRuleName);
            EventHubsNamespaceAuthorizationRuleResource eventHubsNamespaceAuthorizationRule = client.GetEventHubsNamespaceAuthorizationRuleResource(eventHubsNamespaceAuthorizationRuleResourceId);

            // invoke the operation
            EventHubsRegenerateAccessKeyContent content = new EventHubsRegenerateAccessKeyContent(EventHubsAccessKeyType.PrimaryKey);
            EventHubsAccessKeys result = await eventHubsNamespaceAuthorizationRule.RegenerateKeysAsync(content);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
