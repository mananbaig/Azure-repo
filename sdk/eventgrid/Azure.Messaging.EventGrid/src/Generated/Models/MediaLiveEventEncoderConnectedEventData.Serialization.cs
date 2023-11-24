// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(MediaLiveEventEncoderConnectedEventDataConverter))]
    public partial class MediaLiveEventEncoderConnectedEventData : IUtf8JsonSerializable, IJsonModel<MediaLiveEventEncoderConnectedEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MediaLiveEventEncoderConnectedEventData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MediaLiveEventEncoderConnectedEventData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaLiveEventEncoderConnectedEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(MediaLiveEventEncoderConnectedEventData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(IngestUrl))
            {
                writer.WritePropertyName("ingestUrl"u8);
                writer.WriteStringValue(IngestUrl);
            }
            if (options.Format != "W" && Optional.IsDefined(StreamId))
            {
                writer.WritePropertyName("streamId"u8);
                writer.WriteStringValue(StreamId);
            }
            if (options.Format != "W" && Optional.IsDefined(EncoderIp))
            {
                writer.WritePropertyName("encoderIp"u8);
                writer.WriteStringValue(EncoderIp);
            }
            if (options.Format != "W" && Optional.IsDefined(EncoderPort))
            {
                writer.WritePropertyName("encoderPort"u8);
                writer.WriteStringValue(EncoderPort);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        MediaLiveEventEncoderConnectedEventData IJsonModel<MediaLiveEventEncoderConnectedEventData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaLiveEventEncoderConnectedEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(MediaLiveEventEncoderConnectedEventData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMediaLiveEventEncoderConnectedEventData(document.RootElement, options);
        }

        internal static MediaLiveEventEncoderConnectedEventData DeserializeMediaLiveEventEncoderConnectedEventData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> ingestUrl = default;
            Optional<string> streamId = default;
            Optional<string> encoderIp = default;
            Optional<string> encoderPort = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ingestUrl"u8))
                {
                    ingestUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("streamId"u8))
                {
                    streamId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("encoderIp"u8))
                {
                    encoderIp = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("encoderPort"u8))
                {
                    encoderPort = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MediaLiveEventEncoderConnectedEventData(ingestUrl.Value, streamId.Value, encoderIp.Value, encoderPort.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MediaLiveEventEncoderConnectedEventData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaLiveEventEncoderConnectedEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(MediaLiveEventEncoderConnectedEventData)} does not support '{options.Format}' format.");
            }
        }

        MediaLiveEventEncoderConnectedEventData IPersistableModel<MediaLiveEventEncoderConnectedEventData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaLiveEventEncoderConnectedEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMediaLiveEventEncoderConnectedEventData(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(MediaLiveEventEncoderConnectedEventData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MediaLiveEventEncoderConnectedEventData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal partial class MediaLiveEventEncoderConnectedEventDataConverter : JsonConverter<MediaLiveEventEncoderConnectedEventData>
        {
            public override void Write(Utf8JsonWriter writer, MediaLiveEventEncoderConnectedEventData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override MediaLiveEventEncoderConnectedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeMediaLiveEventEncoderConnectedEventData(document.RootElement);
            }
        }
    }
}
