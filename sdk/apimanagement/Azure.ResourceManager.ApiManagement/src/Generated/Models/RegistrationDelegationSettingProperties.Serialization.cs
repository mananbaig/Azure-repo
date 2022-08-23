// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    internal partial class RegistrationDelegationSettingProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(IsUserRegistrationDelegationEnabled))
            {
                writer.WritePropertyName("enabled");
                writer.WriteBooleanValue(IsUserRegistrationDelegationEnabled.Value);
            }
            writer.WriteEndObject();
        }

        internal static RegistrationDelegationSettingProperties DeserializeRegistrationDelegationSettingProperties(JsonElement element)
        {
            Optional<bool> enabled = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
            }
            return new RegistrationDelegationSettingProperties(Optional.ToNullable(enabled));
        }
    }
}
