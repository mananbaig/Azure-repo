// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.MobileNetwork;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    /// <summary> Response for SIM policies API service call. </summary>
    internal partial class SimPolicyListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SimPolicyListResult"/>. </summary>
        internal SimPolicyListResult()
        {
            Value = new ChangeTrackingList<MobileNetworkSimPolicyData>();
        }

        /// <summary> Initializes a new instance of <see cref="SimPolicyListResult"/>. </summary>
        /// <param name="value"> A list of SIM policies. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SimPolicyListResult(IReadOnlyList<MobileNetworkSimPolicyData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> A list of SIM policies. </summary>
        public IReadOnlyList<MobileNetworkSimPolicyData> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
