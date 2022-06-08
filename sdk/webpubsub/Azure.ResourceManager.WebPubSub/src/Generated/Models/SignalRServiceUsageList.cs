// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.WebPubSub.Models
{
    /// <summary> Object that includes an array of the resource usages and a possible link for next set. </summary>
    internal partial class SignalRServiceUsageList
    {
        /// <summary> Initializes a new instance of <see cref="SignalRServiceUsageList"/>. </summary>
        internal SignalRServiceUsageList()
        {
            Value = new ChangeTrackingList<SignalRServiceUsage>();
        }

        /// <summary> Initializes a new instance of <see cref="SignalRServiceUsageList"/>. </summary>
        /// <param name="value"> List of the resource usages. </param>
        /// <param name="nextLink">
        /// The URL the client should use to fetch the next page (per server side paging).
        /// It&apos;s null for now, added for future use.
        /// </param>
        internal SignalRServiceUsageList(IReadOnlyList<SignalRServiceUsage> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of the resource usages. </summary>
        public IReadOnlyList<SignalRServiceUsage> Value { get; }
        /// <summary>
        /// The URL the client should use to fetch the next page (per server side paging).
        /// It&apos;s null for now, added for future use.
        /// </summary>
        public string NextLink { get; }
    }
}
