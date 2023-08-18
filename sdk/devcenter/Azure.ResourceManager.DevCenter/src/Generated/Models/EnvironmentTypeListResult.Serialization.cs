// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DevCenter;

namespace Azure.ResourceManager.DevCenter.Models
{
    internal partial class EnvironmentTypeListResult
    {
        internal static EnvironmentTypeListResult DeserializeEnvironmentTypeListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<DevCenterEnvironmentTypeData>> value = default;
            Core.Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DevCenterEnvironmentTypeData> array = new List<DevCenterEnvironmentTypeData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DevCenterEnvironmentTypeData.DeserializeDevCenterEnvironmentTypeData(item));
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
            return new EnvironmentTypeListResult(Core.Optional.ToList(value), nextLink.Value);
        }
    }
}
