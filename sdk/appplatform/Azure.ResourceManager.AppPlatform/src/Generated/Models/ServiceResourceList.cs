// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppPlatform;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Object that includes an array of Service resources and a possible link for next set. </summary>
    internal partial class ServiceResourceList
    {
        /// <summary> Initializes a new instance of ServiceResourceList. </summary>
        internal ServiceResourceList()
        {
            Value = new ChangeTrackingList<AppPlatformServiceResourceData>();
        }

        /// <summary> Initializes a new instance of ServiceResourceList. </summary>
        /// <param name="value"> Collection of Service resources. </param>
        /// <param name="nextLink">
        /// URL client should use to fetch the next page (per server side paging).
        /// It&apos;s null for now, added for future use.
        /// </param>
        internal ServiceResourceList(IReadOnlyList<AppPlatformServiceResourceData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Collection of Service resources. </summary>
        public IReadOnlyList<AppPlatformServiceResourceData> Value { get; }
        /// <summary>
        /// URL client should use to fetch the next page (per server side paging).
        /// It&apos;s null for now, added for future use.
        /// </summary>
        public string NextLink { get; }
    }
}
