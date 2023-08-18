// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    public partial class EdgeOrderItemPatch : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
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
            if (Core.Optional.IsDefined(ForwardAddress))
            {
                writer.WritePropertyName("forwardAddress"u8);
                writer.WriteObjectValue(ForwardAddress);
            }
            if (Core.Optional.IsDefined(Preferences))
            {
                writer.WritePropertyName("preferences"u8);
                writer.WriteObjectValue(Preferences);
            }
            if (Core.Optional.IsCollectionDefined(NotificationEmailList))
            {
                writer.WritePropertyName("notificationEmailList"u8);
                writer.WriteStartArray();
                foreach (var item in NotificationEmailList)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
