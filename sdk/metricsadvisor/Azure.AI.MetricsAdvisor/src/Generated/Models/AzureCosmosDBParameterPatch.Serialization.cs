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

namespace Azure.AI.MetricsAdvisor.Models
{
    internal partial class AzureCosmosDBParameterPatch : IUtf8JsonSerializable, IModelJsonSerializable<AzureCosmosDBParameterPatch>
    {
        void IModelJsonSerializable<AzureCosmosDBParameterPatch>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ConnectionString))
            {
                writer.WritePropertyName("connectionString"u8);
                writer.WriteStringValue(ConnectionString);
            }
            if (Optional.IsDefined(SqlQuery))
            {
                writer.WritePropertyName("sqlQuery"u8);
                writer.WriteStringValue(SqlQuery);
            }
            if (Optional.IsDefined(Database))
            {
                writer.WritePropertyName("database"u8);
                writer.WriteStringValue(Database);
            }
            if (Optional.IsDefined(CollectionId))
            {
                writer.WritePropertyName("collectionId"u8);
                writer.WriteStringValue(CollectionId);
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

        internal static AzureCosmosDBParameterPatch DeserializeAzureCosmosDBParameterPatch(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> connectionString = default;
            Optional<string> sqlQuery = default;
            Optional<string> database = default;
            Optional<string> collectionId = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("connectionString"u8))
                {
                    connectionString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sqlQuery"u8))
                {
                    sqlQuery = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("database"u8))
                {
                    database = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("collectionId"u8))
                {
                    collectionId = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AzureCosmosDBParameterPatch(connectionString.Value, sqlQuery.Value, database.Value, collectionId.Value, rawData);
        }

        AzureCosmosDBParameterPatch IModelJsonSerializable<AzureCosmosDBParameterPatch>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureCosmosDBParameterPatch(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AzureCosmosDBParameterPatch>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AzureCosmosDBParameterPatch IModelSerializable<AzureCosmosDBParameterPatch>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAzureCosmosDBParameterPatch(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AzureCosmosDBParameterPatch"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AzureCosmosDBParameterPatch"/> to convert. </param>
        public static implicit operator RequestContent(AzureCosmosDBParameterPatch model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AzureCosmosDBParameterPatch"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AzureCosmosDBParameterPatch(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAzureCosmosDBParameterPatch(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
