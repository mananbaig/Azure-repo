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
    public partial class SubscriptionResourceGetMonitorMetricsWithPostContent : IUtf8JsonSerializable, IModelJsonSerializable<SubscriptionResourceGetMonitorMetricsWithPostContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SubscriptionResourceGetMonitorMetricsWithPostContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SubscriptionResourceGetMonitorMetricsWithPostContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Timespan))
            {
                writer.WritePropertyName("timespan"u8);
                writer.WriteStringValue(Timespan.Value, "T");
            }
            if (Optional.IsDefined(Interval))
            {
                writer.WritePropertyName("interval"u8);
                writer.WriteStringValue(Interval.Value, "P");
            }
            if (Optional.IsDefined(MetricNames))
            {
                writer.WritePropertyName("metricNames"u8);
                writer.WriteStringValue(MetricNames);
            }
            if (Optional.IsDefined(Aggregation))
            {
                writer.WritePropertyName("aggregation"u8);
                writer.WriteStringValue(Aggregation);
            }
            if (Optional.IsDefined(Filter))
            {
                writer.WritePropertyName("filter"u8);
                writer.WriteStringValue(Filter);
            }
            if (Optional.IsDefined(Top))
            {
                writer.WritePropertyName("top"u8);
                writer.WriteNumberValue(Top.Value);
            }
            if (Optional.IsDefined(OrderBy))
            {
                writer.WritePropertyName("orderBy"u8);
                writer.WriteStringValue(OrderBy);
            }
            if (Optional.IsDefined(RollUpBy))
            {
                writer.WritePropertyName("rollUpBy"u8);
                writer.WriteStringValue(RollUpBy);
            }
            if (Optional.IsDefined(ResultType))
            {
                writer.WritePropertyName("resultType"u8);
                writer.WriteStringValue(ResultType.Value.ToString());
            }
            if (Optional.IsDefined(MetricNamespace))
            {
                writer.WritePropertyName("metricNamespace"u8);
                writer.WriteStringValue(MetricNamespace);
            }
            if (Optional.IsDefined(AutoAdjustTimegrain))
            {
                writer.WritePropertyName("autoAdjustTimegrain"u8);
                writer.WriteBooleanValue(AutoAdjustTimegrain.Value);
            }
            if (Optional.IsDefined(ValidateDimensions))
            {
                writer.WritePropertyName("validateDimensions"u8);
                writer.WriteBooleanValue(ValidateDimensions.Value);
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

        internal static SubscriptionResourceGetMonitorMetricsWithPostContent DeserializeSubscriptionResourceGetMonitorMetricsWithPostContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<TimeSpan> timespan = default;
            Optional<TimeSpan> interval = default;
            Optional<string> metricNames = default;
            Optional<string> aggregation = default;
            Optional<string> filter = default;
            Optional<int> top = default;
            Optional<string> orderBy = default;
            Optional<string> rollUpBy = default;
            Optional<MonitorMetricResultType> resultType = default;
            Optional<string> metricNamespace = default;
            Optional<bool> autoAdjustTimegrain = default;
            Optional<bool> validateDimensions = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timespan"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timespan = property.Value.GetTimeSpan("T");
                    continue;
                }
                if (property.NameEquals("interval"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    interval = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("metricNames"u8))
                {
                    metricNames = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("aggregation"u8))
                {
                    aggregation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("filter"u8))
                {
                    filter = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("top"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    top = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("orderBy"u8))
                {
                    orderBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rollUpBy"u8))
                {
                    rollUpBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resultType = new MonitorMetricResultType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("metricNamespace"u8))
                {
                    metricNamespace = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("autoAdjustTimegrain"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    autoAdjustTimegrain = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("validateDimensions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    validateDimensions = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SubscriptionResourceGetMonitorMetricsWithPostContent(Optional.ToNullable(timespan), Optional.ToNullable(interval), metricNames.Value, aggregation.Value, filter.Value, Optional.ToNullable(top), orderBy.Value, rollUpBy.Value, Optional.ToNullable(resultType), metricNamespace.Value, Optional.ToNullable(autoAdjustTimegrain), Optional.ToNullable(validateDimensions), rawData);
        }

        SubscriptionResourceGetMonitorMetricsWithPostContent IModelJsonSerializable<SubscriptionResourceGetMonitorMetricsWithPostContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSubscriptionResourceGetMonitorMetricsWithPostContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SubscriptionResourceGetMonitorMetricsWithPostContent>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SubscriptionResourceGetMonitorMetricsWithPostContent IModelSerializable<SubscriptionResourceGetMonitorMetricsWithPostContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSubscriptionResourceGetMonitorMetricsWithPostContent(doc.RootElement, options);
        }

        public static implicit operator RequestContent(SubscriptionResourceGetMonitorMetricsWithPostContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator SubscriptionResourceGetMonitorMetricsWithPostContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSubscriptionResourceGetMonitorMetricsWithPostContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
