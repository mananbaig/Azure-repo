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
    /// Response for ListVirtualNetworkGateways Api service call
    /// </summary>
    public partial class VirtualNetworkGatewayListResultInner
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualNetworkGatewayListResultInner class.
        /// </summary>
        public VirtualNetworkGatewayListResultInner() { }

        /// <summary>
        /// Initializes a new instance of the
        /// VirtualNetworkGatewayListResultInner class.
        /// </summary>
        /// <param name="value">Gets List of VirtualNetworkGateways that
        /// exists in a resource group</param>
        /// <param name="nextLink">Gets the URL to get the next set of
        /// results.</param>
        public VirtualNetworkGatewayListResultInner(System.Collections.Generic.IList<VirtualNetworkGatewayInner> value = default(System.Collections.Generic.IList<VirtualNetworkGatewayInner>), string nextLink = default(string))
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary>
        /// Gets List of VirtualNetworkGateways that exists in a resource group
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "value")]
        public System.Collections.Generic.IList<VirtualNetworkGatewayInner> Value { get; set; }

        /// <summary>
        /// Gets the URL to get the next set of results.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; set; }

    }
}
