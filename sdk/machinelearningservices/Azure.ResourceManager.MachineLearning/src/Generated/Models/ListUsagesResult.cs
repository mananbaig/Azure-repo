// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The List Usages operation response. </summary>
    internal partial class ListUsagesResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ListUsagesResult"/>. </summary>
        internal ListUsagesResult()
        {
            Value = new ChangeTrackingList<MachineLearningUsage>();
        }

        /// <summary> Initializes a new instance of <see cref="ListUsagesResult"/>. </summary>
        /// <param name="value"> The list of AML resource usages. </param>
        /// <param name="nextLink"> The URI to fetch the next page of AML resource usage information. Call ListNext() with this to fetch the next page of AML resource usage information. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ListUsagesResult(IReadOnlyList<MachineLearningUsage> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> The list of AML resource usages. </summary>
        public IReadOnlyList<MachineLearningUsage> Value { get; }
        /// <summary> The URI to fetch the next page of AML resource usage information. Call ListNext() with this to fetch the next page of AML resource usage information. </summary>
        public string NextLink { get; }
    }
}
