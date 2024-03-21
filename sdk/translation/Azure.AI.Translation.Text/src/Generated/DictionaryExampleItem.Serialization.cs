// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Translation.Text
{
    public partial class DictionaryExampleItem : IUtf8JsonSerializable, IJsonModel<DictionaryExampleItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DictionaryExampleItem>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DictionaryExampleItem>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DictionaryExampleItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DictionaryExampleItem)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("normalizedSource"u8);
            writer.WriteStringValue(NormalizedSource);
            writer.WritePropertyName("normalizedTarget"u8);
            writer.WriteStringValue(NormalizedTarget);
            writer.WritePropertyName("examples"u8);
            writer.WriteStartArray();
            foreach (var item in Examples)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
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

        DictionaryExampleItem IJsonModel<DictionaryExampleItem>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DictionaryExampleItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DictionaryExampleItem)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDictionaryExampleItem(document.RootElement, options);
        }

        internal static DictionaryExampleItem DeserializeDictionaryExampleItem(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string normalizedSource = default;
            string normalizedTarget = default;
            IReadOnlyList<DictionaryExample> examples = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("normalizedSource"u8))
                {
                    normalizedSource = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("normalizedTarget"u8))
                {
                    normalizedTarget = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("examples"u8))
                {
                    List<DictionaryExample> array = new List<DictionaryExample>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DictionaryExample.DeserializeDictionaryExample(item, options));
                    }
                    examples = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DictionaryExampleItem(normalizedSource, normalizedTarget, examples, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DictionaryExampleItem>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DictionaryExampleItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DictionaryExampleItem)} does not support writing '{options.Format}' format.");
            }
        }

        DictionaryExampleItem IPersistableModel<DictionaryExampleItem>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DictionaryExampleItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDictionaryExampleItem(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DictionaryExampleItem)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DictionaryExampleItem>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DictionaryExampleItem FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeDictionaryExampleItem(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
