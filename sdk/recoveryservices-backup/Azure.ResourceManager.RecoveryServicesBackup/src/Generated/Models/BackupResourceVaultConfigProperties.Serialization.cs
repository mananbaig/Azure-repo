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
    public partial class BackupResourceVaultConfigProperties : IUtf8JsonSerializable, IModelJsonSerializable<BackupResourceVaultConfigProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<BackupResourceVaultConfigProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<BackupResourceVaultConfigProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BackupResourceVaultConfigProperties>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(StorageModelType))
            {
                writer.WritePropertyName("storageModelType"u8);
                writer.WriteStringValue(StorageModelType.Value.ToString());
            }
            if (Optional.IsDefined(StorageType))
            {
                writer.WritePropertyName("storageType"u8);
                writer.WriteStringValue(StorageType.Value.ToString());
            }
            if (Optional.IsDefined(StorageTypeState))
            {
                writer.WritePropertyName("storageTypeState"u8);
                writer.WriteStringValue(StorageTypeState.Value.ToString());
            }
            if (Optional.IsDefined(EnhancedSecurityState))
            {
                writer.WritePropertyName("enhancedSecurityState"u8);
                writer.WriteStringValue(EnhancedSecurityState.Value.ToString());
            }
            if (Optional.IsDefined(SoftDeleteFeatureState))
            {
                writer.WritePropertyName("softDeleteFeatureState"u8);
                writer.WriteStringValue(SoftDeleteFeatureState.Value.ToString());
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
            if (Optional.IsDefined(IsSoftDeleteFeatureStateEditable))
            {
                writer.WritePropertyName("isSoftDeleteFeatureStateEditable"u8);
                writer.WriteBooleanValue(IsSoftDeleteFeatureStateEditable.Value);
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

        internal static BackupResourceVaultConfigProperties DeserializeBackupResourceVaultConfigProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<BackupStorageType> storageModelType = default;
            Optional<BackupStorageType> storageType = default;
            Optional<BackupStorageTypeState> storageTypeState = default;
            Optional<EnhancedSecurityState> enhancedSecurityState = default;
            Optional<SoftDeleteFeatureState> softDeleteFeatureState = default;
            Optional<IList<string>> resourceGuardOperationRequests = default;
            Optional<bool> isSoftDeleteFeatureStateEditable = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("storageModelType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageModelType = new BackupStorageType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageType = new BackupStorageType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageTypeState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageTypeState = new BackupStorageTypeState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("enhancedSecurityState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enhancedSecurityState = new EnhancedSecurityState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("softDeleteFeatureState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    softDeleteFeatureState = new SoftDeleteFeatureState(property.Value.GetString());
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
                if (property.NameEquals("isSoftDeleteFeatureStateEditable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isSoftDeleteFeatureStateEditable = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new BackupResourceVaultConfigProperties(Optional.ToNullable(storageModelType), Optional.ToNullable(storageType), Optional.ToNullable(storageTypeState), Optional.ToNullable(enhancedSecurityState), Optional.ToNullable(softDeleteFeatureState), Optional.ToList(resourceGuardOperationRequests), Optional.ToNullable(isSoftDeleteFeatureStateEditable), serializedAdditionalRawData);
        }

        BackupResourceVaultConfigProperties IModelJsonSerializable<BackupResourceVaultConfigProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BackupResourceVaultConfigProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeBackupResourceVaultConfigProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<BackupResourceVaultConfigProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BackupResourceVaultConfigProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        BackupResourceVaultConfigProperties IModelSerializable<BackupResourceVaultConfigProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BackupResourceVaultConfigProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeBackupResourceVaultConfigProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="BackupResourceVaultConfigProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="BackupResourceVaultConfigProperties"/> to convert. </param>
        public static implicit operator RequestContent(BackupResourceVaultConfigProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="BackupResourceVaultConfigProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator BackupResourceVaultConfigProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeBackupResourceVaultConfigProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
