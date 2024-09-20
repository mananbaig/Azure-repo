// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.BillingBenefits.Models
{
    public partial class BillingBenefitsSavingsPlanUtilizationAggregate : IUtf8JsonSerializable, IJsonModel<BillingBenefitsSavingsPlanUtilizationAggregate>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BillingBenefitsSavingsPlanUtilizationAggregate>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BillingBenefitsSavingsPlanUtilizationAggregate>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingBenefitsSavingsPlanUtilizationAggregate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BillingBenefitsSavingsPlanUtilizationAggregate)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Grain))
            {
                writer.WritePropertyName("grain"u8);
                writer.WriteNumberValue(Grain.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(GrainUnit))
            {
                writer.WritePropertyName("grainUnit"u8);
                writer.WriteStringValue(GrainUnit);
            }
            if (options.Format != "W" && Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteNumberValue(Value.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ValueUnit))
            {
                writer.WritePropertyName("valueUnit"u8);
                writer.WriteStringValue(ValueUnit);
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

        BillingBenefitsSavingsPlanUtilizationAggregate IJsonModel<BillingBenefitsSavingsPlanUtilizationAggregate>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingBenefitsSavingsPlanUtilizationAggregate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BillingBenefitsSavingsPlanUtilizationAggregate)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBillingBenefitsSavingsPlanUtilizationAggregate(document.RootElement, options);
        }

        internal static BillingBenefitsSavingsPlanUtilizationAggregate DeserializeBillingBenefitsSavingsPlanUtilizationAggregate(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            float? grain = default;
            string grainUnit = default;
            float? value = default;
            string valueUnit = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("grain"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    grain = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("grainUnit"u8))
                {
                    grainUnit = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    value = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("valueUnit"u8))
                {
                    valueUnit = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new BillingBenefitsSavingsPlanUtilizationAggregate(grain, grainUnit, value, valueUnit, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BillingBenefitsSavingsPlanUtilizationAggregate>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingBenefitsSavingsPlanUtilizationAggregate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BillingBenefitsSavingsPlanUtilizationAggregate)} does not support writing '{options.Format}' format.");
            }
        }

        BillingBenefitsSavingsPlanUtilizationAggregate IPersistableModel<BillingBenefitsSavingsPlanUtilizationAggregate>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingBenefitsSavingsPlanUtilizationAggregate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBillingBenefitsSavingsPlanUtilizationAggregate(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BillingBenefitsSavingsPlanUtilizationAggregate)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BillingBenefitsSavingsPlanUtilizationAggregate>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
