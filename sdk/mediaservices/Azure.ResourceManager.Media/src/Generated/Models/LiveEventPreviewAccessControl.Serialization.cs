// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    internal partial class LiveEventPreviewAccessControl : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(IP))
            {
                writer.WritePropertyName("ip"u8);
                writer.WriteObjectValue(IP);
            }
            writer.WriteEndObject();
        }

        internal static LiveEventPreviewAccessControl DeserializeLiveEventPreviewAccessControl(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IPAccessControl> ip = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ip"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ip = IPAccessControl.DeserializeIPAccessControl(property.Value);
                    continue;
                }
            }
            return new LiveEventPreviewAccessControl(ip.Value);
        }
    }
}
