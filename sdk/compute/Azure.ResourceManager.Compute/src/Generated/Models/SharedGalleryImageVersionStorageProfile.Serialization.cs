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
    public partial class SharedGalleryImageVersionStorageProfile : IUtf8JsonSerializable, IModelJsonSerializable<SharedGalleryImageVersionStorageProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SharedGalleryImageVersionStorageProfile>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SharedGalleryImageVersionStorageProfile>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(OSDiskImage))
            {
                writer.WritePropertyName("osDiskImage"u8);
                writer.WriteObjectValue(OSDiskImage);
            }
            if (Optional.IsCollectionDefined(DataDiskImages))
            {
                writer.WritePropertyName("dataDiskImages"u8);
                writer.WriteStartArray();
                foreach (var item in DataDiskImages)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        internal static SharedGalleryImageVersionStorageProfile DeserializeSharedGalleryImageVersionStorageProfile(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SharedGalleryOSDiskImage> osDiskImage = default;
            Optional<IReadOnlyList<SharedGalleryDataDiskImage>> dataDiskImages = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("osDiskImage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    osDiskImage = SharedGalleryOSDiskImage.DeserializeSharedGalleryOSDiskImage(property.Value);
                    continue;
                }
                if (property.NameEquals("dataDiskImages"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SharedGalleryDataDiskImage> array = new List<SharedGalleryDataDiskImage>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SharedGalleryDataDiskImage.DeserializeSharedGalleryDataDiskImage(item));
                    }
                    dataDiskImages = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SharedGalleryImageVersionStorageProfile(osDiskImage.Value, Optional.ToList(dataDiskImages), rawData);
        }

        SharedGalleryImageVersionStorageProfile IModelJsonSerializable<SharedGalleryImageVersionStorageProfile>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSharedGalleryImageVersionStorageProfile(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SharedGalleryImageVersionStorageProfile>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SharedGalleryImageVersionStorageProfile IModelSerializable<SharedGalleryImageVersionStorageProfile>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSharedGalleryImageVersionStorageProfile(doc.RootElement, options);
        }

        public static implicit operator RequestContent(SharedGalleryImageVersionStorageProfile model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator SharedGalleryImageVersionStorageProfile(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSharedGalleryImageVersionStorageProfile(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
