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
    /// A class representing the VpnSiteLink data model.
    /// VpnSiteLink Resource.
    /// </summary>
    public partial class VpnSiteLinkData : NetworkResourceData
    {
        /// <summary> Initializes a new instance of <see cref="VpnSiteLinkData"/>. </summary>
        public VpnSiteLinkData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VpnSiteLinkData"/>. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="linkProperties"> The link provider properties. </param>
        /// <param name="ipAddress"> The ip-address for the vpn-site-link. </param>
        /// <param name="fqdn"> FQDN of vpn-site-link. </param>
        /// <param name="bgpProperties"> The set of bgp properties. </param>
        /// <param name="provisioningState"> The provisioning state of the VPN site link resource. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal VpnSiteLinkData(ResourceIdentifier id, string name, ResourceType? resourceType, ETag? etag, VpnLinkProviderProperties linkProperties, string ipAddress, string fqdn, VpnLinkBgpSettings bgpProperties, NetworkProvisioningState? provisioningState, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, rawData)
        {
            ETag = etag;
            LinkProperties = linkProperties;
            IPAddress = ipAddress;
            Fqdn = fqdn;
            BgpProperties = bgpProperties;
            ProvisioningState = provisioningState;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> The link provider properties. </summary>
        public VpnLinkProviderProperties LinkProperties { get; set; }
        /// <summary> The ip-address for the vpn-site-link. </summary>
        public string IPAddress { get; set; }
        /// <summary> FQDN of vpn-site-link. </summary>
        public string Fqdn { get; set; }
        /// <summary> The set of bgp properties. </summary>
        public VpnLinkBgpSettings BgpProperties { get; set; }
        /// <summary> The provisioning state of the VPN site link resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
    }
}
