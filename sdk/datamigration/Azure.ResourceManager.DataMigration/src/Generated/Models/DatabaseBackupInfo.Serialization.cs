// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class DatabaseBackupInfo
    {
        internal static DatabaseBackupInfo DeserializeDatabaseBackupInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> databaseName = default;
            Core.Optional<BackupType> backupType = default;
            Core.Optional<IReadOnlyList<string>> backupFiles = default;
            Core.Optional<int> position = default;
            Core.Optional<bool> isDamaged = default;
            Core.Optional<bool> isCompressed = default;
            Core.Optional<int> familyCount = default;
            Core.Optional<DateTimeOffset> backupFinishDate = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("databaseName"u8))
                {
                    databaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("backupType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupType = new BackupType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("backupFiles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    backupFiles = array;
                    continue;
                }
                if (property.NameEquals("position"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    position = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("isDamaged"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isDamaged = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isCompressed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isCompressed = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("familyCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    familyCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("backupFinishDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupFinishDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new DatabaseBackupInfo(databaseName.Value, Core.Optional.ToNullable(backupType), Core.Optional.ToList(backupFiles), Core.Optional.ToNullable(position), Core.Optional.ToNullable(isDamaged), Core.Optional.ToNullable(isCompressed), Core.Optional.ToNullable(familyCount), Core.Optional.ToNullable(backupFinishDate));
        }
    }
}
