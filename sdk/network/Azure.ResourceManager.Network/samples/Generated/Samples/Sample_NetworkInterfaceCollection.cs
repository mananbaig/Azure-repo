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
using Azure.ResourceManager.Network;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_NetworkInterfaceCollection
    {
        // Get network interface
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetNetworkInterface()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/NetworkInterfaceGet.json
            // this example is just showing the usage of "NetworkInterfaces_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this NetworkInterfaceResource
            NetworkInterfaceCollection collection = resourceGroupResource.GetNetworkInterfaces();

            // invoke the operation
            string networkInterfaceName = "test-nic";
            NetworkInterfaceResource result = await collection.GetAsync(networkInterfaceName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkInterfaceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get network interface
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetNetworkInterface()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/NetworkInterfaceGet.json
            // this example is just showing the usage of "NetworkInterfaces_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this NetworkInterfaceResource
            NetworkInterfaceCollection collection = resourceGroupResource.GetNetworkInterfaces();

            // invoke the operation
            string networkInterfaceName = "test-nic";
            bool result = await collection.ExistsAsync(networkInterfaceName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Create network interface
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateNetworkInterface()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/NetworkInterfaceCreate.json
            // this example is just showing the usage of "NetworkInterfaces_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this NetworkInterfaceResource
            NetworkInterfaceCollection collection = resourceGroupResource.GetNetworkInterfaces();

            // invoke the operation
            string networkInterfaceName = "test-nic";
            NetworkInterfaceData data = new NetworkInterfaceData()
            {
                IPConfigurations =
{
new NetworkInterfaceIPConfigurationData()
{
Subnet = new SubnetData()
{
Id = new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/virtualNetworks/rg1-vnet/subnets/default"),
},
PublicIPAddress = new PublicIPAddressData()
{
Id = new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/publicIPAddresses/test-ip"),
},
Name = "ipconfig1",
}
},
                EnableAcceleratedNetworking = true,
                DisableTcpStateTracking = true,
                Location = new AzureLocation("eastus"),
            };
            ArmOperation<NetworkInterfaceResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, networkInterfaceName, data);
            NetworkInterfaceResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkInterfaceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create network interface with Gateway Load Balancer Consumer configured
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateNetworkInterfaceWithGatewayLoadBalancerConsumerConfigured()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/NetworkInterfaceCreateGatewayLoadBalancerConsumer.json
            // this example is just showing the usage of "NetworkInterfaces_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this NetworkInterfaceResource
            NetworkInterfaceCollection collection = resourceGroupResource.GetNetworkInterfaces();

            // invoke the operation
            string networkInterfaceName = "test-nic";
            NetworkInterfaceData data = new NetworkInterfaceData()
            {
                IPConfigurations =
{
new NetworkInterfaceIPConfigurationData()
{
GatewayLoadBalancerId = new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/loadBalancers/lb/frontendIPConfigurations/fe-lb-provider"),
Subnet = new SubnetData()
{
Id = new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/virtualNetworks/rg1-vnet/subnets/default"),
},
PublicIPAddress = new PublicIPAddressData()
{
Id = new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/publicIPAddresses/test-ip"),
},
Name = "ipconfig1",
}
},
                EnableAcceleratedNetworking = true,
                Location = new AzureLocation("eastus"),
            };
            ArmOperation<NetworkInterfaceResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, networkInterfaceName, data);
            NetworkInterfaceResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkInterfaceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // List network interfaces in resource group
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListNetworkInterfacesInResourceGroup()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/NetworkInterfaceList.json
            // this example is just showing the usage of "NetworkInterfaces_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this NetworkInterfaceResource
            NetworkInterfaceCollection collection = resourceGroupResource.GetNetworkInterfaces();

            // invoke the operation and iterate over the result
            await foreach (NetworkInterfaceResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetworkInterfaceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
