// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventHubs.Models
{
    public partial class Encryption : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(KeyVaultProperties))
            {
                writer.WritePropertyName("keyVaultProperties");
                writer.WriteStartArray();
                foreach (var item in KeyVaultProperties)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(KeySource))
            {
                writer.WritePropertyName("keySource");
                writer.WriteStringValue(KeySource);
            }
            if (Optional.IsDefined(RequireInfrastructureEncryption))
            {
                writer.WritePropertyName("requireInfrastructureEncryption");
                writer.WriteBooleanValue(RequireInfrastructureEncryption.Value);
            }
            writer.WriteEndObject();
        }

        internal static Encryption DeserializeEncryption(JsonElement element)
        {
            Optional<IList<KeyVaultProperties>> keyVaultProperties = default;
            Optional<string> keySource = default;
            Optional<bool> requireInfrastructureEncryption = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyVaultProperties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<KeyVaultProperties> array = new List<KeyVaultProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.KeyVaultProperties.DeserializeKeyVaultProperties(item));
                    }
                    keyVaultProperties = array;
                    continue;
                }
                if (property.NameEquals("keySource"))
                {
                    keySource = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("requireInfrastructureEncryption"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    requireInfrastructureEncryption = property.Value.GetBoolean();
                    continue;
                }
            }
            return new Encryption(Optional.ToList(keyVaultProperties), keySource.Value, Optional.ToNullable(requireInfrastructureEncryption));
        }
    }
}
