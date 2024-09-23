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
    public partial class Sample_LinkResourceFormatCollection
    {
        // Links_CreateOrUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_LinksCreateOrUpdate()
        {
            // Generated from example definition: specification/customer-insights/resource-manager/Microsoft.CustomerInsights/stable/2017-04-26/examples/LinksCreateOrUpdate.json
            // this example is just showing the usage of "Links_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this LinkResourceFormatResource
            LinkResourceFormatCollection collection = hub.GetLinkResourceFormats();

            // invoke the operation
            string linkName = "linkTest4806";
            LinkResourceFormatData data = new LinkResourceFormatData()
            {
                SourceEntityType = EntityType.Interaction,
                TargetEntityType = EntityType.Profile,
                SourceEntityTypeName = "testInteraction1949",
                TargetEntityTypeName = "testProfile1446",
                DisplayName =
{
["en-us"] = "Link DisplayName",
},
                Description =
{
["en-us"] = "Link Description",
},
                Mappings =
{
new TypePropertiesMapping("testInteraction1949","testProfile1446")
{
LinkType = LinkType.UpdateAlways,
}
},
                ParticipantPropertyReferences =
{
new ParticipantPropertyReference("testInteraction1949","ProfileId")
},
            };
            ArmOperation<LinkResourceFormatResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, linkName, data);
            LinkResourceFormatResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            LinkResourceFormatData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Links_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_LinksGet()
        {
            // Generated from example definition: specification/customer-insights/resource-manager/Microsoft.CustomerInsights/stable/2017-04-26/examples/LinksGet.json
            // this example is just showing the usage of "Links_Get" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this LinkResourceFormatResource
            LinkResourceFormatCollection collection = hub.GetLinkResourceFormats();

            // invoke the operation
            string linkName = "linkTest4806";
            LinkResourceFormatResource result = await collection.GetAsync(linkName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            LinkResourceFormatData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Links_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_LinksGet()
        {
            // Generated from example definition: specification/customer-insights/resource-manager/Microsoft.CustomerInsights/stable/2017-04-26/examples/LinksGet.json
            // this example is just showing the usage of "Links_Get" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this LinkResourceFormatResource
            LinkResourceFormatCollection collection = hub.GetLinkResourceFormats();

            // invoke the operation
            string linkName = "linkTest4806";
            bool result = await collection.ExistsAsync(linkName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Links_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_LinksGet()
        {
            // Generated from example definition: specification/customer-insights/resource-manager/Microsoft.CustomerInsights/stable/2017-04-26/examples/LinksGet.json
            // this example is just showing the usage of "Links_Get" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this LinkResourceFormatResource
            LinkResourceFormatCollection collection = hub.GetLinkResourceFormats();

            // invoke the operation
            string linkName = "linkTest4806";
            NullableResponse<LinkResourceFormatResource> response = await collection.GetIfExistsAsync(linkName);
            LinkResourceFormatResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                LinkResourceFormatData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Links_ListByHub
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_LinksListByHub()
        {
            // Generated from example definition: specification/customer-insights/resource-manager/Microsoft.CustomerInsights/stable/2017-04-26/examples/LinksListByHub.json
            // this example is just showing the usage of "Links_ListByHub" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this LinkResourceFormatResource
            LinkResourceFormatCollection collection = hub.GetLinkResourceFormats();

            // invoke the operation and iterate over the result
            await foreach (LinkResourceFormatResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                LinkResourceFormatData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
