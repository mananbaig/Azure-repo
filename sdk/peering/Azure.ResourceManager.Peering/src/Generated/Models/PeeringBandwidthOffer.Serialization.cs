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

namespace Azure.ResourceManager.Peering.Models
{
    public partial class PeeringBandwidthOffer : IUtf8JsonSerializable, IModelJsonSerializable<PeeringBandwidthOffer>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PeeringBandwidthOffer>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PeeringBandwidthOffer>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(OfferName))
            {
                writer.WritePropertyName("offerName"u8);
                writer.WriteStringValue(OfferName);
            }
            if (Optional.IsDefined(ValueInMbps))
            {
                writer.WritePropertyName("valueInMbps"u8);
                writer.WriteNumberValue(ValueInMbps.Value);
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

        internal static PeeringBandwidthOffer DeserializePeeringBandwidthOffer(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> offerName = default;
            Optional<int> valueInMbps = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("offerName"u8))
                {
                    offerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("valueInMbps"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valueInMbps = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new PeeringBandwidthOffer(offerName.Value, Optional.ToNullable(valueInMbps), rawData);
        }

        PeeringBandwidthOffer IModelJsonSerializable<PeeringBandwidthOffer>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePeeringBandwidthOffer(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PeeringBandwidthOffer>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PeeringBandwidthOffer IModelSerializable<PeeringBandwidthOffer>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePeeringBandwidthOffer(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="PeeringBandwidthOffer"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="PeeringBandwidthOffer"/> to convert. </param>
        public static implicit operator RequestContent(PeeringBandwidthOffer model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="PeeringBandwidthOffer"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator PeeringBandwidthOffer(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePeeringBandwidthOffer(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
