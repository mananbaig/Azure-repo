// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class NetworkFabricPatchablePropertiesTerminalServerConfiguration : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(PrimaryIPv4Prefix))
            {
                writer.WritePropertyName("primaryIpv4Prefix"u8);
                writer.WriteStringValue(PrimaryIPv4Prefix);
            }
            if (Core.Optional.IsDefined(PrimaryIPv6Prefix))
            {
                writer.WritePropertyName("primaryIpv6Prefix"u8);
                writer.WriteStringValue(PrimaryIPv6Prefix);
            }
            if (Core.Optional.IsDefined(SecondaryIPv4Prefix))
            {
                writer.WritePropertyName("secondaryIpv4Prefix"u8);
                writer.WriteStringValue(SecondaryIPv4Prefix);
            }
            if (Core.Optional.IsDefined(SecondaryIPv6Prefix))
            {
                writer.WritePropertyName("secondaryIpv6Prefix"u8);
                writer.WriteStringValue(SecondaryIPv6Prefix);
            }
            if (Core.Optional.IsDefined(Username))
            {
                writer.WritePropertyName("username"u8);
                writer.WriteStringValue(Username);
            }
            if (Core.Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password"u8);
                writer.WriteStringValue(Password);
            }
            if (Core.Optional.IsDefined(SerialNumber))
            {
                writer.WritePropertyName("serialNumber"u8);
                writer.WriteStringValue(SerialNumber);
            }
            writer.WriteEndObject();
        }

        internal static NetworkFabricPatchablePropertiesTerminalServerConfiguration DeserializeNetworkFabricPatchablePropertiesTerminalServerConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> primaryIPv4Prefix = default;
            Core.Optional<string> primaryIPv6Prefix = default;
            Core.Optional<string> secondaryIPv4Prefix = default;
            Core.Optional<string> secondaryIPv6Prefix = default;
            Core.Optional<string> username = default;
            Core.Optional<string> password = default;
            Core.Optional<string> serialNumber = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primaryIpv4Prefix"u8))
                {
                    primaryIPv4Prefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("primaryIpv6Prefix"u8))
                {
                    primaryIPv6Prefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryIpv4Prefix"u8))
                {
                    secondaryIPv4Prefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryIpv6Prefix"u8))
                {
                    secondaryIPv6Prefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("username"u8))
                {
                    username = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("password"u8))
                {
                    password = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serialNumber"u8))
                {
                    serialNumber = property.Value.GetString();
                    continue;
                }
            }
            return new NetworkFabricPatchablePropertiesTerminalServerConfiguration(username.Value, password.Value, serialNumber.Value, primaryIPv4Prefix.Value, primaryIPv6Prefix.Value, secondaryIPv4Prefix.Value, secondaryIPv6Prefix.Value);
        }
    }
}
