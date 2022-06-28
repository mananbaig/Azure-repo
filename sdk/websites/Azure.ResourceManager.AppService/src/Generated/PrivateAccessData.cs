// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing the PrivateAccess data model. </summary>
    public partial class PrivateAccessData : ResourceData
    {
        /// <summary> Initializes a new instance of PrivateAccessData. </summary>
        public PrivateAccessData()
        {
            VirtualNetworks = new ChangeTrackingList<PrivateAccessVirtualNetwork>();
        }

        /// <summary> Initializes a new instance of PrivateAccessData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="enabled"> Whether private access is enabled or not. </param>
        /// <param name="virtualNetworks"> The Virtual Networks (and subnets) allowed to access the site privately. </param>
        /// <param name="kind"> Kind of resource. </param>
        internal PrivateAccessData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, bool? enabled, IList<PrivateAccessVirtualNetwork> virtualNetworks, string kind) : base(id, name, resourceType, systemData)
        {
            Enabled = enabled;
            VirtualNetworks = virtualNetworks;
            Kind = kind;
        }

        /// <summary> Whether private access is enabled or not. </summary>
        public bool? Enabled { get; set; }
        /// <summary> The Virtual Networks (and subnets) allowed to access the site privately. </summary>
        public IList<PrivateAccessVirtualNetwork> VirtualNetworks { get; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
