// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Properties of a query metrics interval. </summary>
    public partial class QueryMetricInterval
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="QueryMetricInterval"/>. </summary>
        public QueryMetricInterval()
        {
            Metrics = new ChangeTrackingList<QueryMetricProperties>();
        }

        /// <summary> Initializes a new instance of <see cref="QueryMetricInterval"/>. </summary>
        /// <param name="intervalStartTime"> The start time for the metric interval (ISO-8601 format). </param>
        /// <param name="intervalType"> Interval type (length). </param>
        /// <param name="executionCount"> Execution count of a query in this interval. </param>
        /// <param name="metrics"> List of metric objects for this interval. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal QueryMetricInterval(string intervalStartTime, QueryTimeGrainType? intervalType, long? executionCount, IList<QueryMetricProperties> metrics, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IntervalStartTime = intervalStartTime;
            IntervalType = intervalType;
            ExecutionCount = executionCount;
            Metrics = metrics;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The start time for the metric interval (ISO-8601 format). </summary>
        public string IntervalStartTime { get; }
        /// <summary> Interval type (length). </summary>
        public QueryTimeGrainType? IntervalType { get; }
        /// <summary> Execution count of a query in this interval. </summary>
        public long? ExecutionCount { get; }
        /// <summary> List of metric objects for this interval. </summary>
        public IList<QueryMetricProperties> Metrics { get; }
    }
}
