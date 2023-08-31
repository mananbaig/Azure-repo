// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> EffectiveRoutes List. </summary>
    public partial class VirtualHubEffectiveRouteList
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="VirtualHubEffectiveRouteList"/>. </summary>
        internal VirtualHubEffectiveRouteList()
        {
            Value = new ChangeTrackingList<VirtualHubEffectiveRoute>();
        }

        /// <summary> Initializes a new instance of <see cref="VirtualHubEffectiveRouteList"/>. </summary>
        /// <param name="value"> The list of effective routes configured on the virtual hub or the specified resource. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualHubEffectiveRouteList(IReadOnlyList<VirtualHubEffectiveRoute> value, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            _rawData = rawData;
        }

        /// <summary> The list of effective routes configured on the virtual hub or the specified resource. </summary>
        public IReadOnlyList<VirtualHubEffectiveRoute> Value { get; }
    }
}
