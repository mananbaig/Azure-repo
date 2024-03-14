// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CognitiveServices;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> A rule governing the accessibility from a specific virtual network. </summary>
    public partial class CognitiveServicesVirtualNetworkRule
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

        /// <summary> Initializes a new instance of <see cref="CognitiveServicesVirtualNetworkRule"/>. </summary>
        /// <param name="id"> Full resource id of a vnet subnet, such as '/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/virtualNetworks/test-vnet/subnets/subnet1'. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public CognitiveServicesVirtualNetworkRule(ResourceIdentifier id)
        {
            Argument.AssertNotNull(id, nameof(id));

            Id = id;
        }

        /// <summary> Initializes a new instance of <see cref="CognitiveServicesVirtualNetworkRule"/>. </summary>
        /// <param name="id"> Full resource id of a vnet subnet, such as '/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/virtualNetworks/test-vnet/subnets/subnet1'. </param>
        /// <param name="state"> Gets the state of virtual network rule. </param>
        /// <param name="ignoreMissingVnetServiceEndpoint"> Ignore missing vnet service endpoint or not. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CognitiveServicesVirtualNetworkRule(ResourceIdentifier id, string state, bool? ignoreMissingVnetServiceEndpoint, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            State = state;
            IgnoreMissingVnetServiceEndpoint = ignoreMissingVnetServiceEndpoint;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CognitiveServicesVirtualNetworkRule"/> for deserialization. </summary>
        internal CognitiveServicesVirtualNetworkRule()
        {
        }

        /// <summary> Full resource id of a vnet subnet, such as '/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/virtualNetworks/test-vnet/subnets/subnet1'. </summary>
        public ResourceIdentifier Id { get; set; }
        /// <summary> Gets the state of virtual network rule. </summary>
        public string State { get; set; }
        /// <summary> Ignore missing vnet service endpoint or not. </summary>
        public bool? IgnoreMissingVnetServiceEndpoint { get; set; }
    }
}
