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
    public partial class Sample_FrontDoorSecurityPolicyResource
    {
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

            // this example assumes you already have this FrontDoorSecurityPolicyResource created on azure
            // for more information of creating FrontDoorSecurityPolicyResource, please refer to the document of FrontDoorSecurityPolicyResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "RG";
            string profileName = "profile1";
            string securityPolicyName = "securityPolicy1";
            ResourceIdentifier frontDoorSecurityPolicyResourceId = FrontDoorSecurityPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName, securityPolicyName);
            FrontDoorSecurityPolicyResource frontDoorSecurityPolicy = client.GetFrontDoorSecurityPolicyResource(frontDoorSecurityPolicyResourceId);

            // invoke the operation
            FrontDoorSecurityPolicyResource result = await frontDoorSecurityPolicy.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FrontDoorSecurityPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // SecurityPolicies_Patch
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_SecurityPoliciesPatch()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2024-02-01/examples/SecurityPolicies_Patch.json
            // this example is just showing the usage of "FrontDoorSecurityPolicies_Patch" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FrontDoorSecurityPolicyResource created on azure
            // for more information of creating FrontDoorSecurityPolicyResource, please refer to the document of FrontDoorSecurityPolicyResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "RG";
            string profileName = "profile1";
            string securityPolicyName = "securityPolicy1";
            ResourceIdentifier frontDoorSecurityPolicyResourceId = FrontDoorSecurityPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName, securityPolicyName);
            FrontDoorSecurityPolicyResource frontDoorSecurityPolicy = client.GetFrontDoorSecurityPolicyResource(frontDoorSecurityPolicyResourceId);

            // invoke the operation
            FrontDoorSecurityPolicyPatch patch = new FrontDoorSecurityPolicyPatch()
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
            ArmOperation<FrontDoorSecurityPolicyResource> lro = await frontDoorSecurityPolicy.UpdateAsync(WaitUntil.Completed, patch);
            FrontDoorSecurityPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FrontDoorSecurityPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // SecurityPolicies_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_SecurityPoliciesDelete()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2024-02-01/examples/SecurityPolicies_Delete.json
            // this example is just showing the usage of "FrontDoorSecurityPolicies_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FrontDoorSecurityPolicyResource created on azure
            // for more information of creating FrontDoorSecurityPolicyResource, please refer to the document of FrontDoorSecurityPolicyResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "RG";
            string profileName = "profile1";
            string securityPolicyName = "securityPolicy1";
            ResourceIdentifier frontDoorSecurityPolicyResourceId = FrontDoorSecurityPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName, securityPolicyName);
            FrontDoorSecurityPolicyResource frontDoorSecurityPolicy = client.GetFrontDoorSecurityPolicyResource(frontDoorSecurityPolicyResourceId);

            // invoke the operation
            await frontDoorSecurityPolicy.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
