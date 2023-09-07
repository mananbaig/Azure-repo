// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The result of the assessment. </summary>
    public partial class SecurityAssessmentStatusResult : SecurityAssessmentStatus
    {
        /// <summary> Initializes a new instance of <see cref="SecurityAssessmentStatusResult"/>. </summary>
        /// <param name="code"> Programmatic code for the status of the assessment. </param>
        public SecurityAssessmentStatusResult(SecurityAssessmentStatusCode code) : base(code)
        {
        }

        /// <summary> Initializes a new instance of <see cref="SecurityAssessmentStatusResult"/>. </summary>
        /// <param name="code"> Programmatic code for the status of the assessment. </param>
        /// <param name="cause"> Programmatic code for the cause of the assessment status. </param>
        /// <param name="description"> Human readable description of the assessment status. </param>
        /// <param name="firstEvaluatedOn"> The time that the assessment was created and first evaluated. Returned as UTC time in ISO 8601 format. </param>
        /// <param name="statusChangeOn"> The time that the status of the assessment last changed. Returned as UTC time in ISO 8601 format. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SecurityAssessmentStatusResult(SecurityAssessmentStatusCode code, string cause, string description, DateTimeOffset? firstEvaluatedOn, DateTimeOffset? statusChangeOn, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(code, cause, description, serializedAdditionalRawData)
        {
            FirstEvaluatedOn = firstEvaluatedOn;
            StatusChangeOn = statusChangeOn;
        }

        /// <summary> Initializes a new instance of <see cref="SecurityAssessmentStatusResult"/> for deserialization. </summary>
        internal SecurityAssessmentStatusResult()
        {
        }

        /// <summary> The time that the assessment was created and first evaluated. Returned as UTC time in ISO 8601 format. </summary>
        public DateTimeOffset? FirstEvaluatedOn { get; }
        /// <summary> The time that the status of the assessment last changed. Returned as UTC time in ISO 8601 format. </summary>
        public DateTimeOffset? StatusChangeOn { get; }
    }
}
