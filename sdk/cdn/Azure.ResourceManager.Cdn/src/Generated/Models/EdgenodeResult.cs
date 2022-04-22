// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Result of the request to list CDN edgenodes. It contains a list of ip address group and a URL link to get the next set of results. </summary>
    internal partial class EdgenodeResult
    {
        /// <summary> Initializes a new instance of EdgenodeResult. </summary>
        internal EdgenodeResult()
        {
            Value = new ChangeTrackingList<EdgeNode>();
        }

        /// <summary> Initializes a new instance of EdgenodeResult. </summary>
        /// <param name="value"> Edge node of CDN service. </param>
        /// <param name="nextLink"> URL to get the next set of edgenode list results if there are any. </param>
        internal EdgenodeResult(IReadOnlyList<EdgeNode> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Edge node of CDN service. </summary>
        public IReadOnlyList<EdgeNode> Value { get; }
        /// <summary> URL to get the next set of edgenode list results if there are any. </summary>
        public string NextLink { get; }
    }
}
