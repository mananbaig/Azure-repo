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

namespace Azure.ResourceManager.StorageCache.Models
{
    public partial class StorageCacheUpgradeStatus : IUtf8JsonSerializable, IModelJsonSerializable<StorageCacheUpgradeStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<StorageCacheUpgradeStatus>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<StorageCacheUpgradeStatus>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StorageCacheUpgradeStatus>(this, options.Format);

            writer.WriteStartObject();
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

        internal static StorageCacheUpgradeStatus DeserializeStorageCacheUpgradeStatus(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> currentFirmwareVersion = default;
            Optional<StorageCacheFirmwareStatusType> firmwareUpdateStatus = default;
            Optional<DateTimeOffset> firmwareUpdateDeadline = default;
            Optional<DateTimeOffset> lastFirmwareUpdate = default;
            Optional<string> pendingFirmwareVersion = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("currentFirmwareVersion"u8))
                {
                    currentFirmwareVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("firmwareUpdateStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    firmwareUpdateStatus = new StorageCacheFirmwareStatusType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("firmwareUpdateDeadline"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    firmwareUpdateDeadline = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastFirmwareUpdate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastFirmwareUpdate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("pendingFirmwareVersion"u8))
                {
                    pendingFirmwareVersion = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new StorageCacheUpgradeStatus(currentFirmwareVersion.Value, Optional.ToNullable(firmwareUpdateStatus), Optional.ToNullable(firmwareUpdateDeadline), Optional.ToNullable(lastFirmwareUpdate), pendingFirmwareVersion.Value, serializedAdditionalRawData);
        }

        StorageCacheUpgradeStatus IModelJsonSerializable<StorageCacheUpgradeStatus>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StorageCacheUpgradeStatus>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageCacheUpgradeStatus(doc.RootElement, options);
        }

        BinaryData IModelSerializable<StorageCacheUpgradeStatus>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StorageCacheUpgradeStatus>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        StorageCacheUpgradeStatus IModelSerializable<StorageCacheUpgradeStatus>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StorageCacheUpgradeStatus>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeStorageCacheUpgradeStatus(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="StorageCacheUpgradeStatus"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="StorageCacheUpgradeStatus"/> to convert. </param>
        public static implicit operator RequestContent(StorageCacheUpgradeStatus model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="StorageCacheUpgradeStatus"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator StorageCacheUpgradeStatus(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeStorageCacheUpgradeStatus(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
