// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    public partial class SubnetData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Type))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type);
            }
            writer.WritePropertyName("id");
            writer.WriteStringValue(Id);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(AddressPrefix))
            {
                writer.WritePropertyName("addressPrefix");
                writer.WriteStringValue(AddressPrefix);
            }
            if (Optional.IsCollectionDefined(AddressPrefixes))
            {
                writer.WritePropertyName("addressPrefixes");
                writer.WriteStartArray();
                foreach (var item in AddressPrefixes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(NetworkSecurityGroup))
            {
                writer.WritePropertyName("networkSecurityGroup");
                writer.WriteObjectValue(NetworkSecurityGroup);
            }
            if (Optional.IsDefined(RouteTable))
            {
                writer.WritePropertyName("routeTable");
                writer.WriteObjectValue(RouteTable);
            }
            if (Optional.IsDefined(NatGateway))
            {
                writer.WritePropertyName("natGateway");
                writer.WriteObjectValue(NatGateway);
            }
            if (Optional.IsCollectionDefined(ServiceEndpoints))
            {
                writer.WritePropertyName("serviceEndpoints");
                writer.WriteStartArray();
                foreach (var item in ServiceEndpoints)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ServiceEndpointPolicies))
            {
                writer.WritePropertyName("serviceEndpointPolicies");
                writer.WriteStartArray();
                foreach (var item in ServiceEndpointPolicies)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(IpAllocations))
            {
                writer.WritePropertyName("ipAllocations");
                writer.WriteStartArray();
                foreach (var item in IpAllocations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Delegations))
            {
                writer.WritePropertyName("delegations");
                writer.WriteStartArray();
                foreach (var item in Delegations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PrivateEndpointNetworkPolicies))
            {
                writer.WritePropertyName("privateEndpointNetworkPolicies");
                writer.WriteStringValue(PrivateEndpointNetworkPolicies.Value.ToString());
            }
            if (Optional.IsDefined(PrivateLinkServiceNetworkPolicies))
            {
                writer.WritePropertyName("privateLinkServiceNetworkPolicies");
                writer.WriteStringValue(PrivateLinkServiceNetworkPolicies.Value.ToString());
            }
            if (Optional.IsCollectionDefined(ApplicationGatewayIpConfigurations))
            {
                writer.WritePropertyName("applicationGatewayIpConfigurations");
                writer.WriteStartArray();
                foreach (var item in ApplicationGatewayIpConfigurations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static SubnetData DeserializeSubnetData(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> etag = default;
            Optional<string> type = default;
            ResourceIdentifier id = default;
            Optional<string> addressPrefix = default;
            Optional<IList<string>> addressPrefixes = default;
            Optional<NetworkSecurityGroupData> networkSecurityGroup = default;
            Optional<RouteTableData> routeTable = default;
            Optional<SubResource> natGateway = default;
            Optional<IList<ServiceEndpointPropertiesFormat>> serviceEndpoints = default;
            Optional<IList<ServiceEndpointPolicyData>> serviceEndpointPolicies = default;
            Optional<IReadOnlyList<PrivateEndpointData>> privateEndpoints = default;
            Optional<IReadOnlyList<IPConfiguration>> ipConfigurations = default;
            Optional<IReadOnlyList<IPConfigurationProfile>> ipConfigurationProfiles = default;
            Optional<IList<SubResource>> ipAllocations = default;
            Optional<IReadOnlyList<ResourceNavigationLink>> resourceNavigationLinks = default;
            Optional<IReadOnlyList<ServiceAssociationLink>> serviceAssociationLinks = default;
            Optional<IList<Delegation>> delegations = default;
            Optional<string> purpose = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<VirtualNetworkPrivateEndpointNetworkPolicies> privateEndpointNetworkPolicies = default;
            Optional<VirtualNetworkPrivateLinkServiceNetworkPolicies> privateLinkServiceNetworkPolicies = default;
            Optional<IList<ApplicationGatewayIPConfiguration>> applicationGatewayIpConfigurations = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("addressPrefix"))
                        {
                            addressPrefix = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("addressPrefixes"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            addressPrefixes = array;
                            continue;
                        }
                        if (property0.NameEquals("networkSecurityGroup"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            networkSecurityGroup = NetworkSecurityGroupData.DeserializeNetworkSecurityGroupData(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("routeTable"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            routeTable = RouteTableData.DeserializeRouteTableData(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("natGateway"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            natGateway = SubResource.DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("serviceEndpoints"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ServiceEndpointPropertiesFormat> array = new List<ServiceEndpointPropertiesFormat>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ServiceEndpointPropertiesFormat.DeserializeServiceEndpointPropertiesFormat(item));
                            }
                            serviceEndpoints = array;
                            continue;
                        }
                        if (property0.NameEquals("serviceEndpointPolicies"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ServiceEndpointPolicyData> array = new List<ServiceEndpointPolicyData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ServiceEndpointPolicyData.DeserializeServiceEndpointPolicyData(item));
                            }
                            serviceEndpointPolicies = array;
                            continue;
                        }
                        if (property0.NameEquals("privateEndpoints"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<PrivateEndpointData> array = new List<PrivateEndpointData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(PrivateEndpointData.DeserializePrivateEndpointData(item));
                            }
                            privateEndpoints = array;
                            continue;
                        }
                        if (property0.NameEquals("ipConfigurations"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<IPConfiguration> array = new List<IPConfiguration>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(IPConfiguration.DeserializeIPConfiguration(item));
                            }
                            ipConfigurations = array;
                            continue;
                        }
                        if (property0.NameEquals("ipConfigurationProfiles"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<IPConfigurationProfile> array = new List<IPConfigurationProfile>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(IPConfigurationProfile.DeserializeIPConfigurationProfile(item));
                            }
                            ipConfigurationProfiles = array;
                            continue;
                        }
                        if (property0.NameEquals("ipAllocations"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<SubResource> array = new List<SubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SubResource.DeserializeSubResource(item));
                            }
                            ipAllocations = array;
                            continue;
                        }
                        if (property0.NameEquals("resourceNavigationLinks"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ResourceNavigationLink> array = new List<ResourceNavigationLink>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ResourceNavigationLink.DeserializeResourceNavigationLink(item));
                            }
                            resourceNavigationLinks = array;
                            continue;
                        }
                        if (property0.NameEquals("serviceAssociationLinks"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ServiceAssociationLink> array = new List<ServiceAssociationLink>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ServiceAssociationLink.DeserializeServiceAssociationLink(item));
                            }
                            serviceAssociationLinks = array;
                            continue;
                        }
                        if (property0.NameEquals("delegations"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<Delegation> array = new List<Delegation>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(Delegation.DeserializeDelegation(item));
                            }
                            delegations = array;
                            continue;
                        }
                        if (property0.NameEquals("purpose"))
                        {
                            purpose = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("privateEndpointNetworkPolicies"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            privateEndpointNetworkPolicies = new VirtualNetworkPrivateEndpointNetworkPolicies(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("privateLinkServiceNetworkPolicies"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            privateLinkServiceNetworkPolicies = new VirtualNetworkPrivateLinkServiceNetworkPolicies(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("applicationGatewayIpConfigurations"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ApplicationGatewayIPConfiguration> array = new List<ApplicationGatewayIPConfiguration>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ApplicationGatewayIPConfiguration.DeserializeApplicationGatewayIPConfiguration(item));
                            }
                            applicationGatewayIpConfigurations = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new SubnetData(id, name.Value, etag.Value, type.Value, addressPrefix.Value, Optional.ToList(addressPrefixes), networkSecurityGroup.Value, routeTable.Value, natGateway.Value, Optional.ToList(serviceEndpoints), Optional.ToList(serviceEndpointPolicies), Optional.ToList(privateEndpoints), Optional.ToList(ipConfigurations), Optional.ToList(ipConfigurationProfiles), Optional.ToList(ipAllocations), Optional.ToList(resourceNavigationLinks), Optional.ToList(serviceAssociationLinks), Optional.ToList(delegations), purpose.Value, Optional.ToNullable(provisioningState), Optional.ToNullable(privateEndpointNetworkPolicies), Optional.ToNullable(privateLinkServiceNetworkPolicies), Optional.ToList(applicationGatewayIpConfigurations));
        }
    }
}
