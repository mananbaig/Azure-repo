// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.HybridContainerService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HybridContainerService
{
    public partial class HybridContainerServiceAgentPoolData : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(ExtendedLocation))
            {
                writer.WritePropertyName("extendedLocation"u8);
                writer.WriteObjectValue(ExtendedLocation);
            }
            if (Core.Optional.IsCollectionDefined(Tags))
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
            if (Core.Optional.IsDefined(Count))
            {
                writer.WritePropertyName("count"u8);
                writer.WriteNumberValue(Count.Value);
            }
            if (Core.Optional.IsCollectionDefined(AvailabilityZones))
            {
                writer.WritePropertyName("availabilityZones"u8);
                writer.WriteStartArray();
                foreach (var item in AvailabilityZones)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsDefined(MaxCount))
            {
                writer.WritePropertyName("maxCount"u8);
                writer.WriteNumberValue(MaxCount.Value);
            }
            if (Core.Optional.IsDefined(MaxPods))
            {
                writer.WritePropertyName("maxPods"u8);
                writer.WriteNumberValue(MaxPods.Value);
            }
            if (Core.Optional.IsDefined(MinCount))
            {
                writer.WritePropertyName("minCount"u8);
                writer.WriteNumberValue(MinCount.Value);
            }
            if (Core.Optional.IsDefined(Mode))
            {
                writer.WritePropertyName("mode"u8);
                writer.WriteStringValue(Mode.Value.ToString());
            }
            if (Core.Optional.IsCollectionDefined(NodeLabels))
            {
                writer.WritePropertyName("nodeLabels"u8);
                writer.WriteStartObject();
                foreach (var item in NodeLabels)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Core.Optional.IsCollectionDefined(NodeTaints))
            {
                writer.WritePropertyName("nodeTaints"u8);
                writer.WriteStartArray();
                foreach (var item in NodeTaints)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsDefined(OSType))
            {
                writer.WritePropertyName("osType"u8);
                writer.WriteStringValue(OSType.Value.ToString());
            }
            if (Core.Optional.IsDefined(NodeImageVersion))
            {
                writer.WritePropertyName("nodeImageVersion"u8);
                writer.WriteStringValue(NodeImageVersion);
            }
            if (Core.Optional.IsDefined(VmSize))
            {
                writer.WritePropertyName("vmSize"u8);
                writer.WriteStringValue(VmSize);
            }
            if (Core.Optional.IsDefined(CloudProviderProfile))
            {
                writer.WritePropertyName("cloudProviderProfile"u8);
                writer.WriteObjectValue(CloudProviderProfile);
            }
            if (Core.Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteObjectValue(Status);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static HybridContainerServiceAgentPoolData DeserializeHybridContainerServiceAgentPoolData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<AgentPoolExtendedLocation> extendedLocation = default;
            Core.Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Core.Optional<SystemData> systemData = default;
            Core.Optional<int> count = default;
            Core.Optional<IList<string>> availabilityZones = default;
            Core.Optional<int> maxCount = default;
            Core.Optional<int> maxPods = default;
            Core.Optional<int> minCount = default;
            Core.Optional<Mode> mode = default;
            Core.Optional<IDictionary<string, string>> nodeLabels = default;
            Core.Optional<IList<string>> nodeTaints = default;
            Core.Optional<OSType> osType = default;
            Core.Optional<string> nodeImageVersion = default;
            Core.Optional<string> vmSize = default;
            Core.Optional<CloudProviderProfile> cloudProviderProfile = default;
            Core.Optional<AgentPoolProvisioningState> provisioningState = default;
            Core.Optional<AgentPoolProvisioningStatusStatus> status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("extendedLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    extendedLocation = AgentPoolExtendedLocation.DeserializeAgentPoolExtendedLocation(property.Value);
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
                        if (property0.NameEquals("count"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            count = property0.Value.GetInt32();
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
                        if (property0.NameEquals("maxCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("maxPods"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxPods = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("minCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            minCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("mode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            mode = new Mode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("nodeLabels"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            nodeLabels = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("nodeTaints"u8))
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
                            nodeTaints = array;
                            continue;
                        }
                        if (property0.NameEquals("osType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            osType = new OSType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("nodeImageVersion"u8))
                        {
                            nodeImageVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("vmSize"u8))
                        {
                            vmSize = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("cloudProviderProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            cloudProviderProfile = CloudProviderProfile.DeserializeCloudProviderProfile(property0.Value);
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
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = AgentPoolProvisioningStatusStatus.DeserializeAgentPoolProvisioningStatusStatus(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new HybridContainerServiceAgentPoolData(id, name, type, systemData.Value, Core.Optional.ToDictionary(tags), location, extendedLocation.Value, Core.Optional.ToNullable(count), Core.Optional.ToList(availabilityZones), Core.Optional.ToNullable(maxCount), Core.Optional.ToNullable(maxPods), Core.Optional.ToNullable(minCount), Core.Optional.ToNullable(mode), Core.Optional.ToDictionary(nodeLabels), Core.Optional.ToList(nodeTaints), Core.Optional.ToNullable(osType), nodeImageVersion.Value, vmSize.Value, cloudProviderProfile.Value, Core.Optional.ToNullable(provisioningState), status.Value);
        }
    }
}
