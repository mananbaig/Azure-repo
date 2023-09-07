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
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class AppServiceCertificateOrderData : IUtf8JsonSerializable, IModelJsonSerializable<AppServiceCertificateOrderData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AppServiceCertificateOrderData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AppServiceCertificateOrderData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppServiceCertificateOrderData>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Certificates))
            {
                writer.WritePropertyName("certificates"u8);
                writer.WriteStartObject();
                foreach (var item in Certificates)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<AppServiceCertificateProperties>)item.Value).Serialize(writer, options);
                    }
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(DistinguishedName))
            {
                writer.WritePropertyName("distinguishedName"u8);
                writer.WriteStringValue(DistinguishedName);
            }
            if (Optional.IsDefined(ValidityInYears))
            {
                writer.WritePropertyName("validityInYears"u8);
                writer.WriteNumberValue(ValidityInYears.Value);
            }
            if (Optional.IsDefined(KeySize))
            {
                writer.WritePropertyName("keySize"u8);
                writer.WriteNumberValue(KeySize.Value);
            }
            if (Optional.IsDefined(ProductType))
            {
                writer.WritePropertyName("productType"u8);
                writer.WriteStringValue(ProductType.Value.ToSerialString());
            }
            if (Optional.IsDefined(IsAutoRenew))
            {
                writer.WritePropertyName("autoRenew"u8);
                writer.WriteBooleanValue(IsAutoRenew.Value);
            }
            if (Optional.IsDefined(Csr))
            {
                writer.WritePropertyName("csr"u8);
                writer.WriteStringValue(Csr);
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

        internal static AppServiceCertificateOrderData DeserializeAppServiceCertificateOrderData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> kind = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<IDictionary<string, AppServiceCertificateProperties>> certificates = default;
            Optional<string> distinguishedName = default;
            Optional<string> domainVerificationToken = default;
            Optional<int> validityInYears = default;
            Optional<int> keySize = default;
            Optional<CertificateProductType> productType = default;
            Optional<bool> autoRenew = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<CertificateOrderStatus> status = default;
            Optional<AppServiceCertificateDetails> signedCertificate = default;
            Optional<string> csr = default;
            Optional<AppServiceCertificateDetails> intermediate = default;
            Optional<AppServiceCertificateDetails> root = default;
            Optional<string> serialNumber = default;
            Optional<DateTimeOffset> lastCertificateIssuanceTime = default;
            Optional<DateTimeOffset> expirationTime = default;
            Optional<bool> isPrivateKeyExternal = default;
            Optional<IReadOnlyList<AppServiceCertificateNotRenewableReason>> appServiceCertificateNotRenewableReasons = default;
            Optional<DateTimeOffset> nextAutoRenewalTimeStamp = default;
            Optional<CertificateOrderContact> contact = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
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
                        if (property0.NameEquals("certificates"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, AppServiceCertificateProperties> dictionary = new Dictionary<string, AppServiceCertificateProperties>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, AppServiceCertificateProperties.DeserializeAppServiceCertificateProperties(property1.Value));
                            }
                            certificates = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("distinguishedName"u8))
                        {
                            distinguishedName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("domainVerificationToken"u8))
                        {
                            domainVerificationToken = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("validityInYears"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            validityInYears = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("keySize"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            keySize = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("productType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            productType = property0.Value.GetString().ToCertificateProductType();
                            continue;
                        }
                        if (property0.NameEquals("autoRenew"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            autoRenew = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = property0.Value.GetString().ToProvisioningState();
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = property0.Value.GetString().ToCertificateOrderStatus();
                            continue;
                        }
                        if (property0.NameEquals("signedCertificate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            signedCertificate = AppServiceCertificateDetails.DeserializeAppServiceCertificateDetails(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("csr"u8))
                        {
                            csr = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("intermediate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            intermediate = AppServiceCertificateDetails.DeserializeAppServiceCertificateDetails(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("root"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            root = AppServiceCertificateDetails.DeserializeAppServiceCertificateDetails(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("serialNumber"u8))
                        {
                            serialNumber = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastCertificateIssuanceTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastCertificateIssuanceTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("expirationTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            expirationTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("isPrivateKeyExternal"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isPrivateKeyExternal = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("appServiceCertificateNotRenewableReasons"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AppServiceCertificateNotRenewableReason> array = new List<AppServiceCertificateNotRenewableReason>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new AppServiceCertificateNotRenewableReason(item.GetString()));
                            }
                            appServiceCertificateNotRenewableReasons = array;
                            continue;
                        }
                        if (property0.NameEquals("nextAutoRenewalTimeStamp"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            nextAutoRenewalTimeStamp = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("contact"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            contact = CertificateOrderContact.DeserializeCertificateOrderContact(property0.Value);
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
            return new AppServiceCertificateOrderData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, Optional.ToDictionary(certificates), distinguishedName.Value, domainVerificationToken.Value, Optional.ToNullable(validityInYears), Optional.ToNullable(keySize), Optional.ToNullable(productType), Optional.ToNullable(autoRenew), Optional.ToNullable(provisioningState), Optional.ToNullable(status), signedCertificate.Value, csr.Value, intermediate.Value, root.Value, serialNumber.Value, Optional.ToNullable(lastCertificateIssuanceTime), Optional.ToNullable(expirationTime), Optional.ToNullable(isPrivateKeyExternal), Optional.ToList(appServiceCertificateNotRenewableReasons), Optional.ToNullable(nextAutoRenewalTimeStamp), contact.Value, kind.Value, serializedAdditionalRawData);
        }

        AppServiceCertificateOrderData IModelJsonSerializable<AppServiceCertificateOrderData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppServiceCertificateOrderData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAppServiceCertificateOrderData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AppServiceCertificateOrderData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppServiceCertificateOrderData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AppServiceCertificateOrderData IModelSerializable<AppServiceCertificateOrderData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppServiceCertificateOrderData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAppServiceCertificateOrderData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AppServiceCertificateOrderData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AppServiceCertificateOrderData"/> to convert. </param>
        public static implicit operator RequestContent(AppServiceCertificateOrderData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AppServiceCertificateOrderData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AppServiceCertificateOrderData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAppServiceCertificateOrderData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
