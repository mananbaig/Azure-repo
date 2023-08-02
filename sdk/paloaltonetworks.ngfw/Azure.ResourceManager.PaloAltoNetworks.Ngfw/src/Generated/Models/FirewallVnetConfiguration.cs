// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    /// <summary> VnetInfo for Firewall Networking. </summary>
    public partial class FirewallVnetConfiguration
    {
        /// <summary> Initializes a new instance of FirewallVnetConfiguration. </summary>
        /// <param name="vnet"> Azure Virtual Network. </param>
        /// <param name="trustSubnet"> Trust Subnet. </param>
        /// <param name="unTrustSubnet"> Untrust Subnet. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vnet"/>, <paramref name="trustSubnet"/> or <paramref name="unTrustSubnet"/> is null. </exception>
        public FirewallVnetConfiguration(IPAddressSpaceInfo vnet, IPAddressSpaceInfo trustSubnet, IPAddressSpaceInfo unTrustSubnet)
        {
            Argument.AssertNotNull(vnet, nameof(vnet));
            Argument.AssertNotNull(trustSubnet, nameof(trustSubnet));
            Argument.AssertNotNull(unTrustSubnet, nameof(unTrustSubnet));

            Vnet = vnet;
            TrustSubnet = trustSubnet;
            UnTrustSubnet = unTrustSubnet;
        }

        /// <summary> Initializes a new instance of FirewallVnetConfiguration. </summary>
        /// <param name="vnet"> Azure Virtual Network. </param>
        /// <param name="trustSubnet"> Trust Subnet. </param>
        /// <param name="unTrustSubnet"> Untrust Subnet. </param>
        /// <param name="ipOfTrustSubnetForUdr"> IP of trust subnet for UDR. </param>
        internal FirewallVnetConfiguration(IPAddressSpaceInfo vnet, IPAddressSpaceInfo trustSubnet, IPAddressSpaceInfo unTrustSubnet, IPAddressInfo ipOfTrustSubnetForUdr)
        {
            Vnet = vnet;
            TrustSubnet = trustSubnet;
            UnTrustSubnet = unTrustSubnet;
            IPOfTrustSubnetForUdr = ipOfTrustSubnetForUdr;
        }

        /// <summary> Azure Virtual Network. </summary>
        public IPAddressSpaceInfo Vnet { get; set; }
        /// <summary> Trust Subnet. </summary>
        public IPAddressSpaceInfo TrustSubnet { get; set; }
        /// <summary> Untrust Subnet. </summary>
        public IPAddressSpaceInfo UnTrustSubnet { get; set; }
        /// <summary> IP of trust subnet for UDR. </summary>
        public IPAddressInfo IPOfTrustSubnetForUdr { get; set; }
    }
}
