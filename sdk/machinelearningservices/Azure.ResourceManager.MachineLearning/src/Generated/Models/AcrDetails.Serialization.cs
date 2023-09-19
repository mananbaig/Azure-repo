// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class AcrDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SystemCreatedAcrAccount))
            {
                if (SystemCreatedAcrAccount != null)
                {
                    writer.WritePropertyName("systemCreatedAcrAccount"u8);
                    writer.WriteObjectValue(SystemCreatedAcrAccount);
                }
                else
                {
                    writer.WriteNull("systemCreatedAcrAccount");
                }
            }
            if (Optional.IsDefined(UserCreatedAcrAccount))
            {
                if (UserCreatedAcrAccount != null)
                {
                    writer.WritePropertyName("userCreatedAcrAccount"u8);
                    writer.WriteObjectValue(UserCreatedAcrAccount);
                }
                else
                {
                    writer.WriteNull("userCreatedAcrAccount");
                }
            }
            writer.WriteEndObject();
        }

        internal static AcrDetails DeserializeAcrDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SystemCreatedAcrAccount> systemCreatedAcrAccount = default;
            Optional<UserCreatedAcrAccount> userCreatedAcrAccount = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("systemCreatedAcrAccount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        systemCreatedAcrAccount = null;
                        continue;
                    }
                    systemCreatedAcrAccount = SystemCreatedAcrAccount.DeserializeSystemCreatedAcrAccount(property.Value);
                    continue;
                }
                if (property.NameEquals("userCreatedAcrAccount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        userCreatedAcrAccount = null;
                        continue;
                    }
                    userCreatedAcrAccount = UserCreatedAcrAccount.DeserializeUserCreatedAcrAccount(property.Value);
                    continue;
                }
            }
            return new AcrDetails(systemCreatedAcrAccount.Value, userCreatedAcrAccount.Value);
        }
    }
}
