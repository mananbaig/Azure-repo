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

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class AcsEmailDeliveryReportStatusDetails : IUtf8JsonSerializable, IJsonModel<AcsEmailDeliveryReportStatusDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AcsEmailDeliveryReportStatusDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AcsEmailDeliveryReportStatusDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<AcsEmailDeliveryReportStatusDetails>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<AcsEmailDeliveryReportStatusDetails>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(StatusMessage))
            {
                writer.WritePropertyName("statusMessage"u8);
                writer.WriteStringValue(StatusMessage);
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

        AcsEmailDeliveryReportStatusDetails IJsonModel<AcsEmailDeliveryReportStatusDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AcsEmailDeliveryReportStatusDetails)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAcsEmailDeliveryReportStatusDetails(document.RootElement, options);
        }

        internal static AcsEmailDeliveryReportStatusDetails DeserializeAcsEmailDeliveryReportStatusDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> statusMessage = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("statusMessage"u8))
                {
                    statusMessage = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AcsEmailDeliveryReportStatusDetails(statusMessage.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AcsEmailDeliveryReportStatusDetails>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AcsEmailDeliveryReportStatusDetails)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        AcsEmailDeliveryReportStatusDetails IPersistableModel<AcsEmailDeliveryReportStatusDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AcsEmailDeliveryReportStatusDetails)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeAcsEmailDeliveryReportStatusDetails(document.RootElement, options);
        }

        string IPersistableModel<AcsEmailDeliveryReportStatusDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
