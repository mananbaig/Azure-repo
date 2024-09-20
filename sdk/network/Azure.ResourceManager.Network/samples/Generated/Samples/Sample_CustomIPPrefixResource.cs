// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_CustomIPPrefixResource
    {
        // Delete custom IP prefix
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteCustomIPPrefix()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/CustomIpPrefixDelete.json
            // this example is just showing the usage of "CustomIPPrefixes_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CustomIPPrefixResource created on azure
            // for more information of creating CustomIPPrefixResource, please refer to the document of CustomIPPrefixResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string customIPPrefixName = "test-customipprefix";
            ResourceIdentifier customIPPrefixResourceId = CustomIPPrefixResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, customIPPrefixName);
            CustomIPPrefixResource customIPPrefix = client.GetCustomIPPrefixResource(customIPPrefixResourceId);

            // invoke the operation
            await customIPPrefix.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Get custom IP prefix
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetCustomIPPrefix()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/CustomIpPrefixGet.json
            // this example is just showing the usage of "CustomIPPrefixes_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CustomIPPrefixResource created on azure
            // for more information of creating CustomIPPrefixResource, please refer to the document of CustomIPPrefixResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string customIPPrefixName = "test-customipprefix";
            ResourceIdentifier customIPPrefixResourceId = CustomIPPrefixResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, customIPPrefixName);
            CustomIPPrefixResource customIPPrefix = client.GetCustomIPPrefixResource(customIPPrefixResourceId);

            // invoke the operation
            CustomIPPrefixResource result = await customIPPrefix.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CustomIPPrefixData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update public IP address tags
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdatePublicIPAddressTags()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/CustomIpPrefixUpdateTags.json
            // this example is just showing the usage of "CustomIPPrefixes_UpdateTags" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CustomIPPrefixResource created on azure
            // for more information of creating CustomIPPrefixResource, please refer to the document of CustomIPPrefixResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string customIPPrefixName = "test-customipprefix";
            ResourceIdentifier customIPPrefixResourceId = CustomIPPrefixResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, customIPPrefixName);
            CustomIPPrefixResource customIPPrefix = client.GetCustomIPPrefixResource(customIPPrefixResourceId);

            // invoke the operation
            NetworkTagsObject networkTagsObject = new NetworkTagsObject()
            {
                Tags =
{
["tag1"] = "value1",
["tag2"] = "value2",
},
            };
            CustomIPPrefixResource result = await customIPPrefix.UpdateAsync(networkTagsObject);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CustomIPPrefixData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // List all custom IP prefixes
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetCustomIPPrefixes_ListAllCustomIPPrefixes()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/CustomIpPrefixListAll.json
            // this example is just showing the usage of "CustomIPPrefixes_ListAll" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subid";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (CustomIPPrefixResource item in subscriptionResource.GetCustomIPPrefixesAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                CustomIPPrefixData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
