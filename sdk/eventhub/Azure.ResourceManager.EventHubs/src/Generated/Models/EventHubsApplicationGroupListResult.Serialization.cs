// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.EventHubs;

namespace Azure.ResourceManager.EventHubs.Models
{
    internal partial class EventHubsApplicationGroupListResult
    {
        internal static EventHubsApplicationGroupListResult DeserializeEventHubsApplicationGroupListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<EventHubsApplicationGroupData>> value = default;
            Core.Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<EventHubsApplicationGroupData> array = new List<EventHubsApplicationGroupData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EventHubsApplicationGroupData.DeserializeEventHubsApplicationGroupData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new EventHubsApplicationGroupListResult(Core.Optional.ToList(value), nextLink.Value);
        }
    }
}
