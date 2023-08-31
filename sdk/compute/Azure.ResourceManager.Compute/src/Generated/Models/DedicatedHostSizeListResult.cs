// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The List Dedicated Host sizes operation response. </summary>
    internal partial class DedicatedHostSizeListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DedicatedHostSizeListResult"/>. </summary>
        internal DedicatedHostSizeListResult()
        {
            Value = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="DedicatedHostSizeListResult"/>. </summary>
        /// <param name="value"> The list of dedicated host sizes. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DedicatedHostSizeListResult(IReadOnlyList<string> value, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            _rawData = rawData;
        }

        /// <summary> The list of dedicated host sizes. </summary>
        public IReadOnlyList<string> Value { get; }
    }
}
