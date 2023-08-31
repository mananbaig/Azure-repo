// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> The MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseLevel. </summary>
    public partial class MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseLevel : MigrateOracleAzureDBPostgreSqlSyncTaskOutput
    {
        /// <summary> Initializes a new instance of <see cref="MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseLevel"/>. </summary>
        internal MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseLevel()
        {
            ResultType = "DatabaseLevelOutput";
        }

        /// <summary> Initializes a new instance of <see cref="MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseLevel"/>. </summary>
        /// <param name="id"> Result identifier. </param>
        /// <param name="resultType"> Result type. </param>
        /// <param name="databaseName"> Name of the database. </param>
        /// <param name="startedOn"> Migration start time. </param>
        /// <param name="endedOn"> Migration end time. </param>
        /// <param name="migrationState"> Migration state that this database is in. </param>
        /// <param name="incomingChanges"> Number of incoming changes. </param>
        /// <param name="appliedChanges"> Number of applied changes. </param>
        /// <param name="cdcInsertCounter"> Number of cdc inserts. </param>
        /// <param name="cdcDeleteCounter"> Number of cdc deletes. </param>
        /// <param name="cdcUpdateCounter"> Number of cdc updates. </param>
        /// <param name="fullLoadCompletedTables"> Number of tables completed in full load. </param>
        /// <param name="fullLoadLoadingTables"> Number of tables loading in full load. </param>
        /// <param name="fullLoadQueuedTables"> Number of tables queued in full load. </param>
        /// <param name="fullLoadErroredTables"> Number of tables errored in full load. </param>
        /// <param name="initializationCompleted"> Indicates if initial load (full load) has been completed. </param>
        /// <param name="latency"> CDC apply latency. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseLevel(string id, string resultType, string databaseName, DateTimeOffset? startedOn, DateTimeOffset? endedOn, SyncDatabaseMigrationReportingState? migrationState, long? incomingChanges, long? appliedChanges, long? cdcInsertCounter, long? cdcDeleteCounter, long? cdcUpdateCounter, long? fullLoadCompletedTables, long? fullLoadLoadingTables, long? fullLoadQueuedTables, long? fullLoadErroredTables, bool? initializationCompleted, long? latency, Dictionary<string, BinaryData> rawData) : base(id, resultType, rawData)
        {
            DatabaseName = databaseName;
            StartedOn = startedOn;
            EndedOn = endedOn;
            MigrationState = migrationState;
            IncomingChanges = incomingChanges;
            AppliedChanges = appliedChanges;
            CdcInsertCounter = cdcInsertCounter;
            CdcDeleteCounter = cdcDeleteCounter;
            CdcUpdateCounter = cdcUpdateCounter;
            FullLoadCompletedTables = fullLoadCompletedTables;
            FullLoadLoadingTables = fullLoadLoadingTables;
            FullLoadQueuedTables = fullLoadQueuedTables;
            FullLoadErroredTables = fullLoadErroredTables;
            InitializationCompleted = initializationCompleted;
            Latency = latency;
            ResultType = resultType ?? "DatabaseLevelOutput";
        }

        /// <summary> Name of the database. </summary>
        public string DatabaseName { get; }
        /// <summary> Migration start time. </summary>
        public DateTimeOffset? StartedOn { get; }
        /// <summary> Migration end time. </summary>
        public DateTimeOffset? EndedOn { get; }
        /// <summary> Migration state that this database is in. </summary>
        public SyncDatabaseMigrationReportingState? MigrationState { get; }
        /// <summary> Number of incoming changes. </summary>
        public long? IncomingChanges { get; }
        /// <summary> Number of applied changes. </summary>
        public long? AppliedChanges { get; }
        /// <summary> Number of cdc inserts. </summary>
        public long? CdcInsertCounter { get; }
        /// <summary> Number of cdc deletes. </summary>
        public long? CdcDeleteCounter { get; }
        /// <summary> Number of cdc updates. </summary>
        public long? CdcUpdateCounter { get; }
        /// <summary> Number of tables completed in full load. </summary>
        public long? FullLoadCompletedTables { get; }
        /// <summary> Number of tables loading in full load. </summary>
        public long? FullLoadLoadingTables { get; }
        /// <summary> Number of tables queued in full load. </summary>
        public long? FullLoadQueuedTables { get; }
        /// <summary> Number of tables errored in full load. </summary>
        public long? FullLoadErroredTables { get; }
        /// <summary> Indicates if initial load (full load) has been completed. </summary>
        public bool? InitializationCompleted { get; }
        /// <summary> CDC apply latency. </summary>
        public long? Latency { get; }
    }
}
