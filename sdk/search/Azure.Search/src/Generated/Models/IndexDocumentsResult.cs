// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Collections.Generic;

namespace Azure.Search.Models
{
    /// <summary> Response containing the status of operations for all documents in the indexing request. </summary>
    public partial class IndexDocumentsResult
    {
        /// <summary> The list of status information for each document in the indexing request. </summary>
        public ICollection<IndexingResult> Results { get; internal set; }
    }
}
