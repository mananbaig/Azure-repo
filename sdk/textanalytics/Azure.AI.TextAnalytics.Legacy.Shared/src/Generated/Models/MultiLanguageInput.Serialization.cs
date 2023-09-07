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

namespace Azure.AI.TextAnalytics.Legacy
{
    internal partial class MultiLanguageInput : IUtf8JsonSerializable, IModelJsonSerializable<MultiLanguageInput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MultiLanguageInput>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MultiLanguageInput>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MultiLanguageInput>(this, options.Format);

            writer.WriteStartObject();
            if (Id != null)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            else
            {
                writer.WriteNull("id");
            }
            if (Text != null)
            {
                writer.WritePropertyName("text"u8);
                writer.WriteStringValue(Text);
            }
            else
            {
                writer.WriteNull("text");
            }
            if (Optional.IsDefined(Language))
            {
                writer.WritePropertyName("language"u8);
                writer.WriteStringValue(Language);
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

        internal static MultiLanguageInput DeserializeMultiLanguageInput(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            string text = default;
            Optional<string> language = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        id = null;
                        continue;
                    }
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("text"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        text = null;
                        continue;
                    }
                    text = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("language"u8))
                {
                    language = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MultiLanguageInput(id, text, language.Value, serializedAdditionalRawData);
        }

        MultiLanguageInput IModelJsonSerializable<MultiLanguageInput>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MultiLanguageInput>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMultiLanguageInput(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MultiLanguageInput>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MultiLanguageInput>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MultiLanguageInput IModelSerializable<MultiLanguageInput>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MultiLanguageInput>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMultiLanguageInput(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MultiLanguageInput"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MultiLanguageInput"/> to convert. </param>
        public static implicit operator RequestContent(MultiLanguageInput model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MultiLanguageInput"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MultiLanguageInput(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMultiLanguageInput(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
