// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class DatabaseMigrationSqlDBProperties : IUtf8JsonSerializable, IModelJsonSerializable<DatabaseMigrationSqlDBProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DatabaseMigrationSqlDBProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DatabaseMigrationSqlDBProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DatabaseMigrationSqlDBProperties>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(TargetSqlConnection))
            {
                writer.WritePropertyName("targetSqlConnection"u8);
                if (TargetSqlConnection is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<SqlConnectionInformation>)TargetSqlConnection).Serialize(writer, options);
                }
            }
            if (Optional.IsCollectionDefined(TableList))
            {
                writer.WritePropertyName("tableList"u8);
                writer.WriteStartArray();
                foreach (var item in TableList)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            if (Optional.IsDefined(Scope))
            {
                writer.WritePropertyName("scope"u8);
                writer.WriteStringValue(Scope);
            }
            if (Optional.IsDefined(SourceSqlConnection))
            {
                writer.WritePropertyName("sourceSqlConnection"u8);
                if (SourceSqlConnection is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<SqlConnectionInformation>)SourceSqlConnection).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(SourceDatabaseName))
            {
                writer.WritePropertyName("sourceDatabaseName"u8);
                writer.WriteStringValue(SourceDatabaseName);
            }
            if (Optional.IsDefined(MigrationService))
            {
                writer.WritePropertyName("migrationService"u8);
                writer.WriteStringValue(MigrationService);
            }
            if (Optional.IsDefined(MigrationOperationId))
            {
                writer.WritePropertyName("migrationOperationId"u8);
                writer.WriteStringValue(MigrationOperationId);
            }
            if (Optional.IsDefined(TargetDatabaseCollation))
            {
                writer.WritePropertyName("targetDatabaseCollation"u8);
                writer.WriteStringValue(TargetDatabaseCollation);
            }
            if (Optional.IsDefined(ProvisioningError))
            {
                writer.WritePropertyName("provisioningError"u8);
                writer.WriteStringValue(ProvisioningError);
            }
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static DatabaseMigrationSqlDBProperties DeserializeDatabaseMigrationSqlDBProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SqlDBMigrationStatusDetails> migrationStatusDetails = default;
            Optional<SqlConnectionInformation> targetSqlConnection = default;
            Optional<SqlDBOfflineConfiguration> offlineConfiguration = default;
            Optional<IList<string>> tableList = default;
            ResourceType kind = default;
            Optional<string> scope = default;
            Optional<string> provisioningState = default;
            Optional<string> migrationStatus = default;
            Optional<DateTimeOffset> startedOn = default;
            Optional<DateTimeOffset> endedOn = default;
            Optional<SqlConnectionInformation> sourceSqlConnection = default;
            Optional<string> sourceDatabaseName = default;
            Optional<string> sourceServerName = default;
            Optional<string> migrationService = default;
            Optional<string> migrationOperationId = default;
            Optional<ErrorInfo> migrationFailureError = default;
            Optional<string> targetDatabaseCollation = default;
            Optional<string> provisioningError = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("migrationStatusDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    migrationStatusDetails = SqlDBMigrationStatusDetails.DeserializeSqlDBMigrationStatusDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("targetSqlConnection"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetSqlConnection = SqlConnectionInformation.DeserializeSqlConnectionInformation(property.Value);
                    continue;
                }
                if (property.NameEquals("offlineConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    offlineConfiguration = SqlDBOfflineConfiguration.DeserializeSqlDBOfflineConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("tableList"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    tableList = array;
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
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DatabaseMigrationSqlDBProperties(kind, scope.Value, provisioningState.Value, migrationStatus.Value, Optional.ToNullable(startedOn), Optional.ToNullable(endedOn), sourceSqlConnection.Value, sourceDatabaseName.Value, sourceServerName.Value, migrationService.Value, migrationOperationId.Value, migrationFailureError.Value, targetDatabaseCollation.Value, provisioningError.Value, migrationStatusDetails.Value, targetSqlConnection.Value, offlineConfiguration.Value, Optional.ToList(tableList), rawData);
        }

        DatabaseMigrationSqlDBProperties IModelJsonSerializable<DatabaseMigrationSqlDBProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DatabaseMigrationSqlDBProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDatabaseMigrationSqlDBProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DatabaseMigrationSqlDBProperties>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DatabaseMigrationSqlDBProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DatabaseMigrationSqlDBProperties IModelSerializable<DatabaseMigrationSqlDBProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DatabaseMigrationSqlDBProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDatabaseMigrationSqlDBProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DatabaseMigrationSqlDBProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DatabaseMigrationSqlDBProperties"/> to convert. </param>
        public static implicit operator RequestContent(DatabaseMigrationSqlDBProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DatabaseMigrationSqlDBProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DatabaseMigrationSqlDBProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDatabaseMigrationSqlDBProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
