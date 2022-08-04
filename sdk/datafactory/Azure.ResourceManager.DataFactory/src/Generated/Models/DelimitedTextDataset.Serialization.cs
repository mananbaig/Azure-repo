// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class DelimitedTextDataset : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteStringValue(DatasetType);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Structure))
            {
                writer.WritePropertyName("structure");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Structure);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(Structure.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(Schema))
            {
                writer.WritePropertyName("schema");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Schema);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(Schema.ToString()).RootElement);
#endif
            }
            writer.WritePropertyName("linkedServiceName");
            writer.WriteObjectValue(LinkedServiceName);
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters");
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Annotations))
            {
                writer.WritePropertyName("annotations");
                writer.WriteStartArray();
                foreach (var item in Annotations)
                {
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(item.ToString()).RootElement);
#endif
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Folder))
            {
                writer.WritePropertyName("folder");
                writer.WriteObjectValue(Folder);
            }
            writer.WritePropertyName("typeProperties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location");
                writer.WriteObjectValue(Location);
            }
            if (Optional.IsDefined(ColumnDelimiter))
            {
                writer.WritePropertyName("columnDelimiter");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(ColumnDelimiter);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(ColumnDelimiter.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(RowDelimiter))
            {
                writer.WritePropertyName("rowDelimiter");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(RowDelimiter);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(RowDelimiter.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(EncodingName))
            {
                writer.WritePropertyName("encodingName");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(EncodingName);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(EncodingName.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(CompressionCodec))
            {
                writer.WritePropertyName("compressionCodec");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(CompressionCodec);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(CompressionCodec.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(CompressionLevel))
            {
                writer.WritePropertyName("compressionLevel");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(CompressionLevel);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(CompressionLevel.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(QuoteChar))
            {
                writer.WritePropertyName("quoteChar");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(QuoteChar);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(QuoteChar.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(EscapeChar))
            {
                writer.WritePropertyName("escapeChar");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(EscapeChar);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(EscapeChar.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(FirstRowAsHeader))
            {
                writer.WritePropertyName("firstRowAsHeader");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(FirstRowAsHeader);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(FirstRowAsHeader.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(NullValue))
            {
                writer.WritePropertyName("nullValue");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(NullValue);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(NullValue.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static DelimitedTextDataset DeserializeDelimitedTextDataset(JsonElement element)
        {
            string type = default;
            Optional<string> description = default;
            Optional<BinaryData> structure = default;
            Optional<BinaryData> schema = default;
            FactoryLinkedServiceReference linkedServiceName = default;
            Optional<IDictionary<string, EntityParameterSpecification>> parameters = default;
            Optional<IList<BinaryData>> annotations = default;
            Optional<DatasetFolder> folder = default;
            Optional<DatasetLocation> location = default;
            Optional<BinaryData> columnDelimiter = default;
            Optional<BinaryData> rowDelimiter = default;
            Optional<BinaryData> encodingName = default;
            Optional<BinaryData> compressionCodec = default;
            Optional<BinaryData> compressionLevel = default;
            Optional<BinaryData> quoteChar = default;
            Optional<BinaryData> escapeChar = default;
            Optional<BinaryData> firstRowAsHeader = default;
            Optional<BinaryData> nullValue = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("structure"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    structure = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("schema"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    schema = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("linkedServiceName"))
                {
                    linkedServiceName = FactoryLinkedServiceReference.DeserializeFactoryLinkedServiceReference(property.Value);
                    continue;
                }
                if (property.NameEquals("parameters"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, EntityParameterSpecification> dictionary = new Dictionary<string, EntityParameterSpecification>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, EntityParameterSpecification.DeserializeEntityParameterSpecification(property0.Value));
                    }
                    parameters = dictionary;
                    continue;
                }
                if (property.NameEquals("annotations"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<BinaryData> array = new List<BinaryData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BinaryData.FromString(item.GetRawText()));
                    }
                    annotations = array;
                    continue;
                }
                if (property.NameEquals("folder"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    folder = DatasetFolder.DeserializeDatasetFolder(property.Value);
                    continue;
                }
                if (property.NameEquals("typeProperties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("location"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            location = DatasetLocation.DeserializeDatasetLocation(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("columnDelimiter"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            columnDelimiter = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("rowDelimiter"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            rowDelimiter = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("encodingName"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            encodingName = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("compressionCodec"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            compressionCodec = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("compressionLevel"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            compressionLevel = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("quoteChar"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            quoteChar = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("escapeChar"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            escapeChar = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("firstRowAsHeader"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            firstRowAsHeader = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("nullValue"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            nullValue = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new DelimitedTextDataset(type, description.Value, structure.Value, schema.Value, linkedServiceName, Optional.ToDictionary(parameters), Optional.ToList(annotations), folder.Value, additionalProperties, location.Value, columnDelimiter.Value, rowDelimiter.Value, encodingName.Value, compressionCodec.Value, compressionLevel.Value, quoteChar.Value, escapeChar.Value, firstRowAsHeader.Value, nullValue.Value);
        }
    }
}
