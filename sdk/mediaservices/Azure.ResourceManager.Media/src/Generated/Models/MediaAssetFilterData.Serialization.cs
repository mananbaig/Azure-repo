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
using Azure.ResourceManager.Media.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Media
{
    public partial class MediaAssetFilterData : IUtf8JsonSerializable, IModelJsonSerializable<MediaAssetFilterData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MediaAssetFilterData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MediaAssetFilterData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(PresentationTimeRange))
            {
                writer.WritePropertyName("presentationTimeRange"u8);
                writer.WriteObjectValue(PresentationTimeRange);
            }
            if (Optional.IsDefined(FirstQuality))
            {
                writer.WritePropertyName("firstQuality"u8);
                writer.WriteObjectValue(FirstQuality);
            }
            if (Optional.IsCollectionDefined(Tracks))
            {
                writer.WritePropertyName("tracks"u8);
                writer.WriteStartArray();
                foreach (var item in Tracks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
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

        internal static MediaAssetFilterData DeserializeMediaAssetFilterData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<PresentationTimeRange> presentationTimeRange = default;
            Optional<FirstQuality> firstQuality = default;
            Optional<IList<FilterTrackSelection>> tracks = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("presentationTimeRange"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            presentationTimeRange = PresentationTimeRange.DeserializePresentationTimeRange(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("firstQuality"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            firstQuality = FirstQuality.DeserializeFirstQuality(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("tracks"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<FilterTrackSelection> array = new List<FilterTrackSelection>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(FilterTrackSelection.DeserializeFilterTrackSelection(item));
                            }
                            tracks = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MediaAssetFilterData(id, name, type, systemData.Value, presentationTimeRange.Value, firstQuality.Value, Optional.ToList(tracks), rawData);
        }

        MediaAssetFilterData IModelJsonSerializable<MediaAssetFilterData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMediaAssetFilterData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MediaAssetFilterData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MediaAssetFilterData IModelSerializable<MediaAssetFilterData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMediaAssetFilterData(doc.RootElement, options);
        }

        public static implicit operator RequestContent(MediaAssetFilterData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator MediaAssetFilterData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMediaAssetFilterData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
