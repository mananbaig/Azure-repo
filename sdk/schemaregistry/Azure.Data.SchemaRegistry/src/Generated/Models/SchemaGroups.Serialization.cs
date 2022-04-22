// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Data.SchemaRegistry.Models
{
    internal partial class SchemaGroups
    {
        internal static SchemaGroups DeserializeSchemaGroups(JsonElement element)
        {
            Optional<IReadOnlyList<string>> schemaGroups = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("schemaGroups"))
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
                    schemaGroups = array;
                    continue;
                }
            }
            return new SchemaGroups(Optional.ToList(schemaGroups));
        }
    }
}
