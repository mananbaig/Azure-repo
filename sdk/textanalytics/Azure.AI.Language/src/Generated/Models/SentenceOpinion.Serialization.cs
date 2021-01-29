// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.Models
{
    internal partial class SentenceOpinion
    {
        internal static SentenceOpinion DeserializeSentenceOpinion(JsonElement element)
        {
            string sentiment = default;
            AspectConfidenceScoreLabel confidenceScores = default;
            int offset = default;
            int length = default;
            string text = default;
            bool isNegated = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sentiment"))
                {
                    sentiment = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("confidenceScores"))
                {
                    confidenceScores = AspectConfidenceScoreLabel.DeserializeAspectConfidenceScoreLabel(property.Value);
                    continue;
                }
                if (property.NameEquals("offset"))
                {
                    offset = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("length"))
                {
                    length = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("text"))
                {
                    text = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isNegated"))
                {
                    isNegated = property.Value.GetBoolean();
                    continue;
                }
            }
            return new SentenceOpinion(sentiment, confidenceScores, offset, length, text, isNegated);
        }
    }
}
