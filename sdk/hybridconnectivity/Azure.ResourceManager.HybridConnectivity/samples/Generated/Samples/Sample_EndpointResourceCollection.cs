// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.HybridConnectivity.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.HybridConnectivity.Samples
{
    public partial class Sample_EndpointResourceCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_HybridConnectivityEndpointsPutCustom()
        {
            // Generated from example definition: specification/hybridconnectivity/resource-manager/Microsoft.HybridConnectivity/stable/2024-12-01/examples/EndpointsPutCustom.json
            // this example is just showing the usage of "Endpoints_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // get the collection of this EndpointResource
            string scope = "subscriptions/f5bcc1d9-23af-4ae9-aca1-041d0f593a63/resourceGroups/hybridRG/providers/Microsoft.HybridCompute/machines/testMachine";
            EndpointResourceCollection collection = client.GetEndpointResources(new ResourceIdentifier(scope));

            // invoke the operation
            string endpointName = "custom";
            EndpointResourceData data = new EndpointResourceData
            {
                Properties = new HybridConnectivityEndpointProperties(EndpointType.Custom)
                {
                    ResourceId = new ResourceIdentifier("/subscriptions/f5bcc1d9-23af-4ae9-aca1-041d0f593a63/resourceGroups/hybridRG/providers/Microsoft.Relay/namespaces/custom-relay-namespace"),
                },
            };
            ArmOperation<EndpointResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, endpointName, data);
            EndpointResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            EndpointResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_HybridConnectivityEndpointsPutDefault()
        {
            // Generated from example definition: specification/hybridconnectivity/resource-manager/Microsoft.HybridConnectivity/stable/2024-12-01/examples/EndpointsPutDefault.json
            // this example is just showing the usage of "Endpoints_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // get the collection of this EndpointResource
            string scope = "subscriptions/f5bcc1d9-23af-4ae9-aca1-041d0f593a63/resourceGroups/hybridRG/providers/Microsoft.HybridCompute/machines/testMachine";
            EndpointResourceCollection collection = client.GetEndpointResources(new ResourceIdentifier(scope));

            // invoke the operation
            string endpointName = "default";
            EndpointResourceData data = new EndpointResourceData
            {
                Properties = new HybridConnectivityEndpointProperties(EndpointType.Default),
            };
            ArmOperation<EndpointResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, endpointName, data);
            EndpointResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            EndpointResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_HybridConnectivityEndpointsGetCustom()
        {
            // Generated from example definition: specification/hybridconnectivity/resource-manager/Microsoft.HybridConnectivity/stable/2024-12-01/examples/EndpointsGetCustom.json
            // this example is just showing the usage of "Endpoints_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // get the collection of this EndpointResource
            string scope = "subscriptions/f5bcc1d9-23af-4ae9-aca1-041d0f593a63/resourceGroups/hybridRG/providers/Microsoft.HybridCompute/machines/testMachine";
            EndpointResourceCollection collection = client.GetEndpointResources(new ResourceIdentifier(scope));

            // invoke the operation
            string endpointName = "custom";
            EndpointResource result = await collection.GetAsync(endpointName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            EndpointResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_HybridConnectivityEndpointsGetDefault()
        {
            // Generated from example definition: specification/hybridconnectivity/resource-manager/Microsoft.HybridConnectivity/stable/2024-12-01/examples/EndpointsGetDefault.json
            // this example is just showing the usage of "Endpoints_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // get the collection of this EndpointResource
            string scope = "subscriptions/f5bcc1d9-23af-4ae9-aca1-041d0f593a63/resourceGroups/hybridRG/providers/Microsoft.HybridCompute/machines/testMachine";
            EndpointResourceCollection collection = client.GetEndpointResources(new ResourceIdentifier(scope));

            // invoke the operation
            string endpointName = "default";
            EndpointResource result = await collection.GetAsync(endpointName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            EndpointResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_HybridConnectivityEndpointsGet()
        {
            // Generated from example definition: specification/hybridconnectivity/resource-manager/Microsoft.HybridConnectivity/stable/2024-12-01/examples/EndpointsList.json
            // this example is just showing the usage of "Endpoints_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // get the collection of this EndpointResource
            string scope = "subscriptions/f5bcc1d9-23af-4ae9-aca1-041d0f593a63/resourceGroups/hybridRG/providers/Microsoft.HybridCompute/machines/testMachine";
            EndpointResourceCollection collection = client.GetEndpointResources(new ResourceIdentifier(scope));

            // invoke the operation and iterate over the result
            await foreach (EndpointResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                EndpointResourceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_HybridConnectivityEndpointsGetCustom()
        {
            // Generated from example definition: specification/hybridconnectivity/resource-manager/Microsoft.HybridConnectivity/stable/2024-12-01/examples/EndpointsGetCustom.json
            // this example is just showing the usage of "Endpoints_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // get the collection of this EndpointResource
            string scope = "subscriptions/f5bcc1d9-23af-4ae9-aca1-041d0f593a63/resourceGroups/hybridRG/providers/Microsoft.HybridCompute/machines/testMachine";
            EndpointResourceCollection collection = client.GetEndpointResources(new ResourceIdentifier(scope));

            // invoke the operation
            string endpointName = "custom";
            bool result = await collection.ExistsAsync(endpointName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_HybridConnectivityEndpointsGetDefault()
        {
            // Generated from example definition: specification/hybridconnectivity/resource-manager/Microsoft.HybridConnectivity/stable/2024-12-01/examples/EndpointsGetDefault.json
            // this example is just showing the usage of "Endpoints_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // get the collection of this EndpointResource
            string scope = "subscriptions/f5bcc1d9-23af-4ae9-aca1-041d0f593a63/resourceGroups/hybridRG/providers/Microsoft.HybridCompute/machines/testMachine";
            EndpointResourceCollection collection = client.GetEndpointResources(new ResourceIdentifier(scope));

            // invoke the operation
            string endpointName = "default";
            bool result = await collection.ExistsAsync(endpointName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_HybridConnectivityEndpointsGetCustom()
        {
            // Generated from example definition: specification/hybridconnectivity/resource-manager/Microsoft.HybridConnectivity/stable/2024-12-01/examples/EndpointsGetCustom.json
            // this example is just showing the usage of "Endpoints_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // get the collection of this EndpointResource
            string scope = "subscriptions/f5bcc1d9-23af-4ae9-aca1-041d0f593a63/resourceGroups/hybridRG/providers/Microsoft.HybridCompute/machines/testMachine";
            EndpointResourceCollection collection = client.GetEndpointResources(new ResourceIdentifier(scope));

            // invoke the operation
            string endpointName = "custom";
            NullableResponse<EndpointResource> response = await collection.GetIfExistsAsync(endpointName);
            EndpointResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                EndpointResourceData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_HybridConnectivityEndpointsGetDefault()
        {
            // Generated from example definition: specification/hybridconnectivity/resource-manager/Microsoft.HybridConnectivity/stable/2024-12-01/examples/EndpointsGetDefault.json
            // this example is just showing the usage of "Endpoints_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // get the collection of this EndpointResource
            string scope = "subscriptions/f5bcc1d9-23af-4ae9-aca1-041d0f593a63/resourceGroups/hybridRG/providers/Microsoft.HybridCompute/machines/testMachine";
            EndpointResourceCollection collection = client.GetEndpointResources(new ResourceIdentifier(scope));

            // invoke the operation
            string endpointName = "default";
            NullableResponse<EndpointResource> response = await collection.GetIfExistsAsync(endpointName);
            EndpointResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                EndpointResourceData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
