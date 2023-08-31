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

namespace Azure.ResourceManager.Consumption.Models
{
    public partial class ConsumptionAmountWithExchangeRate : IUtf8JsonSerializable, IModelJsonSerializable<ConsumptionAmountWithExchangeRate>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ConsumptionAmountWithExchangeRate>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ConsumptionAmountWithExchangeRate>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ConsumptionAmountWithExchangeRate>(this, options.Format);

            writer.WriteStartObject();
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

        internal static ConsumptionAmountWithExchangeRate DeserializeConsumptionAmountWithExchangeRate(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<decimal> exchangeRate = default;
            Optional<int> exchangeRateMonth = default;
            Optional<string> currency = default;
            Optional<decimal> value = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("exchangeRate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    exchangeRate = property.Value.GetDecimal();
                    continue;
                }
                if (property.NameEquals("exchangeRateMonth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    exchangeRateMonth = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("currency"u8))
                {
                    currency = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    value = property.Value.GetDecimal();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ConsumptionAmountWithExchangeRate(currency.Value, Optional.ToNullable(value), Optional.ToNullable(exchangeRate), Optional.ToNullable(exchangeRateMonth), rawData);
        }

        ConsumptionAmountWithExchangeRate IModelJsonSerializable<ConsumptionAmountWithExchangeRate>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ConsumptionAmountWithExchangeRate>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeConsumptionAmountWithExchangeRate(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ConsumptionAmountWithExchangeRate>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ConsumptionAmountWithExchangeRate>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ConsumptionAmountWithExchangeRate IModelSerializable<ConsumptionAmountWithExchangeRate>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ConsumptionAmountWithExchangeRate>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeConsumptionAmountWithExchangeRate(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ConsumptionAmountWithExchangeRate"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ConsumptionAmountWithExchangeRate"/> to convert. </param>
        public static implicit operator RequestContent(ConsumptionAmountWithExchangeRate model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ConsumptionAmountWithExchangeRate"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ConsumptionAmountWithExchangeRate(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeConsumptionAmountWithExchangeRate(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
