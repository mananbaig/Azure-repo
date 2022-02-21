// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DeviceUpdate.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DeviceUpdate
{
    /// <summary> A class representing the PrivateLink data model. </summary>
    public partial class PrivateLinkData : ResourceData
    {
        /// <summary> Initializes a new instance of PrivateLinkData. </summary>
        public PrivateLinkData()
        {
            RequiredMembers = new ChangeTrackingList<string>();
            RequiredZoneNames = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of PrivateLinkData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="groupId"> The private link resource group id. </param>
        /// <param name="requiredMembers"> The private link resource required member names. </param>
        /// <param name="requiredZoneNames"> The private link resource Private link DNS zone name. </param>
        /// <param name="provisioningState"> The provisioning state of private link group ID. </param>
        internal PrivateLinkData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, string groupId, IReadOnlyList<string> requiredMembers, IList<string> requiredZoneNames, GroupIdProvisioningState? provisioningState) : base(id, name, type, systemData)
        {
            GroupId = groupId;
            RequiredMembers = requiredMembers;
            RequiredZoneNames = requiredZoneNames;
            ProvisioningState = provisioningState;
        }

        /// <summary> The private link resource group id. </summary>
        public string GroupId { get; }
        /// <summary> The private link resource required member names. </summary>
        public IReadOnlyList<string> RequiredMembers { get; }
        /// <summary> The private link resource Private link DNS zone name. </summary>
        public IList<string> RequiredZoneNames { get; }
        /// <summary> The provisioning state of private link group ID. </summary>
        public GroupIdProvisioningState? ProvisioningState { get; }
    }
}
