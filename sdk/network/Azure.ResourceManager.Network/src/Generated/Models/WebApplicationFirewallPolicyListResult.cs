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
    /// <summary> Result of the request to list WebApplicationFirewallPolicies. It contains a list of WebApplicationFirewallPolicy objects and a URL link to get the next set of results. </summary>
    internal partial class WebApplicationFirewallPolicyListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="WebApplicationFirewallPolicyListResult"/>. </summary>
        internal WebApplicationFirewallPolicyListResult()
        {
            Value = new ChangeTrackingList<WebApplicationFirewallPolicyData>();
        }

        /// <summary> Initializes a new instance of <see cref="WebApplicationFirewallPolicyListResult"/>. </summary>
        /// <param name="value"> List of WebApplicationFirewallPolicies within a resource group. </param>
        /// <param name="nextLink"> URL to get the next set of WebApplicationFirewallPolicy objects if there are any. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal WebApplicationFirewallPolicyListResult(IReadOnlyList<WebApplicationFirewallPolicyData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of WebApplicationFirewallPolicies within a resource group. </summary>
        public IReadOnlyList<WebApplicationFirewallPolicyData> Value { get; }
        /// <summary> URL to get the next set of WebApplicationFirewallPolicy objects if there are any. </summary>
        public string NextLink { get; }
    }
}
