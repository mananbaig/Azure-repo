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
    public partial class ForecastDefinition : IUtf8JsonSerializable, IJsonModel<ForecastDefinition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ForecastDefinition>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ForecastDefinition>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ForecastDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ForecastDefinition)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ForecastType.ToString());
            writer.WritePropertyName("timeframe"u8);
            writer.WriteStringValue(Timeframe.ToString());
            if (TimePeriod != null)
            {
                writer.WritePropertyName("timePeriod"u8);
                writer.WriteObjectValue(TimePeriod);
            }
            writer.WritePropertyName("dataset"u8);
            writer.WriteObjectValue(Dataset);
            if (IncludeActualCost.HasValue)
            {
                writer.WritePropertyName("includeActualCost"u8);
                writer.WriteBooleanValue(IncludeActualCost.Value);
            }
            if (IncludeFreshPartialCost.HasValue)
            {
                writer.WritePropertyName("includeFreshPartialCost"u8);
                writer.WriteBooleanValue(IncludeFreshPartialCost.Value);
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

        ForecastDefinition IJsonModel<ForecastDefinition>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ForecastDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ForecastDefinition)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeForecastDefinition(document.RootElement, options);
        }

        internal static ForecastDefinition DeserializeForecastDefinition(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ForecastType type = default;
            ForecastTimeframe timeframe = default;
            Optional<ForecastTimePeriod> timePeriod = default;
            ForecastDataset dataset = default;
            Optional<bool> includeActualCost = default;
            Optional<bool> includeFreshPartialCost = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new ForecastType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("timeframe"u8))
                {
                    timeframe = new ForecastTimeframe(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("timePeriod"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timePeriod = ForecastTimePeriod.DeserializeForecastTimePeriod(property.Value, options);
                    continue;
                }
                if (property.NameEquals("dataset"u8))
                {
                    dataset = ForecastDataset.DeserializeForecastDataset(property.Value, options);
                    continue;
                }
                if (property.NameEquals("includeActualCost"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    includeActualCost = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("includeFreshPartialCost"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    includeFreshPartialCost = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ForecastDefinition(type, timeframe, timePeriod.Value, dataset, Optional.ToNullable(includeActualCost), Optional.ToNullable(includeFreshPartialCost), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ForecastDefinition>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ForecastDefinition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ForecastDefinition)} does not support '{options.Format}' format.");
            }
        }

        ForecastDefinition IPersistableModel<ForecastDefinition>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ForecastDefinition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeForecastDefinition(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ForecastDefinition)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ForecastDefinition>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
