// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ExpressRouteCrossConnectionRoutesTableSummary : IUtf8JsonSerializable, IJsonModel<ExpressRouteCrossConnectionRoutesTableSummary>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExpressRouteCrossConnectionRoutesTableSummary>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ExpressRouteCrossConnectionRoutesTableSummary>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressRouteCrossConnectionRoutesTableSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExpressRouteCrossConnectionRoutesTableSummary)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Neighbor))
            {
                writer.WritePropertyName("neighbor"u8);
                writer.WriteStringValue(Neighbor);
            }
            if (Optional.IsDefined(Asn))
            {
                writer.WritePropertyName("asn"u8);
                writer.WriteNumberValue(Asn.Value);
            }
            if (Optional.IsDefined(UpDown))
            {
                writer.WritePropertyName("upDown"u8);
                writer.WriteStringValue(UpDown);
            }
            if (Optional.IsDefined(StateOrPrefixesReceived))
            {
                writer.WritePropertyName("stateOrPrefixesReceived"u8);
                writer.WriteStringValue(StateOrPrefixesReceived);
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

        ExpressRouteCrossConnectionRoutesTableSummary IJsonModel<ExpressRouteCrossConnectionRoutesTableSummary>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressRouteCrossConnectionRoutesTableSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExpressRouteCrossConnectionRoutesTableSummary)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExpressRouteCrossConnectionRoutesTableSummary(document.RootElement, options);
        }

        internal static ExpressRouteCrossConnectionRoutesTableSummary DeserializeExpressRouteCrossConnectionRoutesTableSummary(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string neighbor = default;
            int? asn = default;
            string upDown = default;
            string stateOrPrefixesReceived = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("neighbor"u8))
                {
                    neighbor = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("asn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    asn = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("upDown"u8))
                {
                    upDown = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("stateOrPrefixesReceived"u8))
                {
                    stateOrPrefixesReceived = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ExpressRouteCrossConnectionRoutesTableSummary(neighbor, asn, upDown, stateOrPrefixesReceived, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ExpressRouteCrossConnectionRoutesTableSummary>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressRouteCrossConnectionRoutesTableSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ExpressRouteCrossConnectionRoutesTableSummary)} does not support '{options.Format}' format.");
            }
        }

        ExpressRouteCrossConnectionRoutesTableSummary IPersistableModel<ExpressRouteCrossConnectionRoutesTableSummary>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressRouteCrossConnectionRoutesTableSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeExpressRouteCrossConnectionRoutesTableSummary(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExpressRouteCrossConnectionRoutesTableSummary)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExpressRouteCrossConnectionRoutesTableSummary>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
