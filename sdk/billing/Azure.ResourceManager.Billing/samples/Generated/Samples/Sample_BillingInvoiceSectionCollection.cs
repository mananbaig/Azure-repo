// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Billing.Models;

namespace Azure.ResourceManager.Billing.Samples
{
    public partial class Sample_BillingInvoiceSectionCollection
    {
        // InvoiceSectionsGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_InvoiceSectionsGet()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/invoiceSectionsGet.json
            // this example is just showing the usage of "InvoiceSections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingProfileResource created on azure
            // for more information of creating BillingProfileResource, please refer to the document of BillingProfileResource
            string billingAccountName = "00000000-0000-0000-0000-000000000000:00000000-0000-0000-0000-000000000000_2019-05-31";
            string billingProfileName = "xxxx-xxxx-xxx-xxx";
            ResourceIdentifier billingProfileResourceId = BillingProfileResource.CreateResourceIdentifier(billingAccountName, billingProfileName);
            BillingProfileResource billingProfile = client.GetBillingProfileResource(billingProfileResourceId);

            // get the collection of this BillingInvoiceSectionResource
            BillingInvoiceSectionCollection collection = billingProfile.GetBillingInvoiceSections();

            // invoke the operation
            string invoiceSectionName = "yyyy-yyyy-yyy-yyy";
            BillingInvoiceSectionResource result = await collection.GetAsync(invoiceSectionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BillingInvoiceSectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // InvoiceSectionsGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_InvoiceSectionsGet()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/invoiceSectionsGet.json
            // this example is just showing the usage of "InvoiceSections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingProfileResource created on azure
            // for more information of creating BillingProfileResource, please refer to the document of BillingProfileResource
            string billingAccountName = "00000000-0000-0000-0000-000000000000:00000000-0000-0000-0000-000000000000_2019-05-31";
            string billingProfileName = "xxxx-xxxx-xxx-xxx";
            ResourceIdentifier billingProfileResourceId = BillingProfileResource.CreateResourceIdentifier(billingAccountName, billingProfileName);
            BillingProfileResource billingProfile = client.GetBillingProfileResource(billingProfileResourceId);

            // get the collection of this BillingInvoiceSectionResource
            BillingInvoiceSectionCollection collection = billingProfile.GetBillingInvoiceSections();

            // invoke the operation
            string invoiceSectionName = "yyyy-yyyy-yyy-yyy";
            bool result = await collection.ExistsAsync(invoiceSectionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // InvoiceSectionsGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_InvoiceSectionsGet()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/invoiceSectionsGet.json
            // this example is just showing the usage of "InvoiceSections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingProfileResource created on azure
            // for more information of creating BillingProfileResource, please refer to the document of BillingProfileResource
            string billingAccountName = "00000000-0000-0000-0000-000000000000:00000000-0000-0000-0000-000000000000_2019-05-31";
            string billingProfileName = "xxxx-xxxx-xxx-xxx";
            ResourceIdentifier billingProfileResourceId = BillingProfileResource.CreateResourceIdentifier(billingAccountName, billingProfileName);
            BillingProfileResource billingProfile = client.GetBillingProfileResource(billingProfileResourceId);

            // get the collection of this BillingInvoiceSectionResource
            BillingInvoiceSectionCollection collection = billingProfile.GetBillingInvoiceSections();

            // invoke the operation
            string invoiceSectionName = "yyyy-yyyy-yyy-yyy";
            NullableResponse<BillingInvoiceSectionResource> response = await collection.GetIfExistsAsync(invoiceSectionName);
            BillingInvoiceSectionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                BillingInvoiceSectionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // InvoiceSectionsCreateOrUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_InvoiceSectionsCreateOrUpdate()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/invoiceSectionsCreateOrUpdate.json
            // this example is just showing the usage of "InvoiceSections_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingProfileResource created on azure
            // for more information of creating BillingProfileResource, please refer to the document of BillingProfileResource
            string billingAccountName = "00000000-0000-0000-0000-000000000000:00000000-0000-0000-0000-000000000000_2019-05-31";
            string billingProfileName = "xxxx-xxxx-xxx-xxx";
            ResourceIdentifier billingProfileResourceId = BillingProfileResource.CreateResourceIdentifier(billingAccountName, billingProfileName);
            BillingProfileResource billingProfile = client.GetBillingProfileResource(billingProfileResourceId);

            // get the collection of this BillingInvoiceSectionResource
            BillingInvoiceSectionCollection collection = billingProfile.GetBillingInvoiceSections();

            // invoke the operation
            string invoiceSectionName = "invoice-section-1";
            BillingInvoiceSectionData data = new BillingInvoiceSectionData()
            {
                Properties = new BillingInvoiceSectionProperties()
                {
                    DisplayName = "Invoice Section 1",
                    Tags =
{
["costCategory"] = "Support",
["pcCode"] = "A123456",
},
                },
            };
            ArmOperation<BillingInvoiceSectionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, invoiceSectionName, data);
            BillingInvoiceSectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BillingInvoiceSectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // InvoiceSectionsListByBillingProfile
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_InvoiceSectionsListByBillingProfile()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/invoiceSectionsListByBillingProfile.json
            // this example is just showing the usage of "InvoiceSections_ListByBillingProfile" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingProfileResource created on azure
            // for more information of creating BillingProfileResource, please refer to the document of BillingProfileResource
            string billingAccountName = "00000000-0000-0000-0000-000000000000:00000000-0000-0000-0000-000000000000_2019-05-31";
            string billingProfileName = "xxxx-xxxx-xxx-xxx";
            ResourceIdentifier billingProfileResourceId = BillingProfileResource.CreateResourceIdentifier(billingAccountName, billingProfileName);
            BillingProfileResource billingProfile = client.GetBillingProfileResource(billingProfileResourceId);

            // get the collection of this BillingInvoiceSectionResource
            BillingInvoiceSectionCollection collection = billingProfile.GetBillingInvoiceSections();

            // invoke the operation and iterate over the result
            BillingInvoiceSectionCollectionGetAllOptions options = new BillingInvoiceSectionCollectionGetAllOptions() { IncludeDeleted = true };
            await foreach (BillingInvoiceSectionResource item in collection.GetAllAsync(options))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                BillingInvoiceSectionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
