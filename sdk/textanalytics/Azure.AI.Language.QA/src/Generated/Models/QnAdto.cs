// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.AI.Language.QA.Models
{
    /// <summary> Q-A object. </summary>
    internal partial class QnAdto
    {
        /// <summary> Initializes a new instance of QnAdto. </summary>
        /// <param name="answer"> Answer text. </param>
        /// <param name="questions"> List of questions associated with the answer. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="answer"/> or <paramref name="questions"/> is null. </exception>
        public QnAdto(string answer, IEnumerable<string> questions)
        {
            if (answer == null)
            {
                throw new ArgumentNullException(nameof(answer));
            }
            if (questions == null)
            {
                throw new ArgumentNullException(nameof(questions));
            }

            Answer = answer;
            Questions = questions.ToList();
            Metadata = new ChangeTrackingList<MetadataDTO>();
        }

        /// <summary> Initializes a new instance of QnAdto. </summary>
        /// <param name="id"> Unique id for the Q-A. </param>
        /// <param name="answer"> Answer text. </param>
        /// <param name="source"> Source from which Q-A was indexed. eg. https://docs.microsoft.com/en-us/azure/cognitive-services/QnAMaker/FAQs. </param>
        /// <param name="questions"> List of questions associated with the answer. </param>
        /// <param name="metadata"> List of metadata associated with the answer. </param>
        /// <param name="context"> Context of a QnA. </param>
        /// <param name="lastUpdatedTimestamp"> Timestamp when the QnA was last updated. </param>
        internal QnAdto(int? id, string answer, string source, IList<string> questions, IList<MetadataDTO> metadata, ContextDTO context, string lastUpdatedTimestamp)
        {
            Id = id;
            Answer = answer;
            Source = source;
            Questions = questions;
            Metadata = metadata;
            Context = context;
            LastUpdatedTimestamp = lastUpdatedTimestamp;
        }

        /// <summary> Unique id for the Q-A. </summary>
        public int? Id { get; set; }
        /// <summary> Answer text. </summary>
        public string Answer { get; set; }
        /// <summary> Source from which Q-A was indexed. eg. https://docs.microsoft.com/en-us/azure/cognitive-services/QnAMaker/FAQs. </summary>
        public string Source { get; set; }
        /// <summary> List of questions associated with the answer. </summary>
        public IList<string> Questions { get; }
        /// <summary> List of metadata associated with the answer. </summary>
        public IList<MetadataDTO> Metadata { get; }
        /// <summary> Context of a QnA. </summary>
        public ContextDTO Context { get; set; }
        /// <summary> Timestamp when the QnA was last updated. </summary>
        public string LastUpdatedTimestamp { get; set; }
    }
}
