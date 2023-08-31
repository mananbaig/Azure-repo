// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Kubernetes;

namespace Azure.ResourceManager.Kubernetes.Models
{
    /// <summary> The paginated list of connected Clusters. </summary>
    internal partial class ConnectedClusterList
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ConnectedClusterList"/>. </summary>
        internal ConnectedClusterList()
        {
            Value = new ChangeTrackingList<ConnectedClusterData>();
        }

        /// <summary> Initializes a new instance of <see cref="ConnectedClusterList"/>. </summary>
        /// <param name="value"> The list of connected clusters. </param>
        /// <param name="nextLink"> The link to fetch the next page of connected cluster. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ConnectedClusterList(IReadOnlyList<ConnectedClusterData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> The list of connected clusters. </summary>
        public IReadOnlyList<ConnectedClusterData> Value { get; }
        /// <summary> The link to fetch the next page of connected cluster. </summary>
        public string NextLink { get; }
    }
}
