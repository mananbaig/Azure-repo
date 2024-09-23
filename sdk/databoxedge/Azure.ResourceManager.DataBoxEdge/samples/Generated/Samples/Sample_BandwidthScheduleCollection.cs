// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.DataBoxEdge.Models;

namespace Azure.ResourceManager.DataBoxEdge.Samples
{
    public partial class Sample_BandwidthScheduleCollection
    {
        // BandwidthScheduleGetAllInDevice
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_BandwidthScheduleGetAllInDevice()
        {
            // Generated from example definition: specification/databoxedge/resource-manager/Microsoft.DataBoxEdge/stable/2022-03-01/examples/BandwidthScheduleGetAllInDevice.json
            // this example is just showing the usage of "BandwidthSchedules_ListByDataBoxEdgeDevice" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataBoxEdgeDeviceResource created on azure
            // for more information of creating DataBoxEdgeDeviceResource, please refer to the document of DataBoxEdgeDeviceResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "GroupForEdgeAutomation";
            string deviceName = "testedgedevice";
            ResourceIdentifier dataBoxEdgeDeviceResourceId = DataBoxEdgeDeviceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, deviceName);
            DataBoxEdgeDeviceResource dataBoxEdgeDevice = client.GetDataBoxEdgeDeviceResource(dataBoxEdgeDeviceResourceId);

            // get the collection of this BandwidthScheduleResource
            BandwidthScheduleCollection collection = dataBoxEdgeDevice.GetBandwidthSchedules();

            // invoke the operation and iterate over the result
            await foreach (BandwidthScheduleResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                BandwidthScheduleData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // BandwidthScheduleGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_BandwidthScheduleGet()
        {
            // Generated from example definition: specification/databoxedge/resource-manager/Microsoft.DataBoxEdge/stable/2022-03-01/examples/BandwidthScheduleGet.json
            // this example is just showing the usage of "BandwidthSchedules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataBoxEdgeDeviceResource created on azure
            // for more information of creating DataBoxEdgeDeviceResource, please refer to the document of DataBoxEdgeDeviceResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "GroupForEdgeAutomation";
            string deviceName = "testedgedevice";
            ResourceIdentifier dataBoxEdgeDeviceResourceId = DataBoxEdgeDeviceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, deviceName);
            DataBoxEdgeDeviceResource dataBoxEdgeDevice = client.GetDataBoxEdgeDeviceResource(dataBoxEdgeDeviceResourceId);

            // get the collection of this BandwidthScheduleResource
            BandwidthScheduleCollection collection = dataBoxEdgeDevice.GetBandwidthSchedules();

            // invoke the operation
            string name = "bandwidth-1";
            BandwidthScheduleResource result = await collection.GetAsync(name);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BandwidthScheduleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // BandwidthScheduleGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_BandwidthScheduleGet()
        {
            // Generated from example definition: specification/databoxedge/resource-manager/Microsoft.DataBoxEdge/stable/2022-03-01/examples/BandwidthScheduleGet.json
            // this example is just showing the usage of "BandwidthSchedules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataBoxEdgeDeviceResource created on azure
            // for more information of creating DataBoxEdgeDeviceResource, please refer to the document of DataBoxEdgeDeviceResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "GroupForEdgeAutomation";
            string deviceName = "testedgedevice";
            ResourceIdentifier dataBoxEdgeDeviceResourceId = DataBoxEdgeDeviceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, deviceName);
            DataBoxEdgeDeviceResource dataBoxEdgeDevice = client.GetDataBoxEdgeDeviceResource(dataBoxEdgeDeviceResourceId);

            // get the collection of this BandwidthScheduleResource
            BandwidthScheduleCollection collection = dataBoxEdgeDevice.GetBandwidthSchedules();

            // invoke the operation
            string name = "bandwidth-1";
            bool result = await collection.ExistsAsync(name);

            Console.WriteLine($"Succeeded: {result}");
        }

        // BandwidthScheduleGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_BandwidthScheduleGet()
        {
            // Generated from example definition: specification/databoxedge/resource-manager/Microsoft.DataBoxEdge/stable/2022-03-01/examples/BandwidthScheduleGet.json
            // this example is just showing the usage of "BandwidthSchedules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataBoxEdgeDeviceResource created on azure
            // for more information of creating DataBoxEdgeDeviceResource, please refer to the document of DataBoxEdgeDeviceResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "GroupForEdgeAutomation";
            string deviceName = "testedgedevice";
            ResourceIdentifier dataBoxEdgeDeviceResourceId = DataBoxEdgeDeviceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, deviceName);
            DataBoxEdgeDeviceResource dataBoxEdgeDevice = client.GetDataBoxEdgeDeviceResource(dataBoxEdgeDeviceResourceId);

            // get the collection of this BandwidthScheduleResource
            BandwidthScheduleCollection collection = dataBoxEdgeDevice.GetBandwidthSchedules();

            // invoke the operation
            string name = "bandwidth-1";
            NullableResponse<BandwidthScheduleResource> response = await collection.GetIfExistsAsync(name);
            BandwidthScheduleResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                BandwidthScheduleData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // BandwidthSchedulePut
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_BandwidthSchedulePut()
        {
            // Generated from example definition: specification/databoxedge/resource-manager/Microsoft.DataBoxEdge/stable/2022-03-01/examples/BandwidthSchedulePut.json
            // this example is just showing the usage of "BandwidthSchedules_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataBoxEdgeDeviceResource created on azure
            // for more information of creating DataBoxEdgeDeviceResource, please refer to the document of DataBoxEdgeDeviceResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "GroupForEdgeAutomation";
            string deviceName = "testedgedevice";
            ResourceIdentifier dataBoxEdgeDeviceResourceId = DataBoxEdgeDeviceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, deviceName);
            DataBoxEdgeDeviceResource dataBoxEdgeDevice = client.GetDataBoxEdgeDeviceResource(dataBoxEdgeDeviceResourceId);

            // get the collection of this BandwidthScheduleResource
            BandwidthScheduleCollection collection = dataBoxEdgeDevice.GetBandwidthSchedules();

            // invoke the operation
            string name = "bandwidth-1";
            BandwidthScheduleData data = new BandwidthScheduleData(TimeSpan.Parse("0:0:0"), TimeSpan.Parse("13:59:0"), 100, new DataBoxEdgeDayOfWeek[]
            {
DataBoxEdgeDayOfWeek.Sunday,DataBoxEdgeDayOfWeek.Monday
            });
            ArmOperation<BandwidthScheduleResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, name, data);
            BandwidthScheduleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BandwidthScheduleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
