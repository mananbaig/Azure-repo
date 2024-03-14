// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.ManagedNetworkFabric;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> Port condition that needs to be matched. </summary>
    public partial class NetworkFabricPortCondition
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

        /// <summary> Initializes a new instance of <see cref="NetworkFabricPortCondition"/>. </summary>
        /// <param name="layer4Protocol"> Layer4 protocol type that needs to be matched. </param>
        public NetworkFabricPortCondition(Layer4Protocol layer4Protocol)
        {
            Layer4Protocol = layer4Protocol;
            Ports = new ChangeTrackingList<string>();
            PortGroupNames = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkFabricPortCondition"/>. </summary>
        /// <param name="portType"> Port type that needs to be matched. </param>
        /// <param name="layer4Protocol"> Layer4 protocol type that needs to be matched. </param>
        /// <param name="ports"> List of the Ports that need to be matched. </param>
        /// <param name="portGroupNames"> List of the port Group Names that need to be matched. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkFabricPortCondition(NetworkFabricPortType? portType, Layer4Protocol layer4Protocol, IList<string> ports, IList<string> portGroupNames, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PortType = portType;
            Layer4Protocol = layer4Protocol;
            Ports = ports;
            PortGroupNames = portGroupNames;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="NetworkFabricPortCondition"/> for deserialization. </summary>
        internal NetworkFabricPortCondition()
        {
        }

        /// <summary> Port type that needs to be matched. </summary>
        public NetworkFabricPortType? PortType { get; set; }
        /// <summary> Layer4 protocol type that needs to be matched. </summary>
        public Layer4Protocol Layer4Protocol { get; set; }
        /// <summary> List of the Ports that need to be matched. </summary>
        public IList<string> Ports { get; }
        /// <summary> List of the port Group Names that need to be matched. </summary>
        public IList<string> PortGroupNames { get; }
    }
}
