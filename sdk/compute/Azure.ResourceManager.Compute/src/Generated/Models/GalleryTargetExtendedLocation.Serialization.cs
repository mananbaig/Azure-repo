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

namespace Azure.ResourceManager.Compute.Models
{
    public partial class GalleryTargetExtendedLocation : IUtf8JsonSerializable, IModelJsonSerializable<GalleryTargetExtendedLocation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<GalleryTargetExtendedLocation>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<GalleryTargetExtendedLocation>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(ExtendedLocation))
            {
                writer.WritePropertyName("extendedLocation"u8);
                if (ExtendedLocation is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<GalleryExtendedLocation>)ExtendedLocation).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(ExtendedLocationReplicaCount))
            {
                writer.WritePropertyName("extendedLocationReplicaCount"u8);
                writer.WriteNumberValue(ExtendedLocationReplicaCount.Value);
            }
            if (Optional.IsDefined(GalleryStorageAccountType))
            {
                writer.WritePropertyName("storageAccountType"u8);
                writer.WriteStringValue(GalleryStorageAccountType.Value.ToString());
            }
            if (Optional.IsDefined(Encryption))
            {
                writer.WritePropertyName("encryption"u8);
                if (Encryption is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<EncryptionImages>)Encryption).Serialize(writer, options);
                }
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

        internal static GalleryTargetExtendedLocation DeserializeGalleryTargetExtendedLocation(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<GalleryExtendedLocation> extendedLocation = default;
            Optional<int> extendedLocationReplicaCount = default;
            Optional<EdgeZoneStorageAccountType> storageAccountType = default;
            Optional<EncryptionImages> encryption = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("extendedLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    extendedLocation = GalleryExtendedLocation.DeserializeGalleryExtendedLocation(property.Value);
                    continue;
                }
                if (property.NameEquals("extendedLocationReplicaCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    extendedLocationReplicaCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("storageAccountType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageAccountType = new EdgeZoneStorageAccountType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("encryption"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    encryption = EncryptionImages.DeserializeEncryptionImages(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new GalleryTargetExtendedLocation(name.Value, extendedLocation.Value, Optional.ToNullable(extendedLocationReplicaCount), Optional.ToNullable(storageAccountType), encryption.Value, rawData);
        }

        GalleryTargetExtendedLocation IModelJsonSerializable<GalleryTargetExtendedLocation>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeGalleryTargetExtendedLocation(doc.RootElement, options);
        }

        BinaryData IModelSerializable<GalleryTargetExtendedLocation>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        GalleryTargetExtendedLocation IModelSerializable<GalleryTargetExtendedLocation>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeGalleryTargetExtendedLocation(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="GalleryTargetExtendedLocation"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="GalleryTargetExtendedLocation"/> to convert. </param>
        public static implicit operator RequestContent(GalleryTargetExtendedLocation model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="GalleryTargetExtendedLocation"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator GalleryTargetExtendedLocation(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeGalleryTargetExtendedLocation(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
