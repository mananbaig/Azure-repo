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
    public partial class BackupServerEngine : IUtf8JsonSerializable, IModelJsonSerializable<BackupServerEngine>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<BackupServerEngine>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<BackupServerEngine>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BackupServerEngine>(this, options.Format);

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
            if (Optional.IsDefined(BackupEngineState))
            {
                writer.WritePropertyName("backupEngineState"u8);
                writer.WriteStringValue(BackupEngineState);
            }
            if (Optional.IsDefined(HealthStatus))
            {
                writer.WritePropertyName("healthStatus"u8);
                writer.WriteStringValue(HealthStatus);
            }
            writer.WritePropertyName("backupEngineType"u8);
            writer.WriteStringValue(BackupEngineType.ToString());
            if (Optional.IsDefined(CanReRegister))
            {
                writer.WritePropertyName("canReRegister"u8);
                writer.WriteBooleanValue(CanReRegister.Value);
            }
            if (Optional.IsDefined(BackupEngineId))
            {
                writer.WritePropertyName("backupEngineId"u8);
                writer.WriteStringValue(BackupEngineId);
            }
            if (Optional.IsDefined(DpmVersion))
            {
                writer.WritePropertyName("dpmVersion"u8);
                writer.WriteStringValue(DpmVersion);
            }
            if (Optional.IsDefined(AzureBackupAgentVersion))
            {
                writer.WritePropertyName("azureBackupAgentVersion"u8);
                writer.WriteStringValue(AzureBackupAgentVersion);
            }
            if (Optional.IsDefined(IsAzureBackupAgentUpgradeAvailable))
            {
                writer.WritePropertyName("isAzureBackupAgentUpgradeAvailable"u8);
                writer.WriteBooleanValue(IsAzureBackupAgentUpgradeAvailable.Value);
            }
            if (Optional.IsDefined(IsDpmUpgradeAvailable))
            {
                writer.WritePropertyName("isDpmUpgradeAvailable"u8);
                writer.WriteBooleanValue(IsDpmUpgradeAvailable.Value);
            }
            if (Optional.IsDefined(ExtendedInfo))
            {
                writer.WritePropertyName("extendedInfo"u8);
                if (ExtendedInfo is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<BackupEngineExtendedInfo>)ExtendedInfo).Serialize(writer, options);
                }
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

        internal static BackupServerEngine DeserializeBackupServerEngine(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> friendlyName = default;
            Optional<BackupManagementType> backupManagementType = default;
            Optional<string> registrationStatus = default;
            Optional<string> backupEngineState = default;
            Optional<string> healthStatus = default;
            BackupEngineType backupEngineType = default;
            Optional<bool> canReRegister = default;
            Optional<string> backupEngineId = default;
            Optional<string> dpmVersion = default;
            Optional<string> azureBackupAgentVersion = default;
            Optional<bool> isAzureBackupAgentUpgradeAvailable = default;
            Optional<bool> isDpmUpgradeAvailable = default;
            Optional<BackupEngineExtendedInfo> extendedInfo = default;
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
                if (property.NameEquals("backupEngineState"u8))
                {
                    backupEngineState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("healthStatus"u8))
                {
                    healthStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("backupEngineType"u8))
                {
                    backupEngineType = new BackupEngineType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("canReRegister"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    canReRegister = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("backupEngineId"u8))
                {
                    backupEngineId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dpmVersion"u8))
                {
                    dpmVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("azureBackupAgentVersion"u8))
                {
                    azureBackupAgentVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isAzureBackupAgentUpgradeAvailable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isAzureBackupAgentUpgradeAvailable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isDpmUpgradeAvailable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isDpmUpgradeAvailable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("extendedInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    extendedInfo = BackupEngineExtendedInfo.DeserializeBackupEngineExtendedInfo(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new BackupServerEngine(friendlyName.Value, Optional.ToNullable(backupManagementType), registrationStatus.Value, backupEngineState.Value, healthStatus.Value, backupEngineType, Optional.ToNullable(canReRegister), backupEngineId.Value, dpmVersion.Value, azureBackupAgentVersion.Value, Optional.ToNullable(isAzureBackupAgentUpgradeAvailable), Optional.ToNullable(isDpmUpgradeAvailable), extendedInfo.Value, serializedAdditionalRawData);
        }

        BackupServerEngine IModelJsonSerializable<BackupServerEngine>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BackupServerEngine>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeBackupServerEngine(doc.RootElement, options);
        }

        BinaryData IModelSerializable<BackupServerEngine>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BackupServerEngine>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        BackupServerEngine IModelSerializable<BackupServerEngine>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BackupServerEngine>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeBackupServerEngine(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="BackupServerEngine"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="BackupServerEngine"/> to convert. </param>
        public static implicit operator RequestContent(BackupServerEngine model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="BackupServerEngine"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator BackupServerEngine(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeBackupServerEngine(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
