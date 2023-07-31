// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Temp.Batch.Models
{
    public partial class TaskAddCollectionResult
    {
        internal static TaskAddCollectionResult DeserializeTaskAddCollectionResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<TaskAddResult>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TaskAddResult> array = new List<TaskAddResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TaskAddResult.DeserializeTaskAddResult(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new TaskAddCollectionResult(Optional.ToList(value));
        }
    }
}
