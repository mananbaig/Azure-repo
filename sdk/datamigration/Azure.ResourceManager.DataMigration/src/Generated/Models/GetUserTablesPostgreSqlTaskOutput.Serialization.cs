// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class GetUserTablesPostgreSqlTaskOutput
    {
        internal static GetUserTablesPostgreSqlTaskOutput DeserializeGetUserTablesPostgreSqlTaskOutput(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> databaseName = default;
            Core.Optional<IReadOnlyList<DatabaseTable>> tables = default;
            Core.Optional<IReadOnlyList<ReportableException>> validationErrors = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("databaseName"u8))
                {
                    databaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tables"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DatabaseTable> array = new List<DatabaseTable>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DatabaseTable.DeserializeDatabaseTable(item));
                    }
                    tables = array;
                    continue;
                }
                if (property.NameEquals("validationErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ReportableException> array = new List<ReportableException>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReportableException.DeserializeReportableException(item));
                    }
                    validationErrors = array;
                    continue;
                }
            }
            return new GetUserTablesPostgreSqlTaskOutput(databaseName.Value, Core.Optional.ToList(tables), Core.Optional.ToList(validationErrors));
        }
    }
}
