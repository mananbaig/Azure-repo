// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.Language.Models
{
    /// <summary> Represents Search Result. </summary>
    internal partial class QnASearchResult
    {
        /// <summary> Initializes a new instance of QnASearchResult. </summary>
        internal QnASearchResult()
        {
            Questions = new ChangeTrackingList<string>();
            Metadata = new ChangeTrackingList<Metadata>();
        }

        /// <summary> Initializes a new instance of QnASearchResult. </summary>
        /// <param name="questions"> List of questions. </param>
        /// <param name="answer"> Answer. </param>
        /// <param name="score"> Search result score. </param>
        /// <param name="id"> Id of the QnA result. </param>
        /// <param name="source"> Source of QnA result. </param>
        /// <param name="metadata"> List of metadata. </param>
        /// <param name="context"> Context object of the QnA. </param>
        /// <param name="answerSpan"> Answer span object of QnA with respect to user&apos;s question. </param>
        internal QnASearchResult(IReadOnlyList<string> questions, string answer, float? score, int? id, string source, IReadOnlyList<Metadata> metadata, Context context, AnswerSpanResponse answerSpan)
        {
            Questions = questions;
            Answer = answer;
            Score = score;
            Id = id;
            Source = source;
            Metadata = metadata;
            Context = context;
            AnswerSpan = answerSpan;
        }

        /// <summary> List of questions. </summary>
        public IReadOnlyList<string> Questions { get; }
        /// <summary> Answer. </summary>
        public string Answer { get; }
        /// <summary> Search result score. </summary>
        public float? Score { get; }
        /// <summary> Id of the QnA result. </summary>
        public int? Id { get; }
        /// <summary> Source of QnA result. </summary>
        public string Source { get; }
        /// <summary> List of metadata. </summary>
        public IReadOnlyList<Metadata> Metadata { get; }
        /// <summary> Context object of the QnA. </summary>
        public Context Context { get; }
        /// <summary> Answer span object of QnA with respect to user&apos;s question. </summary>
        public AnswerSpanResponse AnswerSpan { get; }
    }
}
