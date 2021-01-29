// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.Language.QA.Models
{
    /// <summary> To configure Answer span prediction feature. </summary>
    internal partial class AnswerSpanRequestDTO
    {
        /// <summary> Initializes a new instance of AnswerSpanRequestDTO. </summary>
        public AnswerSpanRequestDTO()
        {
        }

        /// <summary> Enable or Disable Answer Span prediction. </summary>
        public bool? Enable { get; set; }
        /// <summary> Minimum threshold score required to include an answer span. </summary>
        public double? ScoreThreshold { get; set; }
        /// <summary> Number of Top answers to be considered for span prediction. </summary>
        public int? TopAnswersWithSpan { get; set; }
    }
}
