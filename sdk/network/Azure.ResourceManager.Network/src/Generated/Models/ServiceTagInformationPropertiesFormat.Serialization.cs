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
    public partial class ServiceTagInformationPropertiesFormat : IUtf8JsonSerializable, IJsonModel<ServiceTagInformationPropertiesFormat>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ServiceTagInformationPropertiesFormat>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ServiceTagInformationPropertiesFormat>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceTagInformationPropertiesFormat>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ServiceTagInformationPropertiesFormat)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ChangeNumber))
            {
                writer.WritePropertyName("changeNumber"u8);
                writer.WriteStringValue(ChangeNumber);
            }
            if (options.Format != "W" && Optional.IsDefined(Region))
            {
                writer.WritePropertyName("region"u8);
                writer.WriteStringValue(Region);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemService))
            {
                writer.WritePropertyName("systemService"u8);
                writer.WriteStringValue(SystemService);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(AddressPrefixes))
            {
                writer.WritePropertyName("addressPrefixes"u8);
                writer.WriteStartArray();
                foreach (var item in AddressPrefixes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State);
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

        ServiceTagInformationPropertiesFormat IJsonModel<ServiceTagInformationPropertiesFormat>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceTagInformationPropertiesFormat>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ServiceTagInformationPropertiesFormat)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeServiceTagInformationPropertiesFormat(document.RootElement, options);
        }

        internal static ServiceTagInformationPropertiesFormat DeserializeServiceTagInformationPropertiesFormat(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> changeNumber = default;
            Optional<string> region = default;
            Optional<string> systemService = default;
            Optional<IReadOnlyList<string>> addressPrefixes = default;
            Optional<string> state = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("changeNumber"u8))
                {
                    changeNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("region"u8))
                {
                    region = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("systemService"u8))
                {
                    systemService = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("addressPrefixes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    addressPrefixes = array;
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    state = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ServiceTagInformationPropertiesFormat(changeNumber.Value, region.Value, systemService.Value, Optional.ToList(addressPrefixes), state.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ServiceTagInformationPropertiesFormat>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceTagInformationPropertiesFormat>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(ServiceTagInformationPropertiesFormat)} does not support '{options.Format}' format.");
            }
        }

        ServiceTagInformationPropertiesFormat IPersistableModel<ServiceTagInformationPropertiesFormat>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceTagInformationPropertiesFormat>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeServiceTagInformationPropertiesFormat(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(ServiceTagInformationPropertiesFormat)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ServiceTagInformationPropertiesFormat>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
