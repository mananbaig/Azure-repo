// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Network sibling set update. </summary>
    public partial class UpdateNetworkSiblingSetContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="UpdateNetworkSiblingSetContent"/>. </summary>
        /// <param name="networkSiblingSetId"> Network Sibling Set ID for a group of volumes sharing networking resources in a subnet. </param>
        /// <param name="subnetId"> The Azure Resource URI for a delegated subnet. Must have the delegation Microsoft.NetApp/volumes. Example /subscriptions/subscriptionId/resourceGroups/resourceGroup/providers/Microsoft.Network/virtualNetworks/testVnet/subnets/{mySubnet}. </param>
        /// <param name="networkSiblingSetStateId"> Network sibling set state Id identifying the current state of the sibling set. </param>
        /// <param name="networkFeatures"> Network features available to the volume, some such. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="networkSiblingSetId"/>, <paramref name="subnetId"/> or <paramref name="networkSiblingSetStateId"/> is null. </exception>
        public UpdateNetworkSiblingSetContent(string networkSiblingSetId, ResourceIdentifier subnetId, string networkSiblingSetStateId, NetAppNetworkFeature networkFeatures)
        {
            Argument.AssertNotNull(networkSiblingSetId, nameof(networkSiblingSetId));
            Argument.AssertNotNull(subnetId, nameof(subnetId));
            Argument.AssertNotNull(networkSiblingSetStateId, nameof(networkSiblingSetStateId));

            NetworkSiblingSetId = networkSiblingSetId;
            SubnetId = subnetId;
            NetworkSiblingSetStateId = networkSiblingSetStateId;
            NetworkFeatures = networkFeatures;
        }

        /// <summary> Initializes a new instance of <see cref="UpdateNetworkSiblingSetContent"/>. </summary>
        /// <param name="networkSiblingSetId"> Network Sibling Set ID for a group of volumes sharing networking resources in a subnet. </param>
        /// <param name="subnetId"> The Azure Resource URI for a delegated subnet. Must have the delegation Microsoft.NetApp/volumes. Example /subscriptions/subscriptionId/resourceGroups/resourceGroup/providers/Microsoft.Network/virtualNetworks/testVnet/subnets/{mySubnet}. </param>
        /// <param name="networkSiblingSetStateId"> Network sibling set state Id identifying the current state of the sibling set. </param>
        /// <param name="networkFeatures"> Network features available to the volume, some such. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UpdateNetworkSiblingSetContent(string networkSiblingSetId, ResourceIdentifier subnetId, string networkSiblingSetStateId, NetAppNetworkFeature networkFeatures, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NetworkSiblingSetId = networkSiblingSetId;
            SubnetId = subnetId;
            NetworkSiblingSetStateId = networkSiblingSetStateId;
            NetworkFeatures = networkFeatures;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="UpdateNetworkSiblingSetContent"/> for deserialization. </summary>
        internal UpdateNetworkSiblingSetContent()
        {
        }

        /// <summary> Network Sibling Set ID for a group of volumes sharing networking resources in a subnet. </summary>
        public string NetworkSiblingSetId { get; }
        /// <summary> The Azure Resource URI for a delegated subnet. Must have the delegation Microsoft.NetApp/volumes. Example /subscriptions/subscriptionId/resourceGroups/resourceGroup/providers/Microsoft.Network/virtualNetworks/testVnet/subnets/{mySubnet}. </summary>
        public ResourceIdentifier SubnetId { get; }
        /// <summary> Network sibling set state Id identifying the current state of the sibling set. </summary>
        public string NetworkSiblingSetStateId { get; }
        /// <summary> Network features available to the volume, some such. </summary>
        public NetAppNetworkFeature NetworkFeatures { get; }
    }
}
