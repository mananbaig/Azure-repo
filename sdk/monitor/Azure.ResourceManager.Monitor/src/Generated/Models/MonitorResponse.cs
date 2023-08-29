// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The response to a metrics query. </summary>
    internal partial class MonitorResponse
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MonitorResponse"/>. </summary>
        /// <param name="timespan"> The timespan for which the data was retrieved. Its value consists of two datetimes concatenated, separated by '/'.  This may be adjusted in the future and returned back from what was originally requested. </param>
        /// <param name="value"> the value of the collection. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="timespan"/> or <paramref name="value"/> is null. </exception>
        internal MonitorResponse(string timespan, IEnumerable<MonitorMetric> value)
        {
            Argument.AssertNotNull(timespan, nameof(timespan));
            Argument.AssertNotNull(value, nameof(value));

            Timespan = timespan;
            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="MonitorResponse"/>. </summary>
        /// <param name="cost"> The integer value representing the relative cost of the query. </param>
        /// <param name="timespan"> The timespan for which the data was retrieved. Its value consists of two datetimes concatenated, separated by '/'.  This may be adjusted in the future and returned back from what was originally requested. </param>
        /// <param name="interval"> The interval (window size) for which the metric data was returned in.  This may be adjusted in the future and returned back from what was originally requested.  This is not present if a metadata request was made. </param>
        /// <param name="namespace"> The namespace of the metrics being queried. </param>
        /// <param name="resourceregion"> The region of the resource being queried for metrics. </param>
        /// <param name="value"> the value of the collection. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MonitorResponse(int? cost, string timespan, TimeSpan? interval, string @namespace, string resourceregion, IReadOnlyList<MonitorMetric> value, Dictionary<string, BinaryData> rawData)
        {
            Cost = cost;
            Timespan = timespan;
            Interval = interval;
            Namespace = @namespace;
            Resourceregion = resourceregion;
            Value = value;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="MonitorResponse"/> for deserialization. </summary>
        internal MonitorResponse()
        {
        }

        /// <summary> The integer value representing the relative cost of the query. </summary>
        public int? Cost { get; }
        /// <summary> The timespan for which the data was retrieved. Its value consists of two datetimes concatenated, separated by '/'.  This may be adjusted in the future and returned back from what was originally requested. </summary>
        public string Timespan { get; }
        /// <summary> The interval (window size) for which the metric data was returned in.  This may be adjusted in the future and returned back from what was originally requested.  This is not present if a metadata request was made. </summary>
        public TimeSpan? Interval { get; }
        /// <summary> The namespace of the metrics being queried. </summary>
        public string Namespace { get; }
        /// <summary> The region of the resource being queried for metrics. </summary>
        public string Resourceregion { get; }
        /// <summary> the value of the collection. </summary>
        public IReadOnlyList<MonitorMetric> Value { get; }
    }
}
