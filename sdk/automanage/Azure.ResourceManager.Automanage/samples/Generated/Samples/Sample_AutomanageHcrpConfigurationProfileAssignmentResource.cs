// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Automanage.Models;

namespace Azure.ResourceManager.Automanage.Samples
{
    public partial class Sample_AutomanageHcrpConfigurationProfileAssignmentResource
    {
        // Create or update HCRP configuration profile assignment
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreateOrUpdateHCRPConfigurationProfileAssignment()
        {
            // Generated from example definition: specification/automanage/resource-manager/Microsoft.Automanage/stable/2022-05-04/examples/createOrUpdateConfigurationProfileHCRPAssignment.json
            // this example is just showing the usage of "ConfigurationProfileHCRPAssignments_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomanageHcrpConfigurationProfileAssignmentResource created on azure
            // for more information of creating AutomanageHcrpConfigurationProfileAssignmentResource, please refer to the document of AutomanageHcrpConfigurationProfileAssignmentResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroupName";
            string machineName = "myMachineName";
            string configurationProfileAssignmentName = "default";
            ResourceIdentifier automanageHcrpConfigurationProfileAssignmentResourceId = AutomanageHcrpConfigurationProfileAssignmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, machineName, configurationProfileAssignmentName);
            AutomanageHcrpConfigurationProfileAssignmentResource automanageHcrpConfigurationProfileAssignment = client.GetAutomanageHcrpConfigurationProfileAssignmentResource(automanageHcrpConfigurationProfileAssignmentResourceId);

            // invoke the operation
            AutomanageConfigurationProfileAssignmentData data = new AutomanageConfigurationProfileAssignmentData()
            {
                Properties = new AutomanageConfigurationProfileAssignmentProperties()
                {
                    ConfigurationProfile = new ResourceIdentifier("/providers/Microsoft.Automanage/bestPractices/AzureBestPracticesProduction"),
                },
            };
            ArmOperation<AutomanageHcrpConfigurationProfileAssignmentResource> lro = await automanageHcrpConfigurationProfileAssignment.UpdateAsync(WaitUntil.Completed, data);
            AutomanageHcrpConfigurationProfileAssignmentResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AutomanageConfigurationProfileAssignmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a HCRP configuration profile assignment
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAHCRPConfigurationProfileAssignment()
        {
            // Generated from example definition: specification/automanage/resource-manager/Microsoft.Automanage/stable/2022-05-04/examples/getConfigurationProfileHCRPAssignment.json
            // this example is just showing the usage of "ConfigurationProfileHCRPAssignments_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomanageHcrpConfigurationProfileAssignmentResource created on azure
            // for more information of creating AutomanageHcrpConfigurationProfileAssignmentResource, please refer to the document of AutomanageHcrpConfigurationProfileAssignmentResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroupName";
            string machineName = "myMachineName";
            string configurationProfileAssignmentName = "default";
            ResourceIdentifier automanageHcrpConfigurationProfileAssignmentResourceId = AutomanageHcrpConfigurationProfileAssignmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, machineName, configurationProfileAssignmentName);
            AutomanageHcrpConfigurationProfileAssignmentResource automanageHcrpConfigurationProfileAssignment = client.GetAutomanageHcrpConfigurationProfileAssignmentResource(automanageHcrpConfigurationProfileAssignmentResourceId);

            // invoke the operation
            AutomanageHcrpConfigurationProfileAssignmentResource result = await automanageHcrpConfigurationProfileAssignment.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AutomanageConfigurationProfileAssignmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete a HCRP configuration profile assignment
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteAHCRPConfigurationProfileAssignment()
        {
            // Generated from example definition: specification/automanage/resource-manager/Microsoft.Automanage/stable/2022-05-04/examples/deleteConfigurationProfileHCRPAssignment.json
            // this example is just showing the usage of "ConfigurationProfileHCRPAssignments_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomanageHcrpConfigurationProfileAssignmentResource created on azure
            // for more information of creating AutomanageHcrpConfigurationProfileAssignmentResource, please refer to the document of AutomanageHcrpConfigurationProfileAssignmentResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroupName";
            string machineName = "myMachineName";
            string configurationProfileAssignmentName = "default";
            ResourceIdentifier automanageHcrpConfigurationProfileAssignmentResourceId = AutomanageHcrpConfigurationProfileAssignmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, machineName, configurationProfileAssignmentName);
            AutomanageHcrpConfigurationProfileAssignmentResource automanageHcrpConfigurationProfileAssignment = client.GetAutomanageHcrpConfigurationProfileAssignmentResource(automanageHcrpConfigurationProfileAssignmentResourceId);

            // invoke the operation
            await automanageHcrpConfigurationProfileAssignment.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
