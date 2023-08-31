// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Monitor.Query.Models
{
    /// <summary> Represents a metric value. </summary>
    public partial class MetricValue
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MetricValue"/>. </summary>
        /// <param name="timeStamp"> the timestamp for the metric value in ISO 8601 format. </param>
        internal MetricValue(DateTimeOffset timeStamp)
        {
            TimeStamp = timeStamp;
        }

        /// <summary> Initializes a new instance of <see cref="MetricValue"/>. </summary>
        /// <param name="timeStamp"> the timestamp for the metric value in ISO 8601 format. </param>
        /// <param name="average"> the average value in the time range. </param>
        /// <param name="minimum"> the least value in the time range. </param>
        /// <param name="maximum"> the greatest value in the time range. </param>
        /// <param name="total"> the sum of all of the values in the time range. </param>
        /// <param name="count"> the number of samples in the time range. Can be used to determine the number of values that contributed to the average value. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MetricValue(DateTimeOffset timeStamp, double? average, double? minimum, double? maximum, double? total, double? count, Dictionary<string, BinaryData> rawData)
        {
            TimeStamp = timeStamp;
            Average = average;
            Minimum = minimum;
            Maximum = maximum;
            Total = total;
            Count = count;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="MetricValue"/> for deserialization. </summary>
        internal MetricValue()
        {
        }

        /// <summary> the timestamp for the metric value in ISO 8601 format. </summary>
        public DateTimeOffset TimeStamp { get; }
        /// <summary> the average value in the time range. </summary>
        public double? Average { get; }
        /// <summary> the least value in the time range. </summary>
        public double? Minimum { get; }
        /// <summary> the greatest value in the time range. </summary>
        public double? Maximum { get; }
        /// <summary> the sum of all of the values in the time range. </summary>
        public double? Total { get; }
        /// <summary> the number of samples in the time range. Can be used to determine the number of values that contributed to the average value. </summary>
        public double? Count { get; }
    }
}
