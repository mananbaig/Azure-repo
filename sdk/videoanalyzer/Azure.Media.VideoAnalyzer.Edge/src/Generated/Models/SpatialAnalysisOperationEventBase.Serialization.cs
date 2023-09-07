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
    public partial class SpatialAnalysisOperationEventBase : IUtf8JsonSerializable, IModelJsonSerializable<SpatialAnalysisOperationEventBase>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SpatialAnalysisOperationEventBase>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SpatialAnalysisOperationEventBase>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SpatialAnalysisOperationEventBase>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Threshold))
            {
                writer.WritePropertyName("threshold"u8);
                writer.WriteStringValue(Threshold);
            }
            if (Optional.IsDefined(Focus))
            {
                writer.WritePropertyName("focus"u8);
                writer.WriteStringValue(Focus.Value.ToString());
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

        internal static SpatialAnalysisOperationEventBase DeserializeSpatialAnalysisOperationEventBase(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> threshold = default;
            Optional<SpatialAnalysisOperationFocus> focus = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("threshold"u8))
                {
                    threshold = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("focus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    focus = new SpatialAnalysisOperationFocus(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SpatialAnalysisOperationEventBase(threshold.Value, Optional.ToNullable(focus), serializedAdditionalRawData);
        }

        SpatialAnalysisOperationEventBase IModelJsonSerializable<SpatialAnalysisOperationEventBase>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SpatialAnalysisOperationEventBase>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSpatialAnalysisOperationEventBase(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SpatialAnalysisOperationEventBase>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SpatialAnalysisOperationEventBase>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SpatialAnalysisOperationEventBase IModelSerializable<SpatialAnalysisOperationEventBase>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SpatialAnalysisOperationEventBase>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSpatialAnalysisOperationEventBase(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SpatialAnalysisOperationEventBase"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SpatialAnalysisOperationEventBase"/> to convert. </param>
        public static implicit operator RequestContent(SpatialAnalysisOperationEventBase model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SpatialAnalysisOperationEventBase"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SpatialAnalysisOperationEventBase(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSpatialAnalysisOperationEventBase(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
