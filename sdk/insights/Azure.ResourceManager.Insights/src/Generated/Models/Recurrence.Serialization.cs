// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Insights.Models
{
    public partial class Recurrence : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("frequency");
            writer.WriteStringValue(Frequency.ToSerialString());
            writer.WritePropertyName("schedule");
            writer.WriteObjectValue(Schedule);
            writer.WriteEndObject();
        }

        internal static Recurrence DeserializeRecurrence(JsonElement element)
        {
            RecurrenceFrequency frequency = default;
            RecurrentSchedule schedule = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("frequency"))
                {
                    frequency = property.Value.GetString().ToRecurrenceFrequency();
                    continue;
                }
                if (property.NameEquals("schedule"))
                {
                    schedule = RecurrentSchedule.DeserializeRecurrentSchedule(property.Value);
                    continue;
                }
            }
            return new Recurrence(frequency, schedule);
        }
    }
}
