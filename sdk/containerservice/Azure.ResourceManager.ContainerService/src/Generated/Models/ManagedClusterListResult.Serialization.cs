// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ContainerService;

namespace Azure.ResourceManager.ContainerService.Models
{
    internal partial class ManagedClusterListResult
    {
        internal static ManagedClusterListResult DeserializeManagedClusterListResult(JsonElement element)
        {
            Optional<IReadOnlyList<ContainerServiceManagedClusterData>> value = default;
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
                    List<ContainerServiceManagedClusterData> array = new List<ContainerServiceManagedClusterData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerServiceManagedClusterData.DeserializeContainerServiceManagedClusterData(item));
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
            return new ManagedClusterListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
