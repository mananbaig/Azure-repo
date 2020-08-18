// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> VirtualWAN Resource. </summary>
    public partial class VirtualWAN : Resource
    {
        /// <summary> Initializes a new instance of VirtualWAN. </summary>
        public VirtualWAN()
        {
            VirtualHubs = new ChangeTrackingList<SubResource>();
            VpnSites = new ChangeTrackingList<SubResource>();
        }

        /// <summary> Initializes a new instance of VirtualWAN. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="disableVpnEncryption"> Vpn encryption to be disabled or not. </param>
        /// <param name="virtualHubs"> List of VirtualHubs in the VirtualWAN. </param>
        /// <param name="vpnSites"> List of VpnSites in the VirtualWAN. </param>
        /// <param name="allowBranchToBranchTraffic"> True if branch to branch traffic is allowed. </param>
        /// <param name="allowVnetToVnetTraffic"> True if Vnet to Vnet traffic is allowed. </param>
        /// <param name="office365LocalBreakoutCategory"> The office local breakout category. </param>
        /// <param name="provisioningState"> The provisioning state of the virtual WAN resource. </param>
        /// <param name="typePropertiesType"> The type of the VirtualWAN. </param>
        internal VirtualWAN(string id, string name, string type, string location, IDictionary<string, string> tags, string etag, bool? disableVpnEncryption, IReadOnlyList<SubResource> virtualHubs, IReadOnlyList<SubResource> vpnSites, bool? allowBranchToBranchTraffic, bool? allowVnetToVnetTraffic, OfficeTrafficCategory? office365LocalBreakoutCategory, ProvisioningState? provisioningState, string typePropertiesType) : base(id, name, type, location, tags)
        {
            Etag = etag;
            DisableVpnEncryption = disableVpnEncryption;
            VirtualHubs = virtualHubs;
            VpnSites = vpnSites;
            AllowBranchToBranchTraffic = allowBranchToBranchTraffic;
            AllowVnetToVnetTraffic = allowVnetToVnetTraffic;
            Office365LocalBreakoutCategory = office365LocalBreakoutCategory;
            ProvisioningState = provisioningState;
            TypePropertiesType = typePropertiesType;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> Vpn encryption to be disabled or not. </summary>
        public bool? DisableVpnEncryption { get; set; }
        /// <summary> List of VirtualHubs in the VirtualWAN. </summary>
        public IReadOnlyList<SubResource> VirtualHubs { get; }
        /// <summary> List of VpnSites in the VirtualWAN. </summary>
        public IReadOnlyList<SubResource> VpnSites { get; }
        /// <summary> True if branch to branch traffic is allowed. </summary>
        public bool? AllowBranchToBranchTraffic { get; set; }
        /// <summary> True if Vnet to Vnet traffic is allowed. </summary>
        public bool? AllowVnetToVnetTraffic { get; set; }
        /// <summary> The office local breakout category. </summary>
        public OfficeTrafficCategory? Office365LocalBreakoutCategory { get; }
        /// <summary> The provisioning state of the virtual WAN resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> The type of the VirtualWAN. </summary>
        public string TypePropertiesType { get; set; }
    }
}
