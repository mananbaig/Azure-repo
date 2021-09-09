// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    internal partial class NetworkVirtualApplianceSiteListResult
    {
        internal static NetworkVirtualApplianceSiteListResult DeserializeNetworkVirtualApplianceSiteListResult(JsonElement element)
        {
            Optional<IReadOnlyList<VirtualApplianceSiteData>> value = default;
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
                    List<VirtualApplianceSiteData> array = new List<VirtualApplianceSiteData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VirtualApplianceSiteData.DeserializeVirtualApplianceSiteData(item));
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
            return new NetworkVirtualApplianceSiteListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
