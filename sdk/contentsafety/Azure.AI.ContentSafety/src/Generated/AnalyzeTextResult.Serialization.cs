// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.ContentSafety
{
    public partial class AnalyzeTextResult : IUtf8JsonSerializable, IJsonModel<AnalyzeTextResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AnalyzeTextResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AnalyzeTextResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalyzeTextResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AnalyzeTextResult)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(BlocklistsMatch))
            {
                writer.WritePropertyName("blocklistsMatch"u8);
                writer.WriteStartArray();
                foreach (var item in BlocklistsMatch)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("categoriesAnalysis"u8);
            writer.WriteStartArray();
            foreach (var item in CategoriesAnalysis)
            {
                writer.WriteObjectValue(item, options);
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

        AnalyzeTextResult IJsonModel<AnalyzeTextResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalyzeTextResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AnalyzeTextResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAnalyzeTextResult(document.RootElement, options);
        }

        internal static AnalyzeTextResult DeserializeAnalyzeTextResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<TextBlocklistMatch> blocklistsMatch = default;
            IReadOnlyList<TextCategoriesAnalysis> categoriesAnalysis = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("blocklistsMatch"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TextBlocklistMatch> array = new List<TextBlocklistMatch>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TextBlocklistMatch.DeserializeTextBlocklistMatch(item, options));
                    }
                    blocklistsMatch = array;
                    continue;
                }
                if (property.NameEquals("categoriesAnalysis"u8))
                {
                    List<TextCategoriesAnalysis> array = new List<TextCategoriesAnalysis>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TextCategoriesAnalysis.DeserializeTextCategoriesAnalysis(item, options));
                    }
                    categoriesAnalysis = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AnalyzeTextResult(blocklistsMatch ?? new ChangeTrackingList<TextBlocklistMatch>(), categoriesAnalysis, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AnalyzeTextResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalyzeTextResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AnalyzeTextResult)} does not support writing '{options.Format}' format.");
            }
        }

        AnalyzeTextResult IPersistableModel<AnalyzeTextResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalyzeTextResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAnalyzeTextResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AnalyzeTextResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AnalyzeTextResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AnalyzeTextResult FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAnalyzeTextResult(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
