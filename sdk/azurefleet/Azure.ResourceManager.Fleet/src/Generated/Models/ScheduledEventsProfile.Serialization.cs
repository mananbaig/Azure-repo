// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Fleet.Models
{
    public partial class ScheduledEventsProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(TerminateNotificationProfile))
            {
                writer.WritePropertyName("terminateNotificationProfile"u8);
                writer.WriteObjectValue(TerminateNotificationProfile);
            }
            if (Optional.IsDefined(OSImageNotificationProfile))
            {
                writer.WritePropertyName("osImageNotificationProfile"u8);
                writer.WriteObjectValue(OSImageNotificationProfile);
            }
            writer.WriteEndObject();
        }

        internal static ScheduledEventsProfile DeserializeScheduledEventsProfile(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<TerminateNotificationProfile> terminateNotificationProfile = default;
            Optional<OSImageNotificationProfile> osImageNotificationProfile = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("terminateNotificationProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    terminateNotificationProfile = TerminateNotificationProfile.DeserializeTerminateNotificationProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("osImageNotificationProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    osImageNotificationProfile = OSImageNotificationProfile.DeserializeOSImageNotificationProfile(property.Value);
                    continue;
                }
            }
            return new ScheduledEventsProfile(terminateNotificationProfile.Value, osImageNotificationProfile.Value);
        }
    }
}
