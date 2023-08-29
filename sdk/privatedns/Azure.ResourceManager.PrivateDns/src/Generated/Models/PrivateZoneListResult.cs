// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.PrivateDns;

namespace Azure.ResourceManager.PrivateDns.Models
{
    /// <summary> The response to a Private DNS zone list operation. </summary>
    internal partial class PrivateZoneListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PrivateZoneListResult"/>. </summary>
        internal PrivateZoneListResult()
        {
            Value = new ChangeTrackingList<PrivateDnsZoneData>();
        }

        /// <summary> Initializes a new instance of <see cref="PrivateZoneListResult"/>. </summary>
        /// <param name="value"> Information about the Private DNS zones. </param>
        /// <param name="nextLink"> The continuation token for the next page of results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PrivateZoneListResult(IReadOnlyList<PrivateDnsZoneData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Information about the Private DNS zones. </summary>
        public IReadOnlyList<PrivateDnsZoneData> Value { get; }
        /// <summary> The continuation token for the next page of results. </summary>
        public string NextLink { get; }
    }
}
