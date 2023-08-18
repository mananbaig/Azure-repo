// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(KeyVaultKeyExpiredEventDataConverter))]
    public partial class KeyVaultKeyExpiredEventData
    {
        internal static KeyVaultKeyExpiredEventData DeserializeKeyVaultKeyExpiredEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> id = default;
            Core.Optional<string> vaultName = default;
            Core.Optional<string> objectType = default;
            Core.Optional<string> objectName = default;
            Core.Optional<string> version = default;
            Core.Optional<float> nbf = default;
            Core.Optional<float> exp = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("Id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("VaultName"u8))
                {
                    vaultName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ObjectType"u8))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ObjectName"u8))
                {
                    objectName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("Version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("NBF"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nbf = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("EXP"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    exp = property.Value.GetSingle();
                    continue;
                }
            }
            return new KeyVaultKeyExpiredEventData(id.Value, vaultName.Value, objectType.Value, objectName.Value, version.Value, Core.Optional.ToNullable(nbf), Core.Optional.ToNullable(exp));
        }

        internal partial class KeyVaultKeyExpiredEventDataConverter : JsonConverter<KeyVaultKeyExpiredEventData>
        {
            public override void Write(Utf8JsonWriter writer, KeyVaultKeyExpiredEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override KeyVaultKeyExpiredEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeKeyVaultKeyExpiredEventData(document.RootElement);
            }
        }
    }
}
