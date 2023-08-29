// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppConfiguration.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.AppConfiguration
{
    /// <summary>
    /// A class representing the AppConfigurationPrivateEndpointConnection data model.
    /// A private endpoint connection
    /// </summary>
    public partial class AppConfigurationPrivateEndpointConnectionData : ResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AppConfigurationPrivateEndpointConnectionData"/>. </summary>
        public AppConfigurationPrivateEndpointConnectionData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppConfigurationPrivateEndpointConnectionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> The provisioning status of the private endpoint connection. </param>
        /// <param name="privateEndpoint"> The resource of private endpoint. </param>
        /// <param name="connectionState"> A collection of information about the state of the connection between service consumer and provider. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AppConfigurationPrivateEndpointConnectionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AppConfigurationProvisioningState? provisioningState, WritableSubResource privateEndpoint, AppConfigurationPrivateLinkServiceConnectionState connectionState, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            ProvisioningState = provisioningState;
            PrivateEndpoint = privateEndpoint;
            ConnectionState = connectionState;
            _rawData = rawData;
        }

        /// <summary> The provisioning status of the private endpoint connection. </summary>
        public AppConfigurationProvisioningState? ProvisioningState { get; }
        /// <summary> The resource of private endpoint. </summary>
        internal WritableSubResource PrivateEndpoint { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier PrivateEndpointId
        {
            get => PrivateEndpoint is null ? default : PrivateEndpoint.Id;
            set
            {
                if (PrivateEndpoint is null)
                    PrivateEndpoint = new WritableSubResource();
                PrivateEndpoint.Id = value;
            }
        }

        /// <summary> A collection of information about the state of the connection between service consumer and provider. </summary>
        public AppConfigurationPrivateLinkServiceConnectionState ConnectionState { get; set; }
    }
}
