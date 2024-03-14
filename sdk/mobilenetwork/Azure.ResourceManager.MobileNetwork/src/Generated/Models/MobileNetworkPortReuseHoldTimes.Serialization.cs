// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.MobileNetwork;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    public partial class MobileNetworkPortReuseHoldTimes : IUtf8JsonSerializable, IJsonModel<MobileNetworkPortReuseHoldTimes>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MobileNetworkPortReuseHoldTimes>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MobileNetworkPortReuseHoldTimes>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MobileNetworkPortReuseHoldTimes>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MobileNetworkPortReuseHoldTimes)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Tcp))
            {
                writer.WritePropertyName("tcp"u8);
                writer.WriteNumberValue(Tcp.Value);
            }
            if (Optional.IsDefined(Udp))
            {
                writer.WritePropertyName("udp"u8);
                writer.WriteNumberValue(Udp.Value);
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

        MobileNetworkPortReuseHoldTimes IJsonModel<MobileNetworkPortReuseHoldTimes>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MobileNetworkPortReuseHoldTimes>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MobileNetworkPortReuseHoldTimes)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMobileNetworkPortReuseHoldTimes(document.RootElement, options);
        }

        internal static MobileNetworkPortReuseHoldTimes DeserializeMobileNetworkPortReuseHoldTimes(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? tcp = default;
            int? udp = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tcp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tcp = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("udp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    udp = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MobileNetworkPortReuseHoldTimes(tcp, udp, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MobileNetworkPortReuseHoldTimes>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MobileNetworkPortReuseHoldTimes>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MobileNetworkPortReuseHoldTimes)} does not support '{options.Format}' format.");
            }
        }

        MobileNetworkPortReuseHoldTimes IPersistableModel<MobileNetworkPortReuseHoldTimes>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MobileNetworkPortReuseHoldTimes>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMobileNetworkPortReuseHoldTimes(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MobileNetworkPortReuseHoldTimes)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MobileNetworkPortReuseHoldTimes>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
