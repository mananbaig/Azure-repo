// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class VirtualNetworkPeeringListResult
    {
        internal static VirtualNetworkPeeringListResult DeserializeVirtualNetworkPeeringListResult(JsonElement element)
        {
            Optional<IReadOnlyList<VirtualNetworkPeering>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<VirtualNetworkPeering> array = new List<VirtualNetworkPeering>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VirtualNetworkPeering.DeserializeVirtualNetworkPeering(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new VirtualNetworkPeeringListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
