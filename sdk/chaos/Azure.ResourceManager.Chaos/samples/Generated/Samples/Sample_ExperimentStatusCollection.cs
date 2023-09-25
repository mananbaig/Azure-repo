// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Chaos;

namespace Azure.ResourceManager.Chaos.Samples
{
    public partial class Sample_ExperimentStatusCollection
    {
        // List all statuses of a Experiment.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListAllStatusesOfAExperiment()
        {
            // Generated from example definition: specification/chaos/resource-manager/Microsoft.Chaos/preview/2023-04-15-preview/examples/ListExperimentStatuses.json
            // this example is just showing the usage of "Experiments_ListAllStatuses" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ExperimentResource created on azure
            // for more information of creating ExperimentResource, please refer to the document of ExperimentResource
            string subscriptionId = "6b052e15-03d3-4f17-b2e1-be7f07588291";
            string resourceGroupName = "exampleRG";
            string experimentName = "exampleExperiment";
            ResourceIdentifier experimentResourceId = ExperimentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, experimentName);
            ExperimentResource experiment = client.GetExperimentResource(experimentResourceId);

            // get the collection of this ExperimentStatusResource
            ExperimentStatusCollection collection = experiment.GetExperimentStatuses();

            // invoke the operation and iterate over the result
            await foreach (ExperimentStatusResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ExperimentStatusData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get the status of a Experiment.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetTheStatusOfAExperiment()
        {
            // Generated from example definition: specification/chaos/resource-manager/Microsoft.Chaos/preview/2023-04-15-preview/examples/GetAExperimentStatus.json
            // this example is just showing the usage of "Experiments_GetStatus" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ExperimentResource created on azure
            // for more information of creating ExperimentResource, please refer to the document of ExperimentResource
            string subscriptionId = "6b052e15-03d3-4f17-b2e1-be7f07588291";
            string resourceGroupName = "exampleRG";
            string experimentName = "exampleExperiment";
            ResourceIdentifier experimentResourceId = ExperimentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, experimentName);
            ExperimentResource experiment = client.GetExperimentResource(experimentResourceId);

            // get the collection of this ExperimentStatusResource
            ExperimentStatusCollection collection = experiment.GetExperimentStatuses();

            // invoke the operation
            string statusId = "50734542-2e64-4e08-814c-cc0e7475f7e4";
            ExperimentStatusResource result = await collection.GetAsync(statusId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ExperimentStatusData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get the status of a Experiment.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetTheStatusOfAExperiment()
        {
            // Generated from example definition: specification/chaos/resource-manager/Microsoft.Chaos/preview/2023-04-15-preview/examples/GetAExperimentStatus.json
            // this example is just showing the usage of "Experiments_GetStatus" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ExperimentResource created on azure
            // for more information of creating ExperimentResource, please refer to the document of ExperimentResource
            string subscriptionId = "6b052e15-03d3-4f17-b2e1-be7f07588291";
            string resourceGroupName = "exampleRG";
            string experimentName = "exampleExperiment";
            ResourceIdentifier experimentResourceId = ExperimentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, experimentName);
            ExperimentResource experiment = client.GetExperimentResource(experimentResourceId);

            // get the collection of this ExperimentStatusResource
            ExperimentStatusCollection collection = experiment.GetExperimentStatuses();

            // invoke the operation
            string statusId = "50734542-2e64-4e08-814c-cc0e7475f7e4";
            bool result = await collection.ExistsAsync(statusId);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get the status of a Experiment.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetTheStatusOfAExperiment()
        {
            // Generated from example definition: specification/chaos/resource-manager/Microsoft.Chaos/preview/2023-04-15-preview/examples/GetAExperimentStatus.json
            // this example is just showing the usage of "Experiments_GetStatus" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ExperimentResource created on azure
            // for more information of creating ExperimentResource, please refer to the document of ExperimentResource
            string subscriptionId = "6b052e15-03d3-4f17-b2e1-be7f07588291";
            string resourceGroupName = "exampleRG";
            string experimentName = "exampleExperiment";
            ResourceIdentifier experimentResourceId = ExperimentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, experimentName);
            ExperimentResource experiment = client.GetExperimentResource(experimentResourceId);

            // get the collection of this ExperimentStatusResource
            ExperimentStatusCollection collection = experiment.GetExperimentStatuses();

            // invoke the operation
            string statusId = "50734542-2e64-4e08-814c-cc0e7475f7e4";
            NullableResponse<ExperimentStatusResource> response = await collection.GetIfExistsAsync(statusId);
            ExperimentStatusResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ExperimentStatusData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
