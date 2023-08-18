// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DigitalTwins;

namespace Azure.ResourceManager.DigitalTwins.Models
{
    internal partial class GroupIdInformationResponse
    {
        internal static GroupIdInformationResponse DeserializeGroupIdInformationResponse(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<DigitalTwinsPrivateLinkResourceData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DigitalTwinsPrivateLinkResourceData> array = new List<DigitalTwinsPrivateLinkResourceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DigitalTwinsPrivateLinkResourceData.DeserializeDigitalTwinsPrivateLinkResourceData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new GroupIdInformationResponse(Core.Optional.ToList(value));
        }
    }
}
