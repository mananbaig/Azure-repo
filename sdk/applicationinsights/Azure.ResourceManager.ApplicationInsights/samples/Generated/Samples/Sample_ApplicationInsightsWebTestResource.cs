// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ApplicationInsights.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ApplicationInsights.Samples
{
    public partial class Sample_ApplicationInsightsWebTestResource
    {
        // webTestGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_WebTestGet()
        {
            // Generated from example definition: specification/applicationinsights/resource-manager/Microsoft.Insights/stable/2022-06-15/examples/WebTestGet.json
            // this example is just showing the usage of "WebTests_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApplicationInsightsWebTestResource created on azure
            // for more information of creating ApplicationInsightsWebTestResource, please refer to the document of ApplicationInsightsWebTestResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "my-resource-group";
            string webTestName = "my-webtest-01-mywebservice";
            ResourceIdentifier applicationInsightsWebTestResourceId = ApplicationInsightsWebTestResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, webTestName);
            ApplicationInsightsWebTestResource applicationInsightsWebTest = client.GetApplicationInsightsWebTestResource(applicationInsightsWebTestResourceId);

            // invoke the operation
            ApplicationInsightsWebTestResource result = await applicationInsightsWebTest.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApplicationInsightsWebTestData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // webTestUpdateTags
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_WebTestUpdateTags()
        {
            // Generated from example definition: specification/applicationinsights/resource-manager/Microsoft.Insights/stable/2022-06-15/examples/WebTestUpdateTagsOnly.json
            // this example is just showing the usage of "WebTests_UpdateTags" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApplicationInsightsWebTestResource created on azure
            // for more information of creating ApplicationInsightsWebTestResource, please refer to the document of ApplicationInsightsWebTestResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "my-resource-group";
            string webTestName = "my-webtest-my-component";
            ResourceIdentifier applicationInsightsWebTestResourceId = ApplicationInsightsWebTestResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, webTestName);
            ApplicationInsightsWebTestResource applicationInsightsWebTest = client.GetApplicationInsightsWebTestResource(applicationInsightsWebTestResourceId);

            // invoke the operation
            WebTestComponentTag webTestTags = new WebTestComponentTag()
            {
                Tags =
{
["Color"] = "AzureBlue",
["CustomField-01"] = "This is a random value",
["SystemType"] = "A08",
["hidden-link:/subscriptions/subid/resourceGroups/my-resource-group/providers/Microsoft.Insights/components/my-component"] = "Resource",
},
            };
            ApplicationInsightsWebTestResource result = await applicationInsightsWebTest.UpdateAsync(webTestTags);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApplicationInsightsWebTestData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // webTestDelete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_WebTestDelete()
        {
            // Generated from example definition: specification/applicationinsights/resource-manager/Microsoft.Insights/stable/2022-06-15/examples/WebTestDelete.json
            // this example is just showing the usage of "WebTests_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApplicationInsightsWebTestResource created on azure
            // for more information of creating ApplicationInsightsWebTestResource, please refer to the document of ApplicationInsightsWebTestResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "my-resource-group";
            string webTestName = "my-webtest-01-mywebservice";
            ResourceIdentifier applicationInsightsWebTestResourceId = ApplicationInsightsWebTestResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, webTestName);
            ApplicationInsightsWebTestResource applicationInsightsWebTest = client.GetApplicationInsightsWebTestResource(applicationInsightsWebTestResourceId);

            // invoke the operation
            await applicationInsightsWebTest.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // webTestList
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetApplicationInsightsWebTests_WebTestList()
        {
            // Generated from example definition: specification/applicationinsights/resource-manager/Microsoft.Insights/stable/2022-06-15/examples/WebTestList.json
            // this example is just showing the usage of "WebTests_List" operation, for the dependent resources, they will have to be created separately.

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
            await foreach (ApplicationInsightsWebTestResource item in subscriptionResource.GetApplicationInsightsWebTestsAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ApplicationInsightsWebTestData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
