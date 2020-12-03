// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Iot.TimeSeriesInsights.Models
{
    public partial class PagedResponse
    {
        internal static PagedResponse DeserializePagedResponse(JsonElement element)
        {
            Optional<string> continuationToken = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("continuationToken"))
                {
                    continuationToken = property.Value.GetString();
                    continue;
                }
            }
            return new PagedResponse(continuationToken.Value);
        }
    }
}
