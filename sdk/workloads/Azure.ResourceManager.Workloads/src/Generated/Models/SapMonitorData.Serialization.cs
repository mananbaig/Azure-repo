// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Workloads.Models;

namespace Azure.ResourceManager.Workloads
{
    public partial class SapMonitorData : IUtf8JsonSerializable, IModelJsonSerializable<SapMonitorData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SapMonitorData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SapMonitorData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SapMonitorData>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                if (Identity is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<UserAssignedServiceIdentity>)Identity).Serialize(writer, options);
                }
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(AppLocation))
            {
                writer.WritePropertyName("appLocation"u8);
                writer.WriteStringValue(AppLocation.Value);
            }
            if (Optional.IsDefined(RoutingPreference))
            {
                writer.WritePropertyName("routingPreference"u8);
                writer.WriteStringValue(RoutingPreference.Value.ToString());
            }
            if (Optional.IsDefined(ZoneRedundancyPreference))
            {
                writer.WritePropertyName("zoneRedundancyPreference"u8);
                writer.WriteStringValue(ZoneRedundancyPreference);
            }
            if (Optional.IsDefined(ManagedResourceGroupConfiguration))
            {
                writer.WritePropertyName("managedResourceGroupConfiguration"u8);
                if (ManagedResourceGroupConfiguration is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ManagedRGConfiguration>)ManagedResourceGroupConfiguration).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(LogAnalyticsWorkspaceArmId))
            {
                writer.WritePropertyName("logAnalyticsWorkspaceArmId"u8);
                writer.WriteStringValue(LogAnalyticsWorkspaceArmId);
            }
            if (Optional.IsDefined(MonitorSubnetId))
            {
                writer.WritePropertyName("monitorSubnet"u8);
                writer.WriteStringValue(MonitorSubnetId);
            }
            writer.WriteEndObject();
            if (_serializedAdditionalRawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static SapMonitorData DeserializeSapMonitorData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<UserAssignedServiceIdentity> identity = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<WorkloadMonitorProvisioningState> provisioningState = default;
            Optional<ResponseError> errors = default;
            Optional<AzureLocation> appLocation = default;
            Optional<SapRoutingPreference> routingPreference = default;
            Optional<string> zoneRedundancyPreference = default;
            Optional<ManagedRGConfiguration> managedResourceGroupConfiguration = default;
            Optional<ResourceIdentifier> logAnalyticsWorkspaceArmId = default;
            Optional<ResourceIdentifier> monitorSubnet = default;
            Optional<ResourceIdentifier> msiArmId = default;
            Optional<ResourceIdentifier> storageAccountArmId = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = UserAssignedServiceIdentity.DeserializeUserAssignedServiceIdentity(property.Value);
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
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
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
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
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
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
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new WorkloadMonitorProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("errors"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            errors = JsonSerializer.Deserialize<ResponseError>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("appLocation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            appLocation = new AzureLocation(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("routingPreference"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            routingPreference = new SapRoutingPreference(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("zoneRedundancyPreference"u8))
                        {
                            zoneRedundancyPreference = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("managedResourceGroupConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            managedResourceGroupConfiguration = ManagedRGConfiguration.DeserializeManagedRGConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("logAnalyticsWorkspaceArmId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            logAnalyticsWorkspaceArmId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("monitorSubnet"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            monitorSubnet = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("msiArmId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            msiArmId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("storageAccountArmId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            storageAccountArmId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SapMonitorData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, identity.Value, Optional.ToNullable(provisioningState), errors.Value, Optional.ToNullable(appLocation), Optional.ToNullable(routingPreference), zoneRedundancyPreference.Value, managedResourceGroupConfiguration.Value, logAnalyticsWorkspaceArmId.Value, monitorSubnet.Value, msiArmId.Value, storageAccountArmId.Value, serializedAdditionalRawData);
        }

        SapMonitorData IModelJsonSerializable<SapMonitorData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SapMonitorData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSapMonitorData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SapMonitorData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SapMonitorData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SapMonitorData IModelSerializable<SapMonitorData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SapMonitorData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSapMonitorData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SapMonitorData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SapMonitorData"/> to convert. </param>
        public static implicit operator RequestContent(SapMonitorData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SapMonitorData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SapMonitorData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSapMonitorData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
