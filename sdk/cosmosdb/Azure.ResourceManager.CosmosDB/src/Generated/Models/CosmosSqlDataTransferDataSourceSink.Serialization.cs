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
    public partial class CosmosSqlDataTransferDataSourceSink : IUtf8JsonSerializable, IModelJsonSerializable<CosmosSqlDataTransferDataSourceSink>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CosmosSqlDataTransferDataSourceSink>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CosmosSqlDataTransferDataSourceSink>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<CosmosSqlDataTransferDataSourceSink>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("databaseName"u8);
            writer.WriteStringValue(DatabaseName);
            writer.WritePropertyName("containerName"u8);
            writer.WriteStringValue(ContainerName);
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

        internal static CosmosSqlDataTransferDataSourceSink DeserializeCosmosSqlDataTransferDataSourceSink(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string databaseName = default;
            string containerName = default;
            DataTransferComponent component = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("databaseName"u8))
                {
                    databaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("containerName"u8))
                {
                    containerName = property.Value.GetString();
                    continue;
                }
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
            return new CosmosSqlDataTransferDataSourceSink(component, databaseName, containerName, rawData);
        }

        CosmosSqlDataTransferDataSourceSink IModelJsonSerializable<CosmosSqlDataTransferDataSourceSink>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<CosmosSqlDataTransferDataSourceSink>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCosmosSqlDataTransferDataSourceSink(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CosmosSqlDataTransferDataSourceSink>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<CosmosSqlDataTransferDataSourceSink>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CosmosSqlDataTransferDataSourceSink IModelSerializable<CosmosSqlDataTransferDataSourceSink>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<CosmosSqlDataTransferDataSourceSink>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCosmosSqlDataTransferDataSourceSink(doc.RootElement, options);
        }

        public static implicit operator RequestContent(CosmosSqlDataTransferDataSourceSink model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator CosmosSqlDataTransferDataSourceSink(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCosmosSqlDataTransferDataSourceSink(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
