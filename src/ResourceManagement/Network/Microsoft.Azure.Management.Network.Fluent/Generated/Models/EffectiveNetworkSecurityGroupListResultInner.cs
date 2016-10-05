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
    /// Response for list effective network security groups api servive call
    /// </summary>
    public partial class EffectiveNetworkSecurityGroupListResultInner
    {
        /// <summary>
        /// Initializes a new instance of the
        /// EffectiveNetworkSecurityGroupListResultInner class.
        /// </summary>
        public EffectiveNetworkSecurityGroupListResultInner() { }

        /// <summary>
        /// Initializes a new instance of the
        /// EffectiveNetworkSecurityGroupListResultInner class.
        /// </summary>
        /// <param name="value">Gets list of effective network security
        /// groups</param>
        /// <param name="nextLink">Gets the URL to get the next set of
        /// results.</param>
        public EffectiveNetworkSecurityGroupListResultInner(System.Collections.Generic.IList<EffectiveNetworkSecurityGroup> value = default(System.Collections.Generic.IList<EffectiveNetworkSecurityGroup>), string nextLink = default(string))
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary>
        /// Gets list of effective network security groups
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "value")]
        public System.Collections.Generic.IList<EffectiveNetworkSecurityGroup> Value { get; set; }

        /// <summary>
        /// Gets the URL to get the next set of results.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; set; }

    }
}
