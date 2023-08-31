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
    public partial class MigrateMySqlAzureDBForMySqlOfflineTaskOutput : IUtf8JsonSerializable, IModelJsonSerializable<MigrateMySqlAzureDBForMySqlOfflineTaskOutput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MigrateMySqlAzureDBForMySqlOfflineTaskOutput>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MigrateMySqlAzureDBForMySqlOfflineTaskOutput>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
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

        internal static MigrateMySqlAzureDBForMySqlOfflineTaskOutput DeserializeMigrateMySqlAzureDBForMySqlOfflineTaskOutput(JsonElement element, ModelSerializerOptions options = default)
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
                    case "DatabaseLevelOutput": return MigrateMySqlAzureDBForMySqlOfflineTaskOutputDatabaseLevel.DeserializeMigrateMySqlAzureDBForMySqlOfflineTaskOutputDatabaseLevel(element);
                    case "ErrorOutput": return MigrateMySqlAzureDBForMySqlOfflineTaskOutputError.DeserializeMigrateMySqlAzureDBForMySqlOfflineTaskOutputError(element);
                    case "MigrationLevelOutput": return MigrateMySqlAzureDBForMySqlOfflineTaskOutputMigrationLevel.DeserializeMigrateMySqlAzureDBForMySqlOfflineTaskOutputMigrationLevel(element);
                    case "TableLevelOutput": return MigrateMySqlAzureDBForMySqlOfflineTaskOutputTableLevel.DeserializeMigrateMySqlAzureDBForMySqlOfflineTaskOutputTableLevel(element);
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
            return new UnknownMigrateMySqlAzureDBForMySqlOfflineTaskOutput(id.Value, resultType, rawData);
        }

        MigrateMySqlAzureDBForMySqlOfflineTaskOutput IModelJsonSerializable<MigrateMySqlAzureDBForMySqlOfflineTaskOutput>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMigrateMySqlAzureDBForMySqlOfflineTaskOutput(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MigrateMySqlAzureDBForMySqlOfflineTaskOutput>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MigrateMySqlAzureDBForMySqlOfflineTaskOutput IModelSerializable<MigrateMySqlAzureDBForMySqlOfflineTaskOutput>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMigrateMySqlAzureDBForMySqlOfflineTaskOutput(doc.RootElement, options);
        }

        public static implicit operator RequestContent(MigrateMySqlAzureDBForMySqlOfflineTaskOutput model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator MigrateMySqlAzureDBForMySqlOfflineTaskOutput(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMigrateMySqlAzureDBForMySqlOfflineTaskOutput(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
