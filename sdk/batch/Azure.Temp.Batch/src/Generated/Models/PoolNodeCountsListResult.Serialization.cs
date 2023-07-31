// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Temp.Batch.Models
{
    internal partial class PoolNodeCountsListResult
    {
        internal static PoolNodeCountsListResult DeserializePoolNodeCountsListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<PoolNodeCounts>> value = default;
            Optional<string> odataNextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PoolNodeCounts> array = new List<PoolNodeCounts>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PoolNodeCounts.DeserializePoolNodeCounts(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("odata.nextLink"u8))
                {
                    odataNextLink = property.Value.GetString();
                    continue;
                }
            }
            return new PoolNodeCountsListResult(Optional.ToList(value), odataNextLink.Value);
        }
    }
}
