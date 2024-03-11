// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class TumblingWindowTriggerDependencyReference : IUtf8JsonSerializable, IJsonModel<TumblingWindowTriggerDependencyReference>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TumblingWindowTriggerDependencyReference>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<TumblingWindowTriggerDependencyReference>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TumblingWindowTriggerDependencyReference>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TumblingWindowTriggerDependencyReference)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Offset))
            {
                writer.WritePropertyName("offset"u8);
                writer.WriteStringValue(Offset);
            }
            if (Optional.IsDefined(Size))
            {
                writer.WritePropertyName("size"u8);
                writer.WriteStringValue(Size);
            }
            writer.WritePropertyName("referenceTrigger"u8);
            writer.WriteObjectValue(ReferenceTrigger);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(DependencyReferenceType);
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

        TumblingWindowTriggerDependencyReference IJsonModel<TumblingWindowTriggerDependencyReference>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TumblingWindowTriggerDependencyReference>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TumblingWindowTriggerDependencyReference)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTumblingWindowTriggerDependencyReference(document.RootElement, options);
        }

        internal static TumblingWindowTriggerDependencyReference DeserializeTumblingWindowTriggerDependencyReference(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string offset = default;
            string size = default;
            DataFactoryTriggerReference referenceTrigger = default;
            string type = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("offset"u8))
                {
                    offset = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("size"u8))
                {
                    size = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("referenceTrigger"u8))
                {
                    referenceTrigger = DataFactoryTriggerReference.DeserializeDataFactoryTriggerReference(property.Value, options);
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new TumblingWindowTriggerDependencyReference(type, serializedAdditionalRawData, referenceTrigger, offset, size);
        }

        BinaryData IPersistableModel<TumblingWindowTriggerDependencyReference>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TumblingWindowTriggerDependencyReference>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TumblingWindowTriggerDependencyReference)} does not support '{options.Format}' format.");
            }
        }

        TumblingWindowTriggerDependencyReference IPersistableModel<TumblingWindowTriggerDependencyReference>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TumblingWindowTriggerDependencyReference>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTumblingWindowTriggerDependencyReference(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TumblingWindowTriggerDependencyReference)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<TumblingWindowTriggerDependencyReference>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
