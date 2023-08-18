// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ManagedNetworkFabric.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    public partial class NetworkFabricData : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsCollectionDefined(Tags))
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
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Annotation))
            {
                writer.WritePropertyName("annotation"u8);
                writer.WriteStringValue(Annotation);
            }
            writer.WritePropertyName("networkFabricSku"u8);
            writer.WriteStringValue(NetworkFabricSku);
            writer.WritePropertyName("networkFabricControllerId"u8);
            writer.WriteStringValue(NetworkFabricControllerId);
            if (Core.Optional.IsDefined(RackCount))
            {
                writer.WritePropertyName("rackCount"u8);
                writer.WriteNumberValue(RackCount.Value);
            }
            writer.WritePropertyName("serverCountPerRack"u8);
            writer.WriteNumberValue(ServerCountPerRack);
            writer.WritePropertyName("ipv4Prefix"u8);
            writer.WriteStringValue(IPv4Prefix);
            if (Core.Optional.IsDefined(IPv6Prefix))
            {
                writer.WritePropertyName("ipv6Prefix"u8);
                writer.WriteStringValue(IPv6Prefix);
            }
            writer.WritePropertyName("fabricASN"u8);
            writer.WriteNumberValue(FabricAsn);
            writer.WritePropertyName("terminalServerConfiguration"u8);
            writer.WriteObjectValue(TerminalServerConfiguration);
            writer.WritePropertyName("managementNetworkConfiguration"u8);
            writer.WriteObjectValue(ManagementNetworkConfiguration);
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static NetworkFabricData DeserializeNetworkFabricData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Core.Optional<SystemData> systemData = default;
            Core.Optional<string> annotation = default;
            string networkFabricSku = default;
            Core.Optional<string> fabricVersion = default;
            Core.Optional<IReadOnlyList<string>> routerIds = default;
            ResourceIdentifier networkFabricControllerId = default;
            Core.Optional<int> rackCount = default;
            int serverCountPerRack = default;
            string ipv4Prefix = default;
            Core.Optional<string> ipv6Prefix = default;
            long fabricAsn = default;
            TerminalServerConfiguration terminalServerConfiguration = default;
            ManagementNetworkConfigurationProperties managementNetworkConfiguration = default;
            Core.Optional<IReadOnlyList<string>> racks = default;
            Core.Optional<IReadOnlyList<string>> l2IsolationDomains = default;
            Core.Optional<IReadOnlyList<string>> l3IsolationDomains = default;
            Core.Optional<NetworkFabricConfigurationState> configurationState = default;
            Core.Optional<NetworkFabricProvisioningState> provisioningState = default;
            Core.Optional<NetworkFabricAdministrativeState> administrativeState = default;
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("annotation"u8))
                        {
                            annotation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("networkFabricSku"u8))
                        {
                            networkFabricSku = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("fabricVersion"u8))
                        {
                            fabricVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("routerIds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            routerIds = array;
                            continue;
                        }
                        if (property0.NameEquals("networkFabricControllerId"u8))
                        {
                            networkFabricControllerId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("rackCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            rackCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("serverCountPerRack"u8))
                        {
                            serverCountPerRack = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("ipv4Prefix"u8))
                        {
                            ipv4Prefix = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ipv6Prefix"u8))
                        {
                            ipv6Prefix = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("fabricASN"u8))
                        {
                            fabricAsn = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("terminalServerConfiguration"u8))
                        {
                            terminalServerConfiguration = TerminalServerConfiguration.DeserializeTerminalServerConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("managementNetworkConfiguration"u8))
                        {
                            managementNetworkConfiguration = ManagementNetworkConfigurationProperties.DeserializeManagementNetworkConfigurationProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("racks"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            racks = array;
                            continue;
                        }
                        if (property0.NameEquals("l2IsolationDomains"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            l2IsolationDomains = array;
                            continue;
                        }
                        if (property0.NameEquals("l3IsolationDomains"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            l3IsolationDomains = array;
                            continue;
                        }
                        if (property0.NameEquals("configurationState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            configurationState = new NetworkFabricConfigurationState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkFabricProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("administrativeState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            administrativeState = new NetworkFabricAdministrativeState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new NetworkFabricData(id, name, type, systemData.Value, Core.Optional.ToDictionary(tags), location, annotation.Value, networkFabricSku, fabricVersion.Value, Core.Optional.ToList(routerIds), networkFabricControllerId, Core.Optional.ToNullable(rackCount), serverCountPerRack, ipv4Prefix, ipv6Prefix.Value, fabricAsn, terminalServerConfiguration, managementNetworkConfiguration, Core.Optional.ToList(racks), Core.Optional.ToList(l2IsolationDomains), Core.Optional.ToList(l3IsolationDomains), Core.Optional.ToNullable(configurationState), Core.Optional.ToNullable(provisioningState), Core.Optional.ToNullable(administrativeState));
        }
    }
}
