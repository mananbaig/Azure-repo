// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> VpnClientConnectionHealth properties. </summary>
    public partial class VpnClientConnectionHealth
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="VpnClientConnectionHealth"/>. </summary>
        internal VpnClientConnectionHealth()
        {
            AllocatedIPAddresses = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="VpnClientConnectionHealth"/>. </summary>
        /// <param name="totalIngressBytesTransferred"> Total of the Ingress Bytes Transferred in this P2S Vpn connection. </param>
        /// <param name="totalEgressBytesTransferred"> Total of the Egress Bytes Transferred in this connection. </param>
        /// <param name="vpnClientConnectionsCount"> The total of p2s vpn clients connected at this time to this P2SVpnGateway. </param>
        /// <param name="allocatedIPAddresses"> List of allocated ip addresses to the connected p2s vpn clients. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal VpnClientConnectionHealth(long? totalIngressBytesTransferred, long? totalEgressBytesTransferred, int? vpnClientConnectionsCount, IReadOnlyList<string> allocatedIPAddresses, Dictionary<string, BinaryData> rawData)
        {
            TotalIngressBytesTransferred = totalIngressBytesTransferred;
            TotalEgressBytesTransferred = totalEgressBytesTransferred;
            VpnClientConnectionsCount = vpnClientConnectionsCount;
            AllocatedIPAddresses = allocatedIPAddresses;
            _rawData = rawData;
        }

        /// <summary> Total of the Ingress Bytes Transferred in this P2S Vpn connection. </summary>
        public long? TotalIngressBytesTransferred { get; }
        /// <summary> Total of the Egress Bytes Transferred in this connection. </summary>
        public long? TotalEgressBytesTransferred { get; }
        /// <summary> The total of p2s vpn clients connected at this time to this P2SVpnGateway. </summary>
        public int? VpnClientConnectionsCount { get; }
        /// <summary> List of allocated ip addresses to the connected p2s vpn clients. </summary>
        public IReadOnlyList<string> AllocatedIPAddresses { get; }
    }
}
