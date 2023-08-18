// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningRecurrenceSchedule : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("hours"u8);
            writer.WriteStartArray();
            foreach (var item in Hours)
            {
                writer.WriteNumberValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("minutes"u8);
            writer.WriteStartArray();
            foreach (var item in Minutes)
            {
                writer.WriteNumberValue(item);
            }
            writer.WriteEndArray();
            if (Core.Optional.IsCollectionDefined(MonthDays))
            {
                if (MonthDays != null)
                {
                    writer.WritePropertyName("monthDays"u8);
                    writer.WriteStartArray();
                    foreach (var item in MonthDays)
                    {
                        writer.WriteNumberValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("monthDays");
                }
            }
            if (Core.Optional.IsCollectionDefined(WeekDays))
            {
                if (WeekDays != null)
                {
                    writer.WritePropertyName("weekDays"u8);
                    writer.WriteStartArray();
                    foreach (var item in WeekDays)
                    {
                        writer.WriteStringValue(item.ToString());
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("weekDays");
                }
            }
            writer.WriteEndObject();
        }

        internal static MachineLearningRecurrenceSchedule DeserializeMachineLearningRecurrenceSchedule(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<int> hours = default;
            IList<int> minutes = default;
            Core.Optional<IList<int>> monthDays = default;
            Core.Optional<IList<MachineLearningDayOfWeek>> weekDays = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hours"u8))
                {
                    List<int> array = new List<int>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetInt32());
                    }
                    hours = array;
                    continue;
                }
                if (property.NameEquals("minutes"u8))
                {
                    List<int> array = new List<int>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetInt32());
                    }
                    minutes = array;
                    continue;
                }
                if (property.NameEquals("monthDays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        monthDays = null;
                        continue;
                    }
                    List<int> array = new List<int>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetInt32());
                    }
                    monthDays = array;
                    continue;
                }
                if (property.NameEquals("weekDays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        weekDays = null;
                        continue;
                    }
                    List<MachineLearningDayOfWeek> array = new List<MachineLearningDayOfWeek>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new MachineLearningDayOfWeek(item.GetString()));
                    }
                    weekDays = array;
                    continue;
                }
            }
            return new MachineLearningRecurrenceSchedule(hours, minutes, Core.Optional.ToList(monthDays), Core.Optional.ToList(weekDays));
        }
    }
}
