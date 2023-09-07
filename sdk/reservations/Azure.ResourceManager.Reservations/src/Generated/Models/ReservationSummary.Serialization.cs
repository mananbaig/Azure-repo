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
    internal partial class ReservationSummary : IUtf8JsonSerializable, IModelJsonSerializable<ReservationSummary>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ReservationSummary>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ReservationSummary>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ReservationSummary>(this, options.Format);

            writer.WriteStartObject();
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

        internal static ReservationSummary DeserializeReservationSummary(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<float> succeededCount = default;
            Optional<float> failedCount = default;
            Optional<float> expiringCount = default;
            Optional<float> expiredCount = default;
            Optional<float> pendingCount = default;
            Optional<float> cancelledCount = default;
            Optional<float> processingCount = default;
            Optional<float> warningCount = default;
            Optional<float> noBenefitCount = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("succeededCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    succeededCount = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("failedCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    failedCount = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("expiringCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expiringCount = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("expiredCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expiredCount = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("pendingCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pendingCount = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("cancelledCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cancelledCount = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("processingCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    processingCount = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("warningCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    warningCount = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("noBenefitCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    noBenefitCount = property.Value.GetSingle();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ReservationSummary(Optional.ToNullable(succeededCount), Optional.ToNullable(failedCount), Optional.ToNullable(expiringCount), Optional.ToNullable(expiredCount), Optional.ToNullable(pendingCount), Optional.ToNullable(cancelledCount), Optional.ToNullable(processingCount), Optional.ToNullable(warningCount), Optional.ToNullable(noBenefitCount), serializedAdditionalRawData);
        }

        ReservationSummary IModelJsonSerializable<ReservationSummary>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ReservationSummary>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeReservationSummary(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ReservationSummary>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ReservationSummary>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ReservationSummary IModelSerializable<ReservationSummary>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ReservationSummary>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeReservationSummary(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ReservationSummary"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ReservationSummary"/> to convert. </param>
        public static implicit operator RequestContent(ReservationSummary model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ReservationSummary"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ReservationSummary(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeReservationSummary(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
