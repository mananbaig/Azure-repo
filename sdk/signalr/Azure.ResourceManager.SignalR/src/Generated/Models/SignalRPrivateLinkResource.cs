// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SignalR.Models
{
    /// <summary> Private link resource. </summary>
    public partial class SignalRPrivateLinkResource : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SignalRPrivateLinkResource"/>. </summary>
        public SignalRPrivateLinkResource()
        {
            RequiredMembers = new ChangeTrackingList<string>();
            RequiredZoneNames = new ChangeTrackingList<string>();
            ShareablePrivateLinkResourceTypes = new ChangeTrackingList<ShareablePrivateLinkResourceType>();
        }

        /// <summary> Initializes a new instance of <see cref="SignalRPrivateLinkResource"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="groupId"> Group Id of the private link resource. </param>
        /// <param name="requiredMembers"> Required members of the private link resource. </param>
        /// <param name="requiredZoneNames"> Required private DNS zone names. </param>
        /// <param name="shareablePrivateLinkResourceTypes"> The list of resources that are onboarded to private link service. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SignalRPrivateLinkResource(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string groupId, IList<string> requiredMembers, IList<string> requiredZoneNames, IList<ShareablePrivateLinkResourceType> shareablePrivateLinkResourceTypes, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            GroupId = groupId;
            RequiredMembers = requiredMembers;
            RequiredZoneNames = requiredZoneNames;
            ShareablePrivateLinkResourceTypes = shareablePrivateLinkResourceTypes;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Group Id of the private link resource. </summary>
        public string GroupId { get; set; }
        /// <summary> Required members of the private link resource. </summary>
        public IList<string> RequiredMembers { get; }
        /// <summary> Required private DNS zone names. </summary>
        public IList<string> RequiredZoneNames { get; }
        /// <summary> The list of resources that are onboarded to private link service. </summary>
        public IList<ShareablePrivateLinkResourceType> ShareablePrivateLinkResourceTypes { get; }
    }
}
