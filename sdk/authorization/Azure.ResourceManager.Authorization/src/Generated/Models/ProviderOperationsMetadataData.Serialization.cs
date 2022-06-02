// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Authorization.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Authorization
{
    public partial class ProviderOperationsMetadataData
    {
        internal static ProviderOperationsMetadataData DeserializeProviderOperationsMetadataData(JsonElement element)
        {
            Optional<string> displayName = default;
            Optional<IReadOnlyList<Models.ResourceType>> resourceTypes = default;
            Optional<IReadOnlyList<ProviderOperation>> operations = default;
            ResourceIdentifier id = default;
            string name = default;
            Core.ResourceType type = default;
            SystemData systemData = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("displayName"))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceTypes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<Models.ResourceType> array = new List<Models.ResourceType>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.ResourceType.DeserializeResourceType(item));
                    }
                    resourceTypes = array;
                    continue;
                }
                if (property.NameEquals("operations"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ProviderOperation> array = new List<ProviderOperation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ProviderOperation.DeserializeProviderOperation(item));
                    }
                    operations = array;
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new Core.ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
            }
            return new ProviderOperationsMetadataData(id, name, type, systemData, displayName.Value, Optional.ToList(resourceTypes), Optional.ToList(operations));
        }
    }
}
