// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> The MigrateSqlServerSqlMISyncTaskOutputDatabaseLevel. </summary>
    public partial class MigrateSqlServerSqlMISyncTaskOutputDatabaseLevel : MigrateSqlServerSqlMISyncTaskOutput
    {
        /// <summary> Initializes a new instance of MigrateSqlServerSqlMISyncTaskOutputDatabaseLevel. </summary>
        internal MigrateSqlServerSqlMISyncTaskOutputDatabaseLevel()
        {
            ActiveBackupSets = new Core.ChangeTrackingList<BackupSetInfo>();
            ExceptionsAndWarnings = new Core.ChangeTrackingList<ReportableException>();
            ResultType = "DatabaseLevelOutput";
        }

        /// <summary> Initializes a new instance of MigrateSqlServerSqlMISyncTaskOutputDatabaseLevel. </summary>
        /// <param name="id"> Result identifier. </param>
        /// <param name="resultType"> Result type. </param>
        /// <param name="sourceDatabaseName"> Name of the database. </param>
        /// <param name="migrationState"> Current state of database. </param>
        /// <param name="startedOn"> Database migration start time. </param>
        /// <param name="endedOn"> Database migration end time. </param>
        /// <param name="fullBackupSetInfo"> Details of full backup set. </param>
        /// <param name="lastRestoredBackupSetInfo"> Last applied backup set information. </param>
        /// <param name="activeBackupSets"> Backup sets that are currently active (Either being uploaded or getting restored). </param>
        /// <param name="containerName"> Name of container created in the Azure Storage account where backups are copied to. </param>
        /// <param name="errorPrefix"> prefix string to use for querying errors for this database. </param>
        /// <param name="isFullBackupRestored"> Whether full backup has been applied to the target database or not. </param>
        /// <param name="exceptionsAndWarnings"> Migration exceptions and warnings. </param>
        internal MigrateSqlServerSqlMISyncTaskOutputDatabaseLevel(string id, string resultType, string sourceDatabaseName, DatabaseMigrationState? migrationState, DateTimeOffset? startedOn, DateTimeOffset? endedOn, BackupSetInfo fullBackupSetInfo, BackupSetInfo lastRestoredBackupSetInfo, IReadOnlyList<BackupSetInfo> activeBackupSets, string containerName, string errorPrefix, bool? isFullBackupRestored, IReadOnlyList<ReportableException> exceptionsAndWarnings) : base(id, resultType)
        {
            SourceDatabaseName = sourceDatabaseName;
            MigrationState = migrationState;
            StartedOn = startedOn;
            EndedOn = endedOn;
            FullBackupSetInfo = fullBackupSetInfo;
            LastRestoredBackupSetInfo = lastRestoredBackupSetInfo;
            ActiveBackupSets = activeBackupSets;
            ContainerName = containerName;
            ErrorPrefix = errorPrefix;
            IsFullBackupRestored = isFullBackupRestored;
            ExceptionsAndWarnings = exceptionsAndWarnings;
            ResultType = resultType ?? "DatabaseLevelOutput";
        }

        /// <summary> Name of the database. </summary>
        public string SourceDatabaseName { get; }
        /// <summary> Current state of database. </summary>
        public DatabaseMigrationState? MigrationState { get; }
        /// <summary> Database migration start time. </summary>
        public DateTimeOffset? StartedOn { get; }
        /// <summary> Database migration end time. </summary>
        public DateTimeOffset? EndedOn { get; }
        /// <summary> Details of full backup set. </summary>
        public BackupSetInfo FullBackupSetInfo { get; }
        /// <summary> Last applied backup set information. </summary>
        public BackupSetInfo LastRestoredBackupSetInfo { get; }
        /// <summary> Backup sets that are currently active (Either being uploaded or getting restored). </summary>
        public IReadOnlyList<BackupSetInfo> ActiveBackupSets { get; }
        /// <summary> Name of container created in the Azure Storage account where backups are copied to. </summary>
        public string ContainerName { get; }
        /// <summary> prefix string to use for querying errors for this database. </summary>
        public string ErrorPrefix { get; }
        /// <summary> Whether full backup has been applied to the target database or not. </summary>
        public bool? IsFullBackupRestored { get; }
        /// <summary> Migration exceptions and warnings. </summary>
        public IReadOnlyList<ReportableException> ExceptionsAndWarnings { get; }
    }
}
