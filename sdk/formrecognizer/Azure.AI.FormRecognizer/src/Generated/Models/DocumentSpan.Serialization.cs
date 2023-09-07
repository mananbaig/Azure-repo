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

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    public partial struct DocumentSpan : IUtf8JsonSerializable, IModelJsonSerializable<DocumentSpan>, IModelJsonSerializable<object>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DocumentSpan>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DocumentSpan>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DocumentSpan>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("offset"u8);
            writer.WriteNumberValue(Index);
            writer.WritePropertyName("length"u8);
            writer.WriteNumberValue(Length);
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

        void IModelJsonSerializable<object>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DocumentSpan>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("offset"u8);
            writer.WriteNumberValue(Index);
            writer.WritePropertyName("length"u8);
            writer.WriteNumberValue(Length);
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

        internal static DocumentSpan DeserializeDocumentSpan(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            int offset = default;
            int length = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("offset"u8))
                {
                    offset = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("length"u8))
                {
                    length = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DocumentSpan(offset, length, serializedAdditionalRawData);
        }

        DocumentSpan IModelJsonSerializable<DocumentSpan>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DocumentSpan>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDocumentSpan(doc.RootElement, options);
        }

        object IModelJsonSerializable<object>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DocumentSpan>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDocumentSpan(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DocumentSpan>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DocumentSpan>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DocumentSpan IModelSerializable<DocumentSpan>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DocumentSpan>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDocumentSpan(doc.RootElement, options);
        }

        BinaryData IModelSerializable<object>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DocumentSpan>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        object IModelSerializable<object>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DocumentSpan>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDocumentSpan(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DocumentSpan"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DocumentSpan"/> to convert. </param>
        public static implicit operator RequestContent(DocumentSpan model)
        {
            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DocumentSpan"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DocumentSpan(Response response)
        {
            Argument.AssertNotNull(response, nameof(response));

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDocumentSpan(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
