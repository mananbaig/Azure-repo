// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Insights.Models
{
    public partial class MetricValue
    {
        internal static MetricValue DeserializeMetricValue(JsonElement element)
        {
            DateTimeOffset timeStamp = default;
            Optional<double> average = default;
            Optional<double> minimum = default;
            Optional<double> maximum = default;
            Optional<double> total = default;
            Optional<double> count = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timeStamp"))
                {
                    timeStamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("average"))
                {
                    average = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("minimum"))
                {
                    minimum = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("maximum"))
                {
                    maximum = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("total"))
                {
                    total = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("count"))
                {
                    count = property.Value.GetDouble();
                    continue;
                }
            }
            return new MetricValue(timeStamp, Optional.ToNullable(average), Optional.ToNullable(minimum), Optional.ToNullable(maximum), Optional.ToNullable(total), Optional.ToNullable(count));
        }
    }
}
