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

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class A2AReplicationIntentDetails : IUtf8JsonSerializable, IJsonModel<A2AReplicationIntentDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<A2AReplicationIntentDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<A2AReplicationIntentDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2AReplicationIntentDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(A2AReplicationIntentDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(FabricObjectId))
            {
                writer.WritePropertyName("fabricObjectId"u8);
                writer.WriteStringValue(FabricObjectId);
            }
            if (Optional.IsDefined(PrimaryLocation))
            {
                writer.WritePropertyName("primaryLocation"u8);
                writer.WriteStringValue(PrimaryLocation.Value);
            }
            if (Optional.IsDefined(RecoveryLocation))
            {
                writer.WritePropertyName("recoveryLocation"u8);
                writer.WriteStringValue(RecoveryLocation.Value);
            }
            if (Optional.IsDefined(RecoverySubscriptionId))
            {
                writer.WritePropertyName("recoverySubscriptionId"u8);
                writer.WriteStringValue(RecoverySubscriptionId);
            }
            if (Optional.IsCollectionDefined(VmDisks))
            {
                writer.WritePropertyName("vmDisks"u8);
                writer.WriteStartArray();
                foreach (var item in VmDisks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(VmManagedDisks))
            {
                writer.WritePropertyName("vmManagedDisks"u8);
                writer.WriteStartArray();
                foreach (var item in VmManagedDisks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(RecoveryResourceGroupId))
            {
                writer.WritePropertyName("recoveryResourceGroupId"u8);
                writer.WriteStringValue(RecoveryResourceGroupId);
            }
            if (Optional.IsDefined(ProtectionProfile))
            {
                writer.WritePropertyName("protectionProfile"u8);
                writer.WriteObjectValue(ProtectionProfile);
            }
            if (Optional.IsDefined(PrimaryStagingStorageAccount))
            {
                writer.WritePropertyName("primaryStagingStorageAccount"u8);
                writer.WriteObjectValue(PrimaryStagingStorageAccount);
            }
            if (Optional.IsDefined(RecoveryAvailabilitySet))
            {
                writer.WritePropertyName("recoveryAvailabilitySet"u8);
                writer.WriteObjectValue(RecoveryAvailabilitySet);
            }
            if (Optional.IsDefined(RecoveryVirtualNetwork))
            {
                writer.WritePropertyName("recoveryVirtualNetwork"u8);
                writer.WriteObjectValue(RecoveryVirtualNetwork);
            }
            if (Optional.IsDefined(RecoveryProximityPlacementGroup))
            {
                writer.WritePropertyName("recoveryProximityPlacementGroup"u8);
                writer.WriteObjectValue(RecoveryProximityPlacementGroup);
            }
            if (Optional.IsDefined(AutoProtectionOfDataDisk))
            {
                writer.WritePropertyName("autoProtectionOfDataDisk"u8);
                writer.WriteStringValue(AutoProtectionOfDataDisk.Value.ToString());
            }
            if (Optional.IsDefined(MultiVmGroupName))
            {
                writer.WritePropertyName("multiVmGroupName"u8);
                writer.WriteStringValue(MultiVmGroupName);
            }
            if (Optional.IsDefined(MultiVmGroupId))
            {
                writer.WritePropertyName("multiVmGroupId"u8);
                writer.WriteStringValue(MultiVmGroupId);
            }
            if (Optional.IsDefined(RecoveryBootDiagStorageAccount))
            {
                writer.WritePropertyName("recoveryBootDiagStorageAccount"u8);
                writer.WriteObjectValue(RecoveryBootDiagStorageAccount);
            }
            if (Optional.IsDefined(DiskEncryptionInfo))
            {
                writer.WritePropertyName("diskEncryptionInfo"u8);
                writer.WriteObjectValue(DiskEncryptionInfo);
            }
            if (Optional.IsDefined(RecoveryAvailabilityZone))
            {
                writer.WritePropertyName("recoveryAvailabilityZone"u8);
                writer.WriteStringValue(RecoveryAvailabilityZone);
            }
            writer.WritePropertyName("recoveryAvailabilityType"u8);
            writer.WriteStringValue(RecoveryAvailabilityType);
            if (Optional.IsDefined(AgentAutoUpdateStatus))
            {
                writer.WritePropertyName("agentAutoUpdateStatus"u8);
                writer.WriteStringValue(AgentAutoUpdateStatus.Value.ToString());
            }
            if (Optional.IsDefined(AutomationAccountArmId))
            {
                writer.WritePropertyName("automationAccountArmId"u8);
                writer.WriteStringValue(AutomationAccountArmId);
            }
            if (Optional.IsDefined(AutomationAccountAuthenticationType))
            {
                writer.WritePropertyName("automationAccountAuthenticationType"u8);
                writer.WriteStringValue(AutomationAccountAuthenticationType.Value.ToString());
            }
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        A2AReplicationIntentDetails IJsonModel<A2AReplicationIntentDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2AReplicationIntentDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(A2AReplicationIntentDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeA2AReplicationIntentDetails(document.RootElement, options);
        }

        internal static A2AReplicationIntentDetails DeserializeA2AReplicationIntentDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> fabricObjectId = default;
            Optional<AzureLocation> primaryLocation = default;
            Optional<AzureLocation> recoveryLocation = default;
            Optional<string> recoverySubscriptionId = default;
            Optional<IReadOnlyList<A2AProtectionIntentDiskDetails>> vmDisks = default;
            Optional<IReadOnlyList<A2AProtectionIntentManagedDiskDetails>> vmManagedDisks = default;
            Optional<ResourceIdentifier> recoveryResourceGroupId = default;
            Optional<ProtectionProfileCustomDetails> protectionProfile = default;
            Optional<StorageAccountCustomDetails> primaryStagingStorageAccount = default;
            Optional<RecoveryAvailabilitySetCustomDetails> recoveryAvailabilitySet = default;
            Optional<RecoveryVirtualNetworkCustomDetails> recoveryVirtualNetwork = default;
            Optional<RecoveryProximityPlacementGroupCustomDetails> recoveryProximityPlacementGroup = default;
            Optional<AutoProtectionOfDataDisk> autoProtectionOfDataDisk = default;
            Optional<string> multiVmGroupName = default;
            Optional<string> multiVmGroupId = default;
            Optional<StorageAccountCustomDetails> recoveryBootDiagStorageAccount = default;
            Optional<SiteRecoveryDiskEncryptionInfo> diskEncryptionInfo = default;
            Optional<string> recoveryAvailabilityZone = default;
            string recoveryAvailabilityType = default;
            Optional<SiteRecoveryAgentAutoUpdateStatus> agentAutoUpdateStatus = default;
            Optional<ResourceIdentifier> automationAccountArmId = default;
            Optional<AutomationAccountAuthenticationType> automationAccountAuthenticationType = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("fabricObjectId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fabricObjectId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("primaryLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryLocation = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recoveryLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryLocation = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recoverySubscriptionId"u8))
                {
                    recoverySubscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vmDisks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<A2AProtectionIntentDiskDetails> array = new List<A2AProtectionIntentDiskDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(A2AProtectionIntentDiskDetails.DeserializeA2AProtectionIntentDiskDetails(item));
                    }
                    vmDisks = array;
                    continue;
                }
                if (property.NameEquals("vmManagedDisks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<A2AProtectionIntentManagedDiskDetails> array = new List<A2AProtectionIntentManagedDiskDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(A2AProtectionIntentManagedDiskDetails.DeserializeA2AProtectionIntentManagedDiskDetails(item));
                    }
                    vmManagedDisks = array;
                    continue;
                }
                if (property.NameEquals("recoveryResourceGroupId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryResourceGroupId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("protectionProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protectionProfile = ProtectionProfileCustomDetails.DeserializeProtectionProfileCustomDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("primaryStagingStorageAccount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryStagingStorageAccount = StorageAccountCustomDetails.DeserializeStorageAccountCustomDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("recoveryAvailabilitySet"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryAvailabilitySet = RecoveryAvailabilitySetCustomDetails.DeserializeRecoveryAvailabilitySetCustomDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("recoveryVirtualNetwork"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryVirtualNetwork = RecoveryVirtualNetworkCustomDetails.DeserializeRecoveryVirtualNetworkCustomDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("recoveryProximityPlacementGroup"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryProximityPlacementGroup = RecoveryProximityPlacementGroupCustomDetails.DeserializeRecoveryProximityPlacementGroupCustomDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("autoProtectionOfDataDisk"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    autoProtectionOfDataDisk = new AutoProtectionOfDataDisk(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("multiVmGroupName"u8))
                {
                    multiVmGroupName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("multiVmGroupId"u8))
                {
                    multiVmGroupId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryBootDiagStorageAccount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryBootDiagStorageAccount = StorageAccountCustomDetails.DeserializeStorageAccountCustomDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("diskEncryptionInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskEncryptionInfo = SiteRecoveryDiskEncryptionInfo.DeserializeSiteRecoveryDiskEncryptionInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("recoveryAvailabilityZone"u8))
                {
                    recoveryAvailabilityZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryAvailabilityType"u8))
                {
                    recoveryAvailabilityType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("agentAutoUpdateStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    agentAutoUpdateStatus = new SiteRecoveryAgentAutoUpdateStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("automationAccountArmId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    automationAccountArmId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("automationAccountAuthenticationType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    automationAccountAuthenticationType = new AutomationAccountAuthenticationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new A2AReplicationIntentDetails(instanceType, serializedAdditionalRawData, fabricObjectId.Value, Optional.ToNullable(primaryLocation), Optional.ToNullable(recoveryLocation), recoverySubscriptionId.Value, Optional.ToList(vmDisks), Optional.ToList(vmManagedDisks), recoveryResourceGroupId.Value, protectionProfile.Value, primaryStagingStorageAccount.Value, recoveryAvailabilitySet.Value, recoveryVirtualNetwork.Value, recoveryProximityPlacementGroup.Value, Optional.ToNullable(autoProtectionOfDataDisk), multiVmGroupName.Value, multiVmGroupId.Value, recoveryBootDiagStorageAccount.Value, diskEncryptionInfo.Value, recoveryAvailabilityZone.Value, recoveryAvailabilityType, Optional.ToNullable(agentAutoUpdateStatus), automationAccountArmId.Value, Optional.ToNullable(automationAccountAuthenticationType));
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(FabricObjectId))
            {
                builder.Append("  fabricObjectId:");
                builder.AppendLine($" '{FabricObjectId.ToString()}'");
            }

            if (Optional.IsDefined(PrimaryLocation))
            {
                builder.Append("  primaryLocation:");
                builder.AppendLine($" '{PrimaryLocation.Value.ToString()}'");
            }

            if (Optional.IsDefined(RecoveryLocation))
            {
                builder.Append("  recoveryLocation:");
                builder.AppendLine($" '{RecoveryLocation.Value.ToString()}'");
            }

            if (Optional.IsDefined(RecoverySubscriptionId))
            {
                builder.Append("  recoverySubscriptionId:");
                builder.AppendLine($" '{RecoverySubscriptionId}'");
            }

            if (Optional.IsCollectionDefined(VmDisks))
            {
                if (VmDisks.Any())
                {
                    builder.Append("  vmDisks:");
                    builder.AppendLine(" [");
                    foreach (var item in VmDisks)
                    {
                        AppendChildObject(builder, item, options, 4, true);
                    }
                    builder.AppendLine("  ]");
                }
            }

            if (Optional.IsCollectionDefined(VmManagedDisks))
            {
                if (VmManagedDisks.Any())
                {
                    builder.Append("  vmManagedDisks:");
                    builder.AppendLine(" [");
                    foreach (var item in VmManagedDisks)
                    {
                        AppendChildObject(builder, item, options, 4, true);
                    }
                    builder.AppendLine("  ]");
                }
            }

            if (Optional.IsDefined(RecoveryResourceGroupId))
            {
                builder.Append("  recoveryResourceGroupId:");
                builder.AppendLine($" '{RecoveryResourceGroupId.ToString()}'");
            }

            if (Optional.IsDefined(ProtectionProfile))
            {
                builder.Append("  protectionProfile:");
                AppendChildObject(builder, ProtectionProfile, options, 2, false);
            }

            if (Optional.IsDefined(PrimaryStagingStorageAccount))
            {
                builder.Append("  primaryStagingStorageAccount:");
                AppendChildObject(builder, PrimaryStagingStorageAccount, options, 2, false);
            }

            if (Optional.IsDefined(RecoveryAvailabilitySet))
            {
                builder.Append("  recoveryAvailabilitySet:");
                AppendChildObject(builder, RecoveryAvailabilitySet, options, 2, false);
            }

            if (Optional.IsDefined(RecoveryVirtualNetwork))
            {
                builder.Append("  recoveryVirtualNetwork:");
                AppendChildObject(builder, RecoveryVirtualNetwork, options, 2, false);
            }

            if (Optional.IsDefined(RecoveryProximityPlacementGroup))
            {
                builder.Append("  recoveryProximityPlacementGroup:");
                AppendChildObject(builder, RecoveryProximityPlacementGroup, options, 2, false);
            }

            if (Optional.IsDefined(AutoProtectionOfDataDisk))
            {
                builder.Append("  autoProtectionOfDataDisk:");
                builder.AppendLine($" '{AutoProtectionOfDataDisk.ToString()}'");
            }

            if (Optional.IsDefined(MultiVmGroupName))
            {
                builder.Append("  multiVmGroupName:");
                builder.AppendLine($" '{MultiVmGroupName}'");
            }

            if (Optional.IsDefined(MultiVmGroupId))
            {
                builder.Append("  multiVmGroupId:");
                builder.AppendLine($" '{MultiVmGroupId}'");
            }

            if (Optional.IsDefined(RecoveryBootDiagStorageAccount))
            {
                builder.Append("  recoveryBootDiagStorageAccount:");
                AppendChildObject(builder, RecoveryBootDiagStorageAccount, options, 2, false);
            }

            if (Optional.IsDefined(DiskEncryptionInfo))
            {
                builder.Append("  diskEncryptionInfo:");
                AppendChildObject(builder, DiskEncryptionInfo, options, 2, false);
            }

            if (Optional.IsDefined(RecoveryAvailabilityZone))
            {
                builder.Append("  recoveryAvailabilityZone:");
                builder.AppendLine($" '{RecoveryAvailabilityZone}'");
            }

            if (Optional.IsDefined(RecoveryAvailabilityType))
            {
                builder.Append("  recoveryAvailabilityType:");
                builder.AppendLine($" '{RecoveryAvailabilityType}'");
            }

            if (Optional.IsDefined(AgentAutoUpdateStatus))
            {
                builder.Append("  agentAutoUpdateStatus:");
                builder.AppendLine($" '{AgentAutoUpdateStatus.ToString()}'");
            }

            if (Optional.IsDefined(AutomationAccountArmId))
            {
                builder.Append("  automationAccountArmId:");
                builder.AppendLine($" '{AutomationAccountArmId.ToString()}'");
            }

            if (Optional.IsDefined(AutomationAccountAuthenticationType))
            {
                builder.Append("  automationAccountAuthenticationType:");
                builder.AppendLine($" '{AutomationAccountAuthenticationType.ToString()}'");
            }

            if (Optional.IsDefined(InstanceType))
            {
                builder.Append("  instanceType:");
                builder.AppendLine($" '{InstanceType}'");
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

        BinaryData IPersistableModel<A2AReplicationIntentDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2AReplicationIntentDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(A2AReplicationIntentDetails)} does not support '{options.Format}' format.");
            }
        }

        A2AReplicationIntentDetails IPersistableModel<A2AReplicationIntentDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2AReplicationIntentDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeA2AReplicationIntentDetails(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(A2AReplicationIntentDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<A2AReplicationIntentDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
