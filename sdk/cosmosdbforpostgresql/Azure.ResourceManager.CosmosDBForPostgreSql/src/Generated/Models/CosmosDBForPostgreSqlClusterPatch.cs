// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDBForPostgreSql.Models
{
    /// <summary> Represents a cluster for update. </summary>
    public partial class CosmosDBForPostgreSqlClusterPatch
    {
        /// <summary> Initializes a new instance of CosmosDBForPostgreSqlClusterPatch. </summary>
        public CosmosDBForPostgreSqlClusterPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Application-specific metadata in the form of key-value pairs. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The password of the administrator login. Each cluster is created with pre-defined administrative role called ‘citus’. . </summary>
        public string AdministratorLoginPassword { get; set; }
        /// <summary> The major PostgreSQL version on all cluster servers. </summary>
        public string PostgresqlVersion { get; set; }
        /// <summary> The Citus extension version on all cluster servers. </summary>
        public string CitusVersion { get; set; }
        /// <summary> If distributed tables are placed on coordinator or not. Should be set to 'true' on single node clusters. Requires shard rebalancing after value is changed. </summary>
        public bool? IsShardsOnCoordinatorEnabled { get; set; }
        /// <summary> If high availability (HA) is enabled or not for the cluster. </summary>
        public bool? IsHAEnabled { get; set; }
        /// <summary> Preferred primary availability zone (AZ) for all cluster servers. </summary>
        public string PreferredPrimaryZone { get; set; }
        /// <summary> The edition of the coordinator (default: GeneralPurpose). </summary>
        public string CoordinatorServerEdition { get; set; }
        /// <summary> The storage of the coordinator in MB. </summary>
        public int? CoordinatorStorageQuotaInMb { get; set; }
        /// <summary> The vCores count of the coordinator (max: 96). </summary>
        public int? CoordinatorVCores { get; set; }
        /// <summary> If public access is enabled on coordinator. </summary>
        public bool? IsCoordinatorPublicIPAccessEnabled { get; set; }
        /// <summary> The edition of a node (default: MemoryOptimized). </summary>
        public string NodeServerEdition { get; set; }
        /// <summary> Worker node count of the cluster. When node count is 0, it represents a single node configuration with the ability to create distributed tables on that node. 2 or more worker nodes represent multi-node configuration. Node count value cannot be 1. </summary>
        public int? NodeCount { get; set; }
        /// <summary> The storage in MB on each worker node. </summary>
        public int? NodeStorageQuotaInMb { get; set; }
        /// <summary> The compute in vCores on each worker node (max: 104). </summary>
        public int? NodeVCores { get; set; }
        /// <summary> If public access is enabled on worker nodes. </summary>
        public bool? IsNodePublicIPAccessEnabled { get; }
        /// <summary> Maintenance window of a cluster. </summary>
        public CosmosDBForPostgreSqlMaintenanceWindow MaintenanceWindow { get; set; }
    }
}
