// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.DevCenter.Models;

namespace Azure.ResourceManager.DevCenter.Samples
{
    public partial class Sample_DevCenterScheduleResource
    {
        // Schedules_GetByPool
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_SchedulesGetByPool()
        {
            // Generated from example definition: specification/devcenter/resource-manager/Microsoft.DevCenter/stable/2023-04-01/examples/Schedules_Get.json
            // this example is just showing the usage of "Schedules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevCenterScheduleResource created on azure
            // for more information of creating DevCenterScheduleResource, please refer to the document of DevCenterScheduleResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string projectName = "TestProject";
            string poolName = "DevPool";
            string scheduleName = "autoShutdown";
            ResourceIdentifier devCenterScheduleResourceId = DevCenterScheduleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, projectName, poolName, scheduleName);
            DevCenterScheduleResource devCenterSchedule = client.GetDevCenterScheduleResource(devCenterScheduleResourceId);

            // invoke the operation
            DevCenterScheduleResource result = await devCenterSchedule.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DevCenterScheduleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Schedules_Update
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_SchedulesUpdate()
        {
            // Generated from example definition: specification/devcenter/resource-manager/Microsoft.DevCenter/stable/2023-04-01/examples/Schedules_Patch.json
            // this example is just showing the usage of "Schedules_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevCenterScheduleResource created on azure
            // for more information of creating DevCenterScheduleResource, please refer to the document of DevCenterScheduleResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string projectName = "TestProject";
            string poolName = "DevPool";
            string scheduleName = "autoShutdown";
            ResourceIdentifier devCenterScheduleResourceId = DevCenterScheduleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, projectName, poolName, scheduleName);
            DevCenterScheduleResource devCenterSchedule = client.GetDevCenterScheduleResource(devCenterScheduleResourceId);

            // invoke the operation
            DevCenterSchedulePatch patch = new DevCenterSchedulePatch()
            {
                Time = "18:00",
            };
            ArmOperation<DevCenterScheduleResource> lro = await devCenterSchedule.UpdateAsync(WaitUntil.Completed, patch);
            DevCenterScheduleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DevCenterScheduleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Schedules_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_SchedulesDelete()
        {
            // Generated from example definition: specification/devcenter/resource-manager/Microsoft.DevCenter/stable/2023-04-01/examples/Schedules_Delete.json
            // this example is just showing the usage of "Schedules_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevCenterScheduleResource created on azure
            // for more information of creating DevCenterScheduleResource, please refer to the document of DevCenterScheduleResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string projectName = "TestProject";
            string poolName = "DevPool";
            string scheduleName = "autoShutdown";
            ResourceIdentifier devCenterScheduleResourceId = DevCenterScheduleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, projectName, poolName, scheduleName);
            DevCenterScheduleResource devCenterSchedule = client.GetDevCenterScheduleResource(devCenterScheduleResourceId);

            // invoke the operation
            await devCenterSchedule.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
