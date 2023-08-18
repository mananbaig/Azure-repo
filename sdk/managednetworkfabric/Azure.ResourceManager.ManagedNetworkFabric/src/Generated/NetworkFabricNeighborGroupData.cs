// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ManagedNetworkFabric.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    /// <summary>
    /// A class representing the NetworkFabricNeighborGroup data model.
    /// Defines the Neighbor Group.
    /// </summary>
    public partial class NetworkFabricNeighborGroupData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of NetworkFabricNeighborGroupData. </summary>
        /// <param name="location"> The location. </param>
        public NetworkFabricNeighborGroupData(AzureLocation location) : base(location)
        {
            NetworkTapIds = new Core.ChangeTrackingList<ResourceIdentifier>();
            NetworkTapRuleIds = new Core.ChangeTrackingList<ResourceIdentifier>();
        }

        /// <summary> Initializes a new instance of NetworkFabricNeighborGroupData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="annotation"> Switch configuration description. </param>
        /// <param name="destination"> An array of destination IPv4 Addresses or IPv6 Addresses. </param>
        /// <param name="networkTapIds"> List of NetworkTap IDs where neighbor group is associated. </param>
        /// <param name="networkTapRuleIds"> List of Network Tap Rule IDs where neighbor group is associated. </param>
        /// <param name="provisioningState"> The provisioning state of the resource. </param>
        internal NetworkFabricNeighborGroupData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string annotation, NeighborGroupDestination destination, IReadOnlyList<ResourceIdentifier> networkTapIds, IReadOnlyList<ResourceIdentifier> networkTapRuleIds, NetworkFabricProvisioningState? provisioningState) : base(id, name, resourceType, systemData, tags, location)
        {
            Annotation = annotation;
            Destination = destination;
            NetworkTapIds = networkTapIds;
            NetworkTapRuleIds = networkTapRuleIds;
            ProvisioningState = provisioningState;
        }

        /// <summary> Switch configuration description. </summary>
        public string Annotation { get; set; }
        /// <summary> An array of destination IPv4 Addresses or IPv6 Addresses. </summary>
        public NeighborGroupDestination Destination { get; set; }
        /// <summary> List of NetworkTap IDs where neighbor group is associated. </summary>
        public IReadOnlyList<ResourceIdentifier> NetworkTapIds { get; }
        /// <summary> List of Network Tap Rule IDs where neighbor group is associated. </summary>
        public IReadOnlyList<ResourceIdentifier> NetworkTapRuleIds { get; }
        /// <summary> The provisioning state of the resource. </summary>
        public NetworkFabricProvisioningState? ProvisioningState { get; }
    }
}
