// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CostManagement.Models
{
    public partial class ReportConfigDataset : IUtf8JsonSerializable, IJsonModel<ReportConfigDataset>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ReportConfigDataset>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ReportConfigDataset>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReportConfigDataset>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReportConfigDataset)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Granularity.HasValue)
            {
                writer.WritePropertyName("granularity"u8);
                writer.WriteStringValue(Granularity.Value.ToString());
            }
            if (Configuration != null)
            {
                writer.WritePropertyName("configuration"u8);
                writer.WriteObjectValue(Configuration);
            }
            if (!(Aggregation is ChangeTrackingDictionary<string, ReportConfigAggregation> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("aggregation"u8);
                writer.WriteStartObject();
                foreach (var item in Aggregation)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (!(Grouping is ChangeTrackingList<ReportConfigGrouping> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("grouping"u8);
                writer.WriteStartArray();
                foreach (var item in Grouping)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(Sorting is ChangeTrackingList<ReportConfigSorting> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("sorting"u8);
                writer.WriteStartArray();
                foreach (var item in Sorting)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Filter != null)
            {
                writer.WritePropertyName("filter"u8);
                writer.WriteObjectValue(Filter);
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

        ReportConfigDataset IJsonModel<ReportConfigDataset>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReportConfigDataset>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReportConfigDataset)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeReportConfigDataset(document.RootElement, options);
        }

        internal static ReportConfigDataset DeserializeReportConfigDataset(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ReportGranularityType> granularity = default;
            Optional<ReportConfigDatasetConfiguration> configuration = default;
            Optional<IDictionary<string, ReportConfigAggregation>> aggregation = default;
            Optional<IList<ReportConfigGrouping>> grouping = default;
            Optional<IList<ReportConfigSorting>> sorting = default;
            Optional<ReportConfigFilter> filter = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("granularity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    granularity = new ReportGranularityType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("configuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    configuration = ReportConfigDatasetConfiguration.DeserializeReportConfigDatasetConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("aggregation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, ReportConfigAggregation> dictionary = new Dictionary<string, ReportConfigAggregation>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, ReportConfigAggregation.DeserializeReportConfigAggregation(property0.Value, options));
                    }
                    aggregation = dictionary;
                    continue;
                }
                if (property.NameEquals("grouping"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ReportConfigGrouping> array = new List<ReportConfigGrouping>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReportConfigGrouping.DeserializeReportConfigGrouping(item, options));
                    }
                    grouping = array;
                    continue;
                }
                if (property.NameEquals("sorting"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ReportConfigSorting> array = new List<ReportConfigSorting>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReportConfigSorting.DeserializeReportConfigSorting(item, options));
                    }
                    sorting = array;
                    continue;
                }
                if (property.NameEquals("filter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    filter = ReportConfigFilter.DeserializeReportConfigFilter(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ReportConfigDataset(Optional.ToNullable(granularity), configuration.Value, Optional.ToDictionary(aggregation), Optional.ToList(grouping), Optional.ToList(sorting), filter.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ReportConfigDataset>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReportConfigDataset>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ReportConfigDataset)} does not support '{options.Format}' format.");
            }
        }

        ReportConfigDataset IPersistableModel<ReportConfigDataset>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReportConfigDataset>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeReportConfigDataset(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ReportConfigDataset)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ReportConfigDataset>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
