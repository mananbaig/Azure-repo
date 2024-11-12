// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ManagementGroups;
using Azure.ResourceManager.Quota.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Quota.Samples
{
    public partial class Sample_QuotaAllocationRequestStatusResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_SubscriptionQuotaAllocationRequestsGetRequestForCompute()
        {
            // Generated from example definition: specification/quota/resource-manager/Microsoft.Quota/preview/2023-06-01-preview/examples/SubscriptionQuotaAllocationRequests/SubscriptionQuotaAllocationRequests_Get-Compute.json
            // this example is just showing the usage of "GroupQuotaSubscriptionAllocationRequest_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this QuotaAllocationRequestStatusResource created on azure
            // for more information of creating QuotaAllocationRequestStatusResource, please refer to the document of QuotaAllocationRequestStatusResource
            string managementGroupId = "E7EC67B3-7657-4966-BFFC-41EFD36BAA09";
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string groupQuotaName = "groupquota1";
            string allocationId = "AE000000-0000-0000-0000-00000000000A";
            ResourceIdentifier quotaAllocationRequestStatusResourceId = QuotaAllocationRequestStatusResource.CreateResourceIdentifier(managementGroupId, subscriptionId, groupQuotaName, allocationId);
            QuotaAllocationRequestStatusResource quotaAllocationRequestStatus = client.GetQuotaAllocationRequestStatusResource(quotaAllocationRequestStatusResourceId);

            // invoke the operation
            QuotaAllocationRequestStatusResource result = await quotaAllocationRequestStatus.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            QuotaAllocationRequestStatusData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetQuotaAllocationRequestStatusesByResourceProvider_SubscriptionQuotaAllocationListRequestForCompute()
        {
            // Generated from example definition: specification/quota/resource-manager/Microsoft.Quota/preview/2023-06-01-preview/examples/SubscriptionQuotaAllocationRequests/SubscriptionQuotaAllocationRequests_List-Compute.json
            // this example is just showing the usage of "GroupQuotaSubscriptionAllocationRequest_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagementGroupResource created on azure
            // for more information of creating ManagementGroupResource, please refer to the document of ManagementGroupResource
            string managementGroupId = "E7EC67B3-7657-4966-BFFC-41EFD36BAA09";
            ResourceIdentifier managementGroupResourceId = ManagementGroupResource.CreateResourceIdentifier(managementGroupId);
            ManagementGroupResource managementGroupResource = client.GetManagementGroupResource(managementGroupResourceId);

            // invoke the operation and iterate over the result
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string groupQuotaName = "groupquota1";
            string resourceProviderName = "Microsoft.Compute";
            string filter = "location eq westus";
            await foreach (QuotaAllocationRequestStatusResource item in managementGroupResource.GetQuotaAllocationRequestStatusesByResourceProviderAsync(subscriptionId, groupQuotaName, resourceProviderName, filter))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                QuotaAllocationRequestStatusData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdateGroupQuotaSubscriptionAllocationRequest_SubscriptionQuotaAllocationPutRequestForCompute()
        {
            // Generated from example definition: specification/quota/resource-manager/Microsoft.Quota/preview/2023-06-01-preview/examples/SubscriptionQuotaAllocationRequests/PutSubscriptionQuotaAllocationRequest-Compute.json
            // this example is just showing the usage of "GroupQuotaSubscriptionAllocationRequest_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagementGroupResource created on azure
            // for more information of creating ManagementGroupResource, please refer to the document of ManagementGroupResource
            string managementGroupId = "E7EC67B3-7657-4966-BFFC-41EFD36BAA09";
            ResourceIdentifier managementGroupResourceId = ManagementGroupResource.CreateResourceIdentifier(managementGroupId);
            ManagementGroupResource managementGroupResource = client.GetManagementGroupResource(managementGroupResourceId);

            // invoke the operation
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string groupQuotaName = "groupquota1";
            string resourceProviderName = "Microsoft.Compute";
            string resourceName = "standardav2family";
            QuotaAllocationRequestStatusData data = new QuotaAllocationRequestStatusData()
            {
                RequestedResource = new QuotaAllocationRequestBase()
                {
                    Limit = 10L,
                    Region = "westus",
                },
            };
            ArmOperation<QuotaAllocationRequestStatusResource> lro = await managementGroupResource.CreateOrUpdateGroupQuotaSubscriptionAllocationRequestAsync(WaitUntil.Completed, subscriptionId, groupQuotaName, resourceProviderName, resourceName, data);
            QuotaAllocationRequestStatusResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            QuotaAllocationRequestStatusData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task UpdateGroupQuotaSubscriptionAllocationRequest_SubscriptionQuotaAllocationPatchRequestForCompute()
        {
            // Generated from example definition: specification/quota/resource-manager/Microsoft.Quota/preview/2023-06-01-preview/examples/SubscriptionQuotaAllocationRequests/PatchSubscriptionQuotaAllocationRequest-Compute.json
            // this example is just showing the usage of "GroupQuotaSubscriptionAllocationRequest_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagementGroupResource created on azure
            // for more information of creating ManagementGroupResource, please refer to the document of ManagementGroupResource
            string managementGroupId = "E7EC67B3-7657-4966-BFFC-41EFD36BAA09";
            ResourceIdentifier managementGroupResourceId = ManagementGroupResource.CreateResourceIdentifier(managementGroupId);
            ManagementGroupResource managementGroupResource = client.GetManagementGroupResource(managementGroupResourceId);

            // invoke the operation
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string groupQuotaName = "groupquota1";
            string resourceProviderName = "Microsoft.Compute";
            string resourceName = "standardav2family";
            QuotaAllocationRequestStatusData data = new QuotaAllocationRequestStatusData()
            {
                RequestedResource = new QuotaAllocationRequestBase()
                {
                    Limit = 10L,
                    Region = "westus",
                },
            };
            ArmOperation<QuotaAllocationRequestStatusResource> lro = await managementGroupResource.UpdateGroupQuotaSubscriptionAllocationRequestAsync(WaitUntil.Completed, subscriptionId, groupQuotaName, resourceProviderName, resourceName, data);
            QuotaAllocationRequestStatusResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            QuotaAllocationRequestStatusData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
