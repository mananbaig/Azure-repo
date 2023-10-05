// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.StorageSync;
using Azure.ResourceManager.StorageSync.Models;

namespace Azure.ResourceManager.StorageSync.Samples
{
    public partial class Sample_StorageSyncGroupCollection
    {
        // SyncGroups_ListByStorageSyncService
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_SyncGroupsListByStorageSyncService()
        {
            // Generated from example definition: specification/storagesync/resource-manager/Microsoft.StorageSync/stable/2022-09-01/examples/SyncGroups_ListByStorageSyncService.json
            // this example is just showing the usage of "SyncGroups_ListByStorageSyncService" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StorageSyncServiceResource created on azure
            // for more information of creating StorageSyncServiceResource, please refer to the document of StorageSyncServiceResource
            string subscriptionId = "52b8da2f-61e0-4a1f-8dde-336911f367fb";
            string resourceGroupName = "SampleResourceGroup_1";
            string storageSyncServiceName = "SampleStorageSyncService_1";
            ResourceIdentifier storageSyncServiceResourceId = StorageSyncServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, storageSyncServiceName);
            StorageSyncServiceResource storageSyncService = client.GetStorageSyncServiceResource(storageSyncServiceResourceId);

            // get the collection of this StorageSyncGroupResource
            StorageSyncGroupCollection collection = storageSyncService.GetStorageSyncGroups();

            // invoke the operation and iterate over the result
            await foreach (StorageSyncGroupResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                StorageSyncGroupData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // SyncGroups_Create
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_SyncGroupsCreate()
        {
            // Generated from example definition: specification/storagesync/resource-manager/Microsoft.StorageSync/stable/2022-09-01/examples/SyncGroups_Create.json
            // this example is just showing the usage of "SyncGroups_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StorageSyncServiceResource created on azure
            // for more information of creating StorageSyncServiceResource, please refer to the document of StorageSyncServiceResource
            string subscriptionId = "52b8da2f-61e0-4a1f-8dde-336911f367fb";
            string resourceGroupName = "SampleResourceGroup_1";
            string storageSyncServiceName = "SampleStorageSyncService_1";
            ResourceIdentifier storageSyncServiceResourceId = StorageSyncServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, storageSyncServiceName);
            StorageSyncServiceResource storageSyncService = client.GetStorageSyncServiceResource(storageSyncServiceResourceId);

            // get the collection of this StorageSyncGroupResource
            StorageSyncGroupCollection collection = storageSyncService.GetStorageSyncGroups();

            // invoke the operation
            string syncGroupName = "SampleSyncGroup_1";
            StorageSyncGroupCreateOrUpdateContent content = new StorageSyncGroupCreateOrUpdateContent()
            {
                Properties = BinaryData.FromObjectAsJson(new Dictionary<string, object>()
                {
                }),
            };
            ArmOperation<StorageSyncGroupResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, syncGroupName, content);
            StorageSyncGroupResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StorageSyncGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // SyncGroups_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_SyncGroupsGet()
        {
            // Generated from example definition: specification/storagesync/resource-manager/Microsoft.StorageSync/stable/2022-09-01/examples/SyncGroups_Get.json
            // this example is just showing the usage of "SyncGroups_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StorageSyncServiceResource created on azure
            // for more information of creating StorageSyncServiceResource, please refer to the document of StorageSyncServiceResource
            string subscriptionId = "52b8da2f-61e0-4a1f-8dde-336911f367fb";
            string resourceGroupName = "SampleResourceGroup_1";
            string storageSyncServiceName = "SampleStorageSyncService_1";
            ResourceIdentifier storageSyncServiceResourceId = StorageSyncServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, storageSyncServiceName);
            StorageSyncServiceResource storageSyncService = client.GetStorageSyncServiceResource(storageSyncServiceResourceId);

            // get the collection of this StorageSyncGroupResource
            StorageSyncGroupCollection collection = storageSyncService.GetStorageSyncGroups();

            // invoke the operation
            string syncGroupName = "SampleSyncGroup_1";
            StorageSyncGroupResource result = await collection.GetAsync(syncGroupName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StorageSyncGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // SyncGroups_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_SyncGroupsGet()
        {
            // Generated from example definition: specification/storagesync/resource-manager/Microsoft.StorageSync/stable/2022-09-01/examples/SyncGroups_Get.json
            // this example is just showing the usage of "SyncGroups_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StorageSyncServiceResource created on azure
            // for more information of creating StorageSyncServiceResource, please refer to the document of StorageSyncServiceResource
            string subscriptionId = "52b8da2f-61e0-4a1f-8dde-336911f367fb";
            string resourceGroupName = "SampleResourceGroup_1";
            string storageSyncServiceName = "SampleStorageSyncService_1";
            ResourceIdentifier storageSyncServiceResourceId = StorageSyncServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, storageSyncServiceName);
            StorageSyncServiceResource storageSyncService = client.GetStorageSyncServiceResource(storageSyncServiceResourceId);

            // get the collection of this StorageSyncGroupResource
            StorageSyncGroupCollection collection = storageSyncService.GetStorageSyncGroups();

            // invoke the operation
            string syncGroupName = "SampleSyncGroup_1";
            bool result = await collection.ExistsAsync(syncGroupName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // SyncGroups_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_SyncGroupsGet()
        {
            // Generated from example definition: specification/storagesync/resource-manager/Microsoft.StorageSync/stable/2022-09-01/examples/SyncGroups_Get.json
            // this example is just showing the usage of "SyncGroups_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StorageSyncServiceResource created on azure
            // for more information of creating StorageSyncServiceResource, please refer to the document of StorageSyncServiceResource
            string subscriptionId = "52b8da2f-61e0-4a1f-8dde-336911f367fb";
            string resourceGroupName = "SampleResourceGroup_1";
            string storageSyncServiceName = "SampleStorageSyncService_1";
            ResourceIdentifier storageSyncServiceResourceId = StorageSyncServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, storageSyncServiceName);
            StorageSyncServiceResource storageSyncService = client.GetStorageSyncServiceResource(storageSyncServiceResourceId);

            // get the collection of this StorageSyncGroupResource
            StorageSyncGroupCollection collection = storageSyncService.GetStorageSyncGroups();

            // invoke the operation
            string syncGroupName = "SampleSyncGroup_1";
            NullableResponse<StorageSyncGroupResource> response = await collection.GetIfExistsAsync(syncGroupName);
            StorageSyncGroupResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                StorageSyncGroupData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
