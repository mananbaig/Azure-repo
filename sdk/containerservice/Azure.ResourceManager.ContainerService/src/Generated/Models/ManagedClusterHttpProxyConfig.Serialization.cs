// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ManagedClusterHttpProxyConfig : IUtf8JsonSerializable, IJsonModel<ManagedClusterHttpProxyConfig>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedClusterHttpProxyConfig>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagedClusterHttpProxyConfig>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterHttpProxyConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterHttpProxyConfig)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (HttpProxy != null)
            {
                writer.WritePropertyName("httpProxy"u8);
                writer.WriteStringValue(HttpProxy);
            }
            if (HttpsProxy != null)
            {
                writer.WritePropertyName("httpsProxy"u8);
                writer.WriteStringValue(HttpsProxy);
            }
            if (!(NoProxy is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("noProxy"u8);
                writer.WriteStartArray();
                foreach (var item in NoProxy)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (TrustedCA != null)
            {
                writer.WritePropertyName("trustedCa"u8);
                writer.WriteStringValue(TrustedCA);
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

        ManagedClusterHttpProxyConfig IJsonModel<ManagedClusterHttpProxyConfig>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterHttpProxyConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterHttpProxyConfig)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedClusterHttpProxyConfig(document.RootElement, options);
        }

        internal static ManagedClusterHttpProxyConfig DeserializeManagedClusterHttpProxyConfig(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> httpProxy = default;
            Optional<string> httpsProxy = default;
            Optional<IList<string>> noProxy = default;
            Optional<string> trustedCA = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("httpProxy"u8))
                {
                    httpProxy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("httpsProxy"u8))
                {
                    httpsProxy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("noProxy"u8))
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
                    noProxy = array;
                    continue;
                }
                if (property.NameEquals("trustedCa"u8))
                {
                    trustedCA = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ManagedClusterHttpProxyConfig(httpProxy.Value, httpsProxy.Value, Optional.ToList(noProxy), trustedCA.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagedClusterHttpProxyConfig>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterHttpProxyConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterHttpProxyConfig)} does not support '{options.Format}' format.");
            }
        }

        ManagedClusterHttpProxyConfig IPersistableModel<ManagedClusterHttpProxyConfig>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterHttpProxyConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedClusterHttpProxyConfig(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterHttpProxyConfig)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedClusterHttpProxyConfig>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
