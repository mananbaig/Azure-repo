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
    public partial class Sample_RouteFilterResource
    {
        // RouteFilterDelete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_RouteFilterDelete()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/RouteFilterDelete.json
            // this example is just showing the usage of "RouteFilters_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RouteFilterResource created on azure
            // for more information of creating RouteFilterResource, please refer to the document of RouteFilterResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string routeFilterName = "filterName";
            ResourceIdentifier routeFilterResourceId = RouteFilterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, routeFilterName);
            RouteFilterResource routeFilter = client.GetRouteFilterResource(routeFilterResourceId);

            // invoke the operation
            await routeFilter.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // RouteFilterGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_RouteFilterGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/RouteFilterGet.json
            // this example is just showing the usage of "RouteFilters_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RouteFilterResource created on azure
            // for more information of creating RouteFilterResource, please refer to the document of RouteFilterResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string routeFilterName = "filterName";
            ResourceIdentifier routeFilterResourceId = RouteFilterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, routeFilterName);
            RouteFilterResource routeFilter = client.GetRouteFilterResource(routeFilterResourceId);

            // invoke the operation
            RouteFilterResource result = await routeFilter.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RouteFilterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update route filter tags
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateRouteFilterTags()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/RouteFilterUpdateTags.json
            // this example is just showing the usage of "RouteFilters_UpdateTags" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RouteFilterResource created on azure
            // for more information of creating RouteFilterResource, please refer to the document of RouteFilterResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string routeFilterName = "filterName";
            ResourceIdentifier routeFilterResourceId = RouteFilterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, routeFilterName);
            RouteFilterResource routeFilter = client.GetRouteFilterResource(routeFilterResourceId);

            // invoke the operation
            NetworkTagsObject networkTagsObject = new NetworkTagsObject()
            {
                Tags =
{
["key1"] = "value1",
},
            };
            RouteFilterResource result = await routeFilter.UpdateAsync(networkTagsObject);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RouteFilterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // RouteFilterList
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetRouteFilters_RouteFilterList()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/RouteFilterList.json
            // this example is just showing the usage of "RouteFilters_List" operation, for the dependent resources, they will have to be created separately.

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
            await foreach (RouteFilterResource item in subscriptionResource.GetRouteFiltersAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                RouteFilterData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
