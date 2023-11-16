// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NetworkAnalytics.Models
{
    /// <summary> Virtual Network Rule. </summary>
    public partial class NetworkAnalyticsVirtualNetworkRule
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="NetworkAnalyticsVirtualNetworkRule"/>. </summary>
        /// <param name="id"> Resource ID of a subnet. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public NetworkAnalyticsVirtualNetworkRule(string id)
        {
            Argument.AssertNotNull(id, nameof(id));

            Id = id;
        }

        /// <summary> Initializes a new instance of <see cref="NetworkAnalyticsVirtualNetworkRule"/>. </summary>
        /// <param name="id"> Resource ID of a subnet. </param>
        /// <param name="action"> The action of virtual network rule. </param>
        /// <param name="state"> Gets the state of virtual network rule. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkAnalyticsVirtualNetworkRule(string id, string action, string state, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Action = action;
            State = state;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="NetworkAnalyticsVirtualNetworkRule"/> for deserialization. </summary>
        internal NetworkAnalyticsVirtualNetworkRule()
        {
        }

        /// <summary> Resource ID of a subnet. </summary>
        public string Id { get; set; }
        /// <summary> The action of virtual network rule. </summary>
        public string Action { get; set; }
        /// <summary> Gets the state of virtual network rule. </summary>
        public string State { get; set; }
    }
}
