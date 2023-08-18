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
    internal partial class EventHubsPrivateEndpointConnectionListResult
    {
        internal static EventHubsPrivateEndpointConnectionListResult DeserializeEventHubsPrivateEndpointConnectionListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<EventHubsPrivateEndpointConnectionData>> value = default;
            Core.Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<EventHubsPrivateEndpointConnectionData> array = new List<EventHubsPrivateEndpointConnectionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EventHubsPrivateEndpointConnectionData.DeserializeEventHubsPrivateEndpointConnectionData(item));
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
            return new EventHubsPrivateEndpointConnectionListResult(Core.Optional.ToList(value), nextLink.Value);
        }
    }
}
