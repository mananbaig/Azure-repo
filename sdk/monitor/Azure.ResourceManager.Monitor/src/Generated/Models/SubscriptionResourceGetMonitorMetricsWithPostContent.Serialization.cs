// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class SubscriptionResourceGetMonitorMetricsWithPostContent : IUtf8JsonSerializable, IJsonModel<SubscriptionResourceGetMonitorMetricsWithPostContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SubscriptionResourceGetMonitorMetricsWithPostContent>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<SubscriptionResourceGetMonitorMetricsWithPostContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<SubscriptionResourceGetMonitorMetricsWithPostContent>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<SubscriptionResourceGetMonitorMetricsWithPostContent>)} interface");
            }

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
            if (_serializedAdditionalRawData != null && options.Format == "J")
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        SubscriptionResourceGetMonitorMetricsWithPostContent IJsonModel<SubscriptionResourceGetMonitorMetricsWithPostContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SubscriptionResourceGetMonitorMetricsWithPostContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSubscriptionResourceGetMonitorMetricsWithPostContent(document.RootElement, options);
        }

        internal static SubscriptionResourceGetMonitorMetricsWithPostContent DeserializeSubscriptionResourceGetMonitorMetricsWithPostContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

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
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
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
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SubscriptionResourceGetMonitorMetricsWithPostContent(Optional.ToNullable(timespan), Optional.ToNullable(interval), metricNames.Value, aggregation.Value, filter.Value, Optional.ToNullable(top), orderBy.Value, rollUpBy.Value, Optional.ToNullable(resultType), metricNamespace.Value, Optional.ToNullable(autoAdjustTimegrain), Optional.ToNullable(validateDimensions), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SubscriptionResourceGetMonitorMetricsWithPostContent>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SubscriptionResourceGetMonitorMetricsWithPostContent)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SubscriptionResourceGetMonitorMetricsWithPostContent IPersistableModel<SubscriptionResourceGetMonitorMetricsWithPostContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SubscriptionResourceGetMonitorMetricsWithPostContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSubscriptionResourceGetMonitorMetricsWithPostContent(document.RootElement, options);
        }

        string IPersistableModel<SubscriptionResourceGetMonitorMetricsWithPostContent>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
