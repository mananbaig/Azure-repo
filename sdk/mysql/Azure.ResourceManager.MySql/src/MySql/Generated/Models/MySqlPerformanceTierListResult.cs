// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MySql.Models
{
    /// <summary> A list of performance tiers. </summary>
    internal partial class MySqlPerformanceTierListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MySqlPerformanceTierListResult"/>. </summary>
        internal MySqlPerformanceTierListResult()
        {
            Value = new ChangeTrackingList<MySqlPerformanceTier>();
        }

        /// <summary> Initializes a new instance of <see cref="MySqlPerformanceTierListResult"/>. </summary>
        /// <param name="value"> The list of performance tiers. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MySqlPerformanceTierListResult(IReadOnlyList<MySqlPerformanceTier> value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The list of performance tiers. </summary>
        public IReadOnlyList<MySqlPerformanceTier> Value { get; }
    }
}
