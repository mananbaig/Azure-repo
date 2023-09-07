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
    public partial class CalculateExchangeContentProperties : IUtf8JsonSerializable, IModelJsonSerializable<CalculateExchangeContentProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CalculateExchangeContentProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CalculateExchangeContentProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CalculateExchangeContentProperties>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(ReservationsToPurchase))
            {
                writer.WritePropertyName("reservationsToPurchase"u8);
                writer.WriteStartArray();
                foreach (var item in ReservationsToPurchase)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<ReservationPurchaseContent>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(SavingsPlansToPurchase))
            {
                writer.WritePropertyName("savingsPlansToPurchase"u8);
                writer.WriteStartArray();
                foreach (var item in SavingsPlansToPurchase)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<SavingsPlanPurchase>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ReservationsToExchange))
            {
                writer.WritePropertyName("reservationsToExchange"u8);
                writer.WriteStartArray();
                foreach (var item in ReservationsToExchange)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<ReservationToReturn>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
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

        internal static CalculateExchangeContentProperties DeserializeCalculateExchangeContentProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<ReservationPurchaseContent>> reservationsToPurchase = default;
            Optional<IList<SavingsPlanPurchase>> savingsPlansToPurchase = default;
            Optional<IList<ReservationToReturn>> reservationsToExchange = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("reservationsToPurchase"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ReservationPurchaseContent> array = new List<ReservationPurchaseContent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReservationPurchaseContent.DeserializeReservationPurchaseContent(item));
                    }
                    reservationsToPurchase = array;
                    continue;
                }
                if (property.NameEquals("savingsPlansToPurchase"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SavingsPlanPurchase> array = new List<SavingsPlanPurchase>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SavingsPlanPurchase.DeserializeSavingsPlanPurchase(item));
                    }
                    savingsPlansToPurchase = array;
                    continue;
                }
                if (property.NameEquals("reservationsToExchange"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ReservationToReturn> array = new List<ReservationToReturn>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReservationToReturn.DeserializeReservationToReturn(item));
                    }
                    reservationsToExchange = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CalculateExchangeContentProperties(Optional.ToList(reservationsToPurchase), Optional.ToList(savingsPlansToPurchase), Optional.ToList(reservationsToExchange), serializedAdditionalRawData);
        }

        CalculateExchangeContentProperties IModelJsonSerializable<CalculateExchangeContentProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CalculateExchangeContentProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCalculateExchangeContentProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CalculateExchangeContentProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CalculateExchangeContentProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CalculateExchangeContentProperties IModelSerializable<CalculateExchangeContentProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CalculateExchangeContentProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCalculateExchangeContentProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CalculateExchangeContentProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CalculateExchangeContentProperties"/> to convert. </param>
        public static implicit operator RequestContent(CalculateExchangeContentProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CalculateExchangeContentProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CalculateExchangeContentProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCalculateExchangeContentProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
