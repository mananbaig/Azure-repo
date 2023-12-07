// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    public partial class DevTestLabCostThreshold : IUtf8JsonSerializable, IJsonModel<DevTestLabCostThreshold>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DevTestLabCostThreshold>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DevTestLabCostThreshold>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabCostThreshold>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(DevTestLabCostThreshold)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ThresholdId))
            {
                writer.WritePropertyName("thresholdId"u8);
                writer.WriteStringValue(ThresholdId);
            }
            if (Optional.IsDefined(PercentageThreshold))
            {
                writer.WritePropertyName("percentageThreshold"u8);
                writer.WriteObjectValue(PercentageThreshold);
            }
            if (Optional.IsDefined(DisplayOnChart))
            {
                writer.WritePropertyName("displayOnChart"u8);
                writer.WriteStringValue(DisplayOnChart.Value.ToString());
            }
            if (Optional.IsDefined(SendNotificationWhenExceeded))
            {
                writer.WritePropertyName("sendNotificationWhenExceeded"u8);
                writer.WriteStringValue(SendNotificationWhenExceeded.Value.ToString());
            }
            if (Optional.IsDefined(NotificationSent))
            {
                writer.WritePropertyName("notificationSent"u8);
                writer.WriteStringValue(NotificationSent);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
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

        DevTestLabCostThreshold IJsonModel<DevTestLabCostThreshold>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabCostThreshold>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(DevTestLabCostThreshold)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDevTestLabCostThreshold(document.RootElement, options);
        }

        internal static DevTestLabCostThreshold DeserializeDevTestLabCostThreshold(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> thresholdId = default;
            Optional<PercentageCostThresholdProperties> percentageThreshold = default;
            Optional<DevTestLabCostThresholdStatus> displayOnChart = default;
            Optional<DevTestLabCostThresholdStatus> sendNotificationWhenExceeded = default;
            Optional<string> notificationSent = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("thresholdId"u8))
                {
                    thresholdId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("percentageThreshold"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    percentageThreshold = PercentageCostThresholdProperties.DeserializePercentageCostThresholdProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("displayOnChart"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    displayOnChart = new DevTestLabCostThresholdStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sendNotificationWhenExceeded"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sendNotificationWhenExceeded = new DevTestLabCostThresholdStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("notificationSent"u8))
                {
                    notificationSent = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DevTestLabCostThreshold(thresholdId.Value, percentageThreshold.Value, Optional.ToNullable(displayOnChart), Optional.ToNullable(sendNotificationWhenExceeded), notificationSent.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DevTestLabCostThreshold>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabCostThreshold>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(DevTestLabCostThreshold)} does not support '{options.Format}' format.");
            }
        }

        DevTestLabCostThreshold IPersistableModel<DevTestLabCostThreshold>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabCostThreshold>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDevTestLabCostThreshold(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(DevTestLabCostThreshold)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DevTestLabCostThreshold>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
