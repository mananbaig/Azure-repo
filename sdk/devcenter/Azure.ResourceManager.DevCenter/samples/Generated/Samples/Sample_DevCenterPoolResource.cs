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
    public partial class Sample_DevCenterPoolResource
    {
        // Pools_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_PoolsGet()
        {
            // Generated from example definition: specification/devcenter/resource-manager/Microsoft.DevCenter/stable/2023-04-01/examples/Pools_Get.json
            // this example is just showing the usage of "Pools_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevCenterPoolResource created on azure
            // for more information of creating DevCenterPoolResource, please refer to the document of DevCenterPoolResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string projectName = "DevProject";
            string poolName = "DevPool";
            ResourceIdentifier devCenterPoolResourceId = DevCenterPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, projectName, poolName);
            DevCenterPoolResource devCenterPool = client.GetDevCenterPoolResource(devCenterPoolResourceId);

            // invoke the operation
            DevCenterPoolResource result = await devCenterPool.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DevCenterPoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Pools_GetUnhealthyStatus
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_PoolsGetUnhealthyStatus()
        {
            // Generated from example definition: specification/devcenter/resource-manager/Microsoft.DevCenter/stable/2023-04-01/examples/Pools_GetUnhealthyStatus.json
            // this example is just showing the usage of "Pools_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevCenterPoolResource created on azure
            // for more information of creating DevCenterPoolResource, please refer to the document of DevCenterPoolResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string projectName = "DevProject";
            string poolName = "DevPool";
            ResourceIdentifier devCenterPoolResourceId = DevCenterPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, projectName, poolName);
            DevCenterPoolResource devCenterPool = client.GetDevCenterPoolResource(devCenterPoolResourceId);

            // invoke the operation
            DevCenterPoolResource result = await devCenterPool.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DevCenterPoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Pools_Update
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_PoolsUpdate()
        {
            // Generated from example definition: specification/devcenter/resource-manager/Microsoft.DevCenter/stable/2023-04-01/examples/Pools_Patch.json
            // this example is just showing the usage of "Pools_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevCenterPoolResource created on azure
            // for more information of creating DevCenterPoolResource, please refer to the document of DevCenterPoolResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string projectName = "DevProject";
            string poolName = "DevPool";
            ResourceIdentifier devCenterPoolResourceId = DevCenterPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, projectName, poolName);
            DevCenterPoolResource devCenterPool = client.GetDevCenterPoolResource(devCenterPoolResourceId);

            // invoke the operation
            DevCenterPoolPatch patch = new DevCenterPoolPatch()
            {
                DevBoxDefinitionName = "WebDevBox2",
            };
            ArmOperation<DevCenterPoolResource> lro = await devCenterPool.UpdateAsync(WaitUntil.Completed, patch);
            DevCenterPoolResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DevCenterPoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Pools_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_PoolsDelete()
        {
            // Generated from example definition: specification/devcenter/resource-manager/Microsoft.DevCenter/stable/2023-04-01/examples/Pools_Delete.json
            // this example is just showing the usage of "Pools_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevCenterPoolResource created on azure
            // for more information of creating DevCenterPoolResource, please refer to the document of DevCenterPoolResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string projectName = "DevProject";
            string poolName = "poolName";
            ResourceIdentifier devCenterPoolResourceId = DevCenterPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, projectName, poolName);
            DevCenterPoolResource devCenterPool = client.GetDevCenterPoolResource(devCenterPoolResourceId);

            // invoke the operation
            await devCenterPool.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Pools_RefreshStatus
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task RunHealthChecks_PoolsRefreshStatus()
        {
            // Generated from example definition: specification/devcenter/resource-manager/Microsoft.DevCenter/stable/2023-04-01/examples/Pools_RunHealthChecks.json
            // this example is just showing the usage of "Pools_RunHealthChecks" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevCenterPoolResource created on azure
            // for more information of creating DevCenterPoolResource, please refer to the document of DevCenterPoolResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string projectName = "DevProject";
            string poolName = "DevPool";
            ResourceIdentifier devCenterPoolResourceId = DevCenterPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, projectName, poolName);
            DevCenterPoolResource devCenterPool = client.GetDevCenterPoolResource(devCenterPoolResourceId);

            // invoke the operation
            await devCenterPool.RunHealthChecksAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
