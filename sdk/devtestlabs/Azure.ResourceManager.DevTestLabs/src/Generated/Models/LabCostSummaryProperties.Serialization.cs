// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    internal partial class LabCostSummaryProperties
    {
        internal static LabCostSummaryProperties DeserializeLabCostSummaryProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<double> estimatedLabCost = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("estimatedLabCost"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    estimatedLabCost = property.Value.GetDouble();
                    continue;
                }
            }
            return new LabCostSummaryProperties(Core.Optional.ToNullable(estimatedLabCost));
        }
    }
}
