// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> A list of data flow resources. </summary>
    internal partial class DataFlowListResponse
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DataFlowListResponse"/>. </summary>
        /// <param name="value"> List of data flows. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal DataFlowListResponse(IEnumerable<DataFlowResource> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="DataFlowListResponse"/>. </summary>
        /// <param name="value"> List of data flows. </param>
        /// <param name="nextLink"> The link to the next page of results, if any remaining results exist. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataFlowListResponse(IReadOnlyList<DataFlowResource> value, string nextLink, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DataFlowListResponse"/> for deserialization. </summary>
        internal DataFlowListResponse()
        {
        }

        /// <summary> List of data flows. </summary>
        public IReadOnlyList<DataFlowResource> Value { get; }
        /// <summary> The link to the next page of results, if any remaining results exist. </summary>
        public string NextLink { get; }
    }
}
