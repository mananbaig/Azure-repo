// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ContainerOrchestratorRuntime.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.ContainerOrchestratorRuntime.Samples
{
    public partial class Sample_ConnectedClusterLoadBalancerCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_LoadBalancersGet()
        {
            // Generated from example definition: 2024-03-01/LoadBalancers_Get.json
            // this example is just showing the usage of "LoadBalancer_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this ConnectedClusterLoadBalancerResource
            string resourceUri = "subscriptions/00000000-1111-2222-3333-444444444444/resourceGroups/example/providers/Microsoft.Kubernetes/connectedClusters/cluster1";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", resourceUri));
            ConnectedClusterLoadBalancerCollection collection = client.GetConnectedClusterLoadBalancers(scopeId);

            // invoke the operation
            string loadBalancerName = "testlb";
            ConnectedClusterLoadBalancerResource result = await collection.GetAsync(loadBalancerName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ConnectedClusterLoadBalancerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_LoadBalancersGet()
        {
            // Generated from example definition: 2024-03-01/LoadBalancers_Get.json
            // this example is just showing the usage of "LoadBalancer_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this ConnectedClusterLoadBalancerResource
            string resourceUri = "subscriptions/00000000-1111-2222-3333-444444444444/resourceGroups/example/providers/Microsoft.Kubernetes/connectedClusters/cluster1";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", resourceUri));
            ConnectedClusterLoadBalancerCollection collection = client.GetConnectedClusterLoadBalancers(scopeId);

            // invoke the operation
            string loadBalancerName = "testlb";
            bool result = await collection.ExistsAsync(loadBalancerName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_LoadBalancersGet()
        {
            // Generated from example definition: 2024-03-01/LoadBalancers_Get.json
            // this example is just showing the usage of "LoadBalancer_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this ConnectedClusterLoadBalancerResource
            string resourceUri = "subscriptions/00000000-1111-2222-3333-444444444444/resourceGroups/example/providers/Microsoft.Kubernetes/connectedClusters/cluster1";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", resourceUri));
            ConnectedClusterLoadBalancerCollection collection = client.GetConnectedClusterLoadBalancers(scopeId);

            // invoke the operation
            string loadBalancerName = "testlb";
            NullableResponse<ConnectedClusterLoadBalancerResource> response = await collection.GetIfExistsAsync(loadBalancerName);
            ConnectedClusterLoadBalancerResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ConnectedClusterLoadBalancerData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_LoadBalancersCreateOrUpdate()
        {
            // Generated from example definition: 2024-03-01/LoadBalancers_CreateOrUpdate.json
            // this example is just showing the usage of "LoadBalancer_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this ConnectedClusterLoadBalancerResource
            string resourceUri = "subscriptions/00000000-1111-2222-3333-444444444444/resourceGroups/example/providers/Microsoft.Kubernetes/connectedClusters/cluster1";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", resourceUri));
            ConnectedClusterLoadBalancerCollection collection = client.GetConnectedClusterLoadBalancers(scopeId);

            // invoke the operation
            string loadBalancerName = "testlb";
            ConnectedClusterLoadBalancerData data = new ConnectedClusterLoadBalancerData()
            {
                Properties = new ConnectedClusterLoadBalancerProperties(new string[]
            {
"192.168.50.1/24","192.168.51.2-192.168.51.10"
            }, AdvertiseMode.Arp)
                {
                    ServiceSelector =
{
["app"] = "frontend",
},
                },
            };
            ArmOperation<ConnectedClusterLoadBalancerResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, loadBalancerName, data);
            ConnectedClusterLoadBalancerResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ConnectedClusterLoadBalancerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_LoadBalancersList()
        {
            // Generated from example definition: 2024-03-01/LoadBalancers_List.json
            // this example is just showing the usage of "LoadBalancer_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this ConnectedClusterLoadBalancerResource
            string resourceUri = "subscriptions/00000000-1111-2222-3333-444444444444/resourceGroups/example/providers/Microsoft.Kubernetes/connectedClusters/cluster1";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", resourceUri));
            ConnectedClusterLoadBalancerCollection collection = client.GetConnectedClusterLoadBalancers(scopeId);

            // invoke the operation and iterate over the result
            await foreach (ConnectedClusterLoadBalancerResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ConnectedClusterLoadBalancerData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}
