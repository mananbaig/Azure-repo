// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> Context of a QnA. </summary>
    public partial class QnAContext : Context
    {
        /// <summary> Initializes a new instance of QnAContext. </summary>
        internal QnAContext()
        {
        }

        /// <summary> Initializes a new instance of QnAContext. </summary>
        /// <param name="isContextOnly">
        /// To mark if a prompt is relevant only with a previous question or not.
        /// true - Do not include this QnA as search result for queries without context
        /// false - ignores context and includes this QnA in search result.
        /// </param>
        /// <param name="prompts"> List of prompts associated with the answer. </param>
        internal QnAContext(bool? isContextOnly, IReadOnlyList<Prompt> prompts) : base(isContextOnly, prompts)
        {
        }
    }
}
