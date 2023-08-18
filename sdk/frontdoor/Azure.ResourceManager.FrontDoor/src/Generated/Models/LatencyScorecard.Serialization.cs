// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.FrontDoor.Models
{
    public partial class LatencyScorecard : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Core.Optional.IsCollectionDefined(LatencyMetrics))
            {
                writer.WritePropertyName("latencyMetrics"u8);
                writer.WriteStartArray();
                foreach (var item in LatencyMetrics)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static LatencyScorecard DeserializeLatencyScorecard(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Core.Optional<SystemData> systemData = default;
            Core.Optional<string> id0 = default;
            Core.Optional<string> name0 = default;
            Core.Optional<string> description = default;
            Core.Optional<Uri> endpointA = default;
            Core.Optional<Uri> endpointB = default;
            Core.Optional<DateTimeOffset> startDateTimeUtc = default;
            Core.Optional<DateTimeOffset> endDateTimeUtc = default;
            Core.Optional<string> country = default;
            Core.Optional<IList<LatencyMetric>> latencyMetrics = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("id"u8))
                        {
                            id0 = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("name"u8))
                        {
                            name0 = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("endpointA"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            endpointA = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("endpointB"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            endpointB = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("startDateTimeUTC"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            startDateTimeUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("endDateTimeUTC"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            endDateTimeUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("country"u8))
                        {
                            country = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("latencyMetrics"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<LatencyMetric> array = new List<LatencyMetric>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(LatencyMetric.DeserializeLatencyMetric(item));
                            }
                            latencyMetrics = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new LatencyScorecard(id, name, type, systemData.Value, Core.Optional.ToDictionary(tags), location, id0.Value, name0.Value, description.Value, endpointA.Value, endpointB.Value, Core.Optional.ToNullable(startDateTimeUtc), Core.Optional.ToNullable(endDateTimeUtc), country.Value, Core.Optional.ToList(latencyMetrics));
        }
    }
}
