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
    public partial class MonitorMetricDefinition : IUtf8JsonSerializable, IModelJsonSerializable<MonitorMetricDefinition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MonitorMetricDefinition>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MonitorMetricDefinition>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(IsDimensionRequired))
            {
                writer.WritePropertyName("isDimensionRequired"u8);
                writer.WriteBooleanValue(IsDimensionRequired.Value);
            }
            if (Optional.IsDefined(ResourceId))
            {
                writer.WritePropertyName("resourceId"u8);
                writer.WriteStringValue(ResourceId);
            }
            if (Optional.IsDefined(Namespace))
            {
                writer.WritePropertyName("namespace"u8);
                writer.WriteStringValue(Namespace);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteObjectValue(Name);
            }
            if (Optional.IsDefined(DisplayDescription))
            {
                writer.WritePropertyName("displayDescription"u8);
                writer.WriteStringValue(DisplayDescription);
            }
            if (Optional.IsDefined(Category))
            {
                writer.WritePropertyName("category"u8);
                writer.WriteStringValue(Category);
            }
            if (Optional.IsDefined(MetricClass))
            {
                writer.WritePropertyName("metricClass"u8);
                writer.WriteStringValue(MetricClass.Value.ToString());
            }
            if (Optional.IsDefined(Unit))
            {
                writer.WritePropertyName("unit"u8);
                writer.WriteStringValue(Unit.Value.ToString());
            }
            if (Optional.IsDefined(PrimaryAggregationType))
            {
                writer.WritePropertyName("primaryAggregationType"u8);
                writer.WriteStringValue(PrimaryAggregationType.Value.ToSerialString());
            }
            if (Optional.IsCollectionDefined(SupportedAggregationTypes))
            {
                writer.WritePropertyName("supportedAggregationTypes"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedAggregationTypes)
                {
                    writer.WriteStringValue(item.ToSerialString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(MetricAvailabilities))
            {
                writer.WritePropertyName("metricAvailabilities"u8);
                writer.WriteStartArray();
                foreach (var item in MetricAvailabilities)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsCollectionDefined(Dimensions))
            {
                writer.WritePropertyName("dimensions"u8);
                writer.WriteStartArray();
                foreach (var item in Dimensions)
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

        internal static MonitorMetricDefinition DeserializeMonitorMetricDefinition(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> isDimensionRequired = default;
            Optional<string> resourceId = default;
            Optional<string> @namespace = default;
            Optional<MonitorLocalizableString> name = default;
            Optional<string> displayDescription = default;
            Optional<string> category = default;
            Optional<MonitorMetricClass> metricClass = default;
            Optional<MonitorMetricUnit> unit = default;
            Optional<MonitorAggregationType> primaryAggregationType = default;
            Optional<IReadOnlyList<MonitorAggregationType>> supportedAggregationTypes = default;
            Optional<IReadOnlyList<MonitorMetricAvailability>> metricAvailabilities = default;
            Optional<string> id = default;
            Optional<IReadOnlyList<MonitorLocalizableString>> dimensions = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("isDimensionRequired"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isDimensionRequired = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("resourceId"u8))
                {
                    resourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("namespace"u8))
                {
                    @namespace = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = MonitorLocalizableString.DeserializeMonitorLocalizableString(property.Value);
                    continue;
                }
                if (property.NameEquals("displayDescription"u8))
                {
                    displayDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("category"u8))
                {
                    category = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metricClass"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    metricClass = new MonitorMetricClass(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("unit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    unit = new MonitorMetricUnit(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("primaryAggregationType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryAggregationType = property.Value.GetString().ToMonitorAggregationType();
                    continue;
                }
                if (property.NameEquals("supportedAggregationTypes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MonitorAggregationType> array = new List<MonitorAggregationType>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString().ToMonitorAggregationType());
                    }
                    supportedAggregationTypes = array;
                    continue;
                }
                if (property.NameEquals("metricAvailabilities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MonitorMetricAvailability> array = new List<MonitorMetricAvailability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MonitorMetricAvailability.DeserializeMonitorMetricAvailability(item));
                    }
                    metricAvailabilities = array;
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dimensions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MonitorLocalizableString> array = new List<MonitorLocalizableString>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MonitorLocalizableString.DeserializeMonitorLocalizableString(item));
                    }
                    dimensions = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MonitorMetricDefinition(Optional.ToNullable(isDimensionRequired), resourceId.Value, @namespace.Value, name.Value, displayDescription.Value, category.Value, Optional.ToNullable(metricClass), Optional.ToNullable(unit), Optional.ToNullable(primaryAggregationType), Optional.ToList(supportedAggregationTypes), Optional.ToList(metricAvailabilities), id.Value, Optional.ToList(dimensions), rawData);
        }

        MonitorMetricDefinition IModelJsonSerializable<MonitorMetricDefinition>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMonitorMetricDefinition(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MonitorMetricDefinition>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MonitorMetricDefinition IModelSerializable<MonitorMetricDefinition>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMonitorMetricDefinition(doc.RootElement, options);
        }

        public static implicit operator RequestContent(MonitorMetricDefinition model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator MonitorMetricDefinition(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMonitorMetricDefinition(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
