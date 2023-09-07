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
    public partial class SearchIndexer : IUtf8JsonSerializable, IModelJsonSerializable<SearchIndexer>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SearchIndexer>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SearchIndexer>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SearchIndexer>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("dataSourceName"u8);
            writer.WriteStringValue(DataSourceName);
            if (Optional.IsDefined(SkillsetName))
            {
                writer.WritePropertyName("skillsetName"u8);
                writer.WriteStringValue(SkillsetName);
            }
            writer.WritePropertyName("targetIndexName"u8);
            writer.WriteStringValue(TargetIndexName);
            if (Optional.IsDefined(Schedule))
            {
                if (Schedule != null)
                {
                    writer.WritePropertyName("schedule"u8);
                    if (Schedule is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<IndexingSchedule>)Schedule).Serialize(writer, options);
                    }
                }
                else
                {
                    writer.WriteNull("schedule");
                }
            }
            if (Optional.IsDefined(Parameters))
            {
                if (Parameters != null)
                {
                    writer.WritePropertyName("parameters"u8);
                    if (Parameters is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<IndexingParameters>)Parameters).Serialize(writer, options);
                    }
                }
                else
                {
                    writer.WriteNull("parameters");
                }
            }
            if (Optional.IsCollectionDefined(FieldMappings))
            {
                writer.WritePropertyName("fieldMappings"u8);
                writer.WriteStartArray();
                foreach (var item in FieldMappings)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<FieldMapping>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(OutputFieldMappings))
            {
                writer.WritePropertyName("outputFieldMappings"u8);
                writer.WriteStartArray();
                foreach (var item in OutputFieldMappings)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<FieldMapping>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsDisabled))
            {
                if (IsDisabled != null)
                {
                    writer.WritePropertyName("disabled"u8);
                    writer.WriteBooleanValue(IsDisabled.Value);
                }
                else
                {
                    writer.WriteNull("disabled");
                }
            }
            if (Optional.IsDefined(_etag))
            {
                writer.WritePropertyName("@odata.etag"u8);
                writer.WriteStringValue(_etag);
            }
            if (Optional.IsDefined(EncryptionKey))
            {
                if (EncryptionKey != null)
                {
                    writer.WritePropertyName("encryptionKey"u8);
                    if (EncryptionKey is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<SearchResourceEncryptionKey>)EncryptionKey).Serialize(writer, options);
                    }
                }
                else
                {
                    writer.WriteNull("encryptionKey");
                }
            }
            if (Optional.IsDefined(Cache))
            {
                if (Cache != null)
                {
                    writer.WritePropertyName("cache"u8);
                    if (Cache is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<SearchIndexerCache>)Cache).Serialize(writer, options);
                    }
                }
                else
                {
                    writer.WriteNull("cache");
                }
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

        internal static SearchIndexer DeserializeSearchIndexer(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            Optional<string> description = default;
            string dataSourceName = default;
            Optional<string> skillsetName = default;
            string targetIndexName = default;
            Optional<IndexingSchedule> schedule = default;
            Optional<IndexingParameters> parameters = default;
            Optional<IList<FieldMapping>> fieldMappings = default;
            Optional<IList<FieldMapping>> outputFieldMappings = default;
            Optional<bool?> disabled = default;
            Optional<string> odataEtag = default;
            Optional<SearchResourceEncryptionKey> encryptionKey = default;
            Optional<SearchIndexerCache> cache = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                if (property.NameEquals("dataSourceName"u8))
                {
                    dataSourceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("skillsetName"u8))
                {
                    skillsetName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetIndexName"u8))
                {
                    targetIndexName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("schedule"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        schedule = null;
                        continue;
                    }
                    schedule = IndexingSchedule.DeserializeIndexingSchedule(property.Value);
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        parameters = null;
                        continue;
                    }
                    parameters = IndexingParameters.DeserializeIndexingParameters(property.Value);
                    continue;
                }
                if (property.NameEquals("fieldMappings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FieldMapping> array = new List<FieldMapping>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FieldMapping.DeserializeFieldMapping(item));
                    }
                    fieldMappings = array;
                    continue;
                }
                if (property.NameEquals("outputFieldMappings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FieldMapping> array = new List<FieldMapping>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FieldMapping.DeserializeFieldMapping(item));
                    }
                    outputFieldMappings = array;
                    continue;
                }
                if (property.NameEquals("disabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        disabled = null;
                        continue;
                    }
                    disabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("@odata.etag"u8))
                {
                    odataEtag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("encryptionKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        encryptionKey = null;
                        continue;
                    }
                    encryptionKey = SearchResourceEncryptionKey.DeserializeSearchResourceEncryptionKey(property.Value);
                    continue;
                }
                if (property.NameEquals("cache"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        cache = null;
                        continue;
                    }
                    cache = SearchIndexerCache.DeserializeSearchIndexerCache(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SearchIndexer(name, description.Value, dataSourceName, skillsetName.Value, targetIndexName, schedule.Value, parameters.Value, Optional.ToList(fieldMappings), Optional.ToList(outputFieldMappings), Optional.ToNullable(disabled), odataEtag.Value, encryptionKey.Value, cache.Value, serializedAdditionalRawData);
        }

        SearchIndexer IModelJsonSerializable<SearchIndexer>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SearchIndexer>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSearchIndexer(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SearchIndexer>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SearchIndexer>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SearchIndexer IModelSerializable<SearchIndexer>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SearchIndexer>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSearchIndexer(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SearchIndexer"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SearchIndexer"/> to convert. </param>
        public static implicit operator RequestContent(SearchIndexer model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SearchIndexer"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SearchIndexer(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSearchIndexer(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
