// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class MigrateSqlServerSqlMIDatabaseInput : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("restoreDatabaseName"u8);
            writer.WriteStringValue(RestoreDatabaseName);
            if (Core.Optional.IsDefined(BackupFileShare))
            {
                writer.WritePropertyName("backupFileShare"u8);
                writer.WriteObjectValue(BackupFileShare);
            }
            if (Core.Optional.IsCollectionDefined(BackupFilePaths))
            {
                writer.WritePropertyName("backupFilePaths"u8);
                writer.WriteStartArray();
                foreach (var item in BackupFilePaths)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            writer.WriteEndObject();
        }

        internal static MigrateSqlServerSqlMIDatabaseInput DeserializeMigrateSqlServerSqlMIDatabaseInput(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string restoreDatabaseName = default;
            Core.Optional<FileShare> backupFileShare = default;
            Core.Optional<IList<string>> backupFilePaths = default;
            Core.Optional<string> id = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("restoreDatabaseName"u8))
                {
                    restoreDatabaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("backupFileShare"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupFileShare = FileShare.DeserializeFileShare(property.Value);
                    continue;
                }
                if (property.NameEquals("backupFilePaths"u8))
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
                    backupFilePaths = array;
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
            }
            return new MigrateSqlServerSqlMIDatabaseInput(name, restoreDatabaseName, backupFileShare.Value, Core.Optional.ToList(backupFilePaths), id.Value);
        }
    }
}
