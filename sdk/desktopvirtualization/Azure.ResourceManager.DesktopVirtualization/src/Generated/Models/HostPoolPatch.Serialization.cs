// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    public partial class HostPoolPatch : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
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
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName");
                writer.WriteStringValue(FriendlyName);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(CustomRdpProperty))
            {
                writer.WritePropertyName("customRdpProperty");
                writer.WriteStringValue(CustomRdpProperty);
            }
            if (Optional.IsDefined(MaxSessionLimit))
            {
                writer.WritePropertyName("maxSessionLimit");
                writer.WriteNumberValue(MaxSessionLimit.Value);
            }
            if (Optional.IsDefined(PersonalDesktopAssignmentType))
            {
                writer.WritePropertyName("personalDesktopAssignmentType");
                writer.WriteStringValue(PersonalDesktopAssignmentType.Value.ToString());
            }
            if (Optional.IsDefined(LoadBalancerType))
            {
                writer.WritePropertyName("loadBalancerType");
                writer.WriteStringValue(LoadBalancerType.Value.ToString());
            }
            if (Optional.IsDefined(Ring))
            {
                writer.WritePropertyName("ring");
                writer.WriteNumberValue(Ring.Value);
            }
            if (Optional.IsDefined(ValidationEnvironment))
            {
                writer.WritePropertyName("validationEnvironment");
                writer.WriteBooleanValue(ValidationEnvironment.Value);
            }
            if (Optional.IsDefined(RegistrationInfo))
            {
                writer.WritePropertyName("registrationInfo");
                writer.WriteObjectValue(RegistrationInfo);
            }
            if (Optional.IsDefined(VmTemplate))
            {
                writer.WritePropertyName("vmTemplate");
                writer.WriteStringValue(VmTemplate);
            }
            if (Optional.IsDefined(SsoadfsAuthority))
            {
                writer.WritePropertyName("ssoadfsAuthority");
                writer.WriteStringValue(SsoadfsAuthority);
            }
            if (Optional.IsDefined(SsoClientId))
            {
                writer.WritePropertyName("ssoClientId");
                writer.WriteStringValue(SsoClientId);
            }
            if (Optional.IsDefined(SsoClientSecretKeyVaultPath))
            {
                writer.WritePropertyName("ssoClientSecretKeyVaultPath");
                writer.WriteStringValue(SsoClientSecretKeyVaultPath);
            }
            if (Optional.IsDefined(SsoSecretType))
            {
                writer.WritePropertyName("ssoSecretType");
                writer.WriteStringValue(SsoSecretType.Value.ToString());
            }
            if (Optional.IsDefined(PreferredAppGroupType))
            {
                writer.WritePropertyName("preferredAppGroupType");
                writer.WriteStringValue(PreferredAppGroupType.Value.ToString());
            }
            if (Optional.IsDefined(StartVmOnConnect))
            {
                writer.WritePropertyName("startVMOnConnect");
                writer.WriteBooleanValue(StartVmOnConnect.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static HostPoolPatch DeserializeHostPoolPatch(JsonElement element)
        {
            Optional<IDictionary<string, string>> tags = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<string> friendlyName = default;
            Optional<string> description = default;
            Optional<string> customRdpProperty = default;
            Optional<int> maxSessionLimit = default;
            Optional<PersonalDesktopAssignmentType> personalDesktopAssignmentType = default;
            Optional<LoadBalancerType> loadBalancerType = default;
            Optional<int> ring = default;
            Optional<bool> validationEnvironment = default;
            Optional<RegistrationInfoPatch> registrationInfo = default;
            Optional<string> vmTemplate = default;
            Optional<string> ssoadfsAuthority = default;
            Optional<string> ssoClientId = default;
            Optional<string> ssoClientSecretKeyVaultPath = default;
            Optional<SsoSecretType> ssoSecretType = default;
            Optional<PreferredAppGroupType> preferredAppGroupType = default;
            Optional<bool> startVMOnConnect = default;
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("friendlyName"))
                        {
                            friendlyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("customRdpProperty"))
                        {
                            customRdpProperty = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("maxSessionLimit"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            maxSessionLimit = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("personalDesktopAssignmentType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            personalDesktopAssignmentType = new PersonalDesktopAssignmentType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("loadBalancerType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            loadBalancerType = new LoadBalancerType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("ring"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            ring = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("validationEnvironment"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            validationEnvironment = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("registrationInfo"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            registrationInfo = RegistrationInfoPatch.DeserializeRegistrationInfoPatch(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("vmTemplate"))
                        {
                            vmTemplate = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ssoadfsAuthority"))
                        {
                            ssoadfsAuthority = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ssoClientId"))
                        {
                            ssoClientId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ssoClientSecretKeyVaultPath"))
                        {
                            ssoClientSecretKeyVaultPath = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ssoSecretType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            ssoSecretType = new SsoSecretType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("preferredAppGroupType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            preferredAppGroupType = new PreferredAppGroupType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("startVMOnConnect"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            startVMOnConnect = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new HostPoolPatch(id, name, type, systemData, Optional.ToDictionary(tags), friendlyName.Value, description.Value, customRdpProperty.Value, Optional.ToNullable(maxSessionLimit), Optional.ToNullable(personalDesktopAssignmentType), Optional.ToNullable(loadBalancerType), Optional.ToNullable(ring), Optional.ToNullable(validationEnvironment), registrationInfo.Value, vmTemplate.Value, ssoadfsAuthority.Value, ssoClientId.Value, ssoClientSecretKeyVaultPath.Value, Optional.ToNullable(ssoSecretType), Optional.ToNullable(preferredAppGroupType), Optional.ToNullable(startVMOnConnect));
        }
    }
}
