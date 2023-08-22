// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Developer.LoadTesting.Models
{
    /// <summary> Test server metrics configuration. </summary>
    public partial class TestServerMetricConfig
    {
        /// <summary> Initializes a new instance of TestServerMetricConfig. </summary>
        public TestServerMetricConfig()
        {
            Metrics = new ChangeTrackingDictionary<string, ResourceMetric>();
        }

        /// <summary> Initializes a new instance of TestServerMetricConfig. </summary>
        /// <param name="testId"> Test identifier. </param>
        /// <param name="metrics"> Azure resource metrics collection {metric id : metrics object} (Refer : https://docs.microsoft.com/en-us/rest/api/monitor/metric-definitions/list#metricdefinition for metric id). </param>
        /// <param name="createdDateTime"> The creation datetime(ISO 8601 literal format). </param>
        /// <param name="createdBy"> The user that created. </param>
        /// <param name="lastModifiedDateTime"> The last Modified datetime(ISO 8601 literal format). </param>
        /// <param name="lastModifiedBy"> The user that last modified. </param>
        internal TestServerMetricConfig(string testId, IDictionary<string, ResourceMetric> metrics, DateTimeOffset? createdDateTime, string createdBy, DateTimeOffset? lastModifiedDateTime, string lastModifiedBy)
        {
            TestId = testId;
            Metrics = metrics;
            CreatedDateTime = createdDateTime;
            CreatedBy = createdBy;
            LastModifiedDateTime = lastModifiedDateTime;
            LastModifiedBy = lastModifiedBy;
        }

        /// <summary> Test identifier. </summary>
        public string TestId { get; }
        /// <summary> Azure resource metrics collection {metric id : metrics object} (Refer : https://docs.microsoft.com/en-us/rest/api/monitor/metric-definitions/list#metricdefinition for metric id). </summary>
        public IDictionary<string, ResourceMetric> Metrics { get; }
        /// <summary> The creation datetime(ISO 8601 literal format). </summary>
        public DateTimeOffset? CreatedDateTime { get; }
        /// <summary> The user that created. </summary>
        public string CreatedBy { get; }
        /// <summary> The last Modified datetime(ISO 8601 literal format). </summary>
        public DateTimeOffset? LastModifiedDateTime { get; }
        /// <summary> The user that last modified. </summary>
        public string LastModifiedBy { get; }
    }
}
