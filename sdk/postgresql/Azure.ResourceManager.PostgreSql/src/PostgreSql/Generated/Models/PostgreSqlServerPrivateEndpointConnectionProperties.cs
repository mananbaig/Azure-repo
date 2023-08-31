// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.PostgreSql.Models
{
    /// <summary> Properties of a private endpoint connection. </summary>
    public partial class PostgreSqlServerPrivateEndpointConnectionProperties
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PostgreSqlServerPrivateEndpointConnectionProperties"/>. </summary>
        internal PostgreSqlServerPrivateEndpointConnectionProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PostgreSqlServerPrivateEndpointConnectionProperties"/>. </summary>
        /// <param name="privateEndpoint"> Private endpoint which the connection belongs to. </param>
        /// <param name="privateLinkServiceConnectionState"> Connection state of the private endpoint connection. </param>
        /// <param name="provisioningState"> State of the private endpoint connection. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PostgreSqlServerPrivateEndpointConnectionProperties(WritableSubResource privateEndpoint, PostgreSqlServerPrivateLinkServiceConnectionStateProperty privateLinkServiceConnectionState, PostgreSqlPrivateEndpointProvisioningState? provisioningState, Dictionary<string, BinaryData> rawData)
        {
            PrivateEndpoint = privateEndpoint;
            PrivateLinkServiceConnectionState = privateLinkServiceConnectionState;
            ProvisioningState = provisioningState;
            _rawData = rawData;
        }

        /// <summary> Private endpoint which the connection belongs to. </summary>
        internal WritableSubResource PrivateEndpoint { get; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier PrivateEndpointId
        {
            get => PrivateEndpoint?.Id;
        }

        /// <summary> Connection state of the private endpoint connection. </summary>
        public PostgreSqlServerPrivateLinkServiceConnectionStateProperty PrivateLinkServiceConnectionState { get; }
        /// <summary> State of the private endpoint connection. </summary>
        public PostgreSqlPrivateEndpointProvisioningState? ProvisioningState { get; }
    }
}
