// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class DataBoxEdgeMetricConfiguration : IUtf8JsonSerializable, IJsonModel<DataBoxEdgeMetricConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataBoxEdgeMetricConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DataBoxEdgeMetricConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxEdgeMetricConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxEdgeMetricConfiguration)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("resourceId"u8);
            writer.WriteStringValue(ResourceId);
            if (Optional.IsDefined(MdmAccount))
            {
                writer.WritePropertyName("mdmAccount"u8);
                writer.WriteStringValue(MdmAccount);
            }
            if (Optional.IsDefined(MetricNameSpace))
            {
                writer.WritePropertyName("metricNameSpace"u8);
                writer.WriteStringValue(MetricNameSpace);
            }
            writer.WritePropertyName("counterSets"u8);
            writer.WriteStartArray();
            foreach (var item in CounterSets)
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
        }

        DataBoxEdgeMetricConfiguration IJsonModel<DataBoxEdgeMetricConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxEdgeMetricConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxEdgeMetricConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataBoxEdgeMetricConfiguration(document.RootElement, options);
        }

        internal static DataBoxEdgeMetricConfiguration DeserializeDataBoxEdgeMetricConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier resourceId = default;
            string mdmAccount = default;
            string metricNameSpace = default;
            IList<DataBoxEdgeMetricCounterSet> counterSets = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceId"u8))
                {
                    resourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("mdmAccount"u8))
                {
                    mdmAccount = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metricNameSpace"u8))
                {
                    metricNameSpace = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("counterSets"u8))
                {
                    List<DataBoxEdgeMetricCounterSet> array = new List<DataBoxEdgeMetricCounterSet>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataBoxEdgeMetricCounterSet.DeserializeDataBoxEdgeMetricCounterSet(item, options));
                    }
                    counterSets = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DataBoxEdgeMetricConfiguration(resourceId, mdmAccount, metricNameSpace, counterSets, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataBoxEdgeMetricConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxEdgeMetricConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataBoxEdgeMetricConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        DataBoxEdgeMetricConfiguration IPersistableModel<DataBoxEdgeMetricConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxEdgeMetricConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataBoxEdgeMetricConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataBoxEdgeMetricConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataBoxEdgeMetricConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
