// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.IoT.Hub.Service.Models
{
    /// <summary> The query result. </summary>
    public partial class QueryResult
    {
        /// <summary> Initializes a new instance of <see cref="QueryResult"/>. </summary>
        internal QueryResult()
        {
            Items = new ChangeTrackingList<object>();
        }

        /// <summary> Initializes a new instance of <see cref="QueryResult"/>. </summary>
        /// <param name="type"> The query result type. </param>
        /// <param name="items"> The query result items, as a collection. </param>
        /// <param name="continuationToken"> The continuation token. </param>
        internal QueryResult(QueryResultType? type, IReadOnlyList<object> items, string continuationToken)
        {
            Type = type;
            Items = items;
            ContinuationToken = continuationToken;
        }

        /// <summary> The query result type. </summary>
        public QueryResultType? Type { get; }
        /// <summary> The query result items, as a collection. </summary>
        public IReadOnlyList<object> Items { get; }
        /// <summary> The continuation token. </summary>
        public string ContinuationToken { get; }
    }
}
