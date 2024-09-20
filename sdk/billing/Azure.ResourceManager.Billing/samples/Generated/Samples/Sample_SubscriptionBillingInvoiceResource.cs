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
    public partial class Sample_SubscriptionBillingInvoiceResource
    {
        // InvoicesDownloadByBillingSubscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task DownloadByBillingSubscription_InvoicesDownloadByBillingSubscription()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/invoicesDownloadByBillingSubscription.json
            // this example is just showing the usage of "Invoices_DownloadByBillingSubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionBillingInvoiceResource created on azure
            // for more information of creating SubscriptionBillingInvoiceResource, please refer to the document of SubscriptionBillingInvoiceResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string invoiceName = "E123456789";
            ResourceIdentifier subscriptionBillingInvoiceResourceId = SubscriptionBillingInvoiceResource.CreateResourceIdentifier(subscriptionId, invoiceName);
            SubscriptionBillingInvoiceResource subscriptionBillingInvoice = client.GetSubscriptionBillingInvoiceResource(subscriptionBillingInvoiceResourceId);

            // invoke the operation
            string documentName = "12345678";
            ArmOperation<BillingDocumentDownloadResult> lro = await subscriptionBillingInvoice.DownloadByBillingSubscriptionAsync(WaitUntil.Completed, documentName: documentName);
            BillingDocumentDownloadResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // InvoicesGetByBillingSubscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_InvoicesGetByBillingSubscription()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/invoicesGetByBillingSubscription.json
            // this example is just showing the usage of "Invoices_GetByBillingSubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionBillingInvoiceResource created on azure
            // for more information of creating SubscriptionBillingInvoiceResource, please refer to the document of SubscriptionBillingInvoiceResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string invoiceName = "E123456789";
            ResourceIdentifier subscriptionBillingInvoiceResourceId = SubscriptionBillingInvoiceResource.CreateResourceIdentifier(subscriptionId, invoiceName);
            SubscriptionBillingInvoiceResource subscriptionBillingInvoice = client.GetSubscriptionBillingInvoiceResource(subscriptionBillingInvoiceResourceId);

            // invoke the operation
            SubscriptionBillingInvoiceResource result = await subscriptionBillingInvoice.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BillingInvoiceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
