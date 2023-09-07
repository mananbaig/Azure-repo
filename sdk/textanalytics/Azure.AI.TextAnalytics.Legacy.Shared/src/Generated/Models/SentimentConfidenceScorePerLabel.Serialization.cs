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

namespace Azure.AI.TextAnalytics.Legacy
{
    internal partial class SentimentConfidenceScorePerLabel : IUtf8JsonSerializable, IModelJsonSerializable<SentimentConfidenceScorePerLabel>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SentimentConfidenceScorePerLabel>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SentimentConfidenceScorePerLabel>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SentimentConfidenceScorePerLabel>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("positive"u8);
            writer.WriteNumberValue(Positive);
            writer.WritePropertyName("neutral"u8);
            writer.WriteNumberValue(Neutral);
            writer.WritePropertyName("negative"u8);
            writer.WriteNumberValue(Negative);
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

        internal static SentimentConfidenceScorePerLabel DeserializeSentimentConfidenceScorePerLabel(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            double positive = default;
            double neutral = default;
            double negative = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("positive"u8))
                {
                    positive = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("neutral"u8))
                {
                    neutral = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("negative"u8))
                {
                    negative = property.Value.GetDouble();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SentimentConfidenceScorePerLabel(positive, neutral, negative, serializedAdditionalRawData);
        }

        SentimentConfidenceScorePerLabel IModelJsonSerializable<SentimentConfidenceScorePerLabel>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SentimentConfidenceScorePerLabel>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSentimentConfidenceScorePerLabel(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SentimentConfidenceScorePerLabel>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SentimentConfidenceScorePerLabel>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SentimentConfidenceScorePerLabel IModelSerializable<SentimentConfidenceScorePerLabel>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SentimentConfidenceScorePerLabel>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSentimentConfidenceScorePerLabel(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SentimentConfidenceScorePerLabel"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SentimentConfidenceScorePerLabel"/> to convert. </param>
        public static implicit operator RequestContent(SentimentConfidenceScorePerLabel model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SentimentConfidenceScorePerLabel"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SentimentConfidenceScorePerLabel(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSentimentConfidenceScorePerLabel(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
