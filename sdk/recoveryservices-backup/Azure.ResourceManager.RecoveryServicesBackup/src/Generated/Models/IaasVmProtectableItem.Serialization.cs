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
    public partial class IaasVmProtectableItem : IUtf8JsonSerializable, IModelJsonSerializable<IaasVmProtectableItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<IaasVmProtectableItem>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<IaasVmProtectableItem>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IaasVmProtectableItem>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(VirtualMachineId))
            {
                writer.WritePropertyName("virtualMachineId"u8);
                writer.WriteStringValue(VirtualMachineId);
            }
            if (Optional.IsDefined(VirtualMachineVersion))
            {
                writer.WritePropertyName("virtualMachineVersion"u8);
                writer.WriteStringValue(VirtualMachineVersion);
            }
            if (Optional.IsDefined(ResourceGroup))
            {
                writer.WritePropertyName("resourceGroup"u8);
                writer.WriteStringValue(ResourceGroup);
            }
            if (Optional.IsDefined(BackupManagementType))
            {
                writer.WritePropertyName("backupManagementType"u8);
                writer.WriteStringValue(BackupManagementType);
            }
            if (Optional.IsDefined(WorkloadType))
            {
                writer.WritePropertyName("workloadType"u8);
                writer.WriteStringValue(WorkloadType);
            }
            writer.WritePropertyName("protectableItemType"u8);
            writer.WriteStringValue(ProtectableItemType);
            if (Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (Optional.IsDefined(ProtectionState))
            {
                writer.WritePropertyName("protectionState"u8);
                writer.WriteStringValue(ProtectionState.Value.ToString());
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

        internal static IaasVmProtectableItem DeserializeIaasVmProtectableItem(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("protectableItemType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Microsoft.ClassicCompute/virtualMachines": return IaasClassicComputeVmProtectableItem.DeserializeIaasClassicComputeVmProtectableItem(element);
                    case "Microsoft.Compute/virtualMachines": return IaasComputeVmProtectableItem.DeserializeIaasComputeVmProtectableItem(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            Optional<ResourceIdentifier> virtualMachineId = default;
            Optional<string> virtualMachineVersion = default;
            Optional<string> resourceGroup = default;
            Optional<string> backupManagementType = default;
            Optional<string> workloadType = default;
            string protectableItemType = "IaaSVMProtectableItem";
            Optional<string> friendlyName = default;
            Optional<BackupProtectionStatus> protectionState = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("virtualMachineId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    virtualMachineId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("virtualMachineVersion"u8))
                {
                    virtualMachineVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceGroup"u8))
                {
                    resourceGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("backupManagementType"u8))
                {
                    backupManagementType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workloadType"u8))
                {
                    workloadType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectableItemType"u8))
                {
                    protectableItemType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("friendlyName"u8))
                {
                    friendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectionState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protectionState = new BackupProtectionStatus(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new IaasVmProtectableItem(backupManagementType.Value, workloadType.Value, protectableItemType, friendlyName.Value, Optional.ToNullable(protectionState), virtualMachineId.Value, virtualMachineVersion.Value, resourceGroup.Value, serializedAdditionalRawData);
        }

        IaasVmProtectableItem IModelJsonSerializable<IaasVmProtectableItem>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IaasVmProtectableItem>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeIaasVmProtectableItem(doc.RootElement, options);
        }

        BinaryData IModelSerializable<IaasVmProtectableItem>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IaasVmProtectableItem>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        IaasVmProtectableItem IModelSerializable<IaasVmProtectableItem>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IaasVmProtectableItem>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeIaasVmProtectableItem(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="IaasVmProtectableItem"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="IaasVmProtectableItem"/> to convert. </param>
        public static implicit operator RequestContent(IaasVmProtectableItem model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="IaasVmProtectableItem"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator IaasVmProtectableItem(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeIaasVmProtectableItem(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
