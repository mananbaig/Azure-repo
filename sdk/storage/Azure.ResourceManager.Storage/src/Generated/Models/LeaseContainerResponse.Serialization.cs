// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class LeaseContainerResponse
    {
        internal static LeaseContainerResponse DeserializeLeaseContainerResponse(JsonElement element)
        {
            Optional<string> leaseId = default;
            Optional<string> leaseTimeSeconds = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("leaseId"))
                {
                    leaseId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("leaseTimeSeconds"))
                {
                    leaseTimeSeconds = property.Value.GetString();
                    continue;
                }
            }
            return new LeaseContainerResponse(leaseId.Value, leaseTimeSeconds.Value);
        }
    }
}
