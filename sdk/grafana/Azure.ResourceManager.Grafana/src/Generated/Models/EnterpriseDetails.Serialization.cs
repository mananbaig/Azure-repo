// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Grafana.Models
{
    public partial class EnterpriseDetails : IUtf8JsonSerializable, IJsonModel<EnterpriseDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EnterpriseDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<EnterpriseDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EnterpriseDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(EnterpriseDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(SaasSubscriptionDetails))
            {
                writer.WritePropertyName("saasSubscriptionDetails"u8);
                writer.WriteObjectValue(SaasSubscriptionDetails);
            }
            if (Optional.IsDefined(MarketplaceTrialQuota))
            {
                writer.WritePropertyName("marketplaceTrialQuota"u8);
                writer.WriteObjectValue(MarketplaceTrialQuota);
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

        EnterpriseDetails IJsonModel<EnterpriseDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EnterpriseDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(EnterpriseDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEnterpriseDetails(document.RootElement, options);
        }

        internal static EnterpriseDetails DeserializeEnterpriseDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SaasSubscriptionDetails> saasSubscriptionDetails = default;
            Optional<MarketplaceTrialQuota> marketplaceTrialQuota = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("saasSubscriptionDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    saasSubscriptionDetails = SaasSubscriptionDetails.DeserializeSaasSubscriptionDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("marketplaceTrialQuota"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    marketplaceTrialQuota = MarketplaceTrialQuota.DeserializeMarketplaceTrialQuota(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new EnterpriseDetails(saasSubscriptionDetails.Value, marketplaceTrialQuota.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EnterpriseDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EnterpriseDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(EnterpriseDetails)} does not support '{options.Format}' format.");
            }
        }

        EnterpriseDetails IPersistableModel<EnterpriseDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EnterpriseDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEnterpriseDetails(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(EnterpriseDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<EnterpriseDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
