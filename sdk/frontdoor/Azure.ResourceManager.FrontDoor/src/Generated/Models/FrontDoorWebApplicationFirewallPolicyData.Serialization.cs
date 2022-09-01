// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.FrontDoor.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.FrontDoor
{
    public partial class FrontDoorWebApplicationFirewallPolicyData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag");
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku");
                writer.WriteObjectValue(Sku);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(PolicySettings))
            {
                writer.WritePropertyName("policySettings");
                writer.WriteObjectValue(PolicySettings);
            }
            if (Optional.IsDefined(CustomRuleList))
            {
                writer.WritePropertyName("customRules");
                writer.WriteObjectValue(CustomRuleList);
            }
            if (Optional.IsDefined(ManagedRules))
            {
                writer.WritePropertyName("managedRules");
                writer.WriteObjectValue(ManagedRules);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static FrontDoorWebApplicationFirewallPolicyData DeserializeFrontDoorWebApplicationFirewallPolicyData(JsonElement element)
        {
            Optional<ETag> etag = default;
            Optional<FrontDoorSku> sku = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            Core.ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<FrontDoorWebApplicationFirewallPolicySettings> policySettings = default;
            Optional<CustomRuleList> customRules = default;
            Optional<ManagedRuleSetList> managedRules = default;
            Optional<IReadOnlyList<SubResource>> frontendEndpointLinks = default;
            Optional<IReadOnlyList<SubResource>> routingRuleLinks = default;
            Optional<IReadOnlyList<SubResource>> securityPolicyLinks = default;
            Optional<string> provisioningState = default;
            Optional<FrontDoorWebApplicationFirewallPolicyResourceState> resourceState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sku"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sku = FrontDoorSku.DeserializeFrontDoorSku(property.Value);
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = new AzureLocation(property.Value.GetString());
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
                        if (property0.NameEquals("policySettings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            policySettings = FrontDoorWebApplicationFirewallPolicySettings.DeserializeFrontDoorWebApplicationFirewallPolicySettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("customRules"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            customRules = CustomRuleList.DeserializeCustomRuleList(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("managedRules"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            managedRules = ManagedRuleSetList.DeserializeManagedRuleSetList(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("frontendEndpointLinks"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<SubResource> array = new List<SubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<SubResource>(item.ToString()));
                            }
                            frontendEndpointLinks = array;
                            continue;
                        }
                        if (property0.NameEquals("routingRuleLinks"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<SubResource> array = new List<SubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<SubResource>(item.ToString()));
                            }
                            routingRuleLinks = array;
                            continue;
                        }
                        if (property0.NameEquals("securityPolicyLinks"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<SubResource> array = new List<SubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<SubResource>(item.ToString()));
                            }
                            securityPolicyLinks = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resourceState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            resourceState = new FrontDoorWebApplicationFirewallPolicyResourceState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new FrontDoorWebApplicationFirewallPolicyData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, Optional.ToNullable(etag), sku.Value, policySettings.Value, customRules.Value, managedRules.Value, Optional.ToList(frontendEndpointLinks), Optional.ToList(routingRuleLinks), Optional.ToList(securityPolicyLinks), provisioningState.Value, Optional.ToNullable(resourceState));
        }
    }
}
