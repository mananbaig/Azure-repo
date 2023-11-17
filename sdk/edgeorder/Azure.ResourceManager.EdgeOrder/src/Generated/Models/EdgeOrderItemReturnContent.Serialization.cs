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
    public partial class EdgeOrderItemReturnContent : IUtf8JsonSerializable, IJsonModel<EdgeOrderItemReturnContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EdgeOrderItemReturnContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<EdgeOrderItemReturnContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<EdgeOrderItemReturnContent>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<EdgeOrderItemReturnContent>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ReturnAddress))
            {
                writer.WritePropertyName("returnAddress"u8);
                writer.WriteObjectValue(ReturnAddress);
            }
            writer.WritePropertyName("returnReason"u8);
            writer.WriteStringValue(ReturnReason);
            if (Optional.IsDefined(ServiceTag))
            {
                writer.WritePropertyName("serviceTag"u8);
                writer.WriteStringValue(ServiceTag);
            }
            if (Optional.IsDefined(IsShippingBoxRequired))
            {
                writer.WritePropertyName("shippingBoxRequired"u8);
                writer.WriteBooleanValue(IsShippingBoxRequired.Value);
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

        EdgeOrderItemReturnContent IJsonModel<EdgeOrderItemReturnContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(EdgeOrderItemReturnContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEdgeOrderItemReturnContent(document.RootElement, options);
        }

        internal static EdgeOrderItemReturnContent DeserializeEdgeOrderItemReturnContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<EdgeOrderItemAddressProperties> returnAddress = default;
            string returnReason = default;
            Optional<string> serviceTag = default;
            Optional<bool> shippingBoxRequired = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("returnAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    returnAddress = EdgeOrderItemAddressProperties.DeserializeEdgeOrderItemAddressProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("returnReason"u8))
                {
                    returnReason = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serviceTag"u8))
                {
                    serviceTag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("shippingBoxRequired"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    shippingBoxRequired = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new EdgeOrderItemReturnContent(returnAddress.Value, returnReason, serviceTag.Value, Optional.ToNullable(shippingBoxRequired), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EdgeOrderItemReturnContent>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(EdgeOrderItemReturnContent)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        EdgeOrderItemReturnContent IPersistableModel<EdgeOrderItemReturnContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(EdgeOrderItemReturnContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeEdgeOrderItemReturnContent(document.RootElement, options);
        }

        string IPersistableModel<EdgeOrderItemReturnContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
