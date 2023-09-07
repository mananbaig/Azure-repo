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
    public partial class A2AProtectedDiskDetails : IUtf8JsonSerializable, IModelJsonSerializable<A2AProtectedDiskDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<A2AProtectedDiskDetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<A2AProtectedDiskDetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<A2AProtectedDiskDetails>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(DiskUri))
            {
                writer.WritePropertyName("diskUri"u8);
                writer.WriteStringValue(DiskUri.AbsoluteUri);
            }
            if (Optional.IsDefined(RecoveryAzureStorageAccountId))
            {
                writer.WritePropertyName("recoveryAzureStorageAccountId"u8);
                writer.WriteStringValue(RecoveryAzureStorageAccountId);
            }
            if (Optional.IsDefined(PrimaryDiskAzureStorageAccountId))
            {
                writer.WritePropertyName("primaryDiskAzureStorageAccountId"u8);
                writer.WriteStringValue(PrimaryDiskAzureStorageAccountId);
            }
            if (Optional.IsDefined(RecoveryDiskUri))
            {
                writer.WritePropertyName("recoveryDiskUri"u8);
                writer.WriteStringValue(RecoveryDiskUri.AbsoluteUri);
            }
            if (Optional.IsDefined(DiskName))
            {
                writer.WritePropertyName("diskName"u8);
                writer.WriteStringValue(DiskName);
            }
            if (Optional.IsDefined(DiskCapacityInBytes))
            {
                writer.WritePropertyName("diskCapacityInBytes"u8);
                writer.WriteNumberValue(DiskCapacityInBytes.Value);
            }
            if (Optional.IsDefined(PrimaryStagingAzureStorageAccountId))
            {
                writer.WritePropertyName("primaryStagingAzureStorageAccountId"u8);
                writer.WriteStringValue(PrimaryStagingAzureStorageAccountId);
            }
            if (Optional.IsDefined(DiskType))
            {
                writer.WritePropertyName("diskType"u8);
                writer.WriteStringValue(DiskType);
            }
            if (Optional.IsDefined(IsResyncRequired))
            {
                writer.WritePropertyName("resyncRequired"u8);
                writer.WriteBooleanValue(IsResyncRequired.Value);
            }
            if (Optional.IsDefined(MonitoringPercentageCompletion))
            {
                writer.WritePropertyName("monitoringPercentageCompletion"u8);
                writer.WriteNumberValue(MonitoringPercentageCompletion.Value);
            }
            if (Optional.IsDefined(MonitoringJobType))
            {
                writer.WritePropertyName("monitoringJobType"u8);
                writer.WriteStringValue(MonitoringJobType);
            }
            if (Optional.IsDefined(DataPendingInStagingStorageAccountInMB))
            {
                writer.WritePropertyName("dataPendingInStagingStorageAccountInMB"u8);
                writer.WriteNumberValue(DataPendingInStagingStorageAccountInMB.Value);
            }
            if (Optional.IsDefined(DataPendingAtSourceAgentInMB))
            {
                writer.WritePropertyName("dataPendingAtSourceAgentInMB"u8);
                writer.WriteNumberValue(DataPendingAtSourceAgentInMB.Value);
            }
            if (Optional.IsDefined(DiskState))
            {
                writer.WritePropertyName("diskState"u8);
                writer.WriteStringValue(DiskState);
            }
            if (Optional.IsCollectionDefined(AllowedDiskLevelOperation))
            {
                writer.WritePropertyName("allowedDiskLevelOperation"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedDiskLevelOperation)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsDiskEncrypted))
            {
                writer.WritePropertyName("isDiskEncrypted"u8);
                writer.WriteBooleanValue(IsDiskEncrypted.Value);
            }
            if (Optional.IsDefined(SecretIdentifier))
            {
                writer.WritePropertyName("secretIdentifier"u8);
                writer.WriteStringValue(SecretIdentifier);
            }
            if (Optional.IsDefined(DekKeyVaultArmId))
            {
                writer.WritePropertyName("dekKeyVaultArmId"u8);
                writer.WriteStringValue(DekKeyVaultArmId);
            }
            if (Optional.IsDefined(IsDiskKeyEncrypted))
            {
                writer.WritePropertyName("isDiskKeyEncrypted"u8);
                writer.WriteBooleanValue(IsDiskKeyEncrypted.Value);
            }
            if (Optional.IsDefined(KeyIdentifier))
            {
                writer.WritePropertyName("keyIdentifier"u8);
                writer.WriteStringValue(KeyIdentifier);
            }
            if (Optional.IsDefined(KekKeyVaultArmId))
            {
                writer.WritePropertyName("kekKeyVaultArmId"u8);
                writer.WriteStringValue(KekKeyVaultArmId);
            }
            if (Optional.IsDefined(FailoverDiskName))
            {
                writer.WritePropertyName("failoverDiskName"u8);
                writer.WriteStringValue(FailoverDiskName);
            }
            if (Optional.IsDefined(TfoDiskName))
            {
                writer.WritePropertyName("tfoDiskName"u8);
                writer.WriteStringValue(TfoDiskName);
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

        internal static A2AProtectedDiskDetails DeserializeA2AProtectedDiskDetails(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Uri> diskUri = default;
            Optional<ResourceIdentifier> recoveryAzureStorageAccountId = default;
            Optional<ResourceIdentifier> primaryDiskAzureStorageAccountId = default;
            Optional<Uri> recoveryDiskUri = default;
            Optional<string> diskName = default;
            Optional<long> diskCapacityInBytes = default;
            Optional<ResourceIdentifier> primaryStagingAzureStorageAccountId = default;
            Optional<string> diskType = default;
            Optional<bool> resyncRequired = default;
            Optional<int> monitoringPercentageCompletion = default;
            Optional<string> monitoringJobType = default;
            Optional<double> dataPendingInStagingStorageAccountInMB = default;
            Optional<double> dataPendingAtSourceAgentInMB = default;
            Optional<string> diskState = default;
            Optional<IReadOnlyList<string>> allowedDiskLevelOperation = default;
            Optional<bool> isDiskEncrypted = default;
            Optional<string> secretIdentifier = default;
            Optional<ResourceIdentifier> dekKeyVaultArmId = default;
            Optional<bool> isDiskKeyEncrypted = default;
            Optional<string> keyIdentifier = default;
            Optional<ResourceIdentifier> kekKeyVaultArmId = default;
            Optional<string> failoverDiskName = default;
            Optional<string> tfoDiskName = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("diskUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recoveryAzureStorageAccountId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryAzureStorageAccountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("primaryDiskAzureStorageAccountId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryDiskAzureStorageAccountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recoveryDiskUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryDiskUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("diskName"u8))
                {
                    diskName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskCapacityInBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskCapacityInBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("primaryStagingAzureStorageAccountId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryStagingAzureStorageAccountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("diskType"u8))
                {
                    diskType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resyncRequired"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resyncRequired = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("monitoringPercentageCompletion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    monitoringPercentageCompletion = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("monitoringJobType"u8))
                {
                    monitoringJobType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataPendingInStagingStorageAccountInMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataPendingInStagingStorageAccountInMB = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("dataPendingAtSourceAgentInMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataPendingAtSourceAgentInMB = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("diskState"u8))
                {
                    diskState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("allowedDiskLevelOperation"u8))
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
                    allowedDiskLevelOperation = array;
                    continue;
                }
                if (property.NameEquals("isDiskEncrypted"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isDiskEncrypted = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("secretIdentifier"u8))
                {
                    secretIdentifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dekKeyVaultArmId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dekKeyVaultArmId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("isDiskKeyEncrypted"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isDiskKeyEncrypted = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("keyIdentifier"u8))
                {
                    keyIdentifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kekKeyVaultArmId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kekKeyVaultArmId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("failoverDiskName"u8))
                {
                    failoverDiskName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tfoDiskName"u8))
                {
                    tfoDiskName = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new A2AProtectedDiskDetails(diskUri.Value, recoveryAzureStorageAccountId.Value, primaryDiskAzureStorageAccountId.Value, recoveryDiskUri.Value, diskName.Value, Optional.ToNullable(diskCapacityInBytes), primaryStagingAzureStorageAccountId.Value, diskType.Value, Optional.ToNullable(resyncRequired), Optional.ToNullable(monitoringPercentageCompletion), monitoringJobType.Value, Optional.ToNullable(dataPendingInStagingStorageAccountInMB), Optional.ToNullable(dataPendingAtSourceAgentInMB), diskState.Value, Optional.ToList(allowedDiskLevelOperation), Optional.ToNullable(isDiskEncrypted), secretIdentifier.Value, dekKeyVaultArmId.Value, Optional.ToNullable(isDiskKeyEncrypted), keyIdentifier.Value, kekKeyVaultArmId.Value, failoverDiskName.Value, tfoDiskName.Value, serializedAdditionalRawData);
        }

        A2AProtectedDiskDetails IModelJsonSerializable<A2AProtectedDiskDetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<A2AProtectedDiskDetails>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeA2AProtectedDiskDetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<A2AProtectedDiskDetails>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<A2AProtectedDiskDetails>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        A2AProtectedDiskDetails IModelSerializable<A2AProtectedDiskDetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<A2AProtectedDiskDetails>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeA2AProtectedDiskDetails(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="A2AProtectedDiskDetails"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="A2AProtectedDiskDetails"/> to convert. </param>
        public static implicit operator RequestContent(A2AProtectedDiskDetails model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="A2AProtectedDiskDetails"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator A2AProtectedDiskDetails(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeA2AProtectedDiskDetails(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
