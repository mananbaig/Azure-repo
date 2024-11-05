// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.HybridNetwork.Models;

namespace Azure.ResourceManager.HybridNetwork.Samples
{
    public partial class Sample_NetworkServiceDesignVersionResource
    {
        // Delete a network service design version
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteANetworkServiceDesignVersion()
        {
            // Generated from example definition: specification/hybridnetwork/resource-manager/Microsoft.HybridNetwork/stable/2023-09-01/examples/NetworkServiceDesignVersionDelete.json
            // this example is just showing the usage of "NetworkServiceDesignVersions_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkServiceDesignVersionResource created on azure
            // for more information of creating NetworkServiceDesignVersionResource, please refer to the document of NetworkServiceDesignVersionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string publisherName = "TestPublisher";
            string networkServiceDesignGroupName = "TestNetworkServiceDesignGroupName";
            string networkServiceDesignVersionName = "1.0.0";
            ResourceIdentifier networkServiceDesignVersionResourceId = NetworkServiceDesignVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, publisherName, networkServiceDesignGroupName, networkServiceDesignVersionName);
            NetworkServiceDesignVersionResource networkServiceDesignVersion = client.GetNetworkServiceDesignVersionResource(networkServiceDesignVersionResourceId);

            // invoke the operation
            await networkServiceDesignVersion.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Get a network service design version resource
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetANetworkServiceDesignVersionResource()
        {
            // Generated from example definition: specification/hybridnetwork/resource-manager/Microsoft.HybridNetwork/stable/2023-09-01/examples/NetworkServiceDesignVersionGet.json
            // this example is just showing the usage of "NetworkServiceDesignVersions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkServiceDesignVersionResource created on azure
            // for more information of creating NetworkServiceDesignVersionResource, please refer to the document of NetworkServiceDesignVersionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string publisherName = "TestPublisher";
            string networkServiceDesignGroupName = "TestNetworkServiceDesignGroupName";
            string networkServiceDesignVersionName = "1.0.0";
            ResourceIdentifier networkServiceDesignVersionResourceId = NetworkServiceDesignVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, publisherName, networkServiceDesignGroupName, networkServiceDesignVersionName);
            NetworkServiceDesignVersionResource networkServiceDesignVersion = client.GetNetworkServiceDesignVersionResource(networkServiceDesignVersionResourceId);

            // invoke the operation
            NetworkServiceDesignVersionResource result = await networkServiceDesignVersion.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkServiceDesignVersionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update the network service design version tags
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateTheNetworkServiceDesignVersionTags()
        {
            // Generated from example definition: specification/hybridnetwork/resource-manager/Microsoft.HybridNetwork/stable/2023-09-01/examples/NetworkServiceDesignVersionUpdateTags.json
            // this example is just showing the usage of "NetworkServiceDesignVersions_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkServiceDesignVersionResource created on azure
            // for more information of creating NetworkServiceDesignVersionResource, please refer to the document of NetworkServiceDesignVersionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string publisherName = "TestPublisher";
            string networkServiceDesignGroupName = "TestNetworkServiceDesignGroupName";
            string networkServiceDesignVersionName = "1.0.0";
            ResourceIdentifier networkServiceDesignVersionResourceId = NetworkServiceDesignVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, publisherName, networkServiceDesignGroupName, networkServiceDesignVersionName);
            NetworkServiceDesignVersionResource networkServiceDesignVersion = client.GetNetworkServiceDesignVersionResource(networkServiceDesignVersionResourceId);

            // invoke the operation
            TagsObject tagsObject = new TagsObject()
            {
                Tags =
{
["tag1"] = "value1",
["tag2"] = "value2",
},
            };
            NetworkServiceDesignVersionResource result = await networkServiceDesignVersion.UpdateAsync(tagsObject);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkServiceDesignVersionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update network service design version state
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task UpdateState_UpdateNetworkServiceDesignVersionState()
        {
            // Generated from example definition: specification/hybridnetwork/resource-manager/Microsoft.HybridNetwork/stable/2023-09-01/examples/NetworkServiceDesignVersionUpdateState.json
            // this example is just showing the usage of "NetworkServiceDesignVersions_UpdateState" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkServiceDesignVersionResource created on azure
            // for more information of creating NetworkServiceDesignVersionResource, please refer to the document of NetworkServiceDesignVersionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string publisherName = "TestPublisher";
            string networkServiceDesignGroupName = "TestNetworkServiceDesignGroupName";
            string networkServiceDesignVersionName = "1.0.0";
            ResourceIdentifier networkServiceDesignVersionResourceId = NetworkServiceDesignVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, publisherName, networkServiceDesignGroupName, networkServiceDesignVersionName);
            NetworkServiceDesignVersionResource networkServiceDesignVersion = client.GetNetworkServiceDesignVersionResource(networkServiceDesignVersionResourceId);

            // invoke the operation
            NetworkServiceDesignVersionUpdateState networkServiceDesignVersionUpdateState = new NetworkServiceDesignVersionUpdateState()
            {
                VersionState = VersionState.Active,
            };
            ArmOperation<NetworkServiceDesignVersionUpdateState> lro = await networkServiceDesignVersion.UpdateStateAsync(WaitUntil.Completed, networkServiceDesignVersionUpdateState);
            NetworkServiceDesignVersionUpdateState result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
