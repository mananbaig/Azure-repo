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
    public partial class Sample_HostPoolPrivateEndpointConnectionCollection
    {
        // PrivateEndpointConnection_ListByHostPool
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_PrivateEndpointConnectionListByHostPool()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/stable/2024-04-03/examples/PrivateEndpointConnection_ListByHostPool.json
            // this example is just showing the usage of "PrivateEndpointConnections_ListByHostPool" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HostPoolResource created on azure
            // for more information of creating HostPoolResource, please refer to the document of HostPoolResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resourceGroup1";
            string hostPoolName = "hostPool1";
            ResourceIdentifier hostPoolResourceId = HostPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hostPoolName);
            HostPoolResource hostPool = client.GetHostPoolResource(hostPoolResourceId);

            // get the collection of this HostPoolPrivateEndpointConnectionResource
            HostPoolPrivateEndpointConnectionCollection collection = hostPool.GetHostPoolPrivateEndpointConnections();

            // invoke the operation and iterate over the result
            await foreach (HostPoolPrivateEndpointConnectionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DesktopVirtualizationPrivateEndpointConnectionDataData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // PrivateEndpointConnection_GetByHostPool
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_PrivateEndpointConnectionGetByHostPool()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/stable/2024-04-03/examples/PrivateEndpointConnection_GetByHostPool.json
            // this example is just showing the usage of "PrivateEndpointConnections_GetByHostPool" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HostPoolResource created on azure
            // for more information of creating HostPoolResource, please refer to the document of HostPoolResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resourceGroup1";
            string hostPoolName = "hostPool1";
            ResourceIdentifier hostPoolResourceId = HostPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hostPoolName);
            HostPoolResource hostPool = client.GetHostPoolResource(hostPoolResourceId);

            // get the collection of this HostPoolPrivateEndpointConnectionResource
            HostPoolPrivateEndpointConnectionCollection collection = hostPool.GetHostPoolPrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "hostPool1.377103f1-5179-4bdf-8556-4cdd3207cc5b";
            HostPoolPrivateEndpointConnectionResource result = await collection.GetAsync(privateEndpointConnectionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DesktopVirtualizationPrivateEndpointConnectionDataData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // PrivateEndpointConnection_GetByHostPool
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_PrivateEndpointConnectionGetByHostPool()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/stable/2024-04-03/examples/PrivateEndpointConnection_GetByHostPool.json
            // this example is just showing the usage of "PrivateEndpointConnections_GetByHostPool" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HostPoolResource created on azure
            // for more information of creating HostPoolResource, please refer to the document of HostPoolResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resourceGroup1";
            string hostPoolName = "hostPool1";
            ResourceIdentifier hostPoolResourceId = HostPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hostPoolName);
            HostPoolResource hostPool = client.GetHostPoolResource(hostPoolResourceId);

            // get the collection of this HostPoolPrivateEndpointConnectionResource
            HostPoolPrivateEndpointConnectionCollection collection = hostPool.GetHostPoolPrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "hostPool1.377103f1-5179-4bdf-8556-4cdd3207cc5b";
            bool result = await collection.ExistsAsync(privateEndpointConnectionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // PrivateEndpointConnection_GetByHostPool
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_PrivateEndpointConnectionGetByHostPool()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/stable/2024-04-03/examples/PrivateEndpointConnection_GetByHostPool.json
            // this example is just showing the usage of "PrivateEndpointConnections_GetByHostPool" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HostPoolResource created on azure
            // for more information of creating HostPoolResource, please refer to the document of HostPoolResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resourceGroup1";
            string hostPoolName = "hostPool1";
            ResourceIdentifier hostPoolResourceId = HostPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hostPoolName);
            HostPoolResource hostPool = client.GetHostPoolResource(hostPoolResourceId);

            // get the collection of this HostPoolPrivateEndpointConnectionResource
            HostPoolPrivateEndpointConnectionCollection collection = hostPool.GetHostPoolPrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "hostPool1.377103f1-5179-4bdf-8556-4cdd3207cc5b";
            NullableResponse<HostPoolPrivateEndpointConnectionResource> response = await collection.GetIfExistsAsync(privateEndpointConnectionName);
            HostPoolPrivateEndpointConnectionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DesktopVirtualizationPrivateEndpointConnectionDataData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // PrivateEndpointConnection_UpdateByHostPool
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_PrivateEndpointConnectionUpdateByHostPool()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/stable/2024-04-03/examples/PrivateEndpointConnection_UpdateByHostPool.json
            // this example is just showing the usage of "PrivateEndpointConnections_UpdateByHostPool" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HostPoolResource created on azure
            // for more information of creating HostPoolResource, please refer to the document of HostPoolResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resourceGroup1";
            string hostPoolName = "hostPool1";
            ResourceIdentifier hostPoolResourceId = HostPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hostPoolName);
            HostPoolResource hostPool = client.GetHostPoolResource(hostPoolResourceId);

            // get the collection of this HostPoolPrivateEndpointConnectionResource
            HostPoolPrivateEndpointConnectionCollection collection = hostPool.GetHostPoolPrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "hostPool1.377103f1-5179-4bdf-8556-4cdd3207cc5b";
            DesktopVirtualizationPrivateEndpointConnection connection = new DesktopVirtualizationPrivateEndpointConnection()
            {
                ConnectionState = new DesktopVirtualizationPrivateLinkServiceConnectionState()
                {
                    Status = DesktopVirtualizationPrivateEndpointServiceConnectionStatus.Approved,
                    Description = "Approved by admin@consoto.com",
                    ActionsRequired = "None",
                },
            };
            ArmOperation<HostPoolPrivateEndpointConnectionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, privateEndpointConnectionName, connection);
            HostPoolPrivateEndpointConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DesktopVirtualizationPrivateEndpointConnectionDataData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
