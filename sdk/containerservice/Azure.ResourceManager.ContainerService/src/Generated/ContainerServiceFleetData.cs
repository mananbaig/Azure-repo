// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.ContainerService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ContainerService
{
    /// <summary>
    /// A class representing the ContainerServiceFleet data model.
    /// The Fleet resource which contains multiple Kubernetes clusters as its members.
    /// </summary>
    public partial class ContainerServiceFleetData : TrackedResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ContainerServiceFleetData"/>. </summary>
        /// <param name="location"> The location. </param>
        public ContainerServiceFleetData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerServiceFleetData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="etag"> Resource Etag. </param>
        /// <param name="hubProfile"> The FleetHubProfile configures the Fleet's hub. </param>
        /// <param name="provisioningState"> The provisioning state of the last accepted operation. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerServiceFleetData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ETag? etag, ContainerServiceFleetHubProfile hubProfile, ContainerServiceFleetProvisioningState? provisioningState, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData, tags, location)
        {
            ETag = etag;
            HubProfile = hubProfile;
            ProvisioningState = provisioningState;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="ContainerServiceFleetData"/> for deserialization. </summary>
        internal ContainerServiceFleetData()
        {
        }

        /// <summary> Resource Etag. </summary>
        public ETag? ETag { get; }
        /// <summary> The FleetHubProfile configures the Fleet's hub. </summary>
        public ContainerServiceFleetHubProfile HubProfile { get; set; }
        /// <summary> The provisioning state of the last accepted operation. </summary>
        public ContainerServiceFleetProvisioningState? ProvisioningState { get; }
    }
}
