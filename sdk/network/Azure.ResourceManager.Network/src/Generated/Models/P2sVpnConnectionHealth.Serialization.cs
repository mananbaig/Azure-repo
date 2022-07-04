// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class P2sVpnConnectionHealth
    {
        internal static P2sVpnConnectionHealth DeserializeP2sVpnConnectionHealth(JsonElement element)
        {
            Optional<Uri> sasUrl = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sasUrl"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        sasUrl = null;
                        continue;
                    }
                    sasUrl = new Uri(property.Value.GetString());
                    continue;
                }
            }
            return new P2sVpnConnectionHealth(sasUrl.Value);
        }
    }
}
