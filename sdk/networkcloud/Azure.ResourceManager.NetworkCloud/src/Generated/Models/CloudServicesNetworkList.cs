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
    /// <summary> CloudServicesNetworkList represents a list of cloud services networks. </summary>
    internal partial class CloudServicesNetworkList
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CloudServicesNetworkList"/>. </summary>
        internal CloudServicesNetworkList()
        {
            Value = new ChangeTrackingList<NetworkCloudCloudServicesNetworkData>();
        }

        /// <summary> Initializes a new instance of <see cref="CloudServicesNetworkList"/>. </summary>
        /// <param name="nextLink"> The link used to get the next page of operations. </param>
        /// <param name="value"> The list of cloud services networks. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CloudServicesNetworkList(string nextLink, IReadOnlyList<NetworkCloudCloudServicesNetworkData> value, Dictionary<string, BinaryData> rawData)
        {
            NextLink = nextLink;
            Value = value;
            _rawData = rawData;
        }

        /// <summary> The link used to get the next page of operations. </summary>
        public string NextLink { get; }
        /// <summary> The list of cloud services networks. </summary>
        public IReadOnlyList<NetworkCloudCloudServicesNetworkData> Value { get; }
    }
}
