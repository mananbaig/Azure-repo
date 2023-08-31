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

namespace Azure.ResourceManager.Media.Models
{
    public partial class LiveEventEncoding : IUtf8JsonSerializable, IModelJsonSerializable<LiveEventEncoding>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<LiveEventEncoding>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<LiveEventEncoding>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(EncodingType))
            {
                writer.WritePropertyName("encodingType"u8);
                writer.WriteStringValue(EncodingType.Value.ToString());
            }
            if (Optional.IsDefined(PresetName))
            {
                writer.WritePropertyName("presetName"u8);
                writer.WriteStringValue(PresetName);
            }
            if (Optional.IsDefined(StretchMode))
            {
                if (StretchMode != null)
                {
                    writer.WritePropertyName("stretchMode"u8);
                    writer.WriteStringValue(StretchMode.Value.ToString());
                }
                else
                {
                    writer.WriteNull("stretchMode");
                }
            }
            if (Optional.IsDefined(KeyFrameInterval))
            {
                if (KeyFrameInterval != null)
                {
                    writer.WritePropertyName("keyFrameInterval"u8);
                    writer.WriteStringValue(KeyFrameInterval.Value, "P");
                }
                else
                {
                    writer.WriteNull("keyFrameInterval");
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

        internal static LiveEventEncoding DeserializeLiveEventEncoding(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<LiveEventEncodingType> encodingType = default;
            Optional<string> presetName = default;
            Optional<InputVideoStretchMode?> stretchMode = default;
            Optional<TimeSpan?> keyFrameInterval = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("encodingType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    encodingType = new LiveEventEncodingType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("presetName"u8))
                {
                    presetName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("stretchMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        stretchMode = null;
                        continue;
                    }
                    stretchMode = new InputVideoStretchMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("keyFrameInterval"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        keyFrameInterval = null;
                        continue;
                    }
                    keyFrameInterval = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new LiveEventEncoding(Optional.ToNullable(encodingType), presetName.Value, Optional.ToNullable(stretchMode), Optional.ToNullable(keyFrameInterval), rawData);
        }

        LiveEventEncoding IModelJsonSerializable<LiveEventEncoding>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeLiveEventEncoding(doc.RootElement, options);
        }

        BinaryData IModelSerializable<LiveEventEncoding>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        LiveEventEncoding IModelSerializable<LiveEventEncoding>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeLiveEventEncoding(doc.RootElement, options);
        }

        public static implicit operator RequestContent(LiveEventEncoding model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator LiveEventEncoding(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeLiveEventEncoding(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
