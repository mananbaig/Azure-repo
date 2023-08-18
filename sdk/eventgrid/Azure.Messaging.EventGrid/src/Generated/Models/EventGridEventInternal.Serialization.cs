// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.Models
{
    [JsonConverter(typeof(EventGridEventInternalConverter))]
    internal partial class EventGridEventInternal : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            if (Core.Optional.IsDefined(Topic))
            {
                writer.WritePropertyName("topic"u8);
                writer.WriteStringValue(Topic);
            }
            writer.WritePropertyName("subject"u8);
            writer.WriteStringValue(Subject);
            writer.WritePropertyName("data"u8);
            Data.WriteTo(writer);
            writer.WritePropertyName("eventType"u8);
            writer.WriteStringValue(EventType);
            writer.WritePropertyName("eventTime"u8);
            writer.WriteStringValue(EventTime, "O");
            writer.WritePropertyName("dataVersion"u8);
            writer.WriteStringValue(DataVersion);
            writer.WriteEndObject();
        }

        internal static EventGridEventInternal DeserializeEventGridEventInternal(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            Core.Optional<string> topic = default;
            string subject = default;
            JsonElement data = default;
            string eventType = default;
            DateTimeOffset eventTime = default;
            Core.Optional<string> metadataVersion = default;
            string dataVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("topic"u8))
                {
                    topic = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subject"u8))
                {
                    subject = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("data"u8))
                {
                    data = property.Value.Clone();
                    continue;
                }
                if (property.NameEquals("eventType"u8))
                {
                    eventType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("eventTime"u8))
                {
                    eventTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("metadataVersion"u8))
                {
                    metadataVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataVersion"u8))
                {
                    dataVersion = property.Value.GetString();
                    continue;
                }
            }
            return new EventGridEventInternal(id, topic.Value, subject, data, eventType, eventTime, metadataVersion.Value, dataVersion);
        }

        internal partial class EventGridEventInternalConverter : JsonConverter<EventGridEventInternal>
        {
            public override void Write(Utf8JsonWriter writer, EventGridEventInternal model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override EventGridEventInternal Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeEventGridEventInternal(document.RootElement);
            }
        }
    }
}
