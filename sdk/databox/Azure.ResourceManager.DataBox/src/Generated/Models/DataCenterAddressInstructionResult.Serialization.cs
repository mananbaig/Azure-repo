// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataBox;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class DataCenterAddressInstructionResult : IUtf8JsonSerializable, IJsonModel<DataCenterAddressInstructionResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataCenterAddressInstructionResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataCenterAddressInstructionResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCenterAddressInstructionResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataCenterAddressInstructionResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(CommunicationInstruction))
            {
                writer.WritePropertyName("communicationInstruction"u8);
                writer.WriteStringValue(CommunicationInstruction);
            }
            writer.WritePropertyName("datacenterAddressType"u8);
            writer.WriteStringValue(DataCenterAddressType.ToSerialString());
            if (options.Format != "W" && Optional.IsCollectionDefined(SupportedCarriersForReturnShipment))
            {
                writer.WritePropertyName("supportedCarriersForReturnShipment"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedCarriersForReturnShipment)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(DataCenterAzureLocation))
            {
                writer.WritePropertyName("dataCenterAzureLocation"u8);
                writer.WriteStringValue(DataCenterAzureLocation.Value);
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

        DataCenterAddressInstructionResult IJsonModel<DataCenterAddressInstructionResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCenterAddressInstructionResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataCenterAddressInstructionResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataCenterAddressInstructionResult(document.RootElement, options);
        }

        internal static DataCenterAddressInstructionResult DeserializeDataCenterAddressInstructionResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string communicationInstruction = default;
            DataCenterAddressType dataCenterAddressType = default;
            IReadOnlyList<string> supportedCarriersForReturnShipment = default;
            AzureLocation? dataCenterAzureLocation = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("communicationInstruction"u8))
                {
                    communicationInstruction = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("datacenterAddressType"u8))
                {
                    dataCenterAddressType = property.Value.GetString().ToDataCenterAddressType();
                    continue;
                }
                if (property.NameEquals("supportedCarriersForReturnShipment"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    supportedCarriersForReturnShipment = array;
                    continue;
                }
                if (property.NameEquals("dataCenterAzureLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataCenterAzureLocation = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataCenterAddressInstructionResult(dataCenterAddressType, supportedCarriersForReturnShipment ?? new ChangeTrackingList<string>(), dataCenterAzureLocation, serializedAdditionalRawData, communicationInstruction);
        }

        BinaryData IPersistableModel<DataCenterAddressInstructionResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCenterAddressInstructionResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataCenterAddressInstructionResult)} does not support '{options.Format}' format.");
            }
        }

        DataCenterAddressInstructionResult IPersistableModel<DataCenterAddressInstructionResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCenterAddressInstructionResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataCenterAddressInstructionResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataCenterAddressInstructionResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataCenterAddressInstructionResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
