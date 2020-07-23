// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DigitalTwins.Models
{
    public partial class DigitalTwinsDescriptionListResult
    {
        internal static DigitalTwinsDescriptionListResult DeserializeDigitalTwinsDescriptionListResult(JsonElement element)
        {
            Optional<string> nextLink = default;
            Optional<IReadOnlyList<DigitalTwinsDescription>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    List<DigitalTwinsDescription> array = new List<DigitalTwinsDescription>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DigitalTwinsDescription.DeserializeDigitalTwinsDescription(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new DigitalTwinsDescriptionListResult(nextLink.Value, Optional.ToList(value));
        }
    }
}
