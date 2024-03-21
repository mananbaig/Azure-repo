// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class AnalysisDetectorEvidences : IUtf8JsonSerializable, IJsonModel<AnalysisDetectorEvidences>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AnalysisDetectorEvidences>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AnalysisDetectorEvidences>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalysisDetectorEvidences>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AnalysisDetectorEvidences)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Source))
            {
                writer.WritePropertyName("source"u8);
                writer.WriteStringValue(Source);
            }
            if (Optional.IsDefined(DetectorDefinition))
            {
                writer.WritePropertyName("detectorDefinition"u8);
                writer.WriteObjectValue(DetectorDefinition);
            }
            if (Optional.IsCollectionDefined(Metrics))
            {
                writer.WritePropertyName("metrics"u8);
                writer.WriteStartArray();
                foreach (var item in Metrics)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Data))
            {
                writer.WritePropertyName("data"u8);
                writer.WriteStartArray();
                foreach (var item in Data)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStartArray();
                    foreach (var item0 in item)
                    {
                        writer.WriteObjectValue(item0);
                    }
                    writer.WriteEndArray();
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DetectorMetaData))
            {
                writer.WritePropertyName("detectorMetaData"u8);
                writer.WriteObjectValue(DetectorMetaData);
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

        AnalysisDetectorEvidences IJsonModel<AnalysisDetectorEvidences>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalysisDetectorEvidences>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AnalysisDetectorEvidences)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAnalysisDetectorEvidences(document.RootElement, options);
        }

        internal static AnalysisDetectorEvidences DeserializeAnalysisDetectorEvidences(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string source = default;
            DetectorDefinition detectorDefinition = default;
            IList<DiagnosticMetricSet> metrics = default;
            IList<IList<AppServiceNameValuePair>> data = default;
            DetectorMetadata detectorMetaData = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("source"u8))
                {
                    source = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("detectorDefinition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    detectorDefinition = DetectorDefinition.DeserializeDetectorDefinition(property.Value, options);
                    continue;
                }
                if (property.NameEquals("metrics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DiagnosticMetricSet> array = new List<DiagnosticMetricSet>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DiagnosticMetricSet.DeserializeDiagnosticMetricSet(item, options));
                    }
                    metrics = array;
                    continue;
                }
                if (property.NameEquals("data"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IList<AppServiceNameValuePair>> array = new List<IList<AppServiceNameValuePair>>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            List<AppServiceNameValuePair> array0 = new List<AppServiceNameValuePair>();
                            foreach (var item0 in item.EnumerateArray())
                            {
                                array0.Add(AppServiceNameValuePair.DeserializeAppServiceNameValuePair(item0, options));
                            }
                            array.Add(array0);
                        }
                    }
                    data = array;
                    continue;
                }
                if (property.NameEquals("detectorMetaData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    detectorMetaData = DetectorMetadata.DeserializeDetectorMetadata(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AnalysisDetectorEvidences(
                source,
                detectorDefinition,
                metrics ?? new ChangeTrackingList<DiagnosticMetricSet>(),
                data ?? new ChangeTrackingList<IList<AppServiceNameValuePair>>(),
                detectorMetaData,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AnalysisDetectorEvidences>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalysisDetectorEvidences>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AnalysisDetectorEvidences)} does not support writing '{options.Format}' format.");
            }
        }

        AnalysisDetectorEvidences IPersistableModel<AnalysisDetectorEvidences>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalysisDetectorEvidences>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAnalysisDetectorEvidences(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AnalysisDetectorEvidences)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AnalysisDetectorEvidences>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
