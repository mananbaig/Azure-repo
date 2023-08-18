// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.LoadTesting.Models
{
    internal partial class OutboundEnvironmentEndpointListResult
    {
        internal static OutboundEnvironmentEndpointListResult DeserializeOutboundEnvironmentEndpointListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<LoadTestingOutboundEnvironmentEndpoint>> value = default;
            Core.Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LoadTestingOutboundEnvironmentEndpoint> array = new List<LoadTestingOutboundEnvironmentEndpoint>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LoadTestingOutboundEnvironmentEndpoint.DeserializeLoadTestingOutboundEnvironmentEndpoint(item));
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
            return new OutboundEnvironmentEndpointListResult(Core.Optional.ToList(value), nextLink.Value);
        }
    }
}
