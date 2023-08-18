// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(ServiceBusActiveMessagesAvailableWithNoListenersEventDataConverter))]
    public partial class ServiceBusActiveMessagesAvailableWithNoListenersEventData
    {
        internal static ServiceBusActiveMessagesAvailableWithNoListenersEventData DeserializeServiceBusActiveMessagesAvailableWithNoListenersEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> namespaceName = default;
            Core.Optional<string> requestUri = default;
            Core.Optional<string> entityType = default;
            Core.Optional<string> queueName = default;
            Core.Optional<string> topicName = default;
            Core.Optional<string> subscriptionName = default;
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
            }
            return new ServiceBusActiveMessagesAvailableWithNoListenersEventData(namespaceName.Value, requestUri.Value, entityType.Value, queueName.Value, topicName.Value, subscriptionName.Value);
        }

        internal partial class ServiceBusActiveMessagesAvailableWithNoListenersEventDataConverter : JsonConverter<ServiceBusActiveMessagesAvailableWithNoListenersEventData>
        {
            public override void Write(Utf8JsonWriter writer, ServiceBusActiveMessagesAvailableWithNoListenersEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override ServiceBusActiveMessagesAvailableWithNoListenersEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeServiceBusActiveMessagesAvailableWithNoListenersEventData(document.RootElement);
            }
        }
    }
}
