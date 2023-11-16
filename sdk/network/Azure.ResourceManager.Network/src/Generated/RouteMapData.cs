// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing the RouteMap data model.
    /// The RouteMap child resource of a Virtual hub.
    /// </summary>
    public partial class RouteMapData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RouteMapData"/>. </summary>
        public RouteMapData()
        {
            AssociatedInboundConnections = new ChangeTrackingList<string>();
            AssociatedOutboundConnections = new ChangeTrackingList<string>();
            Rules = new ChangeTrackingList<RouteMapRule>();
        }

        /// <summary> Initializes a new instance of <see cref="RouteMapData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="associatedInboundConnections"> List of connections which have this RoutMap associated for inbound traffic. </param>
        /// <param name="associatedOutboundConnections"> List of connections which have this RoutMap associated for outbound traffic. </param>
        /// <param name="rules"> List of RouteMap rules to be applied. </param>
        /// <param name="provisioningState"> The provisioning state of the RouteMap resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RouteMapData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ETag? etag, IList<string> associatedInboundConnections, IList<string> associatedOutboundConnections, IList<RouteMapRule> rules, NetworkProvisioningState? provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            ETag = etag;
            AssociatedInboundConnections = associatedInboundConnections;
            AssociatedOutboundConnections = associatedOutboundConnections;
            Rules = rules;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> List of connections which have this RoutMap associated for inbound traffic. </summary>
        public IList<string> AssociatedInboundConnections { get; }
        /// <summary> List of connections which have this RoutMap associated for outbound traffic. </summary>
        public IList<string> AssociatedOutboundConnections { get; }
        /// <summary> List of RouteMap rules to be applied. </summary>
        public IList<RouteMapRule> Rules { get; }
        /// <summary> The provisioning state of the RouteMap resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
    }
}
