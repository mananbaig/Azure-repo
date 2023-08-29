// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> PrivateLinkServiceConnection resource. </summary>
    public partial class NetworkPrivateLinkServiceConnection : NetworkResourceData
    {
        /// <summary> Initializes a new instance of <see cref="NetworkPrivateLinkServiceConnection"/>. </summary>
        public NetworkPrivateLinkServiceConnection()
        {
            GroupIds = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkPrivateLinkServiceConnection"/>. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="provisioningState"> The provisioning state of the private link service connection resource. </param>
        /// <param name="privateLinkServiceId"> The resource id of private link service. </param>
        /// <param name="groupIds"> The ID(s) of the group(s) obtained from the remote resource that this private endpoint should connect to. </param>
        /// <param name="requestMessage"> A message passed to the owner of the remote resource with this connection request. Restricted to 140 chars. </param>
        /// <param name="connectionState"> A collection of read-only information about the state of the connection to the remote resource. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkPrivateLinkServiceConnection(ResourceIdentifier id, string name, ResourceType? resourceType, ETag? etag, NetworkProvisioningState? provisioningState, ResourceIdentifier privateLinkServiceId, IList<string> groupIds, string requestMessage, NetworkPrivateLinkServiceConnectionState connectionState, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, rawData)
        {
            ETag = etag;
            ProvisioningState = provisioningState;
            PrivateLinkServiceId = privateLinkServiceId;
            GroupIds = groupIds;
            RequestMessage = requestMessage;
            ConnectionState = connectionState;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> The provisioning state of the private link service connection resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
        /// <summary> The resource id of private link service. </summary>
        public ResourceIdentifier PrivateLinkServiceId { get; set; }
        /// <summary> The ID(s) of the group(s) obtained from the remote resource that this private endpoint should connect to. </summary>
        public IList<string> GroupIds { get; }
        /// <summary> A message passed to the owner of the remote resource with this connection request. Restricted to 140 chars. </summary>
        public string RequestMessage { get; set; }
        /// <summary> A collection of read-only information about the state of the connection to the remote resource. </summary>
        public NetworkPrivateLinkServiceConnectionState ConnectionState { get; set; }
    }
}
