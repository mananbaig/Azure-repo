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
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class AppCertificatePatch : IUtf8JsonSerializable, IModelJsonSerializable<AppCertificatePatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AppCertificatePatch>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AppCertificatePatch>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppCertificatePatch>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password"u8);
                writer.WriteStringValue(Password);
            }
            if (Optional.IsCollectionDefined(HostNames))
            {
                writer.WritePropertyName("hostNames"u8);
                writer.WriteStartArray();
                foreach (var item in HostNames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PfxBlob))
            {
                writer.WritePropertyName("pfxBlob"u8);
                writer.WriteBase64StringValue(PfxBlob, "D");
            }
            if (Optional.IsDefined(KeyVaultId))
            {
                writer.WritePropertyName("keyVaultId"u8);
                writer.WriteStringValue(KeyVaultId);
            }
            if (Optional.IsDefined(KeyVaultSecretName))
            {
                writer.WritePropertyName("keyVaultSecretName"u8);
                writer.WriteStringValue(KeyVaultSecretName);
            }
            if (Optional.IsDefined(ServerFarmId))
            {
                writer.WritePropertyName("serverFarmId"u8);
                writer.WriteStringValue(ServerFarmId);
            }
            if (Optional.IsDefined(CanonicalName))
            {
                writer.WritePropertyName("canonicalName"u8);
                writer.WriteStringValue(CanonicalName);
            }
            if (Optional.IsDefined(DomainValidationMethod))
            {
                writer.WritePropertyName("domainValidationMethod"u8);
                writer.WriteStringValue(DomainValidationMethod);
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

        internal static AppCertificatePatch DeserializeAppCertificatePatch(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> password = default;
            Optional<string> friendlyName = default;
            Optional<string> subjectName = default;
            Optional<IList<string>> hostNames = default;
            Optional<byte[]> pfxBlob = default;
            Optional<string> siteName = default;
            Optional<string> selfLink = default;
            Optional<string> issuer = default;
            Optional<DateTimeOffset> issueDate = default;
            Optional<DateTimeOffset> expirationDate = default;
            Optional<string> thumbprint = default;
            Optional<bool> valid = default;
            Optional<byte[]> cerBlob = default;
            Optional<string> publicKeyHash = default;
            Optional<HostingEnvironmentProfile> hostingEnvironmentProfile = default;
            Optional<ResourceIdentifier> keyVaultId = default;
            Optional<string> keyVaultSecretName = default;
            Optional<KeyVaultSecretStatus> keyVaultSecretStatus = default;
            Optional<ResourceIdentifier> serverFarmId = default;
            Optional<string> canonicalName = default;
            Optional<string> domainValidationMethod = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("password"u8))
                        {
                            password = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("friendlyName"u8))
                        {
                            friendlyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("subjectName"u8))
                        {
                            subjectName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("hostNames"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            hostNames = array;
                            continue;
                        }
                        if (property0.NameEquals("pfxBlob"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            pfxBlob = property0.Value.GetBytesFromBase64("D");
                            continue;
                        }
                        if (property0.NameEquals("siteName"u8))
                        {
                            siteName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("selfLink"u8))
                        {
                            selfLink = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("issuer"u8))
                        {
                            issuer = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("issueDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            issueDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("expirationDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            expirationDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("thumbprint"u8))
                        {
                            thumbprint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("valid"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            valid = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("cerBlob"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            cerBlob = property0.Value.GetBytesFromBase64("D");
                            continue;
                        }
                        if (property0.NameEquals("publicKeyHash"u8))
                        {
                            publicKeyHash = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("hostingEnvironmentProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hostingEnvironmentProfile = HostingEnvironmentProfile.DeserializeHostingEnvironmentProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("keyVaultId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            keyVaultId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("keyVaultSecretName"u8))
                        {
                            keyVaultSecretName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("keyVaultSecretStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            keyVaultSecretStatus = property0.Value.GetString().ToKeyVaultSecretStatus();
                            continue;
                        }
                        if (property0.NameEquals("serverFarmId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            serverFarmId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("canonicalName"u8))
                        {
                            canonicalName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("domainValidationMethod"u8))
                        {
                            domainValidationMethod = property0.Value.GetString();
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
            return new AppCertificatePatch(id, name, type, systemData.Value, password.Value, friendlyName.Value, subjectName.Value, Optional.ToList(hostNames), pfxBlob.Value, siteName.Value, selfLink.Value, issuer.Value, Optional.ToNullable(issueDate), Optional.ToNullable(expirationDate), thumbprint.Value, Optional.ToNullable(valid), cerBlob.Value, publicKeyHash.Value, hostingEnvironmentProfile.Value, keyVaultId.Value, keyVaultSecretName.Value, Optional.ToNullable(keyVaultSecretStatus), serverFarmId.Value, canonicalName.Value, domainValidationMethod.Value, kind.Value, serializedAdditionalRawData);
        }

        AppCertificatePatch IModelJsonSerializable<AppCertificatePatch>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppCertificatePatch>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAppCertificatePatch(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AppCertificatePatch>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppCertificatePatch>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AppCertificatePatch IModelSerializable<AppCertificatePatch>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppCertificatePatch>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAppCertificatePatch(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AppCertificatePatch"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AppCertificatePatch"/> to convert. </param>
        public static implicit operator RequestContent(AppCertificatePatch model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AppCertificatePatch"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AppCertificatePatch(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAppCertificatePatch(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
