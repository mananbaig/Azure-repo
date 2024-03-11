// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Peer routing details. </summary>
    public partial class PeerRoute
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

        /// <summary> Initializes a new instance of <see cref="PeerRoute"/>. </summary>
        internal PeerRoute()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PeerRoute"/>. </summary>
        /// <param name="localAddress"> The peer's local address. </param>
        /// <param name="network"> The route's network prefix. </param>
        /// <param name="nextHop"> The route's next hop. </param>
        /// <param name="sourcePeer"> The peer this route was learned from. </param>
        /// <param name="origin"> The source this route was learned from. </param>
        /// <param name="asPath"> The route's AS path sequence. </param>
        /// <param name="weight"> The route's weight. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PeerRoute(string localAddress, string network, string nextHop, string sourcePeer, string origin, string asPath, int? weight, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            LocalAddress = localAddress;
            Network = network;
            NextHop = nextHop;
            SourcePeer = sourcePeer;
            Origin = origin;
            AsPath = asPath;
            Weight = weight;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The peer's local address. </summary>
        public string LocalAddress { get; }
        /// <summary> The route's network prefix. </summary>
        public string Network { get; }
        /// <summary> The route's next hop. </summary>
        public string NextHop { get; }
        /// <summary> The peer this route was learned from. </summary>
        public string SourcePeer { get; }
        /// <summary> The source this route was learned from. </summary>
        public string Origin { get; }
        /// <summary> The route's AS path sequence. </summary>
        public string AsPath { get; }
        /// <summary> The route's weight. </summary>
        public int? Weight { get; }
    }
}
