// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Management.Models;

namespace Azure.ResourceManager.Management
{
    public partial class ManagementGroupData
    {
        internal static ManagementGroupData DeserializeManagementGroupData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<string> tenantId = default;
            Optional<string> displayName = default;
            Optional<ManagementGroupDetails> details = default;
            Optional<IReadOnlyList<ManagementGroupChildInfo>> children = default;
            foreach (var property in element.EnumerateObject())
            {
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
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("tenantId"))
                        {
                            tenantId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("displayName"))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("details"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            details = ManagementGroupDetails.DeserializeManagementGroupDetails(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("children"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                children = null;
                                continue;
                            }
                            List<ManagementGroupChildInfo> array = new List<ManagementGroupChildInfo>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ManagementGroupChildInfo.DeserializeManagementGroupChildInfo(item));
                            }
                            children = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ManagementGroupData(id, name, type, tenantId.Value, displayName.Value, details.Value, Optional.ToList(children));
        }
    }
}
