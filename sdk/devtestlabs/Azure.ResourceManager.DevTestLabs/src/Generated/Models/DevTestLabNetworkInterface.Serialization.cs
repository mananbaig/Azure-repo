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

namespace Azure.ResourceManager.DevTestLabs.Models
{
    public partial class DevTestLabNetworkInterface : IUtf8JsonSerializable, IJsonModel<DevTestLabNetworkInterface>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DevTestLabNetworkInterface>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DevTestLabNetworkInterface>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabNetworkInterface>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(DevTestLabNetworkInterface)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(VirtualNetworkId))
            {
                writer.WritePropertyName("virtualNetworkId"u8);
                writer.WriteStringValue(VirtualNetworkId);
            }
            if (Optional.IsDefined(SubnetId))
            {
                writer.WritePropertyName("subnetId"u8);
                writer.WriteStringValue(SubnetId);
            }
            if (Optional.IsDefined(PublicIPAddressId))
            {
                writer.WritePropertyName("publicIpAddressId"u8);
                writer.WriteStringValue(PublicIPAddressId);
            }
            if (Optional.IsDefined(PublicIPAddress))
            {
                writer.WritePropertyName("publicIpAddress"u8);
                writer.WriteStringValue(PublicIPAddress);
            }
            if (Optional.IsDefined(PrivateIPAddress))
            {
                writer.WritePropertyName("privateIpAddress"u8);
                writer.WriteStringValue(PrivateIPAddress);
            }
            if (Optional.IsDefined(DnsName))
            {
                writer.WritePropertyName("dnsName"u8);
                writer.WriteStringValue(DnsName);
            }
            if (Optional.IsDefined(RdpAuthority))
            {
                writer.WritePropertyName("rdpAuthority"u8);
                writer.WriteStringValue(RdpAuthority);
            }
            if (Optional.IsDefined(SshAuthority))
            {
                writer.WritePropertyName("sshAuthority"u8);
                writer.WriteStringValue(SshAuthority);
            }
            if (Optional.IsDefined(SharedPublicIPAddressConfiguration))
            {
                writer.WritePropertyName("sharedPublicIpAddressConfiguration"u8);
                writer.WriteObjectValue(SharedPublicIPAddressConfiguration);
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

        DevTestLabNetworkInterface IJsonModel<DevTestLabNetworkInterface>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabNetworkInterface>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(DevTestLabNetworkInterface)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDevTestLabNetworkInterface(document.RootElement, options);
        }

        internal static DevTestLabNetworkInterface DeserializeDevTestLabNetworkInterface(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> virtualNetworkId = default;
            Optional<ResourceIdentifier> subnetId = default;
            Optional<ResourceIdentifier> publicIPAddressId = default;
            Optional<string> publicIPAddress = default;
            Optional<string> privateIPAddress = default;
            Optional<string> dnsName = default;
            Optional<string> rdpAuthority = default;
            Optional<string> sshAuthority = default;
            Optional<SharedPublicIPAddressConfiguration> sharedPublicIPAddressConfiguration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("virtualNetworkId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    virtualNetworkId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("subnetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subnetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("publicIpAddressId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publicIPAddressId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("publicIpAddress"u8))
                {
                    publicIPAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("privateIpAddress"u8))
                {
                    privateIPAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dnsName"u8))
                {
                    dnsName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rdpAuthority"u8))
                {
                    rdpAuthority = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sshAuthority"u8))
                {
                    sshAuthority = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sharedPublicIpAddressConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sharedPublicIPAddressConfiguration = SharedPublicIPAddressConfiguration.DeserializeSharedPublicIPAddressConfiguration(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DevTestLabNetworkInterface(virtualNetworkId.Value, subnetId.Value, publicIPAddressId.Value, publicIPAddress.Value, privateIPAddress.Value, dnsName.Value, rdpAuthority.Value, sshAuthority.Value, sharedPublicIPAddressConfiguration.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DevTestLabNetworkInterface>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabNetworkInterface>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(DevTestLabNetworkInterface)} does not support '{options.Format}' format.");
            }
        }

        DevTestLabNetworkInterface IPersistableModel<DevTestLabNetworkInterface>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabNetworkInterface>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDevTestLabNetworkInterface(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(DevTestLabNetworkInterface)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DevTestLabNetworkInterface>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
