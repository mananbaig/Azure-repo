// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class StartStreamingJobContent : IUtf8JsonSerializable, IJsonModel<StartStreamingJobContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StartStreamingJobContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StartStreamingJobContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StartStreamingJobContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StartStreamingJobContent)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(OutputStartMode))
            {
                writer.WritePropertyName("outputStartMode"u8);
                writer.WriteStringValue(OutputStartMode.Value.ToString());
            }
            if (Optional.IsDefined(OutputStartOn))
            {
                writer.WritePropertyName("outputStartTime"u8);
                writer.WriteStringValue(OutputStartOn.Value, "O");
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

        StartStreamingJobContent IJsonModel<StartStreamingJobContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StartStreamingJobContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StartStreamingJobContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStartStreamingJobContent(document.RootElement, options);
        }

        internal static StartStreamingJobContent DeserializeStartStreamingJobContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            StreamingJobOutputStartMode? outputStartMode = default;
            DateTimeOffset? outputStartTime = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("outputStartMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    outputStartMode = new StreamingJobOutputStartMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("outputStartTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    outputStartTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StartStreamingJobContent(outputStartMode, outputStartTime, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StartStreamingJobContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StartStreamingJobContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StartStreamingJobContent)} does not support writing '{options.Format}' format.");
            }
        }

        StartStreamingJobContent IPersistableModel<StartStreamingJobContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StartStreamingJobContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStartStreamingJobContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StartStreamingJobContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<StartStreamingJobContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
