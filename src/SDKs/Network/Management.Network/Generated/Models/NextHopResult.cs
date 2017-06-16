// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Network;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The information about next hop from the specified VM.
    /// </summary>
    public partial class NextHopResult
    {
        /// <summary>
        /// Initializes a new instance of the NextHopResult class.
        /// </summary>
        public NextHopResult()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NextHopResult class.
        /// </summary>
        /// <param name="nextHopType">Next hop type. Possible values include:
        /// 'Internet', 'VirtualAppliance', 'VirtualNetworkGateway',
        /// 'VnetLocal', 'HyperNetGateway', 'None'</param>
        /// <param name="nextHopIpAddress">Next hop IP Address</param>
        /// <param name="routeTableId">The resource identifier for the route
        /// table associated with the route being returned. If the route being
        /// returned does not correspond to any user created routes then this
        /// field will be the string 'System Route'.</param>
        public NextHopResult(string nextHopType = default(string), string nextHopIpAddress = default(string), string routeTableId = default(string))
        {
            NextHopType = nextHopType;
            NextHopIpAddress = nextHopIpAddress;
            RouteTableId = routeTableId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets next hop type. Possible values include: 'Internet',
        /// 'VirtualAppliance', 'VirtualNetworkGateway', 'VnetLocal',
        /// 'HyperNetGateway', 'None'
        /// </summary>
        [JsonProperty(PropertyName = "nextHopType")]
        public string NextHopType { get; set; }

        /// <summary>
        /// Gets or sets next hop IP Address
        /// </summary>
        [JsonProperty(PropertyName = "nextHopIpAddress")]
        public string NextHopIpAddress { get; set; }

        /// <summary>
        /// Gets or sets the resource identifier for the route table associated
        /// with the route being returned. If the route being returned does not
        /// correspond to any user created routes then this field will be the
        /// string 'System Route'.
        /// </summary>
        [JsonProperty(PropertyName = "routeTableId")]
        public string RouteTableId { get; set; }

    }
}
