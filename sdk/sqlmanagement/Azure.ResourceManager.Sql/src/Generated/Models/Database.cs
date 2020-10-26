// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A database resource. </summary>
    public partial class Database : TrackedResource
    {
        /// <summary> Initializes a new instance of Database. </summary>
        /// <param name="location"> Resource location. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        public Database(string location) : base(location)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
        }

        /// <summary> Initializes a new instance of Database. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="sku">
        /// The database SKU.
        /// 
        /// 
        /// 
        /// The list of SKUs may vary by region and support offer. To determine the SKUs (including the SKU name, tier/edition, family, and capacity) that are available to your subscription in an Azure region, use the `Capabilities_ListByLocation` REST API or one of the following commands:
        /// 
        /// 
        /// 
        /// ```azurecli
        /// 
        /// az sql db list-editions -l &lt;location&gt; -o table
        /// 
        /// ````
        /// 
        /// 
        /// 
        /// ```powershell
        /// 
        /// Get-AzSqlServerServiceObjective -Location &lt;location&gt;
        /// 
        /// ````
        /// 
        /// .
        /// </param>
        /// <param name="kind"> Kind of database. This is metadata used for the Azure portal experience. </param>
        /// <param name="managedBy"> Resource that manages the database. </param>
        /// <param name="createMode">
        /// Specifies the mode of database creation.
        /// 
        /// 
        /// 
        /// Default: regular database creation.
        /// 
        /// 
        /// 
        /// Copy: creates a database as a copy of an existing database. sourceDatabaseId must be specified as the resource ID of the source database.
        /// 
        /// 
        /// 
        /// Secondary: creates a database as a secondary replica of an existing database. sourceDatabaseId must be specified as the resource ID of the existing primary database.
        /// 
        /// 
        /// 
        /// PointInTimeRestore: Creates a database by restoring a point in time backup of an existing database. sourceDatabaseId must be specified as the resource ID of the existing database, and restorePointInTime must be specified.
        /// 
        /// 
        /// 
        /// Recovery: Creates a database by restoring a geo-replicated backup. sourceDatabaseId must be specified as the recoverable database resource ID to restore.
        /// 
        /// 
        /// 
        /// Restore: Creates a database by restoring a backup of a deleted database. sourceDatabaseId must be specified. If sourceDatabaseId is the database&apos;s original resource ID, then sourceDatabaseDeletionDate must be specified. Otherwise sourceDatabaseId must be the restorable dropped database resource ID and sourceDatabaseDeletionDate is ignored. restorePointInTime may also be specified to restore from an earlier point in time.
        /// 
        /// 
        /// 
        /// RestoreLongTermRetentionBackup: Creates a database by restoring from a long term retention vault. recoveryServicesRecoveryPointResourceId must be specified as the recovery point resource ID.
        /// 
        /// 
        /// 
        /// Copy, Secondary, and RestoreLongTermRetentionBackup are not supported for DataWarehouse edition.
        /// </param>
        /// <param name="collation"> The collation of the database. </param>
        /// <param name="maxSizeBytes"> The max size of the database expressed in bytes. </param>
        /// <param name="sampleName"> The name of the sample schema to apply when creating this database. </param>
        /// <param name="elasticPoolId"> The resource identifier of the elastic pool containing this database. </param>
        /// <param name="sourceDatabaseId"> The resource identifier of the source database associated with create operation of this database. </param>
        /// <param name="status"> The status of the database. </param>
        /// <param name="databaseId"> The ID of the database. </param>
        /// <param name="creationDate"> The creation date of the database (ISO8601 format). </param>
        /// <param name="currentServiceObjectiveName"> The current service level objective name of the database. </param>
        /// <param name="requestedServiceObjectiveName"> The requested service level objective name of the database. </param>
        /// <param name="defaultSecondaryLocation"> The default secondary region for this database. </param>
        /// <param name="failoverGroupId"> Failover Group resource identifier that this database belongs to. </param>
        /// <param name="restorePointInTime"> Specifies the point in time (ISO8601 format) of the source database that will be restored to create the new database. </param>
        /// <param name="sourceDatabaseDeletionDate"> Specifies the time that the database was deleted. </param>
        /// <param name="recoveryServicesRecoveryPointId"> The resource identifier of the recovery point associated with create operation of this database. </param>
        /// <param name="longTermRetentionBackupResourceId"> The resource identifier of the long term retention backup associated with create operation of this database. </param>
        /// <param name="recoverableDatabaseId"> The resource identifier of the recoverable database associated with create operation of this database. </param>
        /// <param name="restorableDroppedDatabaseId"> The resource identifier of the restorable dropped database associated with create operation of this database. </param>
        /// <param name="catalogCollation"> Collation of the metadata catalog. </param>
        /// <param name="zoneRedundant"> Whether or not this database is zone redundant, which means the replicas of this database will be spread across multiple availability zones. </param>
        /// <param name="licenseType"> The license type to apply for this database. `LicenseIncluded` if you need a license, or `BasePrice` if you have a license and are eligible for the Azure Hybrid Benefit. </param>
        /// <param name="maxLogSizeBytes"> The max log size for this database. </param>
        /// <param name="earliestRestoreDate"> This records the earliest start date and time that restore is available for this database (ISO8601 format). </param>
        /// <param name="readScale"> If enabled, connections that have application intent set to readonly in their connection string may be routed to a readonly secondary replica. This property is only settable for Premium and Business Critical databases. </param>
        /// <param name="readReplicaCount"> The number of readonly secondary replicas associated with the database to which readonly application intent connections may be routed. This property is only settable for Hyperscale edition databases. </param>
        /// <param name="currentSku"> The name and tier of the SKU. </param>
        /// <param name="autoPauseDelay"> Time in minutes after which database is automatically paused. A value of -1 means that automatic pause is disabled. </param>
        /// <param name="minCapacity"> Minimal capacity that database will always have allocated, if not paused. </param>
        /// <param name="pausedDate"> The date when database was paused by user configuration or action (ISO8601 format). Null if the database is ready. </param>
        /// <param name="resumedDate"> The date when database was resumed by user action or database login (ISO8601 format). Null if the database is paused. </param>
        internal Database(string id, string name, string type, string location, IDictionary<string, string> tags, Sku sku, string kind, string managedBy, CreateMode? createMode, string collation, long? maxSizeBytes, SampleName? sampleName, string elasticPoolId, string sourceDatabaseId, DatabaseStatus? status, Guid? databaseId, DateTimeOffset? creationDate, string currentServiceObjectiveName, string requestedServiceObjectiveName, string defaultSecondaryLocation, string failoverGroupId, DateTimeOffset? restorePointInTime, DateTimeOffset? sourceDatabaseDeletionDate, string recoveryServicesRecoveryPointId, string longTermRetentionBackupResourceId, string recoverableDatabaseId, string restorableDroppedDatabaseId, CatalogCollationType? catalogCollation, bool? zoneRedundant, DatabaseLicenseType? licenseType, long? maxLogSizeBytes, DateTimeOffset? earliestRestoreDate, DatabaseReadScale? readScale, int? readReplicaCount, Sku currentSku, int? autoPauseDelay, double? minCapacity, DateTimeOffset? pausedDate, DateTimeOffset? resumedDate) : base(id, name, type, location, tags)
        {
            Sku = sku;
            Kind = kind;
            ManagedBy = managedBy;
            CreateMode = createMode;
            Collation = collation;
            MaxSizeBytes = maxSizeBytes;
            SampleName = sampleName;
            ElasticPoolId = elasticPoolId;
            SourceDatabaseId = sourceDatabaseId;
            Status = status;
            DatabaseId = databaseId;
            CreationDate = creationDate;
            CurrentServiceObjectiveName = currentServiceObjectiveName;
            RequestedServiceObjectiveName = requestedServiceObjectiveName;
            DefaultSecondaryLocation = defaultSecondaryLocation;
            FailoverGroupId = failoverGroupId;
            RestorePointInTime = restorePointInTime;
            SourceDatabaseDeletionDate = sourceDatabaseDeletionDate;
            RecoveryServicesRecoveryPointId = recoveryServicesRecoveryPointId;
            LongTermRetentionBackupResourceId = longTermRetentionBackupResourceId;
            RecoverableDatabaseId = recoverableDatabaseId;
            RestorableDroppedDatabaseId = restorableDroppedDatabaseId;
            CatalogCollation = catalogCollation;
            ZoneRedundant = zoneRedundant;
            LicenseType = licenseType;
            MaxLogSizeBytes = maxLogSizeBytes;
            EarliestRestoreDate = earliestRestoreDate;
            ReadScale = readScale;
            ReadReplicaCount = readReplicaCount;
            CurrentSku = currentSku;
            AutoPauseDelay = autoPauseDelay;
            MinCapacity = minCapacity;
            PausedDate = pausedDate;
            ResumedDate = resumedDate;
        }

        /// <summary>
        /// The database SKU.
        /// 
        /// 
        /// 
        /// The list of SKUs may vary by region and support offer. To determine the SKUs (including the SKU name, tier/edition, family, and capacity) that are available to your subscription in an Azure region, use the `Capabilities_ListByLocation` REST API or one of the following commands:
        /// 
        /// 
        /// 
        /// ```azurecli
        /// 
        /// az sql db list-editions -l &lt;location&gt; -o table
        /// 
        /// ````
        /// 
        /// 
        /// 
        /// ```powershell
        /// 
        /// Get-AzSqlServerServiceObjective -Location &lt;location&gt;
        /// 
        /// ````
        /// 
        /// .
        /// </summary>
        public Sku Sku { get; set; }
        /// <summary> Kind of database. This is metadata used for the Azure portal experience. </summary>
        public string Kind { get; }
        /// <summary> Resource that manages the database. </summary>
        public string ManagedBy { get; }
        /// <summary>
        /// Specifies the mode of database creation.
        /// 
        /// 
        /// 
        /// Default: regular database creation.
        /// 
        /// 
        /// 
        /// Copy: creates a database as a copy of an existing database. sourceDatabaseId must be specified as the resource ID of the source database.
        /// 
        /// 
        /// 
        /// Secondary: creates a database as a secondary replica of an existing database. sourceDatabaseId must be specified as the resource ID of the existing primary database.
        /// 
        /// 
        /// 
        /// PointInTimeRestore: Creates a database by restoring a point in time backup of an existing database. sourceDatabaseId must be specified as the resource ID of the existing database, and restorePointInTime must be specified.
        /// 
        /// 
        /// 
        /// Recovery: Creates a database by restoring a geo-replicated backup. sourceDatabaseId must be specified as the recoverable database resource ID to restore.
        /// 
        /// 
        /// 
        /// Restore: Creates a database by restoring a backup of a deleted database. sourceDatabaseId must be specified. If sourceDatabaseId is the database&apos;s original resource ID, then sourceDatabaseDeletionDate must be specified. Otherwise sourceDatabaseId must be the restorable dropped database resource ID and sourceDatabaseDeletionDate is ignored. restorePointInTime may also be specified to restore from an earlier point in time.
        /// 
        /// 
        /// 
        /// RestoreLongTermRetentionBackup: Creates a database by restoring from a long term retention vault. recoveryServicesRecoveryPointResourceId must be specified as the recovery point resource ID.
        /// 
        /// 
        /// 
        /// Copy, Secondary, and RestoreLongTermRetentionBackup are not supported for DataWarehouse edition.
        /// </summary>
        public CreateMode? CreateMode { get; set; }
        /// <summary> The collation of the database. </summary>
        public string Collation { get; set; }
        /// <summary> The max size of the database expressed in bytes. </summary>
        public long? MaxSizeBytes { get; set; }
        /// <summary> The name of the sample schema to apply when creating this database. </summary>
        public SampleName? SampleName { get; set; }
        /// <summary> The resource identifier of the elastic pool containing this database. </summary>
        public string ElasticPoolId { get; set; }
        /// <summary> The resource identifier of the source database associated with create operation of this database. </summary>
        public string SourceDatabaseId { get; set; }
        /// <summary> The status of the database. </summary>
        public DatabaseStatus? Status { get; }
        /// <summary> The ID of the database. </summary>
        public Guid? DatabaseId { get; }
        /// <summary> The creation date of the database (ISO8601 format). </summary>
        public DateTimeOffset? CreationDate { get; }
        /// <summary> The current service level objective name of the database. </summary>
        public string CurrentServiceObjectiveName { get; }
        /// <summary> The requested service level objective name of the database. </summary>
        public string RequestedServiceObjectiveName { get; }
        /// <summary> The default secondary region for this database. </summary>
        public string DefaultSecondaryLocation { get; }
        /// <summary> Failover Group resource identifier that this database belongs to. </summary>
        public string FailoverGroupId { get; }
        /// <summary> Specifies the point in time (ISO8601 format) of the source database that will be restored to create the new database. </summary>
        public DateTimeOffset? RestorePointInTime { get; set; }
        /// <summary> Specifies the time that the database was deleted. </summary>
        public DateTimeOffset? SourceDatabaseDeletionDate { get; set; }
        /// <summary> The resource identifier of the recovery point associated with create operation of this database. </summary>
        public string RecoveryServicesRecoveryPointId { get; set; }
        /// <summary> The resource identifier of the long term retention backup associated with create operation of this database. </summary>
        public string LongTermRetentionBackupResourceId { get; set; }
        /// <summary> The resource identifier of the recoverable database associated with create operation of this database. </summary>
        public string RecoverableDatabaseId { get; set; }
        /// <summary> The resource identifier of the restorable dropped database associated with create operation of this database. </summary>
        public string RestorableDroppedDatabaseId { get; set; }
        /// <summary> Collation of the metadata catalog. </summary>
        public CatalogCollationType? CatalogCollation { get; set; }
        /// <summary> Whether or not this database is zone redundant, which means the replicas of this database will be spread across multiple availability zones. </summary>
        public bool? ZoneRedundant { get; set; }
        /// <summary> The license type to apply for this database. `LicenseIncluded` if you need a license, or `BasePrice` if you have a license and are eligible for the Azure Hybrid Benefit. </summary>
        public DatabaseLicenseType? LicenseType { get; set; }
        /// <summary> The max log size for this database. </summary>
        public long? MaxLogSizeBytes { get; }
        /// <summary> This records the earliest start date and time that restore is available for this database (ISO8601 format). </summary>
        public DateTimeOffset? EarliestRestoreDate { get; }
        /// <summary> If enabled, connections that have application intent set to readonly in their connection string may be routed to a readonly secondary replica. This property is only settable for Premium and Business Critical databases. </summary>
        public DatabaseReadScale? ReadScale { get; set; }
        /// <summary> The number of readonly secondary replicas associated with the database to which readonly application intent connections may be routed. This property is only settable for Hyperscale edition databases. </summary>
        public int? ReadReplicaCount { get; set; }
        /// <summary> The name and tier of the SKU. </summary>
        public Sku CurrentSku { get; }
        /// <summary> Time in minutes after which database is automatically paused. A value of -1 means that automatic pause is disabled. </summary>
        public int? AutoPauseDelay { get; set; }
        /// <summary> Minimal capacity that database will always have allocated, if not paused. </summary>
        public double? MinCapacity { get; set; }
        /// <summary> The date when database was paused by user configuration or action (ISO8601 format). Null if the database is ready. </summary>
        public DateTimeOffset? PausedDate { get; }
        /// <summary> The date when database was resumed by user action or database login (ISO8601 format). Null if the database is paused. </summary>
        public DateTimeOffset? ResumedDate { get; }
    }
}
