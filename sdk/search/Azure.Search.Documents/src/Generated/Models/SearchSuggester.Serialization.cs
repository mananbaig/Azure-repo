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
    public partial class SearchSuggester : IUtf8JsonSerializable, IModelJsonSerializable<SearchSuggester>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SearchSuggester>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SearchSuggester>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SearchSuggester>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("searchMode"u8);
            writer.WriteStringValue(SearchMode);
            writer.WritePropertyName("sourceFields"u8);
            writer.WriteStartArray();
            foreach (var item in SourceFields)
            {
                writer.WriteStringValue(item);
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

        internal static SearchSuggester DeserializeSearchSuggester(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string searchMode = default;
            IList<string> sourceFields = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("searchMode"u8))
                {
                    searchMode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceFields"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    sourceFields = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SearchSuggester(name, searchMode, sourceFields, serializedAdditionalRawData);
        }

        SearchSuggester IModelJsonSerializable<SearchSuggester>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SearchSuggester>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSearchSuggester(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SearchSuggester>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SearchSuggester>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SearchSuggester IModelSerializable<SearchSuggester>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SearchSuggester>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSearchSuggester(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SearchSuggester"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SearchSuggester"/> to convert. </param>
        public static implicit operator RequestContent(SearchSuggester model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SearchSuggester"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SearchSuggester(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSearchSuggester(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
