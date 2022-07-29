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
    internal partial class CosmosDBServiceListResult
    {
        internal static CosmosDBServiceListResult DeserializeCosmosDBServiceListResult(JsonElement element)
        {
            Optional<IReadOnlyList<CosmosDBServiceResourceData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<CosmosDBServiceResourceData> array = new List<CosmosDBServiceResourceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CosmosDBServiceResourceData.DeserializeCosmosDBServiceResourceData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new CosmosDBServiceListResult(Optional.ToList(value));
        }
    }
}
