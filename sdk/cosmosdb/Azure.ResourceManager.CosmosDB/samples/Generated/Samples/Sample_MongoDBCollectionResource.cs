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
    public partial class Sample_MongoDBCollectionResource
    {
        // CosmosDBMongoDBCollectionGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_CosmosDBMongoDBCollectionGet()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-05-15-preview/examples/CosmosDBMongoDBCollectionGet.json
            // this example is just showing the usage of "MongoDBResources_GetMongoDBCollection" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MongoDBCollectionResource created on azure
            // for more information of creating MongoDBCollectionResource, please refer to the document of MongoDBCollectionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rgName";
            string accountName = "ddb1";
            string databaseName = "databaseName";
            string collectionName = "collectionName";
            ResourceIdentifier mongoDBCollectionResourceId = MongoDBCollectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, databaseName, collectionName);
            MongoDBCollectionResource mongoDBCollection = client.GetMongoDBCollectionResource(mongoDBCollectionResourceId);

            // invoke the operation
            MongoDBCollectionResource result = await mongoDBCollection.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MongoDBCollectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CosmosDBMongoDBCollectionCreateUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CosmosDBMongoDBCollectionCreateUpdate()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-05-15-preview/examples/CosmosDBMongoDBCollectionCreateUpdate.json
            // this example is just showing the usage of "MongoDBResources_CreateUpdateMongoDBCollection" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MongoDBCollectionResource created on azure
            // for more information of creating MongoDBCollectionResource, please refer to the document of MongoDBCollectionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string databaseName = "databaseName";
            string collectionName = "collectionName";
            ResourceIdentifier mongoDBCollectionResourceId = MongoDBCollectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, databaseName, collectionName);
            MongoDBCollectionResource mongoDBCollection = client.GetMongoDBCollectionResource(mongoDBCollectionResourceId);

            // invoke the operation
            MongoDBCollectionCreateOrUpdateContent content = new MongoDBCollectionCreateOrUpdateContent(new AzureLocation("West US"), new MongoDBCollectionResourceInfo("collectionName")
            {
                ShardKey =
{
["testKey"] = "Hash",
},
                Indexes =
{
new MongoDBIndex()
{
Keys =
{
"_ts"
},
Options = new MongoDBIndexConfig()
{
ExpireAfterSeconds = 100,
IsUnique = true,
},
},new MongoDBIndex()
{
Keys =
{
"_id"
},
}
},
                AnalyticalStorageTtl = 500,
            })
            {
                Options = new CosmosDBCreateUpdateConfig(),
                Tags =
{
},
            };
            ArmOperation<MongoDBCollectionResource> lro = await mongoDBCollection.UpdateAsync(WaitUntil.Completed, content);
            MongoDBCollectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MongoDBCollectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CosmosDBMongoDBCollectionRestore
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CosmosDBMongoDBCollectionRestore()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-05-15-preview/examples/CosmosDBMongoDBCollectionRestore.json
            // this example is just showing the usage of "MongoDBResources_CreateUpdateMongoDBCollection" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MongoDBCollectionResource created on azure
            // for more information of creating MongoDBCollectionResource, please refer to the document of MongoDBCollectionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string databaseName = "databaseName";
            string collectionName = "collectionName";
            ResourceIdentifier mongoDBCollectionResourceId = MongoDBCollectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, databaseName, collectionName);
            MongoDBCollectionResource mongoDBCollection = client.GetMongoDBCollectionResource(mongoDBCollectionResourceId);

            // invoke the operation
            MongoDBCollectionCreateOrUpdateContent content = new MongoDBCollectionCreateOrUpdateContent(new AzureLocation("West US"), new MongoDBCollectionResourceInfo("collectionName")
            {
                RestoreParameters = new ResourceRestoreParameters()
                {
                    RestoreSource = "/subscriptions/subid/providers/Microsoft.DocumentDB/locations/WestUS/restorableDatabaseAccounts/restorableDatabaseAccountId",
                    RestoreTimestampInUtc = DateTimeOffset.Parse("2022-07-20T18:28:00Z"),
                    IsRestoreWithTtlDisabled = false,
                },
                CreateMode = CosmosDBAccountCreateMode.Restore,
            })
            {
                Options = new CosmosDBCreateUpdateConfig(),
                Tags =
{
},
            };
            ArmOperation<MongoDBCollectionResource> lro = await mongoDBCollection.UpdateAsync(WaitUntil.Completed, content);
            MongoDBCollectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MongoDBCollectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CosmosDBMongoDBCollectionDelete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_CosmosDBMongoDBCollectionDelete()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-05-15-preview/examples/CosmosDBMongoDBCollectionDelete.json
            // this example is just showing the usage of "MongoDBResources_DeleteMongoDBCollection" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MongoDBCollectionResource created on azure
            // for more information of creating MongoDBCollectionResource, please refer to the document of MongoDBCollectionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string databaseName = "databaseName";
            string collectionName = "collectionName";
            ResourceIdentifier mongoDBCollectionResourceId = MongoDBCollectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, databaseName, collectionName);
            MongoDBCollectionResource mongoDBCollection = client.GetMongoDBCollectionResource(mongoDBCollectionResourceId);

            // invoke the operation
            await mongoDBCollection.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // CosmosDBMongoDBCollectionPartitionMerge
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetMongoDBCollectionPartitionMerge_CosmosDBMongoDBCollectionPartitionMerge()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-05-15-preview/examples/CosmosDBMongoDBCollectionPartitionMerge.json
            // this example is just showing the usage of "MongoDBResources_ListMongoDBCollectionPartitionMerge" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MongoDBCollectionResource created on azure
            // for more information of creating MongoDBCollectionResource, please refer to the document of MongoDBCollectionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rgName";
            string accountName = "ddb1";
            string databaseName = "databaseName";
            string collectionName = "collectionName";
            ResourceIdentifier mongoDBCollectionResourceId = MongoDBCollectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, databaseName, collectionName);
            MongoDBCollectionResource mongoDBCollection = client.GetMongoDBCollectionResource(mongoDBCollectionResourceId);

            // invoke the operation
            MergeParameters mergeParameters = new MergeParameters()
            {
                IsDryRun = false,
            };
            ArmOperation<PhysicalPartitionStorageInfoCollection> lro = await mongoDBCollection.GetMongoDBCollectionPartitionMergeAsync(WaitUntil.Completed, mergeParameters);
            PhysicalPartitionStorageInfoCollection result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // CosmosDBMongoDBCollectionBackupInformation
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task RetrieveContinuousBackupInformation_CosmosDBMongoDBCollectionBackupInformation()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-05-15-preview/examples/CosmosDBMongoDBCollectionBackupInformation.json
            // this example is just showing the usage of "MongoDBResources_RetrieveContinuousBackupInformation" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MongoDBCollectionResource created on azure
            // for more information of creating MongoDBCollectionResource, please refer to the document of MongoDBCollectionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rgName";
            string accountName = "ddb1";
            string databaseName = "databaseName";
            string collectionName = "collectionName";
            ResourceIdentifier mongoDBCollectionResourceId = MongoDBCollectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, databaseName, collectionName);
            MongoDBCollectionResource mongoDBCollection = client.GetMongoDBCollectionResource(mongoDBCollectionResourceId);

            // invoke the operation
            ContinuousBackupRestoreLocation location = new ContinuousBackupRestoreLocation()
            {
                Location = new AzureLocation("North Europe"),
            };
            ArmOperation<CosmosDBBackupInformation> lro = await mongoDBCollection.RetrieveContinuousBackupInformationAsync(WaitUntil.Completed, location);
            CosmosDBBackupInformation result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
