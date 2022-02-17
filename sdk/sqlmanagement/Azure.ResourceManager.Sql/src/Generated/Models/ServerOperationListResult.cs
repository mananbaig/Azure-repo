// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The response to a list server operations request. </summary>
    internal partial class ServerOperationListResult
    {
        /// <summary> Initializes a new instance of ServerOperationListResult. </summary>
        internal ServerOperationListResult()
        {
            Value = new ChangeTrackingList<ServerOperation>();
        }

        /// <summary> Initializes a new instance of ServerOperationListResult. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal ServerOperationListResult(IReadOnlyList<ServerOperation> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<ServerOperation> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
