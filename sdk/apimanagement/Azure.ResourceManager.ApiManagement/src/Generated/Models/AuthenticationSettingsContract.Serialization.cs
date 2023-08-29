// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class AuthenticationSettingsContract : IUtf8JsonSerializable, IModelJsonSerializable<AuthenticationSettingsContract>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AuthenticationSettingsContract>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AuthenticationSettingsContract>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(OAuth2))
            {
                writer.WritePropertyName("oAuth2"u8);
                writer.WriteObjectValue(OAuth2);
            }
            if (Optional.IsDefined(OpenId))
            {
                writer.WritePropertyName("openid"u8);
                writer.WriteObjectValue(OpenId);
            }
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static AuthenticationSettingsContract DeserializeAuthenticationSettingsContract(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<OAuth2AuthenticationSettingsContract> oAuth2 = default;
            Optional<OpenIdAuthenticationSettingsContract> openid = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("oAuth2"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    oAuth2 = OAuth2AuthenticationSettingsContract.DeserializeOAuth2AuthenticationSettingsContract(property.Value);
                    continue;
                }
                if (property.NameEquals("openid"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    openid = OpenIdAuthenticationSettingsContract.DeserializeOpenIdAuthenticationSettingsContract(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AuthenticationSettingsContract(oAuth2.Value, openid.Value, rawData);
        }

        AuthenticationSettingsContract IModelJsonSerializable<AuthenticationSettingsContract>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAuthenticationSettingsContract(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AuthenticationSettingsContract>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AuthenticationSettingsContract IModelSerializable<AuthenticationSettingsContract>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAuthenticationSettingsContract(doc.RootElement, options);
        }

        public static implicit operator RequestContent(AuthenticationSettingsContract model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator AuthenticationSettingsContract(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAuthenticationSettingsContract(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
