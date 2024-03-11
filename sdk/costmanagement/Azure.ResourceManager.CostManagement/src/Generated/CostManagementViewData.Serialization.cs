// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.CostManagement.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CostManagement
{
    public partial class CostManagementViewData : IUtf8JsonSerializable, IJsonModel<CostManagementViewData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CostManagementViewData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CostManagementViewData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CostManagementViewData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CostManagementViewData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("eTag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(Scope))
            {
                writer.WritePropertyName("scope"u8);
                writer.WriteStringValue(Scope);
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("createdOn"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(ModifiedOn))
            {
                writer.WritePropertyName("modifiedOn"u8);
                writer.WriteStringValue(ModifiedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(DateRange))
            {
                writer.WritePropertyName("dateRange"u8);
                writer.WriteStringValue(DateRange);
            }
            if (options.Format != "W" && Optional.IsDefined(Currency))
            {
                writer.WritePropertyName("currency"u8);
                writer.WriteStringValue(Currency);
            }
            if (Optional.IsDefined(Chart))
            {
                writer.WritePropertyName("chart"u8);
                writer.WriteStringValue(Chart.Value.ToString());
            }
            if (Optional.IsDefined(Accumulated))
            {
                writer.WritePropertyName("accumulated"u8);
                writer.WriteStringValue(Accumulated.Value.ToString());
            }
            if (Optional.IsDefined(Metric))
            {
                writer.WritePropertyName("metric"u8);
                writer.WriteStringValue(Metric.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Kpis))
            {
                writer.WritePropertyName("kpis"u8);
                writer.WriteStartArray();
                foreach (var item in Kpis)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Pivots))
            {
                writer.WritePropertyName("pivots"u8);
                writer.WriteStartArray();
                foreach (var item in Pivots)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("query"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(TypePropertiesQueryType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(TypePropertiesQueryType.Value.ToString());
            }
            if (Optional.IsDefined(Timeframe))
            {
                writer.WritePropertyName("timeframe"u8);
                writer.WriteStringValue(Timeframe.Value.ToString());
            }
            if (Optional.IsDefined(TimePeriod))
            {
                writer.WritePropertyName("timePeriod"u8);
                writer.WriteObjectValue(TimePeriod);
            }
            if (Optional.IsDefined(DataSet))
            {
                writer.WritePropertyName("dataSet"u8);
                writer.WriteObjectValue(DataSet);
            }
            if (Optional.IsDefined(IncludeMonetaryCommitment))
            {
                writer.WritePropertyName("includeMonetaryCommitment"u8);
                writer.WriteBooleanValue(IncludeMonetaryCommitment.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
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

        CostManagementViewData IJsonModel<CostManagementViewData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CostManagementViewData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CostManagementViewData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCostManagementViewData(document.RootElement, options);
        }

        internal static CostManagementViewData DeserializeCostManagementViewData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ETag? eTag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string displayName = default;
            ResourceIdentifier scope = default;
            DateTimeOffset? createdOn = default;
            DateTimeOffset? modifiedOn = default;
            string dateRange = default;
            string currency = default;
            ViewChartType? chart = default;
            AccumulatedType? accumulated = default;
            ViewMetricType? metric = default;
            IList<ViewKpiProperties> kpis = default;
            IList<ViewPivotProperties> pivots = default;
            ViewReportType? type0 = default;
            ReportTimeframeType? timeframe = default;
            ReportConfigTimePeriod timePeriod = default;
            ReportConfigDataset dataSet = default;
            bool? includeMonetaryCommitment = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("eTag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    eTag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    ReadId(property, ref id);
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("scope"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            scope = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("createdOn"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdOn = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("modifiedOn"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            modifiedOn = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("dateRange"u8))
                        {
                            dateRange = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("currency"u8))
                        {
                            currency = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("chart"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            chart = new ViewChartType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("accumulated"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            accumulated = new AccumulatedType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("metric"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            metric = new ViewMetricType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("kpis"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ViewKpiProperties> array = new List<ViewKpiProperties>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ViewKpiProperties.DeserializeViewKpiProperties(item, options));
                            }
                            kpis = array;
                            continue;
                        }
                        if (property0.NameEquals("pivots"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ViewPivotProperties> array = new List<ViewPivotProperties>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ViewPivotProperties.DeserializeViewPivotProperties(item, options));
                            }
                            pivots = array;
                            continue;
                        }
                        if (property0.NameEquals("query"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.NameEquals("type"u8))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        continue;
                                    }
                                    type0 = new ViewReportType(property1.Value.GetString());
                                    continue;
                                }
                                if (property1.NameEquals("timeframe"u8))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        continue;
                                    }
                                    timeframe = new ReportTimeframeType(property1.Value.GetString());
                                    continue;
                                }
                                if (property1.NameEquals("timePeriod"u8))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        continue;
                                    }
                                    timePeriod = ReportConfigTimePeriod.DeserializeReportConfigTimePeriod(property1.Value, options);
                                    continue;
                                }
                                if (property1.NameEquals("dataSet"u8))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        continue;
                                    }
                                    dataSet = ReportConfigDataset.DeserializeReportConfigDataset(property1.Value, options);
                                    continue;
                                }
                                if (property1.NameEquals("includeMonetaryCommitment"u8))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        continue;
                                    }
                                    includeMonetaryCommitment = property1.Value.GetBoolean();
                                    continue;
                                }
                            }
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CostManagementViewData(
                id,
                name,
                type,
                systemData,
                displayName,
                scope,
                createdOn,
                modifiedOn,
                dateRange,
                currency,
                chart,
                accumulated,
                metric,
                kpis ?? new ChangeTrackingList<ViewKpiProperties>(),
                pivots ?? new ChangeTrackingList<ViewPivotProperties>(),
                type0,
                timeframe,
                timePeriod,
                dataSet,
                includeMonetaryCommitment,
                eTag,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CostManagementViewData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CostManagementViewData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CostManagementViewData)} does not support '{options.Format}' format.");
            }
        }

        CostManagementViewData IPersistableModel<CostManagementViewData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CostManagementViewData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCostManagementViewData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CostManagementViewData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CostManagementViewData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
