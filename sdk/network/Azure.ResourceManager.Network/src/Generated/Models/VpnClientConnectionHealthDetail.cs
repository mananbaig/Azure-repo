// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> VPN client connection health detail. </summary>
    public partial class VpnClientConnectionHealthDetail
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="VpnClientConnectionHealthDetail"/>. </summary>
        internal VpnClientConnectionHealthDetail()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VpnClientConnectionHealthDetail"/>. </summary>
        /// <param name="vpnConnectionId"> The vpn client Id. </param>
        /// <param name="vpnConnectionDurationInSeconds"> The duration time of a connected vpn client. </param>
        /// <param name="vpnConnectionOn"> The start time of a connected vpn client. </param>
        /// <param name="publicIPAddress"> The public Ip of a connected vpn client. </param>
        /// <param name="privateIPAddress"> The assigned private Ip of a connected vpn client. </param>
        /// <param name="vpnUserName"> The user name of a connected vpn client. </param>
        /// <param name="maxBandwidth"> The max band width. </param>
        /// <param name="egressPacketsTransferred"> The egress packets per second. </param>
        /// <param name="egressBytesTransferred"> The egress bytes per second. </param>
        /// <param name="ingressPacketsTransferred"> The ingress packets per second. </param>
        /// <param name="ingressBytesTransferred"> The ingress bytes per second. </param>
        /// <param name="maxPacketsPerSecond"> The max packets transferred per second. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal VpnClientConnectionHealthDetail(string vpnConnectionId, long? vpnConnectionDurationInSeconds, DateTimeOffset? vpnConnectionOn, string publicIPAddress, string privateIPAddress, string vpnUserName, long? maxBandwidth, long? egressPacketsTransferred, long? egressBytesTransferred, long? ingressPacketsTransferred, long? ingressBytesTransferred, long? maxPacketsPerSecond, Dictionary<string, BinaryData> rawData)
        {
            VpnConnectionId = vpnConnectionId;
            VpnConnectionDurationInSeconds = vpnConnectionDurationInSeconds;
            VpnConnectionOn = vpnConnectionOn;
            PublicIPAddress = publicIPAddress;
            PrivateIPAddress = privateIPAddress;
            VpnUserName = vpnUserName;
            MaxBandwidth = maxBandwidth;
            EgressPacketsTransferred = egressPacketsTransferred;
            EgressBytesTransferred = egressBytesTransferred;
            IngressPacketsTransferred = ingressPacketsTransferred;
            IngressBytesTransferred = ingressBytesTransferred;
            MaxPacketsPerSecond = maxPacketsPerSecond;
            _rawData = rawData;
        }

        /// <summary> The vpn client Id. </summary>
        public string VpnConnectionId { get; }
        /// <summary> The duration time of a connected vpn client. </summary>
        public long? VpnConnectionDurationInSeconds { get; }
        /// <summary> The start time of a connected vpn client. </summary>
        public DateTimeOffset? VpnConnectionOn { get; }
        /// <summary> The public Ip of a connected vpn client. </summary>
        public string PublicIPAddress { get; }
        /// <summary> The assigned private Ip of a connected vpn client. </summary>
        public string PrivateIPAddress { get; }
        /// <summary> The user name of a connected vpn client. </summary>
        public string VpnUserName { get; }
        /// <summary> The max band width. </summary>
        public long? MaxBandwidth { get; }
        /// <summary> The egress packets per second. </summary>
        public long? EgressPacketsTransferred { get; }
        /// <summary> The egress bytes per second. </summary>
        public long? EgressBytesTransferred { get; }
        /// <summary> The ingress packets per second. </summary>
        public long? IngressPacketsTransferred { get; }
        /// <summary> The ingress bytes per second. </summary>
        public long? IngressBytesTransferred { get; }
        /// <summary> The max packets transferred per second. </summary>
        public long? MaxPacketsPerSecond { get; }
    }
}
