// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    internal partial class UnknownFabricSpecificCreateNetworkMappingContent : IUtf8JsonSerializable, IJsonModel<FabricSpecificCreateNetworkMappingContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FabricSpecificCreateNetworkMappingContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<FabricSpecificCreateNetworkMappingContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FabricSpecificCreateNetworkMappingContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FabricSpecificCreateNetworkMappingContent)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        FabricSpecificCreateNetworkMappingContent IJsonModel<FabricSpecificCreateNetworkMappingContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FabricSpecificCreateNetworkMappingContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FabricSpecificCreateNetworkMappingContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFabricSpecificCreateNetworkMappingContent(document.RootElement, options);
        }

        internal static UnknownFabricSpecificCreateNetworkMappingContent DeserializeUnknownFabricSpecificCreateNetworkMappingContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string instanceType = "Unknown";
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new UnknownFabricSpecificCreateNetworkMappingContent(instanceType, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FabricSpecificCreateNetworkMappingContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FabricSpecificCreateNetworkMappingContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FabricSpecificCreateNetworkMappingContent)} does not support writing '{options.Format}' format.");
            }
        }

        FabricSpecificCreateNetworkMappingContent IPersistableModel<FabricSpecificCreateNetworkMappingContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FabricSpecificCreateNetworkMappingContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFabricSpecificCreateNetworkMappingContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FabricSpecificCreateNetworkMappingContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FabricSpecificCreateNetworkMappingContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
