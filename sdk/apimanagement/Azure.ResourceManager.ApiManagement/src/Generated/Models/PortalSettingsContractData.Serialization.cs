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

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class PortalSettingsContractData : IUtf8JsonSerializable, IModelJsonSerializable<PortalSettingsContractData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PortalSettingsContractData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PortalSettingsContractData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Uri))
            {
                writer.WritePropertyName("url"u8);
                writer.WriteStringValue(Uri.AbsoluteUri);
            }
            if (Optional.IsDefined(ValidationKey))
            {
                writer.WritePropertyName("validationKey"u8);
                writer.WriteStringValue(ValidationKey);
            }
            if (Optional.IsDefined(IsSubscriptions))
            {
                writer.WritePropertyName("subscriptions"u8);
                writer.WriteObjectValue(IsSubscriptions);
            }
            if (Optional.IsDefined(IsUserRegistration))
            {
                writer.WritePropertyName("userRegistration"u8);
                writer.WriteObjectValue(IsUserRegistration);
            }
            if (Optional.IsDefined(IsRedirectEnabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsRedirectEnabled.Value);
            }
            if (Optional.IsDefined(TermsOfService))
            {
                writer.WritePropertyName("termsOfService"u8);
                writer.WriteObjectValue(TermsOfService);
            }
            writer.WriteEndObject();
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

        internal static PortalSettingsContractData DeserializePortalSettingsContractData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<Uri> uri = default;
            Optional<string> validationKey = default;
            Optional<SubscriptionDelegationSettingProperties> subscriptions = default;
            Optional<RegistrationDelegationSettingProperties> userRegistration = default;
            Optional<bool> enabled = default;
            Optional<TermsOfServiceProperties> termsOfService = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("url"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            uri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("validationKey"u8))
                        {
                            validationKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("subscriptions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            subscriptions = SubscriptionDelegationSettingProperties.DeserializeSubscriptionDelegationSettingProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("userRegistration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            userRegistration = RegistrationDelegationSettingProperties.DeserializeRegistrationDelegationSettingProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("enabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("termsOfService"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            termsOfService = TermsOfServiceProperties.DeserializeTermsOfServiceProperties(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new PortalSettingsContractData(id, name, type, systemData.Value, uri.Value, validationKey.Value, subscriptions.Value, userRegistration.Value, Optional.ToNullable(enabled), termsOfService.Value, rawData);
        }

        PortalSettingsContractData IModelJsonSerializable<PortalSettingsContractData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePortalSettingsContractData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PortalSettingsContractData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PortalSettingsContractData IModelSerializable<PortalSettingsContractData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePortalSettingsContractData(doc.RootElement, options);
        }

        public static implicit operator RequestContent(PortalSettingsContractData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator PortalSettingsContractData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePortalSettingsContractData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
