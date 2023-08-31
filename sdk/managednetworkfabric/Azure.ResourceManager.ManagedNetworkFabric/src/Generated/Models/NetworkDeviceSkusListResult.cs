// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ManagedNetworkFabric;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> List of Network Device SKUs. </summary>
    internal partial class NetworkDeviceSkusListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="NetworkDeviceSkusListResult"/>. </summary>
        internal NetworkDeviceSkusListResult()
        {
            Value = new ChangeTrackingList<NetworkDeviceSkuData>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkDeviceSkusListResult"/>. </summary>
        /// <param name="value"> List of Network Device SKU resources. </param>
        /// <param name="nextLink"> Url to follow for getting next page of resources. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkDeviceSkusListResult(IReadOnlyList<NetworkDeviceSkuData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> List of Network Device SKU resources. </summary>
        public IReadOnlyList<NetworkDeviceSkuData> Value { get; }
        /// <summary> Url to follow for getting next page of resources. </summary>
        public string NextLink { get; }
    }
}
