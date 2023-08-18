// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DeviceProvisioningServices;

namespace Azure.ResourceManager.DeviceProvisioningServices.Models
{
    public partial class DeviceProvisioningServiceProperties : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (Core.Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            if (Core.Optional.IsCollectionDefined(IPFilterRules))
            {
                writer.WritePropertyName("ipFilterRules"u8);
                writer.WriteStartArray();
                foreach (var item in IPFilterRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsCollectionDefined(PrivateEndpointConnections))
            {
                writer.WritePropertyName("privateEndpointConnections"u8);
                writer.WriteStartArray();
                foreach (var item in PrivateEndpointConnections)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (Core.Optional.IsCollectionDefined(IotHubs))
            {
                writer.WritePropertyName("iotHubs"u8);
                writer.WriteStartArray();
                foreach (var item in IotHubs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsDefined(AllocationPolicy))
            {
                writer.WritePropertyName("allocationPolicy"u8);
                writer.WriteStringValue(AllocationPolicy.Value.ToString());
            }
            if (Core.Optional.IsCollectionDefined(AuthorizationPolicies))
            {
                writer.WritePropertyName("authorizationPolicies"u8);
                writer.WriteStartArray();
                foreach (var item in AuthorizationPolicies)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsDefined(IsDataResidencyEnabled))
            {
                writer.WritePropertyName("enableDataResidency"u8);
                writer.WriteBooleanValue(IsDataResidencyEnabled.Value);
            }
            writer.WriteEndObject();
        }

        internal static DeviceProvisioningServiceProperties DeserializeDeviceProvisioningServiceProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<DeviceProvisioningServicesState> state = default;
            Core.Optional<DeviceProvisioningServicesPublicNetworkAccess> publicNetworkAccess = default;
            Core.Optional<IList<DeviceProvisioningServicesIPFilterRule>> ipFilterRules = default;
            Core.Optional<IList<DeviceProvisioningServicesPrivateEndpointConnectionData>> privateEndpointConnections = default;
            Core.Optional<string> provisioningState = default;
            Core.Optional<IList<IotHubDefinitionDescription>> iotHubs = default;
            Core.Optional<DeviceProvisioningServicesAllocationPolicy> allocationPolicy = default;
            Core.Optional<string> serviceOperationsHostName = default;
            Core.Optional<string> deviceProvisioningHostName = default;
            Core.Optional<string> idScope = default;
            Core.Optional<IList<DeviceProvisioningServicesSharedAccessKey>> authorizationPolicies = default;
            Core.Optional<bool> enableDataResidency = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new DeviceProvisioningServicesState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("publicNetworkAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publicNetworkAccess = new DeviceProvisioningServicesPublicNetworkAccess(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ipFilterRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DeviceProvisioningServicesIPFilterRule> array = new List<DeviceProvisioningServicesIPFilterRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeviceProvisioningServicesIPFilterRule.DeserializeDeviceProvisioningServicesIPFilterRule(item));
                    }
                    ipFilterRules = array;
                    continue;
                }
                if (property.NameEquals("privateEndpointConnections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DeviceProvisioningServicesPrivateEndpointConnectionData> array = new List<DeviceProvisioningServicesPrivateEndpointConnectionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeviceProvisioningServicesPrivateEndpointConnectionData.DeserializeDeviceProvisioningServicesPrivateEndpointConnectionData(item));
                    }
                    privateEndpointConnections = array;
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    provisioningState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("iotHubs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IotHubDefinitionDescription> array = new List<IotHubDefinitionDescription>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IotHubDefinitionDescription.DeserializeIotHubDefinitionDescription(item));
                    }
                    iotHubs = array;
                    continue;
                }
                if (property.NameEquals("allocationPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allocationPolicy = new DeviceProvisioningServicesAllocationPolicy(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("serviceOperationsHostName"u8))
                {
                    serviceOperationsHostName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deviceProvisioningHostName"u8))
                {
                    deviceProvisioningHostName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("idScope"u8))
                {
                    idScope = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("authorizationPolicies"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DeviceProvisioningServicesSharedAccessKey> array = new List<DeviceProvisioningServicesSharedAccessKey>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeviceProvisioningServicesSharedAccessKey.DeserializeDeviceProvisioningServicesSharedAccessKey(item));
                    }
                    authorizationPolicies = array;
                    continue;
                }
                if (property.NameEquals("enableDataResidency"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableDataResidency = property.Value.GetBoolean();
                    continue;
                }
            }
            return new DeviceProvisioningServiceProperties(Core.Optional.ToNullable(state), Core.Optional.ToNullable(publicNetworkAccess), Core.Optional.ToList(ipFilterRules), Core.Optional.ToList(privateEndpointConnections), provisioningState.Value, Core.Optional.ToList(iotHubs), Core.Optional.ToNullable(allocationPolicy), serviceOperationsHostName.Value, deviceProvisioningHostName.Value, idScope.Value, Core.Optional.ToList(authorizationPolicies), Core.Optional.ToNullable(enableDataResidency));
        }
    }
}
