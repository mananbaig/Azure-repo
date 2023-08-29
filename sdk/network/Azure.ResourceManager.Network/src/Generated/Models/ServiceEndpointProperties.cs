// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The service endpoint properties. </summary>
    public partial class ServiceEndpointProperties
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ServiceEndpointProperties"/>. </summary>
        public ServiceEndpointProperties()
        {
            Locations = new ChangeTrackingList<AzureLocation>();
        }

        /// <summary> Initializes a new instance of <see cref="ServiceEndpointProperties"/>. </summary>
        /// <param name="service"> The type of the endpoint service. </param>
        /// <param name="locations"> A list of locations. </param>
        /// <param name="provisioningState"> The provisioning state of the service endpoint resource. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ServiceEndpointProperties(string service, IList<AzureLocation> locations, NetworkProvisioningState? provisioningState, Dictionary<string, BinaryData> rawData)
        {
            Service = service;
            Locations = locations;
            ProvisioningState = provisioningState;
            _rawData = rawData;
        }

        /// <summary> The type of the endpoint service. </summary>
        public string Service { get; set; }
        /// <summary> A list of locations. </summary>
        public IList<AzureLocation> Locations { get; }
        /// <summary> The provisioning state of the service endpoint resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
    }
}
