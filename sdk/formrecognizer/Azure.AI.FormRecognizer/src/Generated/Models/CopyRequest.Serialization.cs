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
    internal partial class CopyRequest : IUtf8JsonSerializable, IModelJsonSerializable<CopyRequest>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CopyRequest>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CopyRequest>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CopyRequest>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("targetResourceId"u8);
            writer.WriteStringValue(TargetResourceId);
            writer.WritePropertyName("targetResourceRegion"u8);
            writer.WriteStringValue(TargetResourceRegion);
            writer.WritePropertyName("copyAuthorization"u8);
            if (CopyAuthorization is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<CopyAuthorizationResult>)CopyAuthorization).Serialize(writer, options);
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

        internal static CopyRequest DeserializeCopyRequest(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string targetResourceId = default;
            string targetResourceRegion = default;
            CopyAuthorizationResult copyAuthorization = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("targetResourceId"u8))
                {
                    targetResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetResourceRegion"u8))
                {
                    targetResourceRegion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("copyAuthorization"u8))
                {
                    copyAuthorization = CopyAuthorizationResult.DeserializeCopyAuthorizationResult(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CopyRequest(targetResourceId, targetResourceRegion, copyAuthorization, serializedAdditionalRawData);
        }

        CopyRequest IModelJsonSerializable<CopyRequest>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CopyRequest>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCopyRequest(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CopyRequest>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CopyRequest>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CopyRequest IModelSerializable<CopyRequest>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CopyRequest>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCopyRequest(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CopyRequest"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CopyRequest"/> to convert. </param>
        public static implicit operator RequestContent(CopyRequest model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CopyRequest"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CopyRequest(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCopyRequest(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
