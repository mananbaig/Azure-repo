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
    public partial class ScheduledQueryRuleCondition : IUtf8JsonSerializable, IModelJsonSerializable<ScheduledQueryRuleCondition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ScheduledQueryRuleCondition>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ScheduledQueryRuleCondition>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Query))
            {
                writer.WritePropertyName("query"u8);
                writer.WriteStringValue(Query);
            }
            if (Optional.IsDefined(TimeAggregation))
            {
                writer.WritePropertyName("timeAggregation"u8);
                writer.WriteStringValue(TimeAggregation.Value.ToString());
            }
            if (Optional.IsDefined(MetricMeasureColumn))
            {
                writer.WritePropertyName("metricMeasureColumn"u8);
                writer.WriteStringValue(MetricMeasureColumn);
            }
            if (Optional.IsDefined(ResourceIdColumn))
            {
                writer.WritePropertyName("resourceIdColumn"u8);
                writer.WriteStringValue(ResourceIdColumn);
            }
            if (Optional.IsCollectionDefined(Dimensions))
            {
                writer.WritePropertyName("dimensions"u8);
                writer.WriteStartArray();
                foreach (var item in Dimensions)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<MonitorDimension>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Operator))
            {
                writer.WritePropertyName("operator"u8);
                writer.WriteStringValue(Operator.Value.ToSerialString());
            }
            if (Optional.IsDefined(Threshold))
            {
                writer.WritePropertyName("threshold"u8);
                writer.WriteNumberValue(Threshold.Value);
            }
            if (Optional.IsDefined(FailingPeriods))
            {
                writer.WritePropertyName("failingPeriods"u8);
                if (FailingPeriods is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ConditionFailingPeriods>)FailingPeriods).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(MetricName))
            {
                writer.WritePropertyName("metricName"u8);
                writer.WriteStringValue(MetricName);
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

        internal static ScheduledQueryRuleCondition DeserializeScheduledQueryRuleCondition(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> query = default;
            Optional<ScheduledQueryRuleTimeAggregationType> timeAggregation = default;
            Optional<string> metricMeasureColumn = default;
            Optional<string> resourceIdColumn = default;
            Optional<IList<MonitorDimension>> dimensions = default;
            Optional<MonitorConditionOperator> @operator = default;
            Optional<double> threshold = default;
            Optional<ConditionFailingPeriods> failingPeriods = default;
            Optional<string> metricName = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("query"u8))
                {
                    query = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timeAggregation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeAggregation = new ScheduledQueryRuleTimeAggregationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("metricMeasureColumn"u8))
                {
                    metricMeasureColumn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceIdColumn"u8))
                {
                    resourceIdColumn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dimensions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MonitorDimension> array = new List<MonitorDimension>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MonitorDimension.DeserializeMonitorDimension(item));
                    }
                    dimensions = array;
                    continue;
                }
                if (property.NameEquals("operator"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    @operator = property.Value.GetString().ToMonitorConditionOperator();
                    continue;
                }
                if (property.NameEquals("threshold"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    threshold = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("failingPeriods"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    failingPeriods = ConditionFailingPeriods.DeserializeConditionFailingPeriods(property.Value);
                    continue;
                }
                if (property.NameEquals("metricName"u8))
                {
                    metricName = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ScheduledQueryRuleCondition(query.Value, Optional.ToNullable(timeAggregation), metricMeasureColumn.Value, resourceIdColumn.Value, Optional.ToList(dimensions), Optional.ToNullable(@operator), Optional.ToNullable(threshold), failingPeriods.Value, metricName.Value, rawData);
        }

        ScheduledQueryRuleCondition IModelJsonSerializable<ScheduledQueryRuleCondition>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeScheduledQueryRuleCondition(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ScheduledQueryRuleCondition>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ScheduledQueryRuleCondition IModelSerializable<ScheduledQueryRuleCondition>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeScheduledQueryRuleCondition(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ScheduledQueryRuleCondition"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ScheduledQueryRuleCondition"/> to convert. </param>
        public static implicit operator RequestContent(ScheduledQueryRuleCondition model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ScheduledQueryRuleCondition"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ScheduledQueryRuleCondition(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeScheduledQueryRuleCondition(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
