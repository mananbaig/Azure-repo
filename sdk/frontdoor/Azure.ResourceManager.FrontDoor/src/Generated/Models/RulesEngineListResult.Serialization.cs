// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.FrontDoor;

namespace Azure.ResourceManager.FrontDoor.Models
{
    internal partial class RulesEngineListResult
    {
        internal static RulesEngineListResult DeserializeRulesEngineListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<FrontDoorRulesEngineData>> value = default;
            Core.Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FrontDoorRulesEngineData> array = new List<FrontDoorRulesEngineData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FrontDoorRulesEngineData.DeserializeFrontDoorRulesEngineData(item));
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
            return new RulesEngineListResult(Core.Optional.ToList(value), nextLink.Value);
        }
    }
}
