// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Egress endpoints which AKS agent nodes connect to for common purpose. </summary>
    public partial class ContainerServiceOutboundEnvironmentEndpoint
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ContainerServiceOutboundEnvironmentEndpoint"/>. </summary>
        internal ContainerServiceOutboundEnvironmentEndpoint()
        {
            Endpoints = new ChangeTrackingList<ContainerServiceEndpointDependency>();
        }

        /// <summary> Initializes a new instance of <see cref="ContainerServiceOutboundEnvironmentEndpoint"/>. </summary>
        /// <param name="category"> The category of endpoints accessed by the AKS agent node, e.g. azure-resource-management, apiserver, etc. </param>
        /// <param name="endpoints"> The endpoints that AKS agent nodes connect to. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerServiceOutboundEnvironmentEndpoint(string category, IReadOnlyList<ContainerServiceEndpointDependency> endpoints, Dictionary<string, BinaryData> rawData)
        {
            Category = category;
            Endpoints = endpoints;
            _rawData = rawData;
        }

        /// <summary> The category of endpoints accessed by the AKS agent node, e.g. azure-resource-management, apiserver, etc. </summary>
        public string Category { get; }
        /// <summary> The endpoints that AKS agent nodes connect to. </summary>
        public IReadOnlyList<ContainerServiceEndpointDependency> Endpoints { get; }
    }
}
