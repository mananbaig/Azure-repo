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
    public partial class HyperVReplicaAzureEnableProtectionContent : IUtf8JsonSerializable, IModelJsonSerializable<HyperVReplicaAzureEnableProtectionContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<HyperVReplicaAzureEnableProtectionContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<HyperVReplicaAzureEnableProtectionContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HyperVReplicaAzureEnableProtectionContent>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(HyperVHostVmId))
            {
                writer.WritePropertyName("hvHostVmId"u8);
                writer.WriteStringValue(HyperVHostVmId);
            }
            if (Optional.IsDefined(VmName))
            {
                writer.WritePropertyName("vmName"u8);
                writer.WriteStringValue(VmName);
            }
            if (Optional.IsDefined(OSType))
            {
                writer.WritePropertyName("osType"u8);
                writer.WriteStringValue(OSType);
            }
            if (Optional.IsDefined(VhdId))
            {
                writer.WritePropertyName("vhdId"u8);
                writer.WriteStringValue(VhdId);
            }
            if (Optional.IsDefined(TargetStorageAccountId))
            {
                writer.WritePropertyName("targetStorageAccountId"u8);
                writer.WriteStringValue(TargetStorageAccountId);
            }
            if (Optional.IsDefined(TargetAzureNetworkId))
            {
                writer.WritePropertyName("targetAzureNetworkId"u8);
                writer.WriteStringValue(TargetAzureNetworkId);
            }
            if (Optional.IsDefined(TargetAzureSubnetId))
            {
                writer.WritePropertyName("targetAzureSubnetId"u8);
                writer.WriteStringValue(TargetAzureSubnetId);
            }
            if (Optional.IsDefined(EnableRdpOnTargetOption))
            {
                writer.WritePropertyName("enableRdpOnTargetOption"u8);
                writer.WriteStringValue(EnableRdpOnTargetOption);
            }
            if (Optional.IsDefined(TargetAzureVmName))
            {
                writer.WritePropertyName("targetAzureVmName"u8);
                writer.WriteStringValue(TargetAzureVmName);
            }
            if (Optional.IsDefined(LogStorageAccountId))
            {
                writer.WritePropertyName("logStorageAccountId"u8);
                writer.WriteStringValue(LogStorageAccountId);
            }
            if (Optional.IsCollectionDefined(DisksToInclude))
            {
                writer.WritePropertyName("disksToInclude"u8);
                writer.WriteStartArray();
                foreach (var item in DisksToInclude)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(TargetAzureV1ResourceGroupId))
            {
                writer.WritePropertyName("targetAzureV1ResourceGroupId"u8);
                writer.WriteStringValue(TargetAzureV1ResourceGroupId);
            }
            if (Optional.IsDefined(TargetAzureV2ResourceGroupId))
            {
                writer.WritePropertyName("targetAzureV2ResourceGroupId"u8);
                writer.WriteStringValue(TargetAzureV2ResourceGroupId);
            }
            if (Optional.IsDefined(UseManagedDisks))
            {
                writer.WritePropertyName("useManagedDisks"u8);
                writer.WriteStringValue(UseManagedDisks);
            }
            if (Optional.IsDefined(TargetAvailabilitySetId))
            {
                writer.WritePropertyName("targetAvailabilitySetId"u8);
                writer.WriteStringValue(TargetAvailabilitySetId);
            }
            if (Optional.IsDefined(TargetAvailabilityZone))
            {
                writer.WritePropertyName("targetAvailabilityZone"u8);
                writer.WriteStringValue(TargetAvailabilityZone);
            }
            if (Optional.IsDefined(LicenseType))
            {
                writer.WritePropertyName("licenseType"u8);
                writer.WriteStringValue(LicenseType.Value.ToString());
            }
            if (Optional.IsDefined(SqlServerLicenseType))
            {
                writer.WritePropertyName("sqlServerLicenseType"u8);
                writer.WriteStringValue(SqlServerLicenseType.Value.ToString());
            }
            if (Optional.IsDefined(TargetVmSize))
            {
                writer.WritePropertyName("targetVmSize"u8);
                writer.WriteStringValue(TargetVmSize);
            }
            if (Optional.IsDefined(TargetProximityPlacementGroupId))
            {
                writer.WritePropertyName("targetProximityPlacementGroupId"u8);
                writer.WriteStringValue(TargetProximityPlacementGroupId);
            }
            if (Optional.IsDefined(UseManagedDisksForReplication))
            {
                writer.WritePropertyName("useManagedDisksForReplication"u8);
                writer.WriteStringValue(UseManagedDisksForReplication);
            }
            if (Optional.IsDefined(DiskType))
            {
                writer.WritePropertyName("diskType"u8);
                writer.WriteStringValue(DiskType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(DisksToIncludeForManagedDisks))
            {
                writer.WritePropertyName("disksToIncludeForManagedDisks"u8);
                writer.WriteStartArray();
                foreach (var item in DisksToIncludeForManagedDisks)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<HyperVReplicaAzureDiskDetails>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DiskEncryptionSetId))
            {
                writer.WritePropertyName("diskEncryptionSetId"u8);
                writer.WriteStringValue(DiskEncryptionSetId);
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

        internal static HyperVReplicaAzureEnableProtectionContent DeserializeHyperVReplicaAzureEnableProtectionContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> hvHostVmId = default;
            Optional<string> vmName = default;
            Optional<string> osType = default;
            Optional<string> vhdId = default;
            Optional<ResourceIdentifier> targetStorageAccountId = default;
            Optional<ResourceIdentifier> targetAzureNetworkId = default;
            Optional<ResourceIdentifier> targetAzureSubnetId = default;
            Optional<string> enableRdpOnTargetOption = default;
            Optional<string> targetAzureVmName = default;
            Optional<ResourceIdentifier> logStorageAccountId = default;
            Optional<IList<string>> disksToInclude = default;
            Optional<ResourceIdentifier> targetAzureV1ResourceGroupId = default;
            Optional<ResourceIdentifier> targetAzureV2ResourceGroupId = default;
            Optional<string> useManagedDisks = default;
            Optional<ResourceIdentifier> targetAvailabilitySetId = default;
            Optional<string> targetAvailabilityZone = default;
            Optional<SiteRecoveryLicenseType> licenseType = default;
            Optional<SiteRecoverySqlServerLicenseType> sqlServerLicenseType = default;
            Optional<string> targetVmSize = default;
            Optional<ResourceIdentifier> targetProximityPlacementGroupId = default;
            Optional<string> useManagedDisksForReplication = default;
            Optional<SiteRecoveryDiskAccountType> diskType = default;
            Optional<IList<HyperVReplicaAzureDiskDetails>> disksToIncludeForManagedDisks = default;
            Optional<ResourceIdentifier> diskEncryptionSetId = default;
            Optional<IDictionary<string, string>> targetVmTags = default;
            Optional<IDictionary<string, string>> seedManagedDiskTags = default;
            Optional<IDictionary<string, string>> targetManagedDiskTags = default;
            Optional<IDictionary<string, string>> targetNicTags = default;
            string instanceType = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hvHostVmId"u8))
                {
                    hvHostVmId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vmName"u8))
                {
                    vmName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("osType"u8))
                {
                    osType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vhdId"u8))
                {
                    vhdId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetStorageAccountId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetStorageAccountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetAzureNetworkId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetAzureNetworkId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetAzureSubnetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetAzureSubnetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("enableRdpOnTargetOption"u8))
                {
                    enableRdpOnTargetOption = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetAzureVmName"u8))
                {
                    targetAzureVmName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("logStorageAccountId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logStorageAccountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("disksToInclude"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    disksToInclude = array;
                    continue;
                }
                if (property.NameEquals("targetAzureV1ResourceGroupId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetAzureV1ResourceGroupId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetAzureV2ResourceGroupId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetAzureV2ResourceGroupId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("useManagedDisks"u8))
                {
                    useManagedDisks = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetAvailabilitySetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetAvailabilitySetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetAvailabilityZone"u8))
                {
                    targetAvailabilityZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("licenseType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    licenseType = new SiteRecoveryLicenseType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sqlServerLicenseType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sqlServerLicenseType = new SiteRecoverySqlServerLicenseType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetVmSize"u8))
                {
                    targetVmSize = property.Value.GetString();
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
                if (property.NameEquals("useManagedDisksForReplication"u8))
                {
                    useManagedDisksForReplication = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskType = new SiteRecoveryDiskAccountType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("disksToIncludeForManagedDisks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HyperVReplicaAzureDiskDetails> array = new List<HyperVReplicaAzureDiskDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HyperVReplicaAzureDiskDetails.DeserializeHyperVReplicaAzureDiskDetails(item));
                    }
                    disksToIncludeForManagedDisks = array;
                    continue;
                }
                if (property.NameEquals("diskEncryptionSetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskEncryptionSetId = new ResourceIdentifier(property.Value.GetString());
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
            return new HyperVReplicaAzureEnableProtectionContent(instanceType, hvHostVmId.Value, vmName.Value, osType.Value, vhdId.Value, targetStorageAccountId.Value, targetAzureNetworkId.Value, targetAzureSubnetId.Value, enableRdpOnTargetOption.Value, targetAzureVmName.Value, logStorageAccountId.Value, Optional.ToList(disksToInclude), targetAzureV1ResourceGroupId.Value, targetAzureV2ResourceGroupId.Value, useManagedDisks.Value, targetAvailabilitySetId.Value, targetAvailabilityZone.Value, Optional.ToNullable(licenseType), Optional.ToNullable(sqlServerLicenseType), targetVmSize.Value, targetProximityPlacementGroupId.Value, useManagedDisksForReplication.Value, Optional.ToNullable(diskType), Optional.ToList(disksToIncludeForManagedDisks), diskEncryptionSetId.Value, Optional.ToDictionary(targetVmTags), Optional.ToDictionary(seedManagedDiskTags), Optional.ToDictionary(targetManagedDiskTags), Optional.ToDictionary(targetNicTags), serializedAdditionalRawData);
        }

        HyperVReplicaAzureEnableProtectionContent IModelJsonSerializable<HyperVReplicaAzureEnableProtectionContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HyperVReplicaAzureEnableProtectionContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeHyperVReplicaAzureEnableProtectionContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<HyperVReplicaAzureEnableProtectionContent>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HyperVReplicaAzureEnableProtectionContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        HyperVReplicaAzureEnableProtectionContent IModelSerializable<HyperVReplicaAzureEnableProtectionContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HyperVReplicaAzureEnableProtectionContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeHyperVReplicaAzureEnableProtectionContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="HyperVReplicaAzureEnableProtectionContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="HyperVReplicaAzureEnableProtectionContent"/> to convert. </param>
        public static implicit operator RequestContent(HyperVReplicaAzureEnableProtectionContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="HyperVReplicaAzureEnableProtectionContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator HyperVReplicaAzureEnableProtectionContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeHyperVReplicaAzureEnableProtectionContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
