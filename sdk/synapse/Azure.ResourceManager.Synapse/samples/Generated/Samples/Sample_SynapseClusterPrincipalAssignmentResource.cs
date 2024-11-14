// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Synapse.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Synapse.Samples
{
    public partial class Sample_SynapseClusterPrincipalAssignmentResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_KustoPoolPrincipalAssignmentsGet()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/preview/2021-06-01-preview/examples/KustoPoolPrincipalAssignmentsGet.json
            // this example is just showing the usage of "KustoPoolPrincipalAssignments_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseClusterPrincipalAssignmentResource created on azure
            // for more information of creating SynapseClusterPrincipalAssignmentResource, please refer to the document of SynapseClusterPrincipalAssignmentResource
            string subscriptionId = "12345678-1234-1234-1234-123456789098";
            string resourceGroupName = "kustorptest";
            string workspaceName = "synapseWorkspaceName";
            string kustoPoolName = "kustoclusterrptest4";
            string principalAssignmentName = "kustoprincipal1";
            ResourceIdentifier synapseClusterPrincipalAssignmentResourceId = SynapseClusterPrincipalAssignmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, kustoPoolName, principalAssignmentName);
            SynapseClusterPrincipalAssignmentResource synapseClusterPrincipalAssignment = client.GetSynapseClusterPrincipalAssignmentResource(synapseClusterPrincipalAssignmentResourceId);

            // invoke the operation
            SynapseClusterPrincipalAssignmentResource result = await synapseClusterPrincipalAssignment.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SynapseClusterPrincipalAssignmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_KustoPoolPrincipalAssignmentsCreateOrUpdate()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/preview/2021-06-01-preview/examples/KustoPoolPrincipalAssignmentsCreateOrUpdate.json
            // this example is just showing the usage of "KustoPoolPrincipalAssignments_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseClusterPrincipalAssignmentResource created on azure
            // for more information of creating SynapseClusterPrincipalAssignmentResource, please refer to the document of SynapseClusterPrincipalAssignmentResource
            string subscriptionId = "12345678-1234-1234-1234-123456789098";
            string resourceGroupName = "kustorptest";
            string workspaceName = "synapseWorkspaceName";
            string kustoPoolName = "kustoclusterrptest4";
            string principalAssignmentName = "kustoprincipal1";
            ResourceIdentifier synapseClusterPrincipalAssignmentResourceId = SynapseClusterPrincipalAssignmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, kustoPoolName, principalAssignmentName);
            SynapseClusterPrincipalAssignmentResource synapseClusterPrincipalAssignment = client.GetSynapseClusterPrincipalAssignmentResource(synapseClusterPrincipalAssignmentResourceId);

            // invoke the operation
            SynapseClusterPrincipalAssignmentData data = new SynapseClusterPrincipalAssignmentData()
            {
                PrincipalId = "87654321-1234-1234-1234-123456789123",
                Role = SynapseClusterPrincipalRole.AllDatabasesAdmin,
                TenantId = Guid.Parse("12345678-1234-1234-1234-123456789123"),
                PrincipalType = SynapsePrincipalType.App,
            };
            ArmOperation<SynapseClusterPrincipalAssignmentResource> lro = await synapseClusterPrincipalAssignment.UpdateAsync(WaitUntil.Completed, data);
            SynapseClusterPrincipalAssignmentResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SynapseClusterPrincipalAssignmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_KustoPoolPrincipalAssignmentsDelete()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/preview/2021-06-01-preview/examples/KustoPoolPrincipalAssignmentsDelete.json
            // this example is just showing the usage of "KustoPoolPrincipalAssignments_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseClusterPrincipalAssignmentResource created on azure
            // for more information of creating SynapseClusterPrincipalAssignmentResource, please refer to the document of SynapseClusterPrincipalAssignmentResource
            string subscriptionId = "12345678-1234-1234-1234-123456789098";
            string resourceGroupName = "kustorptest";
            string workspaceName = "synapseWorkspaceName";
            string kustoPoolName = "kustoclusterrptest4";
            string principalAssignmentName = "kustoprincipal1";
            ResourceIdentifier synapseClusterPrincipalAssignmentResourceId = SynapseClusterPrincipalAssignmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, kustoPoolName, principalAssignmentName);
            SynapseClusterPrincipalAssignmentResource synapseClusterPrincipalAssignment = client.GetSynapseClusterPrincipalAssignmentResource(synapseClusterPrincipalAssignmentResourceId);

            // invoke the operation
            await synapseClusterPrincipalAssignment.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }
    }
}
