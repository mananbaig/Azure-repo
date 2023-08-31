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

namespace Azure.ResourceManager.Network.Models
{
    public partial class PacketCaptureStorageLocation : IUtf8JsonSerializable, IModelJsonSerializable<PacketCaptureStorageLocation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PacketCaptureStorageLocation>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PacketCaptureStorageLocation>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(StorageId))
            {
                writer.WritePropertyName("storageId"u8);
                writer.WriteStringValue(StorageId);
            }
            if (Optional.IsDefined(StoragePath))
            {
                writer.WritePropertyName("storagePath"u8);
                writer.WriteStringValue(StoragePath);
            }
            if (Optional.IsDefined(FilePath))
            {
                writer.WritePropertyName("filePath"u8);
                writer.WriteStringValue(FilePath);
            }
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
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

        internal static PacketCaptureStorageLocation DeserializePacketCaptureStorageLocation(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> storageId = default;
            Optional<string> storagePath = default;
            Optional<string> filePath = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("storageId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storagePath"u8))
                {
                    storagePath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("filePath"u8))
                {
                    filePath = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new PacketCaptureStorageLocation(storageId.Value, storagePath.Value, filePath.Value, rawData);
        }

        PacketCaptureStorageLocation IModelJsonSerializable<PacketCaptureStorageLocation>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePacketCaptureStorageLocation(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PacketCaptureStorageLocation>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PacketCaptureStorageLocation IModelSerializable<PacketCaptureStorageLocation>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePacketCaptureStorageLocation(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="PacketCaptureStorageLocation"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="PacketCaptureStorageLocation"/> to convert. </param>
        public static implicit operator RequestContent(PacketCaptureStorageLocation model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="PacketCaptureStorageLocation"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator PacketCaptureStorageLocation(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePacketCaptureStorageLocation(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
