// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.AI.TextAnalytics.Legacy.Models;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Legacy
{
    /// <summary> The SentenceTarget. </summary>
    internal partial class SentenceTarget
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SentenceTarget"/>. </summary>
        /// <param name="sentiment"> Targeted sentiment in the sentence. </param>
        /// <param name="confidenceScores"> Target sentiment confidence scores for the target in the sentence. </param>
        /// <param name="offset"> The target offset from the start of the sentence. </param>
        /// <param name="length"> The length of the target. </param>
        /// <param name="text"> The target text detected. </param>
        /// <param name="relations"> The array of either assessment or target objects which is related to the target. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="confidenceScores"/>, <paramref name="text"/> or <paramref name="relations"/> is null. </exception>
        internal SentenceTarget(TokenSentimentValue sentiment, TargetConfidenceScoreLabel confidenceScores, int offset, int length, string text, IEnumerable<TargetRelation> relations)
        {
            Argument.AssertNotNull(confidenceScores, nameof(confidenceScores));
            Argument.AssertNotNull(text, nameof(text));
            Argument.AssertNotNull(relations, nameof(relations));

            Sentiment = sentiment;
            ConfidenceScores = confidenceScores;
            Offset = offset;
            Length = length;
            Text = text;
            Relations = relations.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="SentenceTarget"/>. </summary>
        /// <param name="sentiment"> Targeted sentiment in the sentence. </param>
        /// <param name="confidenceScores"> Target sentiment confidence scores for the target in the sentence. </param>
        /// <param name="offset"> The target offset from the start of the sentence. </param>
        /// <param name="length"> The length of the target. </param>
        /// <param name="text"> The target text detected. </param>
        /// <param name="relations"> The array of either assessment or target objects which is related to the target. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SentenceTarget(TokenSentimentValue sentiment, TargetConfidenceScoreLabel confidenceScores, int offset, int length, string text, IReadOnlyList<TargetRelation> relations, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Sentiment = sentiment;
            ConfidenceScores = confidenceScores;
            Offset = offset;
            Length = length;
            Text = text;
            Relations = relations;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SentenceTarget"/> for deserialization. </summary>
        internal SentenceTarget()
        {
        }

        /// <summary> Targeted sentiment in the sentence. </summary>
        public TokenSentimentValue Sentiment { get; }
        /// <summary> Target sentiment confidence scores for the target in the sentence. </summary>
        public TargetConfidenceScoreLabel ConfidenceScores { get; }
        /// <summary> The target offset from the start of the sentence. </summary>
        public int Offset { get; }
        /// <summary> The length of the target. </summary>
        public int Length { get; }
        /// <summary> The target text detected. </summary>
        public string Text { get; }
        /// <summary> The array of either assessment or target objects which is related to the target. </summary>
        public IReadOnlyList<TargetRelation> Relations { get; }
    }
}
