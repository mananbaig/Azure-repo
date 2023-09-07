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

namespace Azure.ResourceManager.Reservations.Models
{
    public partial class RenewProperties : IUtf8JsonSerializable, IModelJsonSerializable<RenewProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<RenewProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<RenewProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RenewProperties>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(PurchaseProperties))
            {
                writer.WritePropertyName("purchaseProperties"u8);
                if (PurchaseProperties is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ReservationPurchaseContent>)PurchaseProperties).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(PricingCurrencyTotal))
            {
                writer.WritePropertyName("pricingCurrencyTotal"u8);
                if (PricingCurrencyTotal is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<RenewPropertiesPricingCurrencyTotal>)PricingCurrencyTotal).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(BillingCurrencyTotal))
            {
                writer.WritePropertyName("billingCurrencyTotal"u8);
                if (BillingCurrencyTotal is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<RenewPropertiesBillingCurrencyTotal>)BillingCurrencyTotal).Serialize(writer, options);
                }
            }
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

        internal static RenewProperties DeserializeRenewProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ReservationPurchaseContent> purchaseProperties = default;
            Optional<RenewPropertiesPricingCurrencyTotal> pricingCurrencyTotal = default;
            Optional<RenewPropertiesBillingCurrencyTotal> billingCurrencyTotal = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("purchaseProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    purchaseProperties = ReservationPurchaseContent.DeserializeReservationPurchaseContent(property.Value);
                    continue;
                }
                if (property.NameEquals("pricingCurrencyTotal"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pricingCurrencyTotal = RenewPropertiesPricingCurrencyTotal.DeserializeRenewPropertiesPricingCurrencyTotal(property.Value);
                    continue;
                }
                if (property.NameEquals("billingCurrencyTotal"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    billingCurrencyTotal = RenewPropertiesBillingCurrencyTotal.DeserializeRenewPropertiesBillingCurrencyTotal(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new RenewProperties(purchaseProperties.Value, pricingCurrencyTotal.Value, billingCurrencyTotal.Value, serializedAdditionalRawData);
        }

        RenewProperties IModelJsonSerializable<RenewProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RenewProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeRenewProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<RenewProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RenewProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        RenewProperties IModelSerializable<RenewProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RenewProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeRenewProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="RenewProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="RenewProperties"/> to convert. </param>
        public static implicit operator RequestContent(RenewProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="RenewProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator RenewProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeRenewProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
