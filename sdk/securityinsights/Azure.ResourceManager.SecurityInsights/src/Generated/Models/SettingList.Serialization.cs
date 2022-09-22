// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.SecurityInsights;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    internal partial class SettingList
    {
        internal static SettingList DeserializeSettingList(JsonElement element)
        {
            IReadOnlyList<SettingData> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<SettingData> array = new List<SettingData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SettingData.DeserializeSettingData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new SettingList(value);
        }
    }
}
