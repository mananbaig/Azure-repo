// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.AI.TextAnalytics;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> Supported parameters for an Extractive Summarization task. </summary>
    internal partial class ExtractiveSummarizationTaskParameters : PreBuiltTaskParameters
    {
        /// <summary> Initializes a new instance of <see cref="ExtractiveSummarizationTaskParameters"/>. </summary>
        public ExtractiveSummarizationTaskParameters()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ExtractiveSummarizationTaskParameters"/>. </summary>
        /// <param name="loggingOptOut"></param>
        /// <param name="modelVersion"></param>
        /// <param name="sentenceCount"></param>
        /// <param name="sortBy"> The sorting criteria to use for the results of Extractive Summarization. </param>
        /// <param name="stringIndexType"> Specifies the method used to interpret string offsets.  Defaults to Text Elements (Graphemes) according to Unicode v8.0.0. For additional information see https://aka.ms/text-analytics-offsets. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ExtractiveSummarizationTaskParameters(bool? loggingOptOut, string modelVersion, int? sentenceCount, ExtractiveSummarySentencesOrder? sortBy, StringIndexType? stringIndexType, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(loggingOptOut, modelVersion, serializedAdditionalRawData)
        {
            SentenceCount = sentenceCount;
            SortBy = sortBy;
            StringIndexType = stringIndexType;
        }

        /// <summary> Gets or sets the sentence count. </summary>
        public int? SentenceCount { get; set; }
        /// <summary> The sorting criteria to use for the results of Extractive Summarization. </summary>
        public ExtractiveSummarySentencesOrder? SortBy { get; set; }
        /// <summary> Specifies the method used to interpret string offsets.  Defaults to Text Elements (Graphemes) according to Unicode v8.0.0. For additional information see https://aka.ms/text-analytics-offsets. </summary>
        public StringIndexType? StringIndexType { get; set; }
    }
}
