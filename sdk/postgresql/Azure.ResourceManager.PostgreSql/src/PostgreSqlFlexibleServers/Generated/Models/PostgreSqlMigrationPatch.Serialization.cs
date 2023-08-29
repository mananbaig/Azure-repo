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

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    public partial class PostgreSqlMigrationPatch : IUtf8JsonSerializable, IModelJsonSerializable<PostgreSqlMigrationPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PostgreSqlMigrationPatch>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PostgreSqlMigrationPatch>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(SourceDbServerResourceId))
            {
                writer.WritePropertyName("sourceDbServerResourceId"u8);
                writer.WriteStringValue(SourceDbServerResourceId);
            }
            if (Optional.IsDefined(SourceDbServerFullyQualifiedDomainName))
            {
                writer.WritePropertyName("sourceDbServerFullyQualifiedDomainName"u8);
                writer.WriteStringValue(SourceDbServerFullyQualifiedDomainName);
            }
            if (Optional.IsDefined(TargetDbServerFullyQualifiedDomainName))
            {
                writer.WritePropertyName("targetDbServerFullyQualifiedDomainName"u8);
                writer.WriteStringValue(TargetDbServerFullyQualifiedDomainName);
            }
            if (Optional.IsDefined(SecretParameters))
            {
                writer.WritePropertyName("secretParameters"u8);
                writer.WriteObjectValue(SecretParameters);
            }
            if (Optional.IsCollectionDefined(DbsToMigrate))
            {
                writer.WritePropertyName("dbsToMigrate"u8);
                writer.WriteStartArray();
                foreach (var item in DbsToMigrate)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SetupLogicalReplicationOnSourceDbIfNeeded))
            {
                writer.WritePropertyName("setupLogicalReplicationOnSourceDbIfNeeded"u8);
                writer.WriteStringValue(SetupLogicalReplicationOnSourceDbIfNeeded.Value.ToString());
            }
            if (Optional.IsDefined(OverwriteDbsInTarget))
            {
                writer.WritePropertyName("overwriteDbsInTarget"u8);
                writer.WriteStringValue(OverwriteDbsInTarget.Value.ToString());
            }
            if (Optional.IsDefined(MigrationWindowStartTimeInUtc))
            {
                writer.WritePropertyName("migrationWindowStartTimeInUtc"u8);
                writer.WriteStringValue(MigrationWindowStartTimeInUtc.Value, "O");
            }
            if (Optional.IsDefined(StartDataMigration))
            {
                writer.WritePropertyName("startDataMigration"u8);
                writer.WriteStringValue(StartDataMigration.Value.ToString());
            }
            if (Optional.IsDefined(TriggerCutover))
            {
                writer.WritePropertyName("triggerCutover"u8);
                writer.WriteStringValue(TriggerCutover.Value.ToString());
            }
            if (Optional.IsCollectionDefined(DbsToTriggerCutoverOn))
            {
                writer.WritePropertyName("dbsToTriggerCutoverOn"u8);
                writer.WriteStartArray();
                foreach (var item in DbsToTriggerCutoverOn)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Cancel))
            {
                writer.WritePropertyName("cancel"u8);
                writer.WriteStringValue(Cancel.Value.ToString());
            }
            if (Optional.IsCollectionDefined(DbsToCancelMigrationOn))
            {
                writer.WritePropertyName("dbsToCancelMigrationOn"u8);
                writer.WriteStartArray();
                foreach (var item in DbsToCancelMigrationOn)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(MigrationMode))
            {
                writer.WritePropertyName("migrationMode"u8);
                writer.WriteStringValue(MigrationMode.Value.ToString());
            }
            writer.WriteEndObject();
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

        internal static PostgreSqlMigrationPatch DeserializePostgreSqlMigrationPatch(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            Optional<ResourceIdentifier> sourceDbServerResourceId = default;
            Optional<string> sourceDbServerFullyQualifiedDomainName = default;
            Optional<string> targetDbServerFullyQualifiedDomainName = default;
            Optional<PostgreSqlMigrationSecretParameters> secretParameters = default;
            Optional<IList<string>> dbsToMigrate = default;
            Optional<PostgreSqlMigrationLogicalReplicationOnSourceDb> setupLogicalReplicationOnSourceDbIfNeeded = default;
            Optional<PostgreSqlMigrationOverwriteDbsInTarget> overwriteDbsInTarget = default;
            Optional<DateTimeOffset> migrationWindowStartTimeInUtc = default;
            Optional<PostgreSqlMigrationStartDataMigration> startDataMigration = default;
            Optional<PostgreSqlMigrationTriggerCutover> triggerCutover = default;
            Optional<IList<string>> dbsToTriggerCutoverOn = default;
            Optional<PostgreSqlMigrationCancel> cancel = default;
            Optional<IList<string>> dbsToCancelMigrationOn = default;
            Optional<PostgreSqlMigrationMode> migrationMode = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("sourceDbServerResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sourceDbServerResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("sourceDbServerFullyQualifiedDomainName"u8))
                        {
                            sourceDbServerFullyQualifiedDomainName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("targetDbServerFullyQualifiedDomainName"u8))
                        {
                            targetDbServerFullyQualifiedDomainName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("secretParameters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            secretParameters = PostgreSqlMigrationSecretParameters.DeserializePostgreSqlMigrationSecretParameters(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("dbsToMigrate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            dbsToMigrate = array;
                            continue;
                        }
                        if (property0.NameEquals("setupLogicalReplicationOnSourceDbIfNeeded"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            setupLogicalReplicationOnSourceDbIfNeeded = new PostgreSqlMigrationLogicalReplicationOnSourceDb(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("overwriteDbsInTarget"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            overwriteDbsInTarget = new PostgreSqlMigrationOverwriteDbsInTarget(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("migrationWindowStartTimeInUtc"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            migrationWindowStartTimeInUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("startDataMigration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            startDataMigration = new PostgreSqlMigrationStartDataMigration(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("triggerCutover"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            triggerCutover = new PostgreSqlMigrationTriggerCutover(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("dbsToTriggerCutoverOn"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            dbsToTriggerCutoverOn = array;
                            continue;
                        }
                        if (property0.NameEquals("cancel"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            cancel = new PostgreSqlMigrationCancel(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("dbsToCancelMigrationOn"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            dbsToCancelMigrationOn = array;
                            continue;
                        }
                        if (property0.NameEquals("migrationMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            migrationMode = new PostgreSqlMigrationMode(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new PostgreSqlMigrationPatch(Optional.ToDictionary(tags), sourceDbServerResourceId.Value, sourceDbServerFullyQualifiedDomainName.Value, targetDbServerFullyQualifiedDomainName.Value, secretParameters.Value, Optional.ToList(dbsToMigrate), Optional.ToNullable(setupLogicalReplicationOnSourceDbIfNeeded), Optional.ToNullable(overwriteDbsInTarget), Optional.ToNullable(migrationWindowStartTimeInUtc), Optional.ToNullable(startDataMigration), Optional.ToNullable(triggerCutover), Optional.ToList(dbsToTriggerCutoverOn), Optional.ToNullable(cancel), Optional.ToList(dbsToCancelMigrationOn), Optional.ToNullable(migrationMode), rawData);
        }

        PostgreSqlMigrationPatch IModelJsonSerializable<PostgreSqlMigrationPatch>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePostgreSqlMigrationPatch(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PostgreSqlMigrationPatch>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PostgreSqlMigrationPatch IModelSerializable<PostgreSqlMigrationPatch>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePostgreSqlMigrationPatch(doc.RootElement, options);
        }

        public static implicit operator RequestContent(PostgreSqlMigrationPatch model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator PostgreSqlMigrationPatch(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePostgreSqlMigrationPatch(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
