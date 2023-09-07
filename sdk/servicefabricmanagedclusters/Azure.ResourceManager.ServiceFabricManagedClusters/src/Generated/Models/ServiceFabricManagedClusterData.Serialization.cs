// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.ServiceFabricManagedClusters.Models;

namespace Azure.ResourceManager.ServiceFabricManagedClusters
{
    public partial class ServiceFabricManagedClusterData : IUtf8JsonSerializable, IModelJsonSerializable<ServiceFabricManagedClusterData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ServiceFabricManagedClusterData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ServiceFabricManagedClusterData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServiceFabricManagedClusterData>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("sku"u8);
            if (Sku is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<ServiceFabricManagedClustersSku>)Sku).Serialize(writer, options);
            }
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
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(DnsName))
            {
                writer.WritePropertyName("dnsName"u8);
                writer.WriteStringValue(DnsName);
            }
            if (Optional.IsDefined(ClientConnectionPort))
            {
                writer.WritePropertyName("clientConnectionPort"u8);
                writer.WriteNumberValue(ClientConnectionPort.Value);
            }
            if (Optional.IsDefined(HttpGatewayConnectionPort))
            {
                writer.WritePropertyName("httpGatewayConnectionPort"u8);
                writer.WriteNumberValue(HttpGatewayConnectionPort.Value);
            }
            if (Optional.IsDefined(AdminUserName))
            {
                writer.WritePropertyName("adminUserName"u8);
                writer.WriteStringValue(AdminUserName);
            }
            if (Optional.IsDefined(AdminPassword))
            {
                writer.WritePropertyName("adminPassword"u8);
                writer.WriteStringValue(AdminPassword);
            }
            if (Optional.IsCollectionDefined(LoadBalancingRules))
            {
                writer.WritePropertyName("loadBalancingRules"u8);
                writer.WriteStartArray();
                foreach (var item in LoadBalancingRules)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<ManagedClusterLoadBalancingRule>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsRdpAccessAllowed))
            {
                writer.WritePropertyName("allowRdpAccess"u8);
                writer.WriteBooleanValue(IsRdpAccessAllowed.Value);
            }
            if (Optional.IsCollectionDefined(NetworkSecurityRules))
            {
                writer.WritePropertyName("networkSecurityRules"u8);
                writer.WriteStartArray();
                foreach (var item in NetworkSecurityRules)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<ServiceFabricManagedNetworkSecurityRule>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Clients))
            {
                writer.WritePropertyName("clients"u8);
                writer.WriteStartArray();
                foreach (var item in Clients)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<ManagedClusterClientCertificate>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AzureActiveDirectory))
            {
                writer.WritePropertyName("azureActiveDirectory"u8);
                if (AzureActiveDirectory is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ManagedClusterAzureActiveDirectory>)AzureActiveDirectory).Serialize(writer, options);
                }
            }
            if (Optional.IsCollectionDefined(FabricSettings))
            {
                writer.WritePropertyName("fabricSettings"u8);
                writer.WriteStartArray();
                foreach (var item in FabricSettings)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<ClusterFabricSettingsSection>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ClusterCodeVersion))
            {
                writer.WritePropertyName("clusterCodeVersion"u8);
                writer.WriteStringValue(ClusterCodeVersion);
            }
            if (Optional.IsDefined(ClusterUpgradeMode))
            {
                writer.WritePropertyName("clusterUpgradeMode"u8);
                writer.WriteStringValue(ClusterUpgradeMode.Value.ToString());
            }
            if (Optional.IsDefined(ClusterUpgradeCadence))
            {
                writer.WritePropertyName("clusterUpgradeCadence"u8);
                writer.WriteStringValue(ClusterUpgradeCadence.Value.ToString());
            }
            if (Optional.IsCollectionDefined(AddOnFeatures))
            {
                writer.WritePropertyName("addonFeatures"u8);
                writer.WriteStartArray();
                foreach (var item in AddOnFeatures)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsAutoOSUpgradeEnabled))
            {
                writer.WritePropertyName("enableAutoOSUpgrade"u8);
                writer.WriteBooleanValue(IsAutoOSUpgradeEnabled.Value);
            }
            if (Optional.IsDefined(HasZoneResiliency))
            {
                writer.WritePropertyName("zonalResiliency"u8);
                writer.WriteBooleanValue(HasZoneResiliency.Value);
            }
            if (Optional.IsDefined(ApplicationTypeVersionsCleanupPolicy))
            {
                writer.WritePropertyName("applicationTypeVersionsCleanupPolicy"u8);
                if (ApplicationTypeVersionsCleanupPolicy is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ApplicationTypeVersionsCleanupPolicy>)ApplicationTypeVersionsCleanupPolicy).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(IsIPv6Enabled))
            {
                writer.WritePropertyName("enableIpv6"u8);
                writer.WriteBooleanValue(IsIPv6Enabled.Value);
            }
            if (Optional.IsDefined(SubnetId))
            {
                writer.WritePropertyName("subnetId"u8);
                writer.WriteStringValue(SubnetId);
            }
            if (Optional.IsCollectionDefined(IPTags))
            {
                writer.WritePropertyName("ipTags"u8);
                writer.WriteStartArray();
                foreach (var item in IPTags)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<ManagedClusterIPTag>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsServicePublicIPEnabled))
            {
                writer.WritePropertyName("enableServicePublicIP"u8);
                writer.WriteBooleanValue(IsServicePublicIPEnabled.Value);
            }
            if (Optional.IsCollectionDefined(AuxiliarySubnets))
            {
                writer.WritePropertyName("auxiliarySubnets"u8);
                writer.WriteStartArray();
                foreach (var item in AuxiliarySubnets)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<ManagedClusterSubnet>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ServiceEndpoints))
            {
                writer.WritePropertyName("serviceEndpoints"u8);
                writer.WriteStartArray();
                foreach (var item in ServiceEndpoints)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<ManagedClusterServiceEndpoint>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ZonalUpdateMode))
            {
                writer.WritePropertyName("zonalUpdateMode"u8);
                writer.WriteStringValue(ZonalUpdateMode.Value.ToString());
            }
            if (Optional.IsDefined(UseCustomVnet))
            {
                writer.WritePropertyName("useCustomVnet"u8);
                writer.WriteBooleanValue(UseCustomVnet.Value);
            }
            if (Optional.IsDefined(PublicIPPrefixId))
            {
                writer.WritePropertyName("publicIPPrefixId"u8);
                writer.WriteStringValue(PublicIPPrefixId);
            }
            writer.WriteEndObject();
            if (_serializedAdditionalRawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static ServiceFabricManagedClusterData DeserializeServiceFabricManagedClusterData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ServiceFabricManagedClustersSku sku = default;
            Optional<ETag> etag = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> dnsName = default;
            Optional<string> fqdn = default;
            Optional<IPAddress> ipv4Address = default;
            Optional<Guid> clusterId = default;
            Optional<ServiceFabricManagedClusterState> clusterState = default;
            Optional<IReadOnlyList<BinaryData>> clusterCertificateThumbprints = default;
            Optional<int> clientConnectionPort = default;
            Optional<int> httpGatewayConnectionPort = default;
            Optional<string> adminUserName = default;
            Optional<string> adminPassword = default;
            Optional<IList<ManagedClusterLoadBalancingRule>> loadBalancingRules = default;
            Optional<bool> allowRdpAccess = default;
            Optional<IList<ServiceFabricManagedNetworkSecurityRule>> networkSecurityRules = default;
            Optional<IList<ManagedClusterClientCertificate>> clients = default;
            Optional<ManagedClusterAzureActiveDirectory> azureActiveDirectory = default;
            Optional<IList<ClusterFabricSettingsSection>> fabricSettings = default;
            Optional<ServiceFabricManagedResourceProvisioningState> provisioningState = default;
            Optional<string> clusterCodeVersion = default;
            Optional<ManagedClusterUpgradeMode> clusterUpgradeMode = default;
            Optional<ManagedClusterUpgradeCadence> clusterUpgradeCadence = default;
            Optional<IList<ManagedClusterAddOnFeature>> addonFeatures = default;
            Optional<bool> enableAutoOSUpgrade = default;
            Optional<bool> zonalResiliency = default;
            Optional<ApplicationTypeVersionsCleanupPolicy> applicationTypeVersionsCleanupPolicy = default;
            Optional<bool> enableIPv6 = default;
            Optional<string> subnetId = default;
            Optional<IList<ManagedClusterIPTag>> ipTags = default;
            Optional<IPAddress> ipv6Address = default;
            Optional<bool> enableServicePublicIP = default;
            Optional<IList<ManagedClusterSubnet>> auxiliarySubnets = default;
            Optional<IList<ManagedClusterServiceEndpoint>> serviceEndpoints = default;
            Optional<ZonalUpdateMode> zonalUpdateMode = default;
            Optional<bool> useCustomVnet = default;
            Optional<ResourceIdentifier> publicIPPrefixId = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    sku = ServiceFabricManagedClustersSku.DeserializeServiceFabricManagedClustersSku(property.Value);
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
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
                        if (property0.NameEquals("dnsName"u8))
                        {
                            dnsName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("fqdn"u8))
                        {
                            fqdn = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ipv4Address"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ipv4Address = IPAddress.Parse(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("clusterId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null || property0.Value.ValueKind == JsonValueKind.String && property0.Value.GetString().Length == 0)
                            {
                                continue;
                            }
                            clusterId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("clusterState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterState = new ServiceFabricManagedClusterState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("clusterCertificateThumbprints"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<BinaryData> array = new List<BinaryData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(BinaryData.FromString(item.GetRawText()));
                                }
                            }
                            clusterCertificateThumbprints = array;
                            continue;
                        }
                        if (property0.NameEquals("clientConnectionPort"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clientConnectionPort = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("httpGatewayConnectionPort"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            httpGatewayConnectionPort = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("adminUserName"u8))
                        {
                            adminUserName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("adminPassword"u8))
                        {
                            adminPassword = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("loadBalancingRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ManagedClusterLoadBalancingRule> array = new List<ManagedClusterLoadBalancingRule>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ManagedClusterLoadBalancingRule.DeserializeManagedClusterLoadBalancingRule(item));
                            }
                            loadBalancingRules = array;
                            continue;
                        }
                        if (property0.NameEquals("allowRdpAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            allowRdpAccess = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("networkSecurityRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ServiceFabricManagedNetworkSecurityRule> array = new List<ServiceFabricManagedNetworkSecurityRule>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ServiceFabricManagedNetworkSecurityRule.DeserializeServiceFabricManagedNetworkSecurityRule(item));
                            }
                            networkSecurityRules = array;
                            continue;
                        }
                        if (property0.NameEquals("clients"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ManagedClusterClientCertificate> array = new List<ManagedClusterClientCertificate>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ManagedClusterClientCertificate.DeserializeManagedClusterClientCertificate(item));
                            }
                            clients = array;
                            continue;
                        }
                        if (property0.NameEquals("azureActiveDirectory"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            azureActiveDirectory = ManagedClusterAzureActiveDirectory.DeserializeManagedClusterAzureActiveDirectory(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("fabricSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ClusterFabricSettingsSection> array = new List<ClusterFabricSettingsSection>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ClusterFabricSettingsSection.DeserializeClusterFabricSettingsSection(item));
                            }
                            fabricSettings = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new ServiceFabricManagedResourceProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("clusterCodeVersion"u8))
                        {
                            clusterCodeVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("clusterUpgradeMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterUpgradeMode = new ManagedClusterUpgradeMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("clusterUpgradeCadence"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterUpgradeCadence = new ManagedClusterUpgradeCadence(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("addonFeatures"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ManagedClusterAddOnFeature> array = new List<ManagedClusterAddOnFeature>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new ManagedClusterAddOnFeature(item.GetString()));
                            }
                            addonFeatures = array;
                            continue;
                        }
                        if (property0.NameEquals("enableAutoOSUpgrade"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableAutoOSUpgrade = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("zonalResiliency"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            zonalResiliency = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("applicationTypeVersionsCleanupPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            applicationTypeVersionsCleanupPolicy = ApplicationTypeVersionsCleanupPolicy.DeserializeApplicationTypeVersionsCleanupPolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("enableIpv6"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableIPv6 = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("subnetId"u8))
                        {
                            subnetId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ipTags"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ManagedClusterIPTag> array = new List<ManagedClusterIPTag>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ManagedClusterIPTag.DeserializeManagedClusterIPTag(item));
                            }
                            ipTags = array;
                            continue;
                        }
                        if (property0.NameEquals("ipv6Address"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ipv6Address = IPAddress.Parse(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("enableServicePublicIP"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableServicePublicIP = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("auxiliarySubnets"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ManagedClusterSubnet> array = new List<ManagedClusterSubnet>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ManagedClusterSubnet.DeserializeManagedClusterSubnet(item));
                            }
                            auxiliarySubnets = array;
                            continue;
                        }
                        if (property0.NameEquals("serviceEndpoints"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ManagedClusterServiceEndpoint> array = new List<ManagedClusterServiceEndpoint>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ManagedClusterServiceEndpoint.DeserializeManagedClusterServiceEndpoint(item));
                            }
                            serviceEndpoints = array;
                            continue;
                        }
                        if (property0.NameEquals("zonalUpdateMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            zonalUpdateMode = new ZonalUpdateMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("useCustomVnet"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            useCustomVnet = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("publicIPPrefixId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null || property0.Value.ValueKind == JsonValueKind.String && property0.Value.GetString().Length == 0)
                            {
                                continue;
                            }
                            publicIPPrefixId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ServiceFabricManagedClusterData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, sku, dnsName.Value, fqdn.Value, ipv4Address.Value, Optional.ToNullable(clusterId), Optional.ToNullable(clusterState), Optional.ToList(clusterCertificateThumbprints), Optional.ToNullable(clientConnectionPort), Optional.ToNullable(httpGatewayConnectionPort), adminUserName.Value, adminPassword.Value, Optional.ToList(loadBalancingRules), Optional.ToNullable(allowRdpAccess), Optional.ToList(networkSecurityRules), Optional.ToList(clients), azureActiveDirectory.Value, Optional.ToList(fabricSettings), Optional.ToNullable(provisioningState), clusterCodeVersion.Value, Optional.ToNullable(clusterUpgradeMode), Optional.ToNullable(clusterUpgradeCadence), Optional.ToList(addonFeatures), Optional.ToNullable(enableAutoOSUpgrade), Optional.ToNullable(zonalResiliency), applicationTypeVersionsCleanupPolicy.Value, Optional.ToNullable(enableIPv6), subnetId.Value, Optional.ToList(ipTags), ipv6Address.Value, Optional.ToNullable(enableServicePublicIP), Optional.ToList(auxiliarySubnets), Optional.ToList(serviceEndpoints), Optional.ToNullable(zonalUpdateMode), Optional.ToNullable(useCustomVnet), publicIPPrefixId.Value, Optional.ToNullable(etag), serializedAdditionalRawData);
        }

        ServiceFabricManagedClusterData IModelJsonSerializable<ServiceFabricManagedClusterData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServiceFabricManagedClusterData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeServiceFabricManagedClusterData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ServiceFabricManagedClusterData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServiceFabricManagedClusterData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ServiceFabricManagedClusterData IModelSerializable<ServiceFabricManagedClusterData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServiceFabricManagedClusterData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeServiceFabricManagedClusterData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ServiceFabricManagedClusterData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ServiceFabricManagedClusterData"/> to convert. </param>
        public static implicit operator RequestContent(ServiceFabricManagedClusterData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ServiceFabricManagedClusterData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ServiceFabricManagedClusterData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeServiceFabricManagedClusterData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
