// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Search.Documents.Models
{
    /// <summary> The breakdown of subscores between the text and vector query components of the search query for this document. Each vector query is shown as a separate object in the same order they were received. </summary>
    public partial class QueryResultDocumentSubscores
    {
        /// <summary> Initializes a new instance of <see cref="QueryResultDocumentSubscores"/>. </summary>
        internal QueryResultDocumentSubscores()
        {
            Vectors = new ChangeTrackingList<IDictionary<string, SingleVectorFieldResult>>();
        }

        /// <summary> Initializes a new instance of <see cref="QueryResultDocumentSubscores"/>. </summary>
        /// <param name="text"> The BM25 or Classic score for the text portion of the query. </param>
        /// <param name="vectors"> The vector similarity and @search.score values for each vector query. </param>
        /// <param name="documentBoost"> The BM25 or Classic score for the text portion of the query. </param>
        internal QueryResultDocumentSubscores(TextResult text, IReadOnlyList<IDictionary<string, SingleVectorFieldResult>> vectors, double? documentBoost)
        {
            Text = text;
            Vectors = vectors;
            DocumentBoost = documentBoost;
        }

        /// <summary> The BM25 or Classic score for the text portion of the query. </summary>
        public TextResult Text { get; }
        /// <summary> The vector similarity and @search.score values for each vector query. </summary>
        public IReadOnlyList<IDictionary<string, SingleVectorFieldResult>> Vectors { get; }
        /// <summary> The BM25 or Classic score for the text portion of the query. </summary>
        public double? DocumentBoost { get; }
    }
}
