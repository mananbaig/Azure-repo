// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Purview.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Purview.Samples
{
    public partial class Sample_PurviewKafkaConfigurationCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_KafkaConfigurationsListByAccount()
        {
            // Generated from example definition: specification/purview/resource-manager/Microsoft.Purview/preview/2023-05-01-preview/examples/KafkaConfigurations_ListByAccount.json
            // this example is just showing the usage of "KafkaConfigurations_ListByAccount" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PurviewAccountResource created on azure
            // for more information of creating PurviewAccountResource, please refer to the document of PurviewAccountResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "rgpurview";
            string accountName = "account1";
            ResourceIdentifier purviewAccountResourceId = PurviewAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            PurviewAccountResource purviewAccount = client.GetPurviewAccountResource(purviewAccountResourceId);

            // get the collection of this PurviewKafkaConfigurationResource
            PurviewKafkaConfigurationCollection collection = purviewAccount.GetPurviewKafkaConfigurations();

            // invoke the operation and iterate over the result
            string skipToken = "token";
            await foreach (PurviewKafkaConfigurationResource item in collection.GetAllAsync(skipToken: skipToken))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                PurviewKafkaConfigurationData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_KafkaConfigurationsGet()
        {
            // Generated from example definition: specification/purview/resource-manager/Microsoft.Purview/preview/2023-05-01-preview/examples/KafkaConfigurations_Get.json
            // this example is just showing the usage of "KafkaConfigurations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PurviewAccountResource created on azure
            // for more information of creating PurviewAccountResource, please refer to the document of PurviewAccountResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "rgpurview";
            string accountName = "account1";
            ResourceIdentifier purviewAccountResourceId = PurviewAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            PurviewAccountResource purviewAccount = client.GetPurviewAccountResource(purviewAccountResourceId);

            // get the collection of this PurviewKafkaConfigurationResource
            PurviewKafkaConfigurationCollection collection = purviewAccount.GetPurviewKafkaConfigurations();

            // invoke the operation
            string kafkaConfigurationName = "kafkaConfigName";
            PurviewKafkaConfigurationResource result = await collection.GetAsync(kafkaConfigurationName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PurviewKafkaConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_KafkaConfigurationsGet()
        {
            // Generated from example definition: specification/purview/resource-manager/Microsoft.Purview/preview/2023-05-01-preview/examples/KafkaConfigurations_Get.json
            // this example is just showing the usage of "KafkaConfigurations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PurviewAccountResource created on azure
            // for more information of creating PurviewAccountResource, please refer to the document of PurviewAccountResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "rgpurview";
            string accountName = "account1";
            ResourceIdentifier purviewAccountResourceId = PurviewAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            PurviewAccountResource purviewAccount = client.GetPurviewAccountResource(purviewAccountResourceId);

            // get the collection of this PurviewKafkaConfigurationResource
            PurviewKafkaConfigurationCollection collection = purviewAccount.GetPurviewKafkaConfigurations();

            // invoke the operation
            string kafkaConfigurationName = "kafkaConfigName";
            bool result = await collection.ExistsAsync(kafkaConfigurationName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_KafkaConfigurationsGet()
        {
            // Generated from example definition: specification/purview/resource-manager/Microsoft.Purview/preview/2023-05-01-preview/examples/KafkaConfigurations_Get.json
            // this example is just showing the usage of "KafkaConfigurations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PurviewAccountResource created on azure
            // for more information of creating PurviewAccountResource, please refer to the document of PurviewAccountResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "rgpurview";
            string accountName = "account1";
            ResourceIdentifier purviewAccountResourceId = PurviewAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            PurviewAccountResource purviewAccount = client.GetPurviewAccountResource(purviewAccountResourceId);

            // get the collection of this PurviewKafkaConfigurationResource
            PurviewKafkaConfigurationCollection collection = purviewAccount.GetPurviewKafkaConfigurations();

            // invoke the operation
            string kafkaConfigurationName = "kafkaConfigName";
            NullableResponse<PurviewKafkaConfigurationResource> response = await collection.GetIfExistsAsync(kafkaConfigurationName);
            PurviewKafkaConfigurationResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                PurviewKafkaConfigurationData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_KafkaConfigurationsCreateOrUpdate()
        {
            // Generated from example definition: specification/purview/resource-manager/Microsoft.Purview/preview/2023-05-01-preview/examples/KafkaConfigurations_CreateOrUpdate.json
            // this example is just showing the usage of "KafkaConfigurations_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PurviewAccountResource created on azure
            // for more information of creating PurviewAccountResource, please refer to the document of PurviewAccountResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "rgpurview";
            string accountName = "account1";
            ResourceIdentifier purviewAccountResourceId = PurviewAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            PurviewAccountResource purviewAccount = client.GetPurviewAccountResource(purviewAccountResourceId);

            // get the collection of this PurviewKafkaConfigurationResource
            PurviewKafkaConfigurationCollection collection = purviewAccount.GetPurviewKafkaConfigurations();

            // invoke the operation
            string kafkaConfigurationName = "kafkaConfigName";
            PurviewKafkaConfigurationData data = new PurviewKafkaConfigurationData()
            {
                ConsumerGroup = "consumerGroup",
                Credentials = new PurviewCredentials()
                {
                    IdentityId = "/subscriptions/47e8596d-ee73-4eb2-b6b4-cc13c2b87ssd/resourceGroups/testRG/providers/Microsoft.ManagedIdentity/userAssignedIdentities/testId",
                    CredentialsType = PurviewCredentialsType.UserAssigned,
                },
                EventHubPartitionId = "partitionId",
                EventHubResourceId = new ResourceIdentifier("/subscriptions/225be6fe-ec1c-4d51-a368-f69348d2e6c5/resourceGroups/testRG/providers/Microsoft.EventHub/namespaces/eventHubNameSpaceName"),
                EventHubType = PurviewKafkaEventHubType.Notification,
                EventStreamingState = PurviewEventStreamingState.Enabled,
                EventStreamingType = PurviewEventStreamingType.Azure,
            };
            ArmOperation<PurviewKafkaConfigurationResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, kafkaConfigurationName, data);
            PurviewKafkaConfigurationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PurviewKafkaConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
