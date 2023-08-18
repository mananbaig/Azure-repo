// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    public partial class DevTestLabUserSecretStore : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(KeyVaultUri))
            {
                writer.WritePropertyName("keyVaultUri"u8);
                writer.WriteStringValue(KeyVaultUri.AbsoluteUri);
            }
            if (Core.Optional.IsDefined(KeyVaultId))
            {
                writer.WritePropertyName("keyVaultId"u8);
                writer.WriteStringValue(KeyVaultId);
            }
            writer.WriteEndObject();
        }

        internal static DevTestLabUserSecretStore DeserializeDevTestLabUserSecretStore(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<Uri> keyVaultUri = default;
            Core.Optional<ResourceIdentifier> keyVaultId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyVaultUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyVaultUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("keyVaultId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyVaultId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
            }
            return new DevTestLabUserSecretStore(keyVaultUri.Value, keyVaultId.Value);
        }
    }
}
