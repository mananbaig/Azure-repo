// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB.Samples
{
    public partial class Sample_CosmosDBPrivateEndpointConnectionResource
    {
        // Gets private endpoint connection.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetsPrivateEndpointConnection()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-05-15-preview/examples/CosmosDBPrivateEndpointConnectionGet.json
            // this example is just showing the usage of "PrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBPrivateEndpointConnectionResource created on azure
            // for more information of creating CosmosDBPrivateEndpointConnectionResource, please refer to the document of CosmosDBPrivateEndpointConnectionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string privateEndpointConnectionName = "privateEndpointConnectionName";
            ResourceIdentifier cosmosDBPrivateEndpointConnectionResourceId = CosmosDBPrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, privateEndpointConnectionName);
            CosmosDBPrivateEndpointConnectionResource cosmosDBPrivateEndpointConnection = client.GetCosmosDBPrivateEndpointConnectionResource(cosmosDBPrivateEndpointConnectionResourceId);

            // invoke the operation
            CosmosDBPrivateEndpointConnectionResource result = await cosmosDBPrivateEndpointConnection.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CosmosDBPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Approve or reject a private endpoint connection with a given name.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_ApproveOrRejectAPrivateEndpointConnectionWithAGivenName()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-05-15-preview/examples/CosmosDBPrivateEndpointConnectionUpdate.json
            // this example is just showing the usage of "PrivateEndpointConnections_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBPrivateEndpointConnectionResource created on azure
            // for more information of creating CosmosDBPrivateEndpointConnectionResource, please refer to the document of CosmosDBPrivateEndpointConnectionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string privateEndpointConnectionName = "privateEndpointConnectionName";
            ResourceIdentifier cosmosDBPrivateEndpointConnectionResourceId = CosmosDBPrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, privateEndpointConnectionName);
            CosmosDBPrivateEndpointConnectionResource cosmosDBPrivateEndpointConnection = client.GetCosmosDBPrivateEndpointConnectionResource(cosmosDBPrivateEndpointConnectionResourceId);

            // invoke the operation
            CosmosDBPrivateEndpointConnectionData data = new CosmosDBPrivateEndpointConnectionData()
            {
                ConnectionState = new CosmosDBPrivateLinkServiceConnectionStateProperty()
                {
                    Status = "Approved",
                    Description = "Approved by johndoe@contoso.com",
                },
            };
            ArmOperation<CosmosDBPrivateEndpointConnectionResource> lro = await cosmosDBPrivateEndpointConnection.UpdateAsync(WaitUntil.Completed, data);
            CosmosDBPrivateEndpointConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CosmosDBPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Deletes a private endpoint connection with a given name.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeletesAPrivateEndpointConnectionWithAGivenName()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-05-15-preview/examples/CosmosDBPrivateEndpointConnectionDelete.json
            // this example is just showing the usage of "PrivateEndpointConnections_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBPrivateEndpointConnectionResource created on azure
            // for more information of creating CosmosDBPrivateEndpointConnectionResource, please refer to the document of CosmosDBPrivateEndpointConnectionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string privateEndpointConnectionName = "privateEndpointConnectionName";
            ResourceIdentifier cosmosDBPrivateEndpointConnectionResourceId = CosmosDBPrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, privateEndpointConnectionName);
            CosmosDBPrivateEndpointConnectionResource cosmosDBPrivateEndpointConnection = client.GetCosmosDBPrivateEndpointConnectionResource(cosmosDBPrivateEndpointConnectionResourceId);

            // invoke the operation
            await cosmosDBPrivateEndpointConnection.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
