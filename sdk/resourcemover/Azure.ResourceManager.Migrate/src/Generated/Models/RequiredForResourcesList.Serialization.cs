// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Migrate.Models
{
    public partial class RequiredForResourcesList
    {
        internal static RequiredForResourcesList DeserializeRequiredForResourcesList(JsonElement element)
        {
            Optional<IReadOnlyList<string>> sourceIds = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceIds"))
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
                    sourceIds = array;
                    continue;
                }
            }
            return new RequiredForResourcesList(Optional.ToList(sourceIds));
        }
    }
}
