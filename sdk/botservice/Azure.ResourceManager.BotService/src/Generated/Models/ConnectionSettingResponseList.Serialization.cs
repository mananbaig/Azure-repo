// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.BotService;

namespace Azure.ResourceManager.BotService.Models
{
    internal partial class ConnectionSettingResponseList
    {
        internal static ConnectionSettingResponseList DeserializeConnectionSettingResponseList(JsonElement element)
        {
            Optional<string> nextLink = default;
            Optional<IReadOnlyList<ConnectionSettingData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ConnectionSettingData> array = new List<ConnectionSettingData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ConnectionSettingData.DeserializeConnectionSettingData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new ConnectionSettingResponseList(nextLink.Value, Optional.ToList(value));
        }
    }
}
