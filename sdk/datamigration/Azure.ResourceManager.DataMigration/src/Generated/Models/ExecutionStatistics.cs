// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Description about the errors happen while performing migration validation. </summary>
    public partial class ExecutionStatistics
    {
        /// <summary> Initializes a new instance of ExecutionStatistics. </summary>
        internal ExecutionStatistics()
        {
            WaitStats = new Core.ChangeTrackingDictionary<string, WaitStatistics>();
            SqlErrors = new Core.ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of ExecutionStatistics. </summary>
        /// <param name="executionCount"> No. of query executions. </param>
        /// <param name="cpuTimeMs"> CPU Time in millisecond(s) for the query execution. </param>
        /// <param name="elapsedTimeMs"> Time taken in millisecond(s) for executing the query. </param>
        /// <param name="waitStats"> Dictionary of sql query execution wait types and the respective statistics. </param>
        /// <param name="hasErrors"> Indicates whether the query resulted in an error. </param>
        /// <param name="sqlErrors"> List of sql Errors. </param>
        internal ExecutionStatistics(long? executionCount, float? cpuTimeMs, float? elapsedTimeMs, IReadOnlyDictionary<string, WaitStatistics> waitStats, bool? hasErrors, IReadOnlyList<string> sqlErrors)
        {
            ExecutionCount = executionCount;
            CpuTimeMs = cpuTimeMs;
            ElapsedTimeMs = elapsedTimeMs;
            WaitStats = waitStats;
            HasErrors = hasErrors;
            SqlErrors = sqlErrors;
        }

        /// <summary> No. of query executions. </summary>
        public long? ExecutionCount { get; }
        /// <summary> CPU Time in millisecond(s) for the query execution. </summary>
        public float? CpuTimeMs { get; }
        /// <summary> Time taken in millisecond(s) for executing the query. </summary>
        public float? ElapsedTimeMs { get; }
        /// <summary> Dictionary of sql query execution wait types and the respective statistics. </summary>
        public IReadOnlyDictionary<string, WaitStatistics> WaitStats { get; }
        /// <summary> Indicates whether the query resulted in an error. </summary>
        public bool? HasErrors { get; }
        /// <summary> List of sql Errors. </summary>
        public IReadOnlyList<string> SqlErrors { get; }
    }
}
