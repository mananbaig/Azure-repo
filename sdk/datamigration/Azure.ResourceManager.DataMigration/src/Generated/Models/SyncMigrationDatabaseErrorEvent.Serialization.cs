// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class SyncMigrationDatabaseErrorEvent
    {
        internal static SyncMigrationDatabaseErrorEvent DeserializeSyncMigrationDatabaseErrorEvent(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> timestampString = default;
            Core.Optional<string> eventTypeString = default;
            Core.Optional<string> eventText = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timestampString"u8))
                {
                    timestampString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("eventTypeString"u8))
                {
                    eventTypeString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("eventText"u8))
                {
                    eventText = property.Value.GetString();
                    continue;
                }
            }
            return new SyncMigrationDatabaseErrorEvent(timestampString.Value, eventTypeString.Value, eventText.Value);
        }
    }
}
