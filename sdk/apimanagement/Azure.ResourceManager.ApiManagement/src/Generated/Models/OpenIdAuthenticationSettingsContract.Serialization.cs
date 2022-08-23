// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class OpenIdAuthenticationSettingsContract : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(OpenIdProviderId))
            {
                writer.WritePropertyName("openidProviderId");
                writer.WriteStringValue(OpenIdProviderId);
            }
            if (Optional.IsCollectionDefined(BearerTokenSendingMethods))
            {
                writer.WritePropertyName("bearerTokenSendingMethods");
                writer.WriteStartArray();
                foreach (var item in BearerTokenSendingMethods)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static OpenIdAuthenticationSettingsContract DeserializeOpenIdAuthenticationSettingsContract(JsonElement element)
        {
            Optional<string> openidProviderId = default;
            Optional<IList<BearerTokenSendingMethod>> bearerTokenSendingMethods = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("openidProviderId"))
                {
                    openidProviderId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("bearerTokenSendingMethods"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<BearerTokenSendingMethod> array = new List<BearerTokenSendingMethod>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new BearerTokenSendingMethod(item.GetString()));
                    }
                    bearerTokenSendingMethods = array;
                    continue;
                }
            }
            return new OpenIdAuthenticationSettingsContract(openidProviderId.Value, Optional.ToList(bearerTokenSendingMethods));
        }
    }
}
