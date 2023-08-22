// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Developer.LoadTesting.Models
{
    public partial class TimeSeriesElement
    {
        internal static TimeSeriesElement DeserializeTimeSeriesElement(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<MetricValue>> data = default;
            Optional<IReadOnlyList<DimensionValue>> dimensionValues = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("data"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MetricValue> array = new List<MetricValue>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MetricValue.DeserializeMetricValue(item));
                    }
                    data = array;
                    continue;
                }
                if (property.NameEquals("dimensionValues"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DimensionValue> array = new List<DimensionValue>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DimensionValue.DeserializeDimensionValue(item));
                    }
                    dimensionValues = array;
                    continue;
                }
            }
            return new TimeSeriesElement(Optional.ToList(data), Optional.ToList(dimensionValues));
        }
    }
}
