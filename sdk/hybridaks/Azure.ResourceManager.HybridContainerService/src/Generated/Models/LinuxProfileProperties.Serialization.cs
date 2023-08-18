// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    public partial class LinuxProfileProperties : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(AdminUsername))
            {
                writer.WritePropertyName("adminUsername"u8);
                writer.WriteStringValue(AdminUsername);
            }
            if (Core.Optional.IsDefined(Ssh))
            {
                writer.WritePropertyName("ssh"u8);
                writer.WriteObjectValue(Ssh);
            }
            writer.WriteEndObject();
        }

        internal static LinuxProfileProperties DeserializeLinuxProfileProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> adminUsername = default;
            Core.Optional<LinuxProfilePropertiesSsh> ssh = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("adminUsername"u8))
                {
                    adminUsername = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ssh"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ssh = LinuxProfilePropertiesSsh.DeserializeLinuxProfilePropertiesSsh(property.Value);
                    continue;
                }
            }
            return new LinuxProfileProperties(adminUsername.Value, ssh.Value);
        }
    }
}
