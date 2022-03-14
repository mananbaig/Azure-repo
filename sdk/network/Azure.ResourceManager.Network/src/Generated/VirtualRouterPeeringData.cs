// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the VirtualRouterPeering data model. </summary>
    public partial class VirtualRouterPeeringData : SubResource
    {
        /// <summary> Initializes a new instance of VirtualRouterPeeringData. </summary>
        public VirtualRouterPeeringData()
        {
        }

        /// <summary> Initializes a new instance of VirtualRouterPeeringData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Name of the virtual router peering that is unique within a virtual router. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="type"> Peering type. </param>
        /// <param name="peerAsn"> Peer ASN. </param>
        /// <param name="peerIP"> Peer IP. </param>
        /// <param name="provisioningState"> The provisioning state of the resource. </param>
        internal VirtualRouterPeeringData(string id, string name, string etag, string type, long? peerAsn, string peerIP, ProvisioningState? provisioningState) : base(id)
        {
            Name = name;
            Etag = etag;
            Type = type;
            PeerAsn = peerAsn;
            PeerIP = peerIP;
            ProvisioningState = provisioningState;
        }

        /// <summary> Name of the virtual router peering that is unique within a virtual router. </summary>
        public string Name { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> Peering type. </summary>
        public string Type { get; }
        /// <summary> Peer ASN. </summary>
        public long? PeerAsn { get; set; }
        /// <summary> Peer IP. </summary>
        public string PeerIP { get; set; }
        /// <summary> The provisioning state of the resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
