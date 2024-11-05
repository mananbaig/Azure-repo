// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.EventHubs.Models;

namespace Azure.ResourceManager.EventHubs.Samples
{
    public partial class Sample_EventHubsPrivateEndpointConnectionResource
    {
        // NameSpacePrivateEndPointConnectionCreate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_NameSpacePrivateEndPointConnectionCreate()
        {
            // Generated from example definition: specification/eventhub/resource-manager/Microsoft.EventHub/stable/2024-01-01/examples/NameSpaces/PrivateEndPointConnectionCreate.json
            // this example is just showing the usage of "PrivateEndpointConnections_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventHubsPrivateEndpointConnectionResource created on azure
            // for more information of creating EventHubsPrivateEndpointConnectionResource, please refer to the document of EventHubsPrivateEndpointConnectionResource
            string subscriptionId = "subID";
            string resourceGroupName = "ArunMonocle";
            string namespaceName = "sdk-Namespace-2924";
            string privateEndpointConnectionName = "privateEndpointConnectionName";
            ResourceIdentifier eventHubsPrivateEndpointConnectionResourceId = EventHubsPrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, privateEndpointConnectionName);
            EventHubsPrivateEndpointConnectionResource eventHubsPrivateEndpointConnection = client.GetEventHubsPrivateEndpointConnectionResource(eventHubsPrivateEndpointConnectionResourceId);

            // invoke the operation
            EventHubsPrivateEndpointConnectionData data = new EventHubsPrivateEndpointConnectionData()
            {
                PrivateEndpointId = new ResourceIdentifier("/subscriptions/dbedb4e0-40e6-4145-81f3-f1314c150774/resourceGroups/SDK-EventHub-8396/providers/Microsoft.Network/privateEndpoints/sdk-Namespace-2847"),
                ConnectionState = new EventHubsPrivateLinkServiceConnectionState()
                {
                    Status = EventHubsPrivateLinkConnectionStatus.Rejected,
                    Description = "testing",
                },
                ProvisioningState = EventHubsPrivateEndpointConnectionProvisioningState.Succeeded,
            };
            ArmOperation<EventHubsPrivateEndpointConnectionResource> lro = await eventHubsPrivateEndpointConnection.UpdateAsync(WaitUntil.Completed, data);
            EventHubsPrivateEndpointConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            EventHubsPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // NameSpacePrivateEndPointConnectionDelete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_NameSpacePrivateEndPointConnectionDelete()
        {
            // Generated from example definition: specification/eventhub/resource-manager/Microsoft.EventHub/stable/2024-01-01/examples/NameSpaces/PrivateEndPointConnectionDelete.json
            // this example is just showing the usage of "PrivateEndpointConnections_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventHubsPrivateEndpointConnectionResource created on azure
            // for more information of creating EventHubsPrivateEndpointConnectionResource, please refer to the document of EventHubsPrivateEndpointConnectionResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            string resourceGroupName = "ArunMonocle";
            string namespaceName = "sdk-Namespace-3285";
            string privateEndpointConnectionName = "928c44d5-b7c6-423b-b6fa-811e0c27b3e0";
            ResourceIdentifier eventHubsPrivateEndpointConnectionResourceId = EventHubsPrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, privateEndpointConnectionName);
            EventHubsPrivateEndpointConnectionResource eventHubsPrivateEndpointConnection = client.GetEventHubsPrivateEndpointConnectionResource(eventHubsPrivateEndpointConnectionResourceId);

            // invoke the operation
            await eventHubsPrivateEndpointConnection.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // NameSpacePrivateEndPointConnectionGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_NameSpacePrivateEndPointConnectionGet()
        {
            // Generated from example definition: specification/eventhub/resource-manager/Microsoft.EventHub/stable/2024-01-01/examples/NameSpaces/PrivateEndPointConnectionGet.json
            // this example is just showing the usage of "PrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventHubsPrivateEndpointConnectionResource created on azure
            // for more information of creating EventHubsPrivateEndpointConnectionResource, please refer to the document of EventHubsPrivateEndpointConnectionResource
            string subscriptionId = "subID";
            string resourceGroupName = "SDK-EventHub-4794";
            string namespaceName = "sdk-Namespace-5828";
            string privateEndpointConnectionName = "privateEndpointConnectionName";
            ResourceIdentifier eventHubsPrivateEndpointConnectionResourceId = EventHubsPrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, privateEndpointConnectionName);
            EventHubsPrivateEndpointConnectionResource eventHubsPrivateEndpointConnection = client.GetEventHubsPrivateEndpointConnectionResource(eventHubsPrivateEndpointConnectionResourceId);

            // invoke the operation
            EventHubsPrivateEndpointConnectionResource result = await eventHubsPrivateEndpointConnection.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            EventHubsPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
