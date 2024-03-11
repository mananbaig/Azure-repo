// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.ManagedNetworkFabric;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> Defines the common match conditions of the ACL and Network Tap Rule. </summary>
    public partial class CommonMatchConditions
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
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CommonMatchConditions"/>. </summary>
        public CommonMatchConditions()
        {
            ProtocolTypes = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="CommonMatchConditions"/>. </summary>
        /// <param name="protocolTypes"> List of the protocols that need to be matched. </param>
        /// <param name="vlanMatchCondition"> Vlan match condition that needs to be matched. </param>
        /// <param name="ipCondition"> IP condition that needs to be matched. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CommonMatchConditions(IList<string> protocolTypes, VlanMatchCondition vlanMatchCondition, IPMatchCondition ipCondition, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ProtocolTypes = protocolTypes;
            VlanMatchCondition = vlanMatchCondition;
            IPCondition = ipCondition;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of the protocols that need to be matched. </summary>
        public IList<string> ProtocolTypes { get; }
        /// <summary> Vlan match condition that needs to be matched. </summary>
        public VlanMatchCondition VlanMatchCondition { get; set; }
        /// <summary> IP condition that needs to be matched. </summary>
        public IPMatchCondition IPCondition { get; set; }
    }
}
