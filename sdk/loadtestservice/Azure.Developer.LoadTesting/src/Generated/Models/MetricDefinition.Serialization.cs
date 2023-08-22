// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Developer.LoadTesting.Models
{
    public partial class MetricDefinition
    {
        internal static MetricDefinition DeserializeMetricDefinition(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<NameAndDesc>> dimensions = default;
            Optional<string> description = default;
            Optional<string> name = default;
            Optional<string> @namespace = default;
            Optional<AggregationType> primaryAggregationType = default;
            Optional<IReadOnlyList<string>> supportedAggregationTypes = default;
            Optional<MetricUnit> unit = default;
            Optional<IReadOnlyList<MetricAvailability>> metricAvailabilities = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dimensions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NameAndDesc> array = new List<NameAndDesc>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NameAndDesc.DeserializeNameAndDesc(item));
                    }
                    dimensions = array;
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("namespace"u8))
                {
                    @namespace = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("primaryAggregationType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryAggregationType = new AggregationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("supportedAggregationTypes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    supportedAggregationTypes = array;
                    continue;
                }
                if (property.NameEquals("unit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    unit = new MetricUnit(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("metricAvailabilities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MetricAvailability> array = new List<MetricAvailability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MetricAvailability.DeserializeMetricAvailability(item));
                    }
                    metricAvailabilities = array;
                    continue;
                }
            }
            return new MetricDefinition(Optional.ToList(dimensions), description.Value, name.Value, @namespace.Value, Optional.ToNullable(primaryAggregationType), Optional.ToList(supportedAggregationTypes), Optional.ToNullable(unit), Optional.ToList(metricAvailabilities));
        }
    }
}
