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
    public partial class GalleryArtifactVersionFullSource : IUtf8JsonSerializable, IModelJsonSerializable<GalleryArtifactVersionFullSource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<GalleryArtifactVersionFullSource>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<GalleryArtifactVersionFullSource>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<GalleryArtifactVersionFullSource>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(CommunityGalleryImageId))
            {
                writer.WritePropertyName("communityGalleryImageId"u8);
                writer.WriteStringValue(CommunityGalleryImageId);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
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

        internal static GalleryArtifactVersionFullSource DeserializeGalleryArtifactVersionFullSource(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> communityGalleryImageId = default;
            Optional<ResourceIdentifier> id = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("communityGalleryImageId"u8))
                {
                    communityGalleryImageId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new GalleryArtifactVersionFullSource(id.Value, communityGalleryImageId.Value, rawData);
        }

        GalleryArtifactVersionFullSource IModelJsonSerializable<GalleryArtifactVersionFullSource>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<GalleryArtifactVersionFullSource>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeGalleryArtifactVersionFullSource(doc.RootElement, options);
        }

        BinaryData IModelSerializable<GalleryArtifactVersionFullSource>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<GalleryArtifactVersionFullSource>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        GalleryArtifactVersionFullSource IModelSerializable<GalleryArtifactVersionFullSource>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<GalleryArtifactVersionFullSource>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeGalleryArtifactVersionFullSource(doc.RootElement, options);
        }

        public static implicit operator RequestContent(GalleryArtifactVersionFullSource model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator GalleryArtifactVersionFullSource(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeGalleryArtifactVersionFullSource(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
