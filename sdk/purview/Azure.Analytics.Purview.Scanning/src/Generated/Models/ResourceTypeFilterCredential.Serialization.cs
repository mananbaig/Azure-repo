// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Purview.Scanning.Models
{
    public partial class ResourceTypeFilterCredential : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ReferenceName))
            {
                writer.WritePropertyName("referenceName");
                writer.WriteStringValue(ReferenceName);
            }
            if (Optional.IsDefined(CredentialType))
            {
                writer.WritePropertyName("credentialType");
                writer.WriteStringValue(CredentialType.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static ResourceTypeFilterCredential DeserializeResourceTypeFilterCredential(JsonElement element)
        {
            Optional<string> referenceName = default;
            Optional<CredentialType> credentialType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("referenceName"))
                {
                    referenceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("credentialType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    credentialType = new CredentialType(property.Value.GetString());
                    continue;
                }
            }
            return new ResourceTypeFilterCredential(referenceName.Value, Optional.ToNullable(credentialType));
        }
    }
}
