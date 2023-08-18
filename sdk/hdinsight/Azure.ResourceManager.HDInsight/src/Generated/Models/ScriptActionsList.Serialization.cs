// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    internal partial class ScriptActionsList
    {
        internal static ScriptActionsList DeserializeScriptActionsList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<RuntimeScriptActionDetail>> value = default;
            Core.Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RuntimeScriptActionDetail> array = new List<RuntimeScriptActionDetail>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RuntimeScriptActionDetail.DeserializeRuntimeScriptActionDetail(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new ScriptActionsList(Core.Optional.ToList(value), nextLink.Value);
        }
    }
}
