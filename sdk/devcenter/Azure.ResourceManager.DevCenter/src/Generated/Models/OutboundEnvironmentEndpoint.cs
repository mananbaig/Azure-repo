// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DevCenter.Models
{
    /// <summary> A collection of related endpoints from the same service for which the agent requires outbound access. </summary>
    public partial class OutboundEnvironmentEndpoint
    {
        /// <summary> Initializes a new instance of OutboundEnvironmentEndpoint. </summary>
        internal OutboundEnvironmentEndpoint()
        {
            Endpoints = new Core.ChangeTrackingList<EndpointDependency>();
        }

        /// <summary> Initializes a new instance of OutboundEnvironmentEndpoint. </summary>
        /// <param name="category"> The type of service that the agent connects to. </param>
        /// <param name="endpoints"> The endpoints for this service for which the agent requires outbound access. </param>
        internal OutboundEnvironmentEndpoint(string category, IReadOnlyList<EndpointDependency> endpoints)
        {
            Category = category;
            Endpoints = endpoints;
        }

        /// <summary> The type of service that the agent connects to. </summary>
        public string Category { get; }
        /// <summary> The endpoints for this service for which the agent requires outbound access. </summary>
        public IReadOnlyList<EndpointDependency> Endpoints { get; }
    }
}
