// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.Automanage.Samples
{
    public partial class Sample_AutomanageVmConfigurationProfileAssignmentReportCollection
    {
        // Get a report for a configuration profile assignment
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAReportForAConfigurationProfileAssignment()
        {
            // Generated from example definition: specification/automanage/resource-manager/Microsoft.Automanage/stable/2022-05-04/examples/getReport.json
            // this example is just showing the usage of "reports_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomanageVmConfigurationProfileAssignmentResource created on azure
            // for more information of creating AutomanageVmConfigurationProfileAssignmentResource, please refer to the document of AutomanageVmConfigurationProfileAssignmentResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroupName";
            string vmName = "myVMName";
            string configurationProfileAssignmentName = "default";
            ResourceIdentifier automanageVmConfigurationProfileAssignmentResourceId = AutomanageVmConfigurationProfileAssignmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vmName, configurationProfileAssignmentName);
            AutomanageVmConfigurationProfileAssignmentResource automanageVmConfigurationProfileAssignment = client.GetAutomanageVmConfigurationProfileAssignmentResource(automanageVmConfigurationProfileAssignmentResourceId);

            // get the collection of this AutomanageVmConfigurationProfileAssignmentReportResource
            AutomanageVmConfigurationProfileAssignmentReportCollection collection = automanageVmConfigurationProfileAssignment.GetAutomanageVmConfigurationProfileAssignmentReports();

            // invoke the operation
            string reportName = "b4e9ee6b-1717-4ff0-a8d2-e6d72c33d5f4";
            AutomanageVmConfigurationProfileAssignmentReportResource result = await collection.GetAsync(reportName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AutomanageConfigurationProfileAssignmentReportData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a report for a configuration profile assignment
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetAReportForAConfigurationProfileAssignment()
        {
            // Generated from example definition: specification/automanage/resource-manager/Microsoft.Automanage/stable/2022-05-04/examples/getReport.json
            // this example is just showing the usage of "reports_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomanageVmConfigurationProfileAssignmentResource created on azure
            // for more information of creating AutomanageVmConfigurationProfileAssignmentResource, please refer to the document of AutomanageVmConfigurationProfileAssignmentResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroupName";
            string vmName = "myVMName";
            string configurationProfileAssignmentName = "default";
            ResourceIdentifier automanageVmConfigurationProfileAssignmentResourceId = AutomanageVmConfigurationProfileAssignmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vmName, configurationProfileAssignmentName);
            AutomanageVmConfigurationProfileAssignmentResource automanageVmConfigurationProfileAssignment = client.GetAutomanageVmConfigurationProfileAssignmentResource(automanageVmConfigurationProfileAssignmentResourceId);

            // get the collection of this AutomanageVmConfigurationProfileAssignmentReportResource
            AutomanageVmConfigurationProfileAssignmentReportCollection collection = automanageVmConfigurationProfileAssignment.GetAutomanageVmConfigurationProfileAssignmentReports();

            // invoke the operation
            string reportName = "b4e9ee6b-1717-4ff0-a8d2-e6d72c33d5f4";
            bool result = await collection.ExistsAsync(reportName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get a report for a configuration profile assignment
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetAReportForAConfigurationProfileAssignment()
        {
            // Generated from example definition: specification/automanage/resource-manager/Microsoft.Automanage/stable/2022-05-04/examples/getReport.json
            // this example is just showing the usage of "reports_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomanageVmConfigurationProfileAssignmentResource created on azure
            // for more information of creating AutomanageVmConfigurationProfileAssignmentResource, please refer to the document of AutomanageVmConfigurationProfileAssignmentResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroupName";
            string vmName = "myVMName";
            string configurationProfileAssignmentName = "default";
            ResourceIdentifier automanageVmConfigurationProfileAssignmentResourceId = AutomanageVmConfigurationProfileAssignmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vmName, configurationProfileAssignmentName);
            AutomanageVmConfigurationProfileAssignmentResource automanageVmConfigurationProfileAssignment = client.GetAutomanageVmConfigurationProfileAssignmentResource(automanageVmConfigurationProfileAssignmentResourceId);

            // get the collection of this AutomanageVmConfigurationProfileAssignmentReportResource
            AutomanageVmConfigurationProfileAssignmentReportCollection collection = automanageVmConfigurationProfileAssignment.GetAutomanageVmConfigurationProfileAssignmentReports();

            // invoke the operation
            string reportName = "b4e9ee6b-1717-4ff0-a8d2-e6d72c33d5f4";
            NullableResponse<AutomanageVmConfigurationProfileAssignmentReportResource> response = await collection.GetIfExistsAsync(reportName);
            AutomanageVmConfigurationProfileAssignmentReportResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AutomanageConfigurationProfileAssignmentReportData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // List reports by configuration profiles assignment
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListReportsByConfigurationProfilesAssignment()
        {
            // Generated from example definition: specification/automanage/resource-manager/Microsoft.Automanage/stable/2022-05-04/examples/listReportsByconfigurationProfileAssignment.json
            // this example is just showing the usage of "reports_ListByConfigurationProfileAssignments" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomanageVmConfigurationProfileAssignmentResource created on azure
            // for more information of creating AutomanageVmConfigurationProfileAssignmentResource, please refer to the document of AutomanageVmConfigurationProfileAssignmentResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroupName";
            string vmName = "myVMName";
            string configurationProfileAssignmentName = "default";
            ResourceIdentifier automanageVmConfigurationProfileAssignmentResourceId = AutomanageVmConfigurationProfileAssignmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vmName, configurationProfileAssignmentName);
            AutomanageVmConfigurationProfileAssignmentResource automanageVmConfigurationProfileAssignment = client.GetAutomanageVmConfigurationProfileAssignmentResource(automanageVmConfigurationProfileAssignmentResourceId);

            // get the collection of this AutomanageVmConfigurationProfileAssignmentReportResource
            AutomanageVmConfigurationProfileAssignmentReportCollection collection = automanageVmConfigurationProfileAssignment.GetAutomanageVmConfigurationProfileAssignmentReports();

            // invoke the operation and iterate over the result
            await foreach (AutomanageVmConfigurationProfileAssignmentReportResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AutomanageConfigurationProfileAssignmentReportData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
