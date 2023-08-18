// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    public partial class DevTestLabScheduleCreationParameter : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Core.Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Core.Optional.IsDefined(TaskType))
            {
                writer.WritePropertyName("taskType"u8);
                writer.WriteStringValue(TaskType);
            }
            if (Core.Optional.IsDefined(WeeklyRecurrence))
            {
                writer.WritePropertyName("weeklyRecurrence"u8);
                writer.WriteObjectValue(WeeklyRecurrence);
            }
            if (Core.Optional.IsDefined(DailyRecurrence))
            {
                writer.WritePropertyName("dailyRecurrence"u8);
                writer.WriteObjectValue(DailyRecurrence);
            }
            if (Core.Optional.IsDefined(HourlyRecurrence))
            {
                writer.WritePropertyName("hourlyRecurrence"u8);
                writer.WriteObjectValue(HourlyRecurrence);
            }
            if (Core.Optional.IsDefined(TimeZoneId))
            {
                writer.WritePropertyName("timeZoneId"u8);
                writer.WriteStringValue(TimeZoneId);
            }
            if (Core.Optional.IsDefined(NotificationSettings))
            {
                writer.WritePropertyName("notificationSettings"u8);
                writer.WriteObjectValue(NotificationSettings);
            }
            if (Core.Optional.IsDefined(TargetResourceId))
            {
                writer.WritePropertyName("targetResourceId"u8);
                writer.WriteStringValue(TargetResourceId);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static DevTestLabScheduleCreationParameter DeserializeDevTestLabScheduleCreationParameter(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> name = default;
            Core.Optional<AzureLocation> location = default;
            Core.Optional<IDictionary<string, string>> tags = default;
            Core.Optional<DevTestLabEnableStatus> status = default;
            Core.Optional<string> taskType = default;
            Core.Optional<DevTestLabWeekDetails> weeklyRecurrence = default;
            Core.Optional<DayDetails> dailyRecurrence = default;
            Core.Optional<HourDetails> hourlyRecurrence = default;
            Core.Optional<string> timeZoneId = default;
            Core.Optional<DevTestLabNotificationSettings> notificationSettings = default;
            Core.Optional<ResourceIdentifier> targetResourceId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
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
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = new DevTestLabEnableStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("taskType"u8))
                        {
                            taskType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("weeklyRecurrence"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            weeklyRecurrence = DevTestLabWeekDetails.DeserializeDevTestLabWeekDetails(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("dailyRecurrence"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dailyRecurrence = DayDetails.DeserializeDayDetails(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("hourlyRecurrence"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hourlyRecurrence = HourDetails.DeserializeHourDetails(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("timeZoneId"u8))
                        {
                            timeZoneId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("notificationSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            notificationSettings = DevTestLabNotificationSettings.DeserializeDevTestLabNotificationSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("targetResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            targetResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new DevTestLabScheduleCreationParameter(name.Value, Core.Optional.ToNullable(location), Core.Optional.ToDictionary(tags), Core.Optional.ToNullable(status), taskType.Value, weeklyRecurrence.Value, dailyRecurrence.Value, hourlyRecurrence.Value, timeZoneId.Value, notificationSettings.Value, targetResourceId.Value);
        }
    }
}
