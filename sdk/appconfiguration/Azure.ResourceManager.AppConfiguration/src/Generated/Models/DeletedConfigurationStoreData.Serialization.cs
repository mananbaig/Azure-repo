// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppConfiguration
{
    public partial class DeletedConfigurationStoreData
    {
        internal static DeletedConfigurationStoreData DeserializeDeletedConfigurationStoreData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> configurationStoreId = default;
            Optional<string> location = default;
            Optional<DateTimeOffset> deletionDate = default;
            Optional<DateTimeOffset> scheduledPurgeDate = default;
            Optional<IReadOnlyDictionary<string, string>> tags = default;
            Optional<bool> purgeProtectionEnabled = default;
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
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
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
                        if (property0.NameEquals("configurationStoreId"))
                        {
                            configurationStoreId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("location"))
                        {
                            location = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("deletionDate"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            deletionDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("scheduledPurgeDate"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            scheduledPurgeDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("tags"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            tags = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("purgeProtectionEnabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            purgeProtectionEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new DeletedConfigurationStoreData(id, name, type, systemData.Value, configurationStoreId.Value, location.Value, Optional.ToNullable(deletionDate), Optional.ToNullable(scheduledPurgeDate), Optional.ToDictionary(tags), Optional.ToNullable(purgeProtectionEnabled));
        }
    }
}
