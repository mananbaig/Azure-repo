// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.MachineLearning;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> A paginated list of BatchEndpoint entities. </summary>
    internal partial class BatchEndpointTrackedResourceArmPaginatedResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="BatchEndpointTrackedResourceArmPaginatedResult"/>. </summary>
        internal BatchEndpointTrackedResourceArmPaginatedResult()
        {
            Value = new ChangeTrackingList<MachineLearningBatchEndpointData>();
        }

        /// <summary> Initializes a new instance of <see cref="BatchEndpointTrackedResourceArmPaginatedResult"/>. </summary>
        /// <param name="nextLink"> The link to the next page of BatchEndpoint objects. If null, there are no additional pages. </param>
        /// <param name="value"> An array of objects of type BatchEndpoint. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal BatchEndpointTrackedResourceArmPaginatedResult(string nextLink, IReadOnlyList<MachineLearningBatchEndpointData> value, Dictionary<string, BinaryData> rawData)
        {
            NextLink = nextLink;
            Value = value;
            _rawData = rawData;
        }

        /// <summary> The link to the next page of BatchEndpoint objects. If null, there are no additional pages. </summary>
        public string NextLink { get; }
        /// <summary> An array of objects of type BatchEndpoint. </summary>
        public IReadOnlyList<MachineLearningBatchEndpointData> Value { get; }
    }
}
