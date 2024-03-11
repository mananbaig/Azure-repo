// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.AI.TextAnalytics;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial struct SentenceSentimentInternal : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("text"u8);
            writer.WriteStringValue(Text);
            writer.WritePropertyName("sentiment"u8);
            writer.WriteStringValue(Sentiment);
            writer.WritePropertyName("confidenceScores"u8);
            writer.WriteObjectValue(ConfidenceScores);
            writer.WritePropertyName("offset"u8);
            writer.WriteNumberValue(Offset);
            writer.WritePropertyName("length"u8);
            writer.WriteNumberValue(Length);
            if (Optional.IsCollectionDefined(Targets))
            {
                writer.WritePropertyName("targets"u8);
                writer.WriteStartArray();
                foreach (var item in Targets)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Assessments))
            {
                writer.WritePropertyName("assessments"u8);
                writer.WriteStartArray();
                foreach (var item in Assessments)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static SentenceSentimentInternal DeserializeSentenceSentimentInternal(JsonElement element)
        {
            string text = default;
            string sentiment = default;
            SentimentConfidenceScores confidenceScores = default;
            int offset = default;
            int length = default;
            IReadOnlyList<SentenceTarget> targets = default;
            IReadOnlyList<SentenceAssessment> assessments = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("text"u8))
                {
                    text = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sentiment"u8))
                {
                    sentiment = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("confidenceScores"u8))
                {
                    confidenceScores = SentimentConfidenceScores.DeserializeSentimentConfidenceScores(property.Value);
                    continue;
                }
                if (property.NameEquals("offset"u8))
                {
                    offset = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("length"u8))
                {
                    length = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("targets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SentenceTarget> array = new List<SentenceTarget>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SentenceTarget.DeserializeSentenceTarget(item));
                    }
                    targets = array;
                    continue;
                }
                if (property.NameEquals("assessments"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SentenceAssessment> array = new List<SentenceAssessment>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SentenceAssessment.DeserializeSentenceAssessment(item));
                    }
                    assessments = array;
                    continue;
                }
            }
            return new SentenceSentimentInternal(
                text,
                sentiment,
                confidenceScores,
                offset,
                length,
                targets ?? new ChangeTrackingList<SentenceTarget>(),
                assessments ?? new ChangeTrackingList<SentenceAssessment>());
        }
    }
}
