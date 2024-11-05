// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.Avs.Samples
{
    public partial class Sample_HcxEnterpriseSiteCollection
    {
        // HcxEnterpriseSites_List
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_HcxEnterpriseSitesList()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2023-09-01/examples/HcxEnterpriseSites_List.json
            // this example is just showing the usage of "HcxEnterpriseSites_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AvsPrivateCloudResource created on azure
            // for more information of creating AvsPrivateCloudResource, please refer to the document of AvsPrivateCloudResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            ResourceIdentifier avsPrivateCloudResourceId = AvsPrivateCloudResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName);
            AvsPrivateCloudResource avsPrivateCloud = client.GetAvsPrivateCloudResource(avsPrivateCloudResourceId);

            // get the collection of this HcxEnterpriseSiteResource
            HcxEnterpriseSiteCollection collection = avsPrivateCloud.GetHcxEnterpriseSites();

            // invoke the operation and iterate over the result
            await foreach (HcxEnterpriseSiteResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                HcxEnterpriseSiteData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // HcxEnterpriseSites_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_HcxEnterpriseSitesGet()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2023-09-01/examples/HcxEnterpriseSites_Get.json
            // this example is just showing the usage of "HcxEnterpriseSites_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AvsPrivateCloudResource created on azure
            // for more information of creating AvsPrivateCloudResource, please refer to the document of AvsPrivateCloudResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            ResourceIdentifier avsPrivateCloudResourceId = AvsPrivateCloudResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName);
            AvsPrivateCloudResource avsPrivateCloud = client.GetAvsPrivateCloudResource(avsPrivateCloudResourceId);

            // get the collection of this HcxEnterpriseSiteResource
            HcxEnterpriseSiteCollection collection = avsPrivateCloud.GetHcxEnterpriseSites();

            // invoke the operation
            string hcxEnterpriseSiteName = "site1";
            HcxEnterpriseSiteResource result = await collection.GetAsync(hcxEnterpriseSiteName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HcxEnterpriseSiteData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // HcxEnterpriseSites_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_HcxEnterpriseSitesGet()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2023-09-01/examples/HcxEnterpriseSites_Get.json
            // this example is just showing the usage of "HcxEnterpriseSites_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AvsPrivateCloudResource created on azure
            // for more information of creating AvsPrivateCloudResource, please refer to the document of AvsPrivateCloudResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            ResourceIdentifier avsPrivateCloudResourceId = AvsPrivateCloudResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName);
            AvsPrivateCloudResource avsPrivateCloud = client.GetAvsPrivateCloudResource(avsPrivateCloudResourceId);

            // get the collection of this HcxEnterpriseSiteResource
            HcxEnterpriseSiteCollection collection = avsPrivateCloud.GetHcxEnterpriseSites();

            // invoke the operation
            string hcxEnterpriseSiteName = "site1";
            bool result = await collection.ExistsAsync(hcxEnterpriseSiteName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // HcxEnterpriseSites_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_HcxEnterpriseSitesGet()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2023-09-01/examples/HcxEnterpriseSites_Get.json
            // this example is just showing the usage of "HcxEnterpriseSites_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AvsPrivateCloudResource created on azure
            // for more information of creating AvsPrivateCloudResource, please refer to the document of AvsPrivateCloudResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            ResourceIdentifier avsPrivateCloudResourceId = AvsPrivateCloudResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName);
            AvsPrivateCloudResource avsPrivateCloud = client.GetAvsPrivateCloudResource(avsPrivateCloudResourceId);

            // get the collection of this HcxEnterpriseSiteResource
            HcxEnterpriseSiteCollection collection = avsPrivateCloud.GetHcxEnterpriseSites();

            // invoke the operation
            string hcxEnterpriseSiteName = "site1";
            NullableResponse<HcxEnterpriseSiteResource> response = await collection.GetIfExistsAsync(hcxEnterpriseSiteName);
            HcxEnterpriseSiteResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                HcxEnterpriseSiteData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // HcxEnterpriseSites_CreateOrUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_HcxEnterpriseSitesCreateOrUpdate()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2023-09-01/examples/HcxEnterpriseSites_CreateOrUpdate.json
            // this example is just showing the usage of "HcxEnterpriseSites_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AvsPrivateCloudResource created on azure
            // for more information of creating AvsPrivateCloudResource, please refer to the document of AvsPrivateCloudResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            ResourceIdentifier avsPrivateCloudResourceId = AvsPrivateCloudResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName);
            AvsPrivateCloudResource avsPrivateCloud = client.GetAvsPrivateCloudResource(avsPrivateCloudResourceId);

            // get the collection of this HcxEnterpriseSiteResource
            HcxEnterpriseSiteCollection collection = avsPrivateCloud.GetHcxEnterpriseSites();

            // invoke the operation
            string hcxEnterpriseSiteName = "site1";
            HcxEnterpriseSiteData data = new HcxEnterpriseSiteData();
            ArmOperation<HcxEnterpriseSiteResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, hcxEnterpriseSiteName, data);
            HcxEnterpriseSiteResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HcxEnterpriseSiteData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
