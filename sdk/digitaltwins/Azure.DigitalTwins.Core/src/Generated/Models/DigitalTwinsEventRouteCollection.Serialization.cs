// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.DigitalTwins.Core
{
    internal partial class DigitalTwinsEventRouteCollection
    {
        internal static DigitalTwinsEventRouteCollection DeserializeDigitalTwinsEventRouteCollection(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<DigitalTwinsEventRoute> value = default;
            Azure.Core.Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<DigitalTwinsEventRoute> array = new List<DigitalTwinsEventRoute>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DigitalTwinsEventRoute.DeserializeDigitalTwinsEventRoute(item));
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
            return new DigitalTwinsEventRouteCollection(value, nextLink.Value);
        }
    }
}
