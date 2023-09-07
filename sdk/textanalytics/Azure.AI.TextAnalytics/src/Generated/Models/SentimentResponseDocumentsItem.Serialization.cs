// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.AI.TextAnalytics;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class SentimentResponseDocumentsItem : IUtf8JsonSerializable, IModelJsonSerializable<SentimentResponseDocumentsItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SentimentResponseDocumentsItem>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SentimentResponseDocumentsItem>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SentimentResponseDocumentsItem>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("sentiment"u8);
            writer.WriteStringValue(Sentiment.ToSerialString());
            writer.WritePropertyName("confidenceScores"u8);
            if (ConfidenceScores is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<SentimentConfidenceScores>)ConfidenceScores).Serialize(writer, options);
            }
            writer.WritePropertyName("sentences"u8);
            writer.WriteStartArray();
            foreach (var item in Sentences)
            {
                if (item is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<SentenceSentimentInternal>)item).Serialize(writer, options);
                }
            }
            writer.WriteEndArray();
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            writer.WritePropertyName("warnings"u8);
            writer.WriteStartArray();
            foreach (var item in Warnings)
            {
                if (item is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<DocumentWarning>)item).Serialize(writer, options);
                }
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(Statistics))
            {
                writer.WritePropertyName("statistics"u8);
                if (Statistics.Value is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<TextDocumentStatistics>)Statistics.Value).Serialize(writer, options);
                }
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

        internal static SentimentResponseDocumentsItem DeserializeSentimentResponseDocumentsItem(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TextSentiment sentiment = default;
            SentimentConfidenceScores confidenceScores = default;
            IList<SentenceSentimentInternal> sentences = default;
            string id = default;
            IList<DocumentWarning> warnings = default;
            Optional<TextDocumentStatistics> statistics = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sentiment"u8))
                {
                    sentiment = property.Value.GetString().ToTextSentiment();
                    continue;
                }
                if (property.NameEquals("confidenceScores"u8))
                {
                    confidenceScores = SentimentConfidenceScores.DeserializeSentimentConfidenceScores(property.Value);
                    continue;
                }
                if (property.NameEquals("sentences"u8))
                {
                    List<SentenceSentimentInternal> array = new List<SentenceSentimentInternal>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SentenceSentimentInternal.DeserializeSentenceSentimentInternal(item));
                    }
                    sentences = array;
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("warnings"u8))
                {
                    List<DocumentWarning> array = new List<DocumentWarning>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentWarning.DeserializeDocumentWarning(item));
                    }
                    warnings = array;
                    continue;
                }
                if (property.NameEquals("statistics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    statistics = TextDocumentStatistics.DeserializeTextDocumentStatistics(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SentimentResponseDocumentsItem(id, warnings, Optional.ToNullable(statistics), sentiment, confidenceScores, sentences, serializedAdditionalRawData);
        }

        SentimentResponseDocumentsItem IModelJsonSerializable<SentimentResponseDocumentsItem>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SentimentResponseDocumentsItem>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSentimentResponseDocumentsItem(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SentimentResponseDocumentsItem>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SentimentResponseDocumentsItem>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SentimentResponseDocumentsItem IModelSerializable<SentimentResponseDocumentsItem>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SentimentResponseDocumentsItem>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSentimentResponseDocumentsItem(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SentimentResponseDocumentsItem"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SentimentResponseDocumentsItem"/> to convert. </param>
        public static implicit operator RequestContent(SentimentResponseDocumentsItem model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SentimentResponseDocumentsItem"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SentimentResponseDocumentsItem(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSentimentResponseDocumentsItem(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
