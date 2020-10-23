// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class ScriptLogsList
    {
        internal static ScriptLogsList DeserializeScriptLogsList(JsonElement element)
        {
            Optional<IReadOnlyList<ScriptLog>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ScriptLog> array = new List<ScriptLog>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ScriptLog.DeserializeScriptLog(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new ScriptLogsList(Optional.ToList(value));
        }
    }
}
