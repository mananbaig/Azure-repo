// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The routes table associated with the ExpressRouteCircuit. </summary>
    public partial class ExpressRouteCrossConnectionRoutesTableSummary
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ExpressRouteCrossConnectionRoutesTableSummary"/>. </summary>
        internal ExpressRouteCrossConnectionRoutesTableSummary()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ExpressRouteCrossConnectionRoutesTableSummary"/>. </summary>
        /// <param name="neighbor"> IP address of Neighbor router. </param>
        /// <param name="asn"> Autonomous system number. </param>
        /// <param name="upDown"> The length of time that the BGP session has been in the Established state, or the current status if not in the Established state. </param>
        /// <param name="stateOrPrefixesReceived"> Current state of the BGP session, and the number of prefixes that have been received from a neighbor or peer group. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ExpressRouteCrossConnectionRoutesTableSummary(string neighbor, int? asn, string upDown, string stateOrPrefixesReceived, Dictionary<string, BinaryData> rawData)
        {
            Neighbor = neighbor;
            Asn = asn;
            UpDown = upDown;
            StateOrPrefixesReceived = stateOrPrefixesReceived;
            _rawData = rawData;
        }

        /// <summary> IP address of Neighbor router. </summary>
        public string Neighbor { get; }
        /// <summary> Autonomous system number. </summary>
        public int? Asn { get; }
        /// <summary> The length of time that the BGP session has been in the Established state, or the current status if not in the Established state. </summary>
        public string UpDown { get; }
        /// <summary> Current state of the BGP session, and the number of prefixes that have been received from a neighbor or peer group. </summary>
        public string StateOrPrefixesReceived { get; }
    }
}
