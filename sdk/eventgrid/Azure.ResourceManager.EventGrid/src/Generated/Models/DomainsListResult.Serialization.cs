// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.EventGrid;

namespace Azure.ResourceManager.EventGrid.Models
{
    internal partial class DomainsListResult
    {
        internal static DomainsListResult DeserializeDomainsListResult(JsonElement element)
        {
            Optional<IReadOnlyList<EventGridDomainData>> value = default;
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
                    List<EventGridDomainData> array = new List<EventGridDomainData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EventGridDomainData.DeserializeEventGridDomainData(item));
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
            return new DomainsListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
