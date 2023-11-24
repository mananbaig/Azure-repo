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
    [JsonConverter(typeof(EventGridMqttClientSessionConnectedEventDataConverter))]
    public partial class EventGridMqttClientSessionConnectedEventData : IUtf8JsonSerializable, IJsonModel<EventGridMqttClientSessionConnectedEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EventGridMqttClientSessionConnectedEventData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<EventGridMqttClientSessionConnectedEventData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventGridMqttClientSessionConnectedEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(EventGridMqttClientSessionConnectedEventData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ClientSessionName))
            {
                writer.WritePropertyName("clientSessionName"u8);
                writer.WriteStringValue(ClientSessionName);
            }
            if (Optional.IsDefined(SequenceNumber))
            {
                writer.WritePropertyName("sequenceNumber"u8);
                writer.WriteNumberValue(SequenceNumber.Value);
            }
            if (Optional.IsDefined(ClientAuthenticationName))
            {
                writer.WritePropertyName("clientAuthenticationName"u8);
                writer.WriteStringValue(ClientAuthenticationName);
            }
            if (Optional.IsDefined(ClientName))
            {
                writer.WritePropertyName("clientName"u8);
                writer.WriteStringValue(ClientName);
            }
            if (Optional.IsDefined(NamespaceName))
            {
                writer.WritePropertyName("namespaceName"u8);
                writer.WriteStringValue(NamespaceName);
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

        EventGridMqttClientSessionConnectedEventData IJsonModel<EventGridMqttClientSessionConnectedEventData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventGridMqttClientSessionConnectedEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(EventGridMqttClientSessionConnectedEventData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEventGridMqttClientSessionConnectedEventData(document.RootElement, options);
        }

        internal static EventGridMqttClientSessionConnectedEventData DeserializeEventGridMqttClientSessionConnectedEventData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> clientSessionName = default;
            Optional<long> sequenceNumber = default;
            Optional<string> clientAuthenticationName = default;
            Optional<string> clientName = default;
            Optional<string> namespaceName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clientSessionName"u8))
                {
                    clientSessionName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sequenceNumber"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sequenceNumber = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("clientAuthenticationName"u8))
                {
                    clientAuthenticationName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientName"u8))
                {
                    clientName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("namespaceName"u8))
                {
                    namespaceName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new EventGridMqttClientSessionConnectedEventData(clientAuthenticationName.Value, clientName.Value, namespaceName.Value, serializedAdditionalRawData, clientSessionName.Value, Optional.ToNullable(sequenceNumber));
        }

        BinaryData IPersistableModel<EventGridMqttClientSessionConnectedEventData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventGridMqttClientSessionConnectedEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(EventGridMqttClientSessionConnectedEventData)} does not support '{options.Format}' format.");
            }
        }

        EventGridMqttClientSessionConnectedEventData IPersistableModel<EventGridMqttClientSessionConnectedEventData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventGridMqttClientSessionConnectedEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEventGridMqttClientSessionConnectedEventData(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(EventGridMqttClientSessionConnectedEventData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<EventGridMqttClientSessionConnectedEventData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal partial class EventGridMqttClientSessionConnectedEventDataConverter : JsonConverter<EventGridMqttClientSessionConnectedEventData>
        {
            public override void Write(Utf8JsonWriter writer, EventGridMqttClientSessionConnectedEventData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override EventGridMqttClientSessionConnectedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeEventGridMqttClientSessionConnectedEventData(document.RootElement);
            }
        }
    }
}
