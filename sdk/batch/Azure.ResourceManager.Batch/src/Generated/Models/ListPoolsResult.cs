// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Batch;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> Values returned by the List operation. </summary>
    internal partial class ListPoolsResult
    {
        /// <summary> Initializes a new instance of ListPoolsResult. </summary>
        internal ListPoolsResult()
        {
            Value = new ChangeTrackingList<BatchAccountPoolData>();
        }

        /// <summary> Initializes a new instance of ListPoolsResult. </summary>
        /// <param name="value"> The collection of returned pools. </param>
        /// <param name="nextLink"> The continuation token. </param>
        internal ListPoolsResult(IReadOnlyList<BatchAccountPoolData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The collection of returned pools. </summary>
        public IReadOnlyList<BatchAccountPoolData> Value { get; }
        /// <summary> The continuation token. </summary>
        public string NextLink { get; }
    }
}
