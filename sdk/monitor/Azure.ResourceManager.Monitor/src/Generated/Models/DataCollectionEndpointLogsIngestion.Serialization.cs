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

namespace Azure.ResourceManager.Monitor.Models
{
    internal partial class DataCollectionEndpointLogsIngestion : IUtf8JsonSerializable, IModelJsonSerializable<DataCollectionEndpointLogsIngestion>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DataCollectionEndpointLogsIngestion>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DataCollectionEndpointLogsIngestion>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DataCollectionEndpointLogsIngestion>(this, options.Format);

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

        internal static DataCollectionEndpointLogsIngestion DeserializeDataCollectionEndpointLogsIngestion(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> endpoint = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("endpoint"u8))
                {
                    endpoint = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DataCollectionEndpointLogsIngestion(endpoint.Value, rawData);
        }

        DataCollectionEndpointLogsIngestion IModelJsonSerializable<DataCollectionEndpointLogsIngestion>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DataCollectionEndpointLogsIngestion>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDataCollectionEndpointLogsIngestion(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DataCollectionEndpointLogsIngestion>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DataCollectionEndpointLogsIngestion>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DataCollectionEndpointLogsIngestion IModelSerializable<DataCollectionEndpointLogsIngestion>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DataCollectionEndpointLogsIngestion>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDataCollectionEndpointLogsIngestion(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DataCollectionEndpointLogsIngestion"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DataCollectionEndpointLogsIngestion"/> to convert. </param>
        public static implicit operator RequestContent(DataCollectionEndpointLogsIngestion model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DataCollectionEndpointLogsIngestion"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DataCollectionEndpointLogsIngestion(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDataCollectionEndpointLogsIngestion(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
