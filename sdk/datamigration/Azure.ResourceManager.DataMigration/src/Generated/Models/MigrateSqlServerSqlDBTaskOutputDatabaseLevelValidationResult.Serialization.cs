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
    public partial class MigrateSqlServerSqlDBTaskOutputDatabaseLevelValidationResult : IUtf8JsonSerializable, IModelJsonSerializable<MigrateSqlServerSqlDBTaskOutputDatabaseLevelValidationResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MigrateSqlServerSqlDBTaskOutputDatabaseLevelValidationResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MigrateSqlServerSqlDBTaskOutputDatabaseLevelValidationResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MigrateSqlServerSqlDBTaskOutputDatabaseLevelValidationResult>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("resultType"u8);
            writer.WriteStringValue(ResultType);
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

        internal static MigrateSqlServerSqlDBTaskOutputDatabaseLevelValidationResult DeserializeMigrateSqlServerSqlDBTaskOutputDatabaseLevelValidationResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> migrationId = default;
            Optional<string> sourceDatabaseName = default;
            Optional<string> targetDatabaseName = default;
            Optional<DateTimeOffset> startedOn = default;
            Optional<DateTimeOffset> endedOn = default;
            Optional<DataIntegrityValidationResult> dataIntegrityValidationResult = default;
            Optional<SchemaComparisonValidationResult> schemaValidationResult = default;
            Optional<QueryAnalysisValidationResult> queryAnalysisValidationResult = default;
            Optional<ValidationStatus> status = default;
            Optional<string> id = default;
            string resultType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("migrationId"u8))
                {
                    migrationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceDatabaseName"u8))
                {
                    sourceDatabaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetDatabaseName"u8))
                {
                    targetDatabaseName = property.Value.GetString();
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
                if (property.NameEquals("dataIntegrityValidationResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataIntegrityValidationResult = DataIntegrityValidationResult.DeserializeDataIntegrityValidationResult(property.Value);
                    continue;
                }
                if (property.NameEquals("schemaValidationResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    schemaValidationResult = SchemaComparisonValidationResult.DeserializeSchemaComparisonValidationResult(property.Value);
                    continue;
                }
                if (property.NameEquals("queryAnalysisValidationResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    queryAnalysisValidationResult = QueryAnalysisValidationResult.DeserializeQueryAnalysisValidationResult(property.Value);
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new ValidationStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultType"u8))
                {
                    resultType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MigrateSqlServerSqlDBTaskOutputDatabaseLevelValidationResult(id.Value, resultType, migrationId.Value, sourceDatabaseName.Value, targetDatabaseName.Value, Optional.ToNullable(startedOn), Optional.ToNullable(endedOn), dataIntegrityValidationResult.Value, schemaValidationResult.Value, queryAnalysisValidationResult.Value, Optional.ToNullable(status), rawData);
        }

        MigrateSqlServerSqlDBTaskOutputDatabaseLevelValidationResult IModelJsonSerializable<MigrateSqlServerSqlDBTaskOutputDatabaseLevelValidationResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MigrateSqlServerSqlDBTaskOutputDatabaseLevelValidationResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMigrateSqlServerSqlDBTaskOutputDatabaseLevelValidationResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MigrateSqlServerSqlDBTaskOutputDatabaseLevelValidationResult>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MigrateSqlServerSqlDBTaskOutputDatabaseLevelValidationResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MigrateSqlServerSqlDBTaskOutputDatabaseLevelValidationResult IModelSerializable<MigrateSqlServerSqlDBTaskOutputDatabaseLevelValidationResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MigrateSqlServerSqlDBTaskOutputDatabaseLevelValidationResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMigrateSqlServerSqlDBTaskOutputDatabaseLevelValidationResult(doc.RootElement, options);
        }

        public static implicit operator RequestContent(MigrateSqlServerSqlDBTaskOutputDatabaseLevelValidationResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator MigrateSqlServerSqlDBTaskOutputDatabaseLevelValidationResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMigrateSqlServerSqlDBTaskOutputDatabaseLevelValidationResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
