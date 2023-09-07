// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> Describes conditions applicable to the Input, Output, or the job overall, that warrant customer attention. </summary>
    internal partial class StreamingJobDiagnostics
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="StreamingJobDiagnostics"/>. </summary>
        internal StreamingJobDiagnostics()
        {
            Conditions = new ChangeTrackingList<StreamingJobDiagnosticCondition>();
        }

        /// <summary> Initializes a new instance of <see cref="StreamingJobDiagnostics"/>. </summary>
        /// <param name="conditions"> A collection of zero or more conditions applicable to the resource, or to the job overall, that warrant customer attention. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StreamingJobDiagnostics(IReadOnlyList<StreamingJobDiagnosticCondition> conditions, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Conditions = conditions;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> A collection of zero or more conditions applicable to the resource, or to the job overall, that warrant customer attention. </summary>
        public IReadOnlyList<StreamingJobDiagnosticCondition> Conditions { get; }
    }
}
