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
    public partial class InMageAzureV2ManagedDiskDetails : IUtf8JsonSerializable, IModelJsonSerializable<InMageAzureV2ManagedDiskDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<InMageAzureV2ManagedDiskDetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<InMageAzureV2ManagedDiskDetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<InMageAzureV2ManagedDiskDetails>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(DiskId))
            {
                writer.WritePropertyName("diskId"u8);
                writer.WriteStringValue(DiskId);
            }
            if (Optional.IsDefined(SeedManagedDiskId))
            {
                writer.WritePropertyName("seedManagedDiskId"u8);
                writer.WriteStringValue(SeedManagedDiskId);
            }
            if (Optional.IsDefined(ReplicaDiskType))
            {
                writer.WritePropertyName("replicaDiskType"u8);
                writer.WriteStringValue(ReplicaDiskType);
            }
            if (Optional.IsDefined(DiskEncryptionSetId))
            {
                writer.WritePropertyName("diskEncryptionSetId"u8);
                writer.WriteStringValue(DiskEncryptionSetId);
            }
            if (Optional.IsDefined(TargetDiskName))
            {
                writer.WritePropertyName("targetDiskName"u8);
                writer.WriteStringValue(TargetDiskName);
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

        internal static InMageAzureV2ManagedDiskDetails DeserializeInMageAzureV2ManagedDiskDetails(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> diskId = default;
            Optional<string> seedManagedDiskId = default;
            Optional<string> replicaDiskType = default;
            Optional<ResourceIdentifier> diskEncryptionSetId = default;
            Optional<string> targetDiskName = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("diskId"u8))
                {
                    diskId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("seedManagedDiskId"u8))
                {
                    seedManagedDiskId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("replicaDiskType"u8))
                {
                    replicaDiskType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskEncryptionSetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskEncryptionSetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetDiskName"u8))
                {
                    targetDiskName = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new InMageAzureV2ManagedDiskDetails(diskId.Value, seedManagedDiskId.Value, replicaDiskType.Value, diskEncryptionSetId.Value, targetDiskName.Value, serializedAdditionalRawData);
        }

        InMageAzureV2ManagedDiskDetails IModelJsonSerializable<InMageAzureV2ManagedDiskDetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<InMageAzureV2ManagedDiskDetails>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeInMageAzureV2ManagedDiskDetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<InMageAzureV2ManagedDiskDetails>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<InMageAzureV2ManagedDiskDetails>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        InMageAzureV2ManagedDiskDetails IModelSerializable<InMageAzureV2ManagedDiskDetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<InMageAzureV2ManagedDiskDetails>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeInMageAzureV2ManagedDiskDetails(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="InMageAzureV2ManagedDiskDetails"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="InMageAzureV2ManagedDiskDetails"/> to convert. </param>
        public static implicit operator RequestContent(InMageAzureV2ManagedDiskDetails model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="InMageAzureV2ManagedDiskDetails"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator InMageAzureV2ManagedDiskDetails(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeInMageAzureV2ManagedDiskDetails(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
