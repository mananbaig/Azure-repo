// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The ExtractedSummarySentence. </summary>
    internal partial class ExtractedSummarySentence
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ExtractedSummarySentence"/>. </summary>
        /// <param name="text"> The extracted sentence text. </param>
        /// <param name="rankScore"> A double value representing the relevance of the sentence within the summary. Higher values indicate higher importance. </param>
        /// <param name="offset"> The sentence offset from the start of the document, based on the value of the parameter StringIndexType. </param>
        /// <param name="length"> The length of the sentence. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="text"/> is null. </exception>
        public ExtractedSummarySentence(string text, double rankScore, int offset, int length)
        {
            Argument.AssertNotNull(text, nameof(text));

            Text = text;
            RankScore = rankScore;
            Offset = offset;
            Length = length;
        }

        /// <summary> Initializes a new instance of <see cref="ExtractedSummarySentence"/>. </summary>
        /// <param name="text"> The extracted sentence text. </param>
        /// <param name="rankScore"> A double value representing the relevance of the sentence within the summary. Higher values indicate higher importance. </param>
        /// <param name="offset"> The sentence offset from the start of the document, based on the value of the parameter StringIndexType. </param>
        /// <param name="length"> The length of the sentence. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ExtractedSummarySentence(string text, double rankScore, int offset, int length, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Text = text;
            RankScore = rankScore;
            Offset = offset;
            Length = length;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ExtractedSummarySentence"/> for deserialization. </summary>
        internal ExtractedSummarySentence()
        {
        }

        /// <summary> The extracted sentence text. </summary>
        public string Text { get; set; }
        /// <summary> A double value representing the relevance of the sentence within the summary. Higher values indicate higher importance. </summary>
        public double RankScore { get; set; }
        /// <summary> The sentence offset from the start of the document, based on the value of the parameter StringIndexType. </summary>
        public int Offset { get; set; }
        /// <summary> The length of the sentence. </summary>
        public int Length { get; set; }
    }
}
