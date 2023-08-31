// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> The metadata to describe the capability. </summary>
    public partial class DataBoxEdgeSkuCapability
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DataBoxEdgeSkuCapability"/>. </summary>
        internal DataBoxEdgeSkuCapability()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DataBoxEdgeSkuCapability"/>. </summary>
        /// <param name="name"> An invariant to describe the feature. </param>
        /// <param name="value"> An invariant if the feature is measured by quantity. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DataBoxEdgeSkuCapability(string name, string value, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            Value = value;
            _rawData = rawData;
        }

        /// <summary> An invariant to describe the feature. </summary>
        public string Name { get; }
        /// <summary> An invariant if the feature is measured by quantity. </summary>
        public string Value { get; }
    }
}
