// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.LoadTesting.Models
{
    public partial class LoadTestingCmkEncryptionProperties : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                writer.WriteObjectValue(Identity);
            }
            if (Core.Optional.IsDefined(KeyUri))
            {
                writer.WritePropertyName("keyUrl"u8);
                writer.WriteStringValue(KeyUri.AbsoluteUri);
            }
            writer.WriteEndObject();
        }

        internal static LoadTestingCmkEncryptionProperties DeserializeLoadTestingCmkEncryptionProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<LoadTestingCmkIdentity> identity = default;
            Core.Optional<Uri> keyUrl = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = LoadTestingCmkIdentity.DeserializeLoadTestingCmkIdentity(property.Value);
                    continue;
                }
                if (property.NameEquals("keyUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyUrl = new Uri(property.Value.GetString());
                    continue;
                }
            }
            return new LoadTestingCmkEncryptionProperties(identity.Value, keyUrl.Value);
        }
    }
}
