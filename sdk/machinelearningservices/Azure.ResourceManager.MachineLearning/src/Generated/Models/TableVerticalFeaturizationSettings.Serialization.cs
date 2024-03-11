// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.MachineLearning;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class TableVerticalFeaturizationSettings : IUtf8JsonSerializable, IJsonModel<TableVerticalFeaturizationSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TableVerticalFeaturizationSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<TableVerticalFeaturizationSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TableVerticalFeaturizationSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TableVerticalFeaturizationSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(BlockedTransformers))
            {
                if (BlockedTransformers != null)
                {
                    writer.WritePropertyName("blockedTransformers"u8);
                    writer.WriteStartArray();
                    foreach (var item in BlockedTransformers)
                    {
                        writer.WriteStringValue(item.ToString());
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("blockedTransformers");
                }
            }
            if (Optional.IsCollectionDefined(ColumnNameAndTypes))
            {
                if (ColumnNameAndTypes != null)
                {
                    writer.WritePropertyName("columnNameAndTypes"u8);
                    writer.WriteStartObject();
                    foreach (var item in ColumnNameAndTypes)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("columnNameAndTypes");
                }
            }
            if (Optional.IsDefined(EnableDnnFeaturization))
            {
                writer.WritePropertyName("enableDnnFeaturization"u8);
                writer.WriteBooleanValue(EnableDnnFeaturization.Value);
            }
            if (Optional.IsDefined(Mode))
            {
                writer.WritePropertyName("mode"u8);
                writer.WriteStringValue(Mode.Value.ToString());
            }
            if (Optional.IsCollectionDefined(TransformerParams))
            {
                if (TransformerParams != null)
                {
                    writer.WritePropertyName("transformerParams"u8);
                    writer.WriteStartObject();
                    foreach (var item in TransformerParams)
                    {
                        writer.WritePropertyName(item.Key);
                        if (item.Value == null)
                        {
                            writer.WriteNullValue();
                            continue;
                        }
                        writer.WriteStartArray();
                        foreach (var item0 in item.Value)
                        {
                            writer.WriteObjectValue(item0);
                        }
                        writer.WriteEndArray();
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("transformerParams");
                }
            }
            if (Optional.IsDefined(DatasetLanguage))
            {
                if (DatasetLanguage != null)
                {
                    writer.WritePropertyName("datasetLanguage"u8);
                    writer.WriteStringValue(DatasetLanguage);
                }
                else
                {
                    writer.WriteNull("datasetLanguage");
                }
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
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

        TableVerticalFeaturizationSettings IJsonModel<TableVerticalFeaturizationSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TableVerticalFeaturizationSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TableVerticalFeaturizationSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTableVerticalFeaturizationSettings(document.RootElement, options);
        }

        internal static TableVerticalFeaturizationSettings DeserializeTableVerticalFeaturizationSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<BlockedTransformer> blockedTransformers = default;
            IDictionary<string, string> columnNameAndTypes = default;
            bool? enableDnnFeaturization = default;
            MachineLearningFeaturizationMode? mode = default;
            IDictionary<string, IList<ColumnTransformer>> transformerParams = default;
            string datasetLanguage = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("blockedTransformers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        blockedTransformers = null;
                        continue;
                    }
                    List<BlockedTransformer> array = new List<BlockedTransformer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new BlockedTransformer(item.GetString()));
                    }
                    blockedTransformers = array;
                    continue;
                }
                if (property.NameEquals("columnNameAndTypes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        columnNameAndTypes = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    columnNameAndTypes = dictionary;
                    continue;
                }
                if (property.NameEquals("enableDnnFeaturization"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableDnnFeaturization = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("mode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mode = new MachineLearningFeaturizationMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("transformerParams"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        transformerParams = null;
                        continue;
                    }
                    Dictionary<string, IList<ColumnTransformer>> dictionary = new Dictionary<string, IList<ColumnTransformer>>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            List<ColumnTransformer> array = new List<ColumnTransformer>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ColumnTransformer.DeserializeColumnTransformer(item, options));
                            }
                            dictionary.Add(property0.Name, array);
                        }
                    }
                    transformerParams = dictionary;
                    continue;
                }
                if (property.NameEquals("datasetLanguage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        datasetLanguage = null;
                        continue;
                    }
                    datasetLanguage = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new TableVerticalFeaturizationSettings(
                datasetLanguage,
                serializedAdditionalRawData,
                blockedTransformers ?? new ChangeTrackingList<BlockedTransformer>(),
                columnNameAndTypes ?? new ChangeTrackingDictionary<string, string>(),
                enableDnnFeaturization,
                mode,
                transformerParams ?? new ChangeTrackingDictionary<string, IList<ColumnTransformer>>());
        }

        BinaryData IPersistableModel<TableVerticalFeaturizationSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TableVerticalFeaturizationSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TableVerticalFeaturizationSettings)} does not support '{options.Format}' format.");
            }
        }

        TableVerticalFeaturizationSettings IPersistableModel<TableVerticalFeaturizationSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TableVerticalFeaturizationSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTableVerticalFeaturizationSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TableVerticalFeaturizationSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<TableVerticalFeaturizationSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
