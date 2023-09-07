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
    /// <summary> A list of workload groups. </summary>
    internal partial class SynapseWorkloadGroupListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SynapseWorkloadGroupListResult"/>. </summary>
        internal SynapseWorkloadGroupListResult()
        {
            Value = new ChangeTrackingList<SynapseWorkloadGroupData>();
        }

        /// <summary> Initializes a new instance of <see cref="SynapseWorkloadGroupListResult"/>. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SynapseWorkloadGroupListResult(IReadOnlyList<SynapseWorkloadGroupData> value, string nextLink, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<SynapseWorkloadGroupData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
