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
    internal partial class BatchDeploymentTrackedResourceArmPaginatedResult
    {
        internal static BatchDeploymentTrackedResourceArmPaginatedResult DeserializeBatchDeploymentTrackedResourceArmPaginatedResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> nextLink = default;
            Core.Optional<IReadOnlyList<MachineLearningBatchDeploymentData>> value = default;
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
                    List<MachineLearningBatchDeploymentData> array = new List<MachineLearningBatchDeploymentData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MachineLearningBatchDeploymentData.DeserializeMachineLearningBatchDeploymentData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new BatchDeploymentTrackedResourceArmPaginatedResult(nextLink.Value, Core.Optional.ToList(value));
        }
    }
}
