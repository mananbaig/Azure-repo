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

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class ServiceBusQueueEventSubscriptionDestination : IUtf8JsonSerializable, IJsonModel<ServiceBusQueueEventSubscriptionDestination>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ServiceBusQueueEventSubscriptionDestination>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ServiceBusQueueEventSubscriptionDestination>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<ServiceBusQueueEventSubscriptionDestination>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<ServiceBusQueueEventSubscriptionDestination>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("endpointType"u8);
            writer.WriteStringValue(EndpointType.ToString());
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ResourceId))
            {
                writer.WritePropertyName("resourceId"u8);
                writer.WriteStringValue(ResourceId);
            }
            if (Optional.IsCollectionDefined(DeliveryAttributeMappings))
            {
                writer.WritePropertyName("deliveryAttributeMappings"u8);
                writer.WriteStartArray();
                foreach (var item in DeliveryAttributeMappings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
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

        ServiceBusQueueEventSubscriptionDestination IJsonModel<ServiceBusQueueEventSubscriptionDestination>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ServiceBusQueueEventSubscriptionDestination)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeServiceBusQueueEventSubscriptionDestination(document.RootElement, options);
        }

        internal static ServiceBusQueueEventSubscriptionDestination DeserializeServiceBusQueueEventSubscriptionDestination(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            EndpointType endpointType = default;
            Optional<ResourceIdentifier> resourceId = default;
            Optional<IList<DeliveryAttributeMapping>> deliveryAttributeMappings = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("endpointType"u8))
                {
                    endpointType = new EndpointType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("resourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("deliveryAttributeMappings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DeliveryAttributeMapping> array = new List<DeliveryAttributeMapping>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DeliveryAttributeMapping.DeserializeDeliveryAttributeMapping(item));
                            }
                            deliveryAttributeMappings = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ServiceBusQueueEventSubscriptionDestination(endpointType, serializedAdditionalRawData, resourceId.Value, Optional.ToList(deliveryAttributeMappings));
        }

        BinaryData IPersistableModel<ServiceBusQueueEventSubscriptionDestination>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ServiceBusQueueEventSubscriptionDestination)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ServiceBusQueueEventSubscriptionDestination IPersistableModel<ServiceBusQueueEventSubscriptionDestination>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ServiceBusQueueEventSubscriptionDestination)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeServiceBusQueueEventSubscriptionDestination(document.RootElement, options);
        }

        string IPersistableModel<ServiceBusQueueEventSubscriptionDestination>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
