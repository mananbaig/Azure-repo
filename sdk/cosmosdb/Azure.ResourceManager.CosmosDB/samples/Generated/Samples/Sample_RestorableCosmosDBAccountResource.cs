// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.CosmosDB.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.CosmosDB.Samples
{
    public partial class Sample_RestorableCosmosDBAccountResource
    {
        // CosmosDBRestorableDatabaseAccountNoLocationList
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetRestorableCosmosDBAccounts_CosmosDBRestorableDatabaseAccountNoLocationList()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-05-15-preview/examples/CosmosDBRestorableDatabaseAccountNoLocationList.json
            // this example is just showing the usage of "RestorableDatabaseAccounts_List" operation, for the dependent resources, they will have to be created separately.

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
            await foreach (RestorableCosmosDBAccountResource item in subscriptionResource.GetRestorableCosmosDBAccountsAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                RestorableCosmosDBAccountData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // CosmosDBRestorableDatabaseAccountGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_CosmosDBRestorableDatabaseAccountGet()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-05-15-preview/examples/CosmosDBRestorableDatabaseAccountGet.json
            // this example is just showing the usage of "RestorableDatabaseAccounts_GetByLocation" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RestorableCosmosDBAccountResource created on azure
            // for more information of creating RestorableCosmosDBAccountResource, please refer to the document of RestorableCosmosDBAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            AzureLocation location = new AzureLocation("West US");
            Guid instanceId = Guid.Parse("d9b26648-2f53-4541-b3d8-3044f4f9810d");
            ResourceIdentifier restorableCosmosDBAccountResourceId = RestorableCosmosDBAccountResource.CreateResourceIdentifier(subscriptionId, location, instanceId);
            RestorableCosmosDBAccountResource restorableCosmosDBAccount = client.GetRestorableCosmosDBAccountResource(restorableCosmosDBAccountResourceId);

            // invoke the operation
            RestorableCosmosDBAccountResource result = await restorableCosmosDBAccount.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RestorableCosmosDBAccountData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CosmosDBRestorableSqlDatabaseList
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetRestorableSqlDatabases_CosmosDBRestorableSqlDatabaseList()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-05-15-preview/examples/CosmosDBRestorableSqlDatabaseList.json
            // this example is just showing the usage of "RestorableSqlDatabases_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RestorableCosmosDBAccountResource created on azure
            // for more information of creating RestorableCosmosDBAccountResource, please refer to the document of RestorableCosmosDBAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            AzureLocation location = new AzureLocation("WestUS");
            Guid instanceId = Guid.Parse("d9b26648-2f53-4541-b3d8-3044f4f9810d");
            ResourceIdentifier restorableCosmosDBAccountResourceId = RestorableCosmosDBAccountResource.CreateResourceIdentifier(subscriptionId, location, instanceId);
            RestorableCosmosDBAccountResource restorableCosmosDBAccount = client.GetRestorableCosmosDBAccountResource(restorableCosmosDBAccountResourceId);

            // invoke the operation and iterate over the result
            await foreach (RestorableSqlDatabase item in restorableCosmosDBAccount.GetRestorableSqlDatabasesAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // CosmosDBRestorableSqlContainerList
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetRestorableSqlContainers_CosmosDBRestorableSqlContainerList()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-05-15-preview/examples/CosmosDBRestorableSqlContainerList.json
            // this example is just showing the usage of "RestorableSqlContainers_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RestorableCosmosDBAccountResource created on azure
            // for more information of creating RestorableCosmosDBAccountResource, please refer to the document of RestorableCosmosDBAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            AzureLocation location = new AzureLocation("WestUS");
            Guid instanceId = Guid.Parse("98a570f2-63db-4117-91f0-366327b7b353");
            ResourceIdentifier restorableCosmosDBAccountResourceId = RestorableCosmosDBAccountResource.CreateResourceIdentifier(subscriptionId, location, instanceId);
            RestorableCosmosDBAccountResource restorableCosmosDBAccount = client.GetRestorableCosmosDBAccountResource(restorableCosmosDBAccountResourceId);

            // invoke the operation and iterate over the result
            string restorableSqlDatabaseRid = "3fu-hg==";
            await foreach (RestorableSqlContainer item in restorableCosmosDBAccount.GetRestorableSqlContainersAsync(restorableSqlDatabaseRid: restorableSqlDatabaseRid))
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // CosmosDBRestorableSqlResourceList
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAllRestorableSqlResourceData_CosmosDBRestorableSqlResourceList()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-05-15-preview/examples/CosmosDBRestorableSqlResourceList.json
            // this example is just showing the usage of "RestorableSqlResources_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RestorableCosmosDBAccountResource created on azure
            // for more information of creating RestorableCosmosDBAccountResource, please refer to the document of RestorableCosmosDBAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            AzureLocation location = new AzureLocation("WestUS");
            Guid instanceId = Guid.Parse("d9b26648-2f53-4541-b3d8-3044f4f9810d");
            ResourceIdentifier restorableCosmosDBAccountResourceId = RestorableCosmosDBAccountResource.CreateResourceIdentifier(subscriptionId, location, instanceId);
            RestorableCosmosDBAccountResource restorableCosmosDBAccount = client.GetRestorableCosmosDBAccountResource(restorableCosmosDBAccountResourceId);

            // invoke the operation and iterate over the result
            AzureLocation? restoreLocation = new AzureLocation("WestUS");
            string restoreTimestampInUtc = "06/01/2022 4:56";
            await foreach (RestorableSqlResourceData item in restorableCosmosDBAccount.GetAllRestorableSqlResourceDataAsync(restoreLocation: restoreLocation, restoreTimestampInUtc: restoreTimestampInUtc))
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // CosmosDBRestorableMongodbDatabaseList
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetRestorableMongoDBDatabases_CosmosDBRestorableMongodbDatabaseList()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-05-15-preview/examples/CosmosDBRestorableMongodbDatabaseList.json
            // this example is just showing the usage of "RestorableMongodbDatabases_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RestorableCosmosDBAccountResource created on azure
            // for more information of creating RestorableCosmosDBAccountResource, please refer to the document of RestorableCosmosDBAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            AzureLocation location = new AzureLocation("WestUS");
            Guid instanceId = Guid.Parse("d9b26648-2f53-4541-b3d8-3044f4f9810d");
            ResourceIdentifier restorableCosmosDBAccountResourceId = RestorableCosmosDBAccountResource.CreateResourceIdentifier(subscriptionId, location, instanceId);
            RestorableCosmosDBAccountResource restorableCosmosDBAccount = client.GetRestorableCosmosDBAccountResource(restorableCosmosDBAccountResourceId);

            // invoke the operation and iterate over the result
            await foreach (RestorableMongoDBDatabase item in restorableCosmosDBAccount.GetRestorableMongoDBDatabasesAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // CosmosDBRestorableMongodbCollectionList
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetRestorableMongoDBCollections_CosmosDBRestorableMongodbCollectionList()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-05-15-preview/examples/CosmosDBRestorableMongodbCollectionList.json
            // this example is just showing the usage of "RestorableMongodbCollections_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RestorableCosmosDBAccountResource created on azure
            // for more information of creating RestorableCosmosDBAccountResource, please refer to the document of RestorableCosmosDBAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            AzureLocation location = new AzureLocation("WestUS");
            Guid instanceId = Guid.Parse("98a570f2-63db-4117-91f0-366327b7b353");
            ResourceIdentifier restorableCosmosDBAccountResourceId = RestorableCosmosDBAccountResource.CreateResourceIdentifier(subscriptionId, location, instanceId);
            RestorableCosmosDBAccountResource restorableCosmosDBAccount = client.GetRestorableCosmosDBAccountResource(restorableCosmosDBAccountResourceId);

            // invoke the operation and iterate over the result
            string restorableMongoDBDatabaseRid = "PD5DALigDgw=";
            await foreach (RestorableMongoDBCollection item in restorableCosmosDBAccount.GetRestorableMongoDBCollectionsAsync(restorableMongoDBDatabaseRid: restorableMongoDBDatabaseRid))
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // CosmosDBRestorableMongodbResourceList
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAllRestorableMongoDBResourceData_CosmosDBRestorableMongodbResourceList()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-05-15-preview/examples/CosmosDBRestorableMongodbResourceList.json
            // this example is just showing the usage of "RestorableMongodbResources_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RestorableCosmosDBAccountResource created on azure
            // for more information of creating RestorableCosmosDBAccountResource, please refer to the document of RestorableCosmosDBAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            AzureLocation location = new AzureLocation("WestUS");
            Guid instanceId = Guid.Parse("d9b26648-2f53-4541-b3d8-3044f4f9810d");
            ResourceIdentifier restorableCosmosDBAccountResourceId = RestorableCosmosDBAccountResource.CreateResourceIdentifier(subscriptionId, location, instanceId);
            RestorableCosmosDBAccountResource restorableCosmosDBAccount = client.GetRestorableCosmosDBAccountResource(restorableCosmosDBAccountResourceId);

            // invoke the operation and iterate over the result
            AzureLocation? restoreLocation = new AzureLocation("WestUS");
            string restoreTimestampInUtc = "06/01/2022 4:56";
            await foreach (RestorableMongoDBResourceData item in restorableCosmosDBAccount.GetAllRestorableMongoDBResourceDataAsync(restoreLocation: restoreLocation, restoreTimestampInUtc: restoreTimestampInUtc))
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // CosmosDBRestorableGremlinDatabaseList
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetRestorableGremlinDatabases_CosmosDBRestorableGremlinDatabaseList()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-05-15-preview/examples/CosmosDBRestorableGremlinDatabaseList.json
            // this example is just showing the usage of "RestorableGremlinDatabases_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RestorableCosmosDBAccountResource created on azure
            // for more information of creating RestorableCosmosDBAccountResource, please refer to the document of RestorableCosmosDBAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            AzureLocation location = new AzureLocation("WestUS");
            Guid instanceId = Guid.Parse("d9b26648-2f53-4541-b3d8-3044f4f9810d");
            ResourceIdentifier restorableCosmosDBAccountResourceId = RestorableCosmosDBAccountResource.CreateResourceIdentifier(subscriptionId, location, instanceId);
            RestorableCosmosDBAccountResource restorableCosmosDBAccount = client.GetRestorableCosmosDBAccountResource(restorableCosmosDBAccountResourceId);

            // invoke the operation and iterate over the result
            await foreach (RestorableGremlinDatabase item in restorableCosmosDBAccount.GetRestorableGremlinDatabasesAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // CosmosDBRestorableGremlinGraphList
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetRestorableGremlinGraphs_CosmosDBRestorableGremlinGraphList()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-05-15-preview/examples/CosmosDBRestorableGremlinGraphList.json
            // this example is just showing the usage of "RestorableGremlinGraphs_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RestorableCosmosDBAccountResource created on azure
            // for more information of creating RestorableCosmosDBAccountResource, please refer to the document of RestorableCosmosDBAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            AzureLocation location = new AzureLocation("WestUS");
            Guid instanceId = Guid.Parse("98a570f2-63db-4117-91f0-366327b7b353");
            ResourceIdentifier restorableCosmosDBAccountResourceId = RestorableCosmosDBAccountResource.CreateResourceIdentifier(subscriptionId, location, instanceId);
            RestorableCosmosDBAccountResource restorableCosmosDBAccount = client.GetRestorableCosmosDBAccountResource(restorableCosmosDBAccountResourceId);

            // invoke the operation and iterate over the result
            string restorableGremlinDatabaseRid = "PD5DALigDgw=";
            await foreach (RestorableGremlinGraph item in restorableCosmosDBAccount.GetRestorableGremlinGraphsAsync(restorableGremlinDatabaseRid: restorableGremlinDatabaseRid))
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // CosmosDBRestorableGremlinResourceList
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetRestorableGremlinResources_CosmosDBRestorableGremlinResourceList()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-05-15-preview/examples/CosmosDBRestorableGremlinResourceList.json
            // this example is just showing the usage of "RestorableGremlinResources_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RestorableCosmosDBAccountResource created on azure
            // for more information of creating RestorableCosmosDBAccountResource, please refer to the document of RestorableCosmosDBAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            AzureLocation location = new AzureLocation("WestUS");
            Guid instanceId = Guid.Parse("d9b26648-2f53-4541-b3d8-3044f4f9810d");
            ResourceIdentifier restorableCosmosDBAccountResourceId = RestorableCosmosDBAccountResource.CreateResourceIdentifier(subscriptionId, location, instanceId);
            RestorableCosmosDBAccountResource restorableCosmosDBAccount = client.GetRestorableCosmosDBAccountResource(restorableCosmosDBAccountResourceId);

            // invoke the operation and iterate over the result
            AzureLocation? restoreLocation = new AzureLocation("WestUS");
            string restoreTimestampInUtc = "06/01/2022 4:56";
            await foreach (RestorableGremlinResourceData item in restorableCosmosDBAccount.GetRestorableGremlinResourcesAsync(restoreLocation: restoreLocation, restoreTimestampInUtc: restoreTimestampInUtc))
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // CosmosDBRestorableTableList
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetRestorableTables_CosmosDBRestorableTableList()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-05-15-preview/examples/CosmosDBRestorableTableList.json
            // this example is just showing the usage of "RestorableTables_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RestorableCosmosDBAccountResource created on azure
            // for more information of creating RestorableCosmosDBAccountResource, please refer to the document of RestorableCosmosDBAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            AzureLocation location = new AzureLocation("WestUS");
            Guid instanceId = Guid.Parse("98a570f2-63db-4117-91f0-366327b7b353");
            ResourceIdentifier restorableCosmosDBAccountResourceId = RestorableCosmosDBAccountResource.CreateResourceIdentifier(subscriptionId, location, instanceId);
            RestorableCosmosDBAccountResource restorableCosmosDBAccount = client.GetRestorableCosmosDBAccountResource(restorableCosmosDBAccountResourceId);

            // invoke the operation and iterate over the result
            await foreach (RestorableTable item in restorableCosmosDBAccount.GetRestorableTablesAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // CosmosDBRestorableTableResourceList
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetRestorableTableResources_CosmosDBRestorableTableResourceList()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-05-15-preview/examples/CosmosDBRestorableTableResourceList.json
            // this example is just showing the usage of "RestorableTableResources_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RestorableCosmosDBAccountResource created on azure
            // for more information of creating RestorableCosmosDBAccountResource, please refer to the document of RestorableCosmosDBAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            AzureLocation location = new AzureLocation("WestUS");
            Guid instanceId = Guid.Parse("d9b26648-2f53-4541-b3d8-3044f4f9810d");
            ResourceIdentifier restorableCosmosDBAccountResourceId = RestorableCosmosDBAccountResource.CreateResourceIdentifier(subscriptionId, location, instanceId);
            RestorableCosmosDBAccountResource restorableCosmosDBAccount = client.GetRestorableCosmosDBAccountResource(restorableCosmosDBAccountResourceId);

            // invoke the operation and iterate over the result
            AzureLocation? restoreLocation = new AzureLocation("WestUS");
            string restoreTimestampInUtc = "06/01/2022 4:56";
            await foreach (RestorableTableResourceData item in restorableCosmosDBAccount.GetRestorableTableResourcesAsync(restoreLocation: restoreLocation, restoreTimestampInUtc: restoreTimestampInUtc))
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
