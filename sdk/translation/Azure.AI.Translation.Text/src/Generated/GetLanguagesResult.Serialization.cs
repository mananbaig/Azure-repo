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

namespace Azure.AI.Translation.Text
{
    public partial class GetLanguagesResult : IUtf8JsonSerializable, IModelJsonSerializable<GetLanguagesResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<GetLanguagesResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<GetLanguagesResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Translation))
            {
                writer.WritePropertyName("translation"u8);
                writer.WriteStartObject();
                foreach (var item in Translation)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<TranslationLanguage>)item.Value).Serialize(writer, options);
                    }
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Transliteration))
            {
                writer.WritePropertyName("transliteration"u8);
                writer.WriteStartObject();
                foreach (var item in Transliteration)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<TransliterationLanguage>)item.Value).Serialize(writer, options);
                    }
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Dictionary))
            {
                writer.WritePropertyName("dictionary"u8);
                writer.WriteStartObject();
                foreach (var item in Dictionary)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<SourceDictionaryLanguage>)item.Value).Serialize(writer, options);
                    }
                }
                writer.WriteEndObject();
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

        internal static GetLanguagesResult DeserializeGetLanguagesResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyDictionary<string, TranslationLanguage>> translation = default;
            Optional<IReadOnlyDictionary<string, TransliterationLanguage>> transliteration = default;
            Optional<IReadOnlyDictionary<string, SourceDictionaryLanguage>> dictionary = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("translation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, TranslationLanguage> dictionary0 = new Dictionary<string, TranslationLanguage>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary0.Add(property0.Name, TranslationLanguage.DeserializeTranslationLanguage(property0.Value));
                    }
                    translation = dictionary0;
                    continue;
                }
                if (property.NameEquals("transliteration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, TransliterationLanguage> dictionary0 = new Dictionary<string, TransliterationLanguage>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary0.Add(property0.Name, TransliterationLanguage.DeserializeTransliterationLanguage(property0.Value));
                    }
                    transliteration = dictionary0;
                    continue;
                }
                if (property.NameEquals("dictionary"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, SourceDictionaryLanguage> dictionary0 = new Dictionary<string, SourceDictionaryLanguage>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary0.Add(property0.Name, SourceDictionaryLanguage.DeserializeSourceDictionaryLanguage(property0.Value));
                    }
                    dictionary = dictionary0;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new GetLanguagesResult(Optional.ToDictionary(translation), Optional.ToDictionary(transliteration), Optional.ToDictionary(dictionary), serializedAdditionalRawData);
        }

        GetLanguagesResult IModelJsonSerializable<GetLanguagesResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeGetLanguagesResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<GetLanguagesResult>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        GetLanguagesResult IModelSerializable<GetLanguagesResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeGetLanguagesResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="GetLanguagesResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="GetLanguagesResult"/> to convert. </param>
        public static implicit operator RequestContent(GetLanguagesResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="GetLanguagesResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator GetLanguagesResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeGetLanguagesResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
