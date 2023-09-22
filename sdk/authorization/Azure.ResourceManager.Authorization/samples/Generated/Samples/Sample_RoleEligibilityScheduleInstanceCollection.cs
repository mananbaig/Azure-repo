// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Authorization;

namespace Azure.ResourceManager.Authorization.Samples
{
    public partial class Sample_RoleEligibilityScheduleInstanceCollection
    {
        // GetRoleEligibilityScheduleInstancesByScope
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_GetRoleEligibilityScheduleInstancesByScope()
        {
            // Generated from example definition: specification/authorization/resource-manager/Microsoft.Authorization/stable/2020-10-01/examples/GetRoleEligibilityScheduleInstancesByScope.json
            // this example is just showing the usage of "RoleEligibilityScheduleInstances_ListForScope" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this RoleEligibilityScheduleInstanceResource
            string scope = "providers/Microsoft.Subscription/subscriptions/dfa2a084-766f-4003-8ae1-c4aeb893a99f";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", scope));
            RoleEligibilityScheduleInstanceCollection collection = client.GetRoleEligibilityScheduleInstances(scopeId);

            // invoke the operation and iterate over the result
            string filter = "assignedTo('a3bb8764-cb92-4276-9d2a-ca1e895e55ea')";
            await foreach (RoleEligibilityScheduleInstanceResource item in collection.GetAllAsync(filter: filter))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                RoleEligibilityScheduleInstanceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // GetRoleEligibilityScheduleInstanceByName
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetRoleEligibilityScheduleInstanceByName()
        {
            // Generated from example definition: specification/authorization/resource-manager/Microsoft.Authorization/stable/2020-10-01/examples/GetRoleEligibilityScheduleInstanceByName.json
            // this example is just showing the usage of "RoleEligibilityScheduleInstances_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this RoleEligibilityScheduleInstanceResource
            string scope = "providers/Microsoft.Subscription/subscriptions/dfa2a084-766f-4003-8ae1-c4aeb893a99f";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", scope));
            RoleEligibilityScheduleInstanceCollection collection = client.GetRoleEligibilityScheduleInstances(scopeId);

            // invoke the operation
            string roleEligibilityScheduleInstanceName = "21e4b59a-0499-4fe0-a3c3-43a3055b773a";
            RoleEligibilityScheduleInstanceResource result = await collection.GetAsync(roleEligibilityScheduleInstanceName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RoleEligibilityScheduleInstanceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // GetRoleEligibilityScheduleInstanceByName
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetRoleEligibilityScheduleInstanceByName()
        {
            // Generated from example definition: specification/authorization/resource-manager/Microsoft.Authorization/stable/2020-10-01/examples/GetRoleEligibilityScheduleInstanceByName.json
            // this example is just showing the usage of "RoleEligibilityScheduleInstances_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this RoleEligibilityScheduleInstanceResource
            string scope = "providers/Microsoft.Subscription/subscriptions/dfa2a084-766f-4003-8ae1-c4aeb893a99f";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", scope));
            RoleEligibilityScheduleInstanceCollection collection = client.GetRoleEligibilityScheduleInstances(scopeId);

            // invoke the operation
            string roleEligibilityScheduleInstanceName = "21e4b59a-0499-4fe0-a3c3-43a3055b773a";
            bool result = await collection.ExistsAsync(roleEligibilityScheduleInstanceName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // GetRoleEligibilityScheduleInstanceByName
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetRoleEligibilityScheduleInstanceByName()
        {
            // Generated from example definition: specification/authorization/resource-manager/Microsoft.Authorization/stable/2020-10-01/examples/GetRoleEligibilityScheduleInstanceByName.json
            // this example is just showing the usage of "RoleEligibilityScheduleInstances_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this RoleEligibilityScheduleInstanceResource
            string scope = "providers/Microsoft.Subscription/subscriptions/dfa2a084-766f-4003-8ae1-c4aeb893a99f";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", scope));
            RoleEligibilityScheduleInstanceCollection collection = client.GetRoleEligibilityScheduleInstances(scopeId);

            // invoke the operation
            string roleEligibilityScheduleInstanceName = "21e4b59a-0499-4fe0-a3c3-43a3055b773a";
            NullableResponse<RoleEligibilityScheduleInstanceResource> response = await collection.GetIfExistsAsync(roleEligibilityScheduleInstanceName);
            RoleEligibilityScheduleInstanceResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                RoleEligibilityScheduleInstanceData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
