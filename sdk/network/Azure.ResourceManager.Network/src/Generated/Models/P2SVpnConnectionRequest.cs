// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> List of p2s vpn connections to be disconnected. </summary>
    public partial class P2SVpnConnectionRequest
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="P2SVpnConnectionRequest"/>. </summary>
        public P2SVpnConnectionRequest()
        {
            VpnConnectionIds = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="P2SVpnConnectionRequest"/>. </summary>
        /// <param name="vpnConnectionIds"> List of p2s vpn connection Ids. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal P2SVpnConnectionRequest(IList<string> vpnConnectionIds, Dictionary<string, BinaryData> rawData)
        {
            VpnConnectionIds = vpnConnectionIds;
            _rawData = rawData;
        }

        /// <summary> List of p2s vpn connection Ids. </summary>
        public IList<string> VpnConnectionIds { get; }
    }
}
