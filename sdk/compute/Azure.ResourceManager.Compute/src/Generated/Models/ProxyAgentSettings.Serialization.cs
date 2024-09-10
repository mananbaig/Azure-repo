// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class ProxyAgentSettings : IUtf8JsonSerializable, IJsonModel<ProxyAgentSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ProxyAgentSettings>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ProxyAgentSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProxyAgentSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProxyAgentSettings)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Enabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(Enabled.Value);
            }
            if (Optional.IsDefined(KeyIncarnationId))
            {
                writer.WritePropertyName("keyIncarnationId"u8);
                writer.WriteNumberValue(KeyIncarnationId.Value);
            }
            if (Optional.IsDefined(WireServer))
            {
                writer.WritePropertyName("wireServer"u8);
                writer.WriteObjectValue(WireServer, options);
            }
            if (Optional.IsDefined(Imds))
            {
                writer.WritePropertyName("imds"u8);
                writer.WriteObjectValue(Imds, options);
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

        ProxyAgentSettings IJsonModel<ProxyAgentSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProxyAgentSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProxyAgentSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeProxyAgentSettings(document.RootElement, options);
        }

        internal static ProxyAgentSettings DeserializeProxyAgentSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? enabled = default;
            int? keyIncarnationId = default;
            HostEndpointSettings wireServer = default;
            HostEndpointSettings imds = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("keyIncarnationId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyIncarnationId = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("wireServer"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    wireServer = HostEndpointSettings.DeserializeHostEndpointSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("imds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    imds = HostEndpointSettings.DeserializeHostEndpointSettings(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ProxyAgentSettings(enabled, keyIncarnationId, wireServer, imds, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ProxyAgentSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProxyAgentSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ProxyAgentSettings)} does not support writing '{options.Format}' format.");
            }
        }

        ProxyAgentSettings IPersistableModel<ProxyAgentSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProxyAgentSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeProxyAgentSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ProxyAgentSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ProxyAgentSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
