// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.AI.MetricsAdvisor.Models;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor
{
    public partial class MetricChangePointFeedback : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("startTime");
            writer.WriteStringValue(StartTime, "O");
            writer.WritePropertyName("endTime");
            writer.WriteStringValue(EndTime, "O");
            writer.WritePropertyName("value");
            writer.WriteObjectValue(ValueInternal);
            writer.WritePropertyName("feedbackType");
            writer.WriteStringValue(FeedbackKind.ToString());
            writer.WritePropertyName("metricId");
            writer.WriteStringValue(MetricId);
            writer.WritePropertyName("dimensionFilter");
            writer.WriteObjectValue(DimensionFilter);
            writer.WriteEndObject();
        }

        internal static MetricChangePointFeedback DeserializeMetricChangePointFeedback(JsonElement element)
        {
            DateTimeOffset startTime = default;
            DateTimeOffset endTime = default;
            ChangePointFeedbackValue value = default;
            MetricFeedbackKind feedbackType = default;
            Optional<string> feedbackId = default;
            Optional<DateTimeOffset> createdTime = default;
            Optional<string> userPrincipal = default;
            string metricId = default;
            FeedbackFilter dimensionFilter = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("startTime"))
                {
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"))
                {
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    value = ChangePointFeedbackValue.DeserializeChangePointFeedbackValue(property.Value);
                    continue;
                }
                if (property.NameEquals("feedbackType"))
                {
                    feedbackType = new MetricFeedbackKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("feedbackId"))
                {
                    feedbackId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    createdTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("userPrincipal"))
                {
                    userPrincipal = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metricId"))
                {
                    metricId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dimensionFilter"))
                {
                    dimensionFilter = FeedbackFilter.DeserializeFeedbackFilter(property.Value);
                    continue;
                }
            }
            return new MetricChangePointFeedback(feedbackType, feedbackId.Value, Optional.ToNullable(createdTime), userPrincipal.Value, metricId, dimensionFilter, startTime, endTime, value);
        }
    }
}
