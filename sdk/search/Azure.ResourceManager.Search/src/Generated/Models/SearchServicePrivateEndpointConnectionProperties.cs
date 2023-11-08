// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Search.Models
{
    /// <summary> Describes the properties of an existing Private Endpoint connection to the Azure Cognitive Search service. </summary>
    public partial class SearchServicePrivateEndpointConnectionProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SearchServicePrivateEndpointConnectionProperties"/>. </summary>
        public SearchServicePrivateEndpointConnectionProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SearchServicePrivateEndpointConnectionProperties"/>. </summary>
        /// <param name="privateEndpoint"> The private endpoint resource from Microsoft.Network provider. </param>
        /// <param name="connectionState"> Describes the current state of an existing Private Link Service connection to the Azure Private Endpoint. </param>
        /// <param name="groupId"> The group id from the provider of resource the private link service connection is for. </param>
        /// <param name="provisioningState"> The provisioning state of the private link service connection. Can be Updating, Deleting, Failed, Succeeded, or Incomplete. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SearchServicePrivateEndpointConnectionProperties(WritableSubResource privateEndpoint, SearchServicePrivateLinkServiceConnectionState connectionState, string groupId, SearchPrivateLinkServiceConnectionProvisioningState? provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PrivateEndpoint = privateEndpoint;
            ConnectionState = connectionState;
            GroupId = groupId;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The private endpoint resource from Microsoft.Network provider. </summary>
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

        /// <summary> Describes the current state of an existing Private Link Service connection to the Azure Private Endpoint. </summary>
        public SearchServicePrivateLinkServiceConnectionState ConnectionState { get; set; }
        /// <summary> The group id from the provider of resource the private link service connection is for. </summary>
        public string GroupId { get; set; }
        /// <summary> The provisioning state of the private link service connection. Can be Updating, Deleting, Failed, Succeeded, or Incomplete. </summary>
        public SearchPrivateLinkServiceConnectionProvisioningState? ProvisioningState { get; set; }
    }
}
