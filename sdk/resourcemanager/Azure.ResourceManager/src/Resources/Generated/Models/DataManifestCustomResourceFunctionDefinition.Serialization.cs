// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class DataManifestCustomResourceFunctionDefinition : IUtf8JsonSerializable, IJsonModel<DataManifestCustomResourceFunctionDefinition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataManifestCustomResourceFunctionDefinition>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataManifestCustomResourceFunctionDefinition>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataManifestCustomResourceFunctionDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataManifestCustomResourceFunctionDefinition)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(FullyQualifiedResourceType))
            {
                writer.WritePropertyName("fullyQualifiedResourceType"u8);
                writer.WriteStringValue(FullyQualifiedResourceType.Value);
            }
            if (Optional.IsCollectionDefined(DefaultProperties))
            {
                writer.WritePropertyName("defaultProperties"u8);
                writer.WriteStartArray();
                foreach (var item in DefaultProperties)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AllowCustomProperties))
            {
                writer.WritePropertyName("allowCustomProperties"u8);
                writer.WriteBooleanValue(AllowCustomProperties.Value);
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

        DataManifestCustomResourceFunctionDefinition IJsonModel<DataManifestCustomResourceFunctionDefinition>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataManifestCustomResourceFunctionDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataManifestCustomResourceFunctionDefinition)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataManifestCustomResourceFunctionDefinition(document.RootElement, options);
        }

        internal static DataManifestCustomResourceFunctionDefinition DeserializeDataManifestCustomResourceFunctionDefinition(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            ResourceType? fullyQualifiedResourceType = default;
            IReadOnlyList<string> defaultProperties = default;
            bool? allowCustomProperties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fullyQualifiedResourceType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fullyQualifiedResourceType = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("defaultProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    defaultProperties = array;
                    continue;
                }
                if (property.NameEquals("allowCustomProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allowCustomProperties = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataManifestCustomResourceFunctionDefinition(name, fullyQualifiedResourceType, defaultProperties ?? new ChangeTrackingList<string>(), allowCustomProperties, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataManifestCustomResourceFunctionDefinition>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataManifestCustomResourceFunctionDefinition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataManifestCustomResourceFunctionDefinition)} does not support '{options.Format}' format.");
            }
        }

        DataManifestCustomResourceFunctionDefinition IPersistableModel<DataManifestCustomResourceFunctionDefinition>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataManifestCustomResourceFunctionDefinition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataManifestCustomResourceFunctionDefinition(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataManifestCustomResourceFunctionDefinition)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataManifestCustomResourceFunctionDefinition>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
