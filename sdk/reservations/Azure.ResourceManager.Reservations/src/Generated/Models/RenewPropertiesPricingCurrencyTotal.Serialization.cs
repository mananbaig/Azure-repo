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
    public partial class RenewPropertiesPricingCurrencyTotal : IUtf8JsonSerializable, IModelJsonSerializable<RenewPropertiesPricingCurrencyTotal>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<RenewPropertiesPricingCurrencyTotal>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<RenewPropertiesPricingCurrencyTotal>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RenewPropertiesPricingCurrencyTotal>(this, options.Format);

            writer.WriteStartObject();
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

        internal static RenewPropertiesPricingCurrencyTotal DeserializeRenewPropertiesPricingCurrencyTotal(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> currencyCode = default;
            Optional<float> amount = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                    amount = property.Value.GetSingle();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new RenewPropertiesPricingCurrencyTotal(currencyCode.Value, Optional.ToNullable(amount), serializedAdditionalRawData);
        }

        RenewPropertiesPricingCurrencyTotal IModelJsonSerializable<RenewPropertiesPricingCurrencyTotal>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RenewPropertiesPricingCurrencyTotal>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeRenewPropertiesPricingCurrencyTotal(doc.RootElement, options);
        }

        BinaryData IModelSerializable<RenewPropertiesPricingCurrencyTotal>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RenewPropertiesPricingCurrencyTotal>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        RenewPropertiesPricingCurrencyTotal IModelSerializable<RenewPropertiesPricingCurrencyTotal>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RenewPropertiesPricingCurrencyTotal>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeRenewPropertiesPricingCurrencyTotal(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="RenewPropertiesPricingCurrencyTotal"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="RenewPropertiesPricingCurrencyTotal"/> to convert. </param>
        public static implicit operator RequestContent(RenewPropertiesPricingCurrencyTotal model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="RenewPropertiesPricingCurrencyTotal"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator RenewPropertiesPricingCurrencyTotal(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeRenewPropertiesPricingCurrencyTotal(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
