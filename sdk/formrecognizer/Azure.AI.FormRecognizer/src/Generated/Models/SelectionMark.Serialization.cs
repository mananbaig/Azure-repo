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

namespace Azure.AI.FormRecognizer.Models
{
    internal partial class SelectionMark : IUtf8JsonSerializable, IModelJsonSerializable<SelectionMark>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SelectionMark>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SelectionMark>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SelectionMark>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("boundingBox"u8);
            writer.WriteStartArray();
            foreach (var item in BoundingBox)
            {
                writer.WriteNumberValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("confidence"u8);
            writer.WriteNumberValue(Confidence);
            writer.WritePropertyName("state"u8);
            writer.WriteStringValue(State.ToSerialString());
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

        internal static SelectionMark DeserializeSelectionMark(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<float> boundingBox = default;
            float confidence = default;
            SelectionMarkState state = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("boundingBox"u8))
                {
                    List<float> array = new List<float>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetSingle());
                    }
                    boundingBox = array;
                    continue;
                }
                if (property.NameEquals("confidence"u8))
                {
                    confidence = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    state = property.Value.GetString().ToSelectionMarkState();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SelectionMark(boundingBox, confidence, state, serializedAdditionalRawData);
        }

        SelectionMark IModelJsonSerializable<SelectionMark>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SelectionMark>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSelectionMark(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SelectionMark>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SelectionMark>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SelectionMark IModelSerializable<SelectionMark>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SelectionMark>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSelectionMark(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SelectionMark"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SelectionMark"/> to convert. </param>
        public static implicit operator RequestContent(SelectionMark model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SelectionMark"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SelectionMark(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSelectionMark(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
