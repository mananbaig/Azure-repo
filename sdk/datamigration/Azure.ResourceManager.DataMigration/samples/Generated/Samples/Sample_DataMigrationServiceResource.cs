// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.DataMigration.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.DataMigration.Samples
{
    public partial class Sample_DataMigrationServiceResource
    {
        // Services_CreateOrUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ServicesCreateOrUpdate()
        {
            // Generated from example definition: specification/datamigration/resource-manager/Microsoft.DataMigration/preview/2022-03-30-preview/examples/Services_Get.json
            // this example is just showing the usage of "Services_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataMigrationServiceResource created on azure
            // for more information of creating DataMigrationServiceResource, please refer to the document of DataMigrationServiceResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string groupName = "DmsSdkRg";
            string serviceName = "DmsSdkService";
            ResourceIdentifier dataMigrationServiceResourceId = DataMigrationServiceResource.CreateResourceIdentifier(subscriptionId, groupName, serviceName);
            DataMigrationServiceResource dataMigrationService = client.GetDataMigrationServiceResource(dataMigrationServiceResourceId);

            // invoke the operation
            DataMigrationServiceResource result = await dataMigrationService.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataMigrationServiceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Services_CreateOrUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_ServicesCreateOrUpdate()
        {
            // Generated from example definition: specification/datamigration/resource-manager/Microsoft.DataMigration/preview/2022-03-30-preview/examples/Services_Delete.json
            // this example is just showing the usage of "Services_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataMigrationServiceResource created on azure
            // for more information of creating DataMigrationServiceResource, please refer to the document of DataMigrationServiceResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string groupName = "DmsSdkRg";
            string serviceName = "DmsSdkService";
            ResourceIdentifier dataMigrationServiceResourceId = DataMigrationServiceResource.CreateResourceIdentifier(subscriptionId, groupName, serviceName);
            DataMigrationServiceResource dataMigrationService = client.GetDataMigrationServiceResource(dataMigrationServiceResourceId);

            // invoke the operation
            await dataMigrationService.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Services_CreateOrUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_ServicesCreateOrUpdate()
        {
            // Generated from example definition: specification/datamigration/resource-manager/Microsoft.DataMigration/preview/2022-03-30-preview/examples/Services_Update.json
            // this example is just showing the usage of "Services_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataMigrationServiceResource created on azure
            // for more information of creating DataMigrationServiceResource, please refer to the document of DataMigrationServiceResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string groupName = "DmsSdkRg";
            string serviceName = "DmsSdkService";
            ResourceIdentifier dataMigrationServiceResourceId = DataMigrationServiceResource.CreateResourceIdentifier(subscriptionId, groupName, serviceName);
            DataMigrationServiceResource dataMigrationService = client.GetDataMigrationServiceResource(dataMigrationServiceResourceId);

            // invoke the operation
            DataMigrationServiceData data = new DataMigrationServiceData(new AzureLocation("southcentralus"))
            {
                VirtualSubnetId = "/subscriptions/fc04246f-04c5-437e-ac5e-206a19e7193f/resourceGroups/DmsSdkTestNetwork/providers/Microsoft.Network/virtualNetworks/DmsSdkTestNetwork/subnets/default",
            };
            ArmOperation<DataMigrationServiceResource> lro = await dataMigrationService.UpdateAsync(WaitUntil.Completed, data);
            DataMigrationServiceResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataMigrationServiceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Services_CheckStatus
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CheckStatus_ServicesCheckStatus()
        {
            // Generated from example definition: specification/datamigration/resource-manager/Microsoft.DataMigration/preview/2022-03-30-preview/examples/Services_CheckStatus.json
            // this example is just showing the usage of "Services_CheckStatus" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataMigrationServiceResource created on azure
            // for more information of creating DataMigrationServiceResource, please refer to the document of DataMigrationServiceResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string groupName = "DmsSdkRg";
            string serviceName = "DmsSdkService";
            ResourceIdentifier dataMigrationServiceResourceId = DataMigrationServiceResource.CreateResourceIdentifier(subscriptionId, groupName, serviceName);
            DataMigrationServiceResource dataMigrationService = client.GetDataMigrationServiceResource(dataMigrationServiceResourceId);

            // invoke the operation
            DataMigrationServiceStatusResponse result = await dataMigrationService.CheckStatusAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        // Services_Start
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Start_ServicesStart()
        {
            // Generated from example definition: specification/datamigration/resource-manager/Microsoft.DataMigration/preview/2022-03-30-preview/examples/Services_Start.json
            // this example is just showing the usage of "Services_Start" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataMigrationServiceResource created on azure
            // for more information of creating DataMigrationServiceResource, please refer to the document of DataMigrationServiceResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string groupName = "DmsSdkRg";
            string serviceName = "DmsSdkService";
            ResourceIdentifier dataMigrationServiceResourceId = DataMigrationServiceResource.CreateResourceIdentifier(subscriptionId, groupName, serviceName);
            DataMigrationServiceResource dataMigrationService = client.GetDataMigrationServiceResource(dataMigrationServiceResourceId);

            // invoke the operation
            await dataMigrationService.StartAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Services_Stop
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Stop_ServicesStop()
        {
            // Generated from example definition: specification/datamigration/resource-manager/Microsoft.DataMigration/preview/2022-03-30-preview/examples/Services_Stop.json
            // this example is just showing the usage of "Services_Stop" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataMigrationServiceResource created on azure
            // for more information of creating DataMigrationServiceResource, please refer to the document of DataMigrationServiceResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string groupName = "DmsSdkRg";
            string serviceName = "DmsSdkService";
            ResourceIdentifier dataMigrationServiceResourceId = DataMigrationServiceResource.CreateResourceIdentifier(subscriptionId, groupName, serviceName);
            DataMigrationServiceResource dataMigrationService = client.GetDataMigrationServiceResource(dataMigrationServiceResourceId);

            // invoke the operation
            await dataMigrationService.StopAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Services_ListSkus
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetSkus_ServicesListSkus()
        {
            // Generated from example definition: specification/datamigration/resource-manager/Microsoft.DataMigration/preview/2022-03-30-preview/examples/Services_ListSkus.json
            // this example is just showing the usage of "Services_ListSkus" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataMigrationServiceResource created on azure
            // for more information of creating DataMigrationServiceResource, please refer to the document of DataMigrationServiceResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string groupName = "DmsSdkRg";
            string serviceName = "DmsSdkService";
            ResourceIdentifier dataMigrationServiceResourceId = DataMigrationServiceResource.CreateResourceIdentifier(subscriptionId, groupName, serviceName);
            DataMigrationServiceResource dataMigrationService = client.GetDataMigrationServiceResource(dataMigrationServiceResourceId);

            // invoke the operation and iterate over the result
            await foreach (AvailableServiceSku item in dataMigrationService.GetSkusAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Services_CheckChildrenNameAvailability
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CheckChildrenNameAvailability_ServicesCheckChildrenNameAvailability()
        {
            // Generated from example definition: specification/datamigration/resource-manager/Microsoft.DataMigration/preview/2022-03-30-preview/examples/Services_CheckChildrenNameAvailability.json
            // this example is just showing the usage of "Services_CheckChildrenNameAvailability" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataMigrationServiceResource created on azure
            // for more information of creating DataMigrationServiceResource, please refer to the document of DataMigrationServiceResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string groupName = "DmsSdkRg";
            string serviceName = "DmsSdkService";
            ResourceIdentifier dataMigrationServiceResourceId = DataMigrationServiceResource.CreateResourceIdentifier(subscriptionId, groupName, serviceName);
            DataMigrationServiceResource dataMigrationService = client.GetDataMigrationServiceResource(dataMigrationServiceResourceId);

            // invoke the operation
            NameAvailabilityRequest nameAvailabilityRequest = new NameAvailabilityRequest()
            {
                Name = "Task1",
                ResourceType = "tasks",
            };
            NameAvailabilityResponse result = await dataMigrationService.CheckChildrenNameAvailabilityAsync(nameAvailabilityRequest);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Services_List
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetDataMigrationServices_ServicesList()
        {
            // Generated from example definition: specification/datamigration/resource-manager/Microsoft.DataMigration/preview/2022-03-30-preview/examples/Services_List.json
            // this example is just showing the usage of "Services_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (DataMigrationServiceResource item in subscriptionResource.GetDataMigrationServicesAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DataMigrationServiceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Services_CheckNameAvailability
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CheckNameAvailabilityService_ServicesCheckNameAvailability()
        {
            // Generated from example definition: specification/datamigration/resource-manager/Microsoft.DataMigration/preview/2022-03-30-preview/examples/Services_CheckNameAvailability.json
            // this example is just showing the usage of "Services_CheckNameAvailability" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            AzureLocation location = new AzureLocation("eastus");
            NameAvailabilityRequest nameAvailabilityRequest = new NameAvailabilityRequest()
            {
                Name = "DmsSdkService",
                ResourceType = "services",
            };
            NameAvailabilityResponse result = await subscriptionResource.CheckNameAvailabilityServiceAsync(location, nameAvailabilityRequest);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
