// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ArcScVmm;

namespace Azure.ResourceManager.ArcScVmm.Models
{
    /// <summary> List of VirtualNetworks. </summary>
    internal partial class VirtualNetworkListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="VirtualNetworkListResult"/>. </summary>
        internal VirtualNetworkListResult()
        {
            Value = new ChangeTrackingList<ScVmmVirtualNetworkData>();
        }

        /// <summary> Initializes a new instance of <see cref="VirtualNetworkListResult"/>. </summary>
        /// <param name="value"> List of VirtualNetworks. </param>
        /// <param name="nextLink"> Url to follow for getting next page of resources. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualNetworkListResult(IReadOnlyList<ScVmmVirtualNetworkData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> List of VirtualNetworks. </summary>
        public IReadOnlyList<ScVmmVirtualNetworkData> Value { get; }
        /// <summary> Url to follow for getting next page of resources. </summary>
        public string NextLink { get; }
    }
}
