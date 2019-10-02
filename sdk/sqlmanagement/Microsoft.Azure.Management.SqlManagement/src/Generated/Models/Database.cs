// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A database resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Database : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the Database class.
        /// </summary>
        public Database()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Database class.
        /// </summary>
        /// <param name="location">Resource location.</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="sku">The database SKU.
        ///
        /// The list of SKUs may vary by region and support offer. To determine
        /// the SKUs (including the SKU name, tier/edition, family, and
        /// capacity) that are available to your subscription in an Azure
        /// region, use the `Capabilities_ListByLocation` REST API or one of
        /// the following commands:
        ///
        /// ```azurecli
        /// az sql db list-editions -l &lt;location&gt; -o table
        /// ````
        ///
        /// ```powershell
        /// Get-AzSqlServerServiceObjective -Location &lt;location&gt;
        /// ````
        /// </param>
        /// <param name="kind">Kind of database. This is metadata used for the
        /// Azure portal experience.</param>
        /// <param name="managedBy">Resource that manages the database.</param>
        /// <param name="createMode">Specifies the mode of database creation.
        ///
        /// Default: regular database creation.
        ///
        /// Copy: creates a database as a copy of an existing database.
        /// sourceDatabaseId must be specified as the resource ID of the source
        /// database.
        ///
        /// Secondary: creates a database as a secondary replica of an existing
        /// database. sourceDatabaseId must be specified as the resource ID of
        /// the existing primary database.
        ///
        /// PointInTimeRestore: Creates a database by restoring a point in time
        /// backup of an existing database. sourceDatabaseId must be specified
        /// as the resource ID of the existing database, and restorePointInTime
        /// must be specified.
        ///
        /// Recovery: Creates a database by restoring a geo-replicated backup.
        /// sourceDatabaseId must be specified as the recoverable database
        /// resource ID to restore.
        ///
        /// Restore: Creates a database by restoring a backup of a deleted
        /// database. sourceDatabaseId must be specified. If sourceDatabaseId
        /// is the database's original resource ID, then
        /// sourceDatabaseDeletionDate must be specified. Otherwise
        /// sourceDatabaseId must be the restorable dropped database resource
        /// ID and sourceDatabaseDeletionDate is ignored. restorePointInTime
        /// may also be specified to restore from an earlier point in time.
        ///
        /// RestoreLongTermRetentionBackup: Creates a database by restoring
        /// from a long term retention vault.
        /// recoveryServicesRecoveryPointResourceId must be specified as the
        /// recovery point resource ID.
        ///
        /// Copy, Secondary, and RestoreLongTermRetentionBackup are not
        /// supported for DataWarehouse edition. Possible values include:
        /// 'Default', 'Copy', 'Secondary', 'PointInTimeRestore', 'Restore',
        /// 'Recovery', 'RestoreExternalBackup',
        /// 'RestoreExternalBackupSecondary', 'RestoreLongTermRetentionBackup',
        /// 'OnlineSecondary'</param>
        /// <param name="collation">The collation of the database.</param>
        /// <param name="maxSizeBytes">The max size of the database expressed
        /// in bytes.</param>
        /// <param name="sampleName">The name of the sample schema to apply
        /// when creating this database. Possible values include:
        /// 'AdventureWorksLT', 'WideWorldImportersStd',
        /// 'WideWorldImportersFull'</param>
        /// <param name="elasticPoolId">The resource identifier of the elastic
        /// pool containing this database.</param>
        /// <param name="sourceDatabaseId">The resource identifier of the
        /// source database associated with create operation of this
        /// database.</param>
        /// <param name="status">The status of the database. Possible values
        /// include: 'Online', 'Restoring', 'RecoveryPending', 'Recovering',
        /// 'Suspect', 'Offline', 'Standby', 'Shutdown', 'EmergencyMode',
        /// 'AutoClosed', 'Copying', 'Creating', 'Inaccessible',
        /// 'OfflineSecondary', 'Pausing', 'Paused', 'Resuming', 'Scaling',
        /// 'OfflineChangingDwPerformanceTiers',
        /// 'OnlineChangingDwPerformanceTiers', 'Disabled'</param>
        /// <param name="databaseId">The ID of the database.</param>
        /// <param name="creationDate">The creation date of the database
        /// (ISO8601 format).</param>
        /// <param name="currentServiceObjectiveName">The current service level
        /// objective name of the database.</param>
        /// <param name="requestedServiceObjectiveName">The requested service
        /// level objective name of the database.</param>
        /// <param name="defaultSecondaryLocation">The default secondary region
        /// for this database.</param>
        /// <param name="failoverGroupId">Failover Group resource identifier
        /// that this database belongs to.</param>
        /// <param name="restorePointInTime">Specifies the point in time
        /// (ISO8601 format) of the source database that will be restored to
        /// create the new database.</param>
        /// <param name="sourceDatabaseDeletionDate">Specifies the time that
        /// the database was deleted.</param>
        /// <param name="recoveryServicesRecoveryPointId">The resource
        /// identifier of the recovery point associated with create operation
        /// of this database.</param>
        /// <param name="longTermRetentionBackupResourceId">The resource
        /// identifier of the long term retention backup associated with create
        /// operation of this database.</param>
        /// <param name="recoverableDatabaseId">The resource identifier of the
        /// recoverable database associated with create operation of this
        /// database.</param>
        /// <param name="restorableDroppedDatabaseId">The resource identifier
        /// of the restorable dropped database associated with create operation
        /// of this database.</param>
        /// <param name="catalogCollation">Collation of the metadata catalog.
        /// Possible values include: 'DATABASE_DEFAULT',
        /// 'SQL_Latin1_General_CP1_CI_AS'</param>
        /// <param name="zoneRedundant">Whether or not this database is zone
        /// redundant, which means the replicas of this database will be spread
        /// across multiple availability zones.</param>
        /// <param name="licenseType">The license type to apply for this
        /// database. Possible values include: 'LicenseIncluded',
        /// 'BasePrice'</param>
        /// <param name="maxLogSizeBytes">The max log size for this
        /// database.</param>
        /// <param name="earliestRestoreDate">This records the earliest start
        /// date and time that restore is available for this database (ISO8601
        /// format).</param>
        /// <param name="readScale">If enabled, connections that have
        /// application intent set to readonly in their connection string may
        /// be routed to a readonly secondary replica. This property is only
        /// settable for Premium and Business Critical databases. Possible
        /// values include: 'Enabled', 'Disabled'</param>
        /// <param name="readReplicaCount">The number of readonly secondary
        /// replicas associated with the database to which readonly application
        /// intent connections may be routed. This property is only settable
        /// for Hyperscale edition databases.</param>
        /// <param name="currentSku">The name and tier of the SKU.</param>
        /// <param name="autoPauseDelay">Time in minutes after which database
        /// is automatically paused. A value of -1 means that automatic pause
        /// is disabled</param>
        /// <param name="minCapacity">Minimal capacity that database will
        /// always have allocated, if not paused</param>
        /// <param name="pausedDate">The date when database was paused by user
        /// configuration or action (ISO8601 format). Null if the database is
        /// ready.</param>
        /// <param name="resumedDate">The date when database was resumed by
        /// user action or database login (ISO8601 format). Null if the
        /// database is paused.</param>
        public Database(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), Sku sku = default(Sku), string kind = default(string), string managedBy = default(string), string createMode = default(string), string collation = default(string), long? maxSizeBytes = default(long?), string sampleName = default(string), string elasticPoolId = default(string), string sourceDatabaseId = default(string), string status = default(string), System.Guid? databaseId = default(System.Guid?), System.DateTime? creationDate = default(System.DateTime?), string currentServiceObjectiveName = default(string), string requestedServiceObjectiveName = default(string), string defaultSecondaryLocation = default(string), string failoverGroupId = default(string), System.DateTime? restorePointInTime = default(System.DateTime?), System.DateTime? sourceDatabaseDeletionDate = default(System.DateTime?), string recoveryServicesRecoveryPointId = default(string), string longTermRetentionBackupResourceId = default(string), string recoverableDatabaseId = default(string), string restorableDroppedDatabaseId = default(string), string catalogCollation = default(string), bool? zoneRedundant = default(bool?), string licenseType = default(string), long? maxLogSizeBytes = default(long?), System.DateTime? earliestRestoreDate = default(System.DateTime?), string readScale = default(string), int? readReplicaCount = default(int?), Sku currentSku = default(Sku), int? autoPauseDelay = default(int?), double? minCapacity = default(double?), System.DateTime? pausedDate = default(System.DateTime?), System.DateTime? resumedDate = default(System.DateTime?))
            : base(location, id, name, type, tags)
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
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the database SKU.
        ///
        /// The list of SKUs may vary by region and support offer. To determine
        /// the SKUs (including the SKU name, tier/edition, family, and
        /// capacity) that are available to your subscription in an Azure
        /// region, use the `Capabilities_ListByLocation` REST API or one of
        /// the following commands:
        ///
        /// ```azurecli
        /// az sql db list-editions -l &amp;lt;location&amp;gt; -o table
        /// ````
        ///
        /// ```powershell
        /// Get-AzSqlServerServiceObjective -Location &amp;lt;location&amp;gt;
        /// ````
        ///
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Gets kind of database. This is metadata used for the Azure portal
        /// experience.
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; private set; }

        /// <summary>
        /// Gets resource that manages the database.
        /// </summary>
        [JsonProperty(PropertyName = "managedBy")]
        public string ManagedBy { get; private set; }

        /// <summary>
        /// Gets or sets specifies the mode of database creation.
        ///
        /// Default: regular database creation.
        ///
        /// Copy: creates a database as a copy of an existing database.
        /// sourceDatabaseId must be specified as the resource ID of the source
        /// database.
        ///
        /// Secondary: creates a database as a secondary replica of an existing
        /// database. sourceDatabaseId must be specified as the resource ID of
        /// the existing primary database.
        ///
        /// PointInTimeRestore: Creates a database by restoring a point in time
        /// backup of an existing database. sourceDatabaseId must be specified
        /// as the resource ID of the existing database, and restorePointInTime
        /// must be specified.
        ///
        /// Recovery: Creates a database by restoring a geo-replicated backup.
        /// sourceDatabaseId must be specified as the recoverable database
        /// resource ID to restore.
        ///
        /// Restore: Creates a database by restoring a backup of a deleted
        /// database. sourceDatabaseId must be specified. If sourceDatabaseId
        /// is the database's original resource ID, then
        /// sourceDatabaseDeletionDate must be specified. Otherwise
        /// sourceDatabaseId must be the restorable dropped database resource
        /// ID and sourceDatabaseDeletionDate is ignored. restorePointInTime
        /// may also be specified to restore from an earlier point in time.
        ///
        /// RestoreLongTermRetentionBackup: Creates a database by restoring
        /// from a long term retention vault.
        /// recoveryServicesRecoveryPointResourceId must be specified as the
        /// recovery point resource ID.
        ///
        /// Copy, Secondary, and RestoreLongTermRetentionBackup are not
        /// supported for DataWarehouse edition. Possible values include:
        /// 'Default', 'Copy', 'Secondary', 'PointInTimeRestore', 'Restore',
        /// 'Recovery', 'RestoreExternalBackup',
        /// 'RestoreExternalBackupSecondary', 'RestoreLongTermRetentionBackup',
        /// 'OnlineSecondary'
        /// </summary>
        [JsonProperty(PropertyName = "properties.createMode")]
        public string CreateMode { get; set; }

        /// <summary>
        /// Gets or sets the collation of the database.
        /// </summary>
        [JsonProperty(PropertyName = "properties.collation")]
        public string Collation { get; set; }

        /// <summary>
        /// Gets or sets the max size of the database expressed in bytes.
        /// </summary>
        [JsonProperty(PropertyName = "properties.maxSizeBytes")]
        public long? MaxSizeBytes { get; set; }

        /// <summary>
        /// Gets or sets the name of the sample schema to apply when creating
        /// this database. Possible values include: 'AdventureWorksLT',
        /// 'WideWorldImportersStd', 'WideWorldImportersFull'
        /// </summary>
        [JsonProperty(PropertyName = "properties.sampleName")]
        public string SampleName { get; set; }

        /// <summary>
        /// Gets or sets the resource identifier of the elastic pool containing
        /// this database.
        /// </summary>
        [JsonProperty(PropertyName = "properties.elasticPoolId")]
        public string ElasticPoolId { get; set; }

        /// <summary>
        /// Gets or sets the resource identifier of the source database
        /// associated with create operation of this database.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sourceDatabaseId")]
        public string SourceDatabaseId { get; set; }

        /// <summary>
        /// Gets the status of the database. Possible values include: 'Online',
        /// 'Restoring', 'RecoveryPending', 'Recovering', 'Suspect', 'Offline',
        /// 'Standby', 'Shutdown', 'EmergencyMode', 'AutoClosed', 'Copying',
        /// 'Creating', 'Inaccessible', 'OfflineSecondary', 'Pausing',
        /// 'Paused', 'Resuming', 'Scaling',
        /// 'OfflineChangingDwPerformanceTiers',
        /// 'OnlineChangingDwPerformanceTiers', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public string Status { get; private set; }

        /// <summary>
        /// Gets the ID of the database.
        /// </summary>
        [JsonProperty(PropertyName = "properties.databaseId")]
        public System.Guid? DatabaseId { get; private set; }

        /// <summary>
        /// Gets the creation date of the database (ISO8601 format).
        /// </summary>
        [JsonProperty(PropertyName = "properties.creationDate")]
        public System.DateTime? CreationDate { get; private set; }

        /// <summary>
        /// Gets the current service level objective name of the database.
        /// </summary>
        [JsonProperty(PropertyName = "properties.currentServiceObjectiveName")]
        public string CurrentServiceObjectiveName { get; private set; }

        /// <summary>
        /// Gets the requested service level objective name of the database.
        /// </summary>
        [JsonProperty(PropertyName = "properties.requestedServiceObjectiveName")]
        public string RequestedServiceObjectiveName { get; private set; }

        /// <summary>
        /// Gets the default secondary region for this database.
        /// </summary>
        [JsonProperty(PropertyName = "properties.defaultSecondaryLocation")]
        public string DefaultSecondaryLocation { get; private set; }

        /// <summary>
        /// Gets failover Group resource identifier that this database belongs
        /// to.
        /// </summary>
        [JsonProperty(PropertyName = "properties.failoverGroupId")]
        public string FailoverGroupId { get; private set; }

        /// <summary>
        /// Gets or sets specifies the point in time (ISO8601 format) of the
        /// source database that will be restored to create the new database.
        /// </summary>
        [JsonProperty(PropertyName = "properties.restorePointInTime")]
        public System.DateTime? RestorePointInTime { get; set; }

        /// <summary>
        /// Gets or sets specifies the time that the database was deleted.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sourceDatabaseDeletionDate")]
        public System.DateTime? SourceDatabaseDeletionDate { get; set; }

        /// <summary>
        /// Gets or sets the resource identifier of the recovery point
        /// associated with create operation of this database.
        /// </summary>
        [JsonProperty(PropertyName = "properties.recoveryServicesRecoveryPointId")]
        public string RecoveryServicesRecoveryPointId { get; set; }

        /// <summary>
        /// Gets or sets the resource identifier of the long term retention
        /// backup associated with create operation of this database.
        /// </summary>
        [JsonProperty(PropertyName = "properties.longTermRetentionBackupResourceId")]
        public string LongTermRetentionBackupResourceId { get; set; }

        /// <summary>
        /// Gets or sets the resource identifier of the recoverable database
        /// associated with create operation of this database.
        /// </summary>
        [JsonProperty(PropertyName = "properties.recoverableDatabaseId")]
        public string RecoverableDatabaseId { get; set; }

        /// <summary>
        /// Gets or sets the resource identifier of the restorable dropped
        /// database associated with create operation of this database.
        /// </summary>
        [JsonProperty(PropertyName = "properties.restorableDroppedDatabaseId")]
        public string RestorableDroppedDatabaseId { get; set; }

        /// <summary>
        /// Gets or sets collation of the metadata catalog. Possible values
        /// include: 'DATABASE_DEFAULT', 'SQL_Latin1_General_CP1_CI_AS'
        /// </summary>
        [JsonProperty(PropertyName = "properties.catalogCollation")]
        public string CatalogCollation { get; set; }

        /// <summary>
        /// Gets or sets whether or not this database is zone redundant, which
        /// means the replicas of this database will be spread across multiple
        /// availability zones.
        /// </summary>
        [JsonProperty(PropertyName = "properties.zoneRedundant")]
        public bool? ZoneRedundant { get; set; }

        /// <summary>
        /// Gets or sets the license type to apply for this database. Possible
        /// values include: 'LicenseIncluded', 'BasePrice'
        /// </summary>
        [JsonProperty(PropertyName = "properties.licenseType")]
        public string LicenseType { get; set; }

        /// <summary>
        /// Gets the max log size for this database.
        /// </summary>
        [JsonProperty(PropertyName = "properties.maxLogSizeBytes")]
        public long? MaxLogSizeBytes { get; private set; }

        /// <summary>
        /// Gets this records the earliest start date and time that restore is
        /// available for this database (ISO8601 format).
        /// </summary>
        [JsonProperty(PropertyName = "properties.earliestRestoreDate")]
        public System.DateTime? EarliestRestoreDate { get; private set; }

        /// <summary>
        /// Gets or sets if enabled, connections that have application intent
        /// set to readonly in their connection string may be routed to a
        /// readonly secondary replica. This property is only settable for
        /// Premium and Business Critical databases. Possible values include:
        /// 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.readScale")]
        public string ReadScale { get; set; }

        /// <summary>
        /// Gets or sets the number of readonly secondary replicas associated
        /// with the database to which readonly application intent connections
        /// may be routed. This property is only settable for Hyperscale
        /// edition databases.
        /// </summary>
        [JsonProperty(PropertyName = "properties.readReplicaCount")]
        public int? ReadReplicaCount { get; set; }

        /// <summary>
        /// Gets the name and tier of the SKU.
        /// </summary>
        [JsonProperty(PropertyName = "properties.currentSku")]
        public Sku CurrentSku { get; private set; }

        /// <summary>
        /// Gets or sets time in minutes after which database is automatically
        /// paused. A value of -1 means that automatic pause is disabled
        /// </summary>
        [JsonProperty(PropertyName = "properties.autoPauseDelay")]
        public int? AutoPauseDelay { get; set; }

        /// <summary>
        /// Gets or sets minimal capacity that database will always have
        /// allocated, if not paused
        /// </summary>
        [JsonProperty(PropertyName = "properties.minCapacity")]
        public double? MinCapacity { get; set; }

        /// <summary>
        /// Gets the date when database was paused by user configuration or
        /// action (ISO8601 format). Null if the database is ready.
        /// </summary>
        [JsonProperty(PropertyName = "properties.pausedDate")]
        public System.DateTime? PausedDate { get; private set; }

        /// <summary>
        /// Gets the date when database was resumed by user action or database
        /// login (ISO8601 format). Null if the database is paused.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resumedDate")]
        public System.DateTime? ResumedDate { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Sku != null)
            {
                Sku.Validate();
            }
            if (CurrentSku != null)
            {
                CurrentSku.Validate();
            }
        }
    }
}
