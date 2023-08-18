// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DnsResolver;

namespace Azure.ResourceManager.DnsResolver.Models
{
    internal partial class ForwardingRuleListResult
    {
        internal static ForwardingRuleListResult DeserializeForwardingRuleListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<DnsForwardingRuleData>> value = default;
            Core.Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DnsForwardingRuleData> array = new List<DnsForwardingRuleData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DnsForwardingRuleData.DeserializeDnsForwardingRuleData(item));
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
            return new ForwardingRuleListResult(Core.Optional.ToList(value), nextLink.Value);
        }
    }
}
