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

namespace Azure.Communication.PhoneNumbers
{
    internal partial class PurchasedPhoneNumbers : IUtf8JsonSerializable, IModelJsonSerializable<PurchasedPhoneNumbers>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PurchasedPhoneNumbers>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PurchasedPhoneNumbers>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("phoneNumbers"u8);
            writer.WriteStartArray();
            foreach (var item in PhoneNumbers)
            {
                if (item is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<PurchasedPhoneNumber>)item).Serialize(writer, options);
                }
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(NextLink))
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink);
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

        internal static PurchasedPhoneNumbers DeserializePurchasedPhoneNumbers(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<PurchasedPhoneNumber> phoneNumbers = default;
            Optional<string> nextLink = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("phoneNumbers"u8))
                {
                    List<PurchasedPhoneNumber> array = new List<PurchasedPhoneNumber>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PurchasedPhoneNumber.DeserializePurchasedPhoneNumber(item));
                    }
                    phoneNumbers = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new PurchasedPhoneNumbers(phoneNumbers, nextLink.Value, rawData);
        }

        PurchasedPhoneNumbers IModelJsonSerializable<PurchasedPhoneNumbers>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePurchasedPhoneNumbers(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PurchasedPhoneNumbers>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PurchasedPhoneNumbers IModelSerializable<PurchasedPhoneNumbers>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePurchasedPhoneNumbers(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="PurchasedPhoneNumbers"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="PurchasedPhoneNumbers"/> to convert. </param>
        public static implicit operator RequestContent(PurchasedPhoneNumbers model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="PurchasedPhoneNumbers"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator PurchasedPhoneNumbers(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePurchasedPhoneNumbers(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
