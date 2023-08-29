// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Virtual Wan Vpn profile parameters Vpn profile generation. </summary>
    public partial class VirtualWanVpnProfileContent
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="VirtualWanVpnProfileContent"/>. </summary>
        public VirtualWanVpnProfileContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VirtualWanVpnProfileContent"/>. </summary>
        /// <param name="vpnServerConfigurationResourceId"> VpnServerConfiguration partial resource uri with which VirtualWan is associated to. </param>
        /// <param name="authenticationMethod"> VPN client authentication method. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualWanVpnProfileContent(ResourceIdentifier vpnServerConfigurationResourceId, NetworkAuthenticationMethod? authenticationMethod, Dictionary<string, BinaryData> rawData)
        {
            VpnServerConfigurationResourceId = vpnServerConfigurationResourceId;
            AuthenticationMethod = authenticationMethod;
            _rawData = rawData;
        }

        /// <summary> VpnServerConfiguration partial resource uri with which VirtualWan is associated to. </summary>
        public ResourceIdentifier VpnServerConfigurationResourceId { get; set; }
        /// <summary> VPN client authentication method. </summary>
        public NetworkAuthenticationMethod? AuthenticationMethod { get; set; }
    }
}
