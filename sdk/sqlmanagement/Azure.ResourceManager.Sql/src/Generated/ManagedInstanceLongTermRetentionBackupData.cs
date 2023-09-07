// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing the ManagedInstanceLongTermRetentionBackup data model.
    /// A long term retention backup for a managed database.
    /// </summary>
    public partial class ManagedInstanceLongTermRetentionBackupData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ManagedInstanceLongTermRetentionBackupData"/>. </summary>
        public ManagedInstanceLongTermRetentionBackupData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ManagedInstanceLongTermRetentionBackupData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="managedInstanceName"> The managed instance that the backup database belongs to. </param>
        /// <param name="managedInstanceCreateOn"> The create time of the instance. </param>
        /// <param name="databaseName"> The name of the database the backup belong to. </param>
        /// <param name="databaseDeletedOn"> The delete time of the database. </param>
        /// <param name="backupOn"> The time the backup was taken. </param>
        /// <param name="backupExpireOn"> The time the long term retention backup will expire. </param>
        /// <param name="backupStorageRedundancy"> The storage redundancy type of the backup. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedInstanceLongTermRetentionBackupData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string managedInstanceName, DateTimeOffset? managedInstanceCreateOn, string databaseName, DateTimeOffset? databaseDeletedOn, DateTimeOffset? backupOn, DateTimeOffset? backupExpireOn, SqlBackupStorageRedundancy? backupStorageRedundancy, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            ManagedInstanceName = managedInstanceName;
            ManagedInstanceCreateOn = managedInstanceCreateOn;
            DatabaseName = databaseName;
            DatabaseDeletedOn = databaseDeletedOn;
            BackupOn = backupOn;
            BackupExpireOn = backupExpireOn;
            BackupStorageRedundancy = backupStorageRedundancy;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The managed instance that the backup database belongs to. </summary>
        public string ManagedInstanceName { get; }
        /// <summary> The create time of the instance. </summary>
        public DateTimeOffset? ManagedInstanceCreateOn { get; }
        /// <summary> The name of the database the backup belong to. </summary>
        public string DatabaseName { get; }
        /// <summary> The delete time of the database. </summary>
        public DateTimeOffset? DatabaseDeletedOn { get; }
        /// <summary> The time the backup was taken. </summary>
        public DateTimeOffset? BackupOn { get; }
        /// <summary> The time the long term retention backup will expire. </summary>
        public DateTimeOffset? BackupExpireOn { get; }
        /// <summary> The storage redundancy type of the backup. </summary>
        public SqlBackupStorageRedundancy? BackupStorageRedundancy { get; }
    }
}
