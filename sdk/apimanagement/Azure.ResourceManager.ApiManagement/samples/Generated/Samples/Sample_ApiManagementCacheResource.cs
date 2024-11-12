// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ApiManagement.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.ApiManagement.Samples
{
    public partial class Sample_ApiManagementCacheResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetEntityTag_ApiManagementHeadCache()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementHeadCache.json
            // this example is just showing the usage of "Cache_GetEntityTag" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementCacheResource created on azure
            // for more information of creating ApiManagementCacheResource, please refer to the document of ApiManagementCacheResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string cacheId = "default";
            ResourceIdentifier apiManagementCacheResourceId = ApiManagementCacheResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, cacheId);
            ApiManagementCacheResource apiManagementCache = client.GetApiManagementCacheResource(apiManagementCacheResourceId);

            // invoke the operation
            bool result = await apiManagementCache.GetEntityTagAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ApiManagementGetCache()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementGetCache.json
            // this example is just showing the usage of "Cache_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementCacheResource created on azure
            // for more information of creating ApiManagementCacheResource, please refer to the document of ApiManagementCacheResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string cacheId = "c1";
            ResourceIdentifier apiManagementCacheResourceId = ApiManagementCacheResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, cacheId);
            ApiManagementCacheResource apiManagementCache = client.GetApiManagementCacheResource(apiManagementCacheResourceId);

            // invoke the operation
            ApiManagementCacheResource result = await apiManagementCache.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApiManagementCacheData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_ApiManagementUpdateCache()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementUpdateCache.json
            // this example is just showing the usage of "Cache_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementCacheResource created on azure
            // for more information of creating ApiManagementCacheResource, please refer to the document of ApiManagementCacheResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string cacheId = "c1";
            ResourceIdentifier apiManagementCacheResourceId = ApiManagementCacheResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, cacheId);
            ApiManagementCacheResource apiManagementCache = client.GetApiManagementCacheResource(apiManagementCacheResourceId);

            // invoke the operation
            ETag ifMatch = new ETag("*");
            ApiManagementCachePatch patch = new ApiManagementCachePatch()
            {
                UseFromLocation = "westindia",
            };
            ApiManagementCacheResource result = await apiManagementCache.UpdateAsync(ifMatch, patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApiManagementCacheData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_ApiManagementDeleteCache()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementDeleteCache.json
            // this example is just showing the usage of "Cache_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementCacheResource created on azure
            // for more information of creating ApiManagementCacheResource, please refer to the document of ApiManagementCacheResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string cacheId = "southindia";
            ResourceIdentifier apiManagementCacheResourceId = ApiManagementCacheResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, cacheId);
            ApiManagementCacheResource apiManagementCache = client.GetApiManagementCacheResource(apiManagementCacheResourceId);

            // invoke the operation
            ETag ifMatch = new ETag("*");
            await apiManagementCache.DeleteAsync(WaitUntil.Completed, ifMatch);

            Console.WriteLine("Succeeded");
        }
    }
}
