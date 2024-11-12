// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Reservations.Models;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.Reservations.Samples
{
    public partial class Sample_ReservationQuotaCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_QuotasRequestForCompute()
        {
            // Generated from example definition: specification/reservations/resource-manager/Microsoft.Capacity/stable/2020-10-25/examples/getComputeOneSkuUsages.json
            // this example is just showing the usage of "Quota_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this ReservationQuotaResource
            string providerId = "Microsoft.Compute";
            AzureLocation location = new AzureLocation("eastus");
            ReservationQuotaCollection collection = subscriptionResource.GetAllReservationQuota(providerId, location);

            // invoke the operation
            string resourceName = "standardNDSFamily";
            ReservationQuotaResource result = await collection.GetAsync(resourceName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ReservationQuotaData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_QuotasRequestForCompute()
        {
            // Generated from example definition: specification/reservations/resource-manager/Microsoft.Capacity/stable/2020-10-25/examples/getComputeOneSkuUsages.json
            // this example is just showing the usage of "Quota_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this ReservationQuotaResource
            string providerId = "Microsoft.Compute";
            AzureLocation location = new AzureLocation("eastus");
            ReservationQuotaCollection collection = subscriptionResource.GetAllReservationQuota(providerId, location);

            // invoke the operation
            string resourceName = "standardNDSFamily";
            bool result = await collection.ExistsAsync(resourceName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_QuotasRequestForCompute()
        {
            // Generated from example definition: specification/reservations/resource-manager/Microsoft.Capacity/stable/2020-10-25/examples/getComputeOneSkuUsages.json
            // this example is just showing the usage of "Quota_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this ReservationQuotaResource
            string providerId = "Microsoft.Compute";
            AzureLocation location = new AzureLocation("eastus");
            ReservationQuotaCollection collection = subscriptionResource.GetAllReservationQuota(providerId, location);

            // invoke the operation
            string resourceName = "standardNDSFamily";
            NullableResponse<ReservationQuotaResource> response = await collection.GetIfExistsAsync(resourceName);
            ReservationQuotaResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ReservationQuotaData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_QuotasRequestPutForCompute()
        {
            // Generated from example definition: specification/reservations/resource-manager/Microsoft.Capacity/stable/2020-10-25/examples/putComputeOneSkuQuotaRequest.json
            // this example is just showing the usage of "Quota_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "D7EC67B3-7657-4966-BFFC-41EFD36BAAB3";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this ReservationQuotaResource
            string providerId = "Microsoft.Compute";
            AzureLocation location = new AzureLocation("eastus");
            ReservationQuotaCollection collection = subscriptionResource.GetAllReservationQuota(providerId, location);

            // invoke the operation
            string resourceName = "standardFSv2Family";
            ReservationQuotaData data = new ReservationQuotaData()
            {
                Properties = new QuotaProperties()
                {
                    Limit = 200,
                    Unit = "Count",
                    ResourceName = new ReservationResourceName()
                    {
                        Value = "standardFSv2Family",
                    },
                },
            };
            ArmOperation<ReservationQuotaResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, resourceName, data);
            ReservationQuotaResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ReservationQuotaData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_QuotasRequestPutForMachineLearningServicesDedicatedResource()
        {
            // Generated from example definition: specification/reservations/resource-manager/Microsoft.Capacity/stable/2020-10-25/examples/putMachineLearningServicesQuotaRequestDedicated.json
            // this example is just showing the usage of "Quota_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "D7EC67B3-7657-4966-BFFC-41EFD36BAAB3";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this ReservationQuotaResource
            string providerId = "Microsoft.MachineLearningServices";
            AzureLocation location = new AzureLocation("eastus");
            ReservationQuotaCollection collection = subscriptionResource.GetAllReservationQuota(providerId, location);

            // invoke the operation
            string resourceName = "StandardDv2Family";
            ReservationQuotaData data = new ReservationQuotaData()
            {
                Properties = new QuotaProperties()
                {
                    Limit = 200,
                    Unit = "Count",
                    ResourceName = new ReservationResourceName()
                    {
                        Value = "StandardDv2Family",
                    },
                    ResourceTypeName = ResourceTypeName.Dedicated,
                },
            };
            ArmOperation<ReservationQuotaResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, resourceName, data);
            ReservationQuotaResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ReservationQuotaData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_QuotasRequestPutForMachineLearningServicesLowPriorityResource()
        {
            // Generated from example definition: specification/reservations/resource-manager/Microsoft.Capacity/stable/2020-10-25/examples/putMachineLearningServicesQuotaRequestLowPriority.json
            // this example is just showing the usage of "Quota_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "D7EC67B3-7657-4966-BFFC-41EFD36BAAB3";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this ReservationQuotaResource
            string providerId = "Microsoft.MachineLearningServices";
            AzureLocation location = new AzureLocation("eastus");
            ReservationQuotaCollection collection = subscriptionResource.GetAllReservationQuota(providerId, location);

            // invoke the operation
            string resourceName = "TotalLowPriorityCores";
            ReservationQuotaData data = new ReservationQuotaData()
            {
                Properties = new QuotaProperties()
                {
                    Limit = 200,
                    Unit = "Count",
                    ResourceName = new ReservationResourceName()
                    {
                        Value = "TotalLowPriorityCores",
                    },
                    ResourceTypeName = ResourceTypeName.LowPriority,
                },
            };
            ArmOperation<ReservationQuotaResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, resourceName, data);
            ReservationQuotaResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ReservationQuotaData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_QuotasListUsagesForCompute()
        {
            // Generated from example definition: specification/reservations/resource-manager/Microsoft.Capacity/stable/2020-10-25/examples/getComputeUsages.json
            // this example is just showing the usage of "Quota_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this ReservationQuotaResource
            string providerId = "Microsoft.Compute";
            AzureLocation location = new AzureLocation("eastus");
            ReservationQuotaCollection collection = subscriptionResource.GetAllReservationQuota(providerId, location);

            // invoke the operation and iterate over the result
            await foreach (ReservationQuotaResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ReservationQuotaData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_QuotasListUsagesMachineLearningServices()
        {
            // Generated from example definition: specification/reservations/resource-manager/Microsoft.Capacity/stable/2020-10-25/examples/getMachineLearningServicesUsages.json
            // this example is just showing the usage of "Quota_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this ReservationQuotaResource
            string providerId = "Microsoft.MachineLearningServices";
            AzureLocation location = new AzureLocation("eastus");
            ReservationQuotaCollection collection = subscriptionResource.GetAllReservationQuota(providerId, location);

            // invoke the operation and iterate over the result
            await foreach (ReservationQuotaResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ReservationQuotaData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}
