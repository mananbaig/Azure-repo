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
    public partial class Sample_DatabaseMigrationSqlVmResource
    {
        // Get Sql VM database Migration with the expand parameter.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetSqlVMDatabaseMigrationWithTheExpandParameter()
        {
            // Generated from example definition: specification/datamigration/resource-manager/Microsoft.DataMigration/preview/2022-03-30-preview/examples/SqlVmGetDatabaseMigrationExpanded.json
            // this example is just showing the usage of "DatabaseMigrationsSqlVm_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DatabaseMigrationSqlVmResource created on azure
            // for more information of creating DatabaseMigrationSqlVmResource, please refer to the document of DatabaseMigrationSqlVmResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "testrg";
            string sqlVirtualMachineName = "testvm";
            string targetDBName = "db1";
            ResourceIdentifier databaseMigrationSqlVmResourceId = DatabaseMigrationSqlVmResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, sqlVirtualMachineName, targetDBName);
            DatabaseMigrationSqlVmResource databaseMigrationSqlVm = client.GetDatabaseMigrationSqlVmResource(databaseMigrationSqlVmResourceId);

            // invoke the operation
            string expand = "MigrationStatusDetails";
            DatabaseMigrationSqlVmResource result = await databaseMigrationSqlVm.GetAsync(expand: expand);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DatabaseMigrationSqlVmData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get Sql VM database Migration without the expand parameter.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetSqlVMDatabaseMigrationWithoutTheExpandParameter()
        {
            // Generated from example definition: specification/datamigration/resource-manager/Microsoft.DataMigration/preview/2022-03-30-preview/examples/SqlVmGetDatabaseMigration.json
            // this example is just showing the usage of "DatabaseMigrationsSqlVm_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DatabaseMigrationSqlVmResource created on azure
            // for more information of creating DatabaseMigrationSqlVmResource, please refer to the document of DatabaseMigrationSqlVmResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "testrg";
            string sqlVirtualMachineName = "testvm";
            string targetDBName = "db1";
            ResourceIdentifier databaseMigrationSqlVmResourceId = DatabaseMigrationSqlVmResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, sqlVirtualMachineName, targetDBName);
            DatabaseMigrationSqlVmResource databaseMigrationSqlVm = client.GetDatabaseMigrationSqlVmResource(databaseMigrationSqlVmResourceId);

            // invoke the operation
            DatabaseMigrationSqlVmResource result = await databaseMigrationSqlVm.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DatabaseMigrationSqlVmData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create or Update Database Migration resource with Maximum parameters.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreateOrUpdateDatabaseMigrationResourceWithMaximumParameters()
        {
            // Generated from example definition: specification/datamigration/resource-manager/Microsoft.DataMigration/preview/2022-03-30-preview/examples/SqlVmCreateOrUpdateDatabaseMigrationMAX.json
            // this example is just showing the usage of "DatabaseMigrationsSqlVm_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DatabaseMigrationSqlVmResource created on azure
            // for more information of creating DatabaseMigrationSqlVmResource, please refer to the document of DatabaseMigrationSqlVmResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "testrg";
            string sqlVirtualMachineName = "testvm";
            string targetDBName = "db1";
            ResourceIdentifier databaseMigrationSqlVmResourceId = DatabaseMigrationSqlVmResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, sqlVirtualMachineName, targetDBName);
            DatabaseMigrationSqlVmResource databaseMigrationSqlVm = client.GetDatabaseMigrationSqlVmResource(databaseMigrationSqlVmResourceId);

            // invoke the operation
            DatabaseMigrationSqlVmData data = new DatabaseMigrationSqlVmData()
            {
                Properties = new DatabaseMigrationSqlVmProperties()
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
                    Scope = "/subscriptions/00000000-1111-2222-3333-444444444444/resourceGroups/testrg/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachines/testvm",
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
            ArmOperation<DatabaseMigrationSqlVmResource> lro = await databaseMigrationSqlVm.UpdateAsync(WaitUntil.Completed, data);
            DatabaseMigrationSqlVmResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DatabaseMigrationSqlVmData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create or Update Database Migration resource with Minimum parameters.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreateOrUpdateDatabaseMigrationResourceWithMinimumParameters()
        {
            // Generated from example definition: specification/datamigration/resource-manager/Microsoft.DataMigration/preview/2022-03-30-preview/examples/SqlVmCreateOrUpdateDatabaseMigrationMIN.json
            // this example is just showing the usage of "DatabaseMigrationsSqlVm_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DatabaseMigrationSqlVmResource created on azure
            // for more information of creating DatabaseMigrationSqlVmResource, please refer to the document of DatabaseMigrationSqlVmResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "testrg";
            string sqlVirtualMachineName = "testvm";
            string targetDBName = "db1";
            ResourceIdentifier databaseMigrationSqlVmResourceId = DatabaseMigrationSqlVmResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, sqlVirtualMachineName, targetDBName);
            DatabaseMigrationSqlVmResource databaseMigrationSqlVm = client.GetDatabaseMigrationSqlVmResource(databaseMigrationSqlVmResourceId);

            // invoke the operation
            DatabaseMigrationSqlVmData data = new DatabaseMigrationSqlVmData()
            {
                Properties = new DatabaseMigrationSqlVmProperties()
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
                    Scope = "/subscriptions/00000000-1111-2222-3333-444444444444/resourceGroups/testrg/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachines/testvm",
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
            ArmOperation<DatabaseMigrationSqlVmResource> lro = await databaseMigrationSqlVm.UpdateAsync(WaitUntil.Completed, data);
            DatabaseMigrationSqlVmResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DatabaseMigrationSqlVmData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Stop ongoing migration for the database.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Cancel_StopOngoingMigrationForTheDatabase()
        {
            // Generated from example definition: specification/datamigration/resource-manager/Microsoft.DataMigration/preview/2022-03-30-preview/examples/SqlVmCancelDatabaseMigration.json
            // this example is just showing the usage of "DatabaseMigrationsSqlVm_Cancel" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DatabaseMigrationSqlVmResource created on azure
            // for more information of creating DatabaseMigrationSqlVmResource, please refer to the document of DatabaseMigrationSqlVmResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "testrg";
            string sqlVirtualMachineName = "testvm";
            string targetDBName = "db1";
            ResourceIdentifier databaseMigrationSqlVmResourceId = DatabaseMigrationSqlVmResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, sqlVirtualMachineName, targetDBName);
            DatabaseMigrationSqlVmResource databaseMigrationSqlVm = client.GetDatabaseMigrationSqlVmResource(databaseMigrationSqlVmResourceId);

            // invoke the operation
            MigrationOperationInput input = new MigrationOperationInput()
            {
                MigrationOperationId = Guid.Parse("4124fe90-d1b6-4b50-b4d9-46d02381f59a"),
            };
            await databaseMigrationSqlVm.CancelAsync(WaitUntil.Completed, input);

            Console.WriteLine($"Succeeded");
        }

        // Cutover online migration operation for the database.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Cutover_CutoverOnlineMigrationOperationForTheDatabase()
        {
            // Generated from example definition: specification/datamigration/resource-manager/Microsoft.DataMigration/preview/2022-03-30-preview/examples/SqlVmCutoverDatabaseMigration.json
            // this example is just showing the usage of "DatabaseMigrationsSqlVm_Cutover" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DatabaseMigrationSqlVmResource created on azure
            // for more information of creating DatabaseMigrationSqlVmResource, please refer to the document of DatabaseMigrationSqlVmResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "testrg";
            string sqlVirtualMachineName = "testvm";
            string targetDBName = "db1";
            ResourceIdentifier databaseMigrationSqlVmResourceId = DatabaseMigrationSqlVmResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, sqlVirtualMachineName, targetDBName);
            DatabaseMigrationSqlVmResource databaseMigrationSqlVm = client.GetDatabaseMigrationSqlVmResource(databaseMigrationSqlVmResourceId);

            // invoke the operation
            MigrationOperationInput input = new MigrationOperationInput()
            {
                MigrationOperationId = Guid.Parse("4124fe90-d1b6-4b50-b4d9-46d02381f59a"),
            };
            await databaseMigrationSqlVm.CutoverAsync(WaitUntil.Completed, input);

            Console.WriteLine($"Succeeded");
        }
    }
}
