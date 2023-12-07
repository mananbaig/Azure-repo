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

namespace Azure.ResourceManager.DeviceUpdate.Models
{
    public partial class DeviceUpdateRemotePrivateEndpoint : IUtf8JsonSerializable, IJsonModel<DeviceUpdateRemotePrivateEndpoint>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DeviceUpdateRemotePrivateEndpoint>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DeviceUpdateRemotePrivateEndpoint>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeviceUpdateRemotePrivateEndpoint>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(DeviceUpdateRemotePrivateEndpoint)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            if (Optional.IsDefined(ImmutableSubscriptionId))
            {
                writer.WritePropertyName("immutableSubscriptionId"u8);
                writer.WriteStringValue(ImmutableSubscriptionId);
            }
            if (Optional.IsDefined(ImmutableResourceId))
            {
                writer.WritePropertyName("immutableResourceId"u8);
                writer.WriteStringValue(ImmutableResourceId);
            }
            if (Optional.IsDefined(VnetTrafficTag))
            {
                writer.WritePropertyName("vnetTrafficTag"u8);
                writer.WriteStringValue(VnetTrafficTag);
            }
            if (Optional.IsCollectionDefined(ManualPrivateLinkServiceConnections))
            {
                writer.WritePropertyName("manualPrivateLinkServiceConnections"u8);
                writer.WriteStartArray();
                foreach (var item in ManualPrivateLinkServiceConnections)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(PrivateLinkServiceConnections))
            {
                writer.WritePropertyName("privateLinkServiceConnections"u8);
                writer.WriteStartArray();
                foreach (var item in PrivateLinkServiceConnections)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(PrivateLinkServiceProxies))
            {
                writer.WritePropertyName("privateLinkServiceProxies"u8);
                writer.WriteStartArray();
                foreach (var item in PrivateLinkServiceProxies)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ConnectionDetails))
            {
                writer.WritePropertyName("connectionDetails"u8);
                writer.WriteStartArray();
                foreach (var item in ConnectionDetails)
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

        DeviceUpdateRemotePrivateEndpoint IJsonModel<DeviceUpdateRemotePrivateEndpoint>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeviceUpdateRemotePrivateEndpoint>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(DeviceUpdateRemotePrivateEndpoint)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDeviceUpdateRemotePrivateEndpoint(document.RootElement, options);
        }

        internal static DeviceUpdateRemotePrivateEndpoint DeserializeDeviceUpdateRemotePrivateEndpoint(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> id = default;
            Optional<AzureLocation> location = default;
            Optional<string> immutableSubscriptionId = default;
            Optional<ResourceIdentifier> immutableResourceId = default;
            Optional<string> vnetTrafficTag = default;
            Optional<IList<DeviceUpdatePrivateLinkServiceConnection>> manualPrivateLinkServiceConnections = default;
            Optional<IList<DeviceUpdatePrivateLinkServiceConnection>> privateLinkServiceConnections = default;
            Optional<IList<DeviceUpdatePrivateLinkServiceProxy>> privateLinkServiceProxies = default;
            Optional<IList<DeviceUpdatePrivateEndpointConnectionDetails>> connectionDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("immutableSubscriptionId"u8))
                {
                    immutableSubscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("immutableResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    immutableResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("vnetTrafficTag"u8))
                {
                    vnetTrafficTag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("manualPrivateLinkServiceConnections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DeviceUpdatePrivateLinkServiceConnection> array = new List<DeviceUpdatePrivateLinkServiceConnection>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeviceUpdatePrivateLinkServiceConnection.DeserializeDeviceUpdatePrivateLinkServiceConnection(item));
                    }
                    manualPrivateLinkServiceConnections = array;
                    continue;
                }
                if (property.NameEquals("privateLinkServiceConnections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DeviceUpdatePrivateLinkServiceConnection> array = new List<DeviceUpdatePrivateLinkServiceConnection>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeviceUpdatePrivateLinkServiceConnection.DeserializeDeviceUpdatePrivateLinkServiceConnection(item));
                    }
                    privateLinkServiceConnections = array;
                    continue;
                }
                if (property.NameEquals("privateLinkServiceProxies"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DeviceUpdatePrivateLinkServiceProxy> array = new List<DeviceUpdatePrivateLinkServiceProxy>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeviceUpdatePrivateLinkServiceProxy.DeserializeDeviceUpdatePrivateLinkServiceProxy(item));
                    }
                    privateLinkServiceProxies = array;
                    continue;
                }
                if (property.NameEquals("connectionDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DeviceUpdatePrivateEndpointConnectionDetails> array = new List<DeviceUpdatePrivateEndpointConnectionDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeviceUpdatePrivateEndpointConnectionDetails.DeserializeDeviceUpdatePrivateEndpointConnectionDetails(item));
                    }
                    connectionDetails = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DeviceUpdateRemotePrivateEndpoint(id.Value, Optional.ToNullable(location), immutableSubscriptionId.Value, immutableResourceId.Value, vnetTrafficTag.Value, Optional.ToList(manualPrivateLinkServiceConnections), Optional.ToList(privateLinkServiceConnections), Optional.ToList(privateLinkServiceProxies), Optional.ToList(connectionDetails), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DeviceUpdateRemotePrivateEndpoint>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeviceUpdateRemotePrivateEndpoint>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(DeviceUpdateRemotePrivateEndpoint)} does not support '{options.Format}' format.");
            }
        }

        DeviceUpdateRemotePrivateEndpoint IPersistableModel<DeviceUpdateRemotePrivateEndpoint>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeviceUpdateRemotePrivateEndpoint>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDeviceUpdateRemotePrivateEndpoint(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(DeviceUpdateRemotePrivateEndpoint)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DeviceUpdateRemotePrivateEndpoint>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
