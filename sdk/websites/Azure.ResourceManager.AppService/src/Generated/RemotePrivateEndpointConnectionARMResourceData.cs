// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing the RemotePrivateEndpointConnectionARMResource data model.
    /// Remote Private Endpoint Connection ARM resource.
    /// </summary>
    public partial class RemotePrivateEndpointConnectionARMResourceData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RemotePrivateEndpointConnectionARMResourceData"/>. </summary>
        public RemotePrivateEndpointConnectionARMResourceData()
        {
            IPAddresses = new ChangeTrackingList<IPAddress>();
        }

        /// <summary> Initializes a new instance of <see cref="RemotePrivateEndpointConnectionARMResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"></param>
        /// <param name="privateEndpoint"> PrivateEndpoint of a remote private endpoint connection. </param>
        /// <param name="privateLinkServiceConnectionState"> The state of a private link connection. </param>
        /// <param name="ipAddresses"> Private IPAddresses mapped to the remote private endpoint. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RemotePrivateEndpointConnectionARMResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string provisioningState, SubResource privateEndpoint, PrivateLinkConnectionState privateLinkServiceConnectionState, IList<IPAddress> ipAddresses, string kind, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            ProvisioningState = provisioningState;
            PrivateEndpoint = privateEndpoint;
            PrivateLinkServiceConnectionState = privateLinkServiceConnectionState;
            IPAddresses = ipAddresses;
            Kind = kind;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the provisioning state. </summary>
        public string ProvisioningState { get; }
        /// <summary> PrivateEndpoint of a remote private endpoint connection. </summary>
        internal SubResource PrivateEndpoint { get; set; }
        /// <summary> Gets Id. </summary>
        public ResourceIdentifier PrivateEndpointId
        {
            get => PrivateEndpoint is null ? default : PrivateEndpoint.Id;
        }

        /// <summary> The state of a private link connection. </summary>
        public PrivateLinkConnectionState PrivateLinkServiceConnectionState { get; set; }
        /// <summary> Private IPAddresses mapped to the remote private endpoint. </summary>
        public IList<IPAddress> IPAddresses { get; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
