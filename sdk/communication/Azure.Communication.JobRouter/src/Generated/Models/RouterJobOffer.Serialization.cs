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

namespace Azure.Communication.JobRouter.Models
{
    public partial class RouterJobOffer : IUtf8JsonSerializable, IModelJsonSerializable<RouterJobOffer>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<RouterJobOffer>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<RouterJobOffer>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("offerId"u8);
            writer.WriteStringValue(OfferId);
            writer.WritePropertyName("jobId"u8);
            writer.WriteStringValue(JobId);
            writer.WritePropertyName("capacityCost"u8);
            writer.WriteNumberValue(CapacityCost);
            if (Optional.IsDefined(OfferedAt))
            {
                writer.WritePropertyName("offeredAt"u8);
                writer.WriteStringValue(OfferedAt.Value, "O");
            }
            if (Optional.IsDefined(ExpiresAt))
            {
                writer.WritePropertyName("expiresAt"u8);
                writer.WriteStringValue(ExpiresAt.Value, "O");
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

        internal static RouterJobOffer DeserializeRouterJobOffer(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string offerId = default;
            string jobId = default;
            int capacityCost = default;
            Optional<DateTimeOffset> offeredAt = default;
            Optional<DateTimeOffset> expiresAt = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("offerId"u8))
                {
                    offerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobId"u8))
                {
                    jobId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("capacityCost"u8))
                {
                    capacityCost = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("offeredAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    offeredAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("expiresAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expiresAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new RouterJobOffer(offerId, jobId, capacityCost, Optional.ToNullable(offeredAt), Optional.ToNullable(expiresAt), rawData);
        }

        RouterJobOffer IModelJsonSerializable<RouterJobOffer>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeRouterJobOffer(doc.RootElement, options);
        }

        BinaryData IModelSerializable<RouterJobOffer>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        RouterJobOffer IModelSerializable<RouterJobOffer>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeRouterJobOffer(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="RouterJobOffer"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="RouterJobOffer"/> to convert. </param>
        public static implicit operator RequestContent(RouterJobOffer model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="RouterJobOffer"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator RouterJobOffer(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeRouterJobOffer(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
