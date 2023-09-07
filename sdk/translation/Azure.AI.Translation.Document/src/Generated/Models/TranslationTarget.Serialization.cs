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

namespace Azure.AI.Translation.Document
{
    public partial class TranslationTarget : IUtf8JsonSerializable, IModelJsonSerializable<TranslationTarget>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<TranslationTarget>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<TranslationTarget>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TranslationTarget>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("targetUrl"u8);
            writer.WriteStringValue(TargetUri.AbsoluteUri);
            if (Optional.IsDefined(CategoryId))
            {
                writer.WritePropertyName("category"u8);
                writer.WriteStringValue(CategoryId);
            }
            writer.WritePropertyName("language"u8);
            writer.WriteStringValue(LanguageCode);
            if (Optional.IsCollectionDefined(Glossaries))
            {
                writer.WritePropertyName("glossaries"u8);
                writer.WriteStartArray();
                foreach (var item in Glossaries)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<TranslationGlossary>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(StorageSource))
            {
                writer.WritePropertyName("storageSource"u8);
                writer.WriteStringValue(StorageSource);
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

        internal static TranslationTarget DeserializeTranslationTarget(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri targetUrl = default;
            Optional<string> category = default;
            string language = default;
            Optional<IList<TranslationGlossary>> glossaries = default;
            Optional<string> storageSource = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("targetUrl"u8))
                {
                    targetUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("category"u8))
                {
                    category = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("language"u8))
                {
                    language = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("glossaries"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TranslationGlossary> array = new List<TranslationGlossary>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TranslationGlossary.DeserializeTranslationGlossary(item));
                    }
                    glossaries = array;
                    continue;
                }
                if (property.NameEquals("storageSource"u8))
                {
                    storageSource = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new TranslationTarget(targetUrl, category.Value, language, Optional.ToList(glossaries), storageSource.Value, serializedAdditionalRawData);
        }

        TranslationTarget IModelJsonSerializable<TranslationTarget>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TranslationTarget>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeTranslationTarget(doc.RootElement, options);
        }

        BinaryData IModelSerializable<TranslationTarget>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TranslationTarget>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        TranslationTarget IModelSerializable<TranslationTarget>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TranslationTarget>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeTranslationTarget(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="TranslationTarget"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="TranslationTarget"/> to convert. </param>
        public static implicit operator RequestContent(TranslationTarget model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="TranslationTarget"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator TranslationTarget(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeTranslationTarget(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
