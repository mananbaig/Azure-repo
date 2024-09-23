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
    public partial class Sample_RelationshipLinkResourceFormatResource
    {
        // RelationshipLinks_CreateOrUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_RelationshipLinksCreateOrUpdate()
        {
            // Generated from example definition: specification/customer-insights/resource-manager/Microsoft.CustomerInsights/stable/2017-04-26/examples/RelationshipLinksCreateOrUpdate.json
            // this example is just showing the usage of "RelationshipLinks_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RelationshipLinkResourceFormatResource created on azure
            // for more information of creating RelationshipLinkResourceFormatResource, please refer to the document of RelationshipLinkResourceFormatResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "TestHubRG";
            string hubName = "sdkTestHub";
            string relationshipLinkName = "Somelink";
            ResourceIdentifier relationshipLinkResourceFormatResourceId = RelationshipLinkResourceFormatResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hubName, relationshipLinkName);
            RelationshipLinkResourceFormatResource relationshipLinkResourceFormat = client.GetRelationshipLinkResourceFormatResource(relationshipLinkResourceFormatResourceId);

            // invoke the operation
            RelationshipLinkResourceFormatData data = new RelationshipLinkResourceFormatData()
            {
                DisplayName =
{
["en-us"] = "Link DisplayName",
},
                Description =
{
["en-us"] = "Link Description",
},
                InteractionType = "testInteraction4332",
                ProfilePropertyReferences =
{
new ParticipantProfilePropertyReference("profile1","ProfileId")
},
                RelatedProfilePropertyReferences =
{
new ParticipantProfilePropertyReference("profile1","ProfileId")
},
                RelationshipName = "testProfile2326994",
            };
            ArmOperation<RelationshipLinkResourceFormatResource> lro = await relationshipLinkResourceFormat.UpdateAsync(WaitUntil.Completed, data);
            RelationshipLinkResourceFormatResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RelationshipLinkResourceFormatData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // RelationshipLinks_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_RelationshipLinksGet()
        {
            // Generated from example definition: specification/customer-insights/resource-manager/Microsoft.CustomerInsights/stable/2017-04-26/examples/RelationshipLinksGet.json
            // this example is just showing the usage of "RelationshipLinks_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RelationshipLinkResourceFormatResource created on azure
            // for more information of creating RelationshipLinkResourceFormatResource, please refer to the document of RelationshipLinkResourceFormatResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "TestHubRG";
            string hubName = "sdkTestHub";
            string relationshipLinkName = "Somelink";
            ResourceIdentifier relationshipLinkResourceFormatResourceId = RelationshipLinkResourceFormatResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hubName, relationshipLinkName);
            RelationshipLinkResourceFormatResource relationshipLinkResourceFormat = client.GetRelationshipLinkResourceFormatResource(relationshipLinkResourceFormatResourceId);

            // invoke the operation
            RelationshipLinkResourceFormatResource result = await relationshipLinkResourceFormat.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RelationshipLinkResourceFormatData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // RelationshipLinks_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_RelationshipLinksDelete()
        {
            // Generated from example definition: specification/customer-insights/resource-manager/Microsoft.CustomerInsights/stable/2017-04-26/examples/RelationshipLinksDelete.json
            // this example is just showing the usage of "RelationshipLinks_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RelationshipLinkResourceFormatResource created on azure
            // for more information of creating RelationshipLinkResourceFormatResource, please refer to the document of RelationshipLinkResourceFormatResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "TestHubRG";
            string hubName = "sdkTestHub";
            string relationshipLinkName = "Somelink";
            ResourceIdentifier relationshipLinkResourceFormatResourceId = RelationshipLinkResourceFormatResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hubName, relationshipLinkName);
            RelationshipLinkResourceFormatResource relationshipLinkResourceFormat = client.GetRelationshipLinkResourceFormatResource(relationshipLinkResourceFormatResourceId);

            // invoke the operation
            await relationshipLinkResourceFormat.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
