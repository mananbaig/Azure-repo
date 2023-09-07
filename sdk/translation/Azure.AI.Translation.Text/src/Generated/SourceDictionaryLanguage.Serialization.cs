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
    public partial class SourceDictionaryLanguage : IUtf8JsonSerializable, IModelJsonSerializable<SourceDictionaryLanguage>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SourceDictionaryLanguage>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SourceDictionaryLanguage>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("nativeName"u8);
            writer.WriteStringValue(NativeName);
            writer.WritePropertyName("dir"u8);
            writer.WriteStringValue(Dir);
            writer.WritePropertyName("translations"u8);
            writer.WriteStartArray();
            foreach (var item in Translations)
            {
                if (item is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<TargetDictionaryLanguage>)item).Serialize(writer, options);
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

        internal static SourceDictionaryLanguage DeserializeSourceDictionaryLanguage(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string nativeName = default;
            string dir = default;
            IReadOnlyList<TargetDictionaryLanguage> translations = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("nativeName"u8))
                {
                    nativeName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dir"u8))
                {
                    dir = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("translations"u8))
                {
                    List<TargetDictionaryLanguage> array = new List<TargetDictionaryLanguage>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TargetDictionaryLanguage.DeserializeTargetDictionaryLanguage(item));
                    }
                    translations = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SourceDictionaryLanguage(name, nativeName, dir, translations, serializedAdditionalRawData);
        }

        SourceDictionaryLanguage IModelJsonSerializable<SourceDictionaryLanguage>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSourceDictionaryLanguage(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SourceDictionaryLanguage>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SourceDictionaryLanguage IModelSerializable<SourceDictionaryLanguage>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSourceDictionaryLanguage(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SourceDictionaryLanguage"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SourceDictionaryLanguage"/> to convert. </param>
        public static implicit operator RequestContent(SourceDictionaryLanguage model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SourceDictionaryLanguage"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SourceDictionaryLanguage(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSourceDictionaryLanguage(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
