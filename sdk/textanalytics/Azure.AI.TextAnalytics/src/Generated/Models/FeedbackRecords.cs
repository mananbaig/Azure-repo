// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> Active learning feedback records. </summary>
    internal partial class FeedbackRecords
    {
        /// <summary> Initializes a new instance of FeedbackRecords. </summary>
        internal FeedbackRecords()
        {
            FeedbackRecordsValue = new ChangeTrackingList<FeedbackRecord>();
        }

        /// <summary> List of feedback records. </summary>
        public IReadOnlyList<FeedbackRecord> FeedbackRecordsValue { get; }
    }
}
