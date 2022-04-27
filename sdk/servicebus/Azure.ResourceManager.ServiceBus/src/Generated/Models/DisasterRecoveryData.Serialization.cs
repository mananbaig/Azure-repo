// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.ServiceBus.Models;

namespace Azure.ResourceManager.ServiceBus
{
    public partial class DisasterRecoveryData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(PartnerNamespace))
            {
                writer.WritePropertyName("partnerNamespace");
                writer.WriteStringValue(PartnerNamespace);
            }
            if (Optional.IsDefined(AlternateName))
            {
                writer.WritePropertyName("alternateName");
                writer.WriteStringValue(AlternateName);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static DisasterRecoveryData DeserializeDisasterRecoveryData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<DisasterRecoveryProvisioningState> provisioningState = default;
            Optional<long> pendingReplicationOperationsCount = default;
            Optional<string> partnerNamespace = default;
            Optional<string> alternateName = default;
            Optional<RoleDisasterRecovery> role = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
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
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = property0.Value.GetString().ToDisasterRecoveryProvisioningState();
                            continue;
                        }
                        if (property0.NameEquals("pendingReplicationOperationsCount"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            pendingReplicationOperationsCount = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("partnerNamespace"))
                        {
                            partnerNamespace = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("alternateName"))
                        {
                            alternateName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("role"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            role = property0.Value.GetString().ToRoleDisasterRecovery();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new DisasterRecoveryData(id, name, type, systemData, Optional.ToNullable(provisioningState), Optional.ToNullable(pendingReplicationOperationsCount), partnerNamespace.Value, alternateName.Value, Optional.ToNullable(role));
        }
    }
}
