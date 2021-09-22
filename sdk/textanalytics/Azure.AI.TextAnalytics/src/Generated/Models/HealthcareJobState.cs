// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.AI.TextAnalytics;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The HealthcareJobState. </summary>
    internal partial class HealthcareJobState : JobMetadata
    {
        /// <summary> Initializes a new instance of HealthcareJobState. </summary>
        /// <param name="createdDateTime"></param>
        /// <param name="jobId"></param>
        /// <param name="lastUpdateDateTime"></param>
        /// <param name="status"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> is null. </exception>
        internal HealthcareJobState(DateTimeOffset createdDateTime, string jobId, DateTimeOffset lastUpdateDateTime, TextAnalyticsOperationStatus status) : base(createdDateTime, jobId, lastUpdateDateTime, status)
        {
            if (jobId == null)
            {
                throw new ArgumentNullException(nameof(jobId));
            }

            Errors = new ChangeTrackingList<TextAnalyticsErrorInternal>();
        }

        /// <summary> Initializes a new instance of HealthcareJobState. </summary>
        /// <param name="createdDateTime"></param>
        /// <param name="expirationDateTime"></param>
        /// <param name="jobId"></param>
        /// <param name="lastUpdateDateTime"></param>
        /// <param name="status"></param>
        /// <param name="results"></param>
        /// <param name="errors"></param>
        /// <param name="nextLink"></param>
        internal HealthcareJobState(DateTimeOffset createdDateTime, DateTimeOffset? expirationDateTime, string jobId, DateTimeOffset lastUpdateDateTime, TextAnalyticsOperationStatus status, HealthcareResult results, IReadOnlyList<TextAnalyticsErrorInternal> errors, string nextLink) : base(createdDateTime, expirationDateTime, jobId, lastUpdateDateTime, status)
        {
            Results = results;
            Errors = errors;
            NextLink = nextLink;
        }

        /// <summary> Gets the results. </summary>
        public HealthcareResult Results { get; }
        /// <summary> Gets the errors. </summary>
        public IReadOnlyList<TextAnalyticsErrorInternal> Errors { get; }
        /// <summary> Gets the next link. </summary>
        public string NextLink { get; }
    }
}
