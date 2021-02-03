// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> Represents List of Question Answers. </summary>
    internal partial class QnASearchResultList
    {
        /// <summary> Initializes a new instance of QnASearchResultList. </summary>
        internal QnASearchResultList()
        {
            Answers = new ChangeTrackingList<QnASearchResult>();
        }

        /// <summary> Initializes a new instance of QnASearchResultList. </summary>
        /// <param name="answers"> Represents Search Result list. </param>
        internal QnASearchResultList(IReadOnlyList<QnASearchResult> answers)
        {
            Answers = answers;
        }

        /// <summary> Represents Search Result list. </summary>
        public IReadOnlyList<QnASearchResult> Answers { get; }
    }
}
