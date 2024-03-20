// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.CostManagement;

namespace Azure.ResourceManager.CostManagement.Models
{
    internal partial class UnknownBenefitRecommendationProperties : IUtf8JsonSerializable, IJsonModel<BenefitRecommendationProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BenefitRecommendationProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BenefitRecommendationProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BenefitRecommendationProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BenefitRecommendationProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("scope"u8);
            writer.WriteStringValue(Scope.ToString());
            if (options.Format != "W" && Optional.IsDefined(FirstConsumptionOn))
            {
                writer.WritePropertyName("firstConsumptionDate"u8);
                writer.WriteStringValue(FirstConsumptionOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LastConsumptionOn))
            {
                writer.WritePropertyName("lastConsumptionDate"u8);
                writer.WriteStringValue(LastConsumptionOn.Value, "O");
            }
            if (Optional.IsDefined(LookBackPeriod))
            {
                writer.WritePropertyName("lookBackPeriod"u8);
                writer.WriteStringValue(LookBackPeriod.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(TotalHours))
            {
                writer.WritePropertyName("totalHours"u8);
                writer.WriteNumberValue(TotalHours.Value);
            }
            if (Optional.IsDefined(Usage))
            {
                writer.WritePropertyName("usage"u8);
                writer.WriteObjectValue(Usage);
            }
            if (options.Format != "W" && Optional.IsDefined(ArmSkuName))
            {
                writer.WritePropertyName("armSkuName"u8);
                writer.WriteStringValue(ArmSkuName);
            }
            if (Optional.IsDefined(Term))
            {
                writer.WritePropertyName("term"u8);
                writer.WriteStringValue(Term.Value.ToString());
            }
            if (Optional.IsDefined(CommitmentGranularity))
            {
                writer.WritePropertyName("commitmentGranularity"u8);
                writer.WriteStringValue(CommitmentGranularity.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(CurrencyCode))
            {
                writer.WritePropertyName("currencyCode"u8);
                writer.WriteStringValue(CurrencyCode);
            }
            if (options.Format != "W" && Optional.IsDefined(CostWithoutBenefit))
            {
                writer.WritePropertyName("costWithoutBenefit"u8);
                writer.WriteNumberValue(CostWithoutBenefit.Value);
            }
            if (Optional.IsDefined(RecommendationDetails))
            {
                writer.WritePropertyName("recommendationDetails"u8);
                writer.WriteObjectValue(RecommendationDetails);
            }
            if (options.Format != "W" && Optional.IsDefined(AllRecommendationDetails))
            {
                writer.WritePropertyName("allRecommendationDetails"u8);
                writer.WriteObjectValue(AllRecommendationDetails);
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

        BenefitRecommendationProperties IJsonModel<BenefitRecommendationProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BenefitRecommendationProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BenefitRecommendationProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBenefitRecommendationProperties(document.RootElement, options);
        }

        internal static UnknownBenefitRecommendationProperties DeserializeUnknownBenefitRecommendationProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            BenefitRecommendationScope scope = "Unknown";
            DateTimeOffset? firstConsumptionDate = default;
            DateTimeOffset? lastConsumptionDate = default;
            LookBackPeriod? lookBackPeriod = default;
            int? totalHours = default;
            RecommendationUsageDetails usage = default;
            string armSkuName = default;
            BenefitRecommendationPeriodTerm? term = default;
            BenefitRecommendationUsageGrain? commitmentGranularity = default;
            string currencyCode = default;
            decimal? costWithoutBenefit = default;
            AllSavingsBenefitDetails recommendationDetails = default;
            AllSavingsList allRecommendationDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("scope"u8))
                {
                    scope = new BenefitRecommendationScope(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("firstConsumptionDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    firstConsumptionDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastConsumptionDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastConsumptionDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lookBackPeriod"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lookBackPeriod = new LookBackPeriod(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("totalHours"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalHours = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("usage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    usage = RecommendationUsageDetails.DeserializeRecommendationUsageDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("armSkuName"u8))
                {
                    armSkuName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("term"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    term = new BenefitRecommendationPeriodTerm(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("commitmentGranularity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    commitmentGranularity = new BenefitRecommendationUsageGrain(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("currencyCode"u8))
                {
                    currencyCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("costWithoutBenefit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    costWithoutBenefit = property.Value.GetDecimal();
                    continue;
                }
                if (property.NameEquals("recommendationDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recommendationDetails = AllSavingsBenefitDetails.DeserializeAllSavingsBenefitDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("allRecommendationDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allRecommendationDetails = AllSavingsList.DeserializeAllSavingsList(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new UnknownBenefitRecommendationProperties(
                firstConsumptionDate,
                lastConsumptionDate,
                lookBackPeriod,
                totalHours,
                usage,
                armSkuName,
                term,
                commitmentGranularity,
                currencyCode,
                costWithoutBenefit,
                recommendationDetails,
                allRecommendationDetails,
                scope,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BenefitRecommendationProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BenefitRecommendationProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BenefitRecommendationProperties)} does not support '{options.Format}' format.");
            }
        }

        BenefitRecommendationProperties IPersistableModel<BenefitRecommendationProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BenefitRecommendationProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBenefitRecommendationProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BenefitRecommendationProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BenefitRecommendationProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
