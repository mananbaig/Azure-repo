// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.PrivateDns;

namespace Azure.ResourceManager.PrivateDns.Models
{
    /// <summary> The response to a list virtual network link to Private DNS zone operation. </summary>
    internal partial class VirtualNetworkLinkListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="VirtualNetworkLinkListResult"/>. </summary>
        internal VirtualNetworkLinkListResult()
        {
            Value = new ChangeTrackingList<VirtualNetworkLinkData>();
        }

        /// <summary> Initializes a new instance of <see cref="VirtualNetworkLinkListResult"/>. </summary>
        /// <param name="value"> Information about the virtual network links to the Private DNS zones. </param>
        /// <param name="nextLink"> The continuation token for the next page of results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualNetworkLinkListResult(IReadOnlyList<VirtualNetworkLinkData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Information about the virtual network links to the Private DNS zones. </summary>
        public IReadOnlyList<VirtualNetworkLinkData> Value { get; }
        /// <summary> The continuation token for the next page of results. </summary>
        public string NextLink { get; }
    }
}
