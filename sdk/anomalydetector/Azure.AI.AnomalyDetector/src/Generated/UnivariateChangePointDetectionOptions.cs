// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.AnomalyDetector
{
    /// <summary> Request of change point detection. </summary>
    public partial class UnivariateChangePointDetectionOptions
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="UnivariateChangePointDetectionOptions"/>. </summary>
        /// <param name="series">
        /// Time series data points. Points should be sorted by time stamp in ascending
        /// order to match the change point detection result.
        /// </param>
        /// <param name="granularity"> Granularity is used to verify whether the input series is valid. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="series"/> is null. </exception>
        public UnivariateChangePointDetectionOptions(IEnumerable<TimeSeriesPoint> series, TimeGranularity granularity)
        {
            Argument.AssertNotNull(series, nameof(series));

            Series = series.ToList();
            Granularity = granularity;
        }

        /// <summary> Initializes a new instance of <see cref="UnivariateChangePointDetectionOptions"/>. </summary>
        /// <param name="series">
        /// Time series data points. Points should be sorted by time stamp in ascending
        /// order to match the change point detection result.
        /// </param>
        /// <param name="granularity"> Granularity is used to verify whether the input series is valid. </param>
        /// <param name="customInterval">
        /// A custom interval is used to set a nonstandard time interval. For example, if the
        /// series is 5 minutes, the request can be set as {"granularity":"minutely",
        /// "customInterval":5}.
        /// </param>
        /// <param name="period">
        /// Argument that indicates the periodic value of a time series. If the value is null or
        /// not present, the API will determine the period automatically.
        /// </param>
        /// <param name="stableTrendWindow">
        /// Argument that indicates an advanced model parameter. A default stableTrendWindow value will
        /// be used in detection.
        /// </param>
        /// <param name="threshold">
        /// Argument that indicates an advanced model parameter between 0.0 and 1.0. The lower the
        /// value is, the larger the trend error is, which means less change point will
        /// be accepted.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnivariateChangePointDetectionOptions(IList<TimeSeriesPoint> series, TimeGranularity granularity, int? customInterval, int? period, int? stableTrendWindow, float? threshold, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Series = series;
            Granularity = granularity;
            CustomInterval = customInterval;
            Period = period;
            StableTrendWindow = stableTrendWindow;
            Threshold = threshold;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="UnivariateChangePointDetectionOptions"/> for deserialization. </summary>
        internal UnivariateChangePointDetectionOptions()
        {
        }

        /// <summary>
        /// Time series data points. Points should be sorted by time stamp in ascending
        /// order to match the change point detection result.
        /// </summary>
        public IList<TimeSeriesPoint> Series { get; }
        /// <summary> Granularity is used to verify whether the input series is valid. </summary>
        public TimeGranularity Granularity { get; }
        /// <summary>
        /// A custom interval is used to set a nonstandard time interval. For example, if the
        /// series is 5 minutes, the request can be set as {"granularity":"minutely",
        /// "customInterval":5}.
        /// </summary>
        public int? CustomInterval { get; set; }
        /// <summary>
        /// Argument that indicates the periodic value of a time series. If the value is null or
        /// not present, the API will determine the period automatically.
        /// </summary>
        public int? Period { get; set; }
        /// <summary>
        /// Argument that indicates an advanced model parameter. A default stableTrendWindow value will
        /// be used in detection.
        /// </summary>
        public int? StableTrendWindow { get; set; }
        /// <summary>
        /// Argument that indicates an advanced model parameter between 0.0 and 1.0. The lower the
        /// value is, the larger the trend error is, which means less change point will
        /// be accepted.
        /// </summary>
        public float? Threshold { get; set; }
    }
}
