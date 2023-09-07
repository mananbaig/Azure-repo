// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.AI.TextAnalytics;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The PiiEntityRecognitionLROResult. </summary>
    internal partial class PiiEntityRecognitionLROResult : AnalyzeTextLROResult
    {
        /// <summary> Initializes a new instance of <see cref="PiiEntityRecognitionLROResult"/>. </summary>
        /// <param name="lastUpdateDateTime"></param>
        /// <param name="status"></param>
        /// <param name="results"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="results"/> is null. </exception>
        public PiiEntityRecognitionLROResult(DateTimeOffset lastUpdateDateTime, TextAnalyticsOperationStatus status, PiiEntitiesResult results) : base(lastUpdateDateTime, status)
        {
            Argument.AssertNotNull(results, nameof(results));

            Results = results;
            Kind = AnalyzeTextLROResultsKind.PiiEntityRecognitionLROResults;
        }

        /// <summary> Initializes a new instance of <see cref="PiiEntityRecognitionLROResult"/>. </summary>
        /// <param name="lastUpdateDateTime"></param>
        /// <param name="status"></param>
        /// <param name="kind"> Enumeration of supported Text Analysis long-running operation task results. </param>
        /// <param name="taskName"></param>
        /// <param name="results"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PiiEntityRecognitionLROResult(DateTimeOffset lastUpdateDateTime, TextAnalyticsOperationStatus status, AnalyzeTextLROResultsKind kind, string taskName, PiiEntitiesResult results, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(lastUpdateDateTime, status, kind, taskName, serializedAdditionalRawData)
        {
            Results = results;
            Kind = kind;
        }

        /// <summary> Initializes a new instance of <see cref="PiiEntityRecognitionLROResult"/> for deserialization. </summary>
        internal PiiEntityRecognitionLROResult()
        {
        }

        /// <summary> Gets or sets the results. </summary>
        public PiiEntitiesResult Results { get; set; }
    }
}
