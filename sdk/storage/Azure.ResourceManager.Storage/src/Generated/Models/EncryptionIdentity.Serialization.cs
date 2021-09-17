// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class EncryptionIdentity : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(EncryptionUserAssignedIdentity))
            {
                writer.WritePropertyName("userAssignedIdentity");
                writer.WriteStringValue(EncryptionUserAssignedIdentity);
            }
            writer.WriteEndObject();
        }

        internal static EncryptionIdentity DeserializeEncryptionIdentity(JsonElement element)
        {
            Optional<string> userAssignedIdentity = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("userAssignedIdentity"))
                {
                    userAssignedIdentity = property.Value.GetString();
                    continue;
                }
            }
            return new EncryptionIdentity(userAssignedIdentity.Value);
        }
    }
}
