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
    /// <summary> ClusterList represents a list of clusters. </summary>
    internal partial class ClusterList
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ClusterList"/>. </summary>
        internal ClusterList()
        {
            Value = new ChangeTrackingList<NetworkCloudClusterData>();
        }

        /// <summary> Initializes a new instance of <see cref="ClusterList"/>. </summary>
        /// <param name="nextLink"> The link used to get the next page of operations. </param>
        /// <param name="value"> The list of clusters. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ClusterList(string nextLink, IReadOnlyList<NetworkCloudClusterData> value, Dictionary<string, BinaryData> rawData)
        {
            NextLink = nextLink;
            Value = value;
            _rawData = rawData;
        }

        /// <summary> The link used to get the next page of operations. </summary>
        public string NextLink { get; }
        /// <summary> The list of clusters. </summary>
        public IReadOnlyList<NetworkCloudClusterData> Value { get; }
    }
}
