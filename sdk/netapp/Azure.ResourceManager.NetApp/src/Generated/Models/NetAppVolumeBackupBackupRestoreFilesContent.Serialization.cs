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

namespace Azure.ResourceManager.NetApp.Models
{
    public partial class NetAppVolumeBackupBackupRestoreFilesContent : IUtf8JsonSerializable, IModelJsonSerializable<NetAppVolumeBackupBackupRestoreFilesContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<NetAppVolumeBackupBackupRestoreFilesContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<NetAppVolumeBackupBackupRestoreFilesContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("fileList"u8);
            writer.WriteStartArray();
            foreach (var item in FileList)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(RestoreFilePath))
            {
                writer.WritePropertyName("restoreFilePath"u8);
                writer.WriteStringValue(RestoreFilePath);
            }
            writer.WritePropertyName("destinationVolumeId"u8);
            writer.WriteStringValue(DestinationVolumeId);
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

        internal static NetAppVolumeBackupBackupRestoreFilesContent DeserializeNetAppVolumeBackupBackupRestoreFilesContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> fileList = default;
            Optional<string> restoreFilePath = default;
            ResourceIdentifier destinationVolumeId = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("fileList"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    fileList = array;
                    continue;
                }
                if (property.NameEquals("restoreFilePath"u8))
                {
                    restoreFilePath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("destinationVolumeId"u8))
                {
                    destinationVolumeId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new NetAppVolumeBackupBackupRestoreFilesContent(fileList, restoreFilePath.Value, destinationVolumeId, rawData);
        }

        NetAppVolumeBackupBackupRestoreFilesContent IModelJsonSerializable<NetAppVolumeBackupBackupRestoreFilesContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeNetAppVolumeBackupBackupRestoreFilesContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<NetAppVolumeBackupBackupRestoreFilesContent>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        NetAppVolumeBackupBackupRestoreFilesContent IModelSerializable<NetAppVolumeBackupBackupRestoreFilesContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeNetAppVolumeBackupBackupRestoreFilesContent(doc.RootElement, options);
        }

        public static implicit operator RequestContent(NetAppVolumeBackupBackupRestoreFilesContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator NetAppVolumeBackupBackupRestoreFilesContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeNetAppVolumeBackupBackupRestoreFilesContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
