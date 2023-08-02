// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    public partial class PostgreSqlMigrationAdminCredentials : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("sourceServerPassword"u8);
            writer.WriteStringValue(SourceServerPassword);
            writer.WritePropertyName("targetServerPassword"u8);
            writer.WriteStringValue(TargetServerPassword);
            writer.WriteEndObject();
        }

        internal static PostgreSqlMigrationAdminCredentials DeserializePostgreSqlMigrationAdminCredentials(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string sourceServerPassword = default;
            string targetServerPassword = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceServerPassword"u8))
                {
                    sourceServerPassword = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetServerPassword"u8))
                {
                    targetServerPassword = property.Value.GetString();
                    continue;
                }
            }
            return new PostgreSqlMigrationAdminCredentials(sourceServerPassword, targetServerPassword);
        }
    }
}
