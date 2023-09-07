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

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class TextTranslationSkill : IUtf8JsonSerializable, IModelJsonSerializable<TextTranslationSkill>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<TextTranslationSkill>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<TextTranslationSkill>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TextTranslationSkill>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("defaultToLanguageCode"u8);
            writer.WriteStringValue(DefaultToLanguageCode.ToString());
            if (Optional.IsDefined(DefaultFromLanguageCode))
            {
                if (DefaultFromLanguageCode != null)
                {
                    writer.WritePropertyName("defaultFromLanguageCode"u8);
                    writer.WriteStringValue(DefaultFromLanguageCode.Value.ToString());
                }
                else
                {
                    writer.WriteNull("defaultFromLanguageCode");
                }
            }
            if (Optional.IsDefined(SuggestedFrom))
            {
                if (SuggestedFrom != null)
                {
                    writer.WritePropertyName("suggestedFrom"u8);
                    writer.WriteStringValue(SuggestedFrom.Value.ToString());
                }
                else
                {
                    writer.WriteNull("suggestedFrom");
                }
            }
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(ODataType);
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Context))
            {
                writer.WritePropertyName("context"u8);
                writer.WriteStringValue(Context);
            }
            writer.WritePropertyName("inputs"u8);
            writer.WriteStartArray();
            foreach (var item in Inputs)
            {
                if (item is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<InputFieldMappingEntry>)item).Serialize(writer, options);
                }
            }
            writer.WriteEndArray();
            writer.WritePropertyName("outputs"u8);
            writer.WriteStartArray();
            foreach (var item in Outputs)
            {
                if (item is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<OutputFieldMappingEntry>)item).Serialize(writer, options);
                }
            }
            writer.WriteEndArray();
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

        internal static TextTranslationSkill DeserializeTextTranslationSkill(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TextTranslationSkillLanguage defaultToLanguageCode = default;
            Optional<TextTranslationSkillLanguage?> defaultFromLanguageCode = default;
            Optional<TextTranslationSkillLanguage?> suggestedFrom = default;
            string odataType = default;
            Optional<string> name = default;
            Optional<string> description = default;
            Optional<string> context = default;
            IList<InputFieldMappingEntry> inputs = default;
            IList<OutputFieldMappingEntry> outputs = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("defaultToLanguageCode"u8))
                {
                    defaultToLanguageCode = new TextTranslationSkillLanguage(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("defaultFromLanguageCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        defaultFromLanguageCode = null;
                        continue;
                    }
                    defaultFromLanguageCode = new TextTranslationSkillLanguage(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("suggestedFrom"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        suggestedFrom = null;
                        continue;
                    }
                    suggestedFrom = new TextTranslationSkillLanguage(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("context"u8))
                {
                    context = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inputs"u8))
                {
                    List<InputFieldMappingEntry> array = new List<InputFieldMappingEntry>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InputFieldMappingEntry.DeserializeInputFieldMappingEntry(item));
                    }
                    inputs = array;
                    continue;
                }
                if (property.NameEquals("outputs"u8))
                {
                    List<OutputFieldMappingEntry> array = new List<OutputFieldMappingEntry>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OutputFieldMappingEntry.DeserializeOutputFieldMappingEntry(item));
                    }
                    outputs = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new TextTranslationSkill(odataType, name.Value, description.Value, context.Value, inputs, outputs, defaultToLanguageCode, Optional.ToNullable(defaultFromLanguageCode), Optional.ToNullable(suggestedFrom), serializedAdditionalRawData);
        }

        TextTranslationSkill IModelJsonSerializable<TextTranslationSkill>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TextTranslationSkill>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeTextTranslationSkill(doc.RootElement, options);
        }

        BinaryData IModelSerializable<TextTranslationSkill>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TextTranslationSkill>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        TextTranslationSkill IModelSerializable<TextTranslationSkill>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TextTranslationSkill>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeTextTranslationSkill(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="TextTranslationSkill"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="TextTranslationSkill"/> to convert. </param>
        public static implicit operator RequestContent(TextTranslationSkill model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="TextTranslationSkill"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator TextTranslationSkill(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeTextTranslationSkill(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
