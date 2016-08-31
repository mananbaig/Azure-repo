// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Effective Route
    /// </summary>
    public partial class EffectiveRoute
    {
        /// <summary>
        /// Initializes a new instance of the EffectiveRoute class.
        /// </summary>
        public EffectiveRoute() { }

        /// <summary>
        /// Initializes a new instance of the EffectiveRoute class.
        /// </summary>
        public EffectiveRoute(string name = default(string), string source = default(string), string state = default(string), IList<string> addressPrefix = default(IList<string>), IList<string> nextHopIpAddress = default(IList<string>), string nextHopType = default(string))
        {
            Name = name;
            Source = source;
            State = state;
            AddressPrefix = addressPrefix;
            NextHopIpAddress = nextHopIpAddress;
            NextHopType = nextHopType;
        }

        /// <summary>
        /// Gets the name of the user defined route. This is optional.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets who created the route. Possible values include: 'Unknown',
        /// 'User', 'VirtualNetworkGateway', 'Default'
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        public string Source { get; set; }

        /// <summary>
        /// Gets value of effective route. Possible values include: 'Active',
        /// 'Invalid'
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// Gets address prefixes of the effective routes in CIDR notation.
        /// </summary>
        [JsonProperty(PropertyName = "addressPrefix")]
        public IList<string> AddressPrefix { get; set; }

        /// <summary>
        /// Gets the IP address of the next hop of the effective route
        /// </summary>
        [JsonProperty(PropertyName = "nextHopIpAddress")]
        public IList<string> NextHopIpAddress { get; set; }

        /// <summary>
        /// Gets or sets the type of Azure hop the packet should be sent to.
        /// Possible values include: 'VirtualNetworkGateway', 'VnetLocal',
        /// 'Internet', 'VirtualAppliance', 'None'
        /// </summary>
        [JsonProperty(PropertyName = "nextHopType")]
        public string NextHopType { get; set; }

    }
}
