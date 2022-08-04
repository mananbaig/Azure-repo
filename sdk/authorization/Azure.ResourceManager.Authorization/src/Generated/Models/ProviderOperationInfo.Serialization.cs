// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Authorization.Models
{
    public partial class ProviderOperationInfo
    {
        internal static ProviderOperationInfo DeserializeProviderOperationInfo(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> displayName = default;
            Optional<string> description = default;
            Optional<string> origin = default;
            Optional<BinaryData> properties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("origin"))
                {
                    origin = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        properties = null;
                        continue;
                    }
                    properties = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
            }
            return new ProviderOperationInfo(name.Value, displayName.Value, description.Value, origin.Value, properties.Value);
        }
    }
}
