// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Legacy
{
    /// <summary> The Match. </summary>
    internal partial class Match
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="Match"/>. </summary>
        /// <param name="confidenceScore"> If a well known item is recognized, a decimal number denoting the confidence level between 0 and 1 will be returned. </param>
        /// <param name="text"> Entity text as appears in the request. </param>
        /// <param name="offset"> Start position for the entity match text. </param>
        /// <param name="length"> Length for the entity match text. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal Match(double confidenceScore, string text, int offset, int length, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ConfidenceScore = confidenceScore;
            Text = text;
            Offset = offset;
            Length = length;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="Match"/> for deserialization. </summary>
        internal Match()
        {
        }

        /// <summary> If a well known item is recognized, a decimal number denoting the confidence level between 0 and 1 will be returned. </summary>
        public double ConfidenceScore { get; }
        /// <summary> Entity text as appears in the request. </summary>
        public string Text { get; }
        /// <summary> Start position for the entity match text. </summary>
        public int Offset { get; }
        /// <summary> Length for the entity match text. </summary>
        public int Length { get; }
    }
}
