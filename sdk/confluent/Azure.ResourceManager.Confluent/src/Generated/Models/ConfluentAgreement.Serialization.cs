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

namespace Azure.ResourceManager.Confluent.Models
{
    public partial class ConfluentAgreement : IUtf8JsonSerializable, IModelJsonSerializable<ConfluentAgreement>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ConfluentAgreement>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ConfluentAgreement>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Publisher))
            {
                writer.WritePropertyName("publisher"u8);
                writer.WriteStringValue(Publisher);
            }
            if (Optional.IsDefined(Product))
            {
                writer.WritePropertyName("product"u8);
                writer.WriteStringValue(Product);
            }
            if (Optional.IsDefined(Plan))
            {
                writer.WritePropertyName("plan"u8);
                writer.WriteStringValue(Plan);
            }
            if (Optional.IsDefined(LicenseTextLink))
            {
                writer.WritePropertyName("licenseTextLink"u8);
                writer.WriteStringValue(LicenseTextLink);
            }
            if (Optional.IsDefined(PrivacyPolicyLink))
            {
                writer.WritePropertyName("privacyPolicyLink"u8);
                writer.WriteStringValue(PrivacyPolicyLink);
            }
            if (Optional.IsDefined(RetrieveOn))
            {
                writer.WritePropertyName("retrieveDatetime"u8);
                writer.WriteStringValue(RetrieveOn.Value, "O");
            }
            if (Optional.IsDefined(Signature))
            {
                writer.WritePropertyName("signature"u8);
                writer.WriteStringValue(Signature);
            }
            if (Optional.IsDefined(IsAccepted))
            {
                writer.WritePropertyName("accepted"u8);
                writer.WriteBooleanValue(IsAccepted.Value);
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

        internal static ConfluentAgreement DeserializeConfluentAgreement(JsonElement element, ModelSerializerOptions options = default)
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
            Optional<string> publisher = default;
            Optional<string> product = default;
            Optional<string> plan = default;
            Optional<string> licenseTextLink = default;
            Optional<string> privacyPolicyLink = default;
            Optional<DateTimeOffset> retrieveDatetime = default;
            Optional<string> signature = default;
            Optional<bool> accepted = default;
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
                        if (property0.NameEquals("publisher"u8))
                        {
                            publisher = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("product"u8))
                        {
                            product = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("plan"u8))
                        {
                            plan = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("licenseTextLink"u8))
                        {
                            licenseTextLink = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("privacyPolicyLink"u8))
                        {
                            privacyPolicyLink = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("retrieveDatetime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            retrieveDatetime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("signature"u8))
                        {
                            signature = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("accepted"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            accepted = property0.Value.GetBoolean();
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
            return new ConfluentAgreement(id, name, type, systemData.Value, publisher.Value, product.Value, plan.Value, licenseTextLink.Value, privacyPolicyLink.Value, Optional.ToNullable(retrieveDatetime), signature.Value, Optional.ToNullable(accepted), rawData);
        }

        ConfluentAgreement IModelJsonSerializable<ConfluentAgreement>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeConfluentAgreement(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ConfluentAgreement>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ConfluentAgreement IModelSerializable<ConfluentAgreement>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeConfluentAgreement(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ConfluentAgreement model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ConfluentAgreement(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeConfluentAgreement(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
