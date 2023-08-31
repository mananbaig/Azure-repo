// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Communication.MediaComposition;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Communication.MediaComposition.Models
{
    public partial class MediaOutput : IUtf8JsonSerializable, IModelJsonSerializable<MediaOutput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MediaOutput>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MediaOutput>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
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

        internal static MediaOutput DeserializeMediaOutput(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "groupCall": return GroupCallOutput.DeserializeGroupCallOutput(element);
                    case "room": return RoomOutput.DeserializeRoomOutput(element);
                    case "rtmp": return RtmpOutput.DeserializeRtmpOutput(element);
                    case "srt": return SrtOutput.DeserializeSrtOutput(element);
                    case "teamsMeeting": return TeamsMeetingOutput.DeserializeTeamsMeetingOutput(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            MediaOutputType kind = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = new MediaOutputType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new UnknownMediaOutput(kind, rawData);
        }

        MediaOutput IModelJsonSerializable<MediaOutput>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMediaOutput(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MediaOutput>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MediaOutput IModelSerializable<MediaOutput>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMediaOutput(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MediaOutput"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MediaOutput"/> to convert. </param>
        public static implicit operator RequestContent(MediaOutput model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MediaOutput"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MediaOutput(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMediaOutput(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
