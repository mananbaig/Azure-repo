// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class Subnet : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
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
                writer.WriteStringValue(PrivateEndpointNetworkPolicies);
            }
            if (Optional.IsDefined(PrivateLinkServiceNetworkPolicies))
            {
                writer.WritePropertyName("privateLinkServiceNetworkPolicies");
                writer.WriteStringValue(PrivateLinkServiceNetworkPolicies);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static Subnet DeserializeSubnet(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> etag = default;
            Optional<string> id = default;
            Optional<string> addressPrefix = default;
            Optional<IList<string>> addressPrefixes = default;
            Optional<NetworkSecurityGroup> networkSecurityGroup = default;
            Optional<RouteTable> routeTable = default;
            Optional<SubResource> natGateway = default;
            Optional<IList<ServiceEndpointPropertiesFormat>> serviceEndpoints = default;
            Optional<IList<ServiceEndpointPolicy>> serviceEndpointPolicies = default;
            Optional<IReadOnlyList<PrivateEndpoint>> privateEndpoints = default;
            Optional<IReadOnlyList<IPConfiguration>> ipConfigurations = default;
            Optional<IReadOnlyList<IPConfigurationProfile>> ipConfigurationProfiles = default;
            Optional<IList<SubResource>> ipAllocations = default;
            Optional<IReadOnlyList<ResourceNavigationLink>> resourceNavigationLinks = default;
            Optional<IReadOnlyList<ServiceAssociationLink>> serviceAssociationLinks = default;
            Optional<IList<Delegation>> delegations = default;
            Optional<string> purpose = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<string> privateEndpointNetworkPolicies = default;
            Optional<string> privateLinkServiceNetworkPolicies = default;
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
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("addressPrefix"))
                        {
                            addressPrefix = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("addressPrefixes"))
                        {
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
                            networkSecurityGroup = NetworkSecurityGroup.DeserializeNetworkSecurityGroup(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("routeTable"))
                        {
                            routeTable = RouteTable.DeserializeRouteTable(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("natGateway"))
                        {
                            natGateway = DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("serviceEndpoints"))
                        {
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
                            List<ServiceEndpointPolicy> array = new List<ServiceEndpointPolicy>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ServiceEndpointPolicy.DeserializeServiceEndpointPolicy(item));
                            }
                            serviceEndpointPolicies = array;
                            continue;
                        }
                        if (property0.NameEquals("privateEndpoints"))
                        {
                            List<PrivateEndpoint> array = new List<PrivateEndpoint>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(PrivateEndpoint.DeserializePrivateEndpoint(item));
                            }
                            privateEndpoints = array;
                            continue;
                        }
                        if (property0.NameEquals("ipConfigurations"))
                        {
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
                            List<SubResource> array = new List<SubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DeserializeSubResource(item));
                            }
                            ipAllocations = array;
                            continue;
                        }
                        if (property0.NameEquals("resourceNavigationLinks"))
                        {
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
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("privateEndpointNetworkPolicies"))
                        {
                            privateEndpointNetworkPolicies = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("privateLinkServiceNetworkPolicies"))
                        {
                            privateLinkServiceNetworkPolicies = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new Subnet(id.Value, name.Value, etag.Value, addressPrefix.Value, Optional.ToList(addressPrefixes), networkSecurityGroup.Value, routeTable.Value, natGateway.Value, Optional.ToList(serviceEndpoints), Optional.ToList(serviceEndpointPolicies), Optional.ToList(privateEndpoints), Optional.ToList(ipConfigurations), Optional.ToList(ipConfigurationProfiles), Optional.ToList(ipAllocations), Optional.ToList(resourceNavigationLinks), Optional.ToList(serviceAssociationLinks), Optional.ToList(delegations), purpose.Value, Optional.ToNullable(provisioningState), privateEndpointNetworkPolicies.Value, privateLinkServiceNetworkPolicies.Value);
        }
    }
}
