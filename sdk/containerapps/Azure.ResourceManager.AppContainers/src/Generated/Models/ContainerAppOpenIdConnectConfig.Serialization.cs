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

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppOpenIdConnectConfig : IUtf8JsonSerializable, IModelJsonSerializable<ContainerAppOpenIdConnectConfig>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ContainerAppOpenIdConnectConfig>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ContainerAppOpenIdConnectConfig>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(AuthorizationEndpoint))
            {
                writer.WritePropertyName("authorizationEndpoint"u8);
                writer.WriteStringValue(AuthorizationEndpoint);
            }
            if (Optional.IsDefined(TokenEndpoint))
            {
                writer.WritePropertyName("tokenEndpoint"u8);
                writer.WriteStringValue(TokenEndpoint);
            }
            if (Optional.IsDefined(Issuer))
            {
                writer.WritePropertyName("issuer"u8);
                writer.WriteStringValue(Issuer);
            }
            if (Optional.IsDefined(CertificationUri))
            {
                writer.WritePropertyName("certificationUri"u8);
                writer.WriteStringValue(CertificationUri.AbsoluteUri);
            }
            if (Optional.IsDefined(WellKnownOpenIdConfiguration))
            {
                writer.WritePropertyName("wellKnownOpenIdConfiguration"u8);
                writer.WriteStringValue(WellKnownOpenIdConfiguration);
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

        internal static ContainerAppOpenIdConnectConfig DeserializeContainerAppOpenIdConnectConfig(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> authorizationEndpoint = default;
            Optional<string> tokenEndpoint = default;
            Optional<string> issuer = default;
            Optional<Uri> certificationUri = default;
            Optional<string> wellKnownOpenIdConfiguration = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("authorizationEndpoint"u8))
                {
                    authorizationEndpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tokenEndpoint"u8))
                {
                    tokenEndpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("issuer"u8))
                {
                    issuer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("certificationUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    certificationUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("wellKnownOpenIdConfiguration"u8))
                {
                    wellKnownOpenIdConfiguration = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ContainerAppOpenIdConnectConfig(authorizationEndpoint.Value, tokenEndpoint.Value, issuer.Value, certificationUri.Value, wellKnownOpenIdConfiguration.Value, rawData);
        }

        ContainerAppOpenIdConnectConfig IModelJsonSerializable<ContainerAppOpenIdConnectConfig>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppOpenIdConnectConfig(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ContainerAppOpenIdConnectConfig>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ContainerAppOpenIdConnectConfig IModelSerializable<ContainerAppOpenIdConnectConfig>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeContainerAppOpenIdConnectConfig(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ContainerAppOpenIdConnectConfig"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ContainerAppOpenIdConnectConfig"/> to convert. </param>
        public static implicit operator RequestContent(ContainerAppOpenIdConnectConfig model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ContainerAppOpenIdConnectConfig"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ContainerAppOpenIdConnectConfig(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeContainerAppOpenIdConnectConfig(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
