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
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.FrontDoor.Models
{
    public partial class CustomHttpsConfiguration : IUtf8JsonSerializable, IModelJsonSerializable<CustomHttpsConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CustomHttpsConfiguration>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CustomHttpsConfiguration>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CustomHttpsConfiguration>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("certificateSource"u8);
            writer.WriteStringValue(CertificateSource.ToString());
            writer.WritePropertyName("protocolType"u8);
            writer.WriteStringValue(ProtocolType.ToString());
            writer.WritePropertyName("minimumTlsVersion"u8);
            writer.WriteStringValue(MinimumTlsVersion.ToString());
            writer.WritePropertyName("frontDoorCertificateSourceParameters"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(CertificateType))
            {
                writer.WritePropertyName("certificateType"u8);
                writer.WriteStringValue(CertificateType.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WritePropertyName("keyVaultCertificateSourceParameters"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Vault))
            {
                writer.WritePropertyName("vault"u8);
                JsonSerializer.Serialize(writer, Vault);
            }
            if (Optional.IsDefined(SecretName))
            {
                writer.WritePropertyName("secretName"u8);
                writer.WriteStringValue(SecretName);
            }
            if (Optional.IsDefined(SecretVersion))
            {
                writer.WritePropertyName("secretVersion"u8);
                writer.WriteStringValue(SecretVersion);
            }
            writer.WriteEndObject();
            if (_serializedAdditionalRawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _serializedAdditionalRawData)
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

        internal static CustomHttpsConfiguration DeserializeCustomHttpsConfiguration(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            FrontDoorCertificateSource certificateSource = default;
            FrontDoorTlsProtocolType protocolType = default;
            FrontDoorRequiredMinimumTlsVersion minimumTlsVersion = default;
            Optional<FrontDoorEndpointConnectionCertificateType> certificateType = default;
            Optional<WritableSubResource> vault = default;
            Optional<string> secretName = default;
            Optional<string> secretVersion = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("certificateSource"u8))
                {
                    certificateSource = new FrontDoorCertificateSource(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("protocolType"u8))
                {
                    protocolType = new FrontDoorTlsProtocolType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("minimumTlsVersion"u8))
                {
                    minimumTlsVersion = new FrontDoorRequiredMinimumTlsVersion(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("frontDoorCertificateSourceParameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("certificateType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            certificateType = new FrontDoorEndpointConnectionCertificateType(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (property.NameEquals("keyVaultCertificateSourceParameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("vault"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            vault = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("secretName"u8))
                        {
                            secretName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("secretVersion"u8))
                        {
                            secretVersion = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CustomHttpsConfiguration(certificateSource, protocolType, minimumTlsVersion, Optional.ToNullable(certificateType), vault, secretName.Value, secretVersion.Value, serializedAdditionalRawData);
        }

        CustomHttpsConfiguration IModelJsonSerializable<CustomHttpsConfiguration>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CustomHttpsConfiguration>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCustomHttpsConfiguration(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CustomHttpsConfiguration>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CustomHttpsConfiguration>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CustomHttpsConfiguration IModelSerializable<CustomHttpsConfiguration>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CustomHttpsConfiguration>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCustomHttpsConfiguration(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CustomHttpsConfiguration"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CustomHttpsConfiguration"/> to convert. </param>
        public static implicit operator RequestContent(CustomHttpsConfiguration model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CustomHttpsConfiguration"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CustomHttpsConfiguration(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCustomHttpsConfiguration(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
