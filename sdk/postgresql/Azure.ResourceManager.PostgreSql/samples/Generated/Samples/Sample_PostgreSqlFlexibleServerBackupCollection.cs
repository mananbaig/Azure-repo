// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Samples
{
    public partial class Sample_PostgreSqlFlexibleServerBackupCollection
    {
        // Create a new Backup for a flexible server
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateANewBackupForAFlexibleServer()
        {
            // Generated from example definition: specification/postgresql/resource-manager/Microsoft.DBforPostgreSQL/stable/2024-08-01/examples/BackupCreate.json
            // this example is just showing the usage of "Backups_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PostgreSqlFlexibleServerResource created on azure
            // for more information of creating PostgreSqlFlexibleServerResource, please refer to the document of PostgreSqlFlexibleServerResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestGroup";
            string serverName = "postgresqltestserver";
            ResourceIdentifier postgreSqlFlexibleServerResourceId = PostgreSqlFlexibleServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            PostgreSqlFlexibleServerResource postgreSqlFlexibleServer = client.GetPostgreSqlFlexibleServerResource(postgreSqlFlexibleServerResourceId);

            // get the collection of this PostgreSqlFlexibleServerBackupResource
            PostgreSqlFlexibleServerBackupCollection collection = postgreSqlFlexibleServer.GetPostgreSqlFlexibleServerBackups();

            // invoke the operation
            string backupName = "backup_20210615T160516";
            ArmOperation<PostgreSqlFlexibleServerBackupResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, backupName);
            PostgreSqlFlexibleServerBackupResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PostgreSqlFlexibleServerBackupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a backup for a server
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetABackupForAServer()
        {
            // Generated from example definition: specification/postgresql/resource-manager/Microsoft.DBforPostgreSQL/stable/2024-08-01/examples/BackupGet.json
            // this example is just showing the usage of "Backups_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PostgreSqlFlexibleServerResource created on azure
            // for more information of creating PostgreSqlFlexibleServerResource, please refer to the document of PostgreSqlFlexibleServerResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestGroup";
            string serverName = "postgresqltestserver";
            ResourceIdentifier postgreSqlFlexibleServerResourceId = PostgreSqlFlexibleServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            PostgreSqlFlexibleServerResource postgreSqlFlexibleServer = client.GetPostgreSqlFlexibleServerResource(postgreSqlFlexibleServerResourceId);

            // get the collection of this PostgreSqlFlexibleServerBackupResource
            PostgreSqlFlexibleServerBackupCollection collection = postgreSqlFlexibleServer.GetPostgreSqlFlexibleServerBackups();

            // invoke the operation
            string backupName = "daily_20210615T160516";
            PostgreSqlFlexibleServerBackupResource result = await collection.GetAsync(backupName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PostgreSqlFlexibleServerBackupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a backup for a server
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetABackupForAServer()
        {
            // Generated from example definition: specification/postgresql/resource-manager/Microsoft.DBforPostgreSQL/stable/2024-08-01/examples/BackupGet.json
            // this example is just showing the usage of "Backups_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PostgreSqlFlexibleServerResource created on azure
            // for more information of creating PostgreSqlFlexibleServerResource, please refer to the document of PostgreSqlFlexibleServerResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestGroup";
            string serverName = "postgresqltestserver";
            ResourceIdentifier postgreSqlFlexibleServerResourceId = PostgreSqlFlexibleServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            PostgreSqlFlexibleServerResource postgreSqlFlexibleServer = client.GetPostgreSqlFlexibleServerResource(postgreSqlFlexibleServerResourceId);

            // get the collection of this PostgreSqlFlexibleServerBackupResource
            PostgreSqlFlexibleServerBackupCollection collection = postgreSqlFlexibleServer.GetPostgreSqlFlexibleServerBackups();

            // invoke the operation
            string backupName = "daily_20210615T160516";
            bool result = await collection.ExistsAsync(backupName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get a backup for a server
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetABackupForAServer()
        {
            // Generated from example definition: specification/postgresql/resource-manager/Microsoft.DBforPostgreSQL/stable/2024-08-01/examples/BackupGet.json
            // this example is just showing the usage of "Backups_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PostgreSqlFlexibleServerResource created on azure
            // for more information of creating PostgreSqlFlexibleServerResource, please refer to the document of PostgreSqlFlexibleServerResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestGroup";
            string serverName = "postgresqltestserver";
            ResourceIdentifier postgreSqlFlexibleServerResourceId = PostgreSqlFlexibleServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            PostgreSqlFlexibleServerResource postgreSqlFlexibleServer = client.GetPostgreSqlFlexibleServerResource(postgreSqlFlexibleServerResourceId);

            // get the collection of this PostgreSqlFlexibleServerBackupResource
            PostgreSqlFlexibleServerBackupCollection collection = postgreSqlFlexibleServer.GetPostgreSqlFlexibleServerBackups();

            // invoke the operation
            string backupName = "daily_20210615T160516";
            NullableResponse<PostgreSqlFlexibleServerBackupResource> response = await collection.GetIfExistsAsync(backupName);
            PostgreSqlFlexibleServerBackupResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                PostgreSqlFlexibleServerBackupData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // List backups for a server
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListBackupsForAServer()
        {
            // Generated from example definition: specification/postgresql/resource-manager/Microsoft.DBforPostgreSQL/stable/2024-08-01/examples/BackupListByServer.json
            // this example is just showing the usage of "Backups_ListByServer" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PostgreSqlFlexibleServerResource created on azure
            // for more information of creating PostgreSqlFlexibleServerResource, please refer to the document of PostgreSqlFlexibleServerResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestGroup";
            string serverName = "postgresqltestserver";
            ResourceIdentifier postgreSqlFlexibleServerResourceId = PostgreSqlFlexibleServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            PostgreSqlFlexibleServerResource postgreSqlFlexibleServer = client.GetPostgreSqlFlexibleServerResource(postgreSqlFlexibleServerResourceId);

            // get the collection of this PostgreSqlFlexibleServerBackupResource
            PostgreSqlFlexibleServerBackupCollection collection = postgreSqlFlexibleServer.GetPostgreSqlFlexibleServerBackups();

            // invoke the operation and iterate over the result
            await foreach (PostgreSqlFlexibleServerBackupResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                PostgreSqlFlexibleServerBackupData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
