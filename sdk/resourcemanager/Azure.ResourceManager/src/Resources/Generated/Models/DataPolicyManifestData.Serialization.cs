// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    public partial class DataPolicyManifestData
    {
        internal static DataPolicyManifestData DeserializeDataPolicyManifestData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<IReadOnlyList<string>> namespaces = default;
            Optional<string> policyMode = default;
            Optional<bool> isBuiltInOnly = default;
            Optional<IReadOnlyList<ResourceTypeAliases>> resourceTypeAliases = default;
            Optional<IReadOnlyList<DataPolicyManifestEffect>> effects = default;
            Optional<IReadOnlyList<string>> fieldValues = default;
            Optional<IReadOnlyList<string>> standard = default;
            Optional<IReadOnlyList<DataManifestCustomResourceFunctionDefinition>> custom = default;
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
                    type = (ResourceType)property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
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
                        if (property0.NameEquals("namespaces"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            namespaces = array;
                            continue;
                        }
                        if (property0.NameEquals("policyMode"))
                        {
                            policyMode = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isBuiltInOnly"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isBuiltInOnly = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("resourceTypeAliases"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ResourceTypeAliases> array = new List<ResourceTypeAliases>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(Models.ResourceTypeAliases.DeserializeResourceTypeAliases(item));
                            }
                            resourceTypeAliases = array;
                            continue;
                        }
                        if (property0.NameEquals("effects"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<DataPolicyManifestEffect> array = new List<DataPolicyManifestEffect>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DataPolicyManifestEffect.DeserializeDataPolicyManifestEffect(item));
                            }
                            effects = array;
                            continue;
                        }
                        if (property0.NameEquals("fieldValues"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            fieldValues = array;
                            continue;
                        }
                        if (property0.NameEquals("resourceFunctions"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.NameEquals("standard"))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        property1.ThrowNonNullablePropertyIsNull();
                                        continue;
                                    }
                                    List<string> array = new List<string>();
                                    foreach (var item in property1.Value.EnumerateArray())
                                    {
                                        array.Add(item.GetString());
                                    }
                                    standard = array;
                                    continue;
                                }
                                if (property1.NameEquals("custom"))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        property1.ThrowNonNullablePropertyIsNull();
                                        continue;
                                    }
                                    List<DataManifestCustomResourceFunctionDefinition> array = new List<DataManifestCustomResourceFunctionDefinition>();
                                    foreach (var item in property1.Value.EnumerateArray())
                                    {
                                        array.Add(DataManifestCustomResourceFunctionDefinition.DeserializeDataManifestCustomResourceFunctionDefinition(item));
                                    }
                                    custom = array;
                                    continue;
                                }
                            }
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new DataPolicyManifestData(id, name, type, systemData, Optional.ToList(namespaces), policyMode.Value, Optional.ToNullable(isBuiltInOnly), Optional.ToList(resourceTypeAliases), Optional.ToList(effects), Optional.ToList(fieldValues), Optional.ToList(standard), Optional.ToList(custom));
        }
    }
}
