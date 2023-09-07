// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> The details of Azure-SSIS integration runtime outbound network dependency endpoint. </summary>
    public partial class SynapseIntegrationRuntimeOutboundNetworkDependenciesEndpointDetails
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SynapseIntegrationRuntimeOutboundNetworkDependenciesEndpointDetails"/>. </summary>
        internal SynapseIntegrationRuntimeOutboundNetworkDependenciesEndpointDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SynapseIntegrationRuntimeOutboundNetworkDependenciesEndpointDetails"/>. </summary>
        /// <param name="port"> The port of endpoint. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SynapseIntegrationRuntimeOutboundNetworkDependenciesEndpointDetails(int? port, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Port = port;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The port of endpoint. </summary>
        public int? Port { get; }
    }
}
