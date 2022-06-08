// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.WebPubSub.Models
{
    /// <summary> The list skus operation response. </summary>
    internal partial class SkuList
    {
        /// <summary> Initializes a new instance of <see cref="SkuList"/>. </summary>
        internal SkuList()
        {
            Value = new ChangeTrackingList<WebPubSubResourceSku>();
        }

        /// <summary> Initializes a new instance of <see cref="SkuList"/>. </summary>
        /// <param name="value"> The list of skus available for the resource. </param>
        /// <param name="nextLink">
        /// The URL the client should use to fetch the next page (per server side paging).
        /// It&apos;s null for now, added for future use.
        /// </param>
        internal SkuList(IReadOnlyList<WebPubSubResourceSku> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of skus available for the resource. </summary>
        public IReadOnlyList<WebPubSubResourceSku> Value { get; }
        /// <summary>
        /// The URL the client should use to fetch the next page (per server side paging).
        /// It&apos;s null for now, added for future use.
        /// </summary>
        public string NextLink { get; }
    }
}
