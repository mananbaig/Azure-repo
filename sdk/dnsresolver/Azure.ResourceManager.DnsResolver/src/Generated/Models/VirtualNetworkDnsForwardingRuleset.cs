// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.DnsResolver.Models
{
    /// <summary> Reference to DNS forwarding ruleset and associated virtual network link. </summary>
    public partial class VirtualNetworkDnsForwardingRuleset
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

        /// <summary> Initializes a new instance of <see cref="VirtualNetworkDnsForwardingRuleset"/>. </summary>
        internal VirtualNetworkDnsForwardingRuleset()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VirtualNetworkDnsForwardingRuleset"/>. </summary>
        /// <param name="id"> DNS Forwarding Ruleset Resource ID. </param>
        /// <param name="virtualNetworkLink"> The reference to the virtual network link. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualNetworkDnsForwardingRuleset(ResourceIdentifier id, WritableSubResource virtualNetworkLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            VirtualNetworkLink = virtualNetworkLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> DNS Forwarding Ruleset Resource ID. </summary>
        public ResourceIdentifier Id { get; }
        /// <summary> The reference to the virtual network link. </summary>
        internal WritableSubResource VirtualNetworkLink { get; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier VirtualNetworkLinkId
        {
            get => VirtualNetworkLink?.Id;
        }
    }
}
