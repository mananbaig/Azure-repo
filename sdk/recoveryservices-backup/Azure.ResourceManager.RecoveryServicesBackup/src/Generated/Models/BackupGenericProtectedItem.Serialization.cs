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

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class BackupGenericProtectedItem : IUtf8JsonSerializable, IModelJsonSerializable<BackupGenericProtectedItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<BackupGenericProtectedItem>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<BackupGenericProtectedItem>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BackupGenericProtectedItem>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("protectedItemType"u8);
            writer.WriteStringValue(ProtectedItemType);
            if (Optional.IsDefined(ContainerName))
            {
                writer.WritePropertyName("containerName"u8);
                writer.WriteStringValue(ContainerName);
            }
            if (Optional.IsDefined(SourceResourceId))
            {
                writer.WritePropertyName("sourceResourceId"u8);
                writer.WriteStringValue(SourceResourceId);
            }
            if (Optional.IsDefined(PolicyId))
            {
                writer.WritePropertyName("policyId"u8);
                writer.WriteStringValue(PolicyId);
            }
            if (Optional.IsDefined(LastRecoverOn))
            {
                writer.WritePropertyName("lastRecoveryPoint"u8);
                writer.WriteStringValue(LastRecoverOn.Value, "O");
            }
            if (Optional.IsDefined(BackupSetName))
            {
                writer.WritePropertyName("backupSetName"u8);
                writer.WriteStringValue(BackupSetName);
            }
            if (Optional.IsDefined(CreateMode))
            {
                writer.WritePropertyName("createMode"u8);
                writer.WriteStringValue(CreateMode.Value.ToString());
            }
            if (Optional.IsDefined(DeferredDeletedOn))
            {
                writer.WritePropertyName("deferredDeleteTimeInUTC"u8);
                writer.WriteStringValue(DeferredDeletedOn.Value, "O");
            }
            if (Optional.IsDefined(IsScheduledForDeferredDelete))
            {
                writer.WritePropertyName("isScheduledForDeferredDelete"u8);
                writer.WriteBooleanValue(IsScheduledForDeferredDelete.Value);
            }
            if (Optional.IsDefined(DeferredDeleteTimeRemaining))
            {
                writer.WritePropertyName("deferredDeleteTimeRemaining"u8);
                writer.WriteStringValue(DeferredDeleteTimeRemaining);
            }
            if (Optional.IsDefined(IsDeferredDeleteScheduleUpcoming))
            {
                writer.WritePropertyName("isDeferredDeleteScheduleUpcoming"u8);
                writer.WriteBooleanValue(IsDeferredDeleteScheduleUpcoming.Value);
            }
            if (Optional.IsDefined(IsRehydrate))
            {
                writer.WritePropertyName("isRehydrate"u8);
                writer.WriteBooleanValue(IsRehydrate.Value);
            }
            if (Optional.IsCollectionDefined(ResourceGuardOperationRequests))
            {
                writer.WritePropertyName("resourceGuardOperationRequests"u8);
                writer.WriteStartArray();
                foreach (var item in ResourceGuardOperationRequests)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsArchiveEnabled))
            {
                writer.WritePropertyName("isArchiveEnabled"u8);
                writer.WriteBooleanValue(IsArchiveEnabled.Value);
            }
            if (Optional.IsDefined(PolicyName))
            {
                writer.WritePropertyName("policyName"u8);
                writer.WriteStringValue(PolicyName);
            }
            if (Optional.IsDefined(SoftDeleteRetentionPeriod))
            {
                writer.WritePropertyName("softDeleteRetentionPeriod"u8);
                writer.WriteNumberValue(SoftDeleteRetentionPeriod.Value);
            }
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

        internal static BackupGenericProtectedItem DeserializeBackupGenericProtectedItem(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("protectedItemType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureFileShareProtectedItem": return FileshareProtectedItem.DeserializeFileshareProtectedItem(element);
                    case "AzureIaaSVMProtectedItem": return IaasVmProtectedItem.DeserializeIaasVmProtectedItem(element);
                    case "AzureVmWorkloadProtectedItem": return VmWorkloadProtectedItem.DeserializeVmWorkloadProtectedItem(element);
                    case "AzureVmWorkloadSAPAseDatabase": return VmWorkloadSapAseDatabaseProtectedItem.DeserializeVmWorkloadSapAseDatabaseProtectedItem(element);
                    case "AzureVmWorkloadSAPHanaDBInstance": return VmWorkloadSapHanaDBInstanceProtectedItem.DeserializeVmWorkloadSapHanaDBInstanceProtectedItem(element);
                    case "AzureVmWorkloadSAPHanaDatabase": return VmWorkloadSapHanaDatabaseProtectedItem.DeserializeVmWorkloadSapHanaDatabaseProtectedItem(element);
                    case "AzureVmWorkloadSQLDatabase": return VmWorkloadSqlDatabaseProtectedItem.DeserializeVmWorkloadSqlDatabaseProtectedItem(element);
                    case "DPMProtectedItem": return DpmProtectedItem.DeserializeDpmProtectedItem(element);
                    case "GenericProtectedItem": return GenericProtectedItem.DeserializeGenericProtectedItem(element);
                    case "MabFileFolderProtectedItem": return MabFileFolderProtectedItem.DeserializeMabFileFolderProtectedItem(element);
                    case "Microsoft.ClassicCompute/virtualMachines": return IaasClassicComputeVmProtectedItem.DeserializeIaasClassicComputeVmProtectedItem(element);
                    case "Microsoft.Compute/virtualMachines": return IaasComputeVmProtectedItem.DeserializeIaasComputeVmProtectedItem(element);
                    case "Microsoft.Sql/servers/databases": return SqlProtectedItem.DeserializeSqlProtectedItem(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            string protectedItemType = default;
            Optional<BackupManagementType> backupManagementType = default;
            Optional<BackupDataSourceType> workloadType = default;
            Optional<string> containerName = default;
            Optional<ResourceIdentifier> sourceResourceId = default;
            Optional<ResourceIdentifier> policyId = default;
            Optional<DateTimeOffset> lastRecoveryPoint = default;
            Optional<string> backupSetName = default;
            Optional<BackupCreateMode> createMode = default;
            Optional<DateTimeOffset> deferredDeleteTimeInUTC = default;
            Optional<bool> isScheduledForDeferredDelete = default;
            Optional<string> deferredDeleteTimeRemaining = default;
            Optional<bool> isDeferredDeleteScheduleUpcoming = default;
            Optional<bool> isRehydrate = default;
            Optional<IList<string>> resourceGuardOperationRequests = default;
            Optional<bool> isArchiveEnabled = default;
            Optional<string> policyName = default;
            Optional<int> softDeleteRetentionPeriod = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("protectedItemType"u8))
                {
                    protectedItemType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("backupManagementType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupManagementType = new BackupManagementType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("workloadType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    workloadType = new BackupDataSourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("containerName"u8))
                {
                    containerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("policyId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policyId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("lastRecoveryPoint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastRecoveryPoint = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("backupSetName"u8))
                {
                    backupSetName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createMode = new BackupCreateMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("deferredDeleteTimeInUTC"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deferredDeleteTimeInUTC = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("isScheduledForDeferredDelete"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isScheduledForDeferredDelete = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("deferredDeleteTimeRemaining"u8))
                {
                    deferredDeleteTimeRemaining = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isDeferredDeleteScheduleUpcoming"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isDeferredDeleteScheduleUpcoming = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isRehydrate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isRehydrate = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("resourceGuardOperationRequests"u8))
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
                    resourceGuardOperationRequests = array;
                    continue;
                }
                if (property.NameEquals("isArchiveEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isArchiveEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("policyName"u8))
                {
                    policyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("softDeleteRetentionPeriod"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    softDeleteRetentionPeriod = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new UnknownProtectedItem(protectedItemType, Optional.ToNullable(backupManagementType), Optional.ToNullable(workloadType), containerName.Value, sourceResourceId.Value, policyId.Value, Optional.ToNullable(lastRecoveryPoint), backupSetName.Value, Optional.ToNullable(createMode), Optional.ToNullable(deferredDeleteTimeInUTC), Optional.ToNullable(isScheduledForDeferredDelete), deferredDeleteTimeRemaining.Value, Optional.ToNullable(isDeferredDeleteScheduleUpcoming), Optional.ToNullable(isRehydrate), Optional.ToList(resourceGuardOperationRequests), Optional.ToNullable(isArchiveEnabled), policyName.Value, Optional.ToNullable(softDeleteRetentionPeriod), serializedAdditionalRawData);
        }

        BackupGenericProtectedItem IModelJsonSerializable<BackupGenericProtectedItem>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BackupGenericProtectedItem>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeBackupGenericProtectedItem(doc.RootElement, options);
        }

        BinaryData IModelSerializable<BackupGenericProtectedItem>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BackupGenericProtectedItem>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        BackupGenericProtectedItem IModelSerializable<BackupGenericProtectedItem>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BackupGenericProtectedItem>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeBackupGenericProtectedItem(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="BackupGenericProtectedItem"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="BackupGenericProtectedItem"/> to convert. </param>
        public static implicit operator RequestContent(BackupGenericProtectedItem model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="BackupGenericProtectedItem"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator BackupGenericProtectedItem(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeBackupGenericProtectedItem(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
