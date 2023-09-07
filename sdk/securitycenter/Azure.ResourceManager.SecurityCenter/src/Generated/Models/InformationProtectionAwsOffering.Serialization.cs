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

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class InformationProtectionAwsOffering : IUtf8JsonSerializable, IModelJsonSerializable<InformationProtectionAwsOffering>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<InformationProtectionAwsOffering>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<InformationProtectionAwsOffering>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<InformationProtectionAwsOffering>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(InformationProtection))
            {
                writer.WritePropertyName("informationProtection"u8);
                if (InformationProtection is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<AwsInformationProtection>)InformationProtection).Serialize(writer, options);
                }
            }
            writer.WritePropertyName("offeringType"u8);
            writer.WriteStringValue(OfferingType.ToString());
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

        internal static InformationProtectionAwsOffering DeserializeInformationProtectionAwsOffering(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AwsInformationProtection> informationProtection = default;
            OfferingType offeringType = default;
            Optional<string> description = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("informationProtection"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    informationProtection = AwsInformationProtection.DeserializeAwsInformationProtection(property.Value);
                    continue;
                }
                if (property.NameEquals("offeringType"u8))
                {
                    offeringType = new OfferingType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new InformationProtectionAwsOffering(offeringType, description.Value, informationProtection.Value, serializedAdditionalRawData);
        }

        InformationProtectionAwsOffering IModelJsonSerializable<InformationProtectionAwsOffering>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<InformationProtectionAwsOffering>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeInformationProtectionAwsOffering(doc.RootElement, options);
        }

        BinaryData IModelSerializable<InformationProtectionAwsOffering>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<InformationProtectionAwsOffering>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        InformationProtectionAwsOffering IModelSerializable<InformationProtectionAwsOffering>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<InformationProtectionAwsOffering>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeInformationProtectionAwsOffering(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="InformationProtectionAwsOffering"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="InformationProtectionAwsOffering"/> to convert. </param>
        public static implicit operator RequestContent(InformationProtectionAwsOffering model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="InformationProtectionAwsOffering"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator InformationProtectionAwsOffering(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeInformationProtectionAwsOffering(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
