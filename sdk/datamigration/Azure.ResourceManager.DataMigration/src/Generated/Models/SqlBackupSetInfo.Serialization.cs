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
    public partial class SqlBackupSetInfo
    {
        internal static SqlBackupSetInfo DeserializeSqlBackupSetInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<Guid> backupSetId = default;
            Core.Optional<string> firstLSN = default;
            Core.Optional<string> lastLSN = default;
            Core.Optional<string> backupType = default;
            Core.Optional<IReadOnlyList<SqlBackupFileInfo>> listOfBackupFiles = default;
            Core.Optional<DateTimeOffset> backupStartDate = default;
            Core.Optional<DateTimeOffset> backupFinishDate = default;
            Core.Optional<bool> isBackupRestored = default;
            Core.Optional<bool> hasBackupChecksums = default;
            Core.Optional<int> familyCount = default;
            Core.Optional<IReadOnlyList<string>> ignoreReasons = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("backupSetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupSetId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("firstLSN"u8))
                {
                    firstLSN = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastLSN"u8))
                {
                    lastLSN = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("backupType"u8))
                {
                    backupType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("listOfBackupFiles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SqlBackupFileInfo> array = new List<SqlBackupFileInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SqlBackupFileInfo.DeserializeSqlBackupFileInfo(item));
                    }
                    listOfBackupFiles = array;
                    continue;
                }
                if (property.NameEquals("backupStartDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupStartDate = property.Value.GetDateTimeOffset("O");
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
                if (property.NameEquals("isBackupRestored"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isBackupRestored = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("hasBackupChecksums"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hasBackupChecksums = property.Value.GetBoolean();
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
                if (property.NameEquals("ignoreReasons"u8))
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
                    ignoreReasons = array;
                    continue;
                }
            }
            return new SqlBackupSetInfo(Core.Optional.ToNullable(backupSetId), firstLSN.Value, lastLSN.Value, backupType.Value, Core.Optional.ToList(listOfBackupFiles), Core.Optional.ToNullable(backupStartDate), Core.Optional.ToNullable(backupFinishDate), Core.Optional.ToNullable(isBackupRestored), Core.Optional.ToNullable(hasBackupChecksums), Core.Optional.ToNullable(familyCount), Core.Optional.ToList(ignoreReasons));
        }
    }
}
