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
    public partial class MigrationValidationDatabaseSummaryResult : IUtf8JsonSerializable, IModelJsonSerializable<MigrationValidationDatabaseSummaryResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MigrationValidationDatabaseSummaryResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MigrationValidationDatabaseSummaryResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
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

        internal static MigrationValidationDatabaseSummaryResult DeserializeMigrationValidationDatabaseSummaryResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<string> migrationId = default;
            Optional<string> sourceDatabaseName = default;
            Optional<string> targetDatabaseName = default;
            Optional<DateTimeOffset> startedOn = default;
            Optional<DateTimeOffset> endedOn = default;
            Optional<ValidationStatus> status = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
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
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new ValidationStatus(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MigrationValidationDatabaseSummaryResult(id.Value, migrationId.Value, sourceDatabaseName.Value, targetDatabaseName.Value, Optional.ToNullable(startedOn), Optional.ToNullable(endedOn), Optional.ToNullable(status), rawData);
        }

        MigrationValidationDatabaseSummaryResult IModelJsonSerializable<MigrationValidationDatabaseSummaryResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMigrationValidationDatabaseSummaryResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MigrationValidationDatabaseSummaryResult>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MigrationValidationDatabaseSummaryResult IModelSerializable<MigrationValidationDatabaseSummaryResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMigrationValidationDatabaseSummaryResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MigrationValidationDatabaseSummaryResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MigrationValidationDatabaseSummaryResult"/> to convert. </param>
        public static implicit operator RequestContent(MigrationValidationDatabaseSummaryResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MigrationValidationDatabaseSummaryResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MigrationValidationDatabaseSummaryResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMigrationValidationDatabaseSummaryResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
