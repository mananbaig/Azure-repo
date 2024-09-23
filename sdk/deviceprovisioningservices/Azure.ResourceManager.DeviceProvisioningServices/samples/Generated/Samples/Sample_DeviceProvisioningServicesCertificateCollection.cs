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
    public partial class Sample_DeviceProvisioningServicesCertificateCollection
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

            // this example assumes you already have this DeviceProvisioningServiceResource created on azure
            // for more information of creating DeviceProvisioningServiceResource, please refer to the document of DeviceProvisioningServiceResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string provisioningServiceName = "myFirstProvisioningService";
            ResourceIdentifier deviceProvisioningServiceResourceId = DeviceProvisioningServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, provisioningServiceName);
            DeviceProvisioningServiceResource deviceProvisioningService = client.GetDeviceProvisioningServiceResource(deviceProvisioningServiceResourceId);

            // get the collection of this DeviceProvisioningServicesCertificateResource
            DeviceProvisioningServicesCertificateCollection collection = deviceProvisioningService.GetDeviceProvisioningServicesCertificates();

            // invoke the operation
            string certificateName = "cert";
            DeviceProvisioningServicesCertificateResource result = await collection.GetAsync(certificateName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DeviceProvisioningServicesCertificateData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // DPSGetCertificate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_DPSGetCertificate()
        {
            // Generated from example definition: specification/deviceprovisioningservices/resource-manager/Microsoft.Devices/stable/2022-02-05/examples/DPSGetCertificate.json
            // this example is just showing the usage of "DpsCertificate_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DeviceProvisioningServiceResource created on azure
            // for more information of creating DeviceProvisioningServiceResource, please refer to the document of DeviceProvisioningServiceResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string provisioningServiceName = "myFirstProvisioningService";
            ResourceIdentifier deviceProvisioningServiceResourceId = DeviceProvisioningServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, provisioningServiceName);
            DeviceProvisioningServiceResource deviceProvisioningService = client.GetDeviceProvisioningServiceResource(deviceProvisioningServiceResourceId);

            // get the collection of this DeviceProvisioningServicesCertificateResource
            DeviceProvisioningServicesCertificateCollection collection = deviceProvisioningService.GetDeviceProvisioningServicesCertificates();

            // invoke the operation
            string certificateName = "cert";
            bool result = await collection.ExistsAsync(certificateName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // DPSGetCertificate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_DPSGetCertificate()
        {
            // Generated from example definition: specification/deviceprovisioningservices/resource-manager/Microsoft.Devices/stable/2022-02-05/examples/DPSGetCertificate.json
            // this example is just showing the usage of "DpsCertificate_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DeviceProvisioningServiceResource created on azure
            // for more information of creating DeviceProvisioningServiceResource, please refer to the document of DeviceProvisioningServiceResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string provisioningServiceName = "myFirstProvisioningService";
            ResourceIdentifier deviceProvisioningServiceResourceId = DeviceProvisioningServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, provisioningServiceName);
            DeviceProvisioningServiceResource deviceProvisioningService = client.GetDeviceProvisioningServiceResource(deviceProvisioningServiceResourceId);

            // get the collection of this DeviceProvisioningServicesCertificateResource
            DeviceProvisioningServicesCertificateCollection collection = deviceProvisioningService.GetDeviceProvisioningServicesCertificates();

            // invoke the operation
            string certificateName = "cert";
            NullableResponse<DeviceProvisioningServicesCertificateResource> response = await collection.GetIfExistsAsync(certificateName);
            DeviceProvisioningServicesCertificateResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DeviceProvisioningServicesCertificateData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // DPSCreateOrUpdateCertificate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_DPSCreateOrUpdateCertificate()
        {
            // Generated from example definition: specification/deviceprovisioningservices/resource-manager/Microsoft.Devices/stable/2022-02-05/examples/DPSCertificateCreateOrUpdate.json
            // this example is just showing the usage of "DpsCertificate_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DeviceProvisioningServiceResource created on azure
            // for more information of creating DeviceProvisioningServiceResource, please refer to the document of DeviceProvisioningServiceResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string provisioningServiceName = "myFirstProvisioningService";
            ResourceIdentifier deviceProvisioningServiceResourceId = DeviceProvisioningServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, provisioningServiceName);
            DeviceProvisioningServiceResource deviceProvisioningService = client.GetDeviceProvisioningServiceResource(deviceProvisioningServiceResourceId);

            // get the collection of this DeviceProvisioningServicesCertificateResource
            DeviceProvisioningServicesCertificateCollection collection = deviceProvisioningService.GetDeviceProvisioningServicesCertificates();

            // invoke the operation
            string certificateName = "cert";
            DeviceProvisioningServicesCertificateData data = new DeviceProvisioningServicesCertificateData()
            {
                Properties = new DeviceProvisioningServicesCertificateProperties()
                {
                    Certificate = BinaryData.FromString("\"############################################\""),
                },
            };
            ArmOperation<DeviceProvisioningServicesCertificateResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, certificateName, data);
            DeviceProvisioningServicesCertificateResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DeviceProvisioningServicesCertificateData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // DPSGetCertificates
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_DPSGetCertificates()
        {
            // Generated from example definition: specification/deviceprovisioningservices/resource-manager/Microsoft.Devices/stable/2022-02-05/examples/DPSGetCertificates.json
            // this example is just showing the usage of "DpsCertificate_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DeviceProvisioningServiceResource created on azure
            // for more information of creating DeviceProvisioningServiceResource, please refer to the document of DeviceProvisioningServiceResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string provisioningServiceName = "myFirstProvisioningService";
            ResourceIdentifier deviceProvisioningServiceResourceId = DeviceProvisioningServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, provisioningServiceName);
            DeviceProvisioningServiceResource deviceProvisioningService = client.GetDeviceProvisioningServiceResource(deviceProvisioningServiceResourceId);

            // get the collection of this DeviceProvisioningServicesCertificateResource
            DeviceProvisioningServicesCertificateCollection collection = deviceProvisioningService.GetDeviceProvisioningServicesCertificates();

            // invoke the operation and iterate over the result
            await foreach (DeviceProvisioningServicesCertificateResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DeviceProvisioningServicesCertificateData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
