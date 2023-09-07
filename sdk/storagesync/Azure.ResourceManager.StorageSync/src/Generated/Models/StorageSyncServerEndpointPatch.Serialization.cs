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

namespace Azure.ResourceManager.StorageSync.Models
{
    public partial class StorageSyncServerEndpointPatch : IUtf8JsonSerializable, IModelJsonSerializable<StorageSyncServerEndpointPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<StorageSyncServerEndpointPatch>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<StorageSyncServerEndpointPatch>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StorageSyncServerEndpointPatch>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(CloudTiering))
            {
                writer.WritePropertyName("cloudTiering"u8);
                writer.WriteStringValue(CloudTiering.Value.ToString());
            }
            if (Optional.IsDefined(VolumeFreeSpacePercent))
            {
                writer.WritePropertyName("volumeFreeSpacePercent"u8);
                writer.WriteNumberValue(VolumeFreeSpacePercent.Value);
            }
            if (Optional.IsDefined(TierFilesOlderThanDays))
            {
                writer.WritePropertyName("tierFilesOlderThanDays"u8);
                writer.WriteNumberValue(TierFilesOlderThanDays.Value);
            }
            if (Optional.IsDefined(OfflineDataTransfer))
            {
                writer.WritePropertyName("offlineDataTransfer"u8);
                writer.WriteStringValue(OfflineDataTransfer.Value.ToString());
            }
            if (Optional.IsDefined(OfflineDataTransferShareName))
            {
                writer.WritePropertyName("offlineDataTransferShareName"u8);
                writer.WriteStringValue(OfflineDataTransferShareName);
            }
            if (Optional.IsDefined(LocalCacheMode))
            {
                writer.WritePropertyName("localCacheMode"u8);
                writer.WriteStringValue(LocalCacheMode.Value.ToString());
            }
            writer.WriteEndObject();
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

        internal static StorageSyncServerEndpointPatch DeserializeStorageSyncServerEndpointPatch(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<StorageSyncFeatureStatus> cloudTiering = default;
            Optional<int> volumeFreeSpacePercent = default;
            Optional<int> tierFilesOlderThanDays = default;
            Optional<StorageSyncFeatureStatus> offlineDataTransfer = default;
            Optional<string> offlineDataTransferShareName = default;
            Optional<LocalCacheMode> localCacheMode = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("cloudTiering"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            cloudTiering = new StorageSyncFeatureStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("volumeFreeSpacePercent"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            volumeFreeSpacePercent = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("tierFilesOlderThanDays"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            tierFilesOlderThanDays = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("offlineDataTransfer"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            offlineDataTransfer = new StorageSyncFeatureStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("offlineDataTransferShareName"u8))
                        {
                            offlineDataTransferShareName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("localCacheMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            localCacheMode = new LocalCacheMode(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new StorageSyncServerEndpointPatch(Optional.ToNullable(cloudTiering), Optional.ToNullable(volumeFreeSpacePercent), Optional.ToNullable(tierFilesOlderThanDays), Optional.ToNullable(offlineDataTransfer), offlineDataTransferShareName.Value, Optional.ToNullable(localCacheMode), serializedAdditionalRawData);
        }

        StorageSyncServerEndpointPatch IModelJsonSerializable<StorageSyncServerEndpointPatch>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StorageSyncServerEndpointPatch>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageSyncServerEndpointPatch(doc.RootElement, options);
        }

        BinaryData IModelSerializable<StorageSyncServerEndpointPatch>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StorageSyncServerEndpointPatch>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        StorageSyncServerEndpointPatch IModelSerializable<StorageSyncServerEndpointPatch>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StorageSyncServerEndpointPatch>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeStorageSyncServerEndpointPatch(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="StorageSyncServerEndpointPatch"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="StorageSyncServerEndpointPatch"/> to convert. </param>
        public static implicit operator RequestContent(StorageSyncServerEndpointPatch model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="StorageSyncServerEndpointPatch"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator StorageSyncServerEndpointPatch(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeStorageSyncServerEndpointPatch(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
