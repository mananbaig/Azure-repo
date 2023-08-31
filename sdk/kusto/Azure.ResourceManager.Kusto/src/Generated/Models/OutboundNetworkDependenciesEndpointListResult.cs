// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.Kusto.Models
{
    /// <summary> Collection of Outbound Environment Endpoints. </summary>
    internal partial class OutboundNetworkDependenciesEndpointListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="OutboundNetworkDependenciesEndpointListResult"/>. </summary>
        /// <param name="value"> Collection of resources. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal OutboundNetworkDependenciesEndpointListResult(IEnumerable<OutboundNetworkDependenciesEndpoint> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="OutboundNetworkDependenciesEndpointListResult"/>. </summary>
        /// <param name="value"> Collection of resources. </param>
        /// <param name="nextLink"> Link to next page of resources. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal OutboundNetworkDependenciesEndpointListResult(IReadOnlyList<OutboundNetworkDependenciesEndpoint> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="OutboundNetworkDependenciesEndpointListResult"/> for deserialization. </summary>
        internal OutboundNetworkDependenciesEndpointListResult()
        {
        }

        /// <summary> Collection of resources. </summary>
        public IReadOnlyList<OutboundNetworkDependenciesEndpoint> Value { get; }
        /// <summary> Link to next page of resources. </summary>
        public string NextLink { get; }
    }
}
