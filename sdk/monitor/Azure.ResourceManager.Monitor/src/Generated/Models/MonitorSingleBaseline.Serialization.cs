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
    public partial class MonitorSingleBaseline : IUtf8JsonSerializable, IModelJsonSerializable<MonitorSingleBaseline>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MonitorSingleBaseline>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MonitorSingleBaseline>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("sensitivity"u8);
            writer.WriteStringValue(Sensitivity.ToString());
            writer.WritePropertyName("lowThresholds"u8);
            writer.WriteStartArray();
            foreach (var item in LowThresholds)
            {
                writer.WriteNumberValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("highThresholds"u8);
            writer.WriteStartArray();
            foreach (var item in HighThresholds)
            {
                writer.WriteNumberValue(item);
            }
            writer.WriteEndArray();
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

        internal static MonitorSingleBaseline DeserializeMonitorSingleBaseline(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MonitorBaselineSensitivity sensitivity = default;
            IReadOnlyList<double> lowThresholds = default;
            IReadOnlyList<double> highThresholds = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sensitivity"u8))
                {
                    sensitivity = new MonitorBaselineSensitivity(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("lowThresholds"u8))
                {
                    List<double> array = new List<double>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetDouble());
                    }
                    lowThresholds = array;
                    continue;
                }
                if (property.NameEquals("highThresholds"u8))
                {
                    List<double> array = new List<double>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetDouble());
                    }
                    highThresholds = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MonitorSingleBaseline(sensitivity, lowThresholds, highThresholds, rawData);
        }

        MonitorSingleBaseline IModelJsonSerializable<MonitorSingleBaseline>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMonitorSingleBaseline(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MonitorSingleBaseline>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MonitorSingleBaseline IModelSerializable<MonitorSingleBaseline>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMonitorSingleBaseline(doc.RootElement, options);
        }

        public static implicit operator RequestContent(MonitorSingleBaseline model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator MonitorSingleBaseline(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMonitorSingleBaseline(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
