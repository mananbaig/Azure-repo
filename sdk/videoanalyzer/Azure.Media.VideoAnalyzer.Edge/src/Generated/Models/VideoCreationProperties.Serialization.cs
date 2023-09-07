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

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class VideoCreationProperties : IUtf8JsonSerializable, IModelJsonSerializable<VideoCreationProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<VideoCreationProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<VideoCreationProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<VideoCreationProperties>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Title))
            {
                writer.WritePropertyName("title"u8);
                writer.WriteStringValue(Title);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(SegmentLength))
            {
                writer.WritePropertyName("segmentLength"u8);
                writer.WriteStringValue(SegmentLength);
            }
            if (Optional.IsDefined(RetentionPeriod))
            {
                writer.WritePropertyName("retentionPeriod"u8);
                writer.WriteStringValue(RetentionPeriod);
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

        internal static VideoCreationProperties DeserializeVideoCreationProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> title = default;
            Optional<string> description = default;
            Optional<string> segmentLength = default;
            Optional<string> retentionPeriod = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("title"u8))
                {
                    title = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("segmentLength"u8))
                {
                    segmentLength = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("retentionPeriod"u8))
                {
                    retentionPeriod = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new VideoCreationProperties(title.Value, description.Value, segmentLength.Value, retentionPeriod.Value, serializedAdditionalRawData);
        }

        VideoCreationProperties IModelJsonSerializable<VideoCreationProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<VideoCreationProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeVideoCreationProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<VideoCreationProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<VideoCreationProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        VideoCreationProperties IModelSerializable<VideoCreationProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<VideoCreationProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeVideoCreationProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="VideoCreationProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="VideoCreationProperties"/> to convert. </param>
        public static implicit operator RequestContent(VideoCreationProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="VideoCreationProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator VideoCreationProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeVideoCreationProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
