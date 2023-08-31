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
    /// <summary> Result of the request to list VirtualWANs. It contains a list of VirtualWANs and a URL nextLink to get the next set of results. </summary>
    internal partial class ListVirtualWANsResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ListVirtualWANsResult"/>. </summary>
        internal ListVirtualWANsResult()
        {
            Value = new ChangeTrackingList<VirtualWanData>();
        }

        /// <summary> Initializes a new instance of <see cref="ListVirtualWANsResult"/>. </summary>
        /// <param name="value"> List of VirtualWANs. </param>
        /// <param name="nextLink"> URL to get the next set of operation list results if there are any. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ListVirtualWANsResult(IReadOnlyList<VirtualWanData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> List of VirtualWANs. </summary>
        public IReadOnlyList<VirtualWanData> Value { get; }
        /// <summary> URL to get the next set of operation list results if there are any. </summary>
        public string NextLink { get; }
    }
}
