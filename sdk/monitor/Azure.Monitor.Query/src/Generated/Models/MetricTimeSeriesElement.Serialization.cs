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

namespace Azure.Monitor.Query.Models
{
    public partial class MetricTimeSeriesElement : IUtf8JsonSerializable, IModelJsonSerializable<MetricTimeSeriesElement>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MetricTimeSeriesElement>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MetricTimeSeriesElement>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Metadatavalues))
            {
                writer.WritePropertyName("metadatavalues"u8);
                writer.WriteStartArray();
                foreach (var item in Metadatavalues)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Values))
            {
                writer.WritePropertyName("data"u8);
                writer.WriteStartArray();
                foreach (var item in Values)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        internal static MetricTimeSeriesElement DeserializeMetricTimeSeriesElement(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<MetadataValue>> metadatavalues = default;
            Optional<IReadOnlyList<MetricValue>> data = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("metadatavalues"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MetadataValue> array = new List<MetadataValue>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MetadataValue.DeserializeMetadataValue(item));
                    }
                    metadatavalues = array;
                    continue;
                }
                if (property.NameEquals("data"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MetricValue> array = new List<MetricValue>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MetricValue.DeserializeMetricValue(item));
                    }
                    data = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MetricTimeSeriesElement(Optional.ToList(metadatavalues), Optional.ToList(data), rawData);
        }

        MetricTimeSeriesElement IModelJsonSerializable<MetricTimeSeriesElement>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMetricTimeSeriesElement(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MetricTimeSeriesElement>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MetricTimeSeriesElement IModelSerializable<MetricTimeSeriesElement>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMetricTimeSeriesElement(doc.RootElement, options);
        }

        public static implicit operator RequestContent(MetricTimeSeriesElement model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator MetricTimeSeriesElement(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMetricTimeSeriesElement(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
