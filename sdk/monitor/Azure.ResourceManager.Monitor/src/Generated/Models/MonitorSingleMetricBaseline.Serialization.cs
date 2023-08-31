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
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class MonitorSingleMetricBaseline : IUtf8JsonSerializable, IModelJsonSerializable<MonitorSingleMetricBaseline>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MonitorSingleMetricBaseline>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MonitorSingleMetricBaseline>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("timespan"u8);
            writer.WriteStringValue(Timespan);
            writer.WritePropertyName("interval"u8);
            writer.WriteStringValue(Interval, "P");
            if (Optional.IsDefined(Namespace))
            {
                writer.WritePropertyName("namespace"u8);
                writer.WriteStringValue(Namespace);
            }
            writer.WritePropertyName("baselines"u8);
            writer.WriteStartArray();
            foreach (var item in Baselines)
            {
                if (item is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<MonitorTimeSeriesBaseline>)item).Serialize(writer, options);
                }
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
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

        internal static MonitorSingleMetricBaseline DeserializeMonitorSingleMetricBaseline(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            string timespan = default;
            TimeSpan interval = default;
            Optional<string> @namespace = default;
            IReadOnlyList<MonitorTimeSeriesBaseline> baselines = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("timespan"u8))
                        {
                            timespan = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("interval"u8))
                        {
                            interval = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("namespace"u8))
                        {
                            @namespace = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("baselines"u8))
                        {
                            List<MonitorTimeSeriesBaseline> array = new List<MonitorTimeSeriesBaseline>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(MonitorTimeSeriesBaseline.DeserializeMonitorTimeSeriesBaseline(item));
                            }
                            baselines = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MonitorSingleMetricBaseline(id, name, type, systemData.Value, timespan, interval, @namespace.Value, baselines, rawData);
        }

        MonitorSingleMetricBaseline IModelJsonSerializable<MonitorSingleMetricBaseline>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMonitorSingleMetricBaseline(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MonitorSingleMetricBaseline>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MonitorSingleMetricBaseline IModelSerializable<MonitorSingleMetricBaseline>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMonitorSingleMetricBaseline(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MonitorSingleMetricBaseline"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MonitorSingleMetricBaseline"/> to convert. </param>
        public static implicit operator RequestContent(MonitorSingleMetricBaseline model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MonitorSingleMetricBaseline"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MonitorSingleMetricBaseline(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMonitorSingleMetricBaseline(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
