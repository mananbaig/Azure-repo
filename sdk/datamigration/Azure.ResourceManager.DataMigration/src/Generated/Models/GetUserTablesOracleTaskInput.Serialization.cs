// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class GetUserTablesOracleTaskInput : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("connectionInfo"u8);
            writer.WriteObjectValue(ConnectionInfo);
            writer.WritePropertyName("selectedSchemas"u8);
            writer.WriteStartArray();
            foreach (var item in SelectedSchemas)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static GetUserTablesOracleTaskInput DeserializeGetUserTablesOracleTaskInput(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            OracleConnectionInfo connectionInfo = default;
            IList<string> selectedSchemas = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("connectionInfo"u8))
                {
                    connectionInfo = OracleConnectionInfo.DeserializeOracleConnectionInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("selectedSchemas"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    selectedSchemas = array;
                    continue;
                }
            }
            return new GetUserTablesOracleTaskInput(connectionInfo, selectedSchemas);
        }
    }
}
