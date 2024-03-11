// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    [PersistableModelProxy(typeof(UnknownTrackDescriptor))]
    public partial class TrackDescriptor : IUtf8JsonSerializable, IJsonModel<TrackDescriptor>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TrackDescriptor>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<TrackDescriptor>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrackDescriptor>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TrackDescriptor)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(OdataType);
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

        TrackDescriptor IJsonModel<TrackDescriptor>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrackDescriptor>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TrackDescriptor)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTrackDescriptor(document.RootElement, options);
        }

        internal static TrackDescriptor DeserializeTrackDescriptor(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("@odata.type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "#Microsoft.Media.AudioTrackDescriptor": return AudioTrackDescriptor.DeserializeAudioTrackDescriptor(element, options);
                    case "#Microsoft.Media.SelectAudioTrackByAttribute": return SelectAudioTrackByAttribute.DeserializeSelectAudioTrackByAttribute(element, options);
                    case "#Microsoft.Media.SelectAudioTrackById": return SelectAudioTrackById.DeserializeSelectAudioTrackById(element, options);
                    case "#Microsoft.Media.SelectVideoTrackByAttribute": return SelectVideoTrackByAttribute.DeserializeSelectVideoTrackByAttribute(element, options);
                    case "#Microsoft.Media.SelectVideoTrackById": return SelectVideoTrackById.DeserializeSelectVideoTrackById(element, options);
                    case "#Microsoft.Media.VideoTrackDescriptor": return VideoTrackDescriptor.DeserializeVideoTrackDescriptor(element, options);
                }
            }
            return UnknownTrackDescriptor.DeserializeUnknownTrackDescriptor(element, options);
        }

        BinaryData IPersistableModel<TrackDescriptor>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrackDescriptor>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TrackDescriptor)} does not support '{options.Format}' format.");
            }
        }

        TrackDescriptor IPersistableModel<TrackDescriptor>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrackDescriptor>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTrackDescriptor(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TrackDescriptor)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<TrackDescriptor>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
