// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    [PersistableModelProxy(typeof(UnknownDeliveryAttributeMapping))]
    public partial class DeliveryAttributeMapping : IUtf8JsonSerializable, IJsonModel<DeliveryAttributeMapping>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DeliveryAttributeMapping>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DeliveryAttributeMapping>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<DeliveryAttributeMapping>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<DeliveryAttributeMapping>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(MappingType.ToString());
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

        DeliveryAttributeMapping IJsonModel<DeliveryAttributeMapping>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DeliveryAttributeMapping)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDeliveryAttributeMapping(document.RootElement, options);
        }

        internal static DeliveryAttributeMapping DeserializeDeliveryAttributeMapping(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Dynamic": return DynamicDeliveryAttributeMapping.DeserializeDynamicDeliveryAttributeMapping(element);
                    case "Static": return StaticDeliveryAttributeMapping.DeserializeStaticDeliveryAttributeMapping(element);
                }
            }
            return UnknownDeliveryAttributeMapping.DeserializeUnknownDeliveryAttributeMapping(element);
        }

        BinaryData IPersistableModel<DeliveryAttributeMapping>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DeliveryAttributeMapping)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        DeliveryAttributeMapping IPersistableModel<DeliveryAttributeMapping>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DeliveryAttributeMapping)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeDeliveryAttributeMapping(document.RootElement, options);
        }

        string IPersistableModel<DeliveryAttributeMapping>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
