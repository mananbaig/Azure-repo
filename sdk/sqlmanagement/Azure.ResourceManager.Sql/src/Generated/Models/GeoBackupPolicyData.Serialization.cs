// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    public partial class GeoBackupPolicyData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            writer.WritePropertyName("state");
            writer.WriteStringValue(State.ToSerialString());
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static GeoBackupPolicyData DeserializeGeoBackupPolicyData(JsonElement element)
        {
            Optional<string> kind = default;
            Optional<string> location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            GeoBackupPolicyState state = default;
            Optional<string> storageType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
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
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
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
                        if (property0.NameEquals("state"))
                        {
                            state = property0.Value.GetString().ToGeoBackupPolicyState();
                            continue;
                        }
                        if (property0.NameEquals("storageType"))
                        {
                            storageType = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new GeoBackupPolicyData(id, name, type, systemData.Value, kind.Value, location.Value, state, storageType.Value);
        }
    }
}
