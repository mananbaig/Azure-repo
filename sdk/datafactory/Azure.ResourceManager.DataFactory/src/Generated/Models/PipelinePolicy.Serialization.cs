// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    internal partial class PipelinePolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ElapsedTimeMetric))
            {
                writer.WritePropertyName("elapsedTimeMetric");
                writer.WriteObjectValue(ElapsedTimeMetric);
            }
            writer.WriteEndObject();
        }

        internal static PipelinePolicy DeserializePipelinePolicy(JsonElement element)
        {
            Optional<PipelineElapsedTimeMetricPolicy> elapsedTimeMetric = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("elapsedTimeMetric"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    elapsedTimeMetric = PipelineElapsedTimeMetricPolicy.DeserializePipelineElapsedTimeMetricPolicy(property.Value);
                    continue;
                }
            }
            return new PipelinePolicy(elapsedTimeMetric.Value);
        }
    }
}
