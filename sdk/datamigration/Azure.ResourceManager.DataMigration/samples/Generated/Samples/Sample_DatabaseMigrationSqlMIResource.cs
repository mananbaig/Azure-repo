// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.DataMigration.Models;

namespace Azure.ResourceManager.DataMigration.Samples
{
    public partial class Sample_DatabaseMigrationSqlMIResource
    {
        // Get Sql MI database Migration with the expand parameter.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetSqlMIDatabaseMigrationWithTheExpandParameter()
        {
            // Generated from example definition: specification/datamigration/resource-manager/Microsoft.DataMigration/preview/2022-03-30-preview/examples/SqlMiGetDatabaseMigrationExpanded.json
            // this example is just showing the usage of "DatabaseMigrationsSqlMi_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DatabaseMigrationSqlMIResource created on azure
            // for more information of creating DatabaseMigrationSqlMIResource, please refer to the document of DatabaseMigrationSqlMIResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "testrg";
            string managedInstanceName = "managedInstance1";
            string targetDBName = "db1";
            ResourceIdentifier databaseMigrationSqlMIResourceId = DatabaseMigrationSqlMIResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, managedInstanceName, targetDBName);
            DatabaseMigrationSqlMIResource databaseMigrationSqlMI = client.GetDatabaseMigrationSqlMIResource(databaseMigrationSqlMIResourceId);

            // invoke the operation
            string expand = "MigrationStatusDetails";
            DatabaseMigrationSqlMIResource result = await databaseMigrationSqlMI.GetAsync(expand: expand);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DatabaseMigrationSqlMIData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get Sql MI database Migration without the expand parameter.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetSqlMIDatabaseMigrationWithoutTheExpandParameter()
        {
            // Generated from example definition: specification/datamigration/resource-manager/Microsoft.DataMigration/preview/2022-03-30-preview/examples/SqlMiGetDatabaseMigration.json
            // this example is just showing the usage of "DatabaseMigrationsSqlMi_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DatabaseMigrationSqlMIResource created on azure
            // for more information of creating DatabaseMigrationSqlMIResource, please refer to the document of DatabaseMigrationSqlMIResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "testrg";
            string managedInstanceName = "managedInstance1";
            string targetDBName = "db1";
            ResourceIdentifier databaseMigrationSqlMIResourceId = DatabaseMigrationSqlMIResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, managedInstanceName, targetDBName);
            DatabaseMigrationSqlMIResource databaseMigrationSqlMI = client.GetDatabaseMigrationSqlMIResource(databaseMigrationSqlMIResourceId);

            // invoke the operation
            DatabaseMigrationSqlMIResource result = await databaseMigrationSqlMI.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DatabaseMigrationSqlMIData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create or Update Database Migration resource with Maximum parameters.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreateOrUpdateDatabaseMigrationResourceWithMaximumParameters()
        {
            // Generated from example definition: specification/datamigration/resource-manager/Microsoft.DataMigration/preview/2022-03-30-preview/examples/SqlMiCreateOrUpdateDatabaseMigrationMAX.json
            // this example is just showing the usage of "DatabaseMigrationsSqlMi_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DatabaseMigrationSqlMIResource created on azure
            // for more information of creating DatabaseMigrationSqlMIResource, please refer to the document of DatabaseMigrationSqlMIResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "testrg";
            string managedInstanceName = "managedInstance1";
            string targetDBName = "db1";
            ResourceIdentifier databaseMigrationSqlMIResourceId = DatabaseMigrationSqlMIResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, managedInstanceName, targetDBName);
            DatabaseMigrationSqlMIResource databaseMigrationSqlMI = client.GetDatabaseMigrationSqlMIResource(databaseMigrationSqlMIResourceId);

            // invoke the operation
            DatabaseMigrationSqlMIData data = new DatabaseMigrationSqlMIData()
            {
                Properties = new DatabaseMigrationSqlMIProperties()
                {
                    BackupConfiguration = new BackupConfiguration()
                    {
                        SourceLocation = new SourceLocation()
                        {
                            FileShare = new SqlFileShare()
                            {
                                Path = "C:\\aaa\\bbb\\ccc",
                                Username = "name",
                                Password = "placeholder",
                            },
                        },
                        TargetLocation = new TargetLocation()
                        {
                            StorageAccountResourceId = "account.database.windows.net",
                            AccountKey = "abcd",
                        },
                    },
                    OfflineConfiguration = new OfflineConfiguration()
                    {
                        Offline = true,
                        LastBackupName = "last_backup_file_name",
                    },
                    Scope = "/subscriptions/00000000-1111-2222-3333-444444444444/resourceGroups/testrg/providers/Microsoft.Sql/managedInstances/instance",
                    SourceSqlConnection = new SqlConnectionInformation()
                    {
                        DataSource = "aaa",
                        Authentication = "WindowsAuthentication",
                        UserName = "bbb",
                        Password = "placeholder",
                        EncryptConnection = true,
                        TrustServerCertificate = true,
                    },
                    SourceDatabaseName = "aaa",
                    MigrationService = "/subscriptions/00000000-1111-2222-3333-444444444444/resourceGroups/testrg/providers/Microsoft.DataMigration/sqlMigrationServices/testagent",
                },
            };
            ArmOperation<DatabaseMigrationSqlMIResource> lro = await databaseMigrationSqlMI.UpdateAsync(WaitUntil.Completed, data);
            DatabaseMigrationSqlMIResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DatabaseMigrationSqlMIData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create or Update Database Migration resource with Minimum parameters.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreateOrUpdateDatabaseMigrationResourceWithMinimumParameters()
        {
            // Generated from example definition: specification/datamigration/resource-manager/Microsoft.DataMigration/preview/2022-03-30-preview/examples/SqlMiCreateOrUpdateDatabaseMigrationMIN.json
            // this example is just showing the usage of "DatabaseMigrationsSqlMi_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DatabaseMigrationSqlMIResource created on azure
            // for more information of creating DatabaseMigrationSqlMIResource, please refer to the document of DatabaseMigrationSqlMIResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "testrg";
            string managedInstanceName = "managedInstance1";
            string targetDBName = "db1";
            ResourceIdentifier databaseMigrationSqlMIResourceId = DatabaseMigrationSqlMIResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, managedInstanceName, targetDBName);
            DatabaseMigrationSqlMIResource databaseMigrationSqlMI = client.GetDatabaseMigrationSqlMIResource(databaseMigrationSqlMIResourceId);

            // invoke the operation
            DatabaseMigrationSqlMIData data = new DatabaseMigrationSqlMIData()
            {
                Properties = new DatabaseMigrationSqlMIProperties()
                {
                    BackupConfiguration = new BackupConfiguration()
                    {
                        SourceLocation = new SourceLocation()
                        {
                            FileShare = new SqlFileShare()
                            {
                                Path = "C:\\aaa\\bbb\\ccc",
                                Username = "name",
                                Password = "placeholder",
                            },
                        },
                        TargetLocation = new TargetLocation()
                        {
                            StorageAccountResourceId = "account.database.windows.net",
                            AccountKey = "abcd",
                        },
                    },
                    Scope = "/subscriptions/00000000-1111-2222-3333-444444444444/resourceGroups/testrg/providers/Microsoft.Sql/managedInstances/instance",
                    SourceSqlConnection = new SqlConnectionInformation()
                    {
                        DataSource = "aaa",
                        Authentication = "WindowsAuthentication",
                        UserName = "bbb",
                        Password = "placeholder",
                        EncryptConnection = true,
                        TrustServerCertificate = true,
                    },
                    SourceDatabaseName = "aaa",
                    MigrationService = "/subscriptions/00000000-1111-2222-3333-444444444444/resourceGroups/testrg/providers/Microsoft.DataMigration/sqlMigrationServices/testagent",
                },
            };
            ArmOperation<DatabaseMigrationSqlMIResource> lro = await databaseMigrationSqlMI.UpdateAsync(WaitUntil.Completed, data);
            DatabaseMigrationSqlMIResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DatabaseMigrationSqlMIData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Stop ongoing migration for the database.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Cancel_StopOngoingMigrationForTheDatabase()
        {
            // Generated from example definition: specification/datamigration/resource-manager/Microsoft.DataMigration/preview/2022-03-30-preview/examples/SqlMiCancelDatabaseMigration.json
            // this example is just showing the usage of "DatabaseMigrationsSqlMi_Cancel" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DatabaseMigrationSqlMIResource created on azure
            // for more information of creating DatabaseMigrationSqlMIResource, please refer to the document of DatabaseMigrationSqlMIResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "testrg";
            string managedInstanceName = "managedInstance1";
            string targetDBName = "db1";
            ResourceIdentifier databaseMigrationSqlMIResourceId = DatabaseMigrationSqlMIResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, managedInstanceName, targetDBName);
            DatabaseMigrationSqlMIResource databaseMigrationSqlMI = client.GetDatabaseMigrationSqlMIResource(databaseMigrationSqlMIResourceId);

            // invoke the operation
            MigrationOperationInput input = new MigrationOperationInput()
            {
                MigrationOperationId = Guid.Parse("4124fe90-d1b6-4b50-b4d9-46d02381f59a"),
            };
            await databaseMigrationSqlMI.CancelAsync(WaitUntil.Completed, input);

            Console.WriteLine($"Succeeded");
        }

        // Cutover online migration operation for the database.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Cutover_CutoverOnlineMigrationOperationForTheDatabase()
        {
            // Generated from example definition: specification/datamigration/resource-manager/Microsoft.DataMigration/preview/2022-03-30-preview/examples/SqlMiCutoverDatabaseMigration.json
            // this example is just showing the usage of "DatabaseMigrationsSqlMi_Cutover" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DatabaseMigrationSqlMIResource created on azure
            // for more information of creating DatabaseMigrationSqlMIResource, please refer to the document of DatabaseMigrationSqlMIResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "testrg";
            string managedInstanceName = "managedInstance1";
            string targetDBName = "db1";
            ResourceIdentifier databaseMigrationSqlMIResourceId = DatabaseMigrationSqlMIResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, managedInstanceName, targetDBName);
            DatabaseMigrationSqlMIResource databaseMigrationSqlMI = client.GetDatabaseMigrationSqlMIResource(databaseMigrationSqlMIResourceId);

            // invoke the operation
            MigrationOperationInput input = new MigrationOperationInput()
            {
                MigrationOperationId = Guid.Parse("4124fe90-d1b6-4b50-b4d9-46d02381f59a"),
            };
            await databaseMigrationSqlMI.CutoverAsync(WaitUntil.Completed, input);

            Console.WriteLine($"Succeeded");
        }
    }
}
