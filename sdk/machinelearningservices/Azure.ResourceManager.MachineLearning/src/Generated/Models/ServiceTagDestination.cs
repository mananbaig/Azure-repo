// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.MachineLearning;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Service Tag destination for a Service Tag Outbound Rule for the managed network of a machine learning workspace. </summary>
    public partial class ServiceTagDestination
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

        /// <summary> Initializes a new instance of <see cref="ServiceTagDestination"/>. </summary>
        public ServiceTagDestination()
        {
            AddressPrefixes = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ServiceTagDestination"/>. </summary>
        /// <param name="action"> The action enum for networking rule. </param>
        /// <param name="addressPrefixes"> Optional, if provided, the ServiceTag property will be ignored. </param>
        /// <param name="portRanges"></param>
        /// <param name="protocol"></param>
        /// <param name="serviceTag"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ServiceTagDestination(NetworkingRuleAction? action, IReadOnlyList<string> addressPrefixes, string portRanges, string protocol, string serviceTag, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Action = action;
            AddressPrefixes = addressPrefixes;
            PortRanges = portRanges;
            Protocol = protocol;
            ServiceTag = serviceTag;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The action enum for networking rule. </summary>
        public NetworkingRuleAction? Action { get; set; }
        /// <summary> Optional, if provided, the ServiceTag property will be ignored. </summary>
        public IReadOnlyList<string> AddressPrefixes { get; }
        /// <summary> Gets or sets the port ranges. </summary>
        public string PortRanges { get; set; }
        /// <summary> Gets or sets the protocol. </summary>
        public string Protocol { get; set; }
        /// <summary> Gets or sets the service tag. </summary>
        public string ServiceTag { get; set; }
    }
}
