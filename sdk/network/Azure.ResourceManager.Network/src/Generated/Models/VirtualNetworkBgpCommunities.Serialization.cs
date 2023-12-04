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

namespace Azure.ResourceManager.Network.Models
{
    public partial class VirtualNetworkBgpCommunities : IUtf8JsonSerializable, IJsonModel<VirtualNetworkBgpCommunities>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualNetworkBgpCommunities>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VirtualNetworkBgpCommunities>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualNetworkBgpCommunities>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(VirtualNetworkBgpCommunities)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("virtualNetworkCommunity"u8);
            writer.WriteStringValue(VirtualNetworkCommunity);
            if (options.Format != "W" && Optional.IsDefined(RegionalCommunity))
            {
                writer.WritePropertyName("regionalCommunity"u8);
                writer.WriteStringValue(RegionalCommunity);
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

        VirtualNetworkBgpCommunities IJsonModel<VirtualNetworkBgpCommunities>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualNetworkBgpCommunities>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(VirtualNetworkBgpCommunities)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualNetworkBgpCommunities(document.RootElement, options);
        }

        internal static VirtualNetworkBgpCommunities DeserializeVirtualNetworkBgpCommunities(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string virtualNetworkCommunity = default;
            Optional<string> regionalCommunity = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("virtualNetworkCommunity"u8))
                {
                    virtualNetworkCommunity = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("regionalCommunity"u8))
                {
                    regionalCommunity = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VirtualNetworkBgpCommunities(virtualNetworkCommunity, regionalCommunity.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VirtualNetworkBgpCommunities>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualNetworkBgpCommunities>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(VirtualNetworkBgpCommunities)} does not support '{options.Format}' format.");
            }
        }

        VirtualNetworkBgpCommunities IPersistableModel<VirtualNetworkBgpCommunities>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualNetworkBgpCommunities>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVirtualNetworkBgpCommunities(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(VirtualNetworkBgpCommunities)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VirtualNetworkBgpCommunities>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
