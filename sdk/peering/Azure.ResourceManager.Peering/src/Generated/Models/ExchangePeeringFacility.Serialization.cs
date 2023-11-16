// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Peering.Models
{
    public partial class ExchangePeeringFacility : IUtf8JsonSerializable, IJsonModel<ExchangePeeringFacility>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExchangePeeringFacility>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<ExchangePeeringFacility>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<ExchangePeeringFacility>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<ExchangePeeringFacility>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ExchangeName))
            {
                writer.WritePropertyName("exchangeName"u8);
                writer.WriteStringValue(ExchangeName);
            }
            if (Optional.IsDefined(BandwidthInMbps))
            {
                writer.WritePropertyName("bandwidthInMbps"u8);
                writer.WriteNumberValue(BandwidthInMbps.Value);
            }
            if (Optional.IsDefined(MicrosoftIPv4Address))
            {
                writer.WritePropertyName("microsoftIPv4Address"u8);
                writer.WriteStringValue(MicrosoftIPv4Address.ToString());
            }
            if (Optional.IsDefined(MicrosoftIPv6Address))
            {
                writer.WritePropertyName("microsoftIPv6Address"u8);
                writer.WriteStringValue(MicrosoftIPv6Address.ToString());
            }
            if (Optional.IsDefined(FacilityIPv4Prefix))
            {
                writer.WritePropertyName("facilityIPv4Prefix"u8);
                writer.WriteStringValue(FacilityIPv4Prefix);
            }
            if (Optional.IsDefined(FacilityIPv6Prefix))
            {
                writer.WritePropertyName("facilityIPv6Prefix"u8);
                writer.WriteStringValue(FacilityIPv6Prefix);
            }
            if (Optional.IsDefined(PeeringDBFacilityId))
            {
                writer.WritePropertyName("peeringDBFacilityId"u8);
                writer.WriteNumberValue(PeeringDBFacilityId.Value);
            }
            if (Optional.IsDefined(PeeringDBFacilityLink))
            {
                writer.WritePropertyName("peeringDBFacilityLink"u8);
                writer.WriteStringValue(PeeringDBFacilityLink);
            }
            if (_serializedAdditionalRawData != null && options.Format == "J")
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

        ExchangePeeringFacility IJsonModel<ExchangePeeringFacility>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ExchangePeeringFacility)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExchangePeeringFacility(document.RootElement, options);
        }

        internal static ExchangePeeringFacility DeserializeExchangePeeringFacility(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> exchangeName = default;
            Optional<int> bandwidthInMbps = default;
            Optional<IPAddress> microsoftIPv4Address = default;
            Optional<IPAddress> microsoftIPv6Address = default;
            Optional<string> facilityIPv4Prefix = default;
            Optional<string> facilityIPv6Prefix = default;
            Optional<int> peeringDBFacilityId = default;
            Optional<string> peeringDBFacilityLink = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("exchangeName"u8))
                {
                    exchangeName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("bandwidthInMbps"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bandwidthInMbps = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("microsoftIPv4Address"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null || property.Value.ValueKind == JsonValueKind.String && property.Value.GetString().Length == 0)
                    {
                        continue;
                    }
                    microsoftIPv4Address = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("microsoftIPv6Address"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null || property.Value.ValueKind == JsonValueKind.String && property.Value.GetString().Length == 0)
                    {
                        continue;
                    }
                    microsoftIPv6Address = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("facilityIPv4Prefix"u8))
                {
                    facilityIPv4Prefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("facilityIPv6Prefix"u8))
                {
                    facilityIPv6Prefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("peeringDBFacilityId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    peeringDBFacilityId = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("peeringDBFacilityLink"u8))
                {
                    peeringDBFacilityLink = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ExchangePeeringFacility(exchangeName.Value, Optional.ToNullable(bandwidthInMbps), microsoftIPv4Address.Value, microsoftIPv6Address.Value, facilityIPv4Prefix.Value, facilityIPv6Prefix.Value, Optional.ToNullable(peeringDBFacilityId), peeringDBFacilityLink.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ExchangePeeringFacility>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ExchangePeeringFacility)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ExchangePeeringFacility IPersistableModel<ExchangePeeringFacility>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ExchangePeeringFacility)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeExchangePeeringFacility(document.RootElement, options);
        }

        string IPersistableModel<ExchangePeeringFacility>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
