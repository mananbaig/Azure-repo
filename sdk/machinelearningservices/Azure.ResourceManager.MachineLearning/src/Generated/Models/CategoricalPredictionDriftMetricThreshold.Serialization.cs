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
    public partial class CategoricalPredictionDriftMetricThreshold : IUtf8JsonSerializable, IJsonModel<CategoricalPredictionDriftMetricThreshold>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CategoricalPredictionDriftMetricThreshold>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CategoricalPredictionDriftMetricThreshold>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CategoricalPredictionDriftMetricThreshold>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CategoricalPredictionDriftMetricThreshold)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("metric"u8);
            writer.WriteStringValue(Metric.ToString());
            writer.WritePropertyName("dataType"u8);
            writer.WriteStringValue(DataType.ToString());
            if (Optional.IsDefined(Threshold))
            {
                if (Threshold != null)
                {
                    writer.WritePropertyName("threshold"u8);
                    writer.WriteObjectValue(Threshold);
                }
                else
                {
                    writer.WriteNull("threshold");
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

        CategoricalPredictionDriftMetricThreshold IJsonModel<CategoricalPredictionDriftMetricThreshold>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CategoricalPredictionDriftMetricThreshold>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CategoricalPredictionDriftMetricThreshold)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCategoricalPredictionDriftMetricThreshold(document.RootElement, options);
        }

        internal static CategoricalPredictionDriftMetricThreshold DeserializeCategoricalPredictionDriftMetricThreshold(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            CategoricalPredictionDriftMetric metric = default;
            MonitoringFeatureDataType dataType = default;
            MonitoringThreshold threshold = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("metric"u8))
                {
                    metric = new CategoricalPredictionDriftMetric(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dataType"u8))
                {
                    dataType = new MonitoringFeatureDataType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("threshold"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        threshold = null;
                        continue;
                    }
                    threshold = MonitoringThreshold.DeserializeMonitoringThreshold(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CategoricalPredictionDriftMetricThreshold(dataType, threshold, serializedAdditionalRawData, metric);
        }

        BinaryData IPersistableModel<CategoricalPredictionDriftMetricThreshold>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CategoricalPredictionDriftMetricThreshold>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CategoricalPredictionDriftMetricThreshold)} does not support '{options.Format}' format.");
            }
        }

        CategoricalPredictionDriftMetricThreshold IPersistableModel<CategoricalPredictionDriftMetricThreshold>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CategoricalPredictionDriftMetricThreshold>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCategoricalPredictionDriftMetricThreshold(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CategoricalPredictionDriftMetricThreshold)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CategoricalPredictionDriftMetricThreshold>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
