// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.FrontDoor.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.FrontDoor
{
    public partial class FrontendEndpointData : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Core.Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(HostName))
            {
                writer.WritePropertyName("hostName"u8);
                writer.WriteStringValue(HostName);
            }
            if (Core.Optional.IsDefined(SessionAffinityEnabledState))
            {
                writer.WritePropertyName("sessionAffinityEnabledState"u8);
                writer.WriteStringValue(SessionAffinityEnabledState.Value.ToString());
            }
            if (Core.Optional.IsDefined(SessionAffinityTtlInSeconds))
            {
                writer.WritePropertyName("sessionAffinityTtlSeconds"u8);
                writer.WriteNumberValue(SessionAffinityTtlInSeconds.Value);
            }
            if (Core.Optional.IsDefined(WebApplicationFirewallPolicyLink))
            {
                writer.WritePropertyName("webApplicationFirewallPolicyLink"u8);
                JsonSerializer.Serialize(writer, WebApplicationFirewallPolicyLink);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static FrontendEndpointData DeserializeFrontendEndpointData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<ResourceIdentifier> id = default;
            Core.Optional<string> name = default;
            Core.Optional<ResourceType> type = default;
            Core.Optional<string> hostName = default;
            Core.Optional<SessionAffinityEnabledState> sessionAffinityEnabledState = default;
            Core.Optional<int> sessionAffinityTtlSeconds = default;
            Core.Optional<WritableSubResource> webApplicationFirewallPolicyLink = default;
            Core.Optional<FrontDoorResourceState> resourceState = default;
            Core.Optional<FrontendEndpointCustomHttpsProvisioningState?> customHttpsProvisioningState = default;
            Core.Optional<FrontendEndpointCustomHttpsProvisioningSubstate?> customHttpsProvisioningSubstate = default;
            Core.Optional<CustomHttpsConfiguration> customHttpsConfiguration = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("hostName"u8))
                        {
                            hostName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sessionAffinityEnabledState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sessionAffinityEnabledState = new SessionAffinityEnabledState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("sessionAffinityTtlSeconds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sessionAffinityTtlSeconds = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("webApplicationFirewallPolicyLink"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            webApplicationFirewallPolicyLink = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("resourceState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceState = new FrontDoorResourceState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("customHttpsProvisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                customHttpsProvisioningState = null;
                                continue;
                            }
                            customHttpsProvisioningState = new FrontendEndpointCustomHttpsProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("customHttpsProvisioningSubstate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                customHttpsProvisioningSubstate = null;
                                continue;
                            }
                            customHttpsProvisioningSubstate = new FrontendEndpointCustomHttpsProvisioningSubstate(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("customHttpsConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                customHttpsConfiguration = null;
                                continue;
                            }
                            customHttpsConfiguration = CustomHttpsConfiguration.DeserializeCustomHttpsConfiguration(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new FrontendEndpointData(id.Value, name.Value, Core.Optional.ToNullable(type), hostName.Value, Core.Optional.ToNullable(sessionAffinityEnabledState), Core.Optional.ToNullable(sessionAffinityTtlSeconds), webApplicationFirewallPolicyLink, Core.Optional.ToNullable(resourceState), Core.Optional.ToNullable(customHttpsProvisioningState), Core.Optional.ToNullable(customHttpsProvisioningSubstate), customHttpsConfiguration.Value);
        }
    }
}
