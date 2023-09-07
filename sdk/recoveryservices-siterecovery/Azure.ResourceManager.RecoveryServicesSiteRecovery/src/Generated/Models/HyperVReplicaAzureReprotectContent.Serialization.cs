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
    public partial class HyperVReplicaAzureReprotectContent : IUtf8JsonSerializable, IModelJsonSerializable<HyperVReplicaAzureReprotectContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<HyperVReplicaAzureReprotectContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<HyperVReplicaAzureReprotectContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HyperVReplicaAzureReprotectContent>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(HyperVHostVmId))
            {
                writer.WritePropertyName("hvHostVmId"u8);
                writer.WriteStringValue(HyperVHostVmId);
            }
            if (Optional.IsDefined(VmName))
            {
                writer.WritePropertyName("vmName"u8);
                writer.WriteStringValue(VmName);
            }
            if (Optional.IsDefined(OSType))
            {
                writer.WritePropertyName("osType"u8);
                writer.WriteStringValue(OSType);
            }
            if (Optional.IsDefined(VhdId))
            {
                writer.WritePropertyName("vHDId"u8);
                writer.WriteStringValue(VhdId);
            }
            if (Optional.IsDefined(StorageAccountId))
            {
                writer.WritePropertyName("storageAccountId"u8);
                writer.WriteStringValue(StorageAccountId);
            }
            if (Optional.IsDefined(LogStorageAccountId))
            {
                writer.WritePropertyName("logStorageAccountId"u8);
                writer.WriteStringValue(LogStorageAccountId);
            }
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

        internal static HyperVReplicaAzureReprotectContent DeserializeHyperVReplicaAzureReprotectContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> hvHostVmId = default;
            Optional<string> vmName = default;
            Optional<string> osType = default;
            Optional<string> vhdId = default;
            Optional<ResourceIdentifier> storageAccountId = default;
            Optional<ResourceIdentifier> logStorageAccountId = default;
            string instanceType = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hvHostVmId"u8))
                {
                    hvHostVmId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vmName"u8))
                {
                    vmName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("osType"u8))
                {
                    osType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vHDId"u8))
                {
                    vhdId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storageAccountId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageAccountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("logStorageAccountId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logStorageAccountId = new ResourceIdentifier(property.Value.GetString());
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
            return new HyperVReplicaAzureReprotectContent(instanceType, hvHostVmId.Value, vmName.Value, osType.Value, vhdId.Value, storageAccountId.Value, logStorageAccountId.Value, serializedAdditionalRawData);
        }

        HyperVReplicaAzureReprotectContent IModelJsonSerializable<HyperVReplicaAzureReprotectContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HyperVReplicaAzureReprotectContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeHyperVReplicaAzureReprotectContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<HyperVReplicaAzureReprotectContent>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HyperVReplicaAzureReprotectContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        HyperVReplicaAzureReprotectContent IModelSerializable<HyperVReplicaAzureReprotectContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HyperVReplicaAzureReprotectContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeHyperVReplicaAzureReprotectContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="HyperVReplicaAzureReprotectContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="HyperVReplicaAzureReprotectContent"/> to convert. </param>
        public static implicit operator RequestContent(HyperVReplicaAzureReprotectContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="HyperVReplicaAzureReprotectContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator HyperVReplicaAzureReprotectContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeHyperVReplicaAzureReprotectContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
