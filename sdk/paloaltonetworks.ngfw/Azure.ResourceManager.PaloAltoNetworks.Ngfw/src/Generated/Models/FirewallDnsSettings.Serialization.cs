// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    public partial class FirewallDnsSettings : IUtf8JsonSerializable, IJsonModel<FirewallDnsSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FirewallDnsSettings>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<FirewallDnsSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallDnsSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FirewallDnsSettings)} does not support writing '{format}' format.");
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
                    writer.WriteObjectValue(item, options);
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

        FirewallDnsSettings IJsonModel<FirewallDnsSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallDnsSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FirewallDnsSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFirewallDnsSettings(document.RootElement, options);
        }

        internal static FirewallDnsSettings DeserializeFirewallDnsSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AllowDnsProxyType? enableDnsProxy = default;
            EnabledDnsType? enabledDnsType = default;
            IList<IPAddressInfo> dnsServers = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
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
                        array.Add(IPAddressInfo.DeserializeIPAddressInfo(item, options));
                    }
                    dnsServers = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new FirewallDnsSettings(enableDnsProxy, enabledDnsType, dnsServers ?? new ChangeTrackingList<IPAddressInfo>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FirewallDnsSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallDnsSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FirewallDnsSettings)} does not support writing '{options.Format}' format.");
            }
        }

        FirewallDnsSettings IPersistableModel<FirewallDnsSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallDnsSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFirewallDnsSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FirewallDnsSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FirewallDnsSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
