// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.MachineLearning;

namespace Azure.ResourceManager.MachineLearning.Models
{
    internal partial class RegistryTrackedResourceArmPaginatedResult
    {
        internal static RegistryTrackedResourceArmPaginatedResult DeserializeRegistryTrackedResourceArmPaginatedResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> nextLink = default;
            Optional<IReadOnlyList<RegistryData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RegistryData> array = new List<RegistryData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RegistryData.DeserializeRegistryData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new RegistryTrackedResourceArmPaginatedResult(nextLink.Value, Optional.ToList(value));
        }
    }
}
