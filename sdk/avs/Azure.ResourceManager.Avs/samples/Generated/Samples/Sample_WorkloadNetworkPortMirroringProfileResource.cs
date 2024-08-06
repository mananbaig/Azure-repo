// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Avs.Models;

namespace Azure.ResourceManager.Avs.Samples
{
    public partial class Sample_WorkloadNetworkPortMirroringProfileResource
    {
        // WorkloadNetworks_GetPortMirroring
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_WorkloadNetworksGetPortMirroring()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2023-09-01/examples/WorkloadNetworks_GetPortMirroring.json
            // this example is just showing the usage of "WorkloadNetworks_GetPortMirroring" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkloadNetworkPortMirroringProfileResource created on azure
            // for more information of creating WorkloadNetworkPortMirroringProfileResource, please refer to the document of WorkloadNetworkPortMirroringProfileResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            string portMirroringId = "portMirroring1";
            ResourceIdentifier workloadNetworkPortMirroringProfileResourceId = WorkloadNetworkPortMirroringProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName, portMirroringId);
            WorkloadNetworkPortMirroringProfileResource workloadNetworkPortMirroringProfile = client.GetWorkloadNetworkPortMirroringProfileResource(workloadNetworkPortMirroringProfileResourceId);

            // invoke the operation
            WorkloadNetworkPortMirroringProfileResource result = await workloadNetworkPortMirroringProfile.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            WorkloadNetworkPortMirroringProfileData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // WorkloadNetworks_UpdatePortMirroring
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_WorkloadNetworksUpdatePortMirroring()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2023-09-01/examples/WorkloadNetworks_UpdatePortMirroring.json
            // this example is just showing the usage of "WorkloadNetworks_UpdatePortMirroring" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkloadNetworkPortMirroringProfileResource created on azure
            // for more information of creating WorkloadNetworkPortMirroringProfileResource, please refer to the document of WorkloadNetworkPortMirroringProfileResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            string portMirroringId = "portMirroring1";
            ResourceIdentifier workloadNetworkPortMirroringProfileResourceId = WorkloadNetworkPortMirroringProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName, portMirroringId);
            WorkloadNetworkPortMirroringProfileResource workloadNetworkPortMirroringProfile = client.GetWorkloadNetworkPortMirroringProfileResource(workloadNetworkPortMirroringProfileResourceId);

            // invoke the operation
            WorkloadNetworkPortMirroringProfileData data = new WorkloadNetworkPortMirroringProfileData()
            {
                Properties = new WorkloadNetworkPortMirroringProperties()
                {
                    Direction = PortMirroringProfileDirection.Bidirectional,
                    Source = "vmGroup1",
                    Destination = "vmGroup2",
                    Revision = 1,
                },
            };
            ArmOperation<WorkloadNetworkPortMirroringProfileResource> lro = await workloadNetworkPortMirroringProfile.UpdateAsync(WaitUntil.Completed, data);
            WorkloadNetworkPortMirroringProfileResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            WorkloadNetworkPortMirroringProfileData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // WorkloadNetworks_DeletePortMirroring
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_WorkloadNetworksDeletePortMirroring()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2023-09-01/examples/WorkloadNetworks_DeletePortMirroring.json
            // this example is just showing the usage of "WorkloadNetworks_DeletePortMirroring" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkloadNetworkPortMirroringProfileResource created on azure
            // for more information of creating WorkloadNetworkPortMirroringProfileResource, please refer to the document of WorkloadNetworkPortMirroringProfileResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            string portMirroringId = "portMirroring1";
            ResourceIdentifier workloadNetworkPortMirroringProfileResourceId = WorkloadNetworkPortMirroringProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName, portMirroringId);
            WorkloadNetworkPortMirroringProfileResource workloadNetworkPortMirroringProfile = client.GetWorkloadNetworkPortMirroringProfileResource(workloadNetworkPortMirroringProfileResourceId);

            // invoke the operation
            await workloadNetworkPortMirroringProfile.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
