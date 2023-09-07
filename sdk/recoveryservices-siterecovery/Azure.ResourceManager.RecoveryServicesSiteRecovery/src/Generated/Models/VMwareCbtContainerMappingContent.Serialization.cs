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
    public partial class VMwareCbtContainerMappingContent : IUtf8JsonSerializable, IModelJsonSerializable<VMwareCbtContainerMappingContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<VMwareCbtContainerMappingContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<VMwareCbtContainerMappingContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<VMwareCbtContainerMappingContent>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(KeyVaultId))
            {
                writer.WritePropertyName("keyVaultId"u8);
                writer.WriteStringValue(KeyVaultId);
            }
            if (Optional.IsDefined(KeyVaultUri))
            {
                writer.WritePropertyName("keyVaultUri"u8);
                writer.WriteStringValue(KeyVaultUri.AbsoluteUri);
            }
            writer.WritePropertyName("storageAccountId"u8);
            writer.WriteStringValue(StorageAccountId);
            if (Optional.IsDefined(StorageAccountSasSecretName))
            {
                writer.WritePropertyName("storageAccountSasSecretName"u8);
                writer.WriteStringValue(StorageAccountSasSecretName);
            }
            if (Optional.IsDefined(ServiceBusConnectionStringSecretName))
            {
                writer.WritePropertyName("serviceBusConnectionStringSecretName"u8);
                writer.WriteStringValue(ServiceBusConnectionStringSecretName);
            }
            writer.WritePropertyName("targetLocation"u8);
            writer.WriteStringValue(TargetLocation);
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        internal static VMwareCbtContainerMappingContent DeserializeVMwareCbtContainerMappingContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> keyVaultId = default;
            Optional<Uri> keyVaultUri = default;
            ResourceIdentifier storageAccountId = default;
            Optional<string> storageAccountSasSecretName = default;
            Optional<string> serviceBusConnectionStringSecretName = default;
            string targetLocation = default;
            string instanceType = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyVaultId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyVaultId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("keyVaultUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyVaultUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageAccountId"u8))
                {
                    storageAccountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageAccountSasSecretName"u8))
                {
                    storageAccountSasSecretName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serviceBusConnectionStringSecretName"u8))
                {
                    serviceBusConnectionStringSecretName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetLocation"u8))
                {
                    targetLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new VMwareCbtContainerMappingContent(instanceType, keyVaultId.Value, keyVaultUri.Value, storageAccountId, storageAccountSasSecretName.Value, serviceBusConnectionStringSecretName.Value, targetLocation, serializedAdditionalRawData);
        }

        VMwareCbtContainerMappingContent IModelJsonSerializable<VMwareCbtContainerMappingContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<VMwareCbtContainerMappingContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeVMwareCbtContainerMappingContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<VMwareCbtContainerMappingContent>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<VMwareCbtContainerMappingContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        VMwareCbtContainerMappingContent IModelSerializable<VMwareCbtContainerMappingContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<VMwareCbtContainerMappingContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeVMwareCbtContainerMappingContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="VMwareCbtContainerMappingContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="VMwareCbtContainerMappingContent"/> to convert. </param>
        public static implicit operator RequestContent(VMwareCbtContainerMappingContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="VMwareCbtContainerMappingContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator VMwareCbtContainerMappingContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeVMwareCbtContainerMappingContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
