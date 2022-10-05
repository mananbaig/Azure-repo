// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Redis.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// All Redis Settings. Few possible keys:
    /// rdb-backup-enabled,rdb-storage-connection-string,rdb-backup-frequency,maxmemory-delta,maxmemory-policy,notify-keyspace-events,maxmemory-samples,slowlog-log-slower-than,slowlog-max-len,list-max-ziplist-entries,list-max-ziplist-value,hash-max-ziplist-entries,hash-max-ziplist-value,set-max-intset-entries,zset-max-ziplist-entries,zset-max-ziplist-value
    /// etc.
    /// </summary>
    public partial class RedisCommonPropertiesRedisConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the
        /// RedisCommonPropertiesRedisConfiguration class.
        /// </summary>
        public RedisCommonPropertiesRedisConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// RedisCommonPropertiesRedisConfiguration class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="rdbBackupEnabled">Specifies whether the rdb backup is
        /// enabled</param>
        /// <param name="rdbBackupFrequency">Specifies the frequency for
        /// creating rdb backup in minutes. Valid values: (15, 30, 60, 360,
        /// 720, 1440)</param>
        /// <param name="rdbBackupMaxSnapshotCount">Specifies the maximum
        /// number of snapshots for rdb backup</param>
        /// <param name="rdbStorageConnectionString">The storage account
        /// connection string for storing rdb file</param>
        /// <param name="aofBackupEnabled">Specifies whether the aof backup is
        /// enabled</param>
        /// <param name="aofStorageConnectionString0">First storage account
        /// connection string</param>
        /// <param name="aofStorageConnectionString1">Second storage account
        /// connection string</param>
        /// <param name="maxfragmentationmemoryReserved">Value in megabytes
        /// reserved for fragmentation per shard</param>
        /// <param name="maxmemoryPolicy">The eviction strategy used when your
        /// data won't fit within its memory limit.</param>
        /// <param name="maxmemoryReserved">Value in megabytes reserved for
        /// non-cache usage per shard e.g. failover.</param>
        /// <param name="maxmemoryDelta">Value in megabytes reserved for
        /// non-cache usage per shard e.g. failover.</param>
        /// <param name="maxclients">The max clients config</param>
        /// <param name="preferredDataArchiveAuthMethod">Preferred auth method
        /// to communicate to storage account used for data archive, specify
        /// SAS or ManagedIdentity, default value is SAS</param>
        /// <param name="preferredDataPersistenceAuthMethod">Preferred auth
        /// method to communicate to storage account used for data persistence,
        /// specify SAS or ManagedIdentity, default value is SAS</param>
        /// <param name="zonalConfiguration">Zonal Configuration</param>
        /// <param name="authnotrequired">Specifies whether the authentication
        /// is disabled. Setting this property is highly discouraged from
        /// security point of view.</param>
        public RedisCommonPropertiesRedisConfiguration(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string rdbBackupEnabled = default(string), string rdbBackupFrequency = default(string), string rdbBackupMaxSnapshotCount = default(string), string rdbStorageConnectionString = default(string), string aofBackupEnabled = default(string), string aofStorageConnectionString0 = default(string), string aofStorageConnectionString1 = default(string), string maxfragmentationmemoryReserved = default(string), string maxmemoryPolicy = default(string), string maxmemoryReserved = default(string), string maxmemoryDelta = default(string), string maxclients = default(string), string preferredDataArchiveAuthMethod = default(string), string preferredDataPersistenceAuthMethod = default(string), string zonalConfiguration = default(string), string authnotrequired = default(string))
        {
            AdditionalProperties = additionalProperties;
            RdbBackupEnabled = rdbBackupEnabled;
            RdbBackupFrequency = rdbBackupFrequency;
            RdbBackupMaxSnapshotCount = rdbBackupMaxSnapshotCount;
            RdbStorageConnectionString = rdbStorageConnectionString;
            AofBackupEnabled = aofBackupEnabled;
            AofStorageConnectionString0 = aofStorageConnectionString0;
            AofStorageConnectionString1 = aofStorageConnectionString1;
            MaxfragmentationmemoryReserved = maxfragmentationmemoryReserved;
            MaxmemoryPolicy = maxmemoryPolicy;
            MaxmemoryReserved = maxmemoryReserved;
            MaxmemoryDelta = maxmemoryDelta;
            Maxclients = maxclients;
            PreferredDataArchiveAuthMethod = preferredDataArchiveAuthMethod;
            PreferredDataPersistenceAuthMethod = preferredDataPersistenceAuthMethod;
            ZonalConfiguration = zonalConfiguration;
            Authnotrequired = authnotrequired;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unmatched properties from the message are deserialized
        /// this collection
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Gets or sets specifies whether the rdb backup is enabled
        /// </summary>
        [JsonProperty(PropertyName = "rdb-backup-enabled")]
        public string RdbBackupEnabled { get; set; }

        /// <summary>
        /// Gets or sets specifies the frequency for creating rdb backup in
        /// minutes. Valid values: (15, 30, 60, 360, 720, 1440)
        /// </summary>
        [JsonProperty(PropertyName = "rdb-backup-frequency")]
        public string RdbBackupFrequency { get; set; }

        /// <summary>
        /// Gets or sets specifies the maximum number of snapshots for rdb
        /// backup
        /// </summary>
        [JsonProperty(PropertyName = "rdb-backup-max-snapshot-count")]
        public string RdbBackupMaxSnapshotCount { get; set; }

        /// <summary>
        /// Gets or sets the storage account connection string for storing rdb
        /// file
        /// </summary>
        [JsonProperty(PropertyName = "rdb-storage-connection-string")]
        public string RdbStorageConnectionString { get; set; }

        /// <summary>
        /// Gets or sets specifies whether the aof backup is enabled
        /// </summary>
        [JsonProperty(PropertyName = "aof-backup-enabled")]
        public string AofBackupEnabled { get; set; }

        /// <summary>
        /// Gets or sets first storage account connection string
        /// </summary>
        [JsonProperty(PropertyName = "aof-storage-connection-string-0")]
        public string AofStorageConnectionString0 { get; set; }

        /// <summary>
        /// Gets or sets second storage account connection string
        /// </summary>
        [JsonProperty(PropertyName = "aof-storage-connection-string-1")]
        public string AofStorageConnectionString1 { get; set; }

        /// <summary>
        /// Gets or sets value in megabytes reserved for fragmentation per
        /// shard
        /// </summary>
        [JsonProperty(PropertyName = "maxfragmentationmemory-reserved")]
        public string MaxfragmentationmemoryReserved { get; set; }

        /// <summary>
        /// Gets or sets the eviction strategy used when your data won't fit
        /// within its memory limit.
        /// </summary>
        [JsonProperty(PropertyName = "maxmemory-policy")]
        public string MaxmemoryPolicy { get; set; }

        /// <summary>
        /// Gets or sets value in megabytes reserved for non-cache usage per
        /// shard e.g. failover.
        /// </summary>
        [JsonProperty(PropertyName = "maxmemory-reserved")]
        public string MaxmemoryReserved { get; set; }

        /// <summary>
        /// Gets or sets value in megabytes reserved for non-cache usage per
        /// shard e.g. failover.
        /// </summary>
        [JsonProperty(PropertyName = "maxmemory-delta")]
        public string MaxmemoryDelta { get; set; }

        /// <summary>
        /// Gets the max clients config
        /// </summary>
        [JsonProperty(PropertyName = "maxclients")]
        public string Maxclients { get; private set; }

        /// <summary>
        /// Gets preferred auth method to communicate to storage account used
        /// for data archive, specify SAS or ManagedIdentity, default value is
        /// SAS
        /// </summary>
        [JsonProperty(PropertyName = "preferred-data-archive-auth-method")]
        public string PreferredDataArchiveAuthMethod { get; private set; }

        /// <summary>
        /// Gets or sets preferred auth method to communicate to storage
        /// account used for data persistence, specify SAS or ManagedIdentity,
        /// default value is SAS
        /// </summary>
        [JsonProperty(PropertyName = "preferred-data-persistence-auth-method")]
        public string PreferredDataPersistenceAuthMethod { get; set; }

        /// <summary>
        /// Gets zonal Configuration
        /// </summary>
        [JsonProperty(PropertyName = "zonal-configuration")]
        public string ZonalConfiguration { get; private set; }

        /// <summary>
        /// Gets or sets specifies whether the authentication is disabled.
        /// Setting this property is highly discouraged from security point of
        /// view.
        /// </summary>
        [JsonProperty(PropertyName = "authnotrequired")]
        public string Authnotrequired { get; set; }

    }
}
