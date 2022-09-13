// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class MountPointMap : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("shareId");
            writer.WriteStringValue(ShareId);
            writer.WriteEndObject();
        }

        internal static MountPointMap DeserializeMountPointMap(JsonElement element)
        {
            ResourceIdentifier shareId = default;
            Optional<ResourceIdentifier> roleId = default;
            Optional<string> mountPoint = default;
            Optional<MountType> mountType = default;
            Optional<RoleType> roleType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("shareId"))
                {
                    shareId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("roleId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    roleId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("mountPoint"))
                {
                    mountPoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mountType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    mountType = new MountType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("roleType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    roleType = new RoleType(property.Value.GetString());
                    continue;
                }
            }
            return new MountPointMap(shareId, roleId.Value, mountPoint.Value, Optional.ToNullable(mountType), Optional.ToNullable(roleType));
        }
    }
}
