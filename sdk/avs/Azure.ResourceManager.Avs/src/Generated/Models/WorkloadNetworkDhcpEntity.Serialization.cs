// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Avs.Models
{
    public partial class WorkloadNetworkDhcpEntity : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("dhcpType");
            writer.WriteStringValue(DhcpType.ToString());
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName");
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(Revision))
            {
                writer.WritePropertyName("revision");
                writer.WriteNumberValue(Revision.Value);
            }
            writer.WriteEndObject();
        }

        internal static WorkloadNetworkDhcpEntity DeserializeWorkloadNetworkDhcpEntity(JsonElement element)
        {
            if (element.TryGetProperty("dhcpType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "RELAY": return WorkloadNetworkDhcpRelay.DeserializeWorkloadNetworkDhcpRelay(element);
                    case "SERVER": return WorkloadNetworkDhcpServer.DeserializeWorkloadNetworkDhcpServer(element);
                }
            }
            DhcpTypeEnum dhcpType = default;
            Optional<string> displayName = default;
            Optional<IReadOnlyList<string>> segments = default;
            Optional<WorkloadNetworkDhcpProvisioningState> provisioningState = default;
            Optional<long> revision = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dhcpType"))
                {
                    dhcpType = new DhcpTypeEnum(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("displayName"))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("segments"))
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
                    segments = array;
                    continue;
                }
                if (property.NameEquals("provisioningState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    provisioningState = new WorkloadNetworkDhcpProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("revision"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    revision = property.Value.GetInt64();
                    continue;
                }
            }
            return new UnknownWorkloadNetworkDhcpEntity(dhcpType, displayName.Value, Optional.ToList(segments), Optional.ToNullable(provisioningState), Optional.ToNullable(revision));
        }
    }
}
