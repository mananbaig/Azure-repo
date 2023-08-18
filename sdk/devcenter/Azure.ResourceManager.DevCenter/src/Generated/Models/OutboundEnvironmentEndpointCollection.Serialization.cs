// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevCenter.Models
{
    internal partial class OutboundEnvironmentEndpointCollection
    {
        internal static OutboundEnvironmentEndpointCollection DeserializeOutboundEnvironmentEndpointCollection(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<OutboundEnvironmentEndpoint>> value = default;
            Core.Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<OutboundEnvironmentEndpoint> array = new List<OutboundEnvironmentEndpoint>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OutboundEnvironmentEndpoint.DeserializeOutboundEnvironmentEndpoint(item));
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
            return new OutboundEnvironmentEndpointCollection(Core.Optional.ToList(value), nextLink.Value);
        }
    }
}
