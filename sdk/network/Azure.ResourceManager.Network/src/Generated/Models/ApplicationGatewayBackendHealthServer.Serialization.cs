// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ApplicationGatewayBackendHealthServer
    {
        internal static ApplicationGatewayBackendHealthServer DeserializeApplicationGatewayBackendHealthServer(JsonElement element)
        {
            Optional<string> address = default;
            Optional<NetworkInterfaceIPConfigurationData> ipConfiguration = default;
            Optional<ApplicationGatewayBackendHealthServerHealth> health = default;
            Optional<string> healthProbeLog = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("address"))
                {
                    address = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ipConfiguration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    ipConfiguration = NetworkInterfaceIPConfigurationData.DeserializeNetworkInterfaceIPConfigurationData(property.Value);
                    continue;
                }
                if (property.NameEquals("health"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    health = new ApplicationGatewayBackendHealthServerHealth(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("healthProbeLog"))
                {
                    healthProbeLog = property.Value.GetString();
                    continue;
                }
            }
            return new ApplicationGatewayBackendHealthServer(address.Value, ipConfiguration.Value, Optional.ToNullable(health), healthProbeLog.Value);
        }
    }
}
