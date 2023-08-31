// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> List of all Static Routes. </summary>
    public partial class StaticRoute
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="StaticRoute"/>. </summary>
        public StaticRoute()
        {
            AddressPrefixes = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="StaticRoute"/>. </summary>
        /// <param name="name"> The name of the StaticRoute that is unique within a VnetRoute. </param>
        /// <param name="addressPrefixes"> List of all address prefixes. </param>
        /// <param name="nextHopIPAddress"> The ip address of the next hop. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal StaticRoute(string name, IList<string> addressPrefixes, string nextHopIPAddress, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            AddressPrefixes = addressPrefixes;
            NextHopIPAddress = nextHopIPAddress;
            _rawData = rawData;
        }

        /// <summary> The name of the StaticRoute that is unique within a VnetRoute. </summary>
        public string Name { get; set; }
        /// <summary> List of all address prefixes. </summary>
        public IList<string> AddressPrefixes { get; }
        /// <summary> The ip address of the next hop. </summary>
        public string NextHopIPAddress { get; set; }
    }
}
