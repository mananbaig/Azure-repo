// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Execution policy for an activity. </summary>
    public partial class RetryPolicy
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RetryPolicy"/>. </summary>
        public RetryPolicy()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RetryPolicy"/>. </summary>
        /// <param name="count"> Maximum ordinary retry attempts. Default is 0. Type: integer (or Expression with resultType integer), minimum: 0. </param>
        /// <param name="intervalInSeconds"> Interval between retries in seconds. Default is 30. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RetryPolicy(object count, int? intervalInSeconds, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Count = count;
            IntervalInSeconds = intervalInSeconds;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Maximum ordinary retry attempts. Default is 0. Type: integer (or Expression with resultType integer), minimum: 0. </summary>
        public object Count { get; set; }
        /// <summary> Interval between retries in seconds. Default is 30. </summary>
        public int? IntervalInSeconds { get; set; }
    }
}
