﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading.Tasks;
using Azure.Core.TestFramework;
using NUnit.Framework;
using Azure.ResourceManager.Resources.Models;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Resources;
using System;
using Azure.ResourceManager.ConnectedVMwarevSphere.Tests.Helpers;

namespace Azure.ResourceManager.ConnectedVMwarevSphere.Tests
{
    public class HostTests : ConnectedVMwareTestBase
    {
        public HostTests(bool isAsync) : base(isAsync)
        {
        }

        private async Task<VMwareHostCollection> GetVMwareHostCollectionAsync()
        {
            var resourceGroup = await CreateResourceGroupAsync();
            return resourceGroup.GetVMwareHosts();
        }

        // CreateHost
        [TestCase]
        [RecordedTest]
        public async Task CreateOrUpdate_CreateHost()
        {
            // Generated from example definition: specification/connectedvmware/resource-manager/Microsoft.ConnectedVMwarevSphere/stable/2023-10-01/examples/CreateHost.json
            // this example is just showing the usage of "Hosts_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "204898ee-cd13-4332-b9d4-55ca5c25496d";
            string resourceGroupName = "azcli-test-rg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this VMwareHostResource
            VMwareHostCollection collection = resourceGroupResource.GetVMwareHosts();

            // invoke the operation
            string hostName = "10.150.178.208";
            VMwareHostData data = new VMwareHostData(new AzureLocation("East US"))
            {
                ExtendedLocation = new ExtendedLocation()
                {
                    ExtendedLocationType = "CustomLocation",
                    Name = "/subscriptions/204898ee-cd13-4332-b9d4-55ca5c25496d/resourcegroups/azcli-test-rg/providers/microsoft.extendedlocation/customlocations/azcli-test-cl",
                },
                InventoryItemId = "/subscriptions/204898ee-cd13-4332-b9d4-55ca5c25496d/resourceGroups/azcli-test-rg/providers/Microsoft.ConnectedVMwarevSphere/VCenters/azcli-test-vc/InventoryItems/host-1147412",
            };
            ArmOperation<VMwareHostResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, hostName, data);
            VMwareHostResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VMwareHostData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // GetHost
        [TestCase]
        [RecordedTest]
        public async Task Get_GetHost()
        {
            // Generated from example definition: specification/connectedvmware/resource-manager/Microsoft.ConnectedVMwarevSphere/stable/2023-10-01/examples/GetHost.json
            // this example is just showing the usage of "Hosts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "204898ee-cd13-4332-b9d4-55ca5c25496d";
            string resourceGroupName = "azcli-test-rg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this VMwareHostResource
            VMwareHostCollection collection = resourceGroupResource.GetVMwareHosts();

            // invoke the operation
            string hostName = "10.150.178.208";
            VMwareHostResource result = await collection.GetAsync(hostName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VMwareHostData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // GetHost
        [TestCase]
        [RecordedTest]
        public async Task Exists_GetHost()
        {
            // Generated from example definition: specification/connectedvmware/resource-manager/Microsoft.ConnectedVMwarevSphere/stable/2023-10-01/examples/GetHost.json
            // this example is just showing the usage of "Hosts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "204898ee-cd13-4332-b9d4-55ca5c25496d";
            string resourceGroupName = "azcli-test-rg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this VMwareHostResource
            VMwareHostCollection collection = resourceGroupResource.GetVMwareHosts();

            // invoke the operation
            string hostName = "10.150.178.208";
            bool result = await collection.ExistsAsync(hostName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // GetHost
        [TestCase]
        [RecordedTest]
        public async Task GetIfExists_GetHost()
        {
            // Generated from example definition: specification/connectedvmware/resource-manager/Microsoft.ConnectedVMwarevSphere/stable/2023-10-01/examples/GetHost.json
            // this example is just showing the usage of "Hosts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "204898ee-cd13-4332-b9d4-55ca5c25496d";
            string resourceGroupName = "azcli-test-rg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this VMwareHostResource
            VMwareHostCollection collection = resourceGroupResource.GetVMwareHosts();

            // invoke the operation
            string hostName = "10.150.178.208";
            NullableResponse<VMwareHostResource> response = await collection.GetIfExistsAsync(hostName);
            VMwareHostResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                VMwareHostData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // ListHostsByResourceGroup
        [TestCase]
        [RecordedTest]
        public async Task GetAll_ListHostsByResourceGroup()
        {
            // Generated from example definition: specification/connectedvmware/resource-manager/Microsoft.ConnectedVMwarevSphere/stable/2023-10-01/examples/ListHostsByResourceGroup.json
            // this example is just showing the usage of "Hosts_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "204898ee-cd13-4332-b9d4-55ca5c25496d";
            string resourceGroupName = "azcli-test-rg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this VMwareHostResource
            VMwareHostCollection collection = resourceGroupResource.GetVMwareHosts();

            // invoke the operation and iterate over the result
            await foreach (VMwareHostResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                VMwareHostData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
