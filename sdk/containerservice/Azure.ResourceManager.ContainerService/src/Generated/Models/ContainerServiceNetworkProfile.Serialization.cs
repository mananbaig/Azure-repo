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

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ContainerServiceNetworkProfile : IUtf8JsonSerializable, IJsonModel<ContainerServiceNetworkProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerServiceNetworkProfile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerServiceNetworkProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceNetworkProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ContainerServiceNetworkProfile)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(NetworkPlugin))
            {
                writer.WritePropertyName("networkPlugin"u8);
                writer.WriteStringValue(NetworkPlugin.Value.ToString());
            }
            if (Optional.IsDefined(NetworkPluginMode))
            {
                writer.WritePropertyName("networkPluginMode"u8);
                writer.WriteStringValue(NetworkPluginMode.Value.ToString());
            }
            if (Optional.IsDefined(NetworkPolicy))
            {
                writer.WritePropertyName("networkPolicy"u8);
                writer.WriteStringValue(NetworkPolicy.Value.ToString());
            }
            if (Optional.IsDefined(NetworkMode))
            {
                writer.WritePropertyName("networkMode"u8);
                writer.WriteStringValue(NetworkMode.Value.ToString());
            }
            if (Optional.IsDefined(EbpfDataplane))
            {
                writer.WritePropertyName("ebpfDataplane"u8);
                writer.WriteStringValue(EbpfDataplane.Value.ToString());
            }
            if (Optional.IsDefined(PodCidr))
            {
                writer.WritePropertyName("podCidr"u8);
                writer.WriteStringValue(PodCidr);
            }
            if (Optional.IsDefined(ServiceCidr))
            {
                writer.WritePropertyName("serviceCidr"u8);
                writer.WriteStringValue(ServiceCidr);
            }
            if (Optional.IsDefined(DnsServiceIP))
            {
                writer.WritePropertyName("dnsServiceIP"u8);
                writer.WriteStringValue(DnsServiceIP);
            }
            if (Optional.IsDefined(DockerBridgeCidr))
            {
                writer.WritePropertyName("dockerBridgeCidr"u8);
                writer.WriteStringValue(DockerBridgeCidr);
            }
            if (Optional.IsDefined(OutboundType))
            {
                writer.WritePropertyName("outboundType"u8);
                writer.WriteStringValue(OutboundType.Value.ToString());
            }
            if (Optional.IsDefined(LoadBalancerSku))
            {
                writer.WritePropertyName("loadBalancerSku"u8);
                writer.WriteStringValue(LoadBalancerSku.Value.ToString());
            }
            if (Optional.IsDefined(LoadBalancerProfile))
            {
                writer.WritePropertyName("loadBalancerProfile"u8);
                writer.WriteObjectValue(LoadBalancerProfile);
            }
            if (Optional.IsDefined(NatGatewayProfile))
            {
                writer.WritePropertyName("natGatewayProfile"u8);
                writer.WriteObjectValue(NatGatewayProfile);
            }
            if (Optional.IsCollectionDefined(PodCidrs))
            {
                writer.WritePropertyName("podCidrs"u8);
                writer.WriteStartArray();
                foreach (var item in PodCidrs)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ServiceCidrs))
            {
                writer.WritePropertyName("serviceCidrs"u8);
                writer.WriteStartArray();
                foreach (var item in ServiceCidrs)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(IPFamilies))
            {
                writer.WritePropertyName("ipFamilies"u8);
                writer.WriteStartArray();
                foreach (var item in IPFamilies)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(KubeProxyConfig))
            {
                writer.WritePropertyName("kubeProxyConfig"u8);
                writer.WriteObjectValue(KubeProxyConfig);
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

        ContainerServiceNetworkProfile IJsonModel<ContainerServiceNetworkProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceNetworkProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ContainerServiceNetworkProfile)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerServiceNetworkProfile(document.RootElement, options);
        }

        internal static ContainerServiceNetworkProfile DeserializeContainerServiceNetworkProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ContainerServiceNetworkPlugin> networkPlugin = default;
            Optional<ContainerServiceNetworkPluginMode> networkPluginMode = default;
            Optional<ContainerServiceNetworkPolicy> networkPolicy = default;
            Optional<ContainerServiceNetworkMode> networkMode = default;
            Optional<EbpfDataplane> ebpfDataplane = default;
            Optional<string> podCidr = default;
            Optional<string> serviceCidr = default;
            Optional<string> dnsServiceIP = default;
            Optional<string> dockerBridgeCidr = default;
            Optional<ContainerServiceOutboundType> outboundType = default;
            Optional<ContainerServiceLoadBalancerSku> loadBalancerSku = default;
            Optional<ManagedClusterLoadBalancerProfile> loadBalancerProfile = default;
            Optional<ManagedClusterNatGatewayProfile> natGatewayProfile = default;
            Optional<IList<string>> podCidrs = default;
            Optional<IList<string>> serviceCidrs = default;
            Optional<IList<IPFamily>> ipFamilies = default;
            Optional<ContainerServiceNetworkProfileKubeProxyConfig> kubeProxyConfig = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("networkPlugin"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkPlugin = new ContainerServiceNetworkPlugin(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("networkPluginMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkPluginMode = new ContainerServiceNetworkPluginMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("networkPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkPolicy = new ContainerServiceNetworkPolicy(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("networkMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkMode = new ContainerServiceNetworkMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ebpfDataplane"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ebpfDataplane = new EbpfDataplane(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("podCidr"u8))
                {
                    podCidr = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serviceCidr"u8))
                {
                    serviceCidr = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dnsServiceIP"u8))
                {
                    dnsServiceIP = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dockerBridgeCidr"u8))
                {
                    dockerBridgeCidr = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("outboundType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    outboundType = new ContainerServiceOutboundType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("loadBalancerSku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    loadBalancerSku = new ContainerServiceLoadBalancerSku(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("loadBalancerProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    loadBalancerProfile = ManagedClusterLoadBalancerProfile.DeserializeManagedClusterLoadBalancerProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("natGatewayProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    natGatewayProfile = ManagedClusterNatGatewayProfile.DeserializeManagedClusterNatGatewayProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("podCidrs"u8))
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
                    podCidrs = array;
                    continue;
                }
                if (property.NameEquals("serviceCidrs"u8))
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
                    serviceCidrs = array;
                    continue;
                }
                if (property.NameEquals("ipFamilies"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IPFamily> array = new List<IPFamily>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new IPFamily(item.GetString()));
                    }
                    ipFamilies = array;
                    continue;
                }
                if (property.NameEquals("kubeProxyConfig"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kubeProxyConfig = ContainerServiceNetworkProfileKubeProxyConfig.DeserializeContainerServiceNetworkProfileKubeProxyConfig(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerServiceNetworkProfile(Optional.ToNullable(networkPlugin), Optional.ToNullable(networkPluginMode), Optional.ToNullable(networkPolicy), Optional.ToNullable(networkMode), Optional.ToNullable(ebpfDataplane), podCidr.Value, serviceCidr.Value, dnsServiceIP.Value, dockerBridgeCidr.Value, Optional.ToNullable(outboundType), Optional.ToNullable(loadBalancerSku), loadBalancerProfile.Value, natGatewayProfile.Value, Optional.ToList(podCidrs), Optional.ToList(serviceCidrs), Optional.ToList(ipFamilies), kubeProxyConfig.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerServiceNetworkProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceNetworkProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(ContainerServiceNetworkProfile)} does not support '{options.Format}' format.");
            }
        }

        ContainerServiceNetworkProfile IPersistableModel<ContainerServiceNetworkProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceNetworkProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerServiceNetworkProfile(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(ContainerServiceNetworkProfile)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerServiceNetworkProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
