// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Search.Documents.Models
{
    /// <summary> The raw concatenated strings that were sent to the semantic enrichment process. </summary>
    public partial class QueryResultDocumentRerankerInput
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="QueryResultDocumentRerankerInput"/>. </summary>
        internal QueryResultDocumentRerankerInput()
        {
        }

        /// <summary> Initializes a new instance of <see cref="QueryResultDocumentRerankerInput"/>. </summary>
        /// <param name="title"> The raw string for the title field that was used for semantic enrichment. </param>
        /// <param name="content"> The raw concatenated strings for the content fields that were used for semantic enrichment. </param>
        /// <param name="keywords"> The raw concatenated strings for the keyword fields that were used for semantic enrichment. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal QueryResultDocumentRerankerInput(string title, string content, string keywords, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Title = title;
            Content = content;
            Keywords = keywords;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The raw string for the title field that was used for semantic enrichment. </summary>
        public string Title { get; }
        /// <summary> The raw concatenated strings for the content fields that were used for semantic enrichment. </summary>
        public string Content { get; }
        /// <summary> The raw concatenated strings for the keyword fields that were used for semantic enrichment. </summary>
        public string Keywords { get; }
    }
}
