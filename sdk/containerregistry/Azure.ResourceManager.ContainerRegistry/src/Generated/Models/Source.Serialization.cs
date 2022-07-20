// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    public partial class Source
    {
        internal static Source DeserializeSource(JsonElement element)
        {
            Optional<string> addr = default;
            Optional<string> instanceId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("addr"))
                {
                    addr = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("instanceID"))
                {
                    instanceId = property.Value.GetString();
                    continue;
                }
            }
            return new Source(addr.Value, instanceId.Value);
        }
    }
}
