// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.CosmosDB;

namespace Azure.ResourceManager.CosmosDB.Models
{
    internal partial class CosmosDBSqlRoleAssignmentList
    {
        internal static CosmosDBSqlRoleAssignmentList DeserializeCosmosDBSqlRoleAssignmentList(JsonElement element)
        {
            Optional<IReadOnlyList<CosmosDBSqlRoleAssignmentData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<CosmosDBSqlRoleAssignmentData> array = new List<CosmosDBSqlRoleAssignmentData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CosmosDBSqlRoleAssignmentData.DeserializeCosmosDBSqlRoleAssignmentData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new CosmosDBSqlRoleAssignmentList(Optional.ToList(value));
        }
    }
}
