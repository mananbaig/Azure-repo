// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Compute.Batch
{
    public partial class BatchPoolResourceStatistics : IUtf8JsonSerializable, IJsonModel<BatchPoolResourceStatistics>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BatchPoolResourceStatistics>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BatchPoolResourceStatistics>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchPoolResourceStatistics>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchPoolResourceStatistics)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("startTime"u8);
            writer.WriteStringValue(StartTime, "O");
            writer.WritePropertyName("lastUpdateTime"u8);
            writer.WriteStringValue(LastUpdateTime, "O");
            writer.WritePropertyName("avgCPUPercentage"u8);
            writer.WriteNumberValue(AvgCpuPercentage);
            writer.WritePropertyName("avgMemoryGiB"u8);
            writer.WriteNumberValue(AvgMemoryGiB);
            writer.WritePropertyName("peakMemoryGiB"u8);
            writer.WriteNumberValue(PeakMemoryGiB);
            writer.WritePropertyName("avgDiskGiB"u8);
            writer.WriteNumberValue(AvgDiskGiB);
            writer.WritePropertyName("peakDiskGiB"u8);
            writer.WriteNumberValue(PeakDiskGiB);
            writer.WritePropertyName("diskReadIOps"u8);
            writer.WriteNumberValue(DiskReadIOps);
            writer.WritePropertyName("diskWriteIOps"u8);
            writer.WriteNumberValue(DiskWriteIOps);
            writer.WritePropertyName("diskReadGiB"u8);
            writer.WriteNumberValue(DiskReadGiB);
            writer.WritePropertyName("diskWriteGiB"u8);
            writer.WriteNumberValue(DiskWriteGiB);
            writer.WritePropertyName("networkReadGiB"u8);
            writer.WriteNumberValue(NetworkReadGiB);
            writer.WritePropertyName("networkWriteGiB"u8);
            writer.WriteNumberValue(NetworkWriteGiB);
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
        }

        BatchPoolResourceStatistics IJsonModel<BatchPoolResourceStatistics>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchPoolResourceStatistics>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchPoolResourceStatistics)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBatchPoolResourceStatistics(document.RootElement, options);
        }

        internal static BatchPoolResourceStatistics DeserializeBatchPoolResourceStatistics(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset startTime = default;
            DateTimeOffset lastUpdateTime = default;
            float avgCPUPercentage = default;
            float avgMemoryGiB = default;
            float peakMemoryGiB = default;
            float avgDiskGiB = default;
            float peakDiskGiB = default;
            long diskReadIOps = default;
            long diskWriteIOps = default;
            float diskReadGiB = default;
            float diskWriteGiB = default;
            float networkReadGiB = default;
            float networkWriteGiB = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("startTime"u8))
                {
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastUpdateTime"u8))
                {
                    lastUpdateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("avgCPUPercentage"u8))
                {
                    avgCPUPercentage = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("avgMemoryGiB"u8))
                {
                    avgMemoryGiB = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("peakMemoryGiB"u8))
                {
                    peakMemoryGiB = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("avgDiskGiB"u8))
                {
                    avgDiskGiB = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("peakDiskGiB"u8))
                {
                    peakDiskGiB = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("diskReadIOps"u8))
                {
                    diskReadIOps = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("diskWriteIOps"u8))
                {
                    diskWriteIOps = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("diskReadGiB"u8))
                {
                    diskReadGiB = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("diskWriteGiB"u8))
                {
                    diskWriteGiB = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("networkReadGiB"u8))
                {
                    networkReadGiB = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("networkWriteGiB"u8))
                {
                    networkWriteGiB = property.Value.GetSingle();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new BatchPoolResourceStatistics(
                startTime,
                lastUpdateTime,
                avgCPUPercentage,
                avgMemoryGiB,
                peakMemoryGiB,
                avgDiskGiB,
                peakDiskGiB,
                diskReadIOps,
                diskWriteIOps,
                diskReadGiB,
                diskWriteGiB,
                networkReadGiB,
                networkWriteGiB,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BatchPoolResourceStatistics>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchPoolResourceStatistics>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BatchPoolResourceStatistics)} does not support writing '{options.Format}' format.");
            }
        }

        BatchPoolResourceStatistics IPersistableModel<BatchPoolResourceStatistics>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchPoolResourceStatistics>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBatchPoolResourceStatistics(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BatchPoolResourceStatistics)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BatchPoolResourceStatistics>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static BatchPoolResourceStatistics FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeBatchPoolResourceStatistics(document.RootElement);
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
