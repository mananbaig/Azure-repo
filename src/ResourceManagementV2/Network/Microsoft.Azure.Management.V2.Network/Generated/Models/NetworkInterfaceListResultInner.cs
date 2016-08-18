// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System.Linq;

    /// <summary>
    /// Response for ListNetworkInterface Api service call
    /// </summary>
    public partial class NetworkInterfaceListResultInner
    {
        /// <summary>
        /// Initializes a new instance of the NetworkInterfaceListResultInner
        /// class.
        /// </summary>
        public NetworkInterfaceListResultInner() { }

        /// <summary>
        /// Initializes a new instance of the NetworkInterfaceListResultInner
        /// class.
        /// </summary>
        /// <param name="value">Gets or sets list of NetworkInterfaces in a
        /// resource group</param>
        /// <param name="nextLink">Gets the URL to get the next set of
        /// results.</param>
        public NetworkInterfaceListResultInner(System.Collections.Generic.IList<NetworkInterfaceInner> value = default(System.Collections.Generic.IList<NetworkInterfaceInner>), string nextLink = default(string))
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary>
        /// Gets or sets list of NetworkInterfaces in a resource group
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "value")]
        public System.Collections.Generic.IList<NetworkInterfaceInner> Value { get; set; }

        /// <summary>
        /// Gets the URL to get the next set of results.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; set; }

    }
}
