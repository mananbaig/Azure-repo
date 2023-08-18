// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class MigrateSqlServerSqlMISyncTaskOutputError
    {
        internal static MigrateSqlServerSqlMISyncTaskOutputError DeserializeMigrateSqlServerSqlMISyncTaskOutputError(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<ReportableException> error = default;
            Core.Optional<string> id = default;
            string resultType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = ReportableException.DeserializeReportableException(property.Value);
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultType"u8))
                {
                    resultType = property.Value.GetString();
                    continue;
                }
            }
            return new MigrateSqlServerSqlMISyncTaskOutputError(id.Value, resultType, error.Value);
        }
    }
}
