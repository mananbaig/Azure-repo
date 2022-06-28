// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.KeyVault.Models
{
    public partial class ManagedHsmProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(TenantId))
            {
                writer.WritePropertyName("tenantId");
                writer.WriteStringValue(TenantId.Value);
            }
            if (Optional.IsCollectionDefined(InitialAdminObjectIds))
            {
                writer.WritePropertyName("initialAdminObjectIds");
                writer.WriteStartArray();
                foreach (var item in InitialAdminObjectIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(EnableSoftDelete))
            {
                writer.WritePropertyName("enableSoftDelete");
                writer.WriteBooleanValue(EnableSoftDelete.Value);
            }
            if (Optional.IsDefined(SoftDeleteRetentionInDays))
            {
                writer.WritePropertyName("softDeleteRetentionInDays");
                writer.WriteNumberValue(SoftDeleteRetentionInDays.Value);
            }
            if (Optional.IsDefined(EnablePurgeProtection))
            {
                writer.WritePropertyName("enablePurgeProtection");
                writer.WriteBooleanValue(EnablePurgeProtection.Value);
            }
            if (Optional.IsDefined(CreateMode))
            {
                writer.WritePropertyName("createMode");
                writer.WriteStringValue(CreateMode.Value.ToSerialString());
            }
            if (Optional.IsDefined(NetworkRuleSet))
            {
                writer.WritePropertyName("networkAcls");
                writer.WriteObjectValue(NetworkRuleSet);
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess");
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static ManagedHsmProperties DeserializeManagedHsmProperties(JsonElement element)
        {
            Optional<Guid> tenantId = default;
            Optional<IList<string>> initialAdminObjectIds = default;
            Optional<Uri> hsmUri = default;
            Optional<bool> enableSoftDelete = default;
            Optional<int> softDeleteRetentionInDays = default;
            Optional<bool> enablePurgeProtection = default;
            Optional<ManagedHsmCreateMode> createMode = default;
            Optional<string> statusMessage = default;
            Optional<ManagedHsmProvisioningState> provisioningState = default;
            Optional<ManagedHsmNetworkRuleSet> networkAcls = default;
            Optional<IReadOnlyList<ManagedHsmPrivateEndpointConnectionItemData>> privateEndpointConnections = default;
            Optional<ManagedHsmPublicNetworkAccess> publicNetworkAccess = default;
            Optional<DateTimeOffset> scheduledPurgeDate = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tenantId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("initialAdminObjectIds"))
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
                    initialAdminObjectIds = array;
                    continue;
                }
                if (property.NameEquals("hsmUri"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        hsmUri = null;
                        continue;
                    }
                    hsmUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("enableSoftDelete"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enableSoftDelete = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("softDeleteRetentionInDays"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    softDeleteRetentionInDays = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("enablePurgeProtection"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enablePurgeProtection = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("createMode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    createMode = property.Value.GetString().ToManagedHsmCreateMode();
                    continue;
                }
                if (property.NameEquals("statusMessage"))
                {
                    statusMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    provisioningState = new ManagedHsmProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("networkAcls"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    networkAcls = ManagedHsmNetworkRuleSet.DeserializeManagedHsmNetworkRuleSet(property.Value);
                    continue;
                }
                if (property.NameEquals("privateEndpointConnections"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ManagedHsmPrivateEndpointConnectionItemData> array = new List<ManagedHsmPrivateEndpointConnectionItemData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedHsmPrivateEndpointConnectionItemData.DeserializeManagedHsmPrivateEndpointConnectionItemData(item));
                    }
                    privateEndpointConnections = array;
                    continue;
                }
                if (property.NameEquals("publicNetworkAccess"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    publicNetworkAccess = new ManagedHsmPublicNetworkAccess(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("scheduledPurgeDate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    scheduledPurgeDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new ManagedHsmProperties(Optional.ToNullable(tenantId), Optional.ToList(initialAdminObjectIds), hsmUri.Value, Optional.ToNullable(enableSoftDelete), Optional.ToNullable(softDeleteRetentionInDays), Optional.ToNullable(enablePurgeProtection), Optional.ToNullable(createMode), statusMessage.Value, Optional.ToNullable(provisioningState), networkAcls.Value, Optional.ToList(privateEndpointConnections), Optional.ToNullable(publicNetworkAccess), Optional.ToNullable(scheduledPurgeDate));
        }
    }
}
