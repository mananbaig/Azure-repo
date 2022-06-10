// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class NetworkProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("loadBalancerType");
            writer.WriteStringValue(LoadBalancerType.ToString());
            if (Optional.IsDefined(LoadBalancerSku))
            {
                writer.WritePropertyName("loadBalancerSku");
                writer.WriteStringValue(LoadBalancerSku);
            }
            if (Optional.IsDefined(LoadBalancerTier))
            {
                writer.WritePropertyName("loadBalancerTier");
                writer.WriteStringValue(LoadBalancerTier);
            }
            if (Optional.IsDefined(Capacity))
            {
                writer.WritePropertyName("capacity");
                writer.WriteNumberValue(Capacity.Value);
            }
            if (Optional.IsDefined(AzureFrontDoorEnabled))
            {
                writer.WritePropertyName("azureFrontDoorEnabled");
                writer.WriteStringValue(AzureFrontDoorEnabled.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static NetworkProfile DeserializeNetworkProfile(JsonElement element)
        {
            LoadBalancerType loadBalancerType = default;
            Optional<string> loadBalancerSku = default;
            Optional<string> loadBalancerTier = default;
            Optional<int> capacity = default;
            Optional<AzureFrontDoorEnabled> azureFrontDoorEnabled = default;
            Optional<ResourceIdentifier> vNetResourceId = default;
            Optional<ResourceIdentifier> loadBalancerResourceId = default;
            Optional<ResourceIdentifier> azureFrontDoorResourceId = default;
            Optional<ResourceIdentifier> frontEndPublicIpResourceId = default;
            Optional<IReadOnlyList<string>> outboundPublicIpResourceIds = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("loadBalancerType"))
                {
                    loadBalancerType = new LoadBalancerType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("loadBalancerSku"))
                {
                    loadBalancerSku = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("loadBalancerTier"))
                {
                    loadBalancerTier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("capacity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    capacity = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("azureFrontDoorEnabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    azureFrontDoorEnabled = new AzureFrontDoorEnabled(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("vNetResourceId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    vNetResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("loadBalancerResourceId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    loadBalancerResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("azureFrontDoorResourceId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    azureFrontDoorResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("frontEndPublicIpResourceId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    frontEndPublicIpResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("outboundPublicIpResourceIds"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    outboundPublicIpResourceIds = array;
                    continue;
                }
            }
            return new NetworkProfile(loadBalancerType, loadBalancerSku.Value, loadBalancerTier.Value, Optional.ToNullable(capacity), Optional.ToNullable(azureFrontDoorEnabled), vNetResourceId.Value, loadBalancerResourceId.Value, azureFrontDoorResourceId.Value, frontEndPublicIpResourceId.Value, Optional.ToList(outboundPublicIpResourceIds));
        }
    }
}
