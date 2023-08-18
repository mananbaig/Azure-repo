// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DeviceProvisioningServices.Models
{
    public partial class DeviceProvisioningServicesSharedAccessKey : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("keyName"u8);
            writer.WriteStringValue(KeyName);
            if (Core.Optional.IsDefined(PrimaryKey))
            {
                writer.WritePropertyName("primaryKey"u8);
                writer.WriteStringValue(PrimaryKey);
            }
            if (Core.Optional.IsDefined(SecondaryKey))
            {
                writer.WritePropertyName("secondaryKey"u8);
                writer.WriteStringValue(SecondaryKey);
            }
            writer.WritePropertyName("rights"u8);
            writer.WriteStringValue(Rights.ToString());
            writer.WriteEndObject();
        }

        internal static DeviceProvisioningServicesSharedAccessKey DeserializeDeviceProvisioningServicesSharedAccessKey(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string keyName = default;
            Core.Optional<string> primaryKey = default;
            Core.Optional<string> secondaryKey = default;
            DeviceProvisioningServicesAccessKeyRight rights = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyName"u8))
                {
                    keyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("primaryKey"u8))
                {
                    primaryKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryKey"u8))
                {
                    secondaryKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rights"u8))
                {
                    rights = new DeviceProvisioningServicesAccessKeyRight(property.Value.GetString());
                    continue;
                }
            }
            return new DeviceProvisioningServicesSharedAccessKey(keyName, primaryKey.Value, secondaryKey.Value, rights);
        }
    }
}
