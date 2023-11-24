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
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.DeviceProvisioningServices.Models
{
    public partial class DeviceProvisioningServicesPrivateEndpointConnectionProperties : IUtf8JsonSerializable, IJsonModel<DeviceProvisioningServicesPrivateEndpointConnectionProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DeviceProvisioningServicesPrivateEndpointConnectionProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DeviceProvisioningServicesPrivateEndpointConnectionProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeviceProvisioningServicesPrivateEndpointConnectionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(DeviceProvisioningServicesPrivateEndpointConnectionProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(PrivateEndpoint))
            {
                writer.WritePropertyName("privateEndpoint"u8);
                JsonSerializer.Serialize(writer, PrivateEndpoint);
            }
            writer.WritePropertyName("privateLinkServiceConnectionState"u8);
            writer.WriteObjectValue(ConnectionState);
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

        DeviceProvisioningServicesPrivateEndpointConnectionProperties IJsonModel<DeviceProvisioningServicesPrivateEndpointConnectionProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeviceProvisioningServicesPrivateEndpointConnectionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(DeviceProvisioningServicesPrivateEndpointConnectionProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDeviceProvisioningServicesPrivateEndpointConnectionProperties(document.RootElement, options);
        }

        internal static DeviceProvisioningServicesPrivateEndpointConnectionProperties DeserializeDeviceProvisioningServicesPrivateEndpointConnectionProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SubResource> privateEndpoint = default;
            DeviceProvisioningServicesPrivateLinkServiceConnectionState privateLinkServiceConnectionState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("privateEndpoint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    privateEndpoint = JsonSerializer.Deserialize<SubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("privateLinkServiceConnectionState"u8))
                {
                    privateLinkServiceConnectionState = DeviceProvisioningServicesPrivateLinkServiceConnectionState.DeserializeDeviceProvisioningServicesPrivateLinkServiceConnectionState(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DeviceProvisioningServicesPrivateEndpointConnectionProperties(privateEndpoint, privateLinkServiceConnectionState, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DeviceProvisioningServicesPrivateEndpointConnectionProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeviceProvisioningServicesPrivateEndpointConnectionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(DeviceProvisioningServicesPrivateEndpointConnectionProperties)} does not support '{options.Format}' format.");
            }
        }

        DeviceProvisioningServicesPrivateEndpointConnectionProperties IPersistableModel<DeviceProvisioningServicesPrivateEndpointConnectionProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeviceProvisioningServicesPrivateEndpointConnectionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDeviceProvisioningServicesPrivateEndpointConnectionProperties(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(DeviceProvisioningServicesPrivateEndpointConnectionProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DeviceProvisioningServicesPrivateEndpointConnectionProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
