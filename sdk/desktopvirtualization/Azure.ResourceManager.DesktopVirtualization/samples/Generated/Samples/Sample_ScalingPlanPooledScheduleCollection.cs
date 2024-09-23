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
    public partial class Sample_ScalingPlanPooledScheduleCollection
    {
        // ScalingPlanPooledSchedules_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ScalingPlanPooledSchedulesGet()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/stable/2024-04-03/examples/ScalingPlanPooledSchedule_Get.json
            // this example is just showing the usage of "ScalingPlanPooledSchedules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ScalingPlanResource created on azure
            // for more information of creating ScalingPlanResource, please refer to the document of ScalingPlanResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resourceGroup1";
            string scalingPlanName = "scalingPlan1";
            ResourceIdentifier scalingPlanResourceId = ScalingPlanResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, scalingPlanName);
            ScalingPlanResource scalingPlan = client.GetScalingPlanResource(scalingPlanResourceId);

            // get the collection of this ScalingPlanPooledScheduleResource
            ScalingPlanPooledScheduleCollection collection = scalingPlan.GetScalingPlanPooledSchedules();

            // invoke the operation
            string scalingPlanScheduleName = "scalingPlanScheduleWeekdays1";
            ScalingPlanPooledScheduleResource result = await collection.GetAsync(scalingPlanScheduleName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ScalingPlanPooledScheduleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ScalingPlanPooledSchedules_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_ScalingPlanPooledSchedulesGet()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/stable/2024-04-03/examples/ScalingPlanPooledSchedule_Get.json
            // this example is just showing the usage of "ScalingPlanPooledSchedules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ScalingPlanResource created on azure
            // for more information of creating ScalingPlanResource, please refer to the document of ScalingPlanResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resourceGroup1";
            string scalingPlanName = "scalingPlan1";
            ResourceIdentifier scalingPlanResourceId = ScalingPlanResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, scalingPlanName);
            ScalingPlanResource scalingPlan = client.GetScalingPlanResource(scalingPlanResourceId);

            // get the collection of this ScalingPlanPooledScheduleResource
            ScalingPlanPooledScheduleCollection collection = scalingPlan.GetScalingPlanPooledSchedules();

            // invoke the operation
            string scalingPlanScheduleName = "scalingPlanScheduleWeekdays1";
            bool result = await collection.ExistsAsync(scalingPlanScheduleName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // ScalingPlanPooledSchedules_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_ScalingPlanPooledSchedulesGet()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/stable/2024-04-03/examples/ScalingPlanPooledSchedule_Get.json
            // this example is just showing the usage of "ScalingPlanPooledSchedules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ScalingPlanResource created on azure
            // for more information of creating ScalingPlanResource, please refer to the document of ScalingPlanResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resourceGroup1";
            string scalingPlanName = "scalingPlan1";
            ResourceIdentifier scalingPlanResourceId = ScalingPlanResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, scalingPlanName);
            ScalingPlanResource scalingPlan = client.GetScalingPlanResource(scalingPlanResourceId);

            // get the collection of this ScalingPlanPooledScheduleResource
            ScalingPlanPooledScheduleCollection collection = scalingPlan.GetScalingPlanPooledSchedules();

            // invoke the operation
            string scalingPlanScheduleName = "scalingPlanScheduleWeekdays1";
            NullableResponse<ScalingPlanPooledScheduleResource> response = await collection.GetIfExistsAsync(scalingPlanScheduleName);
            ScalingPlanPooledScheduleResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ScalingPlanPooledScheduleData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // ScalingPlanPooledSchedules_Create
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_ScalingPlanPooledSchedulesCreate()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/stable/2024-04-03/examples/ScalingPlanPooledSchedule_Create.json
            // this example is just showing the usage of "ScalingPlanPooledSchedules_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ScalingPlanResource created on azure
            // for more information of creating ScalingPlanResource, please refer to the document of ScalingPlanResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resourceGroup1";
            string scalingPlanName = "scalingPlan1";
            ResourceIdentifier scalingPlanResourceId = ScalingPlanResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, scalingPlanName);
            ScalingPlanResource scalingPlan = client.GetScalingPlanResource(scalingPlanResourceId);

            // get the collection of this ScalingPlanPooledScheduleResource
            ScalingPlanPooledScheduleCollection collection = scalingPlan.GetScalingPlanPooledSchedules();

            // invoke the operation
            string scalingPlanScheduleName = "scalingPlanScheduleWeekdays1";
            ScalingPlanPooledScheduleData data = new ScalingPlanPooledScheduleData()
            {
                DaysOfWeek =
{
DesktopVirtualizationDayOfWeek.Monday,DesktopVirtualizationDayOfWeek.Tuesday,DesktopVirtualizationDayOfWeek.Wednesday,DesktopVirtualizationDayOfWeek.Thursday,DesktopVirtualizationDayOfWeek.Friday
},
                RampUpStartTime = new ScalingActionTime(6, 0),
                RampUpLoadBalancingAlgorithm = SessionHostLoadBalancingAlgorithm.DepthFirst,
                RampUpMinimumHostsPct = 20,
                RampUpCapacityThresholdPct = 80,
                PeakStartTime = new ScalingActionTime(8, 0),
                PeakLoadBalancingAlgorithm = SessionHostLoadBalancingAlgorithm.BreadthFirst,
                RampDownStartTime = new ScalingActionTime(18, 0),
                RampDownLoadBalancingAlgorithm = SessionHostLoadBalancingAlgorithm.DepthFirst,
                RampDownMinimumHostsPct = 20,
                RampDownCapacityThresholdPct = 50,
                RampDownForceLogoffUsers = true,
                RampDownWaitTimeMinutes = 30,
                RampDownNotificationMessage = "message",
                OffPeakStartTime = new ScalingActionTime(20, 0),
                OffPeakLoadBalancingAlgorithm = SessionHostLoadBalancingAlgorithm.DepthFirst,
            };
            ArmOperation<ScalingPlanPooledScheduleResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, scalingPlanScheduleName, data);
            ScalingPlanPooledScheduleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ScalingPlanPooledScheduleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ScalingPlanPooledSchedules_List
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ScalingPlanPooledSchedulesList()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/stable/2024-04-03/examples/ScalingPlanPooledSchedule_List.json
            // this example is just showing the usage of "ScalingPlanPooledSchedules_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ScalingPlanResource created on azure
            // for more information of creating ScalingPlanResource, please refer to the document of ScalingPlanResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resourceGroup1";
            string scalingPlanName = "scalingPlan1";
            ResourceIdentifier scalingPlanResourceId = ScalingPlanResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, scalingPlanName);
            ScalingPlanResource scalingPlan = client.GetScalingPlanResource(scalingPlanResourceId);

            // get the collection of this ScalingPlanPooledScheduleResource
            ScalingPlanPooledScheduleCollection collection = scalingPlan.GetScalingPlanPooledSchedules();

            // invoke the operation and iterate over the result
            int? pageSize = 10;
            bool? isDescending = true;
            int? initialSkip = 0;
            await foreach (ScalingPlanPooledScheduleResource item in collection.GetAllAsync(pageSize: pageSize, isDescending: isDescending, initialSkip: initialSkip))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ScalingPlanPooledScheduleData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
