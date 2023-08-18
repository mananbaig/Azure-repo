// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    public partial class DevTestLabNotificationSettings : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Core.Optional.IsDefined(TimeInMinutes))
            {
                writer.WritePropertyName("timeInMinutes"u8);
                writer.WriteNumberValue(TimeInMinutes.Value);
            }
            if (Core.Optional.IsDefined(WebhookUri))
            {
                writer.WritePropertyName("webhookUrl"u8);
                writer.WriteStringValue(WebhookUri.AbsoluteUri);
            }
            if (Core.Optional.IsDefined(EmailRecipient))
            {
                writer.WritePropertyName("emailRecipient"u8);
                writer.WriteStringValue(EmailRecipient);
            }
            if (Core.Optional.IsDefined(NotificationLocale))
            {
                writer.WritePropertyName("notificationLocale"u8);
                writer.WriteStringValue(NotificationLocale);
            }
            writer.WriteEndObject();
        }

        internal static DevTestLabNotificationSettings DeserializeDevTestLabNotificationSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<DevTestLabEnableStatus> status = default;
            Core.Optional<int> timeInMinutes = default;
            Core.Optional<Uri> webhookUrl = default;
            Core.Optional<string> emailRecipient = default;
            Core.Optional<string> notificationLocale = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new DevTestLabEnableStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("timeInMinutes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeInMinutes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("webhookUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    webhookUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("emailRecipient"u8))
                {
                    emailRecipient = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("notificationLocale"u8))
                {
                    notificationLocale = property.Value.GetString();
                    continue;
                }
            }
            return new DevTestLabNotificationSettings(Core.Optional.ToNullable(status), Core.Optional.ToNullable(timeInMinutes), webhookUrl.Value, emailRecipient.Value, notificationLocale.Value);
        }
    }
}
