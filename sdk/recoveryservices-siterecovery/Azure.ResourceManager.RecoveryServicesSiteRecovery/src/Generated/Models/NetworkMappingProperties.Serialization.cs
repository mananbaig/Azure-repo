// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class NetworkMappingProperties
    {
        internal static NetworkMappingProperties DeserializeNetworkMappingProperties(JsonElement element)
        {
            Optional<string> state = default;
            Optional<string> primaryNetworkFriendlyName = default;
            Optional<string> primaryNetworkId = default;
            Optional<string> primaryFabricFriendlyName = default;
            Optional<string> recoveryNetworkFriendlyName = default;
            Optional<string> recoveryNetworkId = default;
            Optional<string> recoveryFabricArmId = default;
            Optional<string> recoveryFabricFriendlyName = default;
            Optional<NetworkMappingFabricSpecificSettings> fabricSpecificSettings = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("state"))
                {
                    state = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("primaryNetworkFriendlyName"))
                {
                    primaryNetworkFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("primaryNetworkId"))
                {
                    primaryNetworkId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("primaryFabricFriendlyName"))
                {
                    primaryFabricFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryNetworkFriendlyName"))
                {
                    recoveryNetworkFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryNetworkId"))
                {
                    recoveryNetworkId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryFabricArmId"))
                {
                    recoveryFabricArmId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryFabricFriendlyName"))
                {
                    recoveryFabricFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fabricSpecificSettings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    fabricSpecificSettings = NetworkMappingFabricSpecificSettings.DeserializeNetworkMappingFabricSpecificSettings(property.Value);
                    continue;
                }
            }
            return new NetworkMappingProperties(state.Value, primaryNetworkFriendlyName.Value, primaryNetworkId.Value, primaryFabricFriendlyName.Value, recoveryNetworkFriendlyName.Value, recoveryNetworkId.Value, recoveryFabricArmId.Value, recoveryFabricFriendlyName.Value, fabricSpecificSettings.Value);
        }
    }
}
