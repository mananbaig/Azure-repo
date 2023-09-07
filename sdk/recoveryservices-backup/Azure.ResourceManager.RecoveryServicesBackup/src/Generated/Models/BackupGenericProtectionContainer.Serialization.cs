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
    public partial class BackupGenericProtectionContainer : IUtf8JsonSerializable, IModelJsonSerializable<BackupGenericProtectionContainer>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<BackupGenericProtectionContainer>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<BackupGenericProtectionContainer>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BackupGenericProtectionContainer>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (Optional.IsDefined(BackupManagementType))
            {
                writer.WritePropertyName("backupManagementType"u8);
                writer.WriteStringValue(BackupManagementType.Value.ToString());
            }
            if (Optional.IsDefined(RegistrationStatus))
            {
                writer.WritePropertyName("registrationStatus"u8);
                writer.WriteStringValue(RegistrationStatus);
            }
            if (Optional.IsDefined(HealthStatus))
            {
                writer.WritePropertyName("healthStatus"u8);
                writer.WriteStringValue(HealthStatus);
            }
            writer.WritePropertyName("containerType"u8);
            writer.WriteStringValue(ContainerType.ToSerialString());
            if (Optional.IsDefined(ProtectableObjectType))
            {
                writer.WritePropertyName("protectableObjectType"u8);
                writer.WriteStringValue(ProtectableObjectType);
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

        internal static BackupGenericProtectionContainer DeserializeBackupGenericProtectionContainer(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("containerType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureBackupServerContainer": return BackupServerContainer.DeserializeBackupServerContainer(element);
                    case "AzureSqlContainer": return SqlContainer.DeserializeSqlContainer(element);
                    case "AzureWorkloadContainer": return WorkloadContainer.DeserializeWorkloadContainer(element);
                    case "DPMContainer": return DpmContainer.DeserializeDpmContainer(element);
                    case "GenericContainer": return GenericContainer.DeserializeGenericContainer(element);
                    case "IaasVMContainer": return IaasVmContainer.DeserializeIaasVmContainer(element);
                    case "Microsoft.ClassicCompute/virtualMachines": return IaasClassicComputeVmContainer.DeserializeIaasClassicComputeVmContainer(element);
                    case "Microsoft.Compute/virtualMachines": return IaasComputeVmContainer.DeserializeIaasComputeVmContainer(element);
                    case "SQLAGWorkLoadContainer": return SqlAvailabilityGroupWorkloadProtectionContainer.DeserializeSqlAvailabilityGroupWorkloadProtectionContainer(element);
                    case "StorageContainer": return StorageContainer.DeserializeStorageContainer(element);
                    case "VMAppContainer": return VmAppContainerProtectionContainer.DeserializeVmAppContainerProtectionContainer(element);
                    case "Windows": return MabContainer.DeserializeMabContainer(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            Optional<string> friendlyName = default;
            Optional<BackupManagementType> backupManagementType = default;
            Optional<string> registrationStatus = default;
            Optional<string> healthStatus = default;
            ProtectableContainerType containerType = default;
            Optional<string> protectableObjectType = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("friendlyName"u8))
                {
                    friendlyName = property.Value.GetString();
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
                if (property.NameEquals("registrationStatus"u8))
                {
                    registrationStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("healthStatus"u8))
                {
                    healthStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("containerType"u8))
                {
                    containerType = property.Value.GetString().ToProtectableContainerType();
                    continue;
                }
                if (property.NameEquals("protectableObjectType"u8))
                {
                    protectableObjectType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new UnknownProtectionContainer(friendlyName.Value, Optional.ToNullable(backupManagementType), registrationStatus.Value, healthStatus.Value, containerType, protectableObjectType.Value, serializedAdditionalRawData);
        }

        BackupGenericProtectionContainer IModelJsonSerializable<BackupGenericProtectionContainer>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BackupGenericProtectionContainer>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeBackupGenericProtectionContainer(doc.RootElement, options);
        }

        BinaryData IModelSerializable<BackupGenericProtectionContainer>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BackupGenericProtectionContainer>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        BackupGenericProtectionContainer IModelSerializable<BackupGenericProtectionContainer>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BackupGenericProtectionContainer>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeBackupGenericProtectionContainer(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="BackupGenericProtectionContainer"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="BackupGenericProtectionContainer"/> to convert. </param>
        public static implicit operator RequestContent(BackupGenericProtectionContainer model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="BackupGenericProtectionContainer"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator BackupGenericProtectionContainer(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeBackupGenericProtectionContainer(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
