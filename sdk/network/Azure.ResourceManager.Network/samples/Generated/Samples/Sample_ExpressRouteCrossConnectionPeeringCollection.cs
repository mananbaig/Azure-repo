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
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_ExpressRouteCrossConnectionPeeringCollection
    {
        // ExpressRouteCrossConnectionBgpPeeringList
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ExpressRouteCrossConnectionBgpPeeringList()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-05-01/examples/ExpressRouteCrossConnectionBgpPeeringList.json
            // this example is just showing the usage of "ExpressRouteCrossConnectionPeerings_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ExpressRouteCrossConnectionResource created on azure
            // for more information of creating ExpressRouteCrossConnectionResource, please refer to the document of ExpressRouteCrossConnectionResource
            string subscriptionId = "subid";
            string resourceGroupName = "CrossConnection-SiliconValley";
            string crossConnectionName = "<circuitServiceKey>";
            ResourceIdentifier expressRouteCrossConnectionResourceId = ExpressRouteCrossConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, crossConnectionName);
            ExpressRouteCrossConnectionResource expressRouteCrossConnection = client.GetExpressRouteCrossConnectionResource(expressRouteCrossConnectionResourceId);

            // get the collection of this ExpressRouteCrossConnectionPeeringResource
            ExpressRouteCrossConnectionPeeringCollection collection = expressRouteCrossConnection.GetExpressRouteCrossConnectionPeerings();

            // invoke the operation and iterate over the result
            await foreach (ExpressRouteCrossConnectionPeeringResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ExpressRouteCrossConnectionPeeringData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // GetExpressRouteCrossConnectionBgpPeering
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetExpressRouteCrossConnectionBgpPeering()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-05-01/examples/ExpressRouteCrossConnectionBgpPeeringGet.json
            // this example is just showing the usage of "ExpressRouteCrossConnectionPeerings_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ExpressRouteCrossConnectionResource created on azure
            // for more information of creating ExpressRouteCrossConnectionResource, please refer to the document of ExpressRouteCrossConnectionResource
            string subscriptionId = "subid";
            string resourceGroupName = "CrossConnection-SiliconValley";
            string crossConnectionName = "<circuitServiceKey>";
            ResourceIdentifier expressRouteCrossConnectionResourceId = ExpressRouteCrossConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, crossConnectionName);
            ExpressRouteCrossConnectionResource expressRouteCrossConnection = client.GetExpressRouteCrossConnectionResource(expressRouteCrossConnectionResourceId);

            // get the collection of this ExpressRouteCrossConnectionPeeringResource
            ExpressRouteCrossConnectionPeeringCollection collection = expressRouteCrossConnection.GetExpressRouteCrossConnectionPeerings();

            // invoke the operation
            string peeringName = "AzurePrivatePeering";
            ExpressRouteCrossConnectionPeeringResource result = await collection.GetAsync(peeringName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ExpressRouteCrossConnectionPeeringData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // GetExpressRouteCrossConnectionBgpPeering
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetExpressRouteCrossConnectionBgpPeering()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-05-01/examples/ExpressRouteCrossConnectionBgpPeeringGet.json
            // this example is just showing the usage of "ExpressRouteCrossConnectionPeerings_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ExpressRouteCrossConnectionResource created on azure
            // for more information of creating ExpressRouteCrossConnectionResource, please refer to the document of ExpressRouteCrossConnectionResource
            string subscriptionId = "subid";
            string resourceGroupName = "CrossConnection-SiliconValley";
            string crossConnectionName = "<circuitServiceKey>";
            ResourceIdentifier expressRouteCrossConnectionResourceId = ExpressRouteCrossConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, crossConnectionName);
            ExpressRouteCrossConnectionResource expressRouteCrossConnection = client.GetExpressRouteCrossConnectionResource(expressRouteCrossConnectionResourceId);

            // get the collection of this ExpressRouteCrossConnectionPeeringResource
            ExpressRouteCrossConnectionPeeringCollection collection = expressRouteCrossConnection.GetExpressRouteCrossConnectionPeerings();

            // invoke the operation
            string peeringName = "AzurePrivatePeering";
            bool result = await collection.ExistsAsync(peeringName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // ExpressRouteCrossConnectionBgpPeeringCreate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_ExpressRouteCrossConnectionBgpPeeringCreate()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-05-01/examples/ExpressRouteCrossConnectionBgpPeeringCreate.json
            // this example is just showing the usage of "ExpressRouteCrossConnectionPeerings_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ExpressRouteCrossConnectionResource created on azure
            // for more information of creating ExpressRouteCrossConnectionResource, please refer to the document of ExpressRouteCrossConnectionResource
            string subscriptionId = "subid";
            string resourceGroupName = "CrossConnection-SiliconValley";
            string crossConnectionName = "<circuitServiceKey>";
            ResourceIdentifier expressRouteCrossConnectionResourceId = ExpressRouteCrossConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, crossConnectionName);
            ExpressRouteCrossConnectionResource expressRouteCrossConnection = client.GetExpressRouteCrossConnectionResource(expressRouteCrossConnectionResourceId);

            // get the collection of this ExpressRouteCrossConnectionPeeringResource
            ExpressRouteCrossConnectionPeeringCollection collection = expressRouteCrossConnection.GetExpressRouteCrossConnectionPeerings();

            // invoke the operation
            string peeringName = "AzurePrivatePeering";
            ExpressRouteCrossConnectionPeeringData data = new ExpressRouteCrossConnectionPeeringData()
            {
                PeerASN = 200,
                PrimaryPeerAddressPrefix = "192.168.16.252/30",
                SecondaryPeerAddressPrefix = "192.168.18.252/30",
                VlanId = 200,
                IPv6PeeringConfig = new IPv6ExpressRouteCircuitPeeringConfig()
                {
                    PrimaryPeerAddressPrefix = "3FFE:FFFF:0:CD30::/126",
                    SecondaryPeerAddressPrefix = "3FFE:FFFF:0:CD30::4/126",
                },
            };
            ArmOperation<ExpressRouteCrossConnectionPeeringResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, peeringName, data);
            ExpressRouteCrossConnectionPeeringResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ExpressRouteCrossConnectionPeeringData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
