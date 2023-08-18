// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Net;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DnsResolver.Models
{
    public partial class TargetDnsServer : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("ipAddress"u8);
            writer.WriteStringValue(IPAddress.ToString());
            if (Core.Optional.IsDefined(Port))
            {
                writer.WritePropertyName("port"u8);
                writer.WriteNumberValue(Port.Value);
            }
            writer.WriteEndObject();
        }

        internal static TargetDnsServer DeserializeTargetDnsServer(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IPAddress ipAddress = default;
            Core.Optional<int> port = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ipAddress"u8))
                {
                    ipAddress = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("port"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    port = property.Value.GetInt32();
                    continue;
                }
            }
            return new TargetDnsServer(ipAddress, Core.Optional.ToNullable(port));
        }
    }
}
