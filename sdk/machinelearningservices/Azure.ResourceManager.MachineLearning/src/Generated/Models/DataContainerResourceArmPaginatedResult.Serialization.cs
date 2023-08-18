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
    internal partial class DataContainerResourceArmPaginatedResult
    {
        internal static DataContainerResourceArmPaginatedResult DeserializeDataContainerResourceArmPaginatedResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> nextLink = default;
            Core.Optional<IReadOnlyList<MachineLearningDataContainerData>> value = default;
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
                    List<MachineLearningDataContainerData> array = new List<MachineLearningDataContainerData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MachineLearningDataContainerData.DeserializeMachineLearningDataContainerData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new DataContainerResourceArmPaginatedResult(nextLink.Value, Core.Optional.ToList(value));
        }
    }
}
