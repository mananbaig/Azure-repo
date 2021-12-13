// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Verticals.AgriFood.Farming.Models
{
    internal partial class SeasonListResponse
    {
        internal static SeasonListResponse DeserializeSeasonListResponse(JsonElement element)
        {
            Optional<IReadOnlyList<Season>> value = default;
            Optional<string> skipToken = default;
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
                    List<Season> array = new List<Season>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Season.DeserializeSeason(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("$skipToken"))
                {
                    skipToken = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new SeasonListResponse(Optional.ToList(value), skipToken.Value, nextLink.Value);
        }
    }
}
