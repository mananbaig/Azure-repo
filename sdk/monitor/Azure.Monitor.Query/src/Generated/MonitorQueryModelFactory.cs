// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Monitor.Query.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class MonitorQueryModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="LogsTableColumn"/>. </summary>
        /// <param name="name"> The name of this column. </param>
        /// <param name="type"> The data type of this column. </param>
        /// <returns> A new <see cref="Models.LogsTableColumn"/> instance for mocking. </returns>
        public static LogsTableColumn LogsTableColumn(string name = null, LogsColumnType type = default)
        {
            return new LogsTableColumn(name, type, default);
        }

        /// <summary> Initializes a new instance of <see cref="MetricAvailability"/>. </summary>
        /// <param name="granularity"> the time grain specifies the aggregation interval for the metric. Expressed as a duration 'PT1M', 'P1D', etc. </param>
        /// <param name="retention"> the retention period for the metric at the specified timegrain.  Expressed as a duration 'PT1M', 'P1D', etc. </param>
        /// <returns> A new <see cref="Models.MetricAvailability"/> instance for mocking. </returns>
        public static MetricAvailability MetricAvailability(TimeSpan? granularity = null, TimeSpan? retention = null)
        {
            return new MetricAvailability(granularity, retention, default);
        }
    }
}
