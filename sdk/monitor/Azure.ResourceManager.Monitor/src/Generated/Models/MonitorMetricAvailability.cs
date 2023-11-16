// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Metric availability specifies the time grain (aggregation interval or frequency) and the retention period for that time grain. </summary>
    public partial class MonitorMetricAvailability
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MonitorMetricAvailability"/>. </summary>
        internal MonitorMetricAvailability()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MonitorMetricAvailability"/>. </summary>
        /// <param name="timeGrain"> the time grain specifies the aggregation interval for the metric. Expressed as a duration 'PT1M', 'P1D', etc. </param>
        /// <param name="retention"> the retention period for the metric at the specified timegrain.  Expressed as a duration 'PT1M', 'P1D', etc. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MonitorMetricAvailability(TimeSpan? timeGrain, TimeSpan? retention, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TimeGrain = timeGrain;
            Retention = retention;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> the time grain specifies the aggregation interval for the metric. Expressed as a duration 'PT1M', 'P1D', etc. </summary>
        public TimeSpan? TimeGrain { get; }
        /// <summary> the retention period for the metric at the specified timegrain.  Expressed as a duration 'PT1M', 'P1D', etc. </summary>
        public TimeSpan? Retention { get; }
    }
}
