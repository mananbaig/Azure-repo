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
    public partial class SubscriptionMonitorMetric : IUtf8JsonSerializable, IJsonModel<SubscriptionMonitorMetric>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SubscriptionMonitorMetric>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<SubscriptionMonitorMetric>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<SubscriptionMonitorMetric>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<SubscriptionMonitorMetric>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(SubscriptionScopeMetricType);
            writer.WritePropertyName("name"u8);
            writer.WriteObjectValue(Name);
            if (Optional.IsDefined(DisplayDescription))
            {
                writer.WritePropertyName("displayDescription"u8);
                writer.WriteStringValue(DisplayDescription);
            }
            if (Optional.IsDefined(ErrorCode))
            {
                writer.WritePropertyName("errorCode"u8);
                writer.WriteStringValue(ErrorCode);
            }
            if (Optional.IsDefined(ErrorMessage))
            {
                writer.WritePropertyName("errorMessage"u8);
                writer.WriteStringValue(ErrorMessage);
            }
            writer.WritePropertyName("unit"u8);
            writer.WriteStringValue(Unit.ToString());
            writer.WritePropertyName("timeseries"u8);
            writer.WriteStartArray();
            foreach (var item in Timeseries)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
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

        SubscriptionMonitorMetric IJsonModel<SubscriptionMonitorMetric>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SubscriptionMonitorMetric)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSubscriptionMonitorMetric(document.RootElement, options);
        }

        internal static SubscriptionMonitorMetric DeserializeSubscriptionMonitorMetric(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            string type = default;
            MonitorLocalizableString name = default;
            Optional<string> displayDescription = default;
            Optional<string> errorCode = default;
            Optional<string> errorMessage = default;
            MonitorMetricUnit unit = default;
            IReadOnlyList<MonitorTimeSeriesElement> timeseries = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = MonitorLocalizableString.DeserializeMonitorLocalizableString(property.Value);
                    continue;
                }
                if (property.NameEquals("displayDescription"u8))
                {
                    displayDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorCode"u8))
                {
                    errorCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorMessage"u8))
                {
                    errorMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("unit"u8))
                {
                    unit = new MonitorMetricUnit(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("timeseries"u8))
                {
                    List<MonitorTimeSeriesElement> array = new List<MonitorTimeSeriesElement>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MonitorTimeSeriesElement.DeserializeMonitorTimeSeriesElement(item));
                    }
                    timeseries = array;
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SubscriptionMonitorMetric(id, type, name, displayDescription.Value, errorCode.Value, errorMessage.Value, unit, timeseries, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SubscriptionMonitorMetric>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SubscriptionMonitorMetric)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SubscriptionMonitorMetric IPersistableModel<SubscriptionMonitorMetric>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SubscriptionMonitorMetric)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSubscriptionMonitorMetric(document.RootElement, options);
        }

        string IPersistableModel<SubscriptionMonitorMetric>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
