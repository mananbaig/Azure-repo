// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class DatabaseMigrationSqlMIProperties : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(BackupConfiguration))
            {
                writer.WritePropertyName("backupConfiguration"u8);
                writer.WriteObjectValue(BackupConfiguration);
            }
            if (Core.Optional.IsDefined(OfflineConfiguration))
            {
                writer.WritePropertyName("offlineConfiguration"u8);
                writer.WriteObjectValue(OfflineConfiguration);
            }
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            if (Core.Optional.IsDefined(Scope))
            {
                writer.WritePropertyName("scope"u8);
                writer.WriteStringValue(Scope);
            }
            if (Core.Optional.IsDefined(SourceSqlConnection))
            {
                writer.WritePropertyName("sourceSqlConnection"u8);
                writer.WriteObjectValue(SourceSqlConnection);
            }
            if (Core.Optional.IsDefined(SourceDatabaseName))
            {
                writer.WritePropertyName("sourceDatabaseName"u8);
                writer.WriteStringValue(SourceDatabaseName);
            }
            if (Core.Optional.IsDefined(MigrationService))
            {
                writer.WritePropertyName("migrationService"u8);
                writer.WriteStringValue(MigrationService);
            }
            if (Core.Optional.IsDefined(MigrationOperationId))
            {
                writer.WritePropertyName("migrationOperationId"u8);
                writer.WriteStringValue(MigrationOperationId);
            }
            if (Core.Optional.IsDefined(TargetDatabaseCollation))
            {
                writer.WritePropertyName("targetDatabaseCollation"u8);
                writer.WriteStringValue(TargetDatabaseCollation);
            }
            if (Core.Optional.IsDefined(ProvisioningError))
            {
                writer.WritePropertyName("provisioningError"u8);
                writer.WriteStringValue(ProvisioningError);
            }
            writer.WriteEndObject();
        }

        internal static DatabaseMigrationSqlMIProperties DeserializeDatabaseMigrationSqlMIProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<MigrationStatusDetails> migrationStatusDetails = default;
            Core.Optional<BackupConfiguration> backupConfiguration = default;
            Core.Optional<OfflineConfiguration> offlineConfiguration = default;
            ResourceType kind = default;
            Core.Optional<string> scope = default;
            Core.Optional<string> provisioningState = default;
            Core.Optional<string> migrationStatus = default;
            Core.Optional<DateTimeOffset> startedOn = default;
            Core.Optional<DateTimeOffset> endedOn = default;
            Core.Optional<SqlConnectionInformation> sourceSqlConnection = default;
            Core.Optional<string> sourceDatabaseName = default;
            Core.Optional<string> sourceServerName = default;
            Core.Optional<string> migrationService = default;
            Core.Optional<string> migrationOperationId = default;
            Core.Optional<ErrorInfo> migrationFailureError = default;
            Core.Optional<string> targetDatabaseCollation = default;
            Core.Optional<string> provisioningError = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("migrationStatusDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    migrationStatusDetails = MigrationStatusDetails.DeserializeMigrationStatusDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("backupConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupConfiguration = BackupConfiguration.DeserializeBackupConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("offlineConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    offlineConfiguration = OfflineConfiguration.DeserializeOfflineConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("scope"u8))
                {
                    scope = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    provisioningState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("migrationStatus"u8))
                {
                    migrationStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startedOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startedOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endedOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endedOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("sourceSqlConnection"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceSqlConnection = SqlConnectionInformation.DeserializeSqlConnectionInformation(property.Value);
                    continue;
                }
                if (property.NameEquals("sourceDatabaseName"u8))
                {
                    sourceDatabaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceServerName"u8))
                {
                    sourceServerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("migrationService"u8))
                {
                    migrationService = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("migrationOperationId"u8))
                {
                    migrationOperationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("migrationFailureError"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    migrationFailureError = ErrorInfo.DeserializeErrorInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("targetDatabaseCollation"u8))
                {
                    targetDatabaseCollation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningError"u8))
                {
                    provisioningError = property.Value.GetString();
                    continue;
                }
            }
            return new DatabaseMigrationSqlMIProperties(kind, scope.Value, provisioningState.Value, migrationStatus.Value, Core.Optional.ToNullable(startedOn), Core.Optional.ToNullable(endedOn), sourceSqlConnection.Value, sourceDatabaseName.Value, sourceServerName.Value, migrationService.Value, migrationOperationId.Value, migrationFailureError.Value, targetDatabaseCollation.Value, provisioningError.Value, migrationStatusDetails.Value, backupConfiguration.Value, offlineConfiguration.Value);
        }
    }
}
