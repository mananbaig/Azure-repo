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
    /// Response for ListSecurityRule Api service callRetrieves all security
    /// rules that belongs to a network security group
    /// </summary>
    public partial class SecurityRuleListResultInner
    {
        /// <summary>
        /// Initializes a new instance of the SecurityRuleListResultInner
        /// class.
        /// </summary>
        public SecurityRuleListResultInner() { }

        /// <summary>
        /// Initializes a new instance of the SecurityRuleListResultInner
        /// class.
        /// </summary>
        /// <param name="value">Gets security rules in a network security
        /// group</param>
        /// <param name="nextLink">Gets the URL to get the next set of
        /// results.</param>
        public SecurityRuleListResultInner(System.Collections.Generic.IList<SecurityRuleInner> value = default(System.Collections.Generic.IList<SecurityRuleInner>), string nextLink = default(string))
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary>
        /// Gets security rules in a network security group
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "value")]
        public System.Collections.Generic.IList<SecurityRuleInner> Value { get; set; }

        /// <summary>
        /// Gets the URL to get the next set of results.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; set; }

    }
}
