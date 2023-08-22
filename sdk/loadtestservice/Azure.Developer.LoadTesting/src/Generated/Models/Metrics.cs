// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Developer.LoadTesting.Models
{
    /// <summary> The response to a metrics query. </summary>
    internal partial class Metrics
    {
        /// <summary> Initializes a new instance of Metrics. </summary>
        internal Metrics()
        {
            Value = new ChangeTrackingList<TimeSeriesElement>();
        }

        /// <summary> Initializes a new instance of Metrics. </summary>
        /// <param name="value"> Timeseries data for metric query. </param>
        /// <param name="nextLink"> Link for the next set of timeseries in case of paginated results, if applicable. </param>
        internal Metrics(IReadOnlyList<TimeSeriesElement> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Timeseries data for metric query. </summary>
        public IReadOnlyList<TimeSeriesElement> Value { get; }
        /// <summary> Link for the next set of timeseries in case of paginated results, if applicable. </summary>
        public string NextLink { get; }
    }
}
