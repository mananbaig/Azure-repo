// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> BGP settings details for a link. </summary>
    public partial class VpnLinkBgpSettings
    {
        /// <summary> Initializes a new instance of VpnLinkBgpSettings. </summary>
        public VpnLinkBgpSettings()
        {
        }

        /// <summary> Initializes a new instance of VpnLinkBgpSettings. </summary>
        /// <param name="asn"> The BGP speaker's ASN. </param>
        /// <param name="bgpPeeringAddress"> The BGP peering address and BGP identifier of this BGP speaker. </param>
        internal VpnLinkBgpSettings(long? asn, string bgpPeeringAddress)
        {
            Asn = asn;
            BgpPeeringAddress = bgpPeeringAddress;
        }

        /// <summary> The BGP speaker's ASN. </summary>
        public long? Asn { get; set; }
        /// <summary> The BGP peering address and BGP identifier of this BGP speaker. </summary>
        public string BgpPeeringAddress { get; set; }
    }
}
