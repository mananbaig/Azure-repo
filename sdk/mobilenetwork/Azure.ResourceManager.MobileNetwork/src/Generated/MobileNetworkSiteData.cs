// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.MobileNetwork.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.MobileNetwork
{
    /// <summary>
    /// A class representing the MobileNetworkSite data model.
    /// Site resource. Must be created in the same location as its parent mobile network.
    /// </summary>
    public partial class MobileNetworkSiteData : TrackedResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MobileNetworkSiteData"/>. </summary>
        /// <param name="location"> The location. </param>
        public MobileNetworkSiteData(AzureLocation location) : base(location)
        {
            NetworkFunctions = new ChangeTrackingList<SubResource>();
        }

        /// <summary> Initializes a new instance of <see cref="MobileNetworkSiteData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="provisioningState"> The provisioning state of the site resource. </param>
        /// <param name="networkFunctions"> An array of IDs of the network functions deployed in the site. Deleting the site will delete any network functions that are deployed in the site. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MobileNetworkSiteData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, MobileNetworkProvisioningState? provisioningState, IReadOnlyList<SubResource> networkFunctions, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData, tags, location)
        {
            ProvisioningState = provisioningState;
            NetworkFunctions = networkFunctions;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="MobileNetworkSiteData"/> for deserialization. </summary>
        internal MobileNetworkSiteData()
        {
        }

        /// <summary> The provisioning state of the site resource. </summary>
        public MobileNetworkProvisioningState? ProvisioningState { get; }
        /// <summary> An array of IDs of the network functions deployed in the site. Deleting the site will delete any network functions that are deployed in the site. </summary>
        public IReadOnlyList<SubResource> NetworkFunctions { get; }
    }
}
