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
    public partial class EdgeOrderItemAddressDetails : IUtf8JsonSerializable, IJsonModel<EdgeOrderItemAddressDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EdgeOrderItemAddressDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<EdgeOrderItemAddressDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<EdgeOrderItemAddressDetails>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<EdgeOrderItemAddressDetails>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("forwardAddress"u8);
            writer.WriteObjectValue(ForwardAddress);
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ReturnAddress))
                {
                    writer.WritePropertyName("returnAddress"u8);
                    writer.WriteObjectValue(ReturnAddress);
                }
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

        EdgeOrderItemAddressDetails IJsonModel<EdgeOrderItemAddressDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(EdgeOrderItemAddressDetails)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEdgeOrderItemAddressDetails(document.RootElement, options);
        }

        internal static EdgeOrderItemAddressDetails DeserializeEdgeOrderItemAddressDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            EdgeOrderItemAddressProperties forwardAddress = default;
            Optional<EdgeOrderItemAddressProperties> returnAddress = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("forwardAddress"u8))
                {
                    forwardAddress = EdgeOrderItemAddressProperties.DeserializeEdgeOrderItemAddressProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("returnAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    returnAddress = EdgeOrderItemAddressProperties.DeserializeEdgeOrderItemAddressProperties(property.Value);
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new EdgeOrderItemAddressDetails(forwardAddress, returnAddress.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EdgeOrderItemAddressDetails>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(EdgeOrderItemAddressDetails)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        EdgeOrderItemAddressDetails IPersistableModel<EdgeOrderItemAddressDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(EdgeOrderItemAddressDetails)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeEdgeOrderItemAddressDetails(document.RootElement, options);
        }

        string IPersistableModel<EdgeOrderItemAddressDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
