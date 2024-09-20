// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class WorkloadSqlRestoreContent : IUtf8JsonSerializable, IJsonModel<WorkloadSqlRestoreContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WorkloadSqlRestoreContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<WorkloadSqlRestoreContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadSqlRestoreContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WorkloadSqlRestoreContent)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ShouldUseAlternateTargetLocation))
            {
                writer.WritePropertyName("shouldUseAlternateTargetLocation"u8);
                writer.WriteBooleanValue(ShouldUseAlternateTargetLocation.Value);
            }
            if (Optional.IsDefined(IsNonRecoverable))
            {
                writer.WritePropertyName("isNonRecoverable"u8);
                writer.WriteBooleanValue(IsNonRecoverable.Value);
            }
            if (Optional.IsCollectionDefined(AlternateDirectoryPaths))
            {
                writer.WritePropertyName("alternateDirectoryPaths"u8);
                writer.WriteStartArray();
                foreach (var item in AlternateDirectoryPaths)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(RecoveryType))
            {
                writer.WritePropertyName("recoveryType"u8);
                writer.WriteStringValue(RecoveryType.Value.ToString());
            }
            if (Optional.IsDefined(SourceResourceId))
            {
                writer.WritePropertyName("sourceResourceId"u8);
                writer.WriteStringValue(SourceResourceId);
            }
            if (Optional.IsCollectionDefined(PropertyBag))
            {
                writer.WritePropertyName("propertyBag"u8);
                writer.WriteStartObject();
                foreach (var item in PropertyBag)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(TargetInfo))
            {
                writer.WritePropertyName("targetInfo"u8);
                writer.WriteObjectValue(TargetInfo, options);
            }
            if (Optional.IsDefined(RecoveryMode))
            {
                writer.WritePropertyName("recoveryMode"u8);
                writer.WriteStringValue(RecoveryMode.Value.ToString());
            }
            if (Optional.IsDefined(TargetResourceGroupName))
            {
                writer.WritePropertyName("targetResourceGroupName"u8);
                writer.WriteStringValue(TargetResourceGroupName);
            }
            if (Optional.IsDefined(UserAssignedManagedIdentityDetails))
            {
                writer.WritePropertyName("userAssignedManagedIdentityDetails"u8);
                writer.WriteObjectValue(UserAssignedManagedIdentityDetails, options);
            }
            if (Optional.IsDefined(SnapshotRestoreParameters))
            {
                writer.WritePropertyName("snapshotRestoreParameters"u8);
                writer.WriteObjectValue(SnapshotRestoreParameters, options);
            }
            if (Optional.IsDefined(TargetVirtualMachineId))
            {
                writer.WritePropertyName("targetVirtualMachineId"u8);
                writer.WriteStringValue(TargetVirtualMachineId);
            }
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType);
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

        WorkloadSqlRestoreContent IJsonModel<WorkloadSqlRestoreContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadSqlRestoreContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WorkloadSqlRestoreContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWorkloadSqlRestoreContent(document.RootElement, options);
        }

        internal static WorkloadSqlRestoreContent DeserializeWorkloadSqlRestoreContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("objectType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureWorkloadSQLPointInTimeRestoreRequest": return WorkloadSqlPointInTimeRestoreContent.DeserializeWorkloadSqlPointInTimeRestoreContent(element, options);
                    case "AzureWorkloadSQLPointInTimeRestoreWithRehydrateRequest": return WorkloadSqlPointInTimeRestoreWithRehydrateContent.DeserializeWorkloadSqlPointInTimeRestoreWithRehydrateContent(element, options);
                    case "AzureWorkloadSQLRestoreWithRehydrateRequest": return WorkloadSqlRestoreWithRehydrateContent.DeserializeWorkloadSqlRestoreWithRehydrateContent(element, options);
                }
            }
            bool? shouldUseAlternateTargetLocation = default;
            bool? isNonRecoverable = default;
            IList<SqlDataDirectoryMapping> alternateDirectoryPaths = default;
            FileShareRecoveryType? recoveryType = default;
            ResourceIdentifier sourceResourceId = default;
            IDictionary<string, string> propertyBag = default;
            TargetRestoreInfo targetInfo = default;
            RecoveryMode? recoveryMode = default;
            string targetResourceGroupName = default;
            UserAssignedManagedIdentityDetails userAssignedManagedIdentityDetails = default;
            SnapshotRestoreContent snapshotRestoreParameters = default;
            ResourceIdentifier targetVirtualMachineId = default;
            string objectType = "AzureWorkloadSQLRestoreRequest";
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("shouldUseAlternateTargetLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    shouldUseAlternateTargetLocation = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isNonRecoverable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isNonRecoverable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("alternateDirectoryPaths"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SqlDataDirectoryMapping> array = new List<SqlDataDirectoryMapping>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SqlDataDirectoryMapping.DeserializeSqlDataDirectoryMapping(item, options));
                    }
                    alternateDirectoryPaths = array;
                    continue;
                }
                if (property.NameEquals("recoveryType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryType = new FileShareRecoveryType(property.Value.GetString());
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
                if (property.NameEquals("propertyBag"u8))
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
                    propertyBag = dictionary;
                    continue;
                }
                if (property.NameEquals("targetInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetInfo = TargetRestoreInfo.DeserializeTargetRestoreInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("recoveryMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryMode = new RecoveryMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetResourceGroupName"u8))
                {
                    targetResourceGroupName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("userAssignedManagedIdentityDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    userAssignedManagedIdentityDetails = UserAssignedManagedIdentityDetails.DeserializeUserAssignedManagedIdentityDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("snapshotRestoreParameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    snapshotRestoreParameters = SnapshotRestoreContent.DeserializeSnapshotRestoreContent(property.Value, options);
                    continue;
                }
                if (property.NameEquals("targetVirtualMachineId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetVirtualMachineId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("objectType"u8))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new WorkloadSqlRestoreContent(
                objectType,
                serializedAdditionalRawData,
                recoveryType,
                sourceResourceId,
                propertyBag ?? new ChangeTrackingDictionary<string, string>(),
                targetInfo,
                recoveryMode,
                targetResourceGroupName,
                userAssignedManagedIdentityDetails,
                snapshotRestoreParameters,
                targetVirtualMachineId,
                shouldUseAlternateTargetLocation,
                isNonRecoverable,
                alternateDirectoryPaths ?? new ChangeTrackingList<SqlDataDirectoryMapping>());
        }

        BinaryData IPersistableModel<WorkloadSqlRestoreContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadSqlRestoreContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(WorkloadSqlRestoreContent)} does not support writing '{options.Format}' format.");
            }
        }

        WorkloadSqlRestoreContent IPersistableModel<WorkloadSqlRestoreContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadSqlRestoreContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWorkloadSqlRestoreContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WorkloadSqlRestoreContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<WorkloadSqlRestoreContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
