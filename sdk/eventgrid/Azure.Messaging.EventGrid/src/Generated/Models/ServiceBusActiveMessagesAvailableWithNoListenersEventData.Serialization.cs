// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(ServiceBusActiveMessagesAvailableWithNoListenersEventDataConverter))]
    public partial class ServiceBusActiveMessagesAvailableWithNoListenersEventData : IUtf8JsonSerializable, IJsonModel<ServiceBusActiveMessagesAvailableWithNoListenersEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ServiceBusActiveMessagesAvailableWithNoListenersEventData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ServiceBusActiveMessagesAvailableWithNoListenersEventData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<ServiceBusActiveMessagesAvailableWithNoListenersEventData>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<ServiceBusActiveMessagesAvailableWithNoListenersEventData>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(NamespaceName))
            {
                writer.WritePropertyName("namespaceName"u8);
                writer.WriteStringValue(NamespaceName);
            }
            if (Optional.IsDefined(RequestUri))
            {
                writer.WritePropertyName("requestUri"u8);
                writer.WriteStringValue(RequestUri);
            }
            if (Optional.IsDefined(EntityType))
            {
                writer.WritePropertyName("entityType"u8);
                writer.WriteStringValue(EntityType);
            }
            if (Optional.IsDefined(QueueName))
            {
                writer.WritePropertyName("queueName"u8);
                writer.WriteStringValue(QueueName);
            }
            if (Optional.IsDefined(TopicName))
            {
                writer.WritePropertyName("topicName"u8);
                writer.WriteStringValue(TopicName);
            }
            if (Optional.IsDefined(SubscriptionName))
            {
                writer.WritePropertyName("subscriptionName"u8);
                writer.WriteStringValue(SubscriptionName);
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

        ServiceBusActiveMessagesAvailableWithNoListenersEventData IJsonModel<ServiceBusActiveMessagesAvailableWithNoListenersEventData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ServiceBusActiveMessagesAvailableWithNoListenersEventData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeServiceBusActiveMessagesAvailableWithNoListenersEventData(document.RootElement, options);
        }

        internal static ServiceBusActiveMessagesAvailableWithNoListenersEventData DeserializeServiceBusActiveMessagesAvailableWithNoListenersEventData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> namespaceName = default;
            Optional<string> requestUri = default;
            Optional<string> entityType = default;
            Optional<string> queueName = default;
            Optional<string> topicName = default;
            Optional<string> subscriptionName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("namespaceName"u8))
                {
                    namespaceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("requestUri"u8))
                {
                    requestUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("entityType"u8))
                {
                    entityType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("queueName"u8))
                {
                    queueName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("topicName"u8))
                {
                    topicName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subscriptionName"u8))
                {
                    subscriptionName = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ServiceBusActiveMessagesAvailableWithNoListenersEventData(namespaceName.Value, requestUri.Value, entityType.Value, queueName.Value, topicName.Value, subscriptionName.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ServiceBusActiveMessagesAvailableWithNoListenersEventData>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ServiceBusActiveMessagesAvailableWithNoListenersEventData)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ServiceBusActiveMessagesAvailableWithNoListenersEventData IPersistableModel<ServiceBusActiveMessagesAvailableWithNoListenersEventData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ServiceBusActiveMessagesAvailableWithNoListenersEventData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeServiceBusActiveMessagesAvailableWithNoListenersEventData(document.RootElement, options);
        }

        string IPersistableModel<ServiceBusActiveMessagesAvailableWithNoListenersEventData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal partial class ServiceBusActiveMessagesAvailableWithNoListenersEventDataConverter : JsonConverter<ServiceBusActiveMessagesAvailableWithNoListenersEventData>
        {
            public override void Write(Utf8JsonWriter writer, ServiceBusActiveMessagesAvailableWithNoListenersEventData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override ServiceBusActiveMessagesAvailableWithNoListenersEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeServiceBusActiveMessagesAvailableWithNoListenersEventData(document.RootElement);
            }
        }
    }
}
