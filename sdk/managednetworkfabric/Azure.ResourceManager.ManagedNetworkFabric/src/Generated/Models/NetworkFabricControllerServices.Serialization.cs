// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class NetworkFabricControllerServices
    {
        internal static NetworkFabricControllerServices DeserializeNetworkFabricControllerServices(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<string>> ipv4AddressSpaces = default;
            Core.Optional<IReadOnlyList<string>> ipv6AddressSpaces = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ipv4AddressSpaces"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    ipv4AddressSpaces = array;
                    continue;
                }
                if (property.NameEquals("ipv6AddressSpaces"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    ipv6AddressSpaces = array;
                    continue;
                }
            }
            return new NetworkFabricControllerServices(Core.Optional.ToList(ipv4AddressSpaces), Core.Optional.ToList(ipv6AddressSpaces));
        }
    }
}
