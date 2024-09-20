// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Automation.Models;

namespace Azure.ResourceManager.Automation.Samples
{
    public partial class Sample_AutomationCertificateCollection
    {
        // Get a certificate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetACertificate()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/preview/2020-01-13-preview/examples/getCertificate.json
            // this example is just showing the usage of "Certificate_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationAccountResource created on azure
            // for more information of creating AutomationAccountResource, please refer to the document of AutomationAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg";
            string automationAccountName = "myAutomationAccount33";
            ResourceIdentifier automationAccountResourceId = AutomationAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName);
            AutomationAccountResource automationAccount = client.GetAutomationAccountResource(automationAccountResourceId);

            // get the collection of this AutomationCertificateResource
            AutomationCertificateCollection collection = automationAccount.GetAutomationCertificates();

            // invoke the operation
            string certificateName = "testCert";
            AutomationCertificateResource result = await collection.GetAsync(certificateName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AutomationCertificateData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a certificate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetACertificate()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/preview/2020-01-13-preview/examples/getCertificate.json
            // this example is just showing the usage of "Certificate_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationAccountResource created on azure
            // for more information of creating AutomationAccountResource, please refer to the document of AutomationAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg";
            string automationAccountName = "myAutomationAccount33";
            ResourceIdentifier automationAccountResourceId = AutomationAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName);
            AutomationAccountResource automationAccount = client.GetAutomationAccountResource(automationAccountResourceId);

            // get the collection of this AutomationCertificateResource
            AutomationCertificateCollection collection = automationAccount.GetAutomationCertificates();

            // invoke the operation
            string certificateName = "testCert";
            bool result = await collection.ExistsAsync(certificateName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get a certificate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetACertificate()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/preview/2020-01-13-preview/examples/getCertificate.json
            // this example is just showing the usage of "Certificate_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationAccountResource created on azure
            // for more information of creating AutomationAccountResource, please refer to the document of AutomationAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg";
            string automationAccountName = "myAutomationAccount33";
            ResourceIdentifier automationAccountResourceId = AutomationAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName);
            AutomationAccountResource automationAccount = client.GetAutomationAccountResource(automationAccountResourceId);

            // get the collection of this AutomationCertificateResource
            AutomationCertificateCollection collection = automationAccount.GetAutomationCertificates();

            // invoke the operation
            string certificateName = "testCert";
            NullableResponse<AutomationCertificateResource> response = await collection.GetIfExistsAsync(certificateName);
            AutomationCertificateResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AutomationCertificateData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Create or update a certificate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateACertificate()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/preview/2020-01-13-preview/examples/createOrUpdateCertificate.json
            // this example is just showing the usage of "Certificate_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationAccountResource created on azure
            // for more information of creating AutomationAccountResource, please refer to the document of AutomationAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg";
            string automationAccountName = "myAutomationAccount18";
            ResourceIdentifier automationAccountResourceId = AutomationAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName);
            AutomationAccountResource automationAccount = client.GetAutomationAccountResource(automationAccountResourceId);

            // get the collection of this AutomationCertificateResource
            AutomationCertificateCollection collection = automationAccount.GetAutomationCertificates();

            // invoke the operation
            string certificateName = "testCert";
            AutomationCertificateCreateOrUpdateContent content = new AutomationCertificateCreateOrUpdateContent("testCert", "base 64 value of cert")
            {
                Description = "Sample Cert",
                ThumbprintString = "thumbprint of cert",
                IsExportable = false,
            };
            ArmOperation<AutomationCertificateResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, certificateName, content);
            AutomationCertificateResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AutomationCertificateData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // List certificates
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListCertificates()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/preview/2020-01-13-preview/examples/listCertificatesByAutomationAccount.json
            // this example is just showing the usage of "Certificate_ListByAutomationAccount" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationAccountResource created on azure
            // for more information of creating AutomationAccountResource, please refer to the document of AutomationAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg";
            string automationAccountName = "myAutomationAccount33";
            ResourceIdentifier automationAccountResourceId = AutomationAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName);
            AutomationAccountResource automationAccount = client.GetAutomationAccountResource(automationAccountResourceId);

            // get the collection of this AutomationCertificateResource
            AutomationCertificateCollection collection = automationAccount.GetAutomationCertificates();

            // invoke the operation and iterate over the result
            await foreach (AutomationCertificateResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AutomationCertificateData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
