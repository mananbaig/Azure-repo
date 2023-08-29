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
    /// A class representing the SecurityAdminConfiguration data model.
    /// Defines the security admin configuration
    /// </summary>
    public partial class SecurityAdminConfigurationData : ResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SecurityAdminConfigurationData"/>. </summary>
        public SecurityAdminConfigurationData()
        {
            ApplyOnNetworkIntentPolicyBasedServices = new ChangeTrackingList<NetworkIntentPolicyBasedService>();
        }

        /// <summary> Initializes a new instance of <see cref="SecurityAdminConfigurationData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="description"> A description of the security configuration. </param>
        /// <param name="applyOnNetworkIntentPolicyBasedServices"> Enum list of network intent policy based services. </param>
        /// <param name="provisioningState"> The provisioning state of the resource. </param>
        /// <param name="resourceGuid"> Unique identifier for this resource. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SecurityAdminConfigurationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string description, IList<NetworkIntentPolicyBasedService> applyOnNetworkIntentPolicyBasedServices, NetworkProvisioningState? provisioningState, Guid? resourceGuid, ETag? etag, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            Description = description;
            ApplyOnNetworkIntentPolicyBasedServices = applyOnNetworkIntentPolicyBasedServices;
            ProvisioningState = provisioningState;
            ResourceGuid = resourceGuid;
            ETag = etag;
            _rawData = rawData;
        }

        /// <summary> A description of the security configuration. </summary>
        public string Description { get; set; }
        /// <summary> Enum list of network intent policy based services. </summary>
        public IList<NetworkIntentPolicyBasedService> ApplyOnNetworkIntentPolicyBasedServices { get; }
        /// <summary> The provisioning state of the resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
        /// <summary> Unique identifier for this resource. </summary>
        public Guid? ResourceGuid { get; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
    }
}
