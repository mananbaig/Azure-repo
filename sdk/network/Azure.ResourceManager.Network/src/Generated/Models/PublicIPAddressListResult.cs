// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Response for ListPublicIpAddresses API service call. </summary>
    internal partial class PublicIPAddressListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PublicIPAddressListResult"/>. </summary>
        internal PublicIPAddressListResult()
        {
            Value = new ChangeTrackingList<PublicIPAddressData>();
        }

        /// <summary> Initializes a new instance of <see cref="PublicIPAddressListResult"/>. </summary>
        /// <param name="value"> A list of public IP addresses that exists in a resource group. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PublicIPAddressListResult(IReadOnlyList<PublicIPAddressData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> A list of public IP addresses that exists in a resource group. </summary>
        public IReadOnlyList<PublicIPAddressData> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
