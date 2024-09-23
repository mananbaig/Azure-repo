// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.DataShare.Samples
{
    public partial class Sample_ProviderShareSubscriptionResource
    {
        // ProviderShareSubscriptions_Adjust
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Adjust_ProviderShareSubscriptionsAdjust()
        {
            // Generated from example definition: specification/datashare/resource-manager/Microsoft.DataShare/stable/2021-08-01/examples/ProviderShareSubscriptions_Adjust.json
            // this example is just showing the usage of "ProviderShareSubscriptions_Adjust" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ProviderShareSubscriptionResource created on azure
            // for more information of creating ProviderShareSubscriptionResource, please refer to the document of ProviderShareSubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "SampleResourceGroup";
            string accountName = "Account1";
            string shareName = "Share1";
            string providerShareSubscriptionId = "4256e2cf-0f82-4865-961b-12f83333f487";
            ResourceIdentifier providerShareSubscriptionResourceId = ProviderShareSubscriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, shareName, providerShareSubscriptionId);
            ProviderShareSubscriptionResource providerShareSubscription = client.GetProviderShareSubscriptionResource(providerShareSubscriptionResourceId);

            // invoke the operation
            ProviderShareSubscriptionData data = new ProviderShareSubscriptionData()
            {
                ExpireOn = DateTimeOffset.Parse("2020-12-26T22:33:24.5785265Z"),
            };
            ProviderShareSubscriptionResource result = await providerShareSubscription.AdjustAsync(data);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ProviderShareSubscriptionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ProviderShareSubscriptions_Reinstate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Reinstate_ProviderShareSubscriptionsReinstate()
        {
            // Generated from example definition: specification/datashare/resource-manager/Microsoft.DataShare/stable/2021-08-01/examples/ProviderShareSubscriptions_Reinstate.json
            // this example is just showing the usage of "ProviderShareSubscriptions_Reinstate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ProviderShareSubscriptionResource created on azure
            // for more information of creating ProviderShareSubscriptionResource, please refer to the document of ProviderShareSubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "SampleResourceGroup";
            string accountName = "Account1";
            string shareName = "Share1";
            string providerShareSubscriptionId = "4256e2cf-0f82-4865-961b-12f83333f487";
            ResourceIdentifier providerShareSubscriptionResourceId = ProviderShareSubscriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, shareName, providerShareSubscriptionId);
            ProviderShareSubscriptionResource providerShareSubscription = client.GetProviderShareSubscriptionResource(providerShareSubscriptionResourceId);

            // invoke the operation
            ProviderShareSubscriptionData data = new ProviderShareSubscriptionData()
            {
                ExpireOn = DateTimeOffset.Parse("2020-12-26T22:33:24.5785265Z"),
            };
            ProviderShareSubscriptionResource result = await providerShareSubscription.ReinstateAsync(data);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ProviderShareSubscriptionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ProviderShareSubscriptions_Revoke
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Revoke_ProviderShareSubscriptionsRevoke()
        {
            // Generated from example definition: specification/datashare/resource-manager/Microsoft.DataShare/stable/2021-08-01/examples/ProviderShareSubscriptions_Revoke.json
            // this example is just showing the usage of "ProviderShareSubscriptions_Revoke" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ProviderShareSubscriptionResource created on azure
            // for more information of creating ProviderShareSubscriptionResource, please refer to the document of ProviderShareSubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "SampleResourceGroup";
            string accountName = "Account1";
            string shareName = "Share1";
            string providerShareSubscriptionId = "4256e2cf-0f82-4865-961b-12f83333f487";
            ResourceIdentifier providerShareSubscriptionResourceId = ProviderShareSubscriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, shareName, providerShareSubscriptionId);
            ProviderShareSubscriptionResource providerShareSubscription = client.GetProviderShareSubscriptionResource(providerShareSubscriptionResourceId);

            // invoke the operation
            ArmOperation<ProviderShareSubscriptionResource> lro = await providerShareSubscription.RevokeAsync(WaitUntil.Completed);
            ProviderShareSubscriptionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ProviderShareSubscriptionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ProviderShareSubscriptions_GetByShare
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ProviderShareSubscriptionsGetByShare()
        {
            // Generated from example definition: specification/datashare/resource-manager/Microsoft.DataShare/stable/2021-08-01/examples/ProviderShareSubscriptions_GetByShare.json
            // this example is just showing the usage of "ProviderShareSubscriptions_GetByShare" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ProviderShareSubscriptionResource created on azure
            // for more information of creating ProviderShareSubscriptionResource, please refer to the document of ProviderShareSubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "SampleResourceGroup";
            string accountName = "Account1";
            string shareName = "Share1";
            string providerShareSubscriptionId = "4256e2cf-0f82-4865-961b-12f83333f487";
            ResourceIdentifier providerShareSubscriptionResourceId = ProviderShareSubscriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, shareName, providerShareSubscriptionId);
            ProviderShareSubscriptionResource providerShareSubscription = client.GetProviderShareSubscriptionResource(providerShareSubscriptionResourceId);

            // invoke the operation
            ProviderShareSubscriptionResource result = await providerShareSubscription.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ProviderShareSubscriptionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
