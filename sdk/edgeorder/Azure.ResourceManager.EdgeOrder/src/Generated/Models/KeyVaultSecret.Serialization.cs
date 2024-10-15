// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    public partial class KeyVaultSecret : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("keyVaultSecretUrl"u8);
            writer.WriteStringValue(KeyVaultSecretUri.AbsoluteUri);
            writer.WritePropertyName("keyVaultArmId"u8);
            writer.WriteStringValue(KeyVaultArmId);
            writer.WriteEndObject();
        }

        internal static KeyVaultSecret DeserializeKeyVaultSecret(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri keyVaultSecretUrl = default;
            string keyVaultArmId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyVaultSecretUrl"u8))
                {
                    keyVaultSecretUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("keyVaultArmId"u8))
                {
                    keyVaultArmId = property.Value.GetString();
                    continue;
                }
            }
            return new KeyVaultSecret(keyVaultSecretUrl, keyVaultArmId);
        }
    }
}
