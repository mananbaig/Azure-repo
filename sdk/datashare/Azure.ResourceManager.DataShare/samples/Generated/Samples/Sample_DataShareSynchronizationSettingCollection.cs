// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.DataShare.Models;

namespace Azure.ResourceManager.DataShare.Samples
{
    public partial class Sample_DataShareSynchronizationSettingCollection
    {
        // SynchronizationSettings_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_SynchronizationSettingsGet()
        {
            // Generated from example definition: specification/datashare/resource-manager/Microsoft.DataShare/stable/2021-08-01/examples/SynchronizationSettings_Get.json
            // this example is just showing the usage of "SynchronizationSettings_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataShareResource created on azure
            // for more information of creating DataShareResource, please refer to the document of DataShareResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "SampleResourceGroup";
            string accountName = "Account1";
            string shareName = "Share1";
            ResourceIdentifier dataShareResourceId = DataShareResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, shareName);
            DataShareResource dataShare = client.GetDataShareResource(dataShareResourceId);

            // get the collection of this DataShareSynchronizationSettingResource
            DataShareSynchronizationSettingCollection collection = dataShare.GetDataShareSynchronizationSettings();

            // invoke the operation
            string synchronizationSettingName = "SynchronizationSetting1";
            DataShareSynchronizationSettingResource result = await collection.GetAsync(synchronizationSettingName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataShareSynchronizationSettingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // SynchronizationSettings_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_SynchronizationSettingsGet()
        {
            // Generated from example definition: specification/datashare/resource-manager/Microsoft.DataShare/stable/2021-08-01/examples/SynchronizationSettings_Get.json
            // this example is just showing the usage of "SynchronizationSettings_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataShareResource created on azure
            // for more information of creating DataShareResource, please refer to the document of DataShareResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "SampleResourceGroup";
            string accountName = "Account1";
            string shareName = "Share1";
            ResourceIdentifier dataShareResourceId = DataShareResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, shareName);
            DataShareResource dataShare = client.GetDataShareResource(dataShareResourceId);

            // get the collection of this DataShareSynchronizationSettingResource
            DataShareSynchronizationSettingCollection collection = dataShare.GetDataShareSynchronizationSettings();

            // invoke the operation
            string synchronizationSettingName = "SynchronizationSetting1";
            bool result = await collection.ExistsAsync(synchronizationSettingName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // SynchronizationSettings_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_SynchronizationSettingsGet()
        {
            // Generated from example definition: specification/datashare/resource-manager/Microsoft.DataShare/stable/2021-08-01/examples/SynchronizationSettings_Get.json
            // this example is just showing the usage of "SynchronizationSettings_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataShareResource created on azure
            // for more information of creating DataShareResource, please refer to the document of DataShareResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "SampleResourceGroup";
            string accountName = "Account1";
            string shareName = "Share1";
            ResourceIdentifier dataShareResourceId = DataShareResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, shareName);
            DataShareResource dataShare = client.GetDataShareResource(dataShareResourceId);

            // get the collection of this DataShareSynchronizationSettingResource
            DataShareSynchronizationSettingCollection collection = dataShare.GetDataShareSynchronizationSettings();

            // invoke the operation
            string synchronizationSettingName = "SynchronizationSetting1";
            NullableResponse<DataShareSynchronizationSettingResource> response = await collection.GetIfExistsAsync(synchronizationSettingName);
            DataShareSynchronizationSettingResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DataShareSynchronizationSettingData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // SynchronizationSettings_Create
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_SynchronizationSettingsCreate()
        {
            // Generated from example definition: specification/datashare/resource-manager/Microsoft.DataShare/stable/2021-08-01/examples/SynchronizationSettings_Create.json
            // this example is just showing the usage of "SynchronizationSettings_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataShareResource created on azure
            // for more information of creating DataShareResource, please refer to the document of DataShareResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "SampleResourceGroup";
            string accountName = "Account1";
            string shareName = "Share1";
            ResourceIdentifier dataShareResourceId = DataShareResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, shareName);
            DataShareResource dataShare = client.GetDataShareResource(dataShareResourceId);

            // get the collection of this DataShareSynchronizationSettingResource
            DataShareSynchronizationSettingCollection collection = dataShare.GetDataShareSynchronizationSettings();

            // invoke the operation
            string synchronizationSettingName = "Dataset1";
            DataShareSynchronizationSettingData data = new ScheduledSynchronizationSetting(DataShareSynchronizationRecurrenceInterval.Day, DateTimeOffset.Parse("2018-11-14T04:47:52.9614956Z"));
            ArmOperation<DataShareSynchronizationSettingResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, synchronizationSettingName, data);
            DataShareSynchronizationSettingResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataShareSynchronizationSettingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // SynchronizationSettings_ListByShare
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_SynchronizationSettingsListByShare()
        {
            // Generated from example definition: specification/datashare/resource-manager/Microsoft.DataShare/stable/2021-08-01/examples/SynchronizationSettings_ListByShare.json
            // this example is just showing the usage of "SynchronizationSettings_ListByShare" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataShareResource created on azure
            // for more information of creating DataShareResource, please refer to the document of DataShareResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "SampleResourceGroup";
            string accountName = "Account1";
            string shareName = "Share1";
            ResourceIdentifier dataShareResourceId = DataShareResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, shareName);
            DataShareResource dataShare = client.GetDataShareResource(dataShareResourceId);

            // get the collection of this DataShareSynchronizationSettingResource
            DataShareSynchronizationSettingCollection collection = dataShare.GetDataShareSynchronizationSettings();

            // invoke the operation and iterate over the result
            await foreach (DataShareSynchronizationSettingResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DataShareSynchronizationSettingData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
