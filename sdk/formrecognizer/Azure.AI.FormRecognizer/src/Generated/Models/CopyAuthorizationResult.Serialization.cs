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

namespace Azure.AI.FormRecognizer.Models
{
    internal partial class CopyAuthorizationResult : IUtf8JsonSerializable, IModelJsonSerializable<CopyAuthorizationResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CopyAuthorizationResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CopyAuthorizationResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CopyAuthorizationResult>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("modelId"u8);
            writer.WriteStringValue(ModelId);
            writer.WritePropertyName("accessToken"u8);
            writer.WriteStringValue(AccessToken);
            writer.WritePropertyName("expirationDateTimeTicks"u8);
            writer.WriteNumberValue(ExpirationDateTimeTicks);
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

        internal static CopyAuthorizationResult DeserializeCopyAuthorizationResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string modelId = default;
            string accessToken = default;
            long expirationDateTimeTicks = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("modelId"u8))
                {
                    modelId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accessToken"u8))
                {
                    accessToken = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expirationDateTimeTicks"u8))
                {
                    expirationDateTimeTicks = property.Value.GetInt64();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CopyAuthorizationResult(modelId, accessToken, expirationDateTimeTicks, serializedAdditionalRawData);
        }

        CopyAuthorizationResult IModelJsonSerializable<CopyAuthorizationResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CopyAuthorizationResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCopyAuthorizationResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CopyAuthorizationResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CopyAuthorizationResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CopyAuthorizationResult IModelSerializable<CopyAuthorizationResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CopyAuthorizationResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCopyAuthorizationResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CopyAuthorizationResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CopyAuthorizationResult"/> to convert. </param>
        public static implicit operator RequestContent(CopyAuthorizationResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CopyAuthorizationResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CopyAuthorizationResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCopyAuthorizationResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
