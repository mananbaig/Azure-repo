// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataLakeStore.Models
{
    /// <summary> The parameters used to update a virtual network rule while updating a Data Lake Store account. </summary>
    public partial class VirtualNetworkRuleForDataLakeStoreAccountUpdateContent
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="VirtualNetworkRuleForDataLakeStoreAccountUpdateContent"/>. </summary>
        /// <param name="name"> The unique name of the virtual network rule to update. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public VirtualNetworkRuleForDataLakeStoreAccountUpdateContent(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="VirtualNetworkRuleForDataLakeStoreAccountUpdateContent"/>. </summary>
        /// <param name="name"> The unique name of the virtual network rule to update. </param>
        /// <param name="subnetId"> The resource identifier for the subnet. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualNetworkRuleForDataLakeStoreAccountUpdateContent(string name, ResourceIdentifier subnetId, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            SubnetId = subnetId;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="VirtualNetworkRuleForDataLakeStoreAccountUpdateContent"/> for deserialization. </summary>
        internal VirtualNetworkRuleForDataLakeStoreAccountUpdateContent()
        {
        }

        /// <summary> The unique name of the virtual network rule to update. </summary>
        public string Name { get; }
        /// <summary> The resource identifier for the subnet. </summary>
        public ResourceIdentifier SubnetId { get; set; }
    }
}
