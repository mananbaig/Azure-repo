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
    public partial class LoginFlowNonceSettings : IUtf8JsonSerializable, IModelJsonSerializable<LoginFlowNonceSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<LoginFlowNonceSettings>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<LoginFlowNonceSettings>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LoginFlowNonceSettings>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ValidateNonce))
            {
                writer.WritePropertyName("validateNonce"u8);
                writer.WriteBooleanValue(ValidateNonce.Value);
            }
            if (Optional.IsDefined(NonceExpirationInterval))
            {
                writer.WritePropertyName("nonceExpirationInterval"u8);
                writer.WriteStringValue(NonceExpirationInterval);
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

        internal static LoginFlowNonceSettings DeserializeLoginFlowNonceSettings(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> validateNonce = default;
            Optional<string> nonceExpirationInterval = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("validateNonce"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    validateNonce = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("nonceExpirationInterval"u8))
                {
                    nonceExpirationInterval = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new LoginFlowNonceSettings(Optional.ToNullable(validateNonce), nonceExpirationInterval.Value, serializedAdditionalRawData);
        }

        LoginFlowNonceSettings IModelJsonSerializable<LoginFlowNonceSettings>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LoginFlowNonceSettings>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeLoginFlowNonceSettings(doc.RootElement, options);
        }

        BinaryData IModelSerializable<LoginFlowNonceSettings>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LoginFlowNonceSettings>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        LoginFlowNonceSettings IModelSerializable<LoginFlowNonceSettings>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LoginFlowNonceSettings>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeLoginFlowNonceSettings(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="LoginFlowNonceSettings"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="LoginFlowNonceSettings"/> to convert. </param>
        public static implicit operator RequestContent(LoginFlowNonceSettings model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="LoginFlowNonceSettings"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator LoginFlowNonceSettings(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeLoginFlowNonceSettings(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
