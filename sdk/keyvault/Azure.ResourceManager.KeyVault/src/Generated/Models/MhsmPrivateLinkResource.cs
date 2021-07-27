// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.KeyVault.Models
{
    /// <summary> A private link resource. </summary>
    public partial class MhsmPrivateLinkResource : ManagedHsmResource
    {
        /// <summary> Initializes a new instance of MhsmPrivateLinkResource. </summary>
        /// <param name="location"> The location. </param>
        public MhsmPrivateLinkResource(Location location) : base(location)
        {
            RequiredMembers = new ChangeTrackingList<string>();
            RequiredZoneNames = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of MhsmPrivateLinkResource. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="location"> The location. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="sku"> SKU details. </param>
        /// <param name="systemData"> Metadata pertaining to creation and last modification of the key vault resource. </param>
        /// <param name="groupId"> Group identifier of private link resource. </param>
        /// <param name="requiredMembers"> Required member names of private link resource. </param>
        /// <param name="requiredZoneNames"> Required DNS zone names of the the private link resource. </param>
        internal MhsmPrivateLinkResource(ResourceIdentifier id, string name, ResourceType type, Location location, IDictionary<string, string> tags, ManagedHsmSku sku, SystemData systemData, string groupId, IReadOnlyList<string> requiredMembers, IList<string> requiredZoneNames) : base(id, name, type, location, tags, sku, systemData)
        {
            GroupId = groupId;
            RequiredMembers = requiredMembers;
            RequiredZoneNames = requiredZoneNames;
        }

        /// <summary> Group identifier of private link resource. </summary>
        public string GroupId { get; }
        /// <summary> Required member names of private link resource. </summary>
        public IReadOnlyList<string> RequiredMembers { get; }
        /// <summary> Required DNS zone names of the the private link resource. </summary>
        public IList<string> RequiredZoneNames { get; }
    }
}
