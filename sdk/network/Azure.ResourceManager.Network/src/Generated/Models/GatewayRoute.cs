// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Gateway routing details. </summary>
    public partial class GatewayRoute
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="GatewayRoute"/>. </summary>
        internal GatewayRoute()
        {
        }

        /// <summary> Initializes a new instance of <see cref="GatewayRoute"/>. </summary>
        /// <param name="localAddress"> The gateway's local address. </param>
        /// <param name="network"> The route's network prefix. </param>
        /// <param name="nextHop"> The route's next hop. </param>
        /// <param name="sourcePeer"> The peer this route was learned from. </param>
        /// <param name="origin"> The source this route was learned from. </param>
        /// <param name="asPath"> The route's AS path sequence. </param>
        /// <param name="weight"> The route's weight. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal GatewayRoute(string localAddress, string network, string nextHop, string sourcePeer, string origin, string asPath, int? weight, Dictionary<string, BinaryData> rawData)
        {
            LocalAddress = localAddress;
            Network = network;
            NextHop = nextHop;
            SourcePeer = sourcePeer;
            Origin = origin;
            AsPath = asPath;
            Weight = weight;
            _rawData = rawData;
        }

        /// <summary> The gateway's local address. </summary>
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
