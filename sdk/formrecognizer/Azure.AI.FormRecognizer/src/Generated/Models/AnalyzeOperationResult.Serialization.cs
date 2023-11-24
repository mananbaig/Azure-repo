// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Models
{
    internal partial class AnalyzeOperationResult : IUtf8JsonSerializable, IJsonModel<AnalyzeOperationResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AnalyzeOperationResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AnalyzeOperationResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalyzeOperationResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(AnalyzeOperationResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("status"u8);
            writer.WriteStringValue(Status.ToSerialString());
            writer.WritePropertyName("createdDateTime"u8);
            writer.WriteStringValue(CreatedDateTime, "O");
            writer.WritePropertyName("lastUpdatedDateTime"u8);
            writer.WriteStringValue(LastUpdatedDateTime, "O");
            if (Optional.IsDefined(AnalyzeResult))
            {
                if (AnalyzeResult != null)
                {
                    writer.WritePropertyName("analyzeResult"u8);
                    writer.WriteObjectValue(AnalyzeResult);
                }
                else
                {
                    writer.WriteNull("analyzeResult");
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

        AnalyzeOperationResult IJsonModel<AnalyzeOperationResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalyzeOperationResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(AnalyzeOperationResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAnalyzeOperationResult(document.RootElement, options);
        }

        internal static AnalyzeOperationResult DeserializeAnalyzeOperationResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            OperationStatus status = default;
            DateTimeOffset createdDateTime = default;
            DateTimeOffset lastUpdatedDateTime = default;
            Optional<V2AnalyzeResult> analyzeResult = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString().ToOperationStatus();
                    continue;
                }
                if (property.NameEquals("createdDateTime"u8))
                {
                    createdDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastUpdatedDateTime"u8))
                {
                    lastUpdatedDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("analyzeResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        analyzeResult = null;
                        continue;
                    }
                    analyzeResult = V2AnalyzeResult.DeserializeV2AnalyzeResult(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AnalyzeOperationResult(status, createdDateTime, lastUpdatedDateTime, analyzeResult.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AnalyzeOperationResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalyzeOperationResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(AnalyzeOperationResult)} does not support '{options.Format}' format.");
            }
        }

        AnalyzeOperationResult IPersistableModel<AnalyzeOperationResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalyzeOperationResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAnalyzeOperationResult(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(AnalyzeOperationResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AnalyzeOperationResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
