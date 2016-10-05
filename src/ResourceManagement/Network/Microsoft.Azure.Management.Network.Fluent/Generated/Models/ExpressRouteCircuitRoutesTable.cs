// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// The routes table associated with the ExpressRouteCircuit
    /// </summary>
    public partial class ExpressRouteCircuitRoutesTable
    {
        /// <summary>
        /// Initializes a new instance of the ExpressRouteCircuitRoutesTable
        /// class.
        /// </summary>
        public ExpressRouteCircuitRoutesTable() { }

        /// <summary>
        /// Initializes a new instance of the ExpressRouteCircuitRoutesTable
        /// class.
        /// </summary>
        /// <param name="network">network.</param>
        /// <param name="nextHop">nextHop</param>
        /// <param name="locPrf">locPrf.</param>
        /// <param name="weight">weight.</param>
        /// <param name="path">path .</param>
        public ExpressRouteCircuitRoutesTable(string network = default(string), string nextHop = default(string), string locPrf = default(string), int? weight = default(int?), string path = default(string))
        {
            Network = network;
            NextHop = nextHop;
            LocPrf = locPrf;
            Weight = weight;
            Path = path;
        }

        /// <summary>
        /// Gets or sets network.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "network")]
        public string Network { get; set; }

        /// <summary>
        /// Gets or sets nextHop
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "nextHop")]
        public string NextHop { get; set; }

        /// <summary>
        /// Gets or sets locPrf.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "locPrf")]
        public string LocPrf { get; set; }

        /// <summary>
        /// Gets or sets weight.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "weight")]
        public int? Weight { get; set; }

        /// <summary>
        /// Gets or sets path .
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

    }
}
