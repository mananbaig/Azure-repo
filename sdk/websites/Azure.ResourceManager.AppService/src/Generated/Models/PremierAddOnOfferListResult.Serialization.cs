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

namespace Azure.ResourceManager.AppService.Models
{
    internal partial class PremierAddOnOfferListResult : IUtf8JsonSerializable, IModelJsonSerializable<PremierAddOnOfferListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PremierAddOnOfferListResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PremierAddOnOfferListResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PremierAddOnOfferListResult>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("value"u8);
            writer.WriteStartArray();
            foreach (var item in Value)
            {
                if (item is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<PremierAddOnOffer>)item).Serialize(writer, options);
                }
            }
            writer.WriteEndArray();
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

        internal static PremierAddOnOfferListResult DeserializePremierAddOnOfferListResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<PremierAddOnOffer> value = default;
            Optional<string> nextLink = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<PremierAddOnOffer> array = new List<PremierAddOnOffer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PremierAddOnOffer.DeserializePremierAddOnOffer(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new PremierAddOnOfferListResult(value, nextLink.Value, serializedAdditionalRawData);
        }

        PremierAddOnOfferListResult IModelJsonSerializable<PremierAddOnOfferListResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PremierAddOnOfferListResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePremierAddOnOfferListResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PremierAddOnOfferListResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PremierAddOnOfferListResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PremierAddOnOfferListResult IModelSerializable<PremierAddOnOfferListResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PremierAddOnOfferListResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePremierAddOnOfferListResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="PremierAddOnOfferListResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="PremierAddOnOfferListResult"/> to convert. </param>
        public static implicit operator RequestContent(PremierAddOnOfferListResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="PremierAddOnOfferListResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator PremierAddOnOfferListResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePremierAddOnOfferListResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
