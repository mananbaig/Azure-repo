// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> List of virtual network gateway vpn client connection health. </summary>
    public partial class VpnClientConnectionHealthDetailListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="VpnClientConnectionHealthDetailListResult"/>. </summary>
        internal VpnClientConnectionHealthDetailListResult()
        {
            Value = new ChangeTrackingList<VpnClientConnectionHealthDetail>();
        }

        /// <summary> Initializes a new instance of <see cref="VpnClientConnectionHealthDetailListResult"/>. </summary>
        /// <param name="value"> List of vpn client connection health. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal VpnClientConnectionHealthDetailListResult(IReadOnlyList<VpnClientConnectionHealthDetail> value, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            _rawData = rawData;
        }

        /// <summary> List of vpn client connection health. </summary>
        public IReadOnlyList<VpnClientConnectionHealthDetail> Value { get; }
    }
}
