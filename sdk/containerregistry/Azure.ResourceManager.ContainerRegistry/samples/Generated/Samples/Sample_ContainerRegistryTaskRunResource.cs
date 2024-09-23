// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ContainerRegistry.Models;

namespace Azure.ResourceManager.ContainerRegistry.Samples
{
    public partial class Sample_ContainerRegistryTaskRunResource
    {
        // TaskRuns_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_TaskRunsGet()
        {
            // Generated from example definition: specification/containerregistry/resource-manager/Microsoft.ContainerRegistry/preview/2019-06-01-preview/examples/TaskRunsGet.json
            // this example is just showing the usage of "TaskRuns_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerRegistryTaskRunResource created on azure
            // for more information of creating ContainerRegistryTaskRunResource, please refer to the document of ContainerRegistryTaskRunResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string registryName = "myRegistry";
            string taskRunName = "myRun";
            ResourceIdentifier containerRegistryTaskRunResourceId = ContainerRegistryTaskRunResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName, taskRunName);
            ContainerRegistryTaskRunResource containerRegistryTaskRun = client.GetContainerRegistryTaskRunResource(containerRegistryTaskRunResourceId);

            // invoke the operation
            ContainerRegistryTaskRunResource result = await containerRegistryTaskRun.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerRegistryTaskRunData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // TaskRuns_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_TaskRunsDelete()
        {
            // Generated from example definition: specification/containerregistry/resource-manager/Microsoft.ContainerRegistry/preview/2019-06-01-preview/examples/TaskRunsDelete.json
            // this example is just showing the usage of "TaskRuns_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerRegistryTaskRunResource created on azure
            // for more information of creating ContainerRegistryTaskRunResource, please refer to the document of ContainerRegistryTaskRunResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string registryName = "myRegistry";
            string taskRunName = "myRun";
            ResourceIdentifier containerRegistryTaskRunResourceId = ContainerRegistryTaskRunResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName, taskRunName);
            ContainerRegistryTaskRunResource containerRegistryTaskRun = client.GetContainerRegistryTaskRunResource(containerRegistryTaskRunResourceId);

            // invoke the operation
            await containerRegistryTaskRun.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // TaskRuns_Update
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_TaskRunsUpdate()
        {
            // Generated from example definition: specification/containerregistry/resource-manager/Microsoft.ContainerRegistry/preview/2019-06-01-preview/examples/TaskRunsUpdate.json
            // this example is just showing the usage of "TaskRuns_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerRegistryTaskRunResource created on azure
            // for more information of creating ContainerRegistryTaskRunResource, please refer to the document of ContainerRegistryTaskRunResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string registryName = "myRegistry";
            string taskRunName = "myRun";
            ResourceIdentifier containerRegistryTaskRunResourceId = ContainerRegistryTaskRunResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName, taskRunName);
            ContainerRegistryTaskRunResource containerRegistryTaskRun = client.GetContainerRegistryTaskRunResource(containerRegistryTaskRunResourceId);

            // invoke the operation
            ContainerRegistryTaskRunPatch patch = new ContainerRegistryTaskRunPatch()
            {
                RunRequest = new ContainerRegistryEncodedTaskRunContent("c3RlcHM6IAogIC0gY21kOiB7eyAuVmFsdWVzLmNvbW1hbmQgfX0K", new ContainerRegistryPlatformProperties(ContainerRegistryOS.Linux)
                {
                    Architecture = ContainerRegistryOSArchitecture.Amd64,
                })
                {
                    EncodedValuesContent = "Y29tbWFuZDogYmFzaCBlY2hvIHt7LlJ1bi5SZWdpc3RyeX19Cg==",
                    Values =
{
},
                    Credentials = new ContainerRegistryCredentials(),
                    IsArchiveEnabled = true,
                },
                ForceUpdateTag = "test",
            };
            ArmOperation<ContainerRegistryTaskRunResource> lro = await containerRegistryTaskRun.UpdateAsync(WaitUntil.Completed, patch);
            ContainerRegistryTaskRunResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerRegistryTaskRunData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // TaskRuns_GetDetails
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetDetails_TaskRunsGetDetails()
        {
            // Generated from example definition: specification/containerregistry/resource-manager/Microsoft.ContainerRegistry/preview/2019-06-01-preview/examples/TaskRunsGetDetails.json
            // this example is just showing the usage of "TaskRuns_GetDetails" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerRegistryTaskRunResource created on azure
            // for more information of creating ContainerRegistryTaskRunResource, please refer to the document of ContainerRegistryTaskRunResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string registryName = "myRegistry";
            string taskRunName = "myRun";
            ResourceIdentifier containerRegistryTaskRunResourceId = ContainerRegistryTaskRunResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName, taskRunName);
            ContainerRegistryTaskRunResource containerRegistryTaskRun = client.GetContainerRegistryTaskRunResource(containerRegistryTaskRunResourceId);

            // invoke the operation
            ContainerRegistryTaskRunResource result = await containerRegistryTaskRun.GetDetailsAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerRegistryTaskRunData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
