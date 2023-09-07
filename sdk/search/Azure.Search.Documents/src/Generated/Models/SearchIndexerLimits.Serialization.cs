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
    public partial class SearchIndexerLimits : IUtf8JsonSerializable, IModelJsonSerializable<SearchIndexerLimits>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SearchIndexerLimits>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SearchIndexerLimits>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SearchIndexerLimits>(this, options.Format);

            writer.WriteStartObject();
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

        internal static SearchIndexerLimits DeserializeSearchIndexerLimits(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<TimeSpan> maxRunTime = default;
            Optional<long> maxDocumentExtractionSize = default;
            Optional<long> maxDocumentContentCharactersToExtract = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxRunTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxRunTime = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("maxDocumentExtractionSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxDocumentExtractionSize = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("maxDocumentContentCharactersToExtract"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxDocumentContentCharactersToExtract = property.Value.GetInt64();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SearchIndexerLimits(Optional.ToNullable(maxRunTime), Optional.ToNullable(maxDocumentExtractionSize), Optional.ToNullable(maxDocumentContentCharactersToExtract), serializedAdditionalRawData);
        }

        SearchIndexerLimits IModelJsonSerializable<SearchIndexerLimits>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SearchIndexerLimits>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSearchIndexerLimits(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SearchIndexerLimits>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SearchIndexerLimits>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SearchIndexerLimits IModelSerializable<SearchIndexerLimits>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SearchIndexerLimits>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSearchIndexerLimits(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SearchIndexerLimits"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SearchIndexerLimits"/> to convert. </param>
        public static implicit operator RequestContent(SearchIndexerLimits model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SearchIndexerLimits"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SearchIndexerLimits(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSearchIndexerLimits(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
