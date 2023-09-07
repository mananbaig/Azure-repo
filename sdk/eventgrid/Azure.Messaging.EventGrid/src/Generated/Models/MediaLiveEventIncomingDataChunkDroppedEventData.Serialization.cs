// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(MediaLiveEventIncomingDataChunkDroppedEventDataConverter))]
    public partial class MediaLiveEventIncomingDataChunkDroppedEventData : IUtf8JsonSerializable, IModelJsonSerializable<MediaLiveEventIncomingDataChunkDroppedEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MediaLiveEventIncomingDataChunkDroppedEventData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MediaLiveEventIncomingDataChunkDroppedEventData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MediaLiveEventIncomingDataChunkDroppedEventData>(this, options.Format);

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

        internal static MediaLiveEventIncomingDataChunkDroppedEventData DeserializeMediaLiveEventIncomingDataChunkDroppedEventData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> timestamp = default;
            Optional<string> trackType = default;
            Optional<long> bitrate = default;
            Optional<string> timescale = default;
            Optional<string> resultCode = default;
            Optional<string> trackName = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timestamp"u8))
                {
                    timestamp = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("trackType"u8))
                {
                    trackType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("bitrate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bitrate = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("timescale"u8))
                {
                    timescale = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultCode"u8))
                {
                    resultCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("trackName"u8))
                {
                    trackName = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MediaLiveEventIncomingDataChunkDroppedEventData(timestamp.Value, trackType.Value, Optional.ToNullable(bitrate), timescale.Value, resultCode.Value, trackName.Value, serializedAdditionalRawData);
        }

        MediaLiveEventIncomingDataChunkDroppedEventData IModelJsonSerializable<MediaLiveEventIncomingDataChunkDroppedEventData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MediaLiveEventIncomingDataChunkDroppedEventData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMediaLiveEventIncomingDataChunkDroppedEventData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MediaLiveEventIncomingDataChunkDroppedEventData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MediaLiveEventIncomingDataChunkDroppedEventData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MediaLiveEventIncomingDataChunkDroppedEventData IModelSerializable<MediaLiveEventIncomingDataChunkDroppedEventData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MediaLiveEventIncomingDataChunkDroppedEventData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMediaLiveEventIncomingDataChunkDroppedEventData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MediaLiveEventIncomingDataChunkDroppedEventData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MediaLiveEventIncomingDataChunkDroppedEventData"/> to convert. </param>
        public static implicit operator RequestContent(MediaLiveEventIncomingDataChunkDroppedEventData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MediaLiveEventIncomingDataChunkDroppedEventData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MediaLiveEventIncomingDataChunkDroppedEventData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMediaLiveEventIncomingDataChunkDroppedEventData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class MediaLiveEventIncomingDataChunkDroppedEventDataConverter : JsonConverter<MediaLiveEventIncomingDataChunkDroppedEventData>
        {
            public override void Write(Utf8JsonWriter writer, MediaLiveEventIncomingDataChunkDroppedEventData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override MediaLiveEventIncomingDataChunkDroppedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeMediaLiveEventIncomingDataChunkDroppedEventData(document.RootElement);
            }
        }
    }
}
