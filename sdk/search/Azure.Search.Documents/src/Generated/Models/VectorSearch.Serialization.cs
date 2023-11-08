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
    public partial class VectorSearch : IUtf8JsonSerializable, IJsonModel<VectorSearch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VectorSearch>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<VectorSearch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Profiles))
            {
                writer.WritePropertyName("profiles"u8);
                writer.WriteStartArray();
                foreach (var item in Profiles)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Algorithms))
            {
                writer.WritePropertyName("algorithms"u8);
                writer.WriteStartArray();
                foreach (var item in Algorithms)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        VectorSearch IJsonModel<VectorSearch>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(VectorSearch)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVectorSearch(document.RootElement, options);
        }

        internal static VectorSearch DeserializeVectorSearch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<VectorSearchProfile>> profiles = default;
            Optional<IList<VectorSearchAlgorithmConfiguration>> algorithms = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("profiles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VectorSearchProfile> array = new List<VectorSearchProfile>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VectorSearchProfile.DeserializeVectorSearchProfile(item));
                    }
                    profiles = array;
                    continue;
                }
                if (property.NameEquals("algorithms"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VectorSearchAlgorithmConfiguration> array = new List<VectorSearchAlgorithmConfiguration>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VectorSearchAlgorithmConfiguration.DeserializeVectorSearchAlgorithmConfiguration(item));
                    }
                    algorithms = array;
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VectorSearch(Optional.ToList(profiles), Optional.ToList(algorithms), serializedAdditionalRawData);
        }

        BinaryData IModel<VectorSearch>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(VectorSearch)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        VectorSearch IModel<VectorSearch>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(VectorSearch)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeVectorSearch(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<VectorSearch>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
