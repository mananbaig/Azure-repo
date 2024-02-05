// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class IaasVmProtectedItem : IUtf8JsonSerializable, IJsonModel<IaasVmProtectedItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IaasVmProtectedItem>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<IaasVmProtectedItem>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IaasVmProtectedItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IaasVmProtectedItem)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (options.Format != "W" && Optional.IsDefined(VirtualMachineId))
            {
                writer.WritePropertyName("virtualMachineId"u8);
                writer.WriteStringValue(VirtualMachineId);
            }
            if (Optional.IsDefined(ProtectionStatus))
            {
                writer.WritePropertyName("protectionStatus"u8);
                writer.WriteStringValue(ProtectionStatus);
            }
            if (Optional.IsDefined(ProtectionState))
            {
                writer.WritePropertyName("protectionState"u8);
                writer.WriteStringValue(ProtectionState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(HealthStatus))
            {
                writer.WritePropertyName("healthStatus"u8);
                writer.WriteStringValue(HealthStatus.Value.ToString());
            }
            if (Optional.IsCollectionDefined(HealthDetails))
            {
                writer.WritePropertyName("healthDetails"u8);
                writer.WriteStartArray();
                foreach (var item in HealthDetails)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(KpisHealths))
            {
                writer.WritePropertyName("kpisHealths"u8);
                writer.WriteStartObject();
                foreach (var item in KpisHealths)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(LastBackupStatus))
            {
                writer.WritePropertyName("lastBackupStatus"u8);
                writer.WriteStringValue(LastBackupStatus);
            }
            if (options.Format != "W" && Optional.IsDefined(LastBackupOn))
            {
                writer.WritePropertyName("lastBackupTime"u8);
                writer.WriteStringValue(LastBackupOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(ProtectedItemDataId))
            {
                writer.WritePropertyName("protectedItemDataId"u8);
                writer.WriteStringValue(ProtectedItemDataId);
            }
            if (Optional.IsDefined(ExtendedInfo))
            {
                writer.WritePropertyName("extendedInfo"u8);
                writer.WriteObjectValue(ExtendedInfo);
            }
            if (Optional.IsDefined(ExtendedProperties))
            {
                writer.WritePropertyName("extendedProperties"u8);
                writer.WriteObjectValue(ExtendedProperties);
            }
            writer.WritePropertyName("protectedItemType"u8);
            writer.WriteStringValue(ProtectedItemType);
            if (options.Format != "W" && Optional.IsDefined(BackupManagementType))
            {
                writer.WritePropertyName("backupManagementType"u8);
                writer.WriteStringValue(BackupManagementType.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(WorkloadType))
            {
                writer.WritePropertyName("workloadType"u8);
                writer.WriteStringValue(WorkloadType.Value.ToString());
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
            if (options.Format != "W" && Optional.IsDefined(VaultId))
            {
                writer.WritePropertyName("vaultId"u8);
                writer.WriteStringValue(VaultId);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
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

        IaasVmProtectedItem IJsonModel<IaasVmProtectedItem>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IaasVmProtectedItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IaasVmProtectedItem)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIaasVmProtectedItem(document.RootElement, options);
        }

        internal static IaasVmProtectedItem DeserializeIaasVmProtectedItem(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("protectedItemType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Microsoft.ClassicCompute/virtualMachines": return IaasClassicComputeVmProtectedItem.DeserializeIaasClassicComputeVmProtectedItem(element);
                    case "Microsoft.Compute/virtualMachines": return IaasComputeVmProtectedItem.DeserializeIaasComputeVmProtectedItem(element);
                }
            }
            Optional<string> friendlyName = default;
            Optional<ResourceIdentifier> virtualMachineId = default;
            Optional<string> protectionStatus = default;
            Optional<BackupProtectionState> protectionState = default;
            Optional<IaasVmProtectedItemHealthStatus> healthStatus = default;
            Optional<IList<IaasVmHealthDetails>> healthDetails = default;
            Optional<IDictionary<string, KpiResourceHealthDetails>> kpisHealths = default;
            Optional<string> lastBackupStatus = default;
            Optional<DateTimeOffset> lastBackupTime = default;
            Optional<string> protectedItemDataId = default;
            Optional<IaasVmProtectedItemExtendedInfo> extendedInfo = default;
            Optional<IaasVmBackupExtendedProperties> extendedProperties = default;
            string protectedItemType = "AzureIaaSVMProtectedItem";
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
            Optional<int> softDeleteRetentionPeriodInDays = default;
            Optional<string> vaultId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("friendlyName"u8))
                {
                    friendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("virtualMachineId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    virtualMachineId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("protectionStatus"u8))
                {
                    protectionStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectionState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protectionState = new BackupProtectionState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("healthStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    healthStatus = new IaasVmProtectedItemHealthStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("healthDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IaasVmHealthDetails> array = new List<IaasVmHealthDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IaasVmHealthDetails.DeserializeIaasVmHealthDetails(item));
                    }
                    healthDetails = array;
                    continue;
                }
                if (property.NameEquals("kpisHealths"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, KpiResourceHealthDetails> dictionary = new Dictionary<string, KpiResourceHealthDetails>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, KpiResourceHealthDetails.DeserializeKpiResourceHealthDetails(property0.Value));
                    }
                    kpisHealths = dictionary;
                    continue;
                }
                if (property.NameEquals("lastBackupStatus"u8))
                {
                    lastBackupStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastBackupTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastBackupTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("protectedItemDataId"u8))
                {
                    protectedItemDataId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("extendedInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    extendedInfo = IaasVmProtectedItemExtendedInfo.DeserializeIaasVmProtectedItemExtendedInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("extendedProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    extendedProperties = IaasVmBackupExtendedProperties.DeserializeIaasVmBackupExtendedProperties(property.Value);
                    continue;
                }
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
                if (property.NameEquals("softDeleteRetentionPeriodInDays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    softDeleteRetentionPeriodInDays = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("vaultId"u8))
                {
                    vaultId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new IaasVmProtectedItem(protectedItemType, Optional.ToNullable(backupManagementType), Optional.ToNullable(workloadType), containerName.Value, sourceResourceId.Value, policyId.Value, Optional.ToNullable(lastRecoveryPoint), backupSetName.Value, Optional.ToNullable(createMode), Optional.ToNullable(deferredDeleteTimeInUTC), Optional.ToNullable(isScheduledForDeferredDelete), deferredDeleteTimeRemaining.Value, Optional.ToNullable(isDeferredDeleteScheduleUpcoming), Optional.ToNullable(isRehydrate), Optional.ToList(resourceGuardOperationRequests), Optional.ToNullable(isArchiveEnabled), policyName.Value, Optional.ToNullable(softDeleteRetentionPeriodInDays), vaultId.Value, serializedAdditionalRawData, friendlyName.Value, virtualMachineId.Value, protectionStatus.Value, Optional.ToNullable(protectionState), Optional.ToNullable(healthStatus), Optional.ToList(healthDetails), Optional.ToDictionary(kpisHealths), lastBackupStatus.Value, Optional.ToNullable(lastBackupTime), protectedItemDataId.Value, extendedInfo.Value, extendedProperties.Value);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(FriendlyName))
            {
                builder.Append("  friendlyName:");
                builder.AppendLine($" '{FriendlyName}'");
            }

            if (Optional.IsDefined(VirtualMachineId))
            {
                builder.Append("  virtualMachineId:");
                builder.AppendLine($" '{VirtualMachineId.ToString()}'");
            }

            if (Optional.IsDefined(ProtectionStatus))
            {
                builder.Append("  protectionStatus:");
                builder.AppendLine($" '{ProtectionStatus}'");
            }

            if (Optional.IsDefined(ProtectionState))
            {
                builder.Append("  protectionState:");
                builder.AppendLine($" '{ProtectionState.ToString()}'");
            }

            if (Optional.IsDefined(HealthStatus))
            {
                builder.Append("  healthStatus:");
                builder.AppendLine($" '{HealthStatus.ToString()}'");
            }

            if (Optional.IsCollectionDefined(HealthDetails))
            {
                if (HealthDetails.Any())
                {
                    builder.Append("  healthDetails:");
                    builder.AppendLine(" [");
                    foreach (var item in HealthDetails)
                    {
                        AppendChildObject(builder, item, options, 4, true);
                    }
                    builder.AppendLine("  ]");
                }
            }

            if (Optional.IsCollectionDefined(KpisHealths))
            {
                if (KpisHealths.Any())
                {
                    builder.Append("  kpisHealths:");
                    builder.AppendLine(" {");
                    foreach (var item in KpisHealths)
                    {
                        builder.Append($"    {item.Key}: ");
                        AppendChildObject(builder, item.Value, options, 4, false);
                    }
                    builder.AppendLine("  }");
                }
            }

            if (Optional.IsDefined(LastBackupStatus))
            {
                builder.Append("  lastBackupStatus:");
                builder.AppendLine($" '{LastBackupStatus}'");
            }

            if (Optional.IsDefined(LastBackupOn))
            {
                builder.Append("  lastBackupTime:");
                var formattedDateTimeString = TypeFormatters.ToString(LastBackupOn.Value, "o");
                builder.AppendLine($" '{formattedDateTimeString}'");
            }

            if (Optional.IsDefined(ProtectedItemDataId))
            {
                builder.Append("  protectedItemDataId:");
                builder.AppendLine($" '{ProtectedItemDataId}'");
            }

            if (Optional.IsDefined(ExtendedInfo))
            {
                builder.Append("  extendedInfo:");
                AppendChildObject(builder, ExtendedInfo, options, 2, false);
            }

            if (Optional.IsDefined(ExtendedProperties))
            {
                builder.Append("  extendedProperties:");
                AppendChildObject(builder, ExtendedProperties, options, 2, false);
            }

            if (Optional.IsDefined(ProtectedItemType))
            {
                builder.Append("  protectedItemType:");
                builder.AppendLine($" '{ProtectedItemType}'");
            }

            if (Optional.IsDefined(BackupManagementType))
            {
                builder.Append("  backupManagementType:");
                builder.AppendLine($" '{BackupManagementType.ToString()}'");
            }

            if (Optional.IsDefined(WorkloadType))
            {
                builder.Append("  workloadType:");
                builder.AppendLine($" '{WorkloadType.ToString()}'");
            }

            if (Optional.IsDefined(ContainerName))
            {
                builder.Append("  containerName:");
                builder.AppendLine($" '{ContainerName}'");
            }

            if (Optional.IsDefined(SourceResourceId))
            {
                builder.Append("  sourceResourceId:");
                builder.AppendLine($" '{SourceResourceId.ToString()}'");
            }

            if (Optional.IsDefined(PolicyId))
            {
                builder.Append("  policyId:");
                builder.AppendLine($" '{PolicyId.ToString()}'");
            }

            if (Optional.IsDefined(LastRecoverOn))
            {
                builder.Append("  lastRecoveryPoint:");
                var formattedDateTimeString = TypeFormatters.ToString(LastRecoverOn.Value, "o");
                builder.AppendLine($" '{formattedDateTimeString}'");
            }

            if (Optional.IsDefined(BackupSetName))
            {
                builder.Append("  backupSetName:");
                builder.AppendLine($" '{BackupSetName}'");
            }

            if (Optional.IsDefined(CreateMode))
            {
                builder.Append("  createMode:");
                builder.AppendLine($" '{CreateMode.ToString()}'");
            }

            if (Optional.IsDefined(DeferredDeletedOn))
            {
                builder.Append("  deferredDeleteTimeInUTC:");
                var formattedDateTimeString = TypeFormatters.ToString(DeferredDeletedOn.Value, "o");
                builder.AppendLine($" '{formattedDateTimeString}'");
            }

            if (Optional.IsDefined(IsScheduledForDeferredDelete))
            {
                builder.Append("  isScheduledForDeferredDelete:");
                var boolValue = IsScheduledForDeferredDelete.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(DeferredDeleteTimeRemaining))
            {
                builder.Append("  deferredDeleteTimeRemaining:");
                builder.AppendLine($" '{DeferredDeleteTimeRemaining}'");
            }

            if (Optional.IsDefined(IsDeferredDeleteScheduleUpcoming))
            {
                builder.Append("  isDeferredDeleteScheduleUpcoming:");
                var boolValue = IsDeferredDeleteScheduleUpcoming.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(IsRehydrate))
            {
                builder.Append("  isRehydrate:");
                var boolValue = IsRehydrate.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsCollectionDefined(ResourceGuardOperationRequests))
            {
                if (ResourceGuardOperationRequests.Any())
                {
                    builder.Append("  resourceGuardOperationRequests:");
                    builder.AppendLine(" [");
                    foreach (var item in ResourceGuardOperationRequests)
                    {
                        if (item == null)
                        {
                            builder.Append("null");
                            continue;
                        }
                        builder.AppendLine($"    '{item}'");
                    }
                    builder.AppendLine("  ]");
                }
            }

            if (Optional.IsDefined(IsArchiveEnabled))
            {
                builder.Append("  isArchiveEnabled:");
                var boolValue = IsArchiveEnabled.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(PolicyName))
            {
                builder.Append("  policyName:");
                builder.AppendLine($" '{PolicyName}'");
            }

            if (Optional.IsDefined(SoftDeleteRetentionPeriodInDays))
            {
                builder.Append("  softDeleteRetentionPeriodInDays:");
                builder.AppendLine($" {SoftDeleteRetentionPeriodInDays.Value}");
            }

            if (Optional.IsDefined(VaultId))
            {
                builder.Append("  vaultId:");
                builder.AppendLine($" '{VaultId}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces, bool indentFirstLine)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (i == 0 && !indentFirstLine)
                {
                    stringBuilder.AppendLine($" {line}");
                }
                else
                {
                    stringBuilder.AppendLine($"{indent}{line}");
                }
            }
        }

        BinaryData IPersistableModel<IaasVmProtectedItem>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IaasVmProtectedItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(IaasVmProtectedItem)} does not support '{options.Format}' format.");
            }
        }

        IaasVmProtectedItem IPersistableModel<IaasVmProtectedItem>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IaasVmProtectedItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIaasVmProtectedItem(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(IaasVmProtectedItem)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<IaasVmProtectedItem>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
