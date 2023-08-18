// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.HybridCompute;

namespace Azure.ResourceManager.HybridCompute.Models
{
    /// <summary> A list of private endpoint connections. </summary>
    internal partial class HybridComputePrivateEndpointConnectionListResult
    {
        /// <summary> Initializes a new instance of HybridComputePrivateEndpointConnectionListResult. </summary>
        internal HybridComputePrivateEndpointConnectionListResult()
        {
            Value = new Core.ChangeTrackingList<HybridComputePrivateEndpointConnectionData>();
        }

        /// <summary> Initializes a new instance of HybridComputePrivateEndpointConnectionListResult. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal HybridComputePrivateEndpointConnectionListResult(IReadOnlyList<HybridComputePrivateEndpointConnectionData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<HybridComputePrivateEndpointConnectionData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
