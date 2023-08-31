// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.NetworkCloud;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> L2NetworkList represents a list of L2 networks. </summary>
    internal partial class L2NetworkList
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="L2NetworkList"/>. </summary>
        internal L2NetworkList()
        {
            Value = new ChangeTrackingList<NetworkCloudL2NetworkData>();
        }

        /// <summary> Initializes a new instance of <see cref="L2NetworkList"/>. </summary>
        /// <param name="nextLink"> The link used to get the next page of operations. </param>
        /// <param name="value"> The list of L2 networks. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal L2NetworkList(string nextLink, IReadOnlyList<NetworkCloudL2NetworkData> value, Dictionary<string, BinaryData> rawData)
        {
            NextLink = nextLink;
            Value = value;
            _rawData = rawData;
        }

        /// <summary> The link used to get the next page of operations. </summary>
        public string NextLink { get; }
        /// <summary> The list of L2 networks. </summary>
        public IReadOnlyList<NetworkCloudL2NetworkData> Value { get; }
    }
}
