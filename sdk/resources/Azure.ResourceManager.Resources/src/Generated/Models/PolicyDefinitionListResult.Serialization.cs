// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class PolicyDefinitionListResult
    {
        internal static PolicyDefinitionListResult DeserializePolicyDefinitionListResult(JsonElement element)
        {
            Optional<IReadOnlyList<PolicyDefinition>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<PolicyDefinition> array = new List<PolicyDefinition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PolicyDefinition.DeserializePolicyDefinition(item));
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
            return new PolicyDefinitionListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
