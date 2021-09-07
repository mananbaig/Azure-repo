// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.EventHub;

namespace Azure.ResourceManager.EventHub.Models
{
    internal partial class EHNamespaceListResult
    {
        internal static EHNamespaceListResult DeserializeEHNamespaceListResult(JsonElement element)
        {
            Optional<IReadOnlyList<EHNamespaceData>> value = default;
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
                    List<EHNamespaceData> array = new List<EHNamespaceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EHNamespaceData.DeserializeEHNamespaceData(item));
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
            return new EHNamespaceListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
