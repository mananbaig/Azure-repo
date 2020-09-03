// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    /// <summary> Response for ListConnections API service call retrieves all global reach connections that belongs to a Private Peering for an ExpressRouteCircuit. </summary>
    public partial class ExpressRouteCircuitConnectionListResult
    {
        /// <summary> Initializes a new instance of ExpressRouteCircuitConnectionListResult. </summary>
        internal ExpressRouteCircuitConnectionListResult()
        {
            Value = new ChangeTrackingList<ExpressRouteCircuitConnection>();
        }

        /// <summary> Initializes a new instance of ExpressRouteCircuitConnectionListResult. </summary>
        /// <param name="value"> The global reach connection associated with Private Peering in an ExpressRoute Circuit. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        internal ExpressRouteCircuitConnectionListResult(IReadOnlyList<ExpressRouteCircuitConnection> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The global reach connection associated with Private Peering in an ExpressRoute Circuit. </summary>
        public IReadOnlyList<ExpressRouteCircuitConnection> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
