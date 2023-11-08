// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class SearchIndexer : IUtf8JsonSerializable, IJsonModel<SearchIndexer>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SearchIndexer>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<SearchIndexer>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
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
                    writer.WriteObjectValue(Schedule);
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
                    writer.WriteObjectValue(Parameters);
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
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(OutputFieldMappings))
            {
                writer.WritePropertyName("outputFieldMappings"u8);
                writer.WriteStartArray();
                foreach (var item in OutputFieldMappings)
                {
                    writer.WriteObjectValue(item);
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
                    writer.WriteObjectValue(EncryptionKey);
                }
                else
                {
                    writer.WriteNull("encryptionKey");
                }
            }
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        SearchIndexer IJsonModel<SearchIndexer>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SearchIndexer)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSearchIndexer(document.RootElement, options);
        }

        internal static SearchIndexer DeserializeSearchIndexer(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

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
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
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
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SearchIndexer(name, description.Value, dataSourceName, skillsetName.Value, targetIndexName, schedule.Value, parameters.Value, Optional.ToList(fieldMappings), Optional.ToList(outputFieldMappings), Optional.ToNullable(disabled), odataEtag.Value, encryptionKey.Value, serializedAdditionalRawData);
        }

        BinaryData IModel<SearchIndexer>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SearchIndexer)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SearchIndexer IModel<SearchIndexer>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SearchIndexer)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSearchIndexer(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<SearchIndexer>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
