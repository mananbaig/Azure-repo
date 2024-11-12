// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.EventGrid.Samples
{
    public partial class Sample_CaCertificateResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_CaCertificatesGet()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2024-06-01-preview/examples/CaCertificates_Get.json
            // this example is just showing the usage of "CaCertificates_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CaCertificateResource created on azure
            // for more information of creating CaCertificateResource, please refer to the document of CaCertificateResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string namespaceName = "exampleNamespaceName1";
            string caCertificateName = "exampleCACertificateName1";
            ResourceIdentifier caCertificateResourceId = CaCertificateResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, caCertificateName);
            CaCertificateResource caCertificate = client.GetCaCertificateResource(caCertificateResourceId);

            // invoke the operation
            CaCertificateResource result = await caCertificate.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CaCertificateData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CaCertificatesCreateOrUpdate()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2024-06-01-preview/examples/CaCertificates_CreateOrUpdate.json
            // this example is just showing the usage of "CaCertificates_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CaCertificateResource created on azure
            // for more information of creating CaCertificateResource, please refer to the document of CaCertificateResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string namespaceName = "exampleNamespaceName1";
            string caCertificateName = "exampleCACertificateName1";
            ResourceIdentifier caCertificateResourceId = CaCertificateResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, caCertificateName);
            CaCertificateResource caCertificate = client.GetCaCertificateResource(caCertificateResourceId);

            // invoke the operation
            CaCertificateData data = new CaCertificateData()
            {
                Description = "This is a test certificate",
                EncodedCertificate = "base64EncodePemFormattedCertificateString",
            };
            ArmOperation<CaCertificateResource> lro = await caCertificate.UpdateAsync(WaitUntil.Completed, data);
            CaCertificateResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CaCertificateData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_CaCertificatesDelete()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2024-06-01-preview/examples/CaCertificates_Delete.json
            // this example is just showing the usage of "CaCertificates_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CaCertificateResource created on azure
            // for more information of creating CaCertificateResource, please refer to the document of CaCertificateResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string namespaceName = "exampleNamespaceName1";
            string caCertificateName = "exampleCACertificateName1";
            ResourceIdentifier caCertificateResourceId = CaCertificateResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, caCertificateName);
            CaCertificateResource caCertificate = client.GetCaCertificateResource(caCertificateResourceId);

            // invoke the operation
            await caCertificate.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }
    }
}
