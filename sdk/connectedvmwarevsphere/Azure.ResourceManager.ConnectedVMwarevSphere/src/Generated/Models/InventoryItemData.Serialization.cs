// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ConnectedVMwarevSphere.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ConnectedVMwarevSphere
{
    public partial class InventoryItemData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind");
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            writer.WritePropertyName("inventoryType");
            writer.WriteStringValue(InventoryType.ToString());
            if (Optional.IsDefined(ManagedResourceId))
            {
                writer.WritePropertyName("managedResourceId");
                writer.WriteStringValue(ManagedResourceId);
            }
            if (Optional.IsDefined(MoRefId))
            {
                writer.WritePropertyName("moRefId");
                writer.WriteStringValue(MoRefId);
            }
            if (Optional.IsDefined(MoName))
            {
                writer.WritePropertyName("moName");
                writer.WriteStringValue(MoName);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static InventoryItemData DeserializeInventoryItemData(JsonElement element)
        {
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            InventoryType inventoryType = default;
            Optional<string> managedResourceId = default;
            Optional<string> moRefId = default;
            Optional<string> moName = default;
            Optional<string> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
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
                    type = (ResourceType)property.Value.GetString();
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
                        if (property0.NameEquals("inventoryType"))
                        {
                            inventoryType = new InventoryType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("managedResourceId"))
                        {
                            managedResourceId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("moRefId"))
                        {
                            moRefId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("moName"))
                        {
                            moName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new InventoryItemData(id, name, type, systemData, kind.Value, inventoryType, managedResourceId.Value, moRefId.Value, moName.Value, provisioningState.Value);
        }
    }
}
