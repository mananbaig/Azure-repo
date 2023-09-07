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
    public partial class SavingsPlanToPurchaseCalculateExchange : IUtf8JsonSerializable, IModelJsonSerializable<SavingsPlanToPurchaseCalculateExchange>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SavingsPlanToPurchaseCalculateExchange>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SavingsPlanToPurchaseCalculateExchange>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SavingsPlanToPurchaseCalculateExchange>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Properties))
            {
                writer.WritePropertyName("properties"u8);
                if (Properties is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<SavingsPlanPurchase>)Properties).Serialize(writer, options);
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
                    ((IModelJsonSerializable<PurchasePrice>)BillingCurrencyTotal).Serialize(writer, options);
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

        internal static SavingsPlanToPurchaseCalculateExchange DeserializeSavingsPlanToPurchaseCalculateExchange(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SavingsPlanPurchase> properties = default;
            Optional<PurchasePrice> billingCurrencyTotal = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    properties = SavingsPlanPurchase.DeserializeSavingsPlanPurchase(property.Value);
                    continue;
                }
                if (property.NameEquals("billingCurrencyTotal"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    billingCurrencyTotal = PurchasePrice.DeserializePurchasePrice(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SavingsPlanToPurchaseCalculateExchange(properties.Value, billingCurrencyTotal.Value, serializedAdditionalRawData);
        }

        SavingsPlanToPurchaseCalculateExchange IModelJsonSerializable<SavingsPlanToPurchaseCalculateExchange>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SavingsPlanToPurchaseCalculateExchange>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSavingsPlanToPurchaseCalculateExchange(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SavingsPlanToPurchaseCalculateExchange>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SavingsPlanToPurchaseCalculateExchange>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SavingsPlanToPurchaseCalculateExchange IModelSerializable<SavingsPlanToPurchaseCalculateExchange>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SavingsPlanToPurchaseCalculateExchange>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSavingsPlanToPurchaseCalculateExchange(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SavingsPlanToPurchaseCalculateExchange"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SavingsPlanToPurchaseCalculateExchange"/> to convert. </param>
        public static implicit operator RequestContent(SavingsPlanToPurchaseCalculateExchange model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SavingsPlanToPurchaseCalculateExchange"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SavingsPlanToPurchaseCalculateExchange(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSavingsPlanToPurchaseCalculateExchange(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
