// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class MigrateSyncCompleteCommandInput : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("databaseName"u8);
            writer.WriteStringValue(DatabaseName);
            if (Core.Optional.IsDefined(CommitTimeStamp))
            {
                writer.WritePropertyName("commitTimeStamp"u8);
                writer.WriteStringValue(CommitTimeStamp.Value, "O");
            }
            writer.WriteEndObject();
        }

        internal static MigrateSyncCompleteCommandInput DeserializeMigrateSyncCompleteCommandInput(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string databaseName = default;
            Core.Optional<DateTimeOffset> commitTimeStamp = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("databaseName"u8))
                {
                    databaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("commitTimeStamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    commitTimeStamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new MigrateSyncCompleteCommandInput(databaseName, Core.Optional.ToNullable(commitTimeStamp));
        }
    }
}
