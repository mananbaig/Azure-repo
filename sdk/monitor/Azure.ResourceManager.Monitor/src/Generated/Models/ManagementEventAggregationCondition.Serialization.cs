// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class ManagementEventAggregationCondition : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Operator))
            {
                writer.WritePropertyName("operator");
                writer.WriteStringValue(Operator.Value.ToSerialString());
            }
            if (Optional.IsDefined(Threshold))
            {
                writer.WritePropertyName("threshold");
                writer.WriteNumberValue(Threshold.Value);
            }
            if (Optional.IsDefined(WindowSize))
            {
                writer.WritePropertyName("windowSize");
                writer.WriteStringValue(WindowSize.Value, "P");
            }
            writer.WriteEndObject();
        }

        internal static ManagementEventAggregationCondition DeserializeManagementEventAggregationCondition(JsonElement element)
        {
            Optional<MonitorConditionOperator> @operator = default;
            Optional<double> threshold = default;
            Optional<TimeSpan> windowSize = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("operator"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    @operator = property.Value.GetString().ToMonitorConditionOperator();
                    continue;
                }
                if (property.NameEquals("threshold"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    threshold = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("windowSize"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    windowSize = property.Value.GetTimeSpan("P");
                    continue;
                }
            }
            return new ManagementEventAggregationCondition(Optional.ToNullable(@operator), Optional.ToNullable(threshold), Optional.ToNullable(windowSize));
        }
    }
}
