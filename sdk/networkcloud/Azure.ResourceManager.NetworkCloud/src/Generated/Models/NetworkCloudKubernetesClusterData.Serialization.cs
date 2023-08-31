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
    public partial class NetworkCloudKubernetesClusterData : IUtf8JsonSerializable, IModelJsonSerializable<NetworkCloudKubernetesClusterData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<NetworkCloudKubernetesClusterData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<NetworkCloudKubernetesClusterData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("extendedLocation"u8);
            if (ExtendedLocation is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<ExtendedLocation>)ExtendedLocation).Serialize(writer, options);
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
            if (Optional.IsDefined(AadConfiguration))
            {
                writer.WritePropertyName("aadConfiguration"u8);
                if (AadConfiguration is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<NetworkCloudAadConfiguration>)AadConfiguration).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(AdministratorConfiguration))
            {
                writer.WritePropertyName("administratorConfiguration"u8);
                if (AdministratorConfiguration is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<AdministratorConfiguration>)AdministratorConfiguration).Serialize(writer, options);
                }
            }
            writer.WritePropertyName("controlPlaneNodeConfiguration"u8);
            if (ControlPlaneNodeConfiguration is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<ControlPlaneNodeConfiguration>)ControlPlaneNodeConfiguration).Serialize(writer, options);
            }
            writer.WritePropertyName("initialAgentPoolConfigurations"u8);
            writer.WriteStartArray();
            foreach (var item in InitialAgentPoolConfigurations)
            {
                if (item is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<InitialAgentPoolConfiguration>)item).Serialize(writer, options);
                }
            }
            writer.WriteEndArray();
            writer.WritePropertyName("kubernetesVersion"u8);
            writer.WriteStringValue(KubernetesVersion);
            if (Optional.IsDefined(ManagedResourceGroupConfiguration))
            {
                writer.WritePropertyName("managedResourceGroupConfiguration"u8);
                if (ManagedResourceGroupConfiguration is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ManagedResourceGroupConfiguration>)ManagedResourceGroupConfiguration).Serialize(writer, options);
                }
            }
            writer.WritePropertyName("networkConfiguration"u8);
            if (NetworkConfiguration is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<KubernetesClusterNetworkConfiguration>)NetworkConfiguration).Serialize(writer, options);
            }
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

        internal static NetworkCloudKubernetesClusterData DeserializeNetworkCloudKubernetesClusterData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ExtendedLocation extendedLocation = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<NetworkCloudAadConfiguration> aadConfiguration = default;
            Optional<AdministratorConfiguration> administratorConfiguration = default;
            Optional<IReadOnlyList<ResourceIdentifier>> attachedNetworkIds = default;
            Optional<IReadOnlyList<AvailableUpgrade>> availableUpgrades = default;
            Optional<ResourceIdentifier> clusterId = default;
            Optional<ResourceIdentifier> connectedClusterId = default;
            Optional<string> controlPlaneKubernetesVersion = default;
            ControlPlaneNodeConfiguration controlPlaneNodeConfiguration = default;
            Optional<KubernetesClusterDetailedStatus> detailedStatus = default;
            Optional<string> detailedStatusMessage = default;
            Optional<IReadOnlyList<FeatureStatus>> featureStatuses = default;
            IList<InitialAgentPoolConfiguration> initialAgentPoolConfigurations = default;
            string kubernetesVersion = default;
            Optional<ManagedResourceGroupConfiguration> managedResourceGroupConfiguration = default;
            KubernetesClusterNetworkConfiguration networkConfiguration = default;
            Optional<IReadOnlyList<KubernetesClusterNode>> nodes = default;
            Optional<KubernetesClusterProvisioningState> provisioningState = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("extendedLocation"u8))
                {
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
                        if (property0.NameEquals("aadConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            aadConfiguration = NetworkCloudAadConfiguration.DeserializeNetworkCloudAadConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("administratorConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            administratorConfiguration = AdministratorConfiguration.DeserializeAdministratorConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("attachedNetworkIds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ResourceIdentifier> array = new List<ResourceIdentifier>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(new ResourceIdentifier(item.GetString()));
                                }
                            }
                            attachedNetworkIds = array;
                            continue;
                        }
                        if (property0.NameEquals("availableUpgrades"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AvailableUpgrade> array = new List<AvailableUpgrade>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AvailableUpgrade.DeserializeAvailableUpgrade(item));
                            }
                            availableUpgrades = array;
                            continue;
                        }
                        if (property0.NameEquals("clusterId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("connectedClusterId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            connectedClusterId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("controlPlaneKubernetesVersion"u8))
                        {
                            controlPlaneKubernetesVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("controlPlaneNodeConfiguration"u8))
                        {
                            controlPlaneNodeConfiguration = ControlPlaneNodeConfiguration.DeserializeControlPlaneNodeConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("detailedStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            detailedStatus = new KubernetesClusterDetailedStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("detailedStatusMessage"u8))
                        {
                            detailedStatusMessage = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("featureStatuses"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<FeatureStatus> array = new List<FeatureStatus>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(FeatureStatus.DeserializeFeatureStatus(item));
                            }
                            featureStatuses = array;
                            continue;
                        }
                        if (property0.NameEquals("initialAgentPoolConfigurations"u8))
                        {
                            List<InitialAgentPoolConfiguration> array = new List<InitialAgentPoolConfiguration>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(InitialAgentPoolConfiguration.DeserializeInitialAgentPoolConfiguration(item));
                            }
                            initialAgentPoolConfigurations = array;
                            continue;
                        }
                        if (property0.NameEquals("kubernetesVersion"u8))
                        {
                            kubernetesVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("managedResourceGroupConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            managedResourceGroupConfiguration = ManagedResourceGroupConfiguration.DeserializeManagedResourceGroupConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("networkConfiguration"u8))
                        {
                            networkConfiguration = KubernetesClusterNetworkConfiguration.DeserializeKubernetesClusterNetworkConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("nodes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<KubernetesClusterNode> array = new List<KubernetesClusterNode>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(KubernetesClusterNode.DeserializeKubernetesClusterNode(item));
                            }
                            nodes = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new KubernetesClusterProvisioningState(property0.Value.GetString());
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
            return new NetworkCloudKubernetesClusterData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, extendedLocation, aadConfiguration.Value, administratorConfiguration.Value, Optional.ToList(attachedNetworkIds), Optional.ToList(availableUpgrades), clusterId.Value, connectedClusterId.Value, controlPlaneKubernetesVersion.Value, controlPlaneNodeConfiguration, Optional.ToNullable(detailedStatus), detailedStatusMessage.Value, Optional.ToList(featureStatuses), initialAgentPoolConfigurations, kubernetesVersion, managedResourceGroupConfiguration.Value, networkConfiguration, Optional.ToList(nodes), Optional.ToNullable(provisioningState), rawData);
        }

        NetworkCloudKubernetesClusterData IModelJsonSerializable<NetworkCloudKubernetesClusterData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkCloudKubernetesClusterData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<NetworkCloudKubernetesClusterData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        NetworkCloudKubernetesClusterData IModelSerializable<NetworkCloudKubernetesClusterData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeNetworkCloudKubernetesClusterData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="NetworkCloudKubernetesClusterData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="NetworkCloudKubernetesClusterData"/> to convert. </param>
        public static implicit operator RequestContent(NetworkCloudKubernetesClusterData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="NetworkCloudKubernetesClusterData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator NetworkCloudKubernetesClusterData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeNetworkCloudKubernetesClusterData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
