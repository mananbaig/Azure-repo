// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    [ModelReaderProxy(typeof(UnknownProtectedItem))]
    public partial class BackupGenericProtectedItem : IUtf8JsonSerializable, IJsonModel<BackupGenericProtectedItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BackupGenericProtectedItem>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<BackupGenericProtectedItem>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("protectedItemType"u8);
            writer.WriteStringValue(ProtectedItemType);
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(BackupManagementType))
                {
                    writer.WritePropertyName("backupManagementType"u8);
                    writer.WriteStringValue(BackupManagementType.Value.ToString());
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(WorkloadType))
                {
                    writer.WritePropertyName("workloadType"u8);
                    writer.WriteStringValue(WorkloadType.Value.ToString());
                }
            }
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
            if (Optional.IsDefined(SoftDeleteRetentionPeriodInDays))
            {
                writer.WritePropertyName("softDeleteRetentionPeriodInDays"u8);
                writer.WriteNumberValue(SoftDeleteRetentionPeriodInDays.Value);
            }
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        BackupGenericProtectedItem IJsonModel<BackupGenericProtectedItem>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BackupGenericProtectedItem)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBackupGenericProtectedItem(document.RootElement, options);
        }

        internal static BackupGenericProtectedItem DeserializeBackupGenericProtectedItem(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

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
            return UnknownProtectedItem.DeserializeUnknownProtectedItem(element);
        }

        BinaryData IModel<BackupGenericProtectedItem>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BackupGenericProtectedItem)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        BackupGenericProtectedItem IModel<BackupGenericProtectedItem>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BackupGenericProtectedItem)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeBackupGenericProtectedItem(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<BackupGenericProtectedItem>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
