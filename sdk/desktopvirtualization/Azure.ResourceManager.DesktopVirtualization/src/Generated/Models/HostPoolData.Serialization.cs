// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DesktopVirtualization.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DesktopVirtualization
{
    public partial class HostPoolData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ManagedBy))
            {
                writer.WritePropertyName("managedBy");
                writer.WriteStringValue(ManagedBy);
            }
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind");
                writer.WriteStringValue(Kind);
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity");
                JsonSerializer.Serialize(writer, Identity);
            }
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku");
                writer.WriteObjectValue(Sku);
            }
            if (Optional.IsDefined(Plan))
            {
                writer.WritePropertyName("plan");
                JsonSerializer.Serialize(writer, Plan);
            }
            writer.WritePropertyName("tags");
            writer.WriteStartObject();
            foreach (var item in Tags)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteStringValue(item.Value);
            }
            writer.WriteEndObject();
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
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
            writer.WritePropertyName("hostPoolType");
            writer.WriteStringValue(HostPoolType.ToString());
            if (Optional.IsDefined(PersonalDesktopAssignmentType))
            {
                writer.WritePropertyName("personalDesktopAssignmentType");
                writer.WriteStringValue(PersonalDesktopAssignmentType.Value.ToString());
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
            writer.WritePropertyName("loadBalancerType");
            writer.WriteStringValue(LoadBalancerType.ToString());
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
            writer.WritePropertyName("preferredAppGroupType");
            writer.WriteStringValue(PreferredAppGroupType.ToString());
            if (Optional.IsDefined(StartVmOnConnect))
            {
                writer.WritePropertyName("startVMOnConnect");
                writer.WriteBooleanValue(StartVmOnConnect.Value);
            }
            if (Optional.IsDefined(MigrationRequest))
            {
                writer.WritePropertyName("migrationRequest");
                writer.WriteObjectValue(MigrationRequest);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static HostPoolData DeserializeHostPoolData(JsonElement element)
        {
            Optional<string> managedBy = default;
            Optional<string> kind = default;
            Optional<string> etag = default;
            Optional<SystemAssignedServiceIdentity> identity = default;
            Optional<ResourceModelWithAllowedPropertySetSku> sku = default;
            Optional<ArmPlan> plan = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<string> objectId = default;
            Optional<string> friendlyName = default;
            Optional<string> description = default;
            HostPoolType hostPoolType = default;
            Optional<PersonalDesktopAssignmentType> personalDesktopAssignmentType = default;
            Optional<string> customRdpProperty = default;
            Optional<int> maxSessionLimit = default;
            LoadBalancerType loadBalancerType = default;
            Optional<int> ring = default;
            Optional<bool> validationEnvironment = default;
            Optional<RegistrationInfo> registrationInfo = default;
            Optional<string> vmTemplate = default;
            Optional<IReadOnlyList<string>> applicationGroupReferences = default;
            Optional<string> ssoadfsAuthority = default;
            Optional<string> ssoClientId = default;
            Optional<string> ssoClientSecretKeyVaultPath = default;
            Optional<SsoSecretType> ssoSecretType = default;
            PreferredAppGroupType preferredAppGroupType = default;
            Optional<bool> startVMOnConnect = default;
            Optional<MigrationRequestProperties> migrationRequest = default;
            Optional<bool> cloudPcResource = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("managedBy"))
                {
                    managedBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("identity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<SystemAssignedServiceIdentity>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("sku"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sku = ResourceModelWithAllowedPropertySetSku.DeserializeResourceModelWithAllowedPropertySetSku(property.Value);
                    continue;
                }
                if (property.NameEquals("plan"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    plan = JsonSerializer.Deserialize<ArmPlan>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("tags"))
                {
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
                    location = (AzureLocation)property.Value.GetString();
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
                        if (property0.NameEquals("objectId"))
                        {
                            objectId = property0.Value.GetString();
                            continue;
                        }
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
                        if (property0.NameEquals("hostPoolType"))
                        {
                            hostPoolType = new HostPoolType(property0.Value.GetString());
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
                        if (property0.NameEquals("loadBalancerType"))
                        {
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
                            registrationInfo = RegistrationInfo.DeserializeRegistrationInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("vmTemplate"))
                        {
                            vmTemplate = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("applicationGroupReferences"))
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
                            applicationGroupReferences = array;
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
                        if (property0.NameEquals("migrationRequest"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            migrationRequest = MigrationRequestProperties.DeserializeMigrationRequestProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("cloudPcResource"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            cloudPcResource = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new HostPoolData(id, name, type, systemData, tags, location, managedBy.Value, kind.Value, etag.Value, identity, sku.Value, plan, objectId.Value, friendlyName.Value, description.Value, hostPoolType, Optional.ToNullable(personalDesktopAssignmentType), customRdpProperty.Value, Optional.ToNullable(maxSessionLimit), loadBalancerType, Optional.ToNullable(ring), Optional.ToNullable(validationEnvironment), registrationInfo.Value, vmTemplate.Value, Optional.ToList(applicationGroupReferences), ssoadfsAuthority.Value, ssoClientId.Value, ssoClientSecretKeyVaultPath.Value, Optional.ToNullable(ssoSecretType), preferredAppGroupType, Optional.ToNullable(startVMOnConnect), migrationRequest.Value, Optional.ToNullable(cloudPcResource));
        }
    }
}
