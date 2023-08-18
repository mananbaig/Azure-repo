// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DnsResolver.Models
{
    internal partial class VirtualNetworkDnsForwardingRulesetListResult
    {
        internal static VirtualNetworkDnsForwardingRulesetListResult DeserializeVirtualNetworkDnsForwardingRulesetListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<VirtualNetworkDnsForwardingRuleset>> value = default;
            Core.Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VirtualNetworkDnsForwardingRuleset> array = new List<VirtualNetworkDnsForwardingRuleset>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VirtualNetworkDnsForwardingRuleset.DeserializeVirtualNetworkDnsForwardingRuleset(item));
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
            return new VirtualNetworkDnsForwardingRulesetListResult(Core.Optional.ToList(value), nextLink.Value);
        }
    }
}
