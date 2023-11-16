// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    public partial class FirewallDnsSettings : IUtf8JsonSerializable, IJsonModel<FirewallDnsSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FirewallDnsSettings>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<FirewallDnsSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<FirewallDnsSettings>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<FirewallDnsSettings>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(EnableDnsProxy))
            {
                writer.WritePropertyName("enableDnsProxy"u8);
                writer.WriteStringValue(EnableDnsProxy.Value.ToString());
            }
            if (Optional.IsDefined(EnabledDnsType))
            {
                writer.WritePropertyName("enabledDnsType"u8);
                writer.WriteStringValue(EnabledDnsType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(DnsServers))
            {
                writer.WritePropertyName("dnsServers"u8);
                writer.WriteStartArray();
                foreach (var item in DnsServers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (_serializedAdditionalRawData != null && options.Format == "J")
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

        FirewallDnsSettings IJsonModel<FirewallDnsSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(FirewallDnsSettings)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFirewallDnsSettings(document.RootElement, options);
        }

        internal static FirewallDnsSettings DeserializeFirewallDnsSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AllowDnsProxyType> enableDnsProxy = default;
            Optional<EnabledDnsType> enabledDnsType = default;
            Optional<IList<IPAddressInfo>> dnsServers = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enableDnsProxy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableDnsProxy = new AllowDnsProxyType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("enabledDnsType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabledDnsType = new EnabledDnsType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dnsServers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IPAddressInfo> array = new List<IPAddressInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IPAddressInfo.DeserializeIPAddressInfo(item));
                    }
                    dnsServers = array;
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FirewallDnsSettings(Optional.ToNullable(enableDnsProxy), Optional.ToNullable(enabledDnsType), Optional.ToList(dnsServers), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FirewallDnsSettings>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(FirewallDnsSettings)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        FirewallDnsSettings IPersistableModel<FirewallDnsSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(FirewallDnsSettings)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeFirewallDnsSettings(document.RootElement, options);
        }

        string IPersistableModel<FirewallDnsSettings>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
