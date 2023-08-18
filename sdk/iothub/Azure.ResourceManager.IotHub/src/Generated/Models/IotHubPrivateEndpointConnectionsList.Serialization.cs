// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.IotHub;

namespace Azure.ResourceManager.IotHub.Models
{
    internal partial class IotHubPrivateEndpointConnectionsList
    {
        internal static IotHubPrivateEndpointConnectionsList DeserializeIotHubPrivateEndpointConnectionsList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<IotHubPrivateEndpointConnectionData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IotHubPrivateEndpointConnectionData> array = new List<IotHubPrivateEndpointConnectionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IotHubPrivateEndpointConnectionData.DeserializeIotHubPrivateEndpointConnectionData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new IotHubPrivateEndpointConnectionsList(Core.Optional.ToList(value));
        }
    }
}
