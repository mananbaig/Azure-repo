// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Logic;

namespace Azure.ResourceManager.Logic.Models
{
    internal partial class WorkflowRunActionRepetitionDefinitionCollection
    {
        internal static WorkflowRunActionRepetitionDefinitionCollection DeserializeWorkflowRunActionRepetitionDefinitionCollection(JsonElement element)
        {
            Optional<string> nextLink = default;
            Optional<IReadOnlyList<WorkflowRunActionRepetitionDefinitionData>> value = default;
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
                    List<WorkflowRunActionRepetitionDefinitionData> array = new List<WorkflowRunActionRepetitionDefinitionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WorkflowRunActionRepetitionDefinitionData.DeserializeWorkflowRunActionRepetitionDefinitionData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new WorkflowRunActionRepetitionDefinitionCollection(nextLink.Value, Optional.ToList(value));
        }
    }
}
