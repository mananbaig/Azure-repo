// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ManagedNetworkFabric;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class Layer3IPPrefixProperties : IUtf8JsonSerializable, IJsonModel<Layer3IPPrefixProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<Layer3IPPrefixProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<Layer3IPPrefixProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Layer3IPPrefixProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(Layer3IPPrefixProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(PrimaryIPv4Prefix))
            {
                writer.WritePropertyName("primaryIpv4Prefix"u8);
                writer.WriteStringValue(PrimaryIPv4Prefix);
            }
            if (Optional.IsDefined(PrimaryIPv6Prefix))
            {
                writer.WritePropertyName("primaryIpv6Prefix"u8);
                writer.WriteStringValue(PrimaryIPv6Prefix);
            }
            if (Optional.IsDefined(SecondaryIPv4Prefix))
            {
                writer.WritePropertyName("secondaryIpv4Prefix"u8);
                writer.WriteStringValue(SecondaryIPv4Prefix);
            }
            if (Optional.IsDefined(SecondaryIPv6Prefix))
            {
                writer.WritePropertyName("secondaryIpv6Prefix"u8);
                writer.WriteStringValue(SecondaryIPv6Prefix);
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

        Layer3IPPrefixProperties IJsonModel<Layer3IPPrefixProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Layer3IPPrefixProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(Layer3IPPrefixProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLayer3IPPrefixProperties(document.RootElement, options);
        }

        internal static Layer3IPPrefixProperties DeserializeLayer3IPPrefixProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string primaryIPv4Prefix = default;
            string primaryIPv6Prefix = default;
            string secondaryIPv4Prefix = default;
            string secondaryIPv6Prefix = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primaryIpv4Prefix"u8))
                {
                    primaryIPv4Prefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("primaryIpv6Prefix"u8))
                {
                    primaryIPv6Prefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryIpv4Prefix"u8))
                {
                    secondaryIPv4Prefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryIpv6Prefix"u8))
                {
                    secondaryIPv6Prefix = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new Layer3IPPrefixProperties(primaryIPv4Prefix, primaryIPv6Prefix, secondaryIPv4Prefix, secondaryIPv6Prefix, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<Layer3IPPrefixProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Layer3IPPrefixProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(Layer3IPPrefixProperties)} does not support '{options.Format}' format.");
            }
        }

        Layer3IPPrefixProperties IPersistableModel<Layer3IPPrefixProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Layer3IPPrefixProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLayer3IPPrefixProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(Layer3IPPrefixProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<Layer3IPPrefixProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
