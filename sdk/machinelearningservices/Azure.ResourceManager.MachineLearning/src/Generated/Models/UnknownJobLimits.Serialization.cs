// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    internal partial class UnknownJobLimits : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("jobLimitsType"u8);
            writer.WriteStringValue(JobLimitsType.ToString());
            if (Core.Optional.IsDefined(Timeout))
            {
                if (Timeout != null)
                {
                    writer.WritePropertyName("timeout"u8);
                    writer.WriteStringValue(Timeout.Value, "P");
                }
                else
                {
                    writer.WriteNull("timeout");
                }
            }
            writer.WriteEndObject();
        }

        internal static UnknownJobLimits DeserializeUnknownJobLimits(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            JobLimitsType jobLimitsType = "Unknown";
            Core.Optional<TimeSpan?> timeout = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("jobLimitsType"u8))
                {
                    jobLimitsType = new JobLimitsType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("timeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        timeout = null;
                        continue;
                    }
                    timeout = property.Value.GetTimeSpan("P");
                    continue;
                }
            }
            return new UnknownJobLimits(jobLimitsType, Core.Optional.ToNullable(timeout));
        }
    }
}
