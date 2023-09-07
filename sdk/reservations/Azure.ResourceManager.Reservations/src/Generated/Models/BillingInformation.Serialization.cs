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
    public partial class BillingInformation : IUtf8JsonSerializable, IModelJsonSerializable<BillingInformation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<BillingInformation>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<BillingInformation>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BillingInformation>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(BillingCurrencyTotalPaidAmount))
            {
                writer.WritePropertyName("billingCurrencyTotalPaidAmount"u8);
                if (BillingCurrencyTotalPaidAmount is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<PurchasePrice>)BillingCurrencyTotalPaidAmount).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(BillingCurrencyProratedAmount))
            {
                writer.WritePropertyName("billingCurrencyProratedAmount"u8);
                if (BillingCurrencyProratedAmount is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<PurchasePrice>)BillingCurrencyProratedAmount).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(BillingCurrencyRemainingCommitmentAmount))
            {
                writer.WritePropertyName("billingCurrencyRemainingCommitmentAmount"u8);
                if (BillingCurrencyRemainingCommitmentAmount is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<PurchasePrice>)BillingCurrencyRemainingCommitmentAmount).Serialize(writer, options);
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

        internal static BillingInformation DeserializeBillingInformation(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<PurchasePrice> billingCurrencyTotalPaidAmount = default;
            Optional<PurchasePrice> billingCurrencyProratedAmount = default;
            Optional<PurchasePrice> billingCurrencyRemainingCommitmentAmount = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("billingCurrencyTotalPaidAmount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    billingCurrencyTotalPaidAmount = PurchasePrice.DeserializePurchasePrice(property.Value);
                    continue;
                }
                if (property.NameEquals("billingCurrencyProratedAmount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    billingCurrencyProratedAmount = PurchasePrice.DeserializePurchasePrice(property.Value);
                    continue;
                }
                if (property.NameEquals("billingCurrencyRemainingCommitmentAmount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    billingCurrencyRemainingCommitmentAmount = PurchasePrice.DeserializePurchasePrice(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new BillingInformation(billingCurrencyTotalPaidAmount.Value, billingCurrencyProratedAmount.Value, billingCurrencyRemainingCommitmentAmount.Value, serializedAdditionalRawData);
        }

        BillingInformation IModelJsonSerializable<BillingInformation>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BillingInformation>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeBillingInformation(doc.RootElement, options);
        }

        BinaryData IModelSerializable<BillingInformation>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BillingInformation>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        BillingInformation IModelSerializable<BillingInformation>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BillingInformation>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeBillingInformation(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="BillingInformation"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="BillingInformation"/> to convert. </param>
        public static implicit operator RequestContent(BillingInformation model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="BillingInformation"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator BillingInformation(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeBillingInformation(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
