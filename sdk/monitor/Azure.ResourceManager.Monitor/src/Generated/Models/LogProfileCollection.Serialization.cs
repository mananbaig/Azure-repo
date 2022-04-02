// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Monitor;

namespace Azure.ResourceManager.Monitor.Models
{
    internal partial class LogProfileCollection
    {
        internal static LogProfileCollection DeserializeLogProfileCollection(JsonElement element)
        {
            IReadOnlyList<LogProfileData> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<LogProfileData> array = new List<LogProfileData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LogProfileData.DeserializeLogProfileData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new LogProfileCollection(value);
        }
    }
}
