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

namespace Azure.ResourceManager.BillingBenefits.Models
{
    public partial class BillingBenefitsCommitment : IUtf8JsonSerializable, IModelJsonSerializable<BillingBenefitsCommitment>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<BillingBenefitsCommitment>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<BillingBenefitsCommitment>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<BillingBenefitsCommitment>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Grain))
            {
                writer.WritePropertyName("grain"u8);
                writer.WriteStringValue(Grain.Value.ToString());
            }
            if (Optional.IsDefined(CurrencyCode))
            {
                writer.WritePropertyName("currencyCode"u8);
                writer.WriteStringValue(CurrencyCode);
            }
            if (Optional.IsDefined(Amount))
            {
                writer.WritePropertyName("amount"u8);
                writer.WriteNumberValue(Amount.Value);
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

        internal static BillingBenefitsCommitment DeserializeBillingBenefitsCommitment(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<BillingBenefitsCommitmentGrain> grain = default;
            Optional<string> currencyCode = default;
            Optional<double> amount = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("grain"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    grain = new BillingBenefitsCommitmentGrain(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("currencyCode"u8))
                {
                    currencyCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("amount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    amount = property.Value.GetDouble();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new BillingBenefitsCommitment(currencyCode.Value, Optional.ToNullable(amount), Optional.ToNullable(grain), rawData);
        }

        BillingBenefitsCommitment IModelJsonSerializable<BillingBenefitsCommitment>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<BillingBenefitsCommitment>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeBillingBenefitsCommitment(doc.RootElement, options);
        }

        BinaryData IModelSerializable<BillingBenefitsCommitment>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<BillingBenefitsCommitment>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        BillingBenefitsCommitment IModelSerializable<BillingBenefitsCommitment>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<BillingBenefitsCommitment>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeBillingBenefitsCommitment(doc.RootElement, options);
        }

        public static implicit operator RequestContent(BillingBenefitsCommitment model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator BillingBenefitsCommitment(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeBillingBenefitsCommitment(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
