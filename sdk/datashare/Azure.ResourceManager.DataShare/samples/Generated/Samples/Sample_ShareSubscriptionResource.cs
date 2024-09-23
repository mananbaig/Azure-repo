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
    public partial class Sample_ShareSubscriptionResource
    {
        // ShareSubscriptions_CancelSynchronization
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CancelSynchronization_ShareSubscriptionsCancelSynchronization()
        {
            // Generated from example definition: specification/datashare/resource-manager/Microsoft.DataShare/stable/2021-08-01/examples/ShareSubscriptions_CancelSynchronization.json
            // this example is just showing the usage of "ShareSubscriptions_CancelSynchronization" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ShareSubscriptionResource created on azure
            // for more information of creating ShareSubscriptionResource, please refer to the document of ShareSubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "SampleResourceGroup";
            string accountName = "Account1";
            string shareSubscriptionName = "ShareSubscription1";
            ResourceIdentifier shareSubscriptionResourceId = ShareSubscriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, shareSubscriptionName);
            ShareSubscriptionResource shareSubscription = client.GetShareSubscriptionResource(shareSubscriptionResourceId);

            // invoke the operation
            ShareSubscriptionSynchronization shareSubscriptionSynchronization = new ShareSubscriptionSynchronization(Guid.Parse("7d0536a6-3fa5-43de-b152-3d07c4f6b2bb"));
            ArmOperation<ShareSubscriptionSynchronization> lro = await shareSubscription.CancelSynchronizationAsync(WaitUntil.Completed, shareSubscriptionSynchronization);
            ShareSubscriptionSynchronization result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // ShareSubscriptions_ListSourceShareSynchronizationSettings
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetSourceShareSynchronizationSettings_ShareSubscriptionsListSourceShareSynchronizationSettings()
        {
            // Generated from example definition: specification/datashare/resource-manager/Microsoft.DataShare/stable/2021-08-01/examples/ShareSubscriptions_ListSourceShareSynchronizationSettings.json
            // this example is just showing the usage of "ShareSubscriptions_ListSourceShareSynchronizationSettings" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ShareSubscriptionResource created on azure
            // for more information of creating ShareSubscriptionResource, please refer to the document of ShareSubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "SampleResourceGroup";
            string accountName = "Account1";
            string shareSubscriptionName = "ShareSub1";
            ResourceIdentifier shareSubscriptionResourceId = ShareSubscriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, shareSubscriptionName);
            ShareSubscriptionResource shareSubscription = client.GetShareSubscriptionResource(shareSubscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (SourceShareSynchronizationSetting item in shareSubscription.GetSourceShareSynchronizationSettingsAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // ShareSubscriptions_ListSynchronizationDetails
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetSynchronizationDetails_ShareSubscriptionsListSynchronizationDetails()
        {
            // Generated from example definition: specification/datashare/resource-manager/Microsoft.DataShare/stable/2021-08-01/examples/ShareSubscriptions_ListSynchronizationDetails.json
            // this example is just showing the usage of "ShareSubscriptions_ListSynchronizationDetails" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ShareSubscriptionResource created on azure
            // for more information of creating ShareSubscriptionResource, please refer to the document of ShareSubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "SampleResourceGroup";
            string accountName = "Account1";
            string shareSubscriptionName = "ShareSub1";
            ResourceIdentifier shareSubscriptionResourceId = ShareSubscriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, shareSubscriptionName);
            ShareSubscriptionResource shareSubscription = client.GetShareSubscriptionResource(shareSubscriptionResourceId);

            // invoke the operation and iterate over the result
            ShareSubscriptionSynchronization shareSubscriptionSynchronization = new ShareSubscriptionSynchronization(Guid.Parse("7d0536a6-3fa5-43de-b152-3d07c4f6b2bb"));
            await foreach (SynchronizationDetails item in shareSubscription.GetSynchronizationDetailsAsync(shareSubscriptionSynchronization))
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // ShareSubscriptions_ListSynchronizations
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetSynchronizations_ShareSubscriptionsListSynchronizations()
        {
            // Generated from example definition: specification/datashare/resource-manager/Microsoft.DataShare/stable/2021-08-01/examples/ShareSubscriptions_ListSynchronizations.json
            // this example is just showing the usage of "ShareSubscriptions_ListSynchronizations" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ShareSubscriptionResource created on azure
            // for more information of creating ShareSubscriptionResource, please refer to the document of ShareSubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "SampleResourceGroup";
            string accountName = "Account1";
            string shareSubscriptionName = "ShareSub1";
            ResourceIdentifier shareSubscriptionResourceId = ShareSubscriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, shareSubscriptionName);
            ShareSubscriptionResource shareSubscription = client.GetShareSubscriptionResource(shareSubscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (ShareSubscriptionSynchronization item in shareSubscription.GetSynchronizationsAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // ShareSubscriptions_Synchronize
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Synchronize_ShareSubscriptionsSynchronize()
        {
            // Generated from example definition: specification/datashare/resource-manager/Microsoft.DataShare/stable/2021-08-01/examples/ShareSubscriptions_Synchronize.json
            // this example is just showing the usage of "ShareSubscriptions_Synchronize" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ShareSubscriptionResource created on azure
            // for more information of creating ShareSubscriptionResource, please refer to the document of ShareSubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "SampleResourceGroup";
            string accountName = "Account1";
            string shareSubscriptionName = "ShareSubscription1";
            ResourceIdentifier shareSubscriptionResourceId = ShareSubscriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, shareSubscriptionName);
            ShareSubscriptionResource shareSubscription = client.GetShareSubscriptionResource(shareSubscriptionResourceId);

            // invoke the operation
            DataShareSynchronizeContent content = new DataShareSynchronizeContent()
            {
                SynchronizationMode = SynchronizationMode.Incremental,
            };
            ArmOperation<ShareSubscriptionSynchronization> lro = await shareSubscription.SynchronizeAsync(WaitUntil.Completed, content);
            ShareSubscriptionSynchronization result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // ShareSubscriptions_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ShareSubscriptionsGet()
        {
            // Generated from example definition: specification/datashare/resource-manager/Microsoft.DataShare/stable/2021-08-01/examples/ShareSubscriptions_Get.json
            // this example is just showing the usage of "ShareSubscriptions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ShareSubscriptionResource created on azure
            // for more information of creating ShareSubscriptionResource, please refer to the document of ShareSubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "SampleResourceGroup";
            string accountName = "Account1";
            string shareSubscriptionName = "ShareSubscription1";
            ResourceIdentifier shareSubscriptionResourceId = ShareSubscriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, shareSubscriptionName);
            ShareSubscriptionResource shareSubscription = client.GetShareSubscriptionResource(shareSubscriptionResourceId);

            // invoke the operation
            ShareSubscriptionResource result = await shareSubscription.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ShareSubscriptionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ShareSubscriptions_Create
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_ShareSubscriptionsCreate()
        {
            // Generated from example definition: specification/datashare/resource-manager/Microsoft.DataShare/stable/2021-08-01/examples/ShareSubscriptions_Create.json
            // this example is just showing the usage of "ShareSubscriptions_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ShareSubscriptionResource created on azure
            // for more information of creating ShareSubscriptionResource, please refer to the document of ShareSubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "SampleResourceGroup";
            string accountName = "Account1";
            string shareSubscriptionName = "ShareSubscription1";
            ResourceIdentifier shareSubscriptionResourceId = ShareSubscriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, shareSubscriptionName);
            ShareSubscriptionResource shareSubscription = client.GetShareSubscriptionResource(shareSubscriptionResourceId);

            // invoke the operation
            ShareSubscriptionData data = new ShareSubscriptionData(Guid.Parse("12345678-1234-1234-12345678abd"), new AzureLocation("eastus2"))
            {
                ExpireOn = DateTimeOffset.Parse("2020-08-26T22:33:24.5785265Z"),
            };
            ArmOperation<ShareSubscriptionResource> lro = await shareSubscription.UpdateAsync(WaitUntil.Completed, data);
            ShareSubscriptionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ShareSubscriptionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ShareSubscriptions_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_ShareSubscriptionsDelete()
        {
            // Generated from example definition: specification/datashare/resource-manager/Microsoft.DataShare/stable/2021-08-01/examples/ShareSubscriptions_Delete.json
            // this example is just showing the usage of "ShareSubscriptions_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ShareSubscriptionResource created on azure
            // for more information of creating ShareSubscriptionResource, please refer to the document of ShareSubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "SampleResourceGroup";
            string accountName = "Account1";
            string shareSubscriptionName = "ShareSubscription1";
            ResourceIdentifier shareSubscriptionResourceId = ShareSubscriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, shareSubscriptionName);
            ShareSubscriptionResource shareSubscription = client.GetShareSubscriptionResource(shareSubscriptionResourceId);

            // invoke the operation
            ArmOperation<DataShareOperationResult> lro = await shareSubscription.DeleteAsync(WaitUntil.Completed);
            DataShareOperationResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // ConsumerSourceDataSets_ListByShareSubscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetConsumerSourceDataSets_ConsumerSourceDataSetsListByShareSubscription()
        {
            // Generated from example definition: specification/datashare/resource-manager/Microsoft.DataShare/stable/2021-08-01/examples/ConsumerSourceDataSets_ListByShareSubscription.json
            // this example is just showing the usage of "ConsumerSourceDataSets_ListByShareSubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ShareSubscriptionResource created on azure
            // for more information of creating ShareSubscriptionResource, please refer to the document of ShareSubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "SampleResourceGroup";
            string accountName = "Account1";
            string shareSubscriptionName = "Share1";
            ResourceIdentifier shareSubscriptionResourceId = ShareSubscriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, shareSubscriptionName);
            ShareSubscriptionResource shareSubscription = client.GetShareSubscriptionResource(shareSubscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (ConsumerSourceDataSet item in shareSubscription.GetConsumerSourceDataSetsAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
