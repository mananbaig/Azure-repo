// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.AI.TextAnalytics;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The HealthcareJobState. </summary>
    internal partial class HealthcareJobState : JobMetadata
    {
        /// <summary> Initializes a new instance of HealthcareJobState. </summary>
        /// <param name="createdDateTime"> . </param>
        /// <param name="jobId"> . </param>
        /// <param name="lastUpdateDateTime"> . </param>
        /// <param name="status"> . </param>
        internal HealthcareJobState(DateTimeOffset createdDateTime, Guid jobId, DateTimeOffset lastUpdateDateTime, JobStatus status) : base(createdDateTime, jobId, lastUpdateDateTime, status)
        {
        }

        /// <summary> Initializes a new instance of HealthcareJobState. </summary>
        /// <param name="createdDateTime"> . </param>
        /// <param name="displayName"> . </param>
        /// <param name="expirationDateTime"> . </param>
        /// <param name="jobId"> . </param>
        /// <param name="lastUpdateDateTime"> . </param>
        /// <param name="status"> . </param>
        /// <param name="results"> . </param>
        /// <param name="nextLink"> . </param>
        internal HealthcareJobState(DateTimeOffset createdDateTime, string displayName, DateTimeOffset? expirationDateTime, Guid jobId, DateTimeOffset lastUpdateDateTime, JobStatus status, HealthcareResult results, string nextLink) : base(createdDateTime, displayName, expirationDateTime, jobId, lastUpdateDateTime, status)
        {
            Results = results;
            NextLink = nextLink;
        }

        public HealthcareResult Results { get; }
        public string NextLink { get; }
    }
}
