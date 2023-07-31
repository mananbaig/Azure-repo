// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Temp.Batch.Models
{
    public partial class PoolUsageMetrics
    {
        internal static PoolUsageMetrics DeserializePoolUsageMetrics(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string poolId = default;
            DateTimeOffset startTime = default;
            DateTimeOffset endTime = default;
            string vmSize = default;
            double totalCoreHours = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("poolId"u8))
                {
                    poolId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("vmSize"u8))
                {
                    vmSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("totalCoreHours"u8))
                {
                    totalCoreHours = property.Value.GetDouble();
                    continue;
                }
            }
            return new PoolUsageMetrics(poolId, startTime, endTime, vmSize, totalCoreHours);
        }
    }
}
