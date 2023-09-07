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
    /// <summary> The JobState. </summary>
    internal partial class JobState
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="JobState"/>. </summary>
        /// <param name="createdDateTime"></param>
        /// <param name="jobId"></param>
        /// <param name="lastUpdatedDateTime"></param>
        /// <param name="status"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> is null. </exception>
        internal JobState(DateTimeOffset createdDateTime, string jobId, DateTimeOffset lastUpdatedDateTime, TextAnalyticsOperationStatus status)
        {
            Argument.AssertNotNull(jobId, nameof(jobId));

            CreatedDateTime = createdDateTime;
            JobId = jobId;
            LastUpdatedDateTime = lastUpdatedDateTime;
            Status = status;
            Errors = new ChangeTrackingList<Error>();
        }

        /// <summary> Initializes a new instance of <see cref="JobState"/>. </summary>
        /// <param name="displayName"></param>
        /// <param name="createdDateTime"></param>
        /// <param name="expirationDateTime"></param>
        /// <param name="jobId"></param>
        /// <param name="lastUpdatedDateTime"></param>
        /// <param name="status"></param>
        /// <param name="errors"></param>
        /// <param name="nextLink"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal JobState(string displayName, DateTimeOffset createdDateTime, DateTimeOffset? expirationDateTime, string jobId, DateTimeOffset lastUpdatedDateTime, TextAnalyticsOperationStatus status, IReadOnlyList<Error> errors, string nextLink, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DisplayName = displayName;
            CreatedDateTime = createdDateTime;
            ExpirationDateTime = expirationDateTime;
            JobId = jobId;
            LastUpdatedDateTime = lastUpdatedDateTime;
            Status = status;
            Errors = errors;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="JobState"/> for deserialization. </summary>
        internal JobState()
        {
        }

        /// <summary> Gets the display name. </summary>
        public string DisplayName { get; }
        /// <summary> Gets the created date time. </summary>
        public DateTimeOffset CreatedDateTime { get; }
        /// <summary> Gets the expiration date time. </summary>
        public DateTimeOffset? ExpirationDateTime { get; }
        /// <summary> Gets the job id. </summary>
        public string JobId { get; }
        /// <summary> Gets the last updated date time. </summary>
        public DateTimeOffset LastUpdatedDateTime { get; }
        /// <summary> Gets the status. </summary>
        public TextAnalyticsOperationStatus Status { get; }
        /// <summary> Gets the errors. </summary>
        public IReadOnlyList<Error> Errors { get; }
        /// <summary> Gets the next link. </summary>
        public string NextLink { get; }
    }
}
