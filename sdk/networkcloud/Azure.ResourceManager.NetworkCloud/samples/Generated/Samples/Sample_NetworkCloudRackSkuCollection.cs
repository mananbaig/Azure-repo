// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.NetworkCloud;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.NetworkCloud.Samples
{
    public partial class Sample_NetworkCloudRackSkuCollection
    {
        // List rack SKUs for subscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListRackSKUsForSubscription()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/stable/2023-07-01/examples/RackSkus_ListBySubscription.json
            // this example is just showing the usage of "RackSkus_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this NetworkCloudRackSkuResource
            NetworkCloudRackSkuCollection collection = subscriptionResource.GetNetworkCloudRackSkus();

            // invoke the operation and iterate over the result
            await foreach (NetworkCloudRackSkuResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetworkCloudRackSkuData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get rack SKU resource
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetRackSKUResource()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/stable/2023-07-01/examples/RackSkus_Get.json
            // this example is just showing the usage of "RackSkus_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this NetworkCloudRackSkuResource
            NetworkCloudRackSkuCollection collection = subscriptionResource.GetNetworkCloudRackSkus();

            // invoke the operation
            string rackSkuName = "rackSkuName";
            NetworkCloudRackSkuResource result = await collection.GetAsync(rackSkuName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkCloudRackSkuData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get rack SKU resource
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetRackSKUResource()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/stable/2023-07-01/examples/RackSkus_Get.json
            // this example is just showing the usage of "RackSkus_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this NetworkCloudRackSkuResource
            NetworkCloudRackSkuCollection collection = subscriptionResource.GetNetworkCloudRackSkus();

            // invoke the operation
            string rackSkuName = "rackSkuName";
            bool result = await collection.ExistsAsync(rackSkuName);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
