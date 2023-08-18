// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DigitalTwins;

namespace Azure.ResourceManager.DigitalTwins.Models
{
    internal partial class DigitalTwinsEndpointResourceListResult
    {
        internal static DigitalTwinsEndpointResourceListResult DeserializeDigitalTwinsEndpointResourceListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> nextLink = default;
            Core.Optional<IReadOnlyList<DigitalTwinsEndpointResourceData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        nextLink = null;
                        continue;
                    }
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DigitalTwinsEndpointResourceData> array = new List<DigitalTwinsEndpointResourceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DigitalTwinsEndpointResourceData.DeserializeDigitalTwinsEndpointResourceData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new DigitalTwinsEndpointResourceListResult(nextLink.Value, Core.Optional.ToList(value));
        }
    }
}
