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

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class MonitorTimeWindow : IUtf8JsonSerializable, IJsonModel<MonitorTimeWindow>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MonitorTimeWindow>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MonitorTimeWindow>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorTimeWindow>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(MonitorTimeWindow)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(TimeZone))
            {
                writer.WritePropertyName("timeZone"u8);
                writer.WriteStringValue(TimeZone);
            }
            writer.WritePropertyName("start"u8);
            writer.WriteStringValue(StartOn, "O");
            writer.WritePropertyName("end"u8);
            writer.WriteStringValue(EndOn, "O");
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

        MonitorTimeWindow IJsonModel<MonitorTimeWindow>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorTimeWindow>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(MonitorTimeWindow)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMonitorTimeWindow(document.RootElement, options);
        }

        internal static MonitorTimeWindow DeserializeMonitorTimeWindow(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> timeZone = default;
            DateTimeOffset start = default;
            DateTimeOffset end = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timeZone"u8))
                {
                    timeZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("start"u8))
                {
                    start = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("end"u8))
                {
                    end = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MonitorTimeWindow(timeZone.Value, start, end, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MonitorTimeWindow>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorTimeWindow>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(MonitorTimeWindow)} does not support '{options.Format}' format.");
            }
        }

        MonitorTimeWindow IPersistableModel<MonitorTimeWindow>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorTimeWindow>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMonitorTimeWindow(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(MonitorTimeWindow)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MonitorTimeWindow>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
