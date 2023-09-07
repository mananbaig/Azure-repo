// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> Common error representation. </summary>
    public partial class StreamAnalyticsError
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="StreamAnalyticsError"/>. </summary>
        internal StreamAnalyticsError()
        {
            Details = new ChangeTrackingList<StreamAnalyticsErrorDetails>();
        }

        /// <summary> Initializes a new instance of <see cref="StreamAnalyticsError"/>. </summary>
        /// <param name="code"> Error code. </param>
        /// <param name="message"> Error message. </param>
        /// <param name="target"> Error target. </param>
        /// <param name="details"> Error details. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StreamAnalyticsError(string code, string message, string target, IReadOnlyList<StreamAnalyticsErrorDetails> details, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Code = code;
            Message = message;
            Target = target;
            Details = details;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Error code. </summary>
        public string Code { get; }
        /// <summary> Error message. </summary>
        public string Message { get; }
        /// <summary> Error target. </summary>
        public string Target { get; }
        /// <summary> Error details. </summary>
        public IReadOnlyList<StreamAnalyticsErrorDetails> Details { get; }
    }
}
