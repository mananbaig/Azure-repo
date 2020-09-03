// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class SyncGroupSchemaTable : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Columns))
            {
                writer.WritePropertyName("columns");
                writer.WriteStartArray();
                foreach (var item in Columns)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(QuotedName))
            {
                writer.WritePropertyName("quotedName");
                writer.WriteStringValue(QuotedName);
            }
            writer.WriteEndObject();
        }

        internal static SyncGroupSchemaTable DeserializeSyncGroupSchemaTable(JsonElement element)
        {
            Optional<IList<SyncGroupSchemaTableColumn>> columns = default;
            Optional<string> quotedName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("columns"))
                {
                    List<SyncGroupSchemaTableColumn> array = new List<SyncGroupSchemaTableColumn>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SyncGroupSchemaTableColumn.DeserializeSyncGroupSchemaTableColumn(item));
                    }
                    columns = array;
                    continue;
                }
                if (property.NameEquals("quotedName"))
                {
                    quotedName = property.Value.GetString();
                    continue;
                }
            }
            return new SyncGroupSchemaTable(Optional.ToList(columns), quotedName.Value);
        }
    }
}
