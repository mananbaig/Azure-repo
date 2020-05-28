// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.Network.Models
{
    /// <summary> An IPSec Policy configuration for a virtual network gateway connection. </summary>
    public partial class IpsecPolicy
    {
        /// <summary> Initializes a new instance of IpsecPolicy. </summary>
        /// <param name="saLifeTimeSeconds"> The IPSec Security Association (also called Quick Mode or Phase 2 SA) lifetime in seconds for a site to site VPN tunnel. </param>
        /// <param name="saDataSizeKilobytes"> The IPSec Security Association (also called Quick Mode or Phase 2 SA) payload size in KB for a site to site VPN tunnel. </param>
        /// <param name="ipsecEncryption"> The IPSec encryption algorithm (IKE phase 1). </param>
        /// <param name="ipsecIntegrity"> The IPSec integrity algorithm (IKE phase 1). </param>
        /// <param name="ikeEncryption"> The IKE encryption algorithm (IKE phase 2). </param>
        /// <param name="ikeIntegrity"> The IKE integrity algorithm (IKE phase 2). </param>
        /// <param name="dhGroup"> The DH Group used in IKE Phase 1 for initial SA. </param>
        /// <param name="pfsGroup"> The Pfs Group used in IKE Phase 2 for new child SA. </param>
        public IpsecPolicy(int saLifeTimeSeconds, int saDataSizeKilobytes, IpsecEncryption ipsecEncryption, IpsecIntegrity ipsecIntegrity, IkeEncryption ikeEncryption, IkeIntegrity ikeIntegrity, DhGroup dhGroup, PfsGroup pfsGroup)
        {
            SaLifeTimeSeconds = saLifeTimeSeconds;
            SaDataSizeKilobytes = saDataSizeKilobytes;
            IpsecEncryption = ipsecEncryption;
            IpsecIntegrity = ipsecIntegrity;
            IkeEncryption = ikeEncryption;
            IkeIntegrity = ikeIntegrity;
            DhGroup = dhGroup;
            PfsGroup = pfsGroup;
        }

        /// <summary> The IPSec Security Association (also called Quick Mode or Phase 2 SA) lifetime in seconds for a site to site VPN tunnel. </summary>
        public int SaLifeTimeSeconds { get; set; }
        /// <summary> The IPSec Security Association (also called Quick Mode or Phase 2 SA) payload size in KB for a site to site VPN tunnel. </summary>
        public int SaDataSizeKilobytes { get; set; }
        /// <summary> The IPSec encryption algorithm (IKE phase 1). </summary>
        public IpsecEncryption IpsecEncryption { get; set; }
        /// <summary> The IPSec integrity algorithm (IKE phase 1). </summary>
        public IpsecIntegrity IpsecIntegrity { get; set; }
        /// <summary> The IKE encryption algorithm (IKE phase 2). </summary>
        public IkeEncryption IkeEncryption { get; set; }
        /// <summary> The IKE integrity algorithm (IKE phase 2). </summary>
        public IkeIntegrity IkeIntegrity { get; set; }
        /// <summary> The DH Group used in IKE Phase 1 for initial SA. </summary>
        public DhGroup DhGroup { get; set; }
        /// <summary> The Pfs Group used in IKE Phase 2 for new child SA. </summary>
        public PfsGroup PfsGroup { get; set; }
    }
}
