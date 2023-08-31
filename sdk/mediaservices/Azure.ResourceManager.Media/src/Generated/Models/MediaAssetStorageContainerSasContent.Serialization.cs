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

namespace Azure.ResourceManager.Media.Models
{
    public partial class MediaAssetStorageContainerSasContent : IUtf8JsonSerializable, IModelJsonSerializable<MediaAssetStorageContainerSasContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MediaAssetStorageContainerSasContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MediaAssetStorageContainerSasContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Permissions))
            {
                writer.WritePropertyName("permissions"u8);
                writer.WriteStringValue(Permissions.Value.ToString());
            }
            if (Optional.IsDefined(ExpireOn))
            {
                writer.WritePropertyName("expiryTime"u8);
                writer.WriteStringValue(ExpireOn.Value, "O");
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

        internal static MediaAssetStorageContainerSasContent DeserializeMediaAssetStorageContainerSasContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<MediaAssetContainerPermission> permissions = default;
            Optional<DateTimeOffset> expiryTime = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("permissions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    permissions = new MediaAssetContainerPermission(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("expiryTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expiryTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MediaAssetStorageContainerSasContent(Optional.ToNullable(permissions), Optional.ToNullable(expiryTime), rawData);
        }

        MediaAssetStorageContainerSasContent IModelJsonSerializable<MediaAssetStorageContainerSasContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMediaAssetStorageContainerSasContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MediaAssetStorageContainerSasContent>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MediaAssetStorageContainerSasContent IModelSerializable<MediaAssetStorageContainerSasContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMediaAssetStorageContainerSasContent(doc.RootElement, options);
        }

        public static implicit operator RequestContent(MediaAssetStorageContainerSasContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator MediaAssetStorageContainerSasContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMediaAssetStorageContainerSasContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
