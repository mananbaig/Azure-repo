// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class VirtualApplianceNetworkInterfaceConfiguration : IUtf8JsonSerializable, IJsonModel<VirtualApplianceNetworkInterfaceConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualApplianceNetworkInterfaceConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<VirtualApplianceNetworkInterfaceConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualApplianceNetworkInterfaceConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualApplianceNetworkInterfaceConfiguration)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(NicType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(NicType.Value.ToString());
            }
            if (Optional.IsDefined(Properties))
            {
                writer.WritePropertyName("properties"u8);
                writer.WriteObjectValue(Properties, options);
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

        VirtualApplianceNetworkInterfaceConfiguration IJsonModel<VirtualApplianceNetworkInterfaceConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualApplianceNetworkInterfaceConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualApplianceNetworkInterfaceConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualApplianceNetworkInterfaceConfiguration(document.RootElement, options);
        }

        internal static VirtualApplianceNetworkInterfaceConfiguration DeserializeVirtualApplianceNetworkInterfaceConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            NicTypeInRequest? type = default;
            VirtualApplianceNetworkInterfaceConfigurationProperties properties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new NicTypeInRequest(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    properties = VirtualApplianceNetworkInterfaceConfigurationProperties.DeserializeVirtualApplianceNetworkInterfaceConfigurationProperties(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new VirtualApplianceNetworkInterfaceConfiguration(type, properties, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VirtualApplianceNetworkInterfaceConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualApplianceNetworkInterfaceConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VirtualApplianceNetworkInterfaceConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        VirtualApplianceNetworkInterfaceConfiguration IPersistableModel<VirtualApplianceNetworkInterfaceConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualApplianceNetworkInterfaceConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVirtualApplianceNetworkInterfaceConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VirtualApplianceNetworkInterfaceConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VirtualApplianceNetworkInterfaceConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
