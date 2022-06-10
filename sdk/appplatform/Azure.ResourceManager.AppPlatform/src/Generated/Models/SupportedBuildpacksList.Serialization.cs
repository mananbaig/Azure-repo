// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppPlatform;

namespace Azure.ResourceManager.AppPlatform.Models
{
    internal partial class SupportedBuildpacksList
    {
        internal static SupportedBuildpacksList DeserializeSupportedBuildpacksList(JsonElement element)
        {
            Optional<IReadOnlyList<SupportedBuildpackResourceData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SupportedBuildpackResourceData> array = new List<SupportedBuildpackResourceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SupportedBuildpackResourceData.DeserializeSupportedBuildpackResourceData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new SupportedBuildpacksList(Optional.ToList(value), nextLink.Value);
        }
    }
}
