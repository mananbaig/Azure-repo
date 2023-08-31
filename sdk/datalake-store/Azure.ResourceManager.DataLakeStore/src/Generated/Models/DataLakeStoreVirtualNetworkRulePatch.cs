// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataLakeStore.Models
{
    /// <summary> The parameters used to update a virtual network rule. </summary>
    public partial class DataLakeStoreVirtualNetworkRulePatch
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DataLakeStoreVirtualNetworkRulePatch"/>. </summary>
        public DataLakeStoreVirtualNetworkRulePatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DataLakeStoreVirtualNetworkRulePatch"/>. </summary>
        /// <param name="subnetId"> The resource identifier for the subnet. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DataLakeStoreVirtualNetworkRulePatch(ResourceIdentifier subnetId, Dictionary<string, BinaryData> rawData)
        {
            SubnetId = subnetId;
            _rawData = rawData;
        }

        /// <summary> The resource identifier for the subnet. </summary>
        public ResourceIdentifier SubnetId { get; set; }
    }
}
