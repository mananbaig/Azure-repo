// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Cdn.Models;

namespace Azure.ResourceManager.Cdn
{
    public partial class AFDOriginData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(AzureOrigin))
            {
                writer.WritePropertyName("azureOrigin");
                writer.WriteObjectValue(AzureOrigin);
            }
            if (Optional.IsDefined(HostName))
            {
                writer.WritePropertyName("hostName");
                writer.WriteStringValue(HostName);
            }
            if (Optional.IsDefined(HttpPort))
            {
                writer.WritePropertyName("httpPort");
                writer.WriteNumberValue(HttpPort.Value);
            }
            if (Optional.IsDefined(HttpsPort))
            {
                writer.WritePropertyName("httpsPort");
                writer.WriteNumberValue(HttpsPort.Value);
            }
            if (Optional.IsDefined(OriginHostHeader))
            {
                writer.WritePropertyName("originHostHeader");
                writer.WriteStringValue(OriginHostHeader);
            }
            if (Optional.IsDefined(Priority))
            {
                if (Priority != null)
                {
                    writer.WritePropertyName("priority");
                    writer.WriteNumberValue(Priority.Value);
                }
                else
                {
                    writer.WriteNull("priority");
                }
            }
            if (Optional.IsDefined(Weight))
            {
                if (Weight != null)
                {
                    writer.WritePropertyName("weight");
                    writer.WriteNumberValue(Weight.Value);
                }
                else
                {
                    writer.WriteNull("weight");
                }
            }
            if (Optional.IsDefined(SharedPrivateLinkResource))
            {
                if (SharedPrivateLinkResource != null)
                {
                    writer.WritePropertyName("sharedPrivateLinkResource");
                    writer.WriteObjectValue(SharedPrivateLinkResource);
                }
                else
                {
                    writer.WriteNull("sharedPrivateLinkResource");
                }
            }
            if (Optional.IsDefined(EnabledState))
            {
                writer.WritePropertyName("enabledState");
                writer.WriteStringValue(EnabledState.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static AFDOriginData DeserializeAFDOriginData(JsonElement element)
        {
            Optional<SystemData> systemData = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<ResourceReference> azureOrigin = default;
            Optional<string> hostName = default;
            Optional<int> httpPort = default;
            Optional<int> httpsPort = default;
            Optional<string> originHostHeader = default;
            Optional<int?> priority = default;
            Optional<int?> weight = default;
            Optional<object> sharedPrivateLinkResource = default;
            Optional<EnabledState> enabledState = default;
            Optional<AfdProvisioningState> provisioningState = default;
            Optional<DeploymentStatus> deploymentStatus = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = SystemData.DeserializeSystemData(property.Value);
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
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
                        if (property0.NameEquals("azureOrigin"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            azureOrigin = ResourceReference.DeserializeResourceReference(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("hostName"))
                        {
                            hostName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("httpPort"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            httpPort = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("httpsPort"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            httpsPort = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("originHostHeader"))
                        {
                            originHostHeader = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("priority"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                priority = null;
                                continue;
                            }
                            priority = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("weight"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                weight = null;
                                continue;
                            }
                            weight = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("sharedPrivateLinkResource"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                sharedPrivateLinkResource = null;
                                continue;
                            }
                            sharedPrivateLinkResource = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("enabledState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            enabledState = new EnabledState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new AfdProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("deploymentStatus"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            deploymentStatus = new DeploymentStatus(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new AFDOriginData(id, name, type, systemData.Value, azureOrigin.Value, hostName.Value, Optional.ToNullable(httpPort), Optional.ToNullable(httpsPort), originHostHeader.Value, Optional.ToNullable(priority), Optional.ToNullable(weight), sharedPrivateLinkResource.Value, Optional.ToNullable(enabledState), Optional.ToNullable(provisioningState), Optional.ToNullable(deploymentStatus));
        }
    }
}
