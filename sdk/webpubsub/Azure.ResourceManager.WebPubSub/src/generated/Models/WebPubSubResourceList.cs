// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.WebPubSub;

namespace Azure.ResourceManager.WebPubSub.Models
{
    /// <summary> Object that includes an array of resources and a possible link for next set. </summary>
    internal partial class WebPubSubResourceList
    {
        /// <summary> Initializes a new instance of WebPubSubResourceList. </summary>
        internal WebPubSubResourceList()
        {
            Value = new ChangeTrackingList<WebPubSubResourceData>();
        }

        /// <summary> Initializes a new instance of WebPubSubResourceList. </summary>
        /// <param name="value"> List of the resources. </param>
        /// <param name="nextLink">
        /// The URL the client should use to fetch the next page (per server side paging).
        /// It&apos;s null for now, added for future use.
        /// </param>
        internal WebPubSubResourceList(IReadOnlyList<WebPubSubResourceData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of the resources. </summary>
        public IReadOnlyList<WebPubSubResourceData> Value { get; }
        /// <summary>
        /// The URL the client should use to fetch the next page (per server side paging).
        /// It&apos;s null for now, added for future use.
        /// </summary>
        public string NextLink { get; }
    }
}
