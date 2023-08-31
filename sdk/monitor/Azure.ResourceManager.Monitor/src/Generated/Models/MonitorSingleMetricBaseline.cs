// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The baseline results of a single metric. </summary>
    public partial class MonitorSingleMetricBaseline : ResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MonitorSingleMetricBaseline"/>. </summary>
        /// <param name="timespan"> The timespan for which the data was retrieved. Its value consists of two datetimes concatenated, separated by '/'.  This may be adjusted in the future and returned back from what was originally requested. </param>
        /// <param name="interval"> The interval (window size) for which the metric data was returned in.  This may be adjusted in the future and returned back from what was originally requested.  This is not present if a metadata request was made. </param>
        /// <param name="baselines"> The baseline for each time series that was queried. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="timespan"/> or <paramref name="baselines"/> is null. </exception>
        internal MonitorSingleMetricBaseline(string timespan, TimeSpan interval, IEnumerable<MonitorTimeSeriesBaseline> baselines)
        {
            Argument.AssertNotNull(timespan, nameof(timespan));
            Argument.AssertNotNull(baselines, nameof(baselines));

            Timespan = timespan;
            Interval = interval;
            Baselines = baselines.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="MonitorSingleMetricBaseline"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="timespan"> The timespan for which the data was retrieved. Its value consists of two datetimes concatenated, separated by '/'.  This may be adjusted in the future and returned back from what was originally requested. </param>
        /// <param name="interval"> The interval (window size) for which the metric data was returned in.  This may be adjusted in the future and returned back from what was originally requested.  This is not present if a metadata request was made. </param>
        /// <param name="namespace"> The namespace of the metrics been queried. </param>
        /// <param name="baselines"> The baseline for each time series that was queried. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MonitorSingleMetricBaseline(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string timespan, TimeSpan interval, string @namespace, IReadOnlyList<MonitorTimeSeriesBaseline> baselines, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            Timespan = timespan;
            Interval = interval;
            Namespace = @namespace;
            Baselines = baselines;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="MonitorSingleMetricBaseline"/> for deserialization. </summary>
        internal MonitorSingleMetricBaseline()
        {
        }

        /// <summary> The timespan for which the data was retrieved. Its value consists of two datetimes concatenated, separated by '/'.  This may be adjusted in the future and returned back from what was originally requested. </summary>
        public string Timespan { get; }
        /// <summary> The interval (window size) for which the metric data was returned in.  This may be adjusted in the future and returned back from what was originally requested.  This is not present if a metadata request was made. </summary>
        public TimeSpan Interval { get; }
        /// <summary> The namespace of the metrics been queried. </summary>
        public string Namespace { get; }
        /// <summary> The baseline for each time series that was queried. </summary>
        public IReadOnlyList<MonitorTimeSeriesBaseline> Baselines { get; }
    }
}
