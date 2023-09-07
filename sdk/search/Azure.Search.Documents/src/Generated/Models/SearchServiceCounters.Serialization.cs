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
    public partial class SearchServiceCounters : IUtf8JsonSerializable, IModelJsonSerializable<SearchServiceCounters>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SearchServiceCounters>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SearchServiceCounters>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SearchServiceCounters>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("aliasesCount"u8);
            if (AliasCounter is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<SearchResourceCounter>)AliasCounter).Serialize(writer, options);
            }
            writer.WritePropertyName("documentCount"u8);
            if (DocumentCounter is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<SearchResourceCounter>)DocumentCounter).Serialize(writer, options);
            }
            writer.WritePropertyName("indexesCount"u8);
            if (IndexCounter is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<SearchResourceCounter>)IndexCounter).Serialize(writer, options);
            }
            writer.WritePropertyName("indexersCount"u8);
            if (IndexerCounter is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<SearchResourceCounter>)IndexerCounter).Serialize(writer, options);
            }
            writer.WritePropertyName("dataSourcesCount"u8);
            if (DataSourceCounter is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<SearchResourceCounter>)DataSourceCounter).Serialize(writer, options);
            }
            writer.WritePropertyName("storageSize"u8);
            if (StorageSizeCounter is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<SearchResourceCounter>)StorageSizeCounter).Serialize(writer, options);
            }
            writer.WritePropertyName("synonymMaps"u8);
            if (SynonymMapCounter is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<SearchResourceCounter>)SynonymMapCounter).Serialize(writer, options);
            }
            writer.WritePropertyName("skillsetCount"u8);
            if (SkillsetCounter is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<SearchResourceCounter>)SkillsetCounter).Serialize(writer, options);
            }
            writer.WritePropertyName("vectorIndexSize"u8);
            if (VectorIndexSizeCounter is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<SearchResourceCounter>)VectorIndexSizeCounter).Serialize(writer, options);
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

        internal static SearchServiceCounters DeserializeSearchServiceCounters(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SearchResourceCounter aliasesCount = default;
            SearchResourceCounter documentCount = default;
            SearchResourceCounter indexesCount = default;
            SearchResourceCounter indexersCount = default;
            SearchResourceCounter dataSourcesCount = default;
            SearchResourceCounter storageSize = default;
            SearchResourceCounter synonymMaps = default;
            SearchResourceCounter skillsetCount = default;
            SearchResourceCounter vectorIndexSize = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("aliasesCount"u8))
                {
                    aliasesCount = SearchResourceCounter.DeserializeSearchResourceCounter(property.Value);
                    continue;
                }
                if (property.NameEquals("documentCount"u8))
                {
                    documentCount = SearchResourceCounter.DeserializeSearchResourceCounter(property.Value);
                    continue;
                }
                if (property.NameEquals("indexesCount"u8))
                {
                    indexesCount = SearchResourceCounter.DeserializeSearchResourceCounter(property.Value);
                    continue;
                }
                if (property.NameEquals("indexersCount"u8))
                {
                    indexersCount = SearchResourceCounter.DeserializeSearchResourceCounter(property.Value);
                    continue;
                }
                if (property.NameEquals("dataSourcesCount"u8))
                {
                    dataSourcesCount = SearchResourceCounter.DeserializeSearchResourceCounter(property.Value);
                    continue;
                }
                if (property.NameEquals("storageSize"u8))
                {
                    storageSize = SearchResourceCounter.DeserializeSearchResourceCounter(property.Value);
                    continue;
                }
                if (property.NameEquals("synonymMaps"u8))
                {
                    synonymMaps = SearchResourceCounter.DeserializeSearchResourceCounter(property.Value);
                    continue;
                }
                if (property.NameEquals("skillsetCount"u8))
                {
                    skillsetCount = SearchResourceCounter.DeserializeSearchResourceCounter(property.Value);
                    continue;
                }
                if (property.NameEquals("vectorIndexSize"u8))
                {
                    vectorIndexSize = SearchResourceCounter.DeserializeSearchResourceCounter(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SearchServiceCounters(aliasesCount, documentCount, indexesCount, indexersCount, dataSourcesCount, storageSize, synonymMaps, skillsetCount, vectorIndexSize, serializedAdditionalRawData);
        }

        SearchServiceCounters IModelJsonSerializable<SearchServiceCounters>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SearchServiceCounters>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSearchServiceCounters(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SearchServiceCounters>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SearchServiceCounters>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SearchServiceCounters IModelSerializable<SearchServiceCounters>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SearchServiceCounters>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSearchServiceCounters(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SearchServiceCounters"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SearchServiceCounters"/> to convert. </param>
        public static implicit operator RequestContent(SearchServiceCounters model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SearchServiceCounters"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SearchServiceCounters(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSearchServiceCounters(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
