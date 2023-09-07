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

namespace Azure.ResourceManager.Qumulo.Models
{
    public partial class MarketplaceDetails : IUtf8JsonSerializable, IModelJsonSerializable<MarketplaceDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MarketplaceDetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MarketplaceDetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MarketplaceDetails>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(MarketplaceSubscriptionId))
            {
                writer.WritePropertyName("marketplaceSubscriptionId"u8);
                writer.WriteStringValue(MarketplaceSubscriptionId);
            }
            writer.WritePropertyName("planId"u8);
            writer.WriteStringValue(PlanId);
            writer.WritePropertyName("offerId"u8);
            writer.WriteStringValue(OfferId);
            writer.WritePropertyName("publisherId"u8);
            writer.WriteStringValue(PublisherId);
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

        internal static MarketplaceDetails DeserializeMarketplaceDetails(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> marketplaceSubscriptionId = default;
            string planId = default;
            string offerId = default;
            string publisherId = default;
            Optional<MarketplaceSubscriptionStatus> marketplaceSubscriptionStatus = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("marketplaceSubscriptionId"u8))
                {
                    marketplaceSubscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("planId"u8))
                {
                    planId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("offerId"u8))
                {
                    offerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("publisherId"u8))
                {
                    publisherId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("marketplaceSubscriptionStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    marketplaceSubscriptionStatus = property.Value.GetString().ToMarketplaceSubscriptionStatus();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MarketplaceDetails(marketplaceSubscriptionId.Value, planId, offerId, publisherId, Optional.ToNullable(marketplaceSubscriptionStatus), serializedAdditionalRawData);
        }

        MarketplaceDetails IModelJsonSerializable<MarketplaceDetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MarketplaceDetails>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMarketplaceDetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MarketplaceDetails>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MarketplaceDetails>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MarketplaceDetails IModelSerializable<MarketplaceDetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MarketplaceDetails>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMarketplaceDetails(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MarketplaceDetails"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MarketplaceDetails"/> to convert. </param>
        public static implicit operator RequestContent(MarketplaceDetails model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MarketplaceDetails"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MarketplaceDetails(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMarketplaceDetails(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
