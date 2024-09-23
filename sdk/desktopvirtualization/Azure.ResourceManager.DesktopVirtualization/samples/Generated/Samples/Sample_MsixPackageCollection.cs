// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.DesktopVirtualization.Models;

namespace Azure.ResourceManager.DesktopVirtualization.Samples
{
    public partial class Sample_MsixPackageCollection
    {
        // MSIXPackage_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_MSIXPackageGet()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/stable/2024-04-03/examples/MsixPackage_Get.json
            // this example is just showing the usage of "MSIXPackages_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HostPoolResource created on azure
            // for more information of creating HostPoolResource, please refer to the document of HostPoolResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resourceGroup1";
            string hostPoolName = "hostpool1";
            ResourceIdentifier hostPoolResourceId = HostPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hostPoolName);
            HostPoolResource hostPool = client.GetHostPoolResource(hostPoolResourceId);

            // get the collection of this MsixPackageResource
            MsixPackageCollection collection = hostPool.GetMsixPackages();

            // invoke the operation
            string msixPackageFullName = "packagefullname";
            MsixPackageResource result = await collection.GetAsync(msixPackageFullName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MsixPackageData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // MSIXPackage_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_MSIXPackageGet()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/stable/2024-04-03/examples/MsixPackage_Get.json
            // this example is just showing the usage of "MSIXPackages_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HostPoolResource created on azure
            // for more information of creating HostPoolResource, please refer to the document of HostPoolResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resourceGroup1";
            string hostPoolName = "hostpool1";
            ResourceIdentifier hostPoolResourceId = HostPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hostPoolName);
            HostPoolResource hostPool = client.GetHostPoolResource(hostPoolResourceId);

            // get the collection of this MsixPackageResource
            MsixPackageCollection collection = hostPool.GetMsixPackages();

            // invoke the operation
            string msixPackageFullName = "packagefullname";
            bool result = await collection.ExistsAsync(msixPackageFullName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // MSIXPackage_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_MSIXPackageGet()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/stable/2024-04-03/examples/MsixPackage_Get.json
            // this example is just showing the usage of "MSIXPackages_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HostPoolResource created on azure
            // for more information of creating HostPoolResource, please refer to the document of HostPoolResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resourceGroup1";
            string hostPoolName = "hostpool1";
            ResourceIdentifier hostPoolResourceId = HostPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hostPoolName);
            HostPoolResource hostPool = client.GetHostPoolResource(hostPoolResourceId);

            // get the collection of this MsixPackageResource
            MsixPackageCollection collection = hostPool.GetMsixPackages();

            // invoke the operation
            string msixPackageFullName = "packagefullname";
            NullableResponse<MsixPackageResource> response = await collection.GetIfExistsAsync(msixPackageFullName);
            MsixPackageResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MsixPackageData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // MSIXPackage_Create
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_MSIXPackageCreate()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/stable/2024-04-03/examples/MsixPackage_Create.json
            // this example is just showing the usage of "MSIXPackages_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HostPoolResource created on azure
            // for more information of creating HostPoolResource, please refer to the document of HostPoolResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resourceGroup1";
            string hostPoolName = "hostpool1";
            ResourceIdentifier hostPoolResourceId = HostPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hostPoolName);
            HostPoolResource hostPool = client.GetHostPoolResource(hostPoolResourceId);

            // get the collection of this MsixPackageResource
            MsixPackageCollection collection = hostPool.GetMsixPackages();

            // invoke the operation
            string msixPackageFullName = "msixpackagefullname";
            MsixPackageData data = new MsixPackageData()
            {
                ImagePath = "imagepath",
                PackageName = "MsixPackage_name",
                PackageFamilyName = "MsixPackage_FamilyName",
                DisplayName = "displayname",
                PackageRelativePath = "packagerelativepath",
                IsRegularRegistration = false,
                IsActive = false,
                PackageDependencies =
{
new MsixPackageDependencies()
{
DependencyName = "MsixTest_Dependency_Name",
Publisher = "PublishedName",
MinVersion = "version",
}
},
                Version = "version",
                LastUpdatedOn = DateTimeOffset.Parse("2008-09-22T14:01:54.9571247Z"),
                PackageApplications =
{
new MsixPackageApplications()
{
AppId = "ApplicationId",
Description = "application-desc",
AppUserModelId = "AppUserModelId",
FriendlyName = "friendlyname",
IconImageName = "Apptile",
RawIcon = BinaryData.FromString("\"VGhpcyBpcyBhIHN0cmluZyB0byBoYXNo\""),
RawPng = BinaryData.FromString("\"VGhpcyBpcyBhIHN0cmluZyB0byBoYXNo\""),
}
},
            };
            ArmOperation<MsixPackageResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, msixPackageFullName, data);
            MsixPackageResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MsixPackageData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // MSIXPackage_List
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_MSIXPackageList()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/stable/2024-04-03/examples/MsixPackage_List.json
            // this example is just showing the usage of "MSIXPackages_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HostPoolResource created on azure
            // for more information of creating HostPoolResource, please refer to the document of HostPoolResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resourceGroup1";
            string hostPoolName = "hostpool1";
            ResourceIdentifier hostPoolResourceId = HostPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hostPoolName);
            HostPoolResource hostPool = client.GetHostPoolResource(hostPoolResourceId);

            // get the collection of this MsixPackageResource
            MsixPackageCollection collection = hostPool.GetMsixPackages();

            // invoke the operation and iterate over the result
            int? pageSize = 10;
            bool? isDescending = true;
            int? initialSkip = 0;
            await foreach (MsixPackageResource item in collection.GetAllAsync(pageSize: pageSize, isDescending: isDescending, initialSkip: initialSkip))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MsixPackageData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
