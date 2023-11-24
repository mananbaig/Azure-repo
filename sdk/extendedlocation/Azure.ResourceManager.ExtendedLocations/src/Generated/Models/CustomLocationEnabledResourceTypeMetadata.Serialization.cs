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

namespace Azure.ResourceManager.ExtendedLocations.Models
{
    public partial class CustomLocationEnabledResourceTypeMetadata : IUtf8JsonSerializable, IJsonModel<CustomLocationEnabledResourceTypeMetadata>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CustomLocationEnabledResourceTypeMetadata>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CustomLocationEnabledResourceTypeMetadata>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomLocationEnabledResourceTypeMetadata>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(CustomLocationEnabledResourceTypeMetadata)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ApiVersion))
            {
                writer.WritePropertyName("apiVersion"u8);
                writer.WriteStringValue(ApiVersion);
            }
            if (Optional.IsDefined(ResourceProviderNamespace))
            {
                writer.WritePropertyName("resourceProviderNamespace"u8);
                writer.WriteStringValue(ResourceProviderNamespace);
            }
            if (Optional.IsDefined(ResourceType))
            {
                writer.WritePropertyName("resourceType"u8);
                writer.WriteStringValue(ResourceType);
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

        CustomLocationEnabledResourceTypeMetadata IJsonModel<CustomLocationEnabledResourceTypeMetadata>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomLocationEnabledResourceTypeMetadata>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(CustomLocationEnabledResourceTypeMetadata)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCustomLocationEnabledResourceTypeMetadata(document.RootElement, options);
        }

        internal static CustomLocationEnabledResourceTypeMetadata DeserializeCustomLocationEnabledResourceTypeMetadata(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> apiVersion = default;
            Optional<string> resourceProviderNamespace = default;
            Optional<string> resourceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("apiVersion"u8))
                {
                    apiVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceProviderNamespace"u8))
                {
                    resourceProviderNamespace = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceType"u8))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CustomLocationEnabledResourceTypeMetadata(apiVersion.Value, resourceProviderNamespace.Value, resourceType.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CustomLocationEnabledResourceTypeMetadata>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomLocationEnabledResourceTypeMetadata>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(CustomLocationEnabledResourceTypeMetadata)} does not support '{options.Format}' format.");
            }
        }

        CustomLocationEnabledResourceTypeMetadata IPersistableModel<CustomLocationEnabledResourceTypeMetadata>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomLocationEnabledResourceTypeMetadata>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCustomLocationEnabledResourceTypeMetadata(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(CustomLocationEnabledResourceTypeMetadata)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CustomLocationEnabledResourceTypeMetadata>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
