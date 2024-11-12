// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.OperationalInsights.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.OperationalInsights.Samples
{
    public partial class Sample_OperationalInsightsLinkedStorageAccountsCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_LinkedStorageAccountsCreate()
        {
            // Generated from example definition: specification/operationalinsights/resource-manager/Microsoft.OperationalInsights/stable/2020-08-01/examples/LinkedStorageAccountsCreate.json
            // this example is just showing the usage of "LinkedStorageAccounts_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this OperationalInsightsWorkspaceResource created on azure
            // for more information of creating OperationalInsightsWorkspaceResource, please refer to the document of OperationalInsightsWorkspaceResource
            string subscriptionId = "00000000-0000-0000-0000-00000000000";
            string resourceGroupName = "mms-eus";
            string workspaceName = "testLinkStorageAccountsWS";
            ResourceIdentifier operationalInsightsWorkspaceResourceId = OperationalInsightsWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            OperationalInsightsWorkspaceResource operationalInsightsWorkspace = client.GetOperationalInsightsWorkspaceResource(operationalInsightsWorkspaceResourceId);

            // get the collection of this OperationalInsightsLinkedStorageAccountsResource
            OperationalInsightsLinkedStorageAccountsCollection collection = operationalInsightsWorkspace.GetAllOperationalInsightsLinkedStorageAccounts();

            // invoke the operation
            OperationalInsightsDataSourceType dataSourceType = OperationalInsightsDataSourceType.CustomLogs;
            OperationalInsightsLinkedStorageAccountsData data = new OperationalInsightsLinkedStorageAccountsData()
            {
                StorageAccountIds =
{
new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-00000000000/resourceGroups/mms-eus/providers/Microsoft.Storage/storageAccounts/testStorageA"),new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-00000000000/resourceGroups/mms-eus/providers/Microsoft.Storage/storageAccounts/testStorageB")
},
            };
            ArmOperation<OperationalInsightsLinkedStorageAccountsResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, dataSourceType, data);
            OperationalInsightsLinkedStorageAccountsResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            OperationalInsightsLinkedStorageAccountsData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_LinkedStorageAccountsGet()
        {
            // Generated from example definition: specification/operationalinsights/resource-manager/Microsoft.OperationalInsights/stable/2020-08-01/examples/LinkedStorageAccountsGet.json
            // this example is just showing the usage of "LinkedStorageAccounts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this OperationalInsightsWorkspaceResource created on azure
            // for more information of creating OperationalInsightsWorkspaceResource, please refer to the document of OperationalInsightsWorkspaceResource
            string subscriptionId = "00000000-0000-0000-0000-00000000000";
            string resourceGroupName = "mms-eus";
            string workspaceName = "testLinkStorageAccountsWS";
            ResourceIdentifier operationalInsightsWorkspaceResourceId = OperationalInsightsWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            OperationalInsightsWorkspaceResource operationalInsightsWorkspace = client.GetOperationalInsightsWorkspaceResource(operationalInsightsWorkspaceResourceId);

            // get the collection of this OperationalInsightsLinkedStorageAccountsResource
            OperationalInsightsLinkedStorageAccountsCollection collection = operationalInsightsWorkspace.GetAllOperationalInsightsLinkedStorageAccounts();

            // invoke the operation
            OperationalInsightsDataSourceType dataSourceType = OperationalInsightsDataSourceType.CustomLogs;
            OperationalInsightsLinkedStorageAccountsResource result = await collection.GetAsync(dataSourceType);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            OperationalInsightsLinkedStorageAccountsData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_LinkedStorageAccountsGet()
        {
            // Generated from example definition: specification/operationalinsights/resource-manager/Microsoft.OperationalInsights/stable/2020-08-01/examples/LinkedStorageAccountsGet.json
            // this example is just showing the usage of "LinkedStorageAccounts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this OperationalInsightsWorkspaceResource created on azure
            // for more information of creating OperationalInsightsWorkspaceResource, please refer to the document of OperationalInsightsWorkspaceResource
            string subscriptionId = "00000000-0000-0000-0000-00000000000";
            string resourceGroupName = "mms-eus";
            string workspaceName = "testLinkStorageAccountsWS";
            ResourceIdentifier operationalInsightsWorkspaceResourceId = OperationalInsightsWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            OperationalInsightsWorkspaceResource operationalInsightsWorkspace = client.GetOperationalInsightsWorkspaceResource(operationalInsightsWorkspaceResourceId);

            // get the collection of this OperationalInsightsLinkedStorageAccountsResource
            OperationalInsightsLinkedStorageAccountsCollection collection = operationalInsightsWorkspace.GetAllOperationalInsightsLinkedStorageAccounts();

            // invoke the operation
            OperationalInsightsDataSourceType dataSourceType = OperationalInsightsDataSourceType.CustomLogs;
            bool result = await collection.ExistsAsync(dataSourceType);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_LinkedStorageAccountsGet()
        {
            // Generated from example definition: specification/operationalinsights/resource-manager/Microsoft.OperationalInsights/stable/2020-08-01/examples/LinkedStorageAccountsGet.json
            // this example is just showing the usage of "LinkedStorageAccounts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this OperationalInsightsWorkspaceResource created on azure
            // for more information of creating OperationalInsightsWorkspaceResource, please refer to the document of OperationalInsightsWorkspaceResource
            string subscriptionId = "00000000-0000-0000-0000-00000000000";
            string resourceGroupName = "mms-eus";
            string workspaceName = "testLinkStorageAccountsWS";
            ResourceIdentifier operationalInsightsWorkspaceResourceId = OperationalInsightsWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            OperationalInsightsWorkspaceResource operationalInsightsWorkspace = client.GetOperationalInsightsWorkspaceResource(operationalInsightsWorkspaceResourceId);

            // get the collection of this OperationalInsightsLinkedStorageAccountsResource
            OperationalInsightsLinkedStorageAccountsCollection collection = operationalInsightsWorkspace.GetAllOperationalInsightsLinkedStorageAccounts();

            // invoke the operation
            OperationalInsightsDataSourceType dataSourceType = OperationalInsightsDataSourceType.CustomLogs;
            NullableResponse<OperationalInsightsLinkedStorageAccountsResource> response = await collection.GetIfExistsAsync(dataSourceType);
            OperationalInsightsLinkedStorageAccountsResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                OperationalInsightsLinkedStorageAccountsData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_GetsListOfLinkedStorageAccountsOnAWorkspace()
        {
            // Generated from example definition: specification/operationalinsights/resource-manager/Microsoft.OperationalInsights/stable/2020-08-01/examples/LinkedStorageAccountsListByWorkspace.json
            // this example is just showing the usage of "LinkedStorageAccounts_ListByWorkspace" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this OperationalInsightsWorkspaceResource created on azure
            // for more information of creating OperationalInsightsWorkspaceResource, please refer to the document of OperationalInsightsWorkspaceResource
            string subscriptionId = "00000000-0000-0000-0000-00000000000";
            string resourceGroupName = "mms-eus";
            string workspaceName = "testLinkStorageAccountsWS";
            ResourceIdentifier operationalInsightsWorkspaceResourceId = OperationalInsightsWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            OperationalInsightsWorkspaceResource operationalInsightsWorkspace = client.GetOperationalInsightsWorkspaceResource(operationalInsightsWorkspaceResourceId);

            // get the collection of this OperationalInsightsLinkedStorageAccountsResource
            OperationalInsightsLinkedStorageAccountsCollection collection = operationalInsightsWorkspace.GetAllOperationalInsightsLinkedStorageAccounts();

            // invoke the operation and iterate over the result
            await foreach (OperationalInsightsLinkedStorageAccountsResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                OperationalInsightsLinkedStorageAccountsData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}
