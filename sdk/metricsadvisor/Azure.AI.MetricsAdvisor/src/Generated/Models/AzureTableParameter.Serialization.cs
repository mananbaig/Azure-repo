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
    internal partial class AzureTableParameter : IUtf8JsonSerializable, IModelJsonSerializable<AzureTableParameter>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AzureTableParameter>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AzureTableParameter>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ConnectionString))
            {
                if (ConnectionString != null)
                {
                    writer.WritePropertyName("connectionString"u8);
                    writer.WriteStringValue(ConnectionString);
                }
                else
                {
                    writer.WriteNull("connectionString");
                }
            }
            if (Table != null)
            {
                writer.WritePropertyName("table"u8);
                writer.WriteStringValue(Table);
            }
            else
            {
                writer.WriteNull("table");
            }
            if (Query != null)
            {
                writer.WritePropertyName("query"u8);
                writer.WriteStringValue(Query);
            }
            else
            {
                writer.WriteNull("query");
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

        internal static AzureTableParameter DeserializeAzureTableParameter(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> connectionString = default;
            string table = default;
            string query = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("connectionString"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        connectionString = null;
                        continue;
                    }
                    connectionString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("table"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        table = null;
                        continue;
                    }
                    table = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("query"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        query = null;
                        continue;
                    }
                    query = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AzureTableParameter(connectionString.Value, table, query, rawData);
        }

        AzureTableParameter IModelJsonSerializable<AzureTableParameter>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureTableParameter(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AzureTableParameter>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AzureTableParameter IModelSerializable<AzureTableParameter>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAzureTableParameter(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AzureTableParameter"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AzureTableParameter"/> to convert. </param>
        public static implicit operator RequestContent(AzureTableParameter model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AzureTableParameter"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AzureTableParameter(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAzureTableParameter(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
