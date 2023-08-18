// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class ResourceGuardProperties : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsCollectionDefined(VaultCriticalOperationExclusionList))
            {
                writer.WritePropertyName("vaultCriticalOperationExclusionList"u8);
                writer.WriteStartArray();
                foreach (var item in VaultCriticalOperationExclusionList)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static ResourceGuardProperties DeserializeResourceGuardProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<DataProtectionBackupProvisioningState> provisioningState = default;
            Core.Optional<bool> allowAutoApprovals = default;
            Core.Optional<IReadOnlyList<ResourceGuardOperationDetails>> resourceGuardOperations = default;
            Core.Optional<IList<string>> vaultCriticalOperationExclusionList = default;
            Core.Optional<string> description = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new DataProtectionBackupProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("allowAutoApprovals"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allowAutoApprovals = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("resourceGuardOperations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceGuardOperationDetails> array = new List<ResourceGuardOperationDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceGuardOperationDetails.DeserializeResourceGuardOperationDetails(item));
                    }
                    resourceGuardOperations = array;
                    continue;
                }
                if (property.NameEquals("vaultCriticalOperationExclusionList"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    vaultCriticalOperationExclusionList = array;
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
            }
            return new ResourceGuardProperties(Core.Optional.ToNullable(provisioningState), Core.Optional.ToNullable(allowAutoApprovals), Core.Optional.ToList(resourceGuardOperations), Core.Optional.ToList(vaultCriticalOperationExclusionList), description.Value);
        }
    }
}
