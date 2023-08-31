// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing the VirtualRouterPeering data model.
    /// Virtual Router Peering resource.
    /// </summary>
    public partial class VirtualRouterPeeringData : NetworkResourceData
    {
        /// <summary> Initializes a new instance of <see cref="VirtualRouterPeeringData"/>. </summary>
        public VirtualRouterPeeringData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VirtualRouterPeeringData"/>. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="peerAsn"> Peer ASN. </param>
        /// <param name="peerIP"> Peer IP. </param>
        /// <param name="provisioningState"> The provisioning state of the resource. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualRouterPeeringData(ResourceIdentifier id, string name, ResourceType? resourceType, ETag? etag, long? peerAsn, string peerIP, NetworkProvisioningState? provisioningState, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, rawData)
        {
            ETag = etag;
            PeerAsn = peerAsn;
            PeerIP = peerIP;
            ProvisioningState = provisioningState;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> Peer ASN. </summary>
        public long? PeerAsn { get; set; }
        /// <summary> Peer IP. </summary>
        public string PeerIP { get; set; }
        /// <summary> The provisioning state of the resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
    }
}
