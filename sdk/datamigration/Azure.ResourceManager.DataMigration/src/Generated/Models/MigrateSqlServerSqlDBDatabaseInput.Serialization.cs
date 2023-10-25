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
    public partial class MigrateSqlServerSqlDBDatabaseInput : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(TargetDatabaseName))
            {
                writer.WritePropertyName("targetDatabaseName"u8);
                writer.WriteStringValue(TargetDatabaseName);
            }
            if (Optional.IsDefined(MakeSourceDBReadOnly))
            {
                writer.WritePropertyName("makeSourceDbReadOnly"u8);
                writer.WriteBooleanValue(MakeSourceDBReadOnly.Value);
            }
            if (Optional.IsCollectionDefined(TableMap))
            {
                writer.WritePropertyName("tableMap"u8);
                writer.WriteStartObject();
                foreach (var item in TableMap)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(SchemaSetting))
            {
                writer.WritePropertyName("schemaSetting"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(SchemaSetting);
#else
                using (JsonDocument document = JsonDocument.Parse(SchemaSetting))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            writer.WriteEndObject();
        }

        internal static MigrateSqlServerSqlDBDatabaseInput DeserializeMigrateSqlServerSqlDBDatabaseInput(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> targetDatabaseName = default;
            Optional<bool> makeSourceDBReadOnly = default;
            Optional<IDictionary<string, string>> tableMap = default;
            Optional<BinaryData> schemaSetting = default;
            Optional<string> id = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetDatabaseName"u8))
                {
                    targetDatabaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("makeSourceDbReadOnly"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    makeSourceDBReadOnly = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("tableMap"u8))
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
                    tableMap = dictionary;
                    continue;
                }
                if (property.NameEquals("schemaSetting"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    schemaSetting = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
            }
            return new MigrateSqlServerSqlDBDatabaseInput(name.Value, targetDatabaseName.Value, Optional.ToNullable(makeSourceDBReadOnly), Optional.ToDictionary(tableMap), schemaSetting.Value, id.Value);
        }
    }
}
