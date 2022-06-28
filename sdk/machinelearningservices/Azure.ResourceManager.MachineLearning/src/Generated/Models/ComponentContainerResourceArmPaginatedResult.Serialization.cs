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
    internal partial class ComponentContainerResourceArmPaginatedResult
    {
        internal static ComponentContainerResourceArmPaginatedResult DeserializeComponentContainerResourceArmPaginatedResult(JsonElement element)
        {
            Optional<string> nextLink = default;
            Optional<IReadOnlyList<ComponentContainerData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ComponentContainerData> array = new List<ComponentContainerData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ComponentContainerData.DeserializeComponentContainerData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new ComponentContainerResourceArmPaginatedResult(nextLink.Value, Optional.ToList(value));
        }
    }
}
