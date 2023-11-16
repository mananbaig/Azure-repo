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
using Azure.ResourceManager.Models;
using Azure.ResourceManager.NetworkCloud.Models;

namespace Azure.ResourceManager.NetworkCloud
{
    public partial class NetworkCloudL3NetworkData : IUtf8JsonSerializable, IJsonModel<NetworkCloudL3NetworkData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkCloudL3NetworkData>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<NetworkCloudL3NetworkData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<NetworkCloudL3NetworkData>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<NetworkCloudL3NetworkData>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("extendedLocation"u8);
            writer.WriteObjectValue(ExtendedLocation);
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            if (options.Format == "J")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format == "J")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format == "J")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(SystemData))
                {
                    writer.WritePropertyName("systemData"u8);
                    JsonSerializer.Serialize(writer, SystemData);
                }
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format == "J")
            {
                if (Optional.IsCollectionDefined(AssociatedResourceIds))
                {
                    writer.WritePropertyName("associatedResourceIds"u8);
                    writer.WriteStartArray();
                    foreach (var item in AssociatedResourceIds)
                    {
                        if (item == null)
                        {
                            writer.WriteNullValue();
                            continue;
                        }
                        writer.WriteStringValue(item);
                    }
                    writer.WriteEndArray();
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ClusterId))
                {
                    writer.WritePropertyName("clusterId"u8);
                    writer.WriteStringValue(ClusterId);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(DetailedStatus))
                {
                    writer.WritePropertyName("detailedStatus"u8);
                    writer.WriteStringValue(DetailedStatus.Value.ToString());
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(DetailedStatusMessage))
                {
                    writer.WritePropertyName("detailedStatusMessage"u8);
                    writer.WriteStringValue(DetailedStatusMessage);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsCollectionDefined(HybridAksClustersAssociatedIds))
                {
                    writer.WritePropertyName("hybridAksClustersAssociatedIds"u8);
                    writer.WriteStartArray();
                    foreach (var item in HybridAksClustersAssociatedIds)
                    {
                        if (item == null)
                        {
                            writer.WriteNullValue();
                            continue;
                        }
                        writer.WriteStringValue(item);
                    }
                    writer.WriteEndArray();
                }
            }
            if (Optional.IsDefined(HybridAksIpamEnabled))
            {
                writer.WritePropertyName("hybridAksIpamEnabled"u8);
                writer.WriteStringValue(HybridAksIpamEnabled.Value.ToString());
            }
            if (Optional.IsDefined(HybridAksPluginType))
            {
                writer.WritePropertyName("hybridAksPluginType"u8);
                writer.WriteStringValue(HybridAksPluginType.Value.ToString());
            }
            if (Optional.IsDefined(InterfaceName))
            {
                writer.WritePropertyName("interfaceName"u8);
                writer.WriteStringValue(InterfaceName);
            }
            if (Optional.IsDefined(IPAllocationType))
            {
                writer.WritePropertyName("ipAllocationType"u8);
                writer.WriteStringValue(IPAllocationType.Value.ToString());
            }
            if (Optional.IsDefined(IPv4ConnectedPrefix))
            {
                writer.WritePropertyName("ipv4ConnectedPrefix"u8);
                writer.WriteStringValue(IPv4ConnectedPrefix);
            }
            if (Optional.IsDefined(IPv6ConnectedPrefix))
            {
                writer.WritePropertyName("ipv6ConnectedPrefix"u8);
                writer.WriteStringValue(IPv6ConnectedPrefix);
            }
            writer.WritePropertyName("l3IsolationDomainId"u8);
            writer.WriteStringValue(L3IsolationDomainId);
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ProvisioningState))
                {
                    writer.WritePropertyName("provisioningState"u8);
                    writer.WriteStringValue(ProvisioningState.Value.ToString());
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsCollectionDefined(VirtualMachinesAssociatedIds))
                {
                    writer.WritePropertyName("virtualMachinesAssociatedIds"u8);
                    writer.WriteStartArray();
                    foreach (var item in VirtualMachinesAssociatedIds)
                    {
                        if (item == null)
                        {
                            writer.WriteNullValue();
                            continue;
                        }
                        writer.WriteStringValue(item);
                    }
                    writer.WriteEndArray();
                }
            }
            writer.WritePropertyName("vlan"u8);
            writer.WriteNumberValue(Vlan);
            writer.WriteEndObject();
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

        NetworkCloudL3NetworkData IJsonModel<NetworkCloudL3NetworkData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NetworkCloudL3NetworkData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkCloudL3NetworkData(document.RootElement, options);
        }

        internal static NetworkCloudL3NetworkData DeserializeNetworkCloudL3NetworkData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ExtendedLocation extendedLocation = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<IReadOnlyList<ResourceIdentifier>> associatedResourceIds = default;
            Optional<ResourceIdentifier> clusterId = default;
            Optional<L3NetworkDetailedStatus> detailedStatus = default;
            Optional<string> detailedStatusMessage = default;
            Optional<IReadOnlyList<ResourceIdentifier>> hybridAksClustersAssociatedIds = default;
            Optional<HybridAksIpamEnabled> hybridAksIpamEnabled = default;
            Optional<HybridAksPluginType> hybridAksPluginType = default;
            Optional<string> interfaceName = default;
            Optional<IPAllocationType> ipAllocationType = default;
            Optional<string> ipv4ConnectedPrefix = default;
            Optional<string> ipv6ConnectedPrefix = default;
            ResourceIdentifier l3IsolationDomainId = default;
            Optional<L3NetworkProvisioningState> provisioningState = default;
            Optional<IReadOnlyList<ResourceIdentifier>> virtualMachinesAssociatedIds = default;
            long vlan = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("extendedLocation"u8))
                {
                    extendedLocation = ExtendedLocation.DeserializeExtendedLocation(property.Value);
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("associatedResourceIds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ResourceIdentifier> array = new List<ResourceIdentifier>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(new ResourceIdentifier(item.GetString()));
                                }
                            }
                            associatedResourceIds = array;
                            continue;
                        }
                        if (property0.NameEquals("clusterId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("detailedStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            detailedStatus = new L3NetworkDetailedStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("detailedStatusMessage"u8))
                        {
                            detailedStatusMessage = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("hybridAksClustersAssociatedIds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ResourceIdentifier> array = new List<ResourceIdentifier>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(new ResourceIdentifier(item.GetString()));
                                }
                            }
                            hybridAksClustersAssociatedIds = array;
                            continue;
                        }
                        if (property0.NameEquals("hybridAksIpamEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hybridAksIpamEnabled = new HybridAksIpamEnabled(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("hybridAksPluginType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hybridAksPluginType = new HybridAksPluginType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("interfaceName"u8))
                        {
                            interfaceName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ipAllocationType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ipAllocationType = new IPAllocationType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("ipv4ConnectedPrefix"u8))
                        {
                            ipv4ConnectedPrefix = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ipv6ConnectedPrefix"u8))
                        {
                            ipv6ConnectedPrefix = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("l3IsolationDomainId"u8))
                        {
                            l3IsolationDomainId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new L3NetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("virtualMachinesAssociatedIds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ResourceIdentifier> array = new List<ResourceIdentifier>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(new ResourceIdentifier(item.GetString()));
                                }
                            }
                            virtualMachinesAssociatedIds = array;
                            continue;
                        }
                        if (property0.NameEquals("vlan"u8))
                        {
                            vlan = property0.Value.GetInt64();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NetworkCloudL3NetworkData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, extendedLocation, Optional.ToList(associatedResourceIds), clusterId.Value, Optional.ToNullable(detailedStatus), detailedStatusMessage.Value, Optional.ToList(hybridAksClustersAssociatedIds), Optional.ToNullable(hybridAksIpamEnabled), Optional.ToNullable(hybridAksPluginType), interfaceName.Value, Optional.ToNullable(ipAllocationType), ipv4ConnectedPrefix.Value, ipv6ConnectedPrefix.Value, l3IsolationDomainId, Optional.ToNullable(provisioningState), Optional.ToList(virtualMachinesAssociatedIds), vlan, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetworkCloudL3NetworkData>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NetworkCloudL3NetworkData)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        NetworkCloudL3NetworkData IPersistableModel<NetworkCloudL3NetworkData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NetworkCloudL3NetworkData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeNetworkCloudL3NetworkData(document.RootElement, options);
        }

        string IPersistableModel<NetworkCloudL3NetworkData>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
