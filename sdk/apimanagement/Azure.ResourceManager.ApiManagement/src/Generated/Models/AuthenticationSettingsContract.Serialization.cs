// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class AuthenticationSettingsContract : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(OAuth2))
            {
                writer.WritePropertyName("oAuth2");
                writer.WriteObjectValue(OAuth2);
            }
            if (Optional.IsDefined(OpenId))
            {
                writer.WritePropertyName("openid");
                writer.WriteObjectValue(OpenId);
            }
            writer.WriteEndObject();
        }

        internal static AuthenticationSettingsContract DeserializeAuthenticationSettingsContract(JsonElement element)
        {
            Optional<OAuth2AuthenticationSettingsContract> oAuth2 = default;
            Optional<OpenIdAuthenticationSettingsContract> openid = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("oAuth2"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    oAuth2 = OAuth2AuthenticationSettingsContract.DeserializeOAuth2AuthenticationSettingsContract(property.Value);
                    continue;
                }
                if (property.NameEquals("openid"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    openid = OpenIdAuthenticationSettingsContract.DeserializeOpenIdAuthenticationSettingsContract(property.Value);
                    continue;
                }
            }
            return new AuthenticationSettingsContract(oAuth2.Value, openid.Value);
        }
    }
}
