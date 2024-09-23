// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.CustomerInsights.Models;

namespace Azure.ResourceManager.CustomerInsights.Samples
{
    public partial class Sample_RelationshipResourceFormatCollection
    {
        // Relationships_CreateOrUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_RelationshipsCreateOrUpdate()
        {
            // Generated from example definition: specification/customer-insights/resource-manager/Microsoft.CustomerInsights/stable/2017-04-26/examples/RelationshipsCreateOrUpdate.json
            // this example is just showing the usage of "Relationships_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HubResource created on azure
            // for more information of creating HubResource, please refer to the document of HubResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "TestHubRG";
            string hubName = "sdkTestHub";
            ResourceIdentifier hubResourceId = HubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hubName);
            HubResource hub = client.GetHubResource(hubResourceId);

            // get the collection of this RelationshipResourceFormatResource
            RelationshipResourceFormatCollection collection = hub.GetRelationshipResourceFormats();

            // invoke the operation
            string relationshipName = "SomeRelationship";
            RelationshipResourceFormatData data = new RelationshipResourceFormatData()
            {
                Cardinality = CardinalityType.OneToOne,
                DisplayName =
{
["en-us"] = "Relationship DisplayName",
},
                Description =
{
["en-us"] = "Relationship Description",
},
                Fields =
{
},
                ProfileType = "testProfile2326994",
                RelatedProfileType = "testProfile2326994",
            };
            ArmOperation<RelationshipResourceFormatResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, relationshipName, data);
            RelationshipResourceFormatResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RelationshipResourceFormatData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Relationships_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_RelationshipsGet()
        {
            // Generated from example definition: specification/customer-insights/resource-manager/Microsoft.CustomerInsights/stable/2017-04-26/examples/RelationshipsGet.json
            // this example is just showing the usage of "Relationships_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HubResource created on azure
            // for more information of creating HubResource, please refer to the document of HubResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "TestHubRG";
            string hubName = "sdkTestHub";
            ResourceIdentifier hubResourceId = HubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hubName);
            HubResource hub = client.GetHubResource(hubResourceId);

            // get the collection of this RelationshipResourceFormatResource
            RelationshipResourceFormatCollection collection = hub.GetRelationshipResourceFormats();

            // invoke the operation
            string relationshipName = "SomeRelationship";
            RelationshipResourceFormatResource result = await collection.GetAsync(relationshipName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RelationshipResourceFormatData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Relationships_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_RelationshipsGet()
        {
            // Generated from example definition: specification/customer-insights/resource-manager/Microsoft.CustomerInsights/stable/2017-04-26/examples/RelationshipsGet.json
            // this example is just showing the usage of "Relationships_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HubResource created on azure
            // for more information of creating HubResource, please refer to the document of HubResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "TestHubRG";
            string hubName = "sdkTestHub";
            ResourceIdentifier hubResourceId = HubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hubName);
            HubResource hub = client.GetHubResource(hubResourceId);

            // get the collection of this RelationshipResourceFormatResource
            RelationshipResourceFormatCollection collection = hub.GetRelationshipResourceFormats();

            // invoke the operation
            string relationshipName = "SomeRelationship";
            bool result = await collection.ExistsAsync(relationshipName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Relationships_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_RelationshipsGet()
        {
            // Generated from example definition: specification/customer-insights/resource-manager/Microsoft.CustomerInsights/stable/2017-04-26/examples/RelationshipsGet.json
            // this example is just showing the usage of "Relationships_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HubResource created on azure
            // for more information of creating HubResource, please refer to the document of HubResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "TestHubRG";
            string hubName = "sdkTestHub";
            ResourceIdentifier hubResourceId = HubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hubName);
            HubResource hub = client.GetHubResource(hubResourceId);

            // get the collection of this RelationshipResourceFormatResource
            RelationshipResourceFormatCollection collection = hub.GetRelationshipResourceFormats();

            // invoke the operation
            string relationshipName = "SomeRelationship";
            NullableResponse<RelationshipResourceFormatResource> response = await collection.GetIfExistsAsync(relationshipName);
            RelationshipResourceFormatResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                RelationshipResourceFormatData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Relationships_ListByHub
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_RelationshipsListByHub()
        {
            // Generated from example definition: specification/customer-insights/resource-manager/Microsoft.CustomerInsights/stable/2017-04-26/examples/RelationshipsListByHub.json
            // this example is just showing the usage of "Relationships_ListByHub" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HubResource created on azure
            // for more information of creating HubResource, please refer to the document of HubResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "TestHubRG";
            string hubName = "sdkTestHub";
            ResourceIdentifier hubResourceId = HubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hubName);
            HubResource hub = client.GetHubResource(hubResourceId);

            // get the collection of this RelationshipResourceFormatResource
            RelationshipResourceFormatCollection collection = hub.GetRelationshipResourceFormats();

            // invoke the operation and iterate over the result
            await foreach (RelationshipResourceFormatResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                RelationshipResourceFormatData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
