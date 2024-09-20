// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Cdn.Models;

namespace Azure.ResourceManager.Cdn.Samples
{
    public partial class Sample_FrontDoorSecurityPolicyCollection
    {
        // SecurityPolicies_ListByProfile
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_SecurityPoliciesListByProfile()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2024-02-01/examples/SecurityPolicies_ListByProfile.json
            // this example is just showing the usage of "FrontDoorSecurityPolicies_ListByProfile" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ProfileResource created on azure
            // for more information of creating ProfileResource, please refer to the document of ProfileResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "RG";
            string profileName = "profile1";
            ResourceIdentifier profileResourceId = ProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName);
            ProfileResource profile = client.GetProfileResource(profileResourceId);

            // get the collection of this FrontDoorSecurityPolicyResource
            FrontDoorSecurityPolicyCollection collection = profile.GetFrontDoorSecurityPolicies();

            // invoke the operation and iterate over the result
            await foreach (FrontDoorSecurityPolicyResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                FrontDoorSecurityPolicyData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // SecurityPolicies_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_SecurityPoliciesGet()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2024-02-01/examples/SecurityPolicies_Get.json
            // this example is just showing the usage of "FrontDoorSecurityPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ProfileResource created on azure
            // for more information of creating ProfileResource, please refer to the document of ProfileResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "RG";
            string profileName = "profile1";
            ResourceIdentifier profileResourceId = ProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName);
            ProfileResource profile = client.GetProfileResource(profileResourceId);

            // get the collection of this FrontDoorSecurityPolicyResource
            FrontDoorSecurityPolicyCollection collection = profile.GetFrontDoorSecurityPolicies();

            // invoke the operation
            string securityPolicyName = "securityPolicy1";
            FrontDoorSecurityPolicyResource result = await collection.GetAsync(securityPolicyName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FrontDoorSecurityPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // SecurityPolicies_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_SecurityPoliciesGet()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2024-02-01/examples/SecurityPolicies_Get.json
            // this example is just showing the usage of "FrontDoorSecurityPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ProfileResource created on azure
            // for more information of creating ProfileResource, please refer to the document of ProfileResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "RG";
            string profileName = "profile1";
            ResourceIdentifier profileResourceId = ProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName);
            ProfileResource profile = client.GetProfileResource(profileResourceId);

            // get the collection of this FrontDoorSecurityPolicyResource
            FrontDoorSecurityPolicyCollection collection = profile.GetFrontDoorSecurityPolicies();

            // invoke the operation
            string securityPolicyName = "securityPolicy1";
            bool result = await collection.ExistsAsync(securityPolicyName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // SecurityPolicies_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_SecurityPoliciesGet()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2024-02-01/examples/SecurityPolicies_Get.json
            // this example is just showing the usage of "FrontDoorSecurityPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ProfileResource created on azure
            // for more information of creating ProfileResource, please refer to the document of ProfileResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "RG";
            string profileName = "profile1";
            ResourceIdentifier profileResourceId = ProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName);
            ProfileResource profile = client.GetProfileResource(profileResourceId);

            // get the collection of this FrontDoorSecurityPolicyResource
            FrontDoorSecurityPolicyCollection collection = profile.GetFrontDoorSecurityPolicies();

            // invoke the operation
            string securityPolicyName = "securityPolicy1";
            NullableResponse<FrontDoorSecurityPolicyResource> response = await collection.GetIfExistsAsync(securityPolicyName);
            FrontDoorSecurityPolicyResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                FrontDoorSecurityPolicyData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // SecurityPolicies_Create
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_SecurityPoliciesCreate()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2024-02-01/examples/SecurityPolicies_Create.json
            // this example is just showing the usage of "FrontDoorSecurityPolicies_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ProfileResource created on azure
            // for more information of creating ProfileResource, please refer to the document of ProfileResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "RG";
            string profileName = "profile1";
            ResourceIdentifier profileResourceId = ProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName);
            ProfileResource profile = client.GetProfileResource(profileResourceId);

            // get the collection of this FrontDoorSecurityPolicyResource
            FrontDoorSecurityPolicyCollection collection = profile.GetFrontDoorSecurityPolicies();

            // invoke the operation
            string securityPolicyName = "securityPolicy1";
            FrontDoorSecurityPolicyData data = new FrontDoorSecurityPolicyData()
            {
                Properties = new SecurityPolicyWebApplicationFirewall()
                {
                    WafPolicyId = new ResourceIdentifier("/subscriptions/subid/resourcegroups/RG/providers/Microsoft.Network/frontdoorwebapplicationfirewallpolicies/wafTest"),
                    Associations =
{
new SecurityPolicyWebApplicationFirewallAssociation()
{
Domains =
{
new FrontDoorActivatedResourceInfo()
{
Id = new ResourceIdentifier("/subscriptions/subid/resourcegroups/RG/providers/Microsoft.Cdn/profiles/profile1/customdomains/testdomain1"),
},new FrontDoorActivatedResourceInfo()
{
Id = new ResourceIdentifier("/subscriptions/subid/resourcegroups/RG/providers/Microsoft.Cdn/profiles/profile1/customdomains/testdomain2"),
}
},
PatternsToMatch =
{
"/*"
},
}
},
                },
            };
            ArmOperation<FrontDoorSecurityPolicyResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, securityPolicyName, data);
            FrontDoorSecurityPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FrontDoorSecurityPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
