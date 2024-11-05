// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Consumption.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Consumption
{
    public partial class ConsumptionBudgetData : IUtf8JsonSerializable, IJsonModel<ConsumptionBudgetData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConsumptionBudgetData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ConsumptionBudgetData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionBudgetData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConsumptionBudgetData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("eTag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Category))
            {
                writer.WritePropertyName("category"u8);
                writer.WriteStringValue(Category.Value.ToString());
            }
            if (Optional.IsDefined(Amount))
            {
                writer.WritePropertyName("amount"u8);
                writer.WriteNumberValue(Amount.Value);
            }
            if (Optional.IsDefined(TimeGrain))
            {
                writer.WritePropertyName("timeGrain"u8);
                writer.WriteStringValue(TimeGrain.Value.ToString());
            }
            if (Optional.IsDefined(TimePeriod))
            {
                writer.WritePropertyName("timePeriod"u8);
                writer.WriteObjectValue(TimePeriod, options);
            }
            if (Optional.IsDefined(Filter))
            {
                writer.WritePropertyName("filter"u8);
                writer.WriteObjectValue(Filter, options);
            }
            if (options.Format != "W" && Optional.IsDefined(CurrentSpend))
            {
                writer.WritePropertyName("currentSpend"u8);
                writer.WriteObjectValue(CurrentSpend, options);
            }
            if (Optional.IsCollectionDefined(Notifications))
            {
                writer.WritePropertyName("notifications"u8);
                writer.WriteStartObject();
                foreach (var item in Notifications)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value, options);
                }
                writer.WriteEndObject();
            }
            if (options.Format != "W" && Optional.IsDefined(ForecastSpend))
            {
                writer.WritePropertyName("forecastSpend"u8);
                writer.WriteObjectValue(ForecastSpend, options);
            }
            writer.WriteEndObject();
        }

        ConsumptionBudgetData IJsonModel<ConsumptionBudgetData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionBudgetData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConsumptionBudgetData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConsumptionBudgetData(document.RootElement, options);
        }

        internal static ConsumptionBudgetData DeserializeConsumptionBudgetData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ETag? etag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            BudgetCategory? category = default;
            decimal? amount = default;
            BudgetTimeGrainType? timeGrain = default;
            BudgetTimePeriod timePeriod = default;
            ConsumptionBudgetFilter filter = default;
            BudgetCurrentSpend currentSpend = default;
            IDictionary<string, BudgetAssociatedNotification> notifications = default;
            BudgetForecastSpend forecastSpend = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("eTag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
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
                        if (property0.NameEquals("category"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            category = new BudgetCategory(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("amount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            amount = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("timeGrain"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            timeGrain = new BudgetTimeGrainType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("timePeriod"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            timePeriod = BudgetTimePeriod.DeserializeBudgetTimePeriod(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("filter"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            filter = ConsumptionBudgetFilter.DeserializeConsumptionBudgetFilter(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("currentSpend"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            currentSpend = BudgetCurrentSpend.DeserializeBudgetCurrentSpend(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("notifications"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, BudgetAssociatedNotification> dictionary = new Dictionary<string, BudgetAssociatedNotification>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, BudgetAssociatedNotification.DeserializeBudgetAssociatedNotification(property1.Value, options));
                            }
                            notifications = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("forecastSpend"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            forecastSpend = BudgetForecastSpend.DeserializeBudgetForecastSpend(property0.Value, options);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ConsumptionBudgetData(
                id,
                name,
                type,
                systemData,
                category,
                amount,
                timeGrain,
                timePeriod,
                filter,
                currentSpend,
                notifications ?? new ChangeTrackingDictionary<string, BudgetAssociatedNotification>(),
                forecastSpend,
                etag,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ConsumptionBudgetData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionBudgetData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConsumptionBudgetData)} does not support writing '{options.Format}' format.");
            }
        }

        ConsumptionBudgetData IPersistableModel<ConsumptionBudgetData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionBudgetData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConsumptionBudgetData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConsumptionBudgetData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConsumptionBudgetData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
