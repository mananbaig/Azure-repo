// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> Definition of the test job. </summary>
    public partial class TestJob
    {
        /// <summary> Initializes a new instance of TestJob. </summary>
        internal TestJob()
        {
            Parameters = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of TestJob. </summary>
        /// <param name="createdOn"> Gets or sets the creation time of the test job. </param>
        /// <param name="status"> Gets or sets the status of the test job. </param>
        /// <param name="statusDetails"> Gets or sets the status details of the test job. </param>
        /// <param name="runOn"> Gets or sets the runOn which specifies the group name where the job is to be executed. </param>
        /// <param name="startOn"> Gets or sets the start time of the test job. </param>
        /// <param name="endOn"> Gets or sets the end time of the test job. </param>
        /// <param name="exception"> Gets or sets the exception of the test job. </param>
        /// <param name="lastModifiedOn"> Gets or sets the last modified time of the test job. </param>
        /// <param name="lastStatusModifiedOn"> Gets or sets the last status modified time of the test job. </param>
        /// <param name="parameters"> Gets or sets the parameters of the test job. </param>
        /// <param name="logActivityTrace"> The activity-level tracing options of the runbook. </param>
        internal TestJob(DateTimeOffset? createdOn, string status, string statusDetails, string runOn, DateTimeOffset? startOn, DateTimeOffset? endOn, string exception, DateTimeOffset? lastModifiedOn, DateTimeOffset? lastStatusModifiedOn, IReadOnlyDictionary<string, string> parameters, int? logActivityTrace)
        {
            CreatedOn = createdOn;
            Status = status;
            StatusDetails = statusDetails;
            RunOn = runOn;
            StartOn = startOn;
            EndOn = endOn;
            Exception = exception;
            LastModifiedOn = lastModifiedOn;
            LastStatusModifiedOn = lastStatusModifiedOn;
            Parameters = parameters;
            LogActivityTrace = logActivityTrace;
        }

        /// <summary> Gets or sets the creation time of the test job. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Gets or sets the status of the test job. </summary>
        public string Status { get; }
        /// <summary> Gets or sets the status details of the test job. </summary>
        public string StatusDetails { get; }
        /// <summary> Gets or sets the runOn which specifies the group name where the job is to be executed. </summary>
        public string RunOn { get; }
        /// <summary> Gets or sets the start time of the test job. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> Gets or sets the end time of the test job. </summary>
        public DateTimeOffset? EndOn { get; }
        /// <summary> Gets or sets the exception of the test job. </summary>
        public string Exception { get; }
        /// <summary> Gets or sets the last modified time of the test job. </summary>
        public DateTimeOffset? LastModifiedOn { get; }
        /// <summary> Gets or sets the last status modified time of the test job. </summary>
        public DateTimeOffset? LastStatusModifiedOn { get; }
        /// <summary> Gets or sets the parameters of the test job. </summary>
        public IReadOnlyDictionary<string, string> Parameters { get; }
        /// <summary> The activity-level tracing options of the runbook. </summary>
        public int? LogActivityTrace { get; }
    }
}
