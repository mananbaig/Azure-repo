// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class EmailNotification : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SendToSubscriptionAdministrator))
            {
                writer.WritePropertyName("sendToSubscriptionAdministrator");
                writer.WriteBooleanValue(SendToSubscriptionAdministrator.Value);
            }
            if (Optional.IsDefined(SendToSubscriptionCoAdministrators))
            {
                writer.WritePropertyName("sendToSubscriptionCoAdministrators");
                writer.WriteBooleanValue(SendToSubscriptionCoAdministrators.Value);
            }
            if (Optional.IsCollectionDefined(CustomEmails))
            {
                writer.WritePropertyName("customEmails");
                writer.WriteStartArray();
                foreach (var item in CustomEmails)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static EmailNotification DeserializeEmailNotification(JsonElement element)
        {
            Optional<bool> sendToSubscriptionAdministrator = default;
            Optional<bool> sendToSubscriptionCoAdministrators = default;
            Optional<IList<string>> customEmails = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sendToSubscriptionAdministrator"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sendToSubscriptionAdministrator = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("sendToSubscriptionCoAdministrators"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sendToSubscriptionCoAdministrators = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("customEmails"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    customEmails = array;
                    continue;
                }
            }
            return new EmailNotification(Optional.ToNullable(sendToSubscriptionAdministrator), Optional.ToNullable(sendToSubscriptionCoAdministrators), Optional.ToList(customEmails));
        }
    }
}
