// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Analytics.Synapse.Spark.Models
{
    /// <summary> The SparkBatchJobState. </summary>
    public partial class SparkBatchJobState
    {
        /// <summary> Initializes a new instance of SparkBatchJobState. </summary>
        internal SparkBatchJobState()
        {
        }

        /// <summary> Initializes a new instance of SparkBatchJobState. </summary>
        /// <param name="notStartedAt"> the time that at which "not_started" livy state was first seen. </param>
        /// <param name="startingAt"> the time that at which "starting" livy state was first seen. </param>
        /// <param name="runningAt"> the time that at which "running" livy state was first seen. </param>
        /// <param name="deadAt"> time that at which "dead" livy state was first seen. </param>
        /// <param name="successAt"> the time that at which "success" livy state was first seen. </param>
        /// <param name="terminatedAt"> the time that at which "killed" livy state was first seen. </param>
        /// <param name="recoveringAt"> the time that at which "recovering" livy state was first seen. </param>
        /// <param name="currentState"> the Spark job state. </param>
        /// <param name="jobCreationRequest"></param>
        internal SparkBatchJobState(DateTimeOffset? notStartedAt, DateTimeOffset? startingAt, DateTimeOffset? runningAt, DateTimeOffset? deadAt, DateTimeOffset? successAt, DateTimeOffset? terminatedAt, DateTimeOffset? recoveringAt, string currentState, SparkRequest jobCreationRequest)
        {
            NotStartedAt = notStartedAt;
            StartingAt = startingAt;
            RunningAt = runningAt;
            DeadAt = deadAt;
            SuccessAt = successAt;
            TerminatedAt = terminatedAt;
            RecoveringAt = recoveringAt;
            CurrentState = currentState;
            JobCreationRequest = jobCreationRequest;
        }

        /// <summary> the time that at which "not_started" livy state was first seen. </summary>
        public DateTimeOffset? NotStartedAt { get; }
        /// <summary> the time that at which "starting" livy state was first seen. </summary>
        public DateTimeOffset? StartingAt { get; }
        /// <summary> the time that at which "running" livy state was first seen. </summary>
        public DateTimeOffset? RunningAt { get; }
        /// <summary> time that at which "dead" livy state was first seen. </summary>
        public DateTimeOffset? DeadAt { get; }
        /// <summary> the time that at which "success" livy state was first seen. </summary>
        public DateTimeOffset? SuccessAt { get; }
        /// <summary> the time that at which "killed" livy state was first seen. </summary>
        public DateTimeOffset? TerminatedAt { get; }
        /// <summary> the time that at which "recovering" livy state was first seen. </summary>
        public DateTimeOffset? RecoveringAt { get; }
        /// <summary> the Spark job state. </summary>
        public string CurrentState { get; }
        /// <summary> Gets the job creation request. </summary>
        public SparkRequest JobCreationRequest { get; }
    }
}
