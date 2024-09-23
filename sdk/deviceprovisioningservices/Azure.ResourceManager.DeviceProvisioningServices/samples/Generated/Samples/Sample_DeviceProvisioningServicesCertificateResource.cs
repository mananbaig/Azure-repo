// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.DeviceProvisioningServices.Models;

namespace Azure.ResourceManager.DeviceProvisioningServices.Samples
{
    public partial class Sample_DeviceProvisioningServicesCertificateResource
    {
        // DPSGetCertificate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_DPSGetCertificate()
        {
            // Generated from example definition: specification/deviceprovisioningservices/resource-manager/Microsoft.Devices/stable/2022-02-05/examples/DPSGetCertificate.json
            // this example is just showing the usage of "DpsCertificate_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DeviceProvisioningServicesCertificateResource created on azure
            // for more information of creating DeviceProvisioningServicesCertificateResource, please refer to the document of DeviceProvisioningServicesCertificateResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string provisioningServiceName = "myFirstProvisioningService";
            string certificateName = "cert";
            ResourceIdentifier deviceProvisioningServicesCertificateResourceId = DeviceProvisioningServicesCertificateResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, provisioningServiceName, certificateName);
            DeviceProvisioningServicesCertificateResource deviceProvisioningServicesCertificate = client.GetDeviceProvisioningServicesCertificateResource(deviceProvisioningServicesCertificateResourceId);

            // invoke the operation
            DeviceProvisioningServicesCertificateResource result = await deviceProvisioningServicesCertificate.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DeviceProvisioningServicesCertificateData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // DPSCreateOrUpdateCertificate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_DPSCreateOrUpdateCertificate()
        {
            // Generated from example definition: specification/deviceprovisioningservices/resource-manager/Microsoft.Devices/stable/2022-02-05/examples/DPSCertificateCreateOrUpdate.json
            // this example is just showing the usage of "DpsCertificate_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DeviceProvisioningServicesCertificateResource created on azure
            // for more information of creating DeviceProvisioningServicesCertificateResource, please refer to the document of DeviceProvisioningServicesCertificateResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string provisioningServiceName = "myFirstProvisioningService";
            string certificateName = "cert";
            ResourceIdentifier deviceProvisioningServicesCertificateResourceId = DeviceProvisioningServicesCertificateResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, provisioningServiceName, certificateName);
            DeviceProvisioningServicesCertificateResource deviceProvisioningServicesCertificate = client.GetDeviceProvisioningServicesCertificateResource(deviceProvisioningServicesCertificateResourceId);

            // invoke the operation
            DeviceProvisioningServicesCertificateData data = new DeviceProvisioningServicesCertificateData()
            {
                Properties = new DeviceProvisioningServicesCertificateProperties()
                {
                    Certificate = BinaryData.FromString("\"############################################\""),
                },
            };
            ArmOperation<DeviceProvisioningServicesCertificateResource> lro = await deviceProvisioningServicesCertificate.UpdateAsync(WaitUntil.Completed, data);
            DeviceProvisioningServicesCertificateResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DeviceProvisioningServicesCertificateData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // DPSDeleteCertificate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DPSDeleteCertificate()
        {
            // Generated from example definition: specification/deviceprovisioningservices/resource-manager/Microsoft.Devices/stable/2022-02-05/examples/DPSDeleteCertificate.json
            // this example is just showing the usage of "DpsCertificate_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DeviceProvisioningServicesCertificateResource created on azure
            // for more information of creating DeviceProvisioningServicesCertificateResource, please refer to the document of DeviceProvisioningServicesCertificateResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string provisioningServiceName = "myFirstProvisioningService";
            string certificateName = "cert";
            ResourceIdentifier deviceProvisioningServicesCertificateResourceId = DeviceProvisioningServicesCertificateResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, provisioningServiceName, certificateName);
            DeviceProvisioningServicesCertificateResource deviceProvisioningServicesCertificate = client.GetDeviceProvisioningServicesCertificateResource(deviceProvisioningServicesCertificateResourceId);

            // invoke the operation
            DeviceProvisioningServicesCertificateResourceDeleteOptions options = new DeviceProvisioningServicesCertificateResourceDeleteOptions(ifMatch: "AAAAAAAADGk=") { };
            await deviceProvisioningServicesCertificate.DeleteAsync(WaitUntil.Completed, options);

            Console.WriteLine($"Succeeded");
        }

        // DPSGenerateVerificationCode
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GenerateVerificationCode_DPSGenerateVerificationCode()
        {
            // Generated from example definition: specification/deviceprovisioningservices/resource-manager/Microsoft.Devices/stable/2022-02-05/examples/DPSGenerateVerificationCode.json
            // this example is just showing the usage of "DpsCertificate_GenerateVerificationCode" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DeviceProvisioningServicesCertificateResource created on azure
            // for more information of creating DeviceProvisioningServicesCertificateResource, please refer to the document of DeviceProvisioningServicesCertificateResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string provisioningServiceName = "myFirstProvisioningService";
            string certificateName = "cert";
            ResourceIdentifier deviceProvisioningServicesCertificateResourceId = DeviceProvisioningServicesCertificateResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, provisioningServiceName, certificateName);
            DeviceProvisioningServicesCertificateResource deviceProvisioningServicesCertificate = client.GetDeviceProvisioningServicesCertificateResource(deviceProvisioningServicesCertificateResourceId);

            // invoke the operation
            DeviceProvisioningServicesCertificateResourceGenerateVerificationCodeOptions options = new DeviceProvisioningServicesCertificateResourceGenerateVerificationCodeOptions(ifMatch: "AAAAAAAADGk=") { };
            CertificateVerificationCodeResult result = await deviceProvisioningServicesCertificate.GenerateVerificationCodeAsync(options);

            Console.WriteLine($"Succeeded: {result}");
        }

        // DPSVerifyCertificate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task VerifyCertificate_DPSVerifyCertificate()
        {
            // Generated from example definition: specification/deviceprovisioningservices/resource-manager/Microsoft.Devices/stable/2022-02-05/examples/DPSVerifyCertificate.json
            // this example is just showing the usage of "DpsCertificate_VerifyCertificate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DeviceProvisioningServicesCertificateResource created on azure
            // for more information of creating DeviceProvisioningServicesCertificateResource, please refer to the document of DeviceProvisioningServicesCertificateResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string provisioningServiceName = "myFirstProvisioningService";
            string certificateName = "cert";
            ResourceIdentifier deviceProvisioningServicesCertificateResourceId = DeviceProvisioningServicesCertificateResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, provisioningServiceName, certificateName);
            DeviceProvisioningServicesCertificateResource deviceProvisioningServicesCertificate = client.GetDeviceProvisioningServicesCertificateResource(deviceProvisioningServicesCertificateResourceId);

            // invoke the operation
            DeviceProvisioningServicesCertificateResourceVerifyCertificateOptions options = new DeviceProvisioningServicesCertificateResourceVerifyCertificateOptions(ifMatch: "AAAAAAAADGk=", content: new CertificateVerificationCodeContent()
            {
                Certificate = "#####################################",
            })
            { };
            DeviceProvisioningServicesCertificateResource result = await deviceProvisioningServicesCertificate.VerifyCertificateAsync(options);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DeviceProvisioningServicesCertificateData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
