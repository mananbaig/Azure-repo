// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Response for ListExpressRoutePortsLocations API service call. </summary>
    internal partial class ExpressRoutePortsLocationListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ExpressRoutePortsLocationListResult"/>. </summary>
        internal ExpressRoutePortsLocationListResult()
        {
            Value = new ChangeTrackingList<ExpressRoutePortsLocationData>();
        }

        /// <summary> Initializes a new instance of <see cref="ExpressRoutePortsLocationListResult"/>. </summary>
        /// <param name="value"> The list of all ExpressRoutePort peering locations. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ExpressRoutePortsLocationListResult(IReadOnlyList<ExpressRoutePortsLocationData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> The list of all ExpressRoutePort peering locations. </summary>
        public IReadOnlyList<ExpressRoutePortsLocationData> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
