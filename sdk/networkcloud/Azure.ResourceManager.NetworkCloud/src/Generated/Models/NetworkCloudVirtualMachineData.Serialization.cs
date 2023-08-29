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
    public partial class NetworkCloudVirtualMachineData : IUtf8JsonSerializable, IModelJsonSerializable<NetworkCloudVirtualMachineData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<NetworkCloudVirtualMachineData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<NetworkCloudVirtualMachineData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("extendedLocation"u8);
            writer.WriteObjectValue(ExtendedLocation);
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
            writer.WritePropertyName("adminUsername"u8);
            writer.WriteStringValue(AdminUsername);
            if (Optional.IsDefined(BootMethod))
            {
                writer.WritePropertyName("bootMethod"u8);
                writer.WriteStringValue(BootMethod.Value.ToString());
            }
            writer.WritePropertyName("cloudServicesNetworkAttachment"u8);
            writer.WriteObjectValue(CloudServicesNetworkAttachment);
            writer.WritePropertyName("cpuCores"u8);
            writer.WriteNumberValue(CpuCores);
            if (Optional.IsDefined(IsolateEmulatorThread))
            {
                writer.WritePropertyName("isolateEmulatorThread"u8);
                writer.WriteStringValue(IsolateEmulatorThread.Value.ToString());
            }
            writer.WritePropertyName("memorySizeGB"u8);
            writer.WriteNumberValue(MemorySizeInGB);
            if (Optional.IsCollectionDefined(NetworkAttachments))
            {
                writer.WritePropertyName("networkAttachments"u8);
                writer.WriteStartArray();
                foreach (var item in NetworkAttachments)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(NetworkData))
            {
                writer.WritePropertyName("networkData"u8);
                writer.WriteStringValue(NetworkData);
            }
            if (Optional.IsCollectionDefined(PlacementHints))
            {
                writer.WritePropertyName("placementHints"u8);
                writer.WriteStartArray();
                foreach (var item in PlacementHints)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(SshPublicKeys))
            {
                writer.WritePropertyName("sshPublicKeys"u8);
                writer.WriteStartArray();
                foreach (var item in SshPublicKeys)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("storageProfile"u8);
            writer.WriteObjectValue(StorageProfile);
            if (Optional.IsDefined(UserData))
            {
                writer.WritePropertyName("userData"u8);
                writer.WriteStringValue(UserData);
            }
            if (Optional.IsDefined(VirtioInterface))
            {
                writer.WritePropertyName("virtioInterface"u8);
                writer.WriteStringValue(VirtioInterface.Value.ToString());
            }
            if (Optional.IsDefined(VmDeviceModel))
            {
                writer.WritePropertyName("vmDeviceModel"u8);
                writer.WriteStringValue(VmDeviceModel.Value.ToString());
            }
            writer.WritePropertyName("vmImage"u8);
            writer.WriteStringValue(VmImage);
            if (Optional.IsDefined(VmImageRepositoryCredentials))
            {
                writer.WritePropertyName("vmImageRepositoryCredentials"u8);
                writer.WriteObjectValue(VmImageRepositoryCredentials);
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

        internal static NetworkCloudVirtualMachineData DeserializeNetworkCloudVirtualMachineData(JsonElement element, ModelSerializerOptions options = default)
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
            string adminUsername = default;
            Optional<string> availabilityZone = default;
            Optional<ResourceIdentifier> bareMetalMachineId = default;
            Optional<VirtualMachineBootMethod> bootMethod = default;
            NetworkAttachment cloudServicesNetworkAttachment = default;
            Optional<ResourceIdentifier> clusterId = default;
            long cpuCores = default;
            Optional<VirtualMachineDetailedStatus> detailedStatus = default;
            Optional<string> detailedStatusMessage = default;
            Optional<VirtualMachineIsolateEmulatorThread> isolateEmulatorThread = default;
            long memorySizeGB = default;
            Optional<IList<NetworkAttachment>> networkAttachments = default;
            Optional<string> networkData = default;
            Optional<IList<VirtualMachinePlacementHint>> placementHints = default;
            Optional<VirtualMachinePowerState> powerState = default;
            Optional<VirtualMachineProvisioningState> provisioningState = default;
            Optional<IList<NetworkCloudSshPublicKey>> sshPublicKeys = default;
            NetworkCloudStorageProfile storageProfile = default;
            Optional<string> userData = default;
            Optional<VirtualMachineVirtioInterfaceType> virtioInterface = default;
            Optional<VirtualMachineDeviceModelType> vmDeviceModel = default;
            string vmImage = default;
            Optional<ImageRepositoryCredentials> vmImageRepositoryCredentials = default;
            Optional<IReadOnlyList<ResourceIdentifier>> volumes = default;
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
                        if (property0.NameEquals("adminUsername"u8))
                        {
                            adminUsername = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("availabilityZone"u8))
                        {
                            availabilityZone = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("bareMetalMachineId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            bareMetalMachineId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("bootMethod"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            bootMethod = new VirtualMachineBootMethod(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("cloudServicesNetworkAttachment"u8))
                        {
                            cloudServicesNetworkAttachment = NetworkAttachment.DeserializeNetworkAttachment(property0.Value);
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
                        if (property0.NameEquals("cpuCores"u8))
                        {
                            cpuCores = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("detailedStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            detailedStatus = new VirtualMachineDetailedStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("detailedStatusMessage"u8))
                        {
                            detailedStatusMessage = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isolateEmulatorThread"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isolateEmulatorThread = new VirtualMachineIsolateEmulatorThread(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("memorySizeGB"u8))
                        {
                            memorySizeGB = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("networkAttachments"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<NetworkAttachment> array = new List<NetworkAttachment>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(NetworkAttachment.DeserializeNetworkAttachment(item));
                            }
                            networkAttachments = array;
                            continue;
                        }
                        if (property0.NameEquals("networkData"u8))
                        {
                            networkData = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("placementHints"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<VirtualMachinePlacementHint> array = new List<VirtualMachinePlacementHint>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VirtualMachinePlacementHint.DeserializeVirtualMachinePlacementHint(item));
                            }
                            placementHints = array;
                            continue;
                        }
                        if (property0.NameEquals("powerState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            powerState = new VirtualMachinePowerState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new VirtualMachineProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("sshPublicKeys"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<NetworkCloudSshPublicKey> array = new List<NetworkCloudSshPublicKey>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(NetworkCloudSshPublicKey.DeserializeNetworkCloudSshPublicKey(item));
                            }
                            sshPublicKeys = array;
                            continue;
                        }
                        if (property0.NameEquals("storageProfile"u8))
                        {
                            storageProfile = NetworkCloudStorageProfile.DeserializeNetworkCloudStorageProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("userData"u8))
                        {
                            userData = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("virtioInterface"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            virtioInterface = new VirtualMachineVirtioInterfaceType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("vmDeviceModel"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            vmDeviceModel = new VirtualMachineDeviceModelType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("vmImage"u8))
                        {
                            vmImage = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("vmImageRepositoryCredentials"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            vmImageRepositoryCredentials = ImageRepositoryCredentials.DeserializeImageRepositoryCredentials(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("volumes"u8))
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
                            volumes = array;
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
            return new NetworkCloudVirtualMachineData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, extendedLocation, adminUsername, availabilityZone.Value, bareMetalMachineId.Value, Optional.ToNullable(bootMethod), cloudServicesNetworkAttachment, clusterId.Value, cpuCores, Optional.ToNullable(detailedStatus), detailedStatusMessage.Value, Optional.ToNullable(isolateEmulatorThread), memorySizeGB, Optional.ToList(networkAttachments), networkData.Value, Optional.ToList(placementHints), Optional.ToNullable(powerState), Optional.ToNullable(provisioningState), Optional.ToList(sshPublicKeys), storageProfile, userData.Value, Optional.ToNullable(virtioInterface), Optional.ToNullable(vmDeviceModel), vmImage, vmImageRepositoryCredentials.Value, Optional.ToList(volumes), rawData);
        }

        NetworkCloudVirtualMachineData IModelJsonSerializable<NetworkCloudVirtualMachineData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkCloudVirtualMachineData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<NetworkCloudVirtualMachineData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        NetworkCloudVirtualMachineData IModelSerializable<NetworkCloudVirtualMachineData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeNetworkCloudVirtualMachineData(doc.RootElement, options);
        }

        public static implicit operator RequestContent(NetworkCloudVirtualMachineData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator NetworkCloudVirtualMachineData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeNetworkCloudVirtualMachineData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
