// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Spark.Models
{
    /// <summary> The SparkServiceError. </summary>
    public partial class SparkServiceError
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SparkServiceError"/>. </summary>
        internal SparkServiceError()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SparkServiceError"/>. </summary>
        /// <param name="message"></param>
        /// <param name="errorCode"></param>
        /// <param name="source"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SparkServiceError(string message, string errorCode, SparkErrorSource? source, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Message = message;
            ErrorCode = errorCode;
            Source = source;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the message. </summary>
        public string Message { get; }
        /// <summary> Gets the error code. </summary>
        public string ErrorCode { get; }
        /// <summary> Gets the source. </summary>
        public SparkErrorSource? Source { get; }
    }
}
