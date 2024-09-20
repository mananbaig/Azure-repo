// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.LabServices.Models
{
    public partial class LabVirtualMachineConnectionProfile : IUtf8JsonSerializable, IJsonModel<LabVirtualMachineConnectionProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LabVirtualMachineConnectionProfile>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<LabVirtualMachineConnectionProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LabVirtualMachineConnectionProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LabVirtualMachineConnectionProfile)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(PrivateIPAddress))
            {
                writer.WritePropertyName("privateIpAddress"u8);
                writer.WriteStringValue(PrivateIPAddress.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(SshAuthority))
            {
                writer.WritePropertyName("sshAuthority"u8);
                writer.WriteStringValue(SshAuthority);
            }
            if (options.Format != "W" && Optional.IsDefined(SshInBrowserUri))
            {
                writer.WritePropertyName("sshInBrowserUrl"u8);
                writer.WriteStringValue(SshInBrowserUri.AbsoluteUri);
            }
            if (options.Format != "W" && Optional.IsDefined(RdpAuthority))
            {
                writer.WritePropertyName("rdpAuthority"u8);
                writer.WriteStringValue(RdpAuthority);
            }
            if (options.Format != "W" && Optional.IsDefined(RdpInBrowserUri))
            {
                writer.WritePropertyName("rdpInBrowserUrl"u8);
                writer.WriteStringValue(RdpInBrowserUri.AbsoluteUri);
            }
            if (options.Format != "W" && Optional.IsDefined(AdminUsername))
            {
                writer.WritePropertyName("adminUsername"u8);
                writer.WriteStringValue(AdminUsername);
            }
            if (options.Format != "W" && Optional.IsDefined(NonAdminUsername))
            {
                writer.WritePropertyName("nonAdminUsername"u8);
                writer.WriteStringValue(NonAdminUsername);
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

        LabVirtualMachineConnectionProfile IJsonModel<LabVirtualMachineConnectionProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LabVirtualMachineConnectionProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LabVirtualMachineConnectionProfile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLabVirtualMachineConnectionProfile(document.RootElement, options);
        }

        internal static LabVirtualMachineConnectionProfile DeserializeLabVirtualMachineConnectionProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IPAddress privateIPAddress = default;
            string sshAuthority = default;
            Uri sshInBrowserUrl = default;
            string rdpAuthority = default;
            Uri rdpInBrowserUrl = default;
            string adminUsername = default;
            string nonAdminUsername = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("privateIpAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    privateIPAddress = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sshAuthority"u8))
                {
                    sshAuthority = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sshInBrowserUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sshInBrowserUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("rdpAuthority"u8))
                {
                    rdpAuthority = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rdpInBrowserUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rdpInBrowserUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("adminUsername"u8))
                {
                    adminUsername = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("nonAdminUsername"u8))
                {
                    nonAdminUsername = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new LabVirtualMachineConnectionProfile(
                privateIPAddress,
                sshAuthority,
                sshInBrowserUrl,
                rdpAuthority,
                rdpInBrowserUrl,
                adminUsername,
                nonAdminUsername,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LabVirtualMachineConnectionProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LabVirtualMachineConnectionProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LabVirtualMachineConnectionProfile)} does not support writing '{options.Format}' format.");
            }
        }

        LabVirtualMachineConnectionProfile IPersistableModel<LabVirtualMachineConnectionProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LabVirtualMachineConnectionProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLabVirtualMachineConnectionProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LabVirtualMachineConnectionProfile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<LabVirtualMachineConnectionProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
