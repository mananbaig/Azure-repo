// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Cdn;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines a list of WebApplicationFirewallPolicies for Azure CDN. It contains a list of WebApplicationFirewallPolicy objects and a URL link to get the next set of results. </summary>
    internal partial class CdnWebApplicationFirewallPolicyList
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CdnWebApplicationFirewallPolicyList"/>. </summary>
        internal CdnWebApplicationFirewallPolicyList()
        {
            Value = new ChangeTrackingList<CdnWebApplicationFirewallPolicyData>();
        }

        /// <summary> Initializes a new instance of <see cref="CdnWebApplicationFirewallPolicyList"/>. </summary>
        /// <param name="value"> List of Azure CDN WebApplicationFirewallPolicies within a resource group. </param>
        /// <param name="nextLink"> URL to get the next set of WebApplicationFirewallPolicy objects if there are any. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CdnWebApplicationFirewallPolicyList(IReadOnlyList<CdnWebApplicationFirewallPolicyData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of Azure CDN WebApplicationFirewallPolicies within a resource group. </summary>
        public IReadOnlyList<CdnWebApplicationFirewallPolicyData> Value { get; }
        /// <summary> URL to get the next set of WebApplicationFirewallPolicy objects if there are any. </summary>
        public string NextLink { get; }
    }
}
