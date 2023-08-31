// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Response for ListCustomIpPrefixes API service call. </summary>
    internal partial class CustomIPPrefixListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CustomIPPrefixListResult"/>. </summary>
        internal CustomIPPrefixListResult()
        {
            Value = new ChangeTrackingList<CustomIPPrefixData>();
        }

        /// <summary> Initializes a new instance of <see cref="CustomIPPrefixListResult"/>. </summary>
        /// <param name="value"> A list of Custom IP prefixes that exists in a resource group. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CustomIPPrefixListResult(IReadOnlyList<CustomIPPrefixData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> A list of Custom IP prefixes that exists in a resource group. </summary>
        public IReadOnlyList<CustomIPPrefixData> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
