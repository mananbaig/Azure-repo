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

namespace Azure.ResourceManager.NewRelicObservability.Models
{
    public partial class NewRelicResourceMonitorResult : IUtf8JsonSerializable, IJsonModel<NewRelicResourceMonitorResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NewRelicResourceMonitorResult>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<NewRelicResourceMonitorResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<NewRelicResourceMonitorResult>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<NewRelicResourceMonitorResult>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(SendingMetrics))
            {
                writer.WritePropertyName("sendingMetrics"u8);
                writer.WriteStringValue(SendingMetrics.Value.ToString());
            }
            if (Optional.IsDefined(ReasonForMetricsStatus))
            {
                writer.WritePropertyName("reasonForMetricsStatus"u8);
                writer.WriteStringValue(ReasonForMetricsStatus);
            }
            if (Optional.IsDefined(SendingLogs))
            {
                writer.WritePropertyName("sendingLogs"u8);
                writer.WriteStringValue(SendingLogs.Value.ToString());
            }
            if (Optional.IsDefined(ReasonForLogsStatus))
            {
                writer.WritePropertyName("reasonForLogsStatus"u8);
                writer.WriteStringValue(ReasonForLogsStatus);
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

        NewRelicResourceMonitorResult IJsonModel<NewRelicResourceMonitorResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NewRelicResourceMonitorResult)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNewRelicResourceMonitorResult(document.RootElement, options);
        }

        internal static NewRelicResourceMonitorResult DeserializeNewRelicResourceMonitorResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> id = default;
            Optional<NewRelicObservabilitySendingMetricsStatus> sendingMetrics = default;
            Optional<string> reasonForMetricsStatus = default;
            Optional<NewRelicObservabilitySendingLogsStatus> sendingLogs = default;
            Optional<string> reasonForLogsStatus = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sendingMetrics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sendingMetrics = new NewRelicObservabilitySendingMetricsStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("reasonForMetricsStatus"u8))
                {
                    reasonForMetricsStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sendingLogs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sendingLogs = new NewRelicObservabilitySendingLogsStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("reasonForLogsStatus"u8))
                {
                    reasonForLogsStatus = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NewRelicResourceMonitorResult(id.Value, Optional.ToNullable(sendingMetrics), reasonForMetricsStatus.Value, Optional.ToNullable(sendingLogs), reasonForLogsStatus.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NewRelicResourceMonitorResult>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NewRelicResourceMonitorResult)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        NewRelicResourceMonitorResult IPersistableModel<NewRelicResourceMonitorResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NewRelicResourceMonitorResult)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeNewRelicResourceMonitorResult(document.RootElement, options);
        }

        string IPersistableModel<NewRelicResourceMonitorResult>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
