// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.DevCenter.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.DevCenter.Samples
{
    public partial class Sample_DevCenterNetworkConnectionResource
    {
        // NetworkConnections_ListBySubscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetDevCenterNetworkConnections_NetworkConnectionsListBySubscription()
        {
            // Generated from example definition: specification/devcenter/resource-manager/Microsoft.DevCenter/stable/2023-04-01/examples/NetworkConnections_ListBySubscription.json
            // this example is just showing the usage of "NetworkConnections_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (DevCenterNetworkConnectionResource item in subscriptionResource.GetDevCenterNetworkConnectionsAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DevCenterNetworkConnectionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // NetworkConnections_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_NetworkConnectionsGet()
        {
            // Generated from example definition: specification/devcenter/resource-manager/Microsoft.DevCenter/stable/2023-04-01/examples/NetworkConnections_Get.json
            // this example is just showing the usage of "NetworkConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevCenterNetworkConnectionResource created on azure
            // for more information of creating DevCenterNetworkConnectionResource, please refer to the document of DevCenterNetworkConnectionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkConnectionName = "uswest3network";
            ResourceIdentifier devCenterNetworkConnectionResourceId = DevCenterNetworkConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkConnectionName);
            DevCenterNetworkConnectionResource devCenterNetworkConnection = client.GetDevCenterNetworkConnectionResource(devCenterNetworkConnectionResourceId);

            // invoke the operation
            DevCenterNetworkConnectionResource result = await devCenterNetworkConnection.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DevCenterNetworkConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // NetworkConnections_Update
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_NetworkConnectionsUpdate()
        {
            // Generated from example definition: specification/devcenter/resource-manager/Microsoft.DevCenter/stable/2023-04-01/examples/NetworkConnections_Patch.json
            // this example is just showing the usage of "NetworkConnections_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevCenterNetworkConnectionResource created on azure
            // for more information of creating DevCenterNetworkConnectionResource, please refer to the document of DevCenterNetworkConnectionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkConnectionName = "uswest3network";
            ResourceIdentifier devCenterNetworkConnectionResourceId = DevCenterNetworkConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkConnectionName);
            DevCenterNetworkConnectionResource devCenterNetworkConnection = client.GetDevCenterNetworkConnectionResource(devCenterNetworkConnectionResourceId);

            // invoke the operation
            DevCenterNetworkConnectionPatch patch = new DevCenterNetworkConnectionPatch()
            {
                DomainPassword = "New Password value for user",
            };
            ArmOperation<DevCenterNetworkConnectionResource> lro = await devCenterNetworkConnection.UpdateAsync(WaitUntil.Completed, patch);
            DevCenterNetworkConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DevCenterNetworkConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // NetworkConnections_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_NetworkConnectionsDelete()
        {
            // Generated from example definition: specification/devcenter/resource-manager/Microsoft.DevCenter/stable/2023-04-01/examples/NetworkConnections_Delete.json
            // this example is just showing the usage of "NetworkConnections_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevCenterNetworkConnectionResource created on azure
            // for more information of creating DevCenterNetworkConnectionResource, please refer to the document of DevCenterNetworkConnectionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkConnectionName = "eastusnetwork";
            ResourceIdentifier devCenterNetworkConnectionResourceId = DevCenterNetworkConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkConnectionName);
            DevCenterNetworkConnectionResource devCenterNetworkConnection = client.GetDevCenterNetworkConnectionResource(devCenterNetworkConnectionResourceId);

            // invoke the operation
            await devCenterNetworkConnection.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // NetworkConnections_RunHealthChecks
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task RunHealthChecks_NetworkConnectionsRunHealthChecks()
        {
            // Generated from example definition: specification/devcenter/resource-manager/Microsoft.DevCenter/stable/2023-04-01/examples/NetworkConnections_RunHealthChecks.json
            // this example is just showing the usage of "NetworkConnections_RunHealthChecks" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevCenterNetworkConnectionResource created on azure
            // for more information of creating DevCenterNetworkConnectionResource, please refer to the document of DevCenterNetworkConnectionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkConnectionName = "uswest3network";
            ResourceIdentifier devCenterNetworkConnectionResourceId = DevCenterNetworkConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkConnectionName);
            DevCenterNetworkConnectionResource devCenterNetworkConnection = client.GetDevCenterNetworkConnectionResource(devCenterNetworkConnectionResourceId);

            // invoke the operation
            await devCenterNetworkConnection.RunHealthChecksAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // ListOutboundNetworkDependencies
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetOutboundEnvironmentEndpoints_ListOutboundNetworkDependencies()
        {
            // Generated from example definition: specification/devcenter/resource-manager/Microsoft.DevCenter/stable/2023-04-01/examples/NetworkConnections_ListOutboundNetworkDependenciesEndpoints.json
            // this example is just showing the usage of "NetworkConnections_ListOutboundNetworkDependenciesEndpoints" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevCenterNetworkConnectionResource created on azure
            // for more information of creating DevCenterNetworkConnectionResource, please refer to the document of DevCenterNetworkConnectionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkConnectionName = "uswest3network";
            ResourceIdentifier devCenterNetworkConnectionResourceId = DevCenterNetworkConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkConnectionName);
            DevCenterNetworkConnectionResource devCenterNetworkConnection = client.GetDevCenterNetworkConnectionResource(devCenterNetworkConnectionResourceId);

            // invoke the operation and iterate over the result
            await foreach (OutboundEnvironmentEndpoint item in devCenterNetworkConnection.GetOutboundEnvironmentEndpointsAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
