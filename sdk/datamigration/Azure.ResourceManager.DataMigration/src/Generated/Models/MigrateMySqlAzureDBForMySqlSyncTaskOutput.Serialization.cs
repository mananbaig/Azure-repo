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
    public partial class MigrateMySqlAzureDBForMySqlSyncTaskOutput : IUtf8JsonSerializable, IModelJsonSerializable<MigrateMySqlAzureDBForMySqlSyncTaskOutput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MigrateMySqlAzureDBForMySqlSyncTaskOutput>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MigrateMySqlAzureDBForMySqlSyncTaskOutput>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

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

        internal static MigrateMySqlAzureDBForMySqlSyncTaskOutput DeserializeMigrateMySqlAzureDBForMySqlSyncTaskOutput(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("resultType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "DatabaseLevelErrorOutput": return MigrateMySqlAzureDBForMySqlSyncTaskOutputDatabaseError.DeserializeMigrateMySqlAzureDBForMySqlSyncTaskOutputDatabaseError(element);
                    case "DatabaseLevelOutput": return MigrateMySqlAzureDBForMySqlSyncTaskOutputDatabaseLevel.DeserializeMigrateMySqlAzureDBForMySqlSyncTaskOutputDatabaseLevel(element);
                    case "ErrorOutput": return MigrateMySqlAzureDBForMySqlSyncTaskOutputError.DeserializeMigrateMySqlAzureDBForMySqlSyncTaskOutputError(element);
                    case "MigrationLevelOutput": return MigrateMySqlAzureDBForMySqlSyncTaskOutputMigrationLevel.DeserializeMigrateMySqlAzureDBForMySqlSyncTaskOutputMigrationLevel(element);
                    case "TableLevelOutput": return MigrateMySqlAzureDBForMySqlSyncTaskOutputTableLevel.DeserializeMigrateMySqlAzureDBForMySqlSyncTaskOutputTableLevel(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            Optional<string> id = default;
            string resultType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
            return new UnknownMigrateMySqlAzureDBForMySqlSyncTaskOutput(id.Value, resultType, rawData);
        }

        MigrateMySqlAzureDBForMySqlSyncTaskOutput IModelJsonSerializable<MigrateMySqlAzureDBForMySqlSyncTaskOutput>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMigrateMySqlAzureDBForMySqlSyncTaskOutput(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MigrateMySqlAzureDBForMySqlSyncTaskOutput>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MigrateMySqlAzureDBForMySqlSyncTaskOutput IModelSerializable<MigrateMySqlAzureDBForMySqlSyncTaskOutput>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMigrateMySqlAzureDBForMySqlSyncTaskOutput(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MigrateMySqlAzureDBForMySqlSyncTaskOutput"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MigrateMySqlAzureDBForMySqlSyncTaskOutput"/> to convert. </param>
        public static implicit operator RequestContent(MigrateMySqlAzureDBForMySqlSyncTaskOutput model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MigrateMySqlAzureDBForMySqlSyncTaskOutput"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MigrateMySqlAzureDBForMySqlSyncTaskOutput(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMigrateMySqlAzureDBForMySqlSyncTaskOutput(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
