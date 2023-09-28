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
using Azure.ResourceManager.StorageSync;
using Azure.ResourceManager.StorageSync.Models;

namespace Azure.ResourceManager.StorageSync.Samples
{
    public partial class Sample_StorageSyncRegisteredServerCollection
    {
        // RegisteredServers_ListByStorageSyncService
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_RegisteredServersListByStorageSyncService()
        {
            // Generated from example definition: specification/storagesync/resource-manager/Microsoft.StorageSync/stable/2022-09-01/examples/RegisteredServers_ListByStorageSyncService.json
            // this example is just showing the usage of "RegisteredServers_ListByStorageSyncService" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this StorageSyncRegisteredServerResource
            StorageSyncRegisteredServerCollection collection = storageSyncService.GetStorageSyncRegisteredServers();

            // invoke the operation and iterate over the result
            await foreach (StorageSyncRegisteredServerResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                StorageSyncRegisteredServerData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // RegisteredServers_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_RegisteredServersGet()
        {
            // Generated from example definition: specification/storagesync/resource-manager/Microsoft.StorageSync/stable/2022-09-01/examples/RegisteredServers_Get.json
            // this example is just showing the usage of "RegisteredServers_Get" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this StorageSyncRegisteredServerResource
            StorageSyncRegisteredServerCollection collection = storageSyncService.GetStorageSyncRegisteredServers();

            // invoke the operation
            Guid serverId = Guid.Parse("080d4133-bdb5-40a0-96a0-71a6057bfe9a");
            StorageSyncRegisteredServerResource result = await collection.GetAsync(serverId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StorageSyncRegisteredServerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // RegisteredServers_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_RegisteredServersGet()
        {
            // Generated from example definition: specification/storagesync/resource-manager/Microsoft.StorageSync/stable/2022-09-01/examples/RegisteredServers_Get.json
            // this example is just showing the usage of "RegisteredServers_Get" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this StorageSyncRegisteredServerResource
            StorageSyncRegisteredServerCollection collection = storageSyncService.GetStorageSyncRegisteredServers();

            // invoke the operation
            Guid serverId = Guid.Parse("080d4133-bdb5-40a0-96a0-71a6057bfe9a");
            bool result = await collection.ExistsAsync(serverId);

            Console.WriteLine($"Succeeded: {result}");
        }

        // RegisteredServers_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_RegisteredServersGet()
        {
            // Generated from example definition: specification/storagesync/resource-manager/Microsoft.StorageSync/stable/2022-06-01/examples/RegisteredServers_Get.json
            // this example is just showing the usage of "RegisteredServers_Get" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this StorageSyncRegisteredServerResource
            StorageSyncRegisteredServerCollection collection = storageSyncService.GetStorageSyncRegisteredServers();

            // invoke the operation
            Guid serverId = Guid.Parse("080d4133-bdb5-40a0-96a0-71a6057bfe9a");
            NullableResponse<StorageSyncRegisteredServerResource> response = await collection.GetIfExistsAsync(serverId);
            StorageSyncRegisteredServerResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                StorageSyncRegisteredServerData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // RegisteredServers_Create
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_RegisteredServersCreate()
        {
            // Generated from example definition: specification/storagesync/resource-manager/Microsoft.StorageSync/stable/2022-09-01/examples/RegisteredServers_Create.json
            // this example is just showing the usage of "RegisteredServers_Create" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this StorageSyncRegisteredServerResource
            StorageSyncRegisteredServerCollection collection = storageSyncService.GetStorageSyncRegisteredServers();

            // invoke the operation
            Guid serverId = Guid.Parse("080d4133-bdb5-40a0-96a0-71a6057bfe9a");
            StorageSyncRegisteredServerCreateOrUpdateContent content = new StorageSyncRegisteredServerCreateOrUpdateContent()
            {
                ServerCertificate = BinaryData.FromString("MIIDFjCCAf6gAwIBAgIQQS+DS8uhc4VNzUkTw7wbRjANBgkqhkiG9w0BAQ0FADAzMTEwLwYDVQQDEyhhbmt1c2hiLXByb2QzLnJlZG1vbmQuY29ycC5taWNyb3NvZnQuY29tMB4XDTE3MDgwMzE3MDQyNFoXDTE4MDgwNDE3MDQyNFowMzExMC8GA1UEAxMoYW5rdXNoYi1wcm9kMy5yZWRtb25kLmNvcnAubWljcm9zb2Z0LmNvbTCCASIwDQYJKoZIhvcNAQEBBQADggEPADCCAQoCggEBALDRvV4gmsIy6jGDPiHsXmvgVP749NNP7DopdlbHaNhjFmYINHl0uWylyaZmgJrROt2mnxN/zEyJtGnqYHlzUr4xvGq/qV5pqgdB9tag/sw9i22gfe9PRZ0FmSOZnXMbLYgLiDFqLtut5gHcOuWMj03YnkfoBEKlFBxWbagvW2yxz/Sxi9OVSJOKCaXra0RpcIHrO/KFl6ho2eE1/7Ykmfa8hZvSdoPd5gHdLiQcMB/pxq+mWp1fI6c8vFZoDu7Atn+NXTzYPKUxKzaisF12TsaKpohUsJpbB3Wocb0F5frn614D2pg14ERB5otjAMWw1m65csQWPI6dP8KIYe0+QPkCAwEAAaMmMCQwIgYDVR0lAQH/BBgwFgYIKwYBBQUHAwIGCisGAQQBgjcKAwwwDQYJKoZIhvcNAQENBQADggEBAA4RhVIBkw34M1RwakJgHvtjsOFxF1tVQA941NtLokx1l2Z8+GFQkcG4xpZSt+UN6wLerdCbnNhtkCErWUDeaT0jxk4g71Ofex7iM04crT4iHJr8mi96/XnhnkTUs+GDk12VgdeeNEczMZz+8Mxw9dJ5NCnYgTwO0SzGlclRsDvjzkLo8rh2ZG6n/jKrEyNXXo+hOqhupij0QbRP2Tvexdfw201kgN1jdZify8XzJ8Oi0bTS0KpJf2pNPOlooK2bjMUei9ANtEdXwwfVZGWvVh6tJjdv6k14wWWJ1L7zhA1IIVb1J+sQUzJji5iX0DrezjTz1Fg+gAzITaA/WsuujlM="),
                AgentVersion = "1.0.277.0",
                ServerOSVersion = "10.0.14393.0",
                ServerRole = "Standalone",
                ServerId = Guid.Parse("080d4133-bdb5-40a0-96a0-71a6057bfe9a"),
                FriendlyName = "afscv-2304-139",
            };
            ArmOperation<StorageSyncRegisteredServerResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, serverId, content);
            StorageSyncRegisteredServerResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StorageSyncRegisteredServerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
