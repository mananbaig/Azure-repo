// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.MachineLearning.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.MachineLearning.Samples
{
    public partial class Sample_MachineLearningWorkspaceConnectionResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreateWorkspaceConnection()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/WorkspaceConnection/create.json
            // this example is just showing the usage of "WorkspaceConnections_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningWorkspaceConnectionResource created on azure
            // for more information of creating MachineLearningWorkspaceConnectionResource, please refer to the document of MachineLearningWorkspaceConnectionResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "resourceGroup-1";
            string workspaceName = "workspace-1";
            string connectionName = "connection-1";
            ResourceIdentifier machineLearningWorkspaceConnectionResourceId = MachineLearningWorkspaceConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, connectionName);
            MachineLearningWorkspaceConnectionResource machineLearningWorkspaceConnection = client.GetMachineLearningWorkspaceConnectionResource(machineLearningWorkspaceConnectionResourceId);

            // invoke the operation
            MachineLearningWorkspaceConnectionData data = new MachineLearningWorkspaceConnectionData(new MachineLearningNoneAuthTypeWorkspaceConnection()
            {
                Category = MachineLearningConnectionCategory.ContainerRegistry,
                Target = "www.facebook.com",
            });
            ArmOperation<MachineLearningWorkspaceConnectionResource> lro = await machineLearningWorkspaceConnection.UpdateAsync(WaitUntil.Completed, data);
            MachineLearningWorkspaceConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningWorkspaceConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetWorkspaceConnection()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/WorkspaceConnection/get.json
            // this example is just showing the usage of "WorkspaceConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningWorkspaceConnectionResource created on azure
            // for more information of creating MachineLearningWorkspaceConnectionResource, please refer to the document of MachineLearningWorkspaceConnectionResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "resourceGroup-1";
            string workspaceName = "workspace-1";
            string connectionName = "connection-1";
            ResourceIdentifier machineLearningWorkspaceConnectionResourceId = MachineLearningWorkspaceConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, connectionName);
            MachineLearningWorkspaceConnectionResource machineLearningWorkspaceConnection = client.GetMachineLearningWorkspaceConnectionResource(machineLearningWorkspaceConnectionResourceId);

            // invoke the operation
            MachineLearningWorkspaceConnectionResource result = await machineLearningWorkspaceConnection.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningWorkspaceConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteWorkspaceConnection()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/WorkspaceConnection/delete.json
            // this example is just showing the usage of "WorkspaceConnections_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningWorkspaceConnectionResource created on azure
            // for more information of creating MachineLearningWorkspaceConnectionResource, please refer to the document of MachineLearningWorkspaceConnectionResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "resourceGroup-1";
            string workspaceName = "workspace-1";
            string connectionName = "connection-1";
            ResourceIdentifier machineLearningWorkspaceConnectionResourceId = MachineLearningWorkspaceConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, connectionName);
            MachineLearningWorkspaceConnectionResource machineLearningWorkspaceConnection = client.GetMachineLearningWorkspaceConnectionResource(machineLearningWorkspaceConnectionResourceId);

            // invoke the operation
            await machineLearningWorkspaceConnection.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetSecrets_GetWorkspaceConnection()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/WorkspaceConnection/listSecrets.json
            // this example is just showing the usage of "WorkspaceConnections_ListSecrets" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningWorkspaceConnectionResource created on azure
            // for more information of creating MachineLearningWorkspaceConnectionResource, please refer to the document of MachineLearningWorkspaceConnectionResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "workspace-1";
            string connectionName = "connection-1";
            ResourceIdentifier machineLearningWorkspaceConnectionResourceId = MachineLearningWorkspaceConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, connectionName);
            MachineLearningWorkspaceConnectionResource machineLearningWorkspaceConnection = client.GetMachineLearningWorkspaceConnectionResource(machineLearningWorkspaceConnectionResourceId);

            // invoke the operation
            MachineLearningWorkspaceConnectionResource result = await machineLearningWorkspaceConnection.GetSecretsAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningWorkspaceConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
