// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> SKU of an application gateway. </summary>
    public partial class ApplicationGatewaySku
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewaySku"/>. </summary>
        public ApplicationGatewaySku()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewaySku"/>. </summary>
        /// <param name="name"> Name of an application gateway SKU. </param>
        /// <param name="tier"> Tier of an application gateway. </param>
        /// <param name="capacity"> Capacity (instance count) of an application gateway. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ApplicationGatewaySku(ApplicationGatewaySkuName? name, ApplicationGatewayTier? tier, int? capacity, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            Tier = tier;
            Capacity = capacity;
            _rawData = rawData;
        }

        /// <summary> Name of an application gateway SKU. </summary>
        public ApplicationGatewaySkuName? Name { get; set; }
        /// <summary> Tier of an application gateway. </summary>
        public ApplicationGatewayTier? Tier { get; set; }
        /// <summary> Capacity (instance count) of an application gateway. </summary>
        public int? Capacity { get; set; }
    }
}
