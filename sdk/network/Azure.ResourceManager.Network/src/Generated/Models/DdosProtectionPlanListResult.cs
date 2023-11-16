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
    /// <summary> A list of DDoS protection plans. </summary>
    internal partial class DdosProtectionPlanListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DdosProtectionPlanListResult"/>. </summary>
        internal DdosProtectionPlanListResult()
        {
            Value = new ChangeTrackingList<DdosProtectionPlanData>();
        }

        /// <summary> Initializes a new instance of <see cref="DdosProtectionPlanListResult"/>. </summary>
        /// <param name="value"> A list of DDoS protection plans. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DdosProtectionPlanListResult(IReadOnlyList<DdosProtectionPlanData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> A list of DDoS protection plans. </summary>
        public IReadOnlyList<DdosProtectionPlanData> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
