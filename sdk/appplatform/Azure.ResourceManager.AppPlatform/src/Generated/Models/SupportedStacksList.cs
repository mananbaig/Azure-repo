// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppPlatform;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Object that includes an array of supported stacks resources and a possible link for next set. </summary>
    internal partial class SupportedStacksList
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SupportedStacksList"/>. </summary>
        internal SupportedStacksList()
        {
            Value = new ChangeTrackingList<AppPlatformSupportedStackData>();
        }

        /// <summary> Initializes a new instance of <see cref="SupportedStacksList"/>. </summary>
        /// <param name="value"> Collection of supported stacks resources. </param>
        /// <param name="nextLink">
        /// URL client should use to fetch the next page (per server side paging).
        /// It's null for now, added for future use.
        /// </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SupportedStacksList(IReadOnlyList<AppPlatformSupportedStackData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Collection of supported stacks resources. </summary>
        public IReadOnlyList<AppPlatformSupportedStackData> Value { get; }
        /// <summary>
        /// URL client should use to fetch the next page (per server side paging).
        /// It's null for now, added for future use.
        /// </summary>
        public string NextLink { get; }
    }
}
