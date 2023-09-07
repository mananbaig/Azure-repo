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
    public partial class OnvifSystemDateTime : IUtf8JsonSerializable, IModelJsonSerializable<OnvifSystemDateTime>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<OnvifSystemDateTime>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<OnvifSystemDateTime>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<OnvifSystemDateTime>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Type))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(Type.Value.ToString());
            }
            if (Optional.IsDefined(Time))
            {
                writer.WritePropertyName("time"u8);
                writer.WriteStringValue(Time);
            }
            if (Optional.IsDefined(TimeZone))
            {
                writer.WritePropertyName("timeZone"u8);
                writer.WriteStringValue(TimeZone);
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

        internal static OnvifSystemDateTime DeserializeOnvifSystemDateTime(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<OnvifSystemDateTimeType> type = default;
            Optional<string> time = default;
            Optional<string> timeZone = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new OnvifSystemDateTimeType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("time"u8))
                {
                    time = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timeZone"u8))
                {
                    timeZone = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new OnvifSystemDateTime(Optional.ToNullable(type), time.Value, timeZone.Value, serializedAdditionalRawData);
        }

        OnvifSystemDateTime IModelJsonSerializable<OnvifSystemDateTime>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<OnvifSystemDateTime>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeOnvifSystemDateTime(doc.RootElement, options);
        }

        BinaryData IModelSerializable<OnvifSystemDateTime>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<OnvifSystemDateTime>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        OnvifSystemDateTime IModelSerializable<OnvifSystemDateTime>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<OnvifSystemDateTime>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeOnvifSystemDateTime(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="OnvifSystemDateTime"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="OnvifSystemDateTime"/> to convert. </param>
        public static implicit operator RequestContent(OnvifSystemDateTime model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="OnvifSystemDateTime"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator OnvifSystemDateTime(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeOnvifSystemDateTime(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
