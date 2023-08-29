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
using Azure.ResourceManager.NetworkCloud.Models;

namespace Azure.ResourceManager.NetworkCloud
{
    public partial class NetworkCloudAgentPoolData : IUtf8JsonSerializable, IModelJsonSerializable<NetworkCloudAgentPoolData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<NetworkCloudAgentPoolData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<NetworkCloudAgentPoolData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ExtendedLocation))
            {
                writer.WritePropertyName("extendedLocation"u8);
                writer.WriteObjectValue(ExtendedLocation);
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
            if (Optional.IsDefined(AdministratorConfiguration))
            {
                writer.WritePropertyName("administratorConfiguration"u8);
                writer.WriteObjectValue(AdministratorConfiguration);
            }
            if (Optional.IsDefined(AgentOptions))
            {
                writer.WritePropertyName("agentOptions"u8);
                writer.WriteObjectValue(AgentOptions);
            }
            if (Optional.IsDefined(AttachedNetworkConfiguration))
            {
                writer.WritePropertyName("attachedNetworkConfiguration"u8);
                writer.WriteObjectValue(AttachedNetworkConfiguration);
            }
            if (Optional.IsCollectionDefined(AvailabilityZones))
            {
                writer.WritePropertyName("availabilityZones"u8);
                writer.WriteStartArray();
                foreach (var item in AvailabilityZones)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("count"u8);
            writer.WriteNumberValue(Count);
            if (Optional.IsCollectionDefined(Labels))
            {
                writer.WritePropertyName("labels"u8);
                writer.WriteStartArray();
                foreach (var item in Labels)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("mode"u8);
            writer.WriteStringValue(Mode.ToString());
            if (Optional.IsCollectionDefined(Taints))
            {
                writer.WritePropertyName("taints"u8);
                writer.WriteStartArray();
                foreach (var item in Taints)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(UpgradeSettings))
            {
                writer.WritePropertyName("upgradeSettings"u8);
                writer.WriteObjectValue(UpgradeSettings);
            }
            writer.WritePropertyName("vmSkuName"u8);
            writer.WriteStringValue(VmSkuName);
            writer.WriteEndObject();
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
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

        internal static NetworkCloudAgentPoolData DeserializeNetworkCloudAgentPoolData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ExtendedLocation> extendedLocation = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<AdministratorConfiguration> administratorConfiguration = default;
            Optional<NetworkCloudAgentConfiguration> agentOptions = default;
            Optional<AttachedNetworkConfiguration> attachedNetworkConfiguration = default;
            Optional<IList<string>> availabilityZones = default;
            long count = default;
            Optional<AgentPoolDetailedStatus> detailedStatus = default;
            Optional<string> detailedStatusMessage = default;
            Optional<string> kubernetesVersion = default;
            Optional<IList<KubernetesLabel>> labels = default;
            NetworkCloudAgentPoolMode mode = default;
            Optional<AgentPoolProvisioningState> provisioningState = default;
            Optional<IList<KubernetesLabel>> taints = default;
            Optional<AgentPoolUpgradeSettings> upgradeSettings = default;
            string vmSkuName = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("extendedLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    extendedLocation = ExtendedLocation.DeserializeExtendedLocation(property.Value);
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
                        if (property0.NameEquals("administratorConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            administratorConfiguration = AdministratorConfiguration.DeserializeAdministratorConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("agentOptions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            agentOptions = NetworkCloudAgentConfiguration.DeserializeNetworkCloudAgentConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("attachedNetworkConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            attachedNetworkConfiguration = AttachedNetworkConfiguration.DeserializeAttachedNetworkConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("availabilityZones"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            availabilityZones = array;
                            continue;
                        }
                        if (property0.NameEquals("count"u8))
                        {
                            count = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("detailedStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            detailedStatus = new AgentPoolDetailedStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("detailedStatusMessage"u8))
                        {
                            detailedStatusMessage = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("kubernetesVersion"u8))
                        {
                            kubernetesVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("labels"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<KubernetesLabel> array = new List<KubernetesLabel>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(KubernetesLabel.DeserializeKubernetesLabel(item));
                            }
                            labels = array;
                            continue;
                        }
                        if (property0.NameEquals("mode"u8))
                        {
                            mode = new NetworkCloudAgentPoolMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new AgentPoolProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("taints"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<KubernetesLabel> array = new List<KubernetesLabel>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(KubernetesLabel.DeserializeKubernetesLabel(item));
                            }
                            taints = array;
                            continue;
                        }
                        if (property0.NameEquals("upgradeSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            upgradeSettings = AgentPoolUpgradeSettings.DeserializeAgentPoolUpgradeSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("vmSkuName"u8))
                        {
                            vmSkuName = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new NetworkCloudAgentPoolData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, extendedLocation.Value, administratorConfiguration.Value, agentOptions.Value, attachedNetworkConfiguration.Value, Optional.ToList(availabilityZones), count, Optional.ToNullable(detailedStatus), detailedStatusMessage.Value, kubernetesVersion.Value, Optional.ToList(labels), mode, Optional.ToNullable(provisioningState), Optional.ToList(taints), upgradeSettings.Value, vmSkuName, rawData);
        }

        NetworkCloudAgentPoolData IModelJsonSerializable<NetworkCloudAgentPoolData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkCloudAgentPoolData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<NetworkCloudAgentPoolData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        NetworkCloudAgentPoolData IModelSerializable<NetworkCloudAgentPoolData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeNetworkCloudAgentPoolData(doc.RootElement, options);
        }

        public static implicit operator RequestContent(NetworkCloudAgentPoolData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator NetworkCloudAgentPoolData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeNetworkCloudAgentPoolData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
