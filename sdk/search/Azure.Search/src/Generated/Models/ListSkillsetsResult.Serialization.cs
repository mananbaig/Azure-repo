// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Models
{
    internal partial class ListSkillsetsResult
    {
        internal static ListSkillsetsResult DeserializeListSkillsetsResult(JsonElement element)
        {
            ListSkillsetsResult result = new ListSkillsetsResult();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.Skillsets.Add(Skillset.DeserializeSkillset(item));
                    }
                    continue;
                }
            }
            return result;
        }
    }
}
