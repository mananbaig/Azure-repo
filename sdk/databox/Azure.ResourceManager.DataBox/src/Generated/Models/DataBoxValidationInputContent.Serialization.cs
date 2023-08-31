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

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class DataBoxValidationInputContent : IUtf8JsonSerializable, IModelJsonSerializable<DataBoxValidationInputContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DataBoxValidationInputContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DataBoxValidationInputContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("validationType"u8);
            writer.WriteStringValue(ValidationType.ToSerialString());
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

        internal static DataBoxValidationInputContent DeserializeDataBoxValidationInputContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("validationType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "ValidateCreateOrderLimit": return CreateOrderLimitForSubscriptionValidationContent.DeserializeCreateOrderLimitForSubscriptionValidationContent(element);
                    case "ValidateDataTransferDetails": return DataTransferDetailsValidationContent.DeserializeDataTransferDetailsValidationContent(element);
                    case "ValidatePreferences": return PreferencesValidationContent.DeserializePreferencesValidationContent(element);
                    case "ValidateSkuAvailability": return SkuAvailabilityValidationContent.DeserializeSkuAvailabilityValidationContent(element);
                    case "ValidateSubscriptionIsAllowedToCreateJob": return SubscriptionIsAllowedToCreateJobValidationContent.DeserializeSubscriptionIsAllowedToCreateJobValidationContent(element);
                    case "ValidateAddress": return DataBoxValidateAddressContent.DeserializeDataBoxValidateAddressContent(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            DataBoxValidationInputDiscriminator validationType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("validationType"u8))
                {
                    validationType = property.Value.GetString().ToDataBoxValidationInputDiscriminator();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new Models.DataBoxValidationInputContent(validationType, rawData);
        }

        DataBoxValidationInputContent IModelJsonSerializable<DataBoxValidationInputContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDataBoxValidationInputContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DataBoxValidationInputContent>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DataBoxValidationInputContent IModelSerializable<DataBoxValidationInputContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDataBoxValidationInputContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DataBoxValidationInputContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DataBoxValidationInputContent"/> to convert. </param>
        public static implicit operator RequestContent(DataBoxValidationInputContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DataBoxValidationInputContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DataBoxValidationInputContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDataBoxValidationInputContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
