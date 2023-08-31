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
    public partial class MigrateSqlServerSqlDBTaskOutputMigrationLevel : IUtf8JsonSerializable, IModelJsonSerializable<MigrateSqlServerSqlDBTaskOutputMigrationLevel>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MigrateSqlServerSqlDBTaskOutputMigrationLevel>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MigrateSqlServerSqlDBTaskOutputMigrationLevel>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MigrateSqlServerSqlDBTaskOutputMigrationLevel>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(MigrationValidationResult))
            {
                writer.WritePropertyName("migrationValidationResult"u8);
                if (MigrationValidationResult is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<MigrationValidationResult>)MigrationValidationResult).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(MigrationReportResult))
            {
                writer.WritePropertyName("migrationReportResult"u8);
                if (MigrationReportResult is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<MigrationReportResult>)MigrationReportResult).Serialize(writer, options);
                }
            }
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

        internal static MigrateSqlServerSqlDBTaskOutputMigrationLevel DeserializeMigrateSqlServerSqlDBTaskOutputMigrationLevel(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset> startedOn = default;
            Optional<DateTimeOffset> endedOn = default;
            Optional<long> durationInSeconds = default;
            Optional<MigrationStatus> status = default;
            Optional<string> statusMessage = default;
            Optional<string> message = default;
            Optional<string> databases = default;
            Optional<string> databaseSummary = default;
            Optional<MigrationValidationResult> migrationValidationResult = default;
            Optional<MigrationReportResult> migrationReportResult = default;
            Optional<string> sourceServerVersion = default;
            Optional<string> sourceServerBrandVersion = default;
            Optional<string> targetServerVersion = default;
            Optional<string> targetServerBrandVersion = default;
            Optional<IReadOnlyList<ReportableException>> exceptionsAndWarnings = default;
            Optional<string> id = default;
            string resultType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                if (property.NameEquals("durationInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    durationInSeconds = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new MigrationStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("statusMessage"u8))
                {
                    statusMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("databases"u8))
                {
                    databases = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("databaseSummary"u8))
                {
                    databaseSummary = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("migrationValidationResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    migrationValidationResult = MigrationValidationResult.DeserializeMigrationValidationResult(property.Value);
                    continue;
                }
                if (property.NameEquals("migrationReportResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    migrationReportResult = MigrationReportResult.DeserializeMigrationReportResult(property.Value);
                    continue;
                }
                if (property.NameEquals("sourceServerVersion"u8))
                {
                    sourceServerVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceServerBrandVersion"u8))
                {
                    sourceServerBrandVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetServerVersion"u8))
                {
                    targetServerVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetServerBrandVersion"u8))
                {
                    targetServerBrandVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("exceptionsAndWarnings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ReportableException> array = new List<ReportableException>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReportableException.DeserializeReportableException(item));
                    }
                    exceptionsAndWarnings = array;
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
            return new MigrateSqlServerSqlDBTaskOutputMigrationLevel(id.Value, resultType, Optional.ToNullable(startedOn), Optional.ToNullable(endedOn), Optional.ToNullable(durationInSeconds), Optional.ToNullable(status), statusMessage.Value, message.Value, databases.Value, databaseSummary.Value, migrationValidationResult.Value, migrationReportResult.Value, sourceServerVersion.Value, sourceServerBrandVersion.Value, targetServerVersion.Value, targetServerBrandVersion.Value, Optional.ToList(exceptionsAndWarnings), rawData);
        }

        MigrateSqlServerSqlDBTaskOutputMigrationLevel IModelJsonSerializable<MigrateSqlServerSqlDBTaskOutputMigrationLevel>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MigrateSqlServerSqlDBTaskOutputMigrationLevel>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMigrateSqlServerSqlDBTaskOutputMigrationLevel(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MigrateSqlServerSqlDBTaskOutputMigrationLevel>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MigrateSqlServerSqlDBTaskOutputMigrationLevel>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MigrateSqlServerSqlDBTaskOutputMigrationLevel IModelSerializable<MigrateSqlServerSqlDBTaskOutputMigrationLevel>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MigrateSqlServerSqlDBTaskOutputMigrationLevel>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMigrateSqlServerSqlDBTaskOutputMigrationLevel(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MigrateSqlServerSqlDBTaskOutputMigrationLevel"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MigrateSqlServerSqlDBTaskOutputMigrationLevel"/> to convert. </param>
        public static implicit operator RequestContent(MigrateSqlServerSqlDBTaskOutputMigrationLevel model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MigrateSqlServerSqlDBTaskOutputMigrationLevel"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MigrateSqlServerSqlDBTaskOutputMigrationLevel(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMigrateSqlServerSqlDBTaskOutputMigrationLevel(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
