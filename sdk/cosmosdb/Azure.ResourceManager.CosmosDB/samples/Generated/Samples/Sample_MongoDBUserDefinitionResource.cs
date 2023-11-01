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
using Azure.ResourceManager.CosmosDB;
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB.Samples
{
    public partial class Sample_MongoDBUserDefinitionResource
    {
        // CosmosDBMongoDBUserDefinitionGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_CosmosDBMongoDBUserDefinitionGet()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2023-09-15-preview/examples/CosmosDBMongoDBUserDefinitionGet.json
            // this example is just showing the usage of "MongoDBResources_GetMongoUserDefinition" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MongoDBUserDefinitionResource created on azure
            // for more information of creating MongoDBUserDefinitionResource, please refer to the document of MongoDBUserDefinitionResource
            string subscriptionId = "mySubscriptionId";
            string resourceGroupName = "myResourceGroupName";
            string accountName = "myAccountName";
            string mongoUserDefinitionId = "myMongoUserDefinitionId";
            ResourceIdentifier mongoDBUserDefinitionResourceId = MongoDBUserDefinitionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, mongoUserDefinitionId);
            MongoDBUserDefinitionResource mongoDBUserDefinition = client.GetMongoDBUserDefinitionResource(mongoDBUserDefinitionResourceId);

            // invoke the operation
            MongoDBUserDefinitionResource result = await mongoDBUserDefinition.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MongoDBUserDefinitionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CosmosDBMongoDBUserDefinitionCreateUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CosmosDBMongoDBUserDefinitionCreateUpdate()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2023-09-15-preview/examples/CosmosDBMongoDBUserDefinitionCreateUpdate.json
            // this example is just showing the usage of "MongoDBResources_CreateUpdateMongoUserDefinition" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MongoDBUserDefinitionResource created on azure
            // for more information of creating MongoDBUserDefinitionResource, please refer to the document of MongoDBUserDefinitionResource
            string subscriptionId = "mySubscriptionId";
            string resourceGroupName = "myResourceGroupName";
            string accountName = "myAccountName";
            string mongoUserDefinitionId = "myMongoUserDefinitionId";
            ResourceIdentifier mongoDBUserDefinitionResourceId = MongoDBUserDefinitionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, mongoUserDefinitionId);
            MongoDBUserDefinitionResource mongoDBUserDefinition = client.GetMongoDBUserDefinitionResource(mongoDBUserDefinitionResourceId);

            // invoke the operation
            MongoDBUserDefinitionCreateOrUpdateContent content = new MongoDBUserDefinitionCreateOrUpdateContent()
            {
                UserName = "myUserName",
                Password = "myPassword",
                DatabaseName = "sales",
                CustomData = "My custom data",
                Roles =
{
new MongoDBRole()
{
DBName = "sales",
Role = "myReadRole",
}
},
                Mechanisms = "SCRAM-SHA-256",
            };
            ArmOperation<MongoDBUserDefinitionResource> lro = await mongoDBUserDefinition.UpdateAsync(WaitUntil.Completed, content);
            MongoDBUserDefinitionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MongoDBUserDefinitionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CosmosDBMongoDBUserDefinitionDelete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_CosmosDBMongoDBUserDefinitionDelete()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2023-09-15-preview/examples/CosmosDBMongoDBUserDefinitionDelete.json
            // this example is just showing the usage of "MongoDBResources_DeleteMongoUserDefinition" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MongoDBUserDefinitionResource created on azure
            // for more information of creating MongoDBUserDefinitionResource, please refer to the document of MongoDBUserDefinitionResource
            string subscriptionId = "mySubscriptionId";
            string resourceGroupName = "myResourceGroupName";
            string accountName = "myAccountName";
            string mongoUserDefinitionId = "myMongoUserDefinitionId";
            ResourceIdentifier mongoDBUserDefinitionResourceId = MongoDBUserDefinitionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, mongoUserDefinitionId);
            MongoDBUserDefinitionResource mongoDBUserDefinition = client.GetMongoDBUserDefinitionResource(mongoDBUserDefinitionResourceId);

            // invoke the operation
            await mongoDBUserDefinition.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
