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

namespace Azure.ResourceManager.EdgeOrder.Models
{
    public partial class ForwardShippingDetails : IUtf8JsonSerializable, IJsonModel<ForwardShippingDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ForwardShippingDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ForwardShippingDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ForwardShippingDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ForwardShippingDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(CarrierName))
            {
                writer.WritePropertyName("carrierName"u8);
                writer.WriteStringValue(CarrierName);
            }
            if (options.Format != "W" && Optional.IsDefined(CarrierDisplayName))
            {
                writer.WritePropertyName("carrierDisplayName"u8);
                writer.WriteStringValue(CarrierDisplayName);
            }
            if (options.Format != "W" && Optional.IsDefined(TrackingId))
            {
                writer.WritePropertyName("trackingId"u8);
                writer.WriteStringValue(TrackingId);
            }
            if (options.Format != "W" && Optional.IsDefined(TrackingUri))
            {
                writer.WritePropertyName("trackingUrl"u8);
                writer.WriteStringValue(TrackingUri.AbsoluteUri);
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

        ForwardShippingDetails IJsonModel<ForwardShippingDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ForwardShippingDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ForwardShippingDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeForwardShippingDetails(document.RootElement, options);
        }

        internal static ForwardShippingDetails DeserializeForwardShippingDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> carrierName = default;
            Optional<string> carrierDisplayName = default;
            Optional<string> trackingId = default;
            Optional<Uri> trackingUrl = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("carrierName"u8))
                {
                    carrierName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("carrierDisplayName"u8))
                {
                    carrierDisplayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("trackingId"u8))
                {
                    trackingId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("trackingUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    trackingUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ForwardShippingDetails(carrierName.Value, carrierDisplayName.Value, trackingId.Value, trackingUrl.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ForwardShippingDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ForwardShippingDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(ForwardShippingDetails)} does not support '{options.Format}' format.");
            }
        }

        ForwardShippingDetails IPersistableModel<ForwardShippingDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ForwardShippingDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeForwardShippingDetails(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(ForwardShippingDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ForwardShippingDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
