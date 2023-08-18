// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class ProjectTaskProperties : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("taskType"u8);
            writer.WriteStringValue(TaskType.ToString());
            if (Core.Optional.IsCollectionDefined(ClientData))
            {
                writer.WritePropertyName("clientData"u8);
                writer.WriteStartObject();
                foreach (var item in ClientData)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }

        internal static ProjectTaskProperties DeserializeProjectTaskProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("taskType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Connect.MongoDb": return ConnectToMongoDBTaskProperties.DeserializeConnectToMongoDBTaskProperties(element);
                    case "ConnectToSource.MySql": return ConnectToSourceMySqlTaskProperties.DeserializeConnectToSourceMySqlTaskProperties(element);
                    case "ConnectToSource.Oracle.Sync": return ConnectToSourceOracleSyncTaskProperties.DeserializeConnectToSourceOracleSyncTaskProperties(element);
                    case "ConnectToSource.PostgreSql.Sync": return ConnectToSourcePostgreSqlSyncTaskProperties.DeserializeConnectToSourcePostgreSqlSyncTaskProperties(element);
                    case "ConnectToSource.SqlServer": return ConnectToSourceSqlServerTaskProperties.DeserializeConnectToSourceSqlServerTaskProperties(element);
                    case "ConnectToSource.SqlServer.Sync": return ConnectToSourceSqlServerSyncTaskProperties.DeserializeConnectToSourceSqlServerSyncTaskProperties(element);
                    case "ConnectToTarget.AzureDbForMySql": return ConnectToTargetAzureDBForMySqlTaskProperties.DeserializeConnectToTargetAzureDBForMySqlTaskProperties(element);
                    case "ConnectToTarget.AzureDbForPostgreSql.Sync": return ConnectToTargetAzureDBForPostgreSqlSyncTaskProperties.DeserializeConnectToTargetAzureDBForPostgreSqlSyncTaskProperties(element);
                    case "ConnectToTarget.AzureSqlDbMI": return ConnectToTargetSqlMITaskProperties.DeserializeConnectToTargetSqlMITaskProperties(element);
                    case "ConnectToTarget.AzureSqlDbMI.Sync.LRS": return ConnectToTargetSqlMISyncTaskProperties.DeserializeConnectToTargetSqlMISyncTaskProperties(element);
                    case "ConnectToTarget.Oracle.AzureDbForPostgreSql.Sync": return ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskProperties.DeserializeConnectToTargetOracleAzureDBForPostgreSqlSyncTaskProperties(element);
                    case "ConnectToTarget.SqlDb": return ConnectToTargetSqlDBTaskProperties.DeserializeConnectToTargetSqlDBTaskProperties(element);
                    case "ConnectToTarget.SqlDb.Sync": return ConnectToTargetSqlDBSyncTaskProperties.DeserializeConnectToTargetSqlDBSyncTaskProperties(element);
                    case "GetTDECertificates.Sql": return GetTdeCertificatesSqlTaskProperties.DeserializeGetTdeCertificatesSqlTaskProperties(element);
                    case "GetUserTables.AzureSqlDb.Sync": return GetUserTablesSqlSyncTaskProperties.DeserializeGetUserTablesSqlSyncTaskProperties(element);
                    case "GetUserTables.Sql": return GetUserTablesSqlTaskProperties.DeserializeGetUserTablesSqlTaskProperties(element);
                    case "GetUserTablesMySql": return GetUserTablesMySqlTaskProperties.DeserializeGetUserTablesMySqlTaskProperties(element);
                    case "GetUserTablesOracle": return GetUserTablesOracleTaskProperties.DeserializeGetUserTablesOracleTaskProperties(element);
                    case "GetUserTablesPostgreSql": return GetUserTablesPostgreSqlTaskProperties.DeserializeGetUserTablesPostgreSqlTaskProperties(element);
                    case "Migrate.MongoDb": return MigrateMongoDBTaskProperties.DeserializeMigrateMongoDBTaskProperties(element);
                    case "Migrate.MySql.AzureDbForMySql": return MigrateMySqlAzureDBForMySqlOfflineTaskProperties.DeserializeMigrateMySqlAzureDBForMySqlOfflineTaskProperties(element);
                    case "Migrate.MySql.AzureDbForMySql.Sync": return MigrateMySqlAzureDBForMySqlSyncTaskProperties.DeserializeMigrateMySqlAzureDBForMySqlSyncTaskProperties(element);
                    case "Migrate.Oracle.AzureDbForPostgreSql.Sync": return MigrateOracleAzureDBForPostgreSqlSyncTaskProperties.DeserializeMigrateOracleAzureDBForPostgreSqlSyncTaskProperties(element);
                    case "Migrate.PostgreSql.AzureDbForPostgreSql.SyncV2": return MigratePostgreSqlAzureDBForPostgreSqlSyncTaskProperties.DeserializeMigratePostgreSqlAzureDBForPostgreSqlSyncTaskProperties(element);
                    case "Migrate.SqlServer.AzureSqlDb.Sync": return MigrateSqlServerSqlDBSyncTaskProperties.DeserializeMigrateSqlServerSqlDBSyncTaskProperties(element);
                    case "Migrate.SqlServer.AzureSqlDbMI": return MigrateSqlServerSqlMITaskProperties.DeserializeMigrateSqlServerSqlMITaskProperties(element);
                    case "Migrate.SqlServer.AzureSqlDbMI.Sync.LRS": return MigrateSqlServerSqlMISyncTaskProperties.DeserializeMigrateSqlServerSqlMISyncTaskProperties(element);
                    case "Migrate.SqlServer.SqlDb": return MigrateSqlServerSqlDBTaskProperties.DeserializeMigrateSqlServerSqlDBTaskProperties(element);
                    case "Migrate.Ssis": return MigrateSsisTaskProperties.DeserializeMigrateSsisTaskProperties(element);
                    case "MigrateSchemaSqlServerSqlDb": return MigrateSchemaSqlServerSqlDBTaskProperties.DeserializeMigrateSchemaSqlServerSqlDBTaskProperties(element);
                    case "Service.Check.OCI": return CheckOciDriverTaskProperties.DeserializeCheckOciDriverTaskProperties(element);
                    case "Service.Install.OCI": return InstallOciDriverTaskProperties.DeserializeInstallOciDriverTaskProperties(element);
                    case "Service.Upload.OCI": return UploadOciDriverTaskProperties.DeserializeUploadOciDriverTaskProperties(element);
                    case "Validate.MongoDb": return ValidateMongoDBTaskProperties.DeserializeValidateMongoDBTaskProperties(element);
                    case "Validate.Oracle.AzureDbPostgreSql.Sync": return ValidateOracleAzureDBForPostgreSqlSyncTaskProperties.DeserializeValidateOracleAzureDBForPostgreSqlSyncTaskProperties(element);
                    case "ValidateMigrationInput.SqlServer.AzureSqlDbMI": return ValidateMigrationInputSqlServerSqlMITaskProperties.DeserializeValidateMigrationInputSqlServerSqlMITaskProperties(element);
                    case "ValidateMigrationInput.SqlServer.AzureSqlDbMI.Sync.LRS": return ValidateMigrationInputSqlServerSqlMISyncTaskProperties.DeserializeValidateMigrationInputSqlServerSqlMISyncTaskProperties(element);
                    case "ValidateMigrationInput.SqlServer.SqlDb.Sync": return ValidateMigrationInputSqlServerSqlDBSyncTaskProperties.DeserializeValidateMigrationInputSqlServerSqlDBSyncTaskProperties(element);
                }
            }
            return UnknownProjectTaskProperties.DeserializeUnknownProjectTaskProperties(element);
        }
    }
}
