// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.FrontDoor.Models
{
    public partial class LatencyMetric : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WriteEndObject();
        }

        internal static LatencyMetric DeserializeLatencyMetric(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> name = default;
            Core.Optional<DateTimeOffset> endDateTimeUtc = default;
            Core.Optional<float> aValue = default;
            Core.Optional<float> bValue = default;
            Core.Optional<float> delta = default;
            Core.Optional<float> deltaPercent = default;
            Core.Optional<float> acLower95CI = default;
            Core.Optional<float> ahUpper95CI = default;
            Core.Optional<float> bcLower95CI = default;
            Core.Optional<float> bUpper95CI = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endDateTimeUTC"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endDateTimeUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("aValue"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    aValue = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("bValue"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bValue = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("delta"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    delta = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("deltaPercent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deltaPercent = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("aCLower95CI"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    acLower95CI = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("aHUpper95CI"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ahUpper95CI = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("bCLower95CI"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bcLower95CI = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("bUpper95CI"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bUpper95CI = property.Value.GetSingle();
                    continue;
                }
            }
            return new LatencyMetric(name.Value, Core.Optional.ToNullable(endDateTimeUtc), Core.Optional.ToNullable(aValue), Core.Optional.ToNullable(bValue), Core.Optional.ToNullable(delta), Core.Optional.ToNullable(deltaPercent), Core.Optional.ToNullable(acLower95CI), Core.Optional.ToNullable(ahUpper95CI), Core.Optional.ToNullable(bcLower95CI), Core.Optional.ToNullable(bUpper95CI));
        }
    }
}
