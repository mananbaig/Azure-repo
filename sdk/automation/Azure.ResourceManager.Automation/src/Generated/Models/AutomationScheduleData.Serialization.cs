// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Automation.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Automation
{
    public partial class AutomationScheduleData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (Optional.IsDefined(ExpireOn))
            {
                if (ExpireOn != null)
                {
                    writer.WritePropertyName("expiryTime"u8);
                    writer.WriteStringValue(ExpireOn.Value, "O");
                }
                else
                {
                    writer.WriteNull("expiryTime");
                }
            }
            if (Optional.IsDefined(ExpireInMinutes))
            {
                writer.WritePropertyName("expiryTimeOffsetMinutes"u8);
                writer.WriteNumberValue(ExpireInMinutes.Value);
            }
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("isEnabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsDefined(NextRunOn))
            {
                if (NextRunOn != null)
                {
                    writer.WritePropertyName("nextRun"u8);
                    writer.WriteStringValue(NextRunOn.Value, "O");
                }
                else
                {
                    writer.WriteNull("nextRun");
                }
            }
            if (Optional.IsDefined(NextRunInMinutes))
            {
                writer.WritePropertyName("nextRunOffsetMinutes"u8);
                writer.WriteNumberValue(NextRunInMinutes.Value);
            }
            if (Optional.IsDefined(Interval))
            {
                writer.WritePropertyName("interval"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Interval);
#else
                using (JsonDocument document = JsonDocument.Parse(Interval))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(Frequency))
            {
                writer.WritePropertyName("frequency"u8);
                writer.WriteStringValue(Frequency.Value.ToString());
            }
            if (Optional.IsDefined(TimeZone))
            {
                writer.WritePropertyName("timeZone"u8);
                writer.WriteStringValue(TimeZone);
            }
            if (Optional.IsDefined(AdvancedSchedule))
            {
                writer.WritePropertyName("advancedSchedule"u8);
                writer.WriteObjectValue(AdvancedSchedule);
            }
            if (Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("creationTime"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (Optional.IsDefined(LastModifiedOn))
            {
                writer.WritePropertyName("lastModifiedTime"u8);
                writer.WriteStringValue(LastModifiedOn.Value, "O");
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static AutomationScheduleData DeserializeAutomationScheduleData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<double> startTimeOffsetMinutes = default;
            Optional<DateTimeOffset?> expiryTime = default;
            Optional<double> expiryTimeOffsetMinutes = default;
            Optional<bool> isEnabled = default;
            Optional<DateTimeOffset?> nextRun = default;
            Optional<double> nextRunOffsetMinutes = default;
            Optional<BinaryData> interval = default;
            Optional<AutomationScheduleFrequency> frequency = default;
            Optional<string> timeZone = default;
            Optional<AutomationAdvancedSchedule> advancedSchedule = default;
            Optional<DateTimeOffset> creationTime = default;
            Optional<DateTimeOffset> lastModifiedTime = default;
            Optional<string> description = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
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
                        if (property0.NameEquals("startTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            startTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("startTimeOffsetMinutes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            startTimeOffsetMinutes = property0.Value.GetDouble();
                            continue;
                        }
                        if (property0.NameEquals("expiryTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                expiryTime = null;
                                continue;
                            }
                            expiryTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("expiryTimeOffsetMinutes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            expiryTimeOffsetMinutes = property0.Value.GetDouble();
                            continue;
                        }
                        if (property0.NameEquals("isEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("nextRun"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                nextRun = null;
                                continue;
                            }
                            nextRun = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("nextRunOffsetMinutes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            nextRunOffsetMinutes = property0.Value.GetDouble();
                            continue;
                        }
                        if (property0.NameEquals("interval"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            interval = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("frequency"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            frequency = new AutomationScheduleFrequency(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("timeZone"u8))
                        {
                            timeZone = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("advancedSchedule"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            advancedSchedule = AutomationAdvancedSchedule.DeserializeAutomationAdvancedSchedule(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("creationTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            creationTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastModifiedTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastModifiedTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new AutomationScheduleData(id, name, type, systemData.Value, Optional.ToNullable(startTime), Optional.ToNullable(startTimeOffsetMinutes), Optional.ToNullable(expiryTime), Optional.ToNullable(expiryTimeOffsetMinutes), Optional.ToNullable(isEnabled), Optional.ToNullable(nextRun), Optional.ToNullable(nextRunOffsetMinutes), interval.Value, Optional.ToNullable(frequency), timeZone.Value, advancedSchedule.Value, Optional.ToNullable(creationTime), Optional.ToNullable(lastModifiedTime), description.Value);
        }
    }
}
