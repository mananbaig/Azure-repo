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

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class DataTransferDataSourceSink : IUtf8JsonSerializable, IModelJsonSerializable<DataTransferDataSourceSink>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DataTransferDataSourceSink>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DataTransferDataSourceSink>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("component"u8);
            writer.WriteStringValue(Component.ToString());
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

        internal static DataTransferDataSourceSink DeserializeDataTransferDataSourceSink(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("component", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureBlobStorage": return AzureBlobDataTransferDataSourceSink.DeserializeAzureBlobDataTransferDataSourceSink(element);
                    case "CosmosDBCassandra": return CosmosCassandraDataTransferDataSourceSink.DeserializeCosmosCassandraDataTransferDataSourceSink(element);
                    case "CosmosDBMongo": return CosmosMongoDataTransferDataSourceSink.DeserializeCosmosMongoDataTransferDataSourceSink(element);
                    case "CosmosDBSql": return CosmosSqlDataTransferDataSourceSink.DeserializeCosmosSqlDataTransferDataSourceSink(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            DataTransferComponent component = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("component"u8))
                {
                    component = new DataTransferComponent(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new UnknownDataTransferDataSourceSink(component, rawData);
        }

        DataTransferDataSourceSink IModelJsonSerializable<DataTransferDataSourceSink>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDataTransferDataSourceSink(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DataTransferDataSourceSink>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DataTransferDataSourceSink IModelSerializable<DataTransferDataSourceSink>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDataTransferDataSourceSink(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DataTransferDataSourceSink"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DataTransferDataSourceSink"/> to convert. </param>
        public static implicit operator RequestContent(DataTransferDataSourceSink model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DataTransferDataSourceSink"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DataTransferDataSourceSink(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDataTransferDataSourceSink(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
