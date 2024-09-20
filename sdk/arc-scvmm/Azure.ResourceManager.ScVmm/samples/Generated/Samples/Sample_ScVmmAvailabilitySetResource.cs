// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.ScVmm.Models;

namespace Azure.ResourceManager.ScVmm.Samples
{
    public partial class Sample_ScVmmAvailabilitySetResource
    {
        // GetAvailabilitySet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAvailabilitySet()
        {
            // Generated from example definition: specification/scvmm/resource-manager/Microsoft.ScVmm/stable/2023-10-07/examples/GetAvailabilitySet.json
            // this example is just showing the usage of "AvailabilitySets_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ScVmmAvailabilitySetResource created on azure
            // for more information of creating ScVmmAvailabilitySetResource, please refer to the document of ScVmmAvailabilitySetResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "testrg";
            string availabilitySetResourceName = "HRAvailabilitySet";
            ResourceIdentifier scVmmAvailabilitySetResourceId = ScVmmAvailabilitySetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, availabilitySetResourceName);
            ScVmmAvailabilitySetResource scVmmAvailabilitySet = client.GetScVmmAvailabilitySetResource(scVmmAvailabilitySetResourceId);

            // invoke the operation
            ScVmmAvailabilitySetResource result = await scVmmAvailabilitySet.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ScVmmAvailabilitySetData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // DeleteAvailabilitySet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteAvailabilitySet()
        {
            // Generated from example definition: specification/scvmm/resource-manager/Microsoft.ScVmm/stable/2023-10-07/examples/DeleteAvailabilitySet.json
            // this example is just showing the usage of "AvailabilitySets_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ScVmmAvailabilitySetResource created on azure
            // for more information of creating ScVmmAvailabilitySetResource, please refer to the document of ScVmmAvailabilitySetResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "testrg";
            string availabilitySetResourceName = "HRAvailabilitySet";
            ResourceIdentifier scVmmAvailabilitySetResourceId = ScVmmAvailabilitySetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, availabilitySetResourceName);
            ScVmmAvailabilitySetResource scVmmAvailabilitySet = client.GetScVmmAvailabilitySetResource(scVmmAvailabilitySetResourceId);

            // invoke the operation
            await scVmmAvailabilitySet.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // UpdateAvailabilitySet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateAvailabilitySet()
        {
            // Generated from example definition: specification/scvmm/resource-manager/Microsoft.ScVmm/stable/2023-10-07/examples/UpdateAvailabilitySet.json
            // this example is just showing the usage of "AvailabilitySets_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ScVmmAvailabilitySetResource created on azure
            // for more information of creating ScVmmAvailabilitySetResource, please refer to the document of ScVmmAvailabilitySetResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "testrg";
            string availabilitySetResourceName = "HRAvailabilitySet";
            ResourceIdentifier scVmmAvailabilitySetResourceId = ScVmmAvailabilitySetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, availabilitySetResourceName);
            ScVmmAvailabilitySetResource scVmmAvailabilitySet = client.GetScVmmAvailabilitySetResource(scVmmAvailabilitySetResourceId);

            // invoke the operation
            ScVmmResourcePatch patch = new ScVmmResourcePatch()
            {
                Tags =
{
["tag1"] = "value1",
["tag2"] = "value2",
},
            };
            ArmOperation<ScVmmAvailabilitySetResource> lro = await scVmmAvailabilitySet.UpdateAsync(WaitUntil.Completed, patch);
            ScVmmAvailabilitySetResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ScVmmAvailabilitySetData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ListAvailabilitySetsBySubscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetScVmmAvailabilitySets_ListAvailabilitySetsBySubscription()
        {
            // Generated from example definition: specification/scvmm/resource-manager/Microsoft.ScVmm/stable/2023-10-07/examples/ListAvailabilitySetsBySubscription.json
            // this example is just showing the usage of "AvailabilitySets_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

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
            await foreach (ScVmmAvailabilitySetResource item in subscriptionResource.GetScVmmAvailabilitySetsAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ScVmmAvailabilitySetData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
