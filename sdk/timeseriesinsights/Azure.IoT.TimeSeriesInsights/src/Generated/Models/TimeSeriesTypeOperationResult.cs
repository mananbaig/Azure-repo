// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.IoT.TimeSeriesInsights
{
    /// <summary> Result of a batch operation on a particular time series type. Type object is set when operation is successful and error object is set when operation is unsuccessful. </summary>
    public partial class TimeSeriesTypeOperationResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="TimeSeriesTypeOperationResult"/>. </summary>
        internal TimeSeriesTypeOperationResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TimeSeriesTypeOperationResult"/>. </summary>
        /// <param name="timeSeriesType"> Time series type object - set when the operation is successful. </param>
        /// <param name="error"> Error object - set when the operation is unsuccessful. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TimeSeriesTypeOperationResult(TimeSeriesType timeSeriesType, TimeSeriesOperationError error, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TimeSeriesType = timeSeriesType;
            Error = error;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Time series type object - set when the operation is successful. </summary>
        public TimeSeriesType TimeSeriesType { get; }
        /// <summary> Error object - set when the operation is unsuccessful. </summary>
        public TimeSeriesOperationError Error { get; }
    }
}
