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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_PrivateLinkServiceResource
    {
        // Delete private link service
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeletePrivateLinkService()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-06-01/examples/PrivateLinkServiceDelete.json
            // this example is just showing the usage of "PrivateLinkServices_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PrivateLinkServiceResource created on azure
            // for more information of creating PrivateLinkServiceResource, please refer to the document of PrivateLinkServiceResource
            string subscriptionId = "subId";
            string resourceGroupName = "rg1";
            string serviceName = "testPls";
            ResourceIdentifier privateLinkServiceResourceId = PrivateLinkServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName);
            PrivateLinkServiceResource privateLinkService = client.GetPrivateLinkServiceResource(privateLinkServiceResourceId);

            // invoke the operation
            await privateLinkService.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Get private link service
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetPrivateLinkService()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-06-01/examples/PrivateLinkServiceGet.json
            // this example is just showing the usage of "PrivateLinkServices_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PrivateLinkServiceResource created on azure
            // for more information of creating PrivateLinkServiceResource, please refer to the document of PrivateLinkServiceResource
            string subscriptionId = "subId";
            string resourceGroupName = "rg1";
            string serviceName = "testPls";
            ResourceIdentifier privateLinkServiceResourceId = PrivateLinkServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName);
            PrivateLinkServiceResource privateLinkService = client.GetPrivateLinkServiceResource(privateLinkServiceResourceId);

            // invoke the operation
            PrivateLinkServiceResource result = await privateLinkService.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PrivateLinkServiceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create private link service
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreatePrivateLinkService()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-06-01/examples/PrivateLinkServiceCreate.json
            // this example is just showing the usage of "PrivateLinkServices_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PrivateLinkServiceResource created on azure
            // for more information of creating PrivateLinkServiceResource, please refer to the document of PrivateLinkServiceResource
            string subscriptionId = "subId";
            string resourceGroupName = "rg1";
            string serviceName = "testPls";
            ResourceIdentifier privateLinkServiceResourceId = PrivateLinkServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName);
            PrivateLinkServiceResource privateLinkService = client.GetPrivateLinkServiceResource(privateLinkServiceResourceId);

            // invoke the operation
            PrivateLinkServiceData data = new PrivateLinkServiceData()
            {
                LoadBalancerFrontendIPConfigurations =
{
new FrontendIPConfigurationData()
{
Id = new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/loadBalancers/lb/frontendIPConfigurations/fe-lb"),
}
},
                IPConfigurations =
{
new PrivateLinkServiceIPConfiguration()
{
PrivateIPAddress = "10.0.1.4",
PrivateIPAllocationMethod = NetworkIPAllocationMethod.Static,
Subnet = new SubnetData()
{
Id = new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/virtualNetworks/vnetlb/subnets/subnetlb"),
},
PrivateIPAddressVersion = NetworkIPVersion.IPv4,
Name = "fe-lb",
}
},
                VisibilitySubscriptions =
{
"subscription1","subscription2","subscription3"
},
                AutoApprovalSubscriptions =
{
"subscription1","subscription2"
},
                Fqdns =
{
"fqdn1","fqdn2","fqdn3"
},
                Location = new AzureLocation("eastus"),
            };
            ArmOperation<PrivateLinkServiceResource> lro = await privateLinkService.UpdateAsync(WaitUntil.Completed, data);
            PrivateLinkServiceResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PrivateLinkServiceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // List all private list service
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetPrivateLinkServices_ListAllPrivateListService()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-06-01/examples/PrivateLinkServiceListAll.json
            // this example is just showing the usage of "PrivateLinkServices_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subId";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (PrivateLinkServiceResource item in subscriptionResource.GetPrivateLinkServicesAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                PrivateLinkServiceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
