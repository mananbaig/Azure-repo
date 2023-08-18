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
    public partial class MigratePostgreSqlAzureDBForPostgreSqlSyncDatabaseInput : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Core.Optional.IsDefined(TargetDatabaseName))
            {
                writer.WritePropertyName("targetDatabaseName"u8);
                writer.WriteStringValue(TargetDatabaseName);
            }
            if (Core.Optional.IsCollectionDefined(MigrationSetting))
            {
                writer.WritePropertyName("migrationSetting"u8);
                writer.WriteStartObject();
                foreach (var item in MigrationSetting)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
                }
                writer.WriteEndObject();
            }
            if (Core.Optional.IsCollectionDefined(SourceSetting))
            {
                writer.WritePropertyName("sourceSetting"u8);
                writer.WriteStartObject();
                foreach (var item in SourceSetting)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Core.Optional.IsCollectionDefined(TargetSetting))
            {
                writer.WritePropertyName("targetSetting"u8);
                writer.WriteStartObject();
                foreach (var item in TargetSetting)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Core.Optional.IsCollectionDefined(SelectedTables))
            {
                writer.WritePropertyName("selectedTables"u8);
                writer.WriteStartArray();
                foreach (var item in SelectedTables)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static MigratePostgreSqlAzureDBForPostgreSqlSyncDatabaseInput DeserializeMigratePostgreSqlAzureDBForPostgreSqlSyncDatabaseInput(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> name = default;
            Core.Optional<string> id = default;
            Core.Optional<string> targetDatabaseName = default;
            Core.Optional<IDictionary<string, BinaryData>> migrationSetting = default;
            Core.Optional<IDictionary<string, string>> sourceSetting = default;
            Core.Optional<IDictionary<string, string>> targetSetting = default;
            Core.Optional<IList<MigratePostgreSqlAzureDBForPostgreSqlSyncDatabaseTableInput>> selectedTables = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetDatabaseName"u8))
                {
                    targetDatabaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("migrationSetting"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, BinaryData.FromString(property0.Value.GetRawText()));
                        }
                    }
                    migrationSetting = dictionary;
                    continue;
                }
                if (property.NameEquals("sourceSetting"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    sourceSetting = dictionary;
                    continue;
                }
                if (property.NameEquals("targetSetting"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    targetSetting = dictionary;
                    continue;
                }
                if (property.NameEquals("selectedTables"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MigratePostgreSqlAzureDBForPostgreSqlSyncDatabaseTableInput> array = new List<MigratePostgreSqlAzureDBForPostgreSqlSyncDatabaseTableInput>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MigratePostgreSqlAzureDBForPostgreSqlSyncDatabaseTableInput.DeserializeMigratePostgreSqlAzureDBForPostgreSqlSyncDatabaseTableInput(item));
                    }
                    selectedTables = array;
                    continue;
                }
            }
            return new MigratePostgreSqlAzureDBForPostgreSqlSyncDatabaseInput(name.Value, id.Value, targetDatabaseName.Value, Core.Optional.ToDictionary(migrationSetting), Core.Optional.ToDictionary(sourceSetting), Core.Optional.ToDictionary(targetSetting), Core.Optional.ToList(selectedTables));
        }
    }
}
