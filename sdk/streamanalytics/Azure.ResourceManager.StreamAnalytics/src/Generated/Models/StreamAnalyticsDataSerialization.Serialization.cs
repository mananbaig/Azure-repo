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

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class StreamAnalyticsDataSerialization : IUtf8JsonSerializable, IModelJsonSerializable<StreamAnalyticsDataSerialization>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<StreamAnalyticsDataSerialization>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<StreamAnalyticsDataSerialization>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StreamAnalyticsDataSerialization>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(EventSerializationType.ToString());
            if (_serializedAdditionalRawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _serializedAdditionalRawData)
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

        internal static StreamAnalyticsDataSerialization DeserializeStreamAnalyticsDataSerialization(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Avro": return AvroFormatSerialization.DeserializeAvroFormatSerialization(element);
                    case "Csv": return CsvFormatSerialization.DeserializeCsvFormatSerialization(element);
                    case "CustomClr": return CustomClrFormatSerialization.DeserializeCustomClrFormatSerialization(element);
                    case "Json": return JsonFormatSerialization.DeserializeJsonFormatSerialization(element);
                    case "Parquet": return ParquetFormatSerialization.DeserializeParquetFormatSerialization(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            EventSerializationType type = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new EventSerializationType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new UnknownSerialization(type, serializedAdditionalRawData);
        }

        StreamAnalyticsDataSerialization IModelJsonSerializable<StreamAnalyticsDataSerialization>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StreamAnalyticsDataSerialization>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeStreamAnalyticsDataSerialization(doc.RootElement, options);
        }

        BinaryData IModelSerializable<StreamAnalyticsDataSerialization>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StreamAnalyticsDataSerialization>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        StreamAnalyticsDataSerialization IModelSerializable<StreamAnalyticsDataSerialization>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StreamAnalyticsDataSerialization>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeStreamAnalyticsDataSerialization(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="StreamAnalyticsDataSerialization"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="StreamAnalyticsDataSerialization"/> to convert. </param>
        public static implicit operator RequestContent(StreamAnalyticsDataSerialization model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="StreamAnalyticsDataSerialization"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator StreamAnalyticsDataSerialization(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeStreamAnalyticsDataSerialization(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
