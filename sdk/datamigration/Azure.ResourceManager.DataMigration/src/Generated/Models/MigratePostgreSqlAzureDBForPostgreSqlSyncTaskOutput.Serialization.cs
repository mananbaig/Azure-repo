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
    public partial class MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput : IUtf8JsonSerializable, IModelJsonSerializable<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
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

        internal static MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput DeserializeMigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput(JsonElement element, ModelSerializerOptions options = default)
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
                    case "DatabaseLevelErrorOutput": return MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputDatabaseError.DeserializeMigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputDatabaseError(element);
                    case "DatabaseLevelOutput": return MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputDatabaseLevel.DeserializeMigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputDatabaseLevel(element);
                    case "ErrorOutput": return MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputError.DeserializeMigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputError(element);
                    case "MigrationLevelOutput": return MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputMigrationLevel.DeserializeMigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputMigrationLevel(element);
                    case "TableLevelOutput": return MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputTableLevel.DeserializeMigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputTableLevel(element);
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
            return new UnknownMigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput(id.Value, resultType, rawData);
        }

        MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput IModelJsonSerializable<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput IModelSerializable<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput"/> to convert. </param>
        public static implicit operator RequestContent(MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
