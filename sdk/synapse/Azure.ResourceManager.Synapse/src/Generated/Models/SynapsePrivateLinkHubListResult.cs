// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Synapse;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> List of privateLinkHubs. </summary>
    internal partial class SynapsePrivateLinkHubListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SynapsePrivateLinkHubListResult"/>. </summary>
        internal SynapsePrivateLinkHubListResult()
        {
            Value = new ChangeTrackingList<SynapsePrivateLinkHubData>();
        }

        /// <summary> Initializes a new instance of <see cref="SynapsePrivateLinkHubListResult"/>. </summary>
        /// <param name="nextLink"> Link to the next page of results. </param>
        /// <param name="value"> List of privateLinkHubs. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SynapsePrivateLinkHubListResult(string nextLink, IReadOnlyList<SynapsePrivateLinkHubData> value, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NextLink = nextLink;
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Link to the next page of results. </summary>
        public string NextLink { get; }
        /// <summary> List of privateLinkHubs. </summary>
        public IReadOnlyList<SynapsePrivateLinkHubData> Value { get; }
    }
}
