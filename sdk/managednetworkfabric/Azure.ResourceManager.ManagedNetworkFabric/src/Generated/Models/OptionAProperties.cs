// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> Peering optionA properties. </summary>
    public partial class OptionAProperties
    {
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="OptionAProperties"/>. </summary>
        public OptionAProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="OptionAProperties"/>. </summary>
        /// <param name="mtu"> MTU to use for option A peering. </param>
        /// <param name="vlanId"> Vlan Id.Example : 501. </param>
        /// <param name="peerAsn"> Peer ASN number.Example : 28. </param>
        /// <param name="bfdConfiguration"> BFD Configuration properties. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal OptionAProperties(int? mtu, int? vlanId, long? peerAsn, BfdConfiguration bfdConfiguration, Dictionary<string, BinaryData> rawData)
        {
            Mtu = mtu;
            VlanId = vlanId;
            PeerAsn = peerAsn;
            BfdConfiguration = bfdConfiguration;
            _rawData = rawData;
        }

        /// <summary> MTU to use for option A peering. </summary>
        public int? Mtu { get; set; }
        /// <summary> Vlan Id.Example : 501. </summary>
        public int? VlanId { get; set; }
        /// <summary> Peer ASN number.Example : 28. </summary>
        public long? PeerAsn { get; set; }
        /// <summary> BFD Configuration properties. </summary>
        public BfdConfiguration BfdConfiguration { get; set; }
    }
}
