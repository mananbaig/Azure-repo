// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Detailed status of current migration. </summary>
    public partial class MigrationStatusDetails
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MigrationStatusDetails"/>. </summary>
        internal MigrationStatusDetails()
        {
            ActiveBackupSets = new ChangeTrackingList<SqlBackupSetInfo>();
            InvalidFiles = new ChangeTrackingList<string>();
            FileUploadBlockingErrors = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="MigrationStatusDetails"/>. </summary>
        /// <param name="migrationState"> Current State of Migration. </param>
        /// <param name="fullBackupSetInfo"> Details of full backup set. </param>
        /// <param name="lastRestoredBackupSetInfo"> Last applied backup set information. </param>
        /// <param name="activeBackupSets"> Backup sets that are currently active. </param>
        /// <param name="invalidFiles"> Files that are not valid backup files. </param>
        /// <param name="blobContainerName"> Name of blob container. </param>
        /// <param name="isFullBackupRestored"> Whether full backup has been applied to the target database or not. </param>
        /// <param name="restoreBlockingReason"> Restore blocking reason, if any. </param>
        /// <param name="completeRestoreErrorMessage"> Complete restore error message, if any. </param>
        /// <param name="fileUploadBlockingErrors"> File upload blocking errors, if any. </param>
        /// <param name="currentRestoringFilename"> File name that is currently being restored. </param>
        /// <param name="lastRestoredFilename"> Last restored file name. </param>
        /// <param name="pendingLogBackupsCount"> Total pending log backups. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MigrationStatusDetails(string migrationState, SqlBackupSetInfo fullBackupSetInfo, SqlBackupSetInfo lastRestoredBackupSetInfo, IReadOnlyList<SqlBackupSetInfo> activeBackupSets, IReadOnlyList<string> invalidFiles, string blobContainerName, bool? isFullBackupRestored, string restoreBlockingReason, string completeRestoreErrorMessage, IReadOnlyList<string> fileUploadBlockingErrors, string currentRestoringFilename, string lastRestoredFilename, int? pendingLogBackupsCount, Dictionary<string, BinaryData> rawData)
        {
            MigrationState = migrationState;
            FullBackupSetInfo = fullBackupSetInfo;
            LastRestoredBackupSetInfo = lastRestoredBackupSetInfo;
            ActiveBackupSets = activeBackupSets;
            InvalidFiles = invalidFiles;
            BlobContainerName = blobContainerName;
            IsFullBackupRestored = isFullBackupRestored;
            RestoreBlockingReason = restoreBlockingReason;
            CompleteRestoreErrorMessage = completeRestoreErrorMessage;
            FileUploadBlockingErrors = fileUploadBlockingErrors;
            CurrentRestoringFilename = currentRestoringFilename;
            LastRestoredFilename = lastRestoredFilename;
            PendingLogBackupsCount = pendingLogBackupsCount;
            _rawData = rawData;
        }

        /// <summary> Current State of Migration. </summary>
        public string MigrationState { get; }
        /// <summary> Details of full backup set. </summary>
        public SqlBackupSetInfo FullBackupSetInfo { get; }
        /// <summary> Last applied backup set information. </summary>
        public SqlBackupSetInfo LastRestoredBackupSetInfo { get; }
        /// <summary> Backup sets that are currently active. </summary>
        public IReadOnlyList<SqlBackupSetInfo> ActiveBackupSets { get; }
        /// <summary> Files that are not valid backup files. </summary>
        public IReadOnlyList<string> InvalidFiles { get; }
        /// <summary> Name of blob container. </summary>
        public string BlobContainerName { get; }
        /// <summary> Whether full backup has been applied to the target database or not. </summary>
        public bool? IsFullBackupRestored { get; }
        /// <summary> Restore blocking reason, if any. </summary>
        public string RestoreBlockingReason { get; }
        /// <summary> Complete restore error message, if any. </summary>
        public string CompleteRestoreErrorMessage { get; }
        /// <summary> File upload blocking errors, if any. </summary>
        public IReadOnlyList<string> FileUploadBlockingErrors { get; }
        /// <summary> File name that is currently being restored. </summary>
        public string CurrentRestoringFilename { get; }
        /// <summary> Last restored file name. </summary>
        public string LastRestoredFilename { get; }
        /// <summary> Total pending log backups. </summary>
        public int? PendingLogBackupsCount { get; }
    }
}
