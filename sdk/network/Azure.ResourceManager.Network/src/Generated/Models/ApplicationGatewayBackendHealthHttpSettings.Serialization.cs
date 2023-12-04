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
    public partial class ApplicationGatewayBackendHealthHttpSettings : IUtf8JsonSerializable, IJsonModel<ApplicationGatewayBackendHealthHttpSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApplicationGatewayBackendHealthHttpSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ApplicationGatewayBackendHealthHttpSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationGatewayBackendHealthHttpSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ApplicationGatewayBackendHealthHttpSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(BackendHttpSettings))
            {
                writer.WritePropertyName("backendHttpSettings"u8);
                writer.WriteObjectValue(BackendHttpSettings);
            }
            if (Optional.IsCollectionDefined(Servers))
            {
                writer.WritePropertyName("servers"u8);
                writer.WriteStartArray();
                foreach (var item in Servers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        ApplicationGatewayBackendHealthHttpSettings IJsonModel<ApplicationGatewayBackendHealthHttpSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationGatewayBackendHealthHttpSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ApplicationGatewayBackendHealthHttpSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApplicationGatewayBackendHealthHttpSettings(document.RootElement, options);
        }

        internal static ApplicationGatewayBackendHealthHttpSettings DeserializeApplicationGatewayBackendHealthHttpSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ApplicationGatewayBackendHttpSettings> backendHttpSettings = default;
            Optional<IReadOnlyList<ApplicationGatewayBackendHealthServer>> servers = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("backendHttpSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backendHttpSettings = ApplicationGatewayBackendHttpSettings.DeserializeApplicationGatewayBackendHttpSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("servers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ApplicationGatewayBackendHealthServer> array = new List<ApplicationGatewayBackendHealthServer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ApplicationGatewayBackendHealthServer.DeserializeApplicationGatewayBackendHealthServer(item));
                    }
                    servers = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ApplicationGatewayBackendHealthHttpSettings(backendHttpSettings.Value, Optional.ToList(servers), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ApplicationGatewayBackendHealthHttpSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationGatewayBackendHealthHttpSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(ApplicationGatewayBackendHealthHttpSettings)} does not support '{options.Format}' format.");
            }
        }

        ApplicationGatewayBackendHealthHttpSettings IPersistableModel<ApplicationGatewayBackendHealthHttpSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationGatewayBackendHealthHttpSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeApplicationGatewayBackendHealthHttpSettings(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(ApplicationGatewayBackendHealthHttpSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApplicationGatewayBackendHealthHttpSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
