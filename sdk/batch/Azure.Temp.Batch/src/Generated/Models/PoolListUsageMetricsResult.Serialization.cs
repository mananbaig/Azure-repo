// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Temp.Batch.Models
{
    internal partial class PoolListUsageMetricsResult
    {
        internal static PoolListUsageMetricsResult DeserializePoolListUsageMetricsResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<PoolUsageMetrics>> value = default;
            Optional<string> odataNextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PoolUsageMetrics> array = new List<PoolUsageMetrics>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PoolUsageMetrics.DeserializePoolUsageMetrics(item));
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
            return new PoolListUsageMetricsResult(Optional.ToList(value), odataNextLink.Value);
        }
    }
}
