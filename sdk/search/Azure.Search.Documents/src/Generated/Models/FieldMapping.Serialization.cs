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
    public partial class FieldMapping : IUtf8JsonSerializable, IJsonModel<FieldMapping>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FieldMapping>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<FieldMapping>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("sourceFieldName"u8);
            writer.WriteStringValue(SourceFieldName);
            if (Optional.IsDefined(TargetFieldName))
            {
                writer.WritePropertyName("targetFieldName"u8);
                writer.WriteStringValue(TargetFieldName);
            }
            if (Optional.IsDefined(MappingFunction))
            {
                if (MappingFunction != null)
                {
                    writer.WritePropertyName("mappingFunction"u8);
                    writer.WriteObjectValue(MappingFunction);
                }
                else
                {
                    writer.WriteNull("mappingFunction");
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

        FieldMapping IJsonModel<FieldMapping>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(FieldMapping)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFieldMapping(document.RootElement, options);
        }

        internal static FieldMapping DeserializeFieldMapping(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string sourceFieldName = default;
            Optional<string> targetFieldName = default;
            Optional<FieldMappingFunction> mappingFunction = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceFieldName"u8))
                {
                    sourceFieldName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetFieldName"u8))
                {
                    targetFieldName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mappingFunction"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        mappingFunction = null;
                        continue;
                    }
                    mappingFunction = FieldMappingFunction.DeserializeFieldMappingFunction(property.Value);
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FieldMapping(sourceFieldName, targetFieldName.Value, mappingFunction.Value, serializedAdditionalRawData);
        }

        BinaryData IModel<FieldMapping>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(FieldMapping)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        FieldMapping IModel<FieldMapping>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(FieldMapping)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeFieldMapping(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<FieldMapping>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
