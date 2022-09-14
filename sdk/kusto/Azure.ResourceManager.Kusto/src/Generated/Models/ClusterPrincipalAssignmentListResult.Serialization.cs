// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Kusto;

namespace Azure.ResourceManager.Kusto.Models
{
    internal partial class ClusterPrincipalAssignmentListResult
    {
        internal static ClusterPrincipalAssignmentListResult DeserializeClusterPrincipalAssignmentListResult(JsonElement element)
        {
            Optional<IReadOnlyList<KustoClusterPrincipalAssignmentData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<KustoClusterPrincipalAssignmentData> array = new List<KustoClusterPrincipalAssignmentData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(KustoClusterPrincipalAssignmentData.DeserializeKustoClusterPrincipalAssignmentData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new ClusterPrincipalAssignmentListResult(Optional.ToList(value));
        }
    }
}
