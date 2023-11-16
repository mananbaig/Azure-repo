// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> CloudServicesNetworkPatchParameters represents the body of the request to patch the cloud services network. </summary>
    public partial class NetworkCloudCloudServicesNetworkPatch
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="NetworkCloudCloudServicesNetworkPatch"/>. </summary>
        public NetworkCloudCloudServicesNetworkPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            AdditionalEgressEndpoints = new ChangeTrackingList<EgressEndpoint>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkCloudCloudServicesNetworkPatch"/>. </summary>
        /// <param name="tags"> The Azure resource tags that will replace the existing ones. </param>
        /// <param name="additionalEgressEndpoints"> The list of egress endpoints. This allows for connection from a Hybrid AKS cluster to the specified endpoint. </param>
        /// <param name="enableDefaultEgressEndpoints"> The indicator of whether the platform default endpoints are allowed for the egress traffic. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkCloudCloudServicesNetworkPatch(IDictionary<string, string> tags, IList<EgressEndpoint> additionalEgressEndpoints, CloudServicesNetworkEnableDefaultEgressEndpoint? enableDefaultEgressEndpoints, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Tags = tags;
            AdditionalEgressEndpoints = additionalEgressEndpoints;
            EnableDefaultEgressEndpoints = enableDefaultEgressEndpoints;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The Azure resource tags that will replace the existing ones. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The list of egress endpoints. This allows for connection from a Hybrid AKS cluster to the specified endpoint. </summary>
        public IList<EgressEndpoint> AdditionalEgressEndpoints { get; }
        /// <summary> The indicator of whether the platform default endpoints are allowed for the egress traffic. </summary>
        public CloudServicesNetworkEnableDefaultEgressEndpoint? EnableDefaultEgressEndpoints { get; set; }
    }
}
