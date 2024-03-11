// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Media;

namespace Azure.ResourceManager.Media.Models
{
    public partial class H265Layer : IUtf8JsonSerializable, IJsonModel<H265Layer>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<H265Layer>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<H265Layer>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<H265Layer>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(H265Layer)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Profile))
            {
                writer.WritePropertyName("profile"u8);
                writer.WriteStringValue(Profile.Value.ToString());
            }
            if (Optional.IsDefined(Level))
            {
                writer.WritePropertyName("level"u8);
                writer.WriteStringValue(Level);
            }
            if (Optional.IsDefined(BufferWindow))
            {
                writer.WritePropertyName("bufferWindow"u8);
                writer.WriteStringValue(BufferWindow.Value, "P");
            }
            if (Optional.IsDefined(Crf))
            {
                writer.WritePropertyName("crf"u8);
                writer.WriteNumberValue(Crf.Value);
            }
            if (Optional.IsDefined(ReferenceFrames))
            {
                writer.WritePropertyName("referenceFrames"u8);
                writer.WriteNumberValue(ReferenceFrames.Value);
            }
            writer.WritePropertyName("bitrate"u8);
            writer.WriteNumberValue(Bitrate);
            if (Optional.IsDefined(MaxBitrate))
            {
                writer.WritePropertyName("maxBitrate"u8);
                writer.WriteNumberValue(MaxBitrate.Value);
            }
            if (Optional.IsDefined(BFrames))
            {
                writer.WritePropertyName("bFrames"u8);
                writer.WriteNumberValue(BFrames.Value);
            }
            if (Optional.IsDefined(FrameRate))
            {
                writer.WritePropertyName("frameRate"u8);
                writer.WriteStringValue(FrameRate);
            }
            if (Optional.IsDefined(Slices))
            {
                writer.WritePropertyName("slices"u8);
                writer.WriteNumberValue(Slices.Value);
            }
            if (Optional.IsDefined(UseAdaptiveBFrame))
            {
                writer.WritePropertyName("adaptiveBFrame"u8);
                writer.WriteBooleanValue(UseAdaptiveBFrame.Value);
            }
            if (Optional.IsDefined(Width))
            {
                writer.WritePropertyName("width"u8);
                writer.WriteStringValue(Width);
            }
            if (Optional.IsDefined(Height))
            {
                writer.WritePropertyName("height"u8);
                writer.WriteStringValue(Height);
            }
            if (Optional.IsDefined(Label))
            {
                writer.WritePropertyName("label"u8);
                writer.WriteStringValue(Label);
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

        H265Layer IJsonModel<H265Layer>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<H265Layer>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(H265Layer)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeH265Layer(document.RootElement, options);
        }

        internal static H265Layer DeserializeH265Layer(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            H265VideoProfile? profile = default;
            string level = default;
            TimeSpan? bufferWindow = default;
            float? crf = default;
            int? referenceFrames = default;
            int bitrate = default;
            int? maxBitrate = default;
            int? bFrames = default;
            string frameRate = default;
            int? slices = default;
            bool? adaptiveBFrame = default;
            string width = default;
            string height = default;
            string label = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("profile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    profile = new H265VideoProfile(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("level"u8))
                {
                    level = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("bufferWindow"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bufferWindow = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("crf"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    crf = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("referenceFrames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    referenceFrames = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("bitrate"u8))
                {
                    bitrate = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxBitrate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxBitrate = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("bFrames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bFrames = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("frameRate"u8))
                {
                    frameRate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("slices"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    slices = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("adaptiveBFrame"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    adaptiveBFrame = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("width"u8))
                {
                    width = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("height"u8))
                {
                    height = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("label"u8))
                {
                    label = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new H265Layer(
                width,
                height,
                label,
                serializedAdditionalRawData,
                bitrate,
                maxBitrate,
                bFrames,
                frameRate,
                slices,
                adaptiveBFrame,
                profile,
                level,
                bufferWindow,
                crf,
                referenceFrames);
        }

        BinaryData IPersistableModel<H265Layer>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<H265Layer>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(H265Layer)} does not support '{options.Format}' format.");
            }
        }

        H265Layer IPersistableModel<H265Layer>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<H265Layer>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeH265Layer(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(H265Layer)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<H265Layer>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
