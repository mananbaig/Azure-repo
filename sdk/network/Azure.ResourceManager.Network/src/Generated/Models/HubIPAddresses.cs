// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> IP addresses associated with azure firewall. </summary>
    public partial class HubIPAddresses
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="HubIPAddresses"/>. </summary>
        public HubIPAddresses()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HubIPAddresses"/>. </summary>
        /// <param name="publicIPs"> Public IP addresses associated with azure firewall. </param>
        /// <param name="privateIPAddress"> Private IP Address associated with azure firewall. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal HubIPAddresses(HubPublicIPAddresses publicIPs, string privateIPAddress, Dictionary<string, BinaryData> rawData)
        {
            PublicIPs = publicIPs;
            PrivateIPAddress = privateIPAddress;
            _rawData = rawData;
        }

        /// <summary> Public IP addresses associated with azure firewall. </summary>
        public HubPublicIPAddresses PublicIPs { get; set; }
        /// <summary> Private IP Address associated with azure firewall. </summary>
        public string PrivateIPAddress { get; set; }
    }
}
