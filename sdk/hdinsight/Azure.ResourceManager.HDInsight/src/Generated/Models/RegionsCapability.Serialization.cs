// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class RegionsCapability
    {
        internal static RegionsCapability DeserializeRegionsCapability(JsonElement element)
        {
            Optional<IReadOnlyList<string>> available = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("available"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    available = array;
                    continue;
                }
            }
            return new RegionsCapability(Optional.ToList(available));
        }
    }
}
