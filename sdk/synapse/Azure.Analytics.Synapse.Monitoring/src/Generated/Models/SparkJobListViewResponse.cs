// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Monitoring.Models
{
    /// <summary> The SparkJobListViewResponse. </summary>
    public partial class SparkJobListViewResponse
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SparkJobListViewResponse"/>. </summary>
        internal SparkJobListViewResponse()
        {
            SparkJobs = new ChangeTrackingList<SparkJob>();
        }

        /// <summary> Initializes a new instance of <see cref="SparkJobListViewResponse"/>. </summary>
        /// <param name="nJobs"></param>
        /// <param name="sparkJobs"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SparkJobListViewResponse(int? nJobs, IReadOnlyList<SparkJob> sparkJobs, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NJobs = nJobs;
            SparkJobs = sparkJobs;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the n jobs. </summary>
        public int? NJobs { get; }
        /// <summary> Gets the spark jobs. </summary>
        public IReadOnlyList<SparkJob> SparkJobs { get; }
    }
}
