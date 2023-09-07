// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> List of data policy manifests. </summary>
    internal partial class DataPolicyManifestListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DataPolicyManifestListResult"/>. </summary>
        internal DataPolicyManifestListResult()
        {
            Value = new ChangeTrackingList<DataPolicyManifestData>();
        }

        /// <summary> Initializes a new instance of <see cref="DataPolicyManifestListResult"/>. </summary>
        /// <param name="value"> An array of data policy manifests. </param>
        /// <param name="nextLink"> The URL to use for getting the next set of results. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataPolicyManifestListResult(IReadOnlyList<DataPolicyManifestData> value, string nextLink, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> An array of data policy manifests. </summary>
        public IReadOnlyList<DataPolicyManifestData> Value { get; }
        /// <summary> The URL to use for getting the next set of results. </summary>
        public string NextLink { get; }
    }
}
