// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> A private endpoint connection. </summary>
    public partial class PrivateEndpointConnection : ProxyResource
    {
        /// <summary> Initializes a new instance of <see cref="PrivateEndpointConnection"/>. </summary>
        public PrivateEndpointConnection()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PrivateEndpointConnection"/>. </summary>
        /// <param name="id"> Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. </param>
        /// <param name="name"> The name of the resource. </param>
        /// <param name="type"> The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts". </param>
        /// <param name="privateEndpoint"> The private endpoint which the connection belongs to. </param>
        /// <param name="connectionState"> Connection state of the private endpoint connection. </param>
        /// <param name="provisioningState"> Provisioning state of the private endpoint connection. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PrivateEndpointConnection(string id, string name, string type, PrivateEndpoint privateEndpoint, PrivateLinkServiceConnectionState connectionState, string provisioningState, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, type, serializedAdditionalRawData)
        {
            PrivateEndpoint = privateEndpoint;
            ConnectionState = connectionState;
            ProvisioningState = provisioningState;
        }

        /// <summary> The private endpoint which the connection belongs to. </summary>
        public PrivateEndpoint PrivateEndpoint { get; set; }
        /// <summary> Connection state of the private endpoint connection. </summary>
        public PrivateLinkServiceConnectionState ConnectionState { get; set; }
        /// <summary> Provisioning state of the private endpoint connection. </summary>
        public string ProvisioningState { get; }
    }
}
