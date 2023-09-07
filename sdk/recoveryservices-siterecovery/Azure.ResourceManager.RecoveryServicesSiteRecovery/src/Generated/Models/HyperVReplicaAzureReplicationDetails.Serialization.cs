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

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class HyperVReplicaAzureReplicationDetails : IUtf8JsonSerializable, IModelJsonSerializable<HyperVReplicaAzureReplicationDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<HyperVReplicaAzureReplicationDetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<HyperVReplicaAzureReplicationDetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HyperVReplicaAzureReplicationDetails>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(AzureVmDiskDetails))
            {
                writer.WritePropertyName("azureVmDiskDetails"u8);
                writer.WriteStartArray();
                foreach (var item in AzureVmDiskDetails)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<SiteRecoveryVmDiskDetails>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(RecoveryAzureVmName))
            {
                writer.WritePropertyName("recoveryAzureVmName"u8);
                writer.WriteStringValue(RecoveryAzureVmName);
            }
            if (Optional.IsDefined(RecoveryAzureVmSize))
            {
                writer.WritePropertyName("recoveryAzureVMSize"u8);
                writer.WriteStringValue(RecoveryAzureVmSize);
            }
            if (Optional.IsDefined(RecoveryAzureStorageAccount))
            {
                writer.WritePropertyName("recoveryAzureStorageAccount"u8);
                writer.WriteStringValue(RecoveryAzureStorageAccount);
            }
            if (Optional.IsDefined(RecoveryAzureLogStorageAccountId))
            {
                writer.WritePropertyName("recoveryAzureLogStorageAccountId"u8);
                writer.WriteStringValue(RecoveryAzureLogStorageAccountId);
            }
            if (Optional.IsDefined(LastReplicatedOn))
            {
                writer.WritePropertyName("lastReplicatedTime"u8);
                writer.WriteStringValue(LastReplicatedOn.Value, "O");
            }
            if (Optional.IsDefined(RpoInSeconds))
            {
                writer.WritePropertyName("rpoInSeconds"u8);
                writer.WriteNumberValue(RpoInSeconds.Value);
            }
            if (Optional.IsDefined(LastRpoCalculatedOn))
            {
                writer.WritePropertyName("lastRpoCalculatedTime"u8);
                writer.WriteStringValue(LastRpoCalculatedOn.Value, "O");
            }
            if (Optional.IsDefined(VmId))
            {
                writer.WritePropertyName("vmId"u8);
                writer.WriteStringValue(VmId);
            }
            if (Optional.IsDefined(VmProtectionState))
            {
                writer.WritePropertyName("vmProtectionState"u8);
                writer.WriteStringValue(VmProtectionState);
            }
            if (Optional.IsDefined(VmProtectionStateDescription))
            {
                writer.WritePropertyName("vmProtectionStateDescription"u8);
                writer.WriteStringValue(VmProtectionStateDescription);
            }
            if (Optional.IsDefined(InitialReplicationDetails))
            {
                writer.WritePropertyName("initialReplicationDetails"u8);
                if (InitialReplicationDetails is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<InitialReplicationDetails>)InitialReplicationDetails).Serialize(writer, options);
                }
            }
            if (Optional.IsCollectionDefined(VmNics))
            {
                writer.WritePropertyName("vmNics"u8);
                writer.WriteStartArray();
                foreach (var item in VmNics)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<VmNicDetails>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SelectedRecoveryAzureNetworkId))
            {
                writer.WritePropertyName("selectedRecoveryAzureNetworkId"u8);
                writer.WriteStringValue(SelectedRecoveryAzureNetworkId);
            }
            if (Optional.IsDefined(SelectedSourceNicId))
            {
                writer.WritePropertyName("selectedSourceNicId"u8);
                writer.WriteStringValue(SelectedSourceNicId);
            }
            if (Optional.IsDefined(Encryption))
            {
                writer.WritePropertyName("encryption"u8);
                writer.WriteStringValue(Encryption);
            }
            if (Optional.IsDefined(OSDetails))
            {
                writer.WritePropertyName("oSDetails"u8);
                if (OSDetails is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<SiteRecoveryOSDetails>)OSDetails).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(SourceVmRamSizeInMB))
            {
                writer.WritePropertyName("sourceVmRamSizeInMB"u8);
                writer.WriteNumberValue(SourceVmRamSizeInMB.Value);
            }
            if (Optional.IsDefined(SourceVmCpuCount))
            {
                writer.WritePropertyName("sourceVmCpuCount"u8);
                writer.WriteNumberValue(SourceVmCpuCount.Value);
            }
            if (Optional.IsDefined(EnableRdpOnTargetOption))
            {
                writer.WritePropertyName("enableRdpOnTargetOption"u8);
                writer.WriteStringValue(EnableRdpOnTargetOption);
            }
            if (Optional.IsDefined(RecoveryAzureResourceGroupId))
            {
                writer.WritePropertyName("recoveryAzureResourceGroupId"u8);
                writer.WriteStringValue(RecoveryAzureResourceGroupId);
            }
            if (Optional.IsDefined(RecoveryAvailabilitySetId))
            {
                writer.WritePropertyName("recoveryAvailabilitySetId"u8);
                writer.WriteStringValue(RecoveryAvailabilitySetId);
            }
            if (Optional.IsDefined(TargetAvailabilityZone))
            {
                writer.WritePropertyName("targetAvailabilityZone"u8);
                writer.WriteStringValue(TargetAvailabilityZone);
            }
            if (Optional.IsDefined(TargetProximityPlacementGroupId))
            {
                writer.WritePropertyName("targetProximityPlacementGroupId"u8);
                writer.WriteStringValue(TargetProximityPlacementGroupId);
            }
            if (Optional.IsDefined(UseManagedDisks))
            {
                writer.WritePropertyName("useManagedDisks"u8);
                writer.WriteStringValue(UseManagedDisks);
            }
            if (Optional.IsDefined(LicenseType))
            {
                writer.WritePropertyName("licenseType"u8);
                writer.WriteStringValue(LicenseType);
            }
            if (Optional.IsDefined(SqlServerLicenseType))
            {
                writer.WritePropertyName("sqlServerLicenseType"u8);
                writer.WriteStringValue(SqlServerLicenseType);
            }
            if (Optional.IsCollectionDefined(TargetVmTags))
            {
                writer.WritePropertyName("targetVmTags"u8);
                writer.WriteStartObject();
                foreach (var item in TargetVmTags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(SeedManagedDiskTags))
            {
                writer.WritePropertyName("seedManagedDiskTags"u8);
                writer.WriteStartObject();
                foreach (var item in SeedManagedDiskTags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(TargetManagedDiskTags))
            {
                writer.WritePropertyName("targetManagedDiskTags"u8);
                writer.WriteStartObject();
                foreach (var item in TargetManagedDiskTags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(TargetNicTags))
            {
                writer.WritePropertyName("targetNicTags"u8);
                writer.WriteStartObject();
                foreach (var item in TargetNicTags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(ProtectedManagedDisks))
            {
                writer.WritePropertyName("protectedManagedDisks"u8);
                writer.WriteStartArray();
                foreach (var item in ProtectedManagedDisks)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<HyperVReplicaAzureManagedDiskDetails>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        internal static HyperVReplicaAzureReplicationDetails DeserializeHyperVReplicaAzureReplicationDetails(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<SiteRecoveryVmDiskDetails>> azureVmDiskDetails = default;
            Optional<string> recoveryAzureVmName = default;
            Optional<string> recoveryAzureVmSize = default;
            Optional<string> recoveryAzureStorageAccount = default;
            Optional<ResourceIdentifier> recoveryAzureLogStorageAccountId = default;
            Optional<DateTimeOffset> lastReplicatedTime = default;
            Optional<long> rpoInSeconds = default;
            Optional<DateTimeOffset> lastRpoCalculatedTime = default;
            Optional<string> vmId = default;
            Optional<string> vmProtectionState = default;
            Optional<string> vmProtectionStateDescription = default;
            Optional<InitialReplicationDetails> initialReplicationDetails = default;
            Optional<IReadOnlyList<VmNicDetails>> vmNics = default;
            Optional<ResourceIdentifier> selectedRecoveryAzureNetworkId = default;
            Optional<string> selectedSourceNicId = default;
            Optional<string> encryption = default;
            Optional<SiteRecoveryOSDetails> osDetails = default;
            Optional<int> sourceVmRamSizeInMB = default;
            Optional<int> sourceVmCpuCount = default;
            Optional<string> enableRdpOnTargetOption = default;
            Optional<ResourceIdentifier> recoveryAzureResourceGroupId = default;
            Optional<ResourceIdentifier> recoveryAvailabilitySetId = default;
            Optional<string> targetAvailabilityZone = default;
            Optional<ResourceIdentifier> targetProximityPlacementGroupId = default;
            Optional<string> useManagedDisks = default;
            Optional<string> licenseType = default;
            Optional<string> sqlServerLicenseType = default;
            Optional<DateTimeOffset> lastRecoveryPointReceived = default;
            Optional<IReadOnlyDictionary<string, string>> targetVmTags = default;
            Optional<IReadOnlyDictionary<string, string>> seedManagedDiskTags = default;
            Optional<IReadOnlyDictionary<string, string>> targetManagedDiskTags = default;
            Optional<IReadOnlyDictionary<string, string>> targetNicTags = default;
            Optional<IReadOnlyList<HyperVReplicaAzureManagedDiskDetails>> protectedManagedDisks = default;
            string instanceType = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("azureVmDiskDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SiteRecoveryVmDiskDetails> array = new List<SiteRecoveryVmDiskDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SiteRecoveryVmDiskDetails.DeserializeSiteRecoveryVmDiskDetails(item));
                    }
                    azureVmDiskDetails = array;
                    continue;
                }
                if (property.NameEquals("recoveryAzureVmName"u8))
                {
                    recoveryAzureVmName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryAzureVMSize"u8))
                {
                    recoveryAzureVmSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryAzureStorageAccount"u8))
                {
                    recoveryAzureStorageAccount = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryAzureLogStorageAccountId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryAzureLogStorageAccountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("lastReplicatedTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastReplicatedTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("rpoInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rpoInSeconds = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("lastRpoCalculatedTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastRpoCalculatedTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("vmId"u8))
                {
                    vmId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vmProtectionState"u8))
                {
                    vmProtectionState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vmProtectionStateDescription"u8))
                {
                    vmProtectionStateDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("initialReplicationDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    initialReplicationDetails = InitialReplicationDetails.DeserializeInitialReplicationDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("vmNics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VmNicDetails> array = new List<VmNicDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VmNicDetails.DeserializeVmNicDetails(item));
                    }
                    vmNics = array;
                    continue;
                }
                if (property.NameEquals("selectedRecoveryAzureNetworkId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    selectedRecoveryAzureNetworkId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("selectedSourceNicId"u8))
                {
                    selectedSourceNicId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("encryption"u8))
                {
                    encryption = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("oSDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    osDetails = SiteRecoveryOSDetails.DeserializeSiteRecoveryOSDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("sourceVmRamSizeInMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceVmRamSizeInMB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("sourceVmCpuCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceVmCpuCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("enableRdpOnTargetOption"u8))
                {
                    enableRdpOnTargetOption = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryAzureResourceGroupId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryAzureResourceGroupId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recoveryAvailabilitySetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryAvailabilitySetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetAvailabilityZone"u8))
                {
                    targetAvailabilityZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetProximityPlacementGroupId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetProximityPlacementGroupId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("useManagedDisks"u8))
                {
                    useManagedDisks = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("licenseType"u8))
                {
                    licenseType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sqlServerLicenseType"u8))
                {
                    sqlServerLicenseType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastRecoveryPointReceived"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastRecoveryPointReceived = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("targetVmTags"u8))
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
                    targetVmTags = dictionary;
                    continue;
                }
                if (property.NameEquals("seedManagedDiskTags"u8))
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
                    seedManagedDiskTags = dictionary;
                    continue;
                }
                if (property.NameEquals("targetManagedDiskTags"u8))
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
                    targetManagedDiskTags = dictionary;
                    continue;
                }
                if (property.NameEquals("targetNicTags"u8))
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
                    targetNicTags = dictionary;
                    continue;
                }
                if (property.NameEquals("protectedManagedDisks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HyperVReplicaAzureManagedDiskDetails> array = new List<HyperVReplicaAzureManagedDiskDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HyperVReplicaAzureManagedDiskDetails.DeserializeHyperVReplicaAzureManagedDiskDetails(item));
                    }
                    protectedManagedDisks = array;
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new HyperVReplicaAzureReplicationDetails(instanceType, Optional.ToList(azureVmDiskDetails), recoveryAzureVmName.Value, recoveryAzureVmSize.Value, recoveryAzureStorageAccount.Value, recoveryAzureLogStorageAccountId.Value, Optional.ToNullable(lastReplicatedTime), Optional.ToNullable(rpoInSeconds), Optional.ToNullable(lastRpoCalculatedTime), vmId.Value, vmProtectionState.Value, vmProtectionStateDescription.Value, initialReplicationDetails.Value, Optional.ToList(vmNics), selectedRecoveryAzureNetworkId.Value, selectedSourceNicId.Value, encryption.Value, osDetails.Value, Optional.ToNullable(sourceVmRamSizeInMB), Optional.ToNullable(sourceVmCpuCount), enableRdpOnTargetOption.Value, recoveryAzureResourceGroupId.Value, recoveryAvailabilitySetId.Value, targetAvailabilityZone.Value, targetProximityPlacementGroupId.Value, useManagedDisks.Value, licenseType.Value, sqlServerLicenseType.Value, Optional.ToNullable(lastRecoveryPointReceived), Optional.ToDictionary(targetVmTags), Optional.ToDictionary(seedManagedDiskTags), Optional.ToDictionary(targetManagedDiskTags), Optional.ToDictionary(targetNicTags), Optional.ToList(protectedManagedDisks), serializedAdditionalRawData);
        }

        HyperVReplicaAzureReplicationDetails IModelJsonSerializable<HyperVReplicaAzureReplicationDetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HyperVReplicaAzureReplicationDetails>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeHyperVReplicaAzureReplicationDetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<HyperVReplicaAzureReplicationDetails>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HyperVReplicaAzureReplicationDetails>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        HyperVReplicaAzureReplicationDetails IModelSerializable<HyperVReplicaAzureReplicationDetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HyperVReplicaAzureReplicationDetails>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeHyperVReplicaAzureReplicationDetails(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="HyperVReplicaAzureReplicationDetails"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="HyperVReplicaAzureReplicationDetails"/> to convert. </param>
        public static implicit operator RequestContent(HyperVReplicaAzureReplicationDetails model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="HyperVReplicaAzureReplicationDetails"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator HyperVReplicaAzureReplicationDetails(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeHyperVReplicaAzureReplicationDetails(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
