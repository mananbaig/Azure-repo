// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Private Endpoint Connection Approval ARM resource. </summary>
    public partial class PrivateLinkConnectionApprovalRequestResource : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of <see cref="PrivateLinkConnectionApprovalRequestResource"/>. </summary>
        public PrivateLinkConnectionApprovalRequestResource()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PrivateLinkConnectionApprovalRequestResource"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="privateLinkServiceConnectionState"> The state of a private link connection. </param>
        internal PrivateLinkConnectionApprovalRequestResource(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string kind, PrivateLinkConnectionState privateLinkServiceConnectionState) : base(id, name, resourceType, systemData, kind)
        {
            PrivateLinkServiceConnectionState = privateLinkServiceConnectionState;
        }

        /// <summary> The state of a private link connection. </summary>
        public PrivateLinkConnectionState PrivateLinkServiceConnectionState { get; set; }
    }
}
