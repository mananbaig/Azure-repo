// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Reservations.Models
{
    public partial class ReservationRefundRequestProperties : IUtf8JsonSerializable, IJsonModel<ReservationRefundRequestProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ReservationRefundRequestProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ReservationRefundRequestProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationRefundRequestProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReservationRefundRequestProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(SessionId))
            {
                writer.WritePropertyName("sessionId"u8);
                writer.WriteStringValue(SessionId.Value);
            }
            if (Optional.IsDefined(Scope))
            {
                writer.WritePropertyName("scope"u8);
                writer.WriteStringValue(Scope);
            }
            if (Optional.IsDefined(ReservationToReturn))
            {
                writer.WritePropertyName("reservationToReturn"u8);
                writer.WriteObjectValue(ReservationToReturn, options);
            }
            if (Optional.IsDefined(ReturnReason))
            {
                writer.WritePropertyName("returnReason"u8);
                writer.WriteStringValue(ReturnReason);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        ReservationRefundRequestProperties IJsonModel<ReservationRefundRequestProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationRefundRequestProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReservationRefundRequestProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeReservationRefundRequestProperties(document.RootElement, options);
        }

        internal static ReservationRefundRequestProperties DeserializeReservationRefundRequestProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Guid? sessionId = default;
            string scope = default;
            ReservationToReturn reservationToReturn = default;
            string returnReason = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sessionId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sessionId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("scope"u8))
                {
                    scope = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("reservationToReturn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reservationToReturn = ReservationToReturn.DeserializeReservationToReturn(property.Value, options);
                    continue;
                }
                if (property.NameEquals("returnReason"u8))
                {
                    returnReason = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ReservationRefundRequestProperties(sessionId, scope, reservationToReturn, returnReason, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ReservationRefundRequestProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationRefundRequestProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ReservationRefundRequestProperties)} does not support writing '{options.Format}' format.");
            }
        }

        ReservationRefundRequestProperties IPersistableModel<ReservationRefundRequestProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationRefundRequestProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeReservationRefundRequestProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ReservationRefundRequestProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ReservationRefundRequestProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
