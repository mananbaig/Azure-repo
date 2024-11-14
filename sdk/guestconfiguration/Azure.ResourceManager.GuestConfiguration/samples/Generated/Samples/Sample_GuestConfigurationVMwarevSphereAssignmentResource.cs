// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.GuestConfiguration.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.GuestConfiguration.Samples
{
    public partial class Sample_GuestConfigurationVMwarevSphereAssignmentResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreateOrUpdateGuestConfigurationAssignment()
        {
            // Generated from example definition: specification/guestconfiguration/resource-manager/Microsoft.GuestConfiguration/stable/2024-04-05/examples/createOrUpdateGuestConfigurationConnectedVMwarevSphereAssignment.json
            // this example is just showing the usage of "GuestConfigurationConnectedVMwarevSphereAssignments_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GuestConfigurationVMwarevSphereAssignmentResource created on azure
            // for more information of creating GuestConfigurationVMwarevSphereAssignmentResource, please refer to the document of GuestConfigurationVMwarevSphereAssignmentResource
            string subscriptionId = "mySubscriptionId";
            string resourceGroupName = "myResourceGroupName";
            string vmName = "myVMName";
            string guestConfigurationAssignmentName = "NotInstalledApplicationForWindows";
            ResourceIdentifier guestConfigurationVMwarevSphereAssignmentResourceId = GuestConfigurationVMwarevSphereAssignmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vmName, guestConfigurationAssignmentName);
            GuestConfigurationVMwarevSphereAssignmentResource guestConfigurationVMwarevSphereAssignment = client.GetGuestConfigurationVMwarevSphereAssignmentResource(guestConfigurationVMwarevSphereAssignmentResourceId);

            // invoke the operation
            GuestConfigurationAssignmentData data = new GuestConfigurationAssignmentData()
            {
                Properties = new GuestConfigurationAssignmentProperties()
                {
                    GuestConfiguration = new GuestConfigurationNavigation()
                    {
                        Name = "NotInstalledApplicationForWindows",
                        Version = "1.0.0.0",
                        ContentUri = new Uri("https://thisisfake/pacakge"),
                        ContentHash = "123contenthash",
                        AssignmentType = GuestConfigurationAssignmentType.ApplyAndAutoCorrect,
                        ConfigurationParameters =
{
new GuestConfigurationParameter()
{
Name = "[InstalledApplication]NotInstalledApplicationResource1;Name",
Value = "NotePad,sql",
}
},
                    },
                    Context = "Azure policy",
                },
                Name = "NotInstalledApplicationForWindows",
                Location = new AzureLocation("westcentralus"),
            };
            ArmOperation<GuestConfigurationVMwarevSphereAssignmentResource> lro = await guestConfigurationVMwarevSphereAssignment.UpdateAsync(WaitUntil.Completed, data);
            GuestConfigurationVMwarevSphereAssignmentResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            GuestConfigurationAssignmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAGuestConfigurationAssignment()
        {
            // Generated from example definition: specification/guestconfiguration/resource-manager/Microsoft.GuestConfiguration/stable/2024-04-05/examples/getGuestConfigurationConnectedVMwarevSphereAssignment.json
            // this example is just showing the usage of "GuestConfigurationConnectedVMwarevSphereAssignments_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GuestConfigurationVMwarevSphereAssignmentResource created on azure
            // for more information of creating GuestConfigurationVMwarevSphereAssignmentResource, please refer to the document of GuestConfigurationVMwarevSphereAssignmentResource
            string subscriptionId = "mySubscriptionId";
            string resourceGroupName = "myResourceGroupName";
            string vmName = "myVMName";
            string guestConfigurationAssignmentName = "SecureProtocol";
            ResourceIdentifier guestConfigurationVMwarevSphereAssignmentResourceId = GuestConfigurationVMwarevSphereAssignmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vmName, guestConfigurationAssignmentName);
            GuestConfigurationVMwarevSphereAssignmentResource guestConfigurationVMwarevSphereAssignment = client.GetGuestConfigurationVMwarevSphereAssignmentResource(guestConfigurationVMwarevSphereAssignmentResourceId);

            // invoke the operation
            GuestConfigurationVMwarevSphereAssignmentResource result = await guestConfigurationVMwarevSphereAssignment.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            GuestConfigurationAssignmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteAnGuestConfigurationAssignment()
        {
            // Generated from example definition: specification/guestconfiguration/resource-manager/Microsoft.GuestConfiguration/stable/2024-04-05/examples/deleteGuestConfigurationConnectedVMwarevSphereAssignment.json
            // this example is just showing the usage of "GuestConfigurationConnectedVMwarevSphereAssignments_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GuestConfigurationVMwarevSphereAssignmentResource created on azure
            // for more information of creating GuestConfigurationVMwarevSphereAssignmentResource, please refer to the document of GuestConfigurationVMwarevSphereAssignmentResource
            string subscriptionId = "mySubscriptionId";
            string resourceGroupName = "myResourceGroupName";
            string vmName = "myVMName";
            string guestConfigurationAssignmentName = "SecureProtocol";
            ResourceIdentifier guestConfigurationVMwarevSphereAssignmentResourceId = GuestConfigurationVMwarevSphereAssignmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vmName, guestConfigurationAssignmentName);
            GuestConfigurationVMwarevSphereAssignmentResource guestConfigurationVMwarevSphereAssignment = client.GetGuestConfigurationVMwarevSphereAssignmentResource(guestConfigurationVMwarevSphereAssignmentResourceId);

            // invoke the operation
            await guestConfigurationVMwarevSphereAssignment.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetGuestConfigurationConnectedVMwarevSphereAssignmentsReports_ListAllGuestConfigurationAssignmentsForAVirtualMachine()
        {
            // Generated from example definition: specification/guestconfiguration/resource-manager/Microsoft.GuestConfiguration/stable/2024-04-05/examples/listAllGuestConfigurationConnectedVMwarevSphereAssignmentsReports.json
            // this example is just showing the usage of "GuestConfigurationConnectedVMwarevSphereAssignmentsReports_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GuestConfigurationVMwarevSphereAssignmentResource created on azure
            // for more information of creating GuestConfigurationVMwarevSphereAssignmentResource, please refer to the document of GuestConfigurationVMwarevSphereAssignmentResource
            string subscriptionId = "mySubscriptionid";
            string resourceGroupName = "myResourceGroupName";
            string vmName = "myVMName";
            string guestConfigurationAssignmentName = "AuditSecureProtocol";
            ResourceIdentifier guestConfigurationVMwarevSphereAssignmentResourceId = GuestConfigurationVMwarevSphereAssignmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vmName, guestConfigurationAssignmentName);
            GuestConfigurationVMwarevSphereAssignmentResource guestConfigurationVMwarevSphereAssignment = client.GetGuestConfigurationVMwarevSphereAssignmentResource(guestConfigurationVMwarevSphereAssignmentResourceId);

            // invoke the operation and iterate over the result
            await foreach (GuestConfigurationAssignmentReport item in guestConfigurationVMwarevSphereAssignment.GetGuestConfigurationConnectedVMwarevSphereAssignmentsReportsAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetGuestConfigurationConnectedVMwarevSphereAssignmentsReport_GetAGuestConfigurationAssignmentReportByIdForAVirtualMachine()
        {
            // Generated from example definition: specification/guestconfiguration/resource-manager/Microsoft.GuestConfiguration/stable/2024-04-05/examples/getGuestConfigurationConnectedVMwarevSphereAssignmentReportById.json
            // this example is just showing the usage of "GuestConfigurationConnectedVMwarevSphereAssignmentsReports_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GuestConfigurationVMwarevSphereAssignmentResource created on azure
            // for more information of creating GuestConfigurationVMwarevSphereAssignmentResource, please refer to the document of GuestConfigurationVMwarevSphereAssignmentResource
            string subscriptionId = "mySubscriptionid";
            string resourceGroupName = "myResourceGroupName";
            string vmName = "myvm";
            string guestConfigurationAssignmentName = "AuditSecureProtocol";
            ResourceIdentifier guestConfigurationVMwarevSphereAssignmentResourceId = GuestConfigurationVMwarevSphereAssignmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vmName, guestConfigurationAssignmentName);
            GuestConfigurationVMwarevSphereAssignmentResource guestConfigurationVMwarevSphereAssignment = client.GetGuestConfigurationVMwarevSphereAssignmentResource(guestConfigurationVMwarevSphereAssignmentResourceId);

            // invoke the operation
            string reportId = "7367cbb8-ae99-47d0-a33b-a283564d2cb1";
            GuestConfigurationAssignmentReport result = await guestConfigurationVMwarevSphereAssignment.GetGuestConfigurationConnectedVMwarevSphereAssignmentsReportAsync(reportId);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
