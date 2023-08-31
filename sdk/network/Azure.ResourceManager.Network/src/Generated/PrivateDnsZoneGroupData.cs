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
    /// A class representing the PrivateDnsZoneGroup data model.
    /// Private dns zone group resource.
    /// </summary>
    public partial class PrivateDnsZoneGroupData : NetworkResourceData
    {
        /// <summary> Initializes a new instance of <see cref="PrivateDnsZoneGroupData"/>. </summary>
        public PrivateDnsZoneGroupData()
        {
            PrivateDnsZoneConfigs = new ChangeTrackingList<PrivateDnsZoneConfig>();
        }

        /// <summary> Initializes a new instance of <see cref="PrivateDnsZoneGroupData"/>. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="provisioningState"> The provisioning state of the private dns zone group resource. </param>
        /// <param name="privateDnsZoneConfigs"> A collection of private dns zone configurations of the private dns zone group. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PrivateDnsZoneGroupData(ResourceIdentifier id, string name, ResourceType? resourceType, ETag? etag, NetworkProvisioningState? provisioningState, IList<PrivateDnsZoneConfig> privateDnsZoneConfigs, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, rawData)
        {
            ETag = etag;
            ProvisioningState = provisioningState;
            PrivateDnsZoneConfigs = privateDnsZoneConfigs;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> The provisioning state of the private dns zone group resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
        /// <summary> A collection of private dns zone configurations of the private dns zone group. </summary>
        public IList<PrivateDnsZoneConfig> PrivateDnsZoneConfigs { get; }
    }
}
