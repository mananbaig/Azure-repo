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
    public partial class HyperVReplicaAzureUpdateReplicationProtectedItemContent : IUtf8JsonSerializable, IModelJsonSerializable<HyperVReplicaAzureUpdateReplicationProtectedItemContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<HyperVReplicaAzureUpdateReplicationProtectedItemContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<HyperVReplicaAzureUpdateReplicationProtectedItemContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HyperVReplicaAzureUpdateReplicationProtectedItemContent>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(RecoveryAzureV1ResourceGroupId))
            {
                writer.WritePropertyName("recoveryAzureV1ResourceGroupId"u8);
                writer.WriteStringValue(RecoveryAzureV1ResourceGroupId);
            }
            if (Optional.IsDefined(RecoveryAzureV2ResourceGroupId))
            {
                writer.WritePropertyName("recoveryAzureV2ResourceGroupId"u8);
                writer.WriteStringValue(RecoveryAzureV2ResourceGroupId);
            }
            if (Optional.IsDefined(UseManagedDisks))
            {
                writer.WritePropertyName("useManagedDisks"u8);
                writer.WriteStringValue(UseManagedDisks);
            }
            if (Optional.IsCollectionDefined(DiskIdToDiskEncryptionMap))
            {
                writer.WritePropertyName("diskIdToDiskEncryptionMap"u8);
                writer.WriteStartObject();
                foreach (var item in DiskIdToDiskEncryptionMap)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(TargetProximityPlacementGroupId))
            {
                writer.WritePropertyName("targetProximityPlacementGroupId"u8);
                writer.WriteStringValue(TargetProximityPlacementGroupId);
            }
            if (Optional.IsDefined(TargetAvailabilityZone))
            {
                writer.WritePropertyName("targetAvailabilityZone"u8);
                writer.WriteStringValue(TargetAvailabilityZone);
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
            if (Optional.IsDefined(SqlServerLicenseType))
            {
                writer.WritePropertyName("sqlServerLicenseType"u8);
                writer.WriteStringValue(SqlServerLicenseType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(VmDisks))
            {
                writer.WritePropertyName("vmDisks"u8);
                writer.WriteStartArray();
                foreach (var item in VmDisks)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<UpdateDiskContent>)item).Serialize(writer, options);
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

        internal static HyperVReplicaAzureUpdateReplicationProtectedItemContent DeserializeHyperVReplicaAzureUpdateReplicationProtectedItemContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> recoveryAzureV1ResourceGroupId = default;
            Optional<ResourceIdentifier> recoveryAzureV2ResourceGroupId = default;
            Optional<string> useManagedDisks = default;
            Optional<IDictionary<string, string>> diskIdToDiskEncryptionMap = default;
            Optional<ResourceIdentifier> targetProximityPlacementGroupId = default;
            Optional<string> targetAvailabilityZone = default;
            Optional<IDictionary<string, string>> targetVmTags = default;
            Optional<IDictionary<string, string>> targetManagedDiskTags = default;
            Optional<IDictionary<string, string>> targetNicTags = default;
            Optional<SiteRecoverySqlServerLicenseType> sqlServerLicenseType = default;
            Optional<IList<UpdateDiskContent>> vmDisks = default;
            string instanceType = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recoveryAzureV1ResourceGroupId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryAzureV1ResourceGroupId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recoveryAzureV2ResourceGroupId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryAzureV2ResourceGroupId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("useManagedDisks"u8))
                {
                    useManagedDisks = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskIdToDiskEncryptionMap"u8))
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
                    diskIdToDiskEncryptionMap = dictionary;
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
                if (property.NameEquals("targetAvailabilityZone"u8))
                {
                    targetAvailabilityZone = property.Value.GetString();
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
                if (property.NameEquals("sqlServerLicenseType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sqlServerLicenseType = new SiteRecoverySqlServerLicenseType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("vmDisks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<UpdateDiskContent> array = new List<UpdateDiskContent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(UpdateDiskContent.DeserializeUpdateDiskContent(item));
                    }
                    vmDisks = array;
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
            return new HyperVReplicaAzureUpdateReplicationProtectedItemContent(instanceType, recoveryAzureV1ResourceGroupId.Value, recoveryAzureV2ResourceGroupId.Value, useManagedDisks.Value, Optional.ToDictionary(diskIdToDiskEncryptionMap), targetProximityPlacementGroupId.Value, targetAvailabilityZone.Value, Optional.ToDictionary(targetVmTags), Optional.ToDictionary(targetManagedDiskTags), Optional.ToDictionary(targetNicTags), Optional.ToNullable(sqlServerLicenseType), Optional.ToList(vmDisks), serializedAdditionalRawData);
        }

        HyperVReplicaAzureUpdateReplicationProtectedItemContent IModelJsonSerializable<HyperVReplicaAzureUpdateReplicationProtectedItemContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HyperVReplicaAzureUpdateReplicationProtectedItemContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeHyperVReplicaAzureUpdateReplicationProtectedItemContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<HyperVReplicaAzureUpdateReplicationProtectedItemContent>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HyperVReplicaAzureUpdateReplicationProtectedItemContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        HyperVReplicaAzureUpdateReplicationProtectedItemContent IModelSerializable<HyperVReplicaAzureUpdateReplicationProtectedItemContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HyperVReplicaAzureUpdateReplicationProtectedItemContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeHyperVReplicaAzureUpdateReplicationProtectedItemContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="HyperVReplicaAzureUpdateReplicationProtectedItemContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="HyperVReplicaAzureUpdateReplicationProtectedItemContent"/> to convert. </param>
        public static implicit operator RequestContent(HyperVReplicaAzureUpdateReplicationProtectedItemContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="HyperVReplicaAzureUpdateReplicationProtectedItemContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator HyperVReplicaAzureUpdateReplicationProtectedItemContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeHyperVReplicaAzureUpdateReplicationProtectedItemContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
