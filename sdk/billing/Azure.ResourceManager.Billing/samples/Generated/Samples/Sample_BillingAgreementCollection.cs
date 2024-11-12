// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.Billing.Samples
{
    public partial class Sample_BillingAgreementCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_AgreementByName()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/agreementByName.json
            // this example is just showing the usage of "Agreements_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingAccountResource created on azure
            // for more information of creating BillingAccountResource, please refer to the document of BillingAccountResource
            string billingAccountName = "10000000-0000-0000-0000-000000000000:00000000-0000-0000-0000-000000000000_2019-05-31";
            ResourceIdentifier billingAccountResourceId = BillingAccountResource.CreateResourceIdentifier(billingAccountName);
            BillingAccountResource billingAccount = client.GetBillingAccountResource(billingAccountResourceId);

            // get the collection of this BillingAgreementResource
            BillingAgreementCollection collection = billingAccount.GetBillingAgreements();

            // invoke the operation
            string agreementName = "ABC123";
            BillingAgreementResource result = await collection.GetAsync(agreementName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BillingAgreementData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_AgreementByName()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/agreementByName.json
            // this example is just showing the usage of "Agreements_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingAccountResource created on azure
            // for more information of creating BillingAccountResource, please refer to the document of BillingAccountResource
            string billingAccountName = "10000000-0000-0000-0000-000000000000:00000000-0000-0000-0000-000000000000_2019-05-31";
            ResourceIdentifier billingAccountResourceId = BillingAccountResource.CreateResourceIdentifier(billingAccountName);
            BillingAccountResource billingAccount = client.GetBillingAccountResource(billingAccountResourceId);

            // get the collection of this BillingAgreementResource
            BillingAgreementCollection collection = billingAccount.GetBillingAgreements();

            // invoke the operation
            string agreementName = "ABC123";
            bool result = await collection.ExistsAsync(agreementName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_AgreementByName()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/agreementByName.json
            // this example is just showing the usage of "Agreements_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingAccountResource created on azure
            // for more information of creating BillingAccountResource, please refer to the document of BillingAccountResource
            string billingAccountName = "10000000-0000-0000-0000-000000000000:00000000-0000-0000-0000-000000000000_2019-05-31";
            ResourceIdentifier billingAccountResourceId = BillingAccountResource.CreateResourceIdentifier(billingAccountName);
            BillingAccountResource billingAccount = client.GetBillingAccountResource(billingAccountResourceId);

            // get the collection of this BillingAgreementResource
            BillingAgreementCollection collection = billingAccount.GetBillingAgreements();

            // invoke the operation
            string agreementName = "ABC123";
            NullableResponse<BillingAgreementResource> response = await collection.GetIfExistsAsync(agreementName);
            BillingAgreementResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                BillingAgreementData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_AgreementsListByBillingAccount()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/agreementsListByBillingAccount.json
            // this example is just showing the usage of "Agreements_ListByBillingAccount" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingAccountResource created on azure
            // for more information of creating BillingAccountResource, please refer to the document of BillingAccountResource
            string billingAccountName = "10000000-0000-0000-0000-000000000000:00000000-0000-0000-0000-000000000000_2019-05-31";
            ResourceIdentifier billingAccountResourceId = BillingAccountResource.CreateResourceIdentifier(billingAccountName);
            BillingAccountResource billingAccount = client.GetBillingAccountResource(billingAccountResourceId);

            // get the collection of this BillingAgreementResource
            BillingAgreementCollection collection = billingAccount.GetBillingAgreements();

            // invoke the operation and iterate over the result
            string expand = "Participants";
            await foreach (BillingAgreementResource item in collection.GetAllAsync(expand: expand))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                BillingAgreementData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}
