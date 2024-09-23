// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.AppContainers.Models;

namespace Azure.ResourceManager.AppContainers.Samples
{
    public partial class Sample_ContainerAppManagedEnvironmentCertificateResource
    {
        // Get Certificate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetCertificate()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/stable/2024-03-01/examples/Certificate_Get.json
            // this example is just showing the usage of "Certificates_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppManagedEnvironmentCertificateResource created on azure
            // for more information of creating ContainerAppManagedEnvironmentCertificateResource, please refer to the document of ContainerAppManagedEnvironmentCertificateResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "examplerg";
            string environmentName = "testcontainerenv";
            string certificateName = "certificate-firendly-name";
            ResourceIdentifier containerAppManagedEnvironmentCertificateResourceId = ContainerAppManagedEnvironmentCertificateResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, environmentName, certificateName);
            ContainerAppManagedEnvironmentCertificateResource containerAppManagedEnvironmentCertificate = client.GetContainerAppManagedEnvironmentCertificateResource(containerAppManagedEnvironmentCertificateResourceId);

            // invoke the operation
            ContainerAppManagedEnvironmentCertificateResource result = await containerAppManagedEnvironmentCertificate.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerAppCertificateData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete Certificate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteCertificate()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/stable/2024-03-01/examples/Certificate_Delete.json
            // this example is just showing the usage of "Certificates_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppManagedEnvironmentCertificateResource created on azure
            // for more information of creating ContainerAppManagedEnvironmentCertificateResource, please refer to the document of ContainerAppManagedEnvironmentCertificateResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "examplerg";
            string environmentName = "testcontainerenv";
            string certificateName = "certificate-firendly-name";
            ResourceIdentifier containerAppManagedEnvironmentCertificateResourceId = ContainerAppManagedEnvironmentCertificateResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, environmentName, certificateName);
            ContainerAppManagedEnvironmentCertificateResource containerAppManagedEnvironmentCertificate = client.GetContainerAppManagedEnvironmentCertificateResource(containerAppManagedEnvironmentCertificateResourceId);

            // invoke the operation
            await containerAppManagedEnvironmentCertificate.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Patch Certificate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_PatchCertificate()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/stable/2024-03-01/examples/Certificates_Patch.json
            // this example is just showing the usage of "Certificates_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppManagedEnvironmentCertificateResource created on azure
            // for more information of creating ContainerAppManagedEnvironmentCertificateResource, please refer to the document of ContainerAppManagedEnvironmentCertificateResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "examplerg";
            string environmentName = "testcontainerenv";
            string certificateName = "certificate-firendly-name";
            ResourceIdentifier containerAppManagedEnvironmentCertificateResourceId = ContainerAppManagedEnvironmentCertificateResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, environmentName, certificateName);
            ContainerAppManagedEnvironmentCertificateResource containerAppManagedEnvironmentCertificate = client.GetContainerAppManagedEnvironmentCertificateResource(containerAppManagedEnvironmentCertificateResourceId);

            // invoke the operation
            ContainerAppCertificatePatch patch = new ContainerAppCertificatePatch()
            {
                Tags =
{
["tag1"] = "value1",
["tag2"] = "value2",
},
            };
            ContainerAppManagedEnvironmentCertificateResource result = await containerAppManagedEnvironmentCertificate.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerAppCertificateData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
