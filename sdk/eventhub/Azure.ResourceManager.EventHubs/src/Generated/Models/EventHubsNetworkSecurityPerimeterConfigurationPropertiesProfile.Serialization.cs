// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventHubs.Models
{
    public partial class EventHubsNetworkSecurityPerimeterConfigurationPropertiesProfile
    {
        internal static EventHubsNetworkSecurityPerimeterConfigurationPropertiesProfile DeserializeEventHubsNetworkSecurityPerimeterConfigurationPropertiesProfile(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> name = default;
            Core.Optional<string> accessRulesVersion = default;
            Core.Optional<IReadOnlyList<EventHubsNspAccessRule>> accessRules = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accessRulesVersion"u8))
                {
                    accessRulesVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accessRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<EventHubsNspAccessRule> array = new List<EventHubsNspAccessRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EventHubsNspAccessRule.DeserializeEventHubsNspAccessRule(item));
                    }
                    accessRules = array;
                    continue;
                }
            }
            return new EventHubsNetworkSecurityPerimeterConfigurationPropertiesProfile(name.Value, accessRulesVersion.Value, Core.Optional.ToList(accessRules));
        }
    }
}
