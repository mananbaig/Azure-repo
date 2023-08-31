// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CosmosDBForPostgreSql.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CosmosDBForPostgreSql
{
    /// <summary>
    /// A class representing the CosmosDBForPostgreSqlCluster data model.
    /// Represents a cluster.
    /// </summary>
    public partial class CosmosDBForPostgreSqlClusterData : TrackedResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CosmosDBForPostgreSqlClusterData"/>. </summary>
        /// <param name="location"> The location. </param>
        public CosmosDBForPostgreSqlClusterData(AzureLocation location) : base(location)
        {
            ServerNames = new ChangeTrackingList<ServerNameItem>();
            ReadReplicas = new ChangeTrackingList<string>();
            PrivateEndpointConnections = new ChangeTrackingList<CosmosDBForPostgreSqlSimplePrivateEndpointConnection>();
        }

        /// <summary> Initializes a new instance of <see cref="CosmosDBForPostgreSqlClusterData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="administratorLogin"> The administrator's login name of the servers in the cluster. </param>
        /// <param name="administratorLoginPassword"> The password of the administrator login. Required for creation. </param>
        /// <param name="provisioningState"> Provisioning state of the cluster. </param>
        /// <param name="state"> A state of a cluster/server that is visible to user. </param>
        /// <param name="postgresqlVersion"> The major PostgreSQL version on all cluster servers. </param>
        /// <param name="citusVersion"> The Citus extension version on all cluster servers. </param>
        /// <param name="maintenanceWindow"> Maintenance window of a cluster. </param>
        /// <param name="preferredPrimaryZone"> Preferred primary availability zone (AZ) for all cluster servers. </param>
        /// <param name="isShardsOnCoordinatorEnabled"> If shards on coordinator is enabled or not for the cluster. </param>
        /// <param name="isHAEnabled"> If high availability (HA) is enabled or not for the cluster. </param>
        /// <param name="coordinatorServerEdition"> The edition of a coordinator server (default: GeneralPurpose). Required for creation. </param>
        /// <param name="coordinatorStorageQuotaInMb"> The storage of a server in MB. Required for creation. See https://learn.microsoft.com/azure/cosmos-db/postgresql/resources-compute for more information. </param>
        /// <param name="coordinatorVCores"> The vCores count of a server (max: 96). Required for creation. See https://learn.microsoft.com/azure/cosmos-db/postgresql/resources-compute for more information. </param>
        /// <param name="isCoordinatorPublicIPAccessEnabled"> If public access is enabled on coordinator. </param>
        /// <param name="nodeServerEdition"> The edition of a node server (default: MemoryOptimized). </param>
        /// <param name="nodeCount"> Worker node count of the cluster. When node count is 0, it represents a single node configuration with the ability to create distributed tables on that node. 2 or more worker nodes represent multi-node configuration. Node count value cannot be 1. Required for creation. </param>
        /// <param name="nodeStorageQuotaInMb"> The storage in MB on each worker node. See https://learn.microsoft.com/azure/cosmos-db/postgresql/resources-compute for more information. </param>
        /// <param name="nodeVCores"> The compute in vCores on each worker node (max: 104). See https://learn.microsoft.com/azure/cosmos-db/postgresql/resources-compute for more information. </param>
        /// <param name="isNodePublicIPAccessEnabled"> If public access is enabled on worker nodes. </param>
        /// <param name="serverNames"> The list of server names in the cluster. </param>
        /// <param name="sourceResourceId"> The resource id of source cluster for read replica clusters. </param>
        /// <param name="sourceLocation"> The Azure region of source cluster for read replica clusters. </param>
        /// <param name="pointInTimeUTC"> Date and time in UTC (ISO8601 format) for cluster restore. </param>
        /// <param name="readReplicas"> The array of read replica clusters. </param>
        /// <param name="earliestRestoreOn"> The earliest restore point time (ISO8601 format) for the cluster. </param>
        /// <param name="privateEndpointConnections"> The private endpoint connections for a cluster. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CosmosDBForPostgreSqlClusterData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string administratorLogin, string administratorLoginPassword, string provisioningState, string state, string postgresqlVersion, string citusVersion, CosmosDBForPostgreSqlMaintenanceWindow maintenanceWindow, string preferredPrimaryZone, bool? isShardsOnCoordinatorEnabled, bool? isHAEnabled, string coordinatorServerEdition, int? coordinatorStorageQuotaInMb, int? coordinatorVCores, bool? isCoordinatorPublicIPAccessEnabled, string nodeServerEdition, int? nodeCount, int? nodeStorageQuotaInMb, int? nodeVCores, bool? isNodePublicIPAccessEnabled, IReadOnlyList<ServerNameItem> serverNames, ResourceIdentifier sourceResourceId, AzureLocation? sourceLocation, DateTimeOffset? pointInTimeUTC, IReadOnlyList<string> readReplicas, DateTimeOffset? earliestRestoreOn, IReadOnlyList<CosmosDBForPostgreSqlSimplePrivateEndpointConnection> privateEndpointConnections, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData, tags, location)
        {
            AdministratorLogin = administratorLogin;
            AdministratorLoginPassword = administratorLoginPassword;
            ProvisioningState = provisioningState;
            State = state;
            PostgresqlVersion = postgresqlVersion;
            CitusVersion = citusVersion;
            MaintenanceWindow = maintenanceWindow;
            PreferredPrimaryZone = preferredPrimaryZone;
            IsShardsOnCoordinatorEnabled = isShardsOnCoordinatorEnabled;
            IsHAEnabled = isHAEnabled;
            CoordinatorServerEdition = coordinatorServerEdition;
            CoordinatorStorageQuotaInMb = coordinatorStorageQuotaInMb;
            CoordinatorVCores = coordinatorVCores;
            IsCoordinatorPublicIPAccessEnabled = isCoordinatorPublicIPAccessEnabled;
            NodeServerEdition = nodeServerEdition;
            NodeCount = nodeCount;
            NodeStorageQuotaInMb = nodeStorageQuotaInMb;
            NodeVCores = nodeVCores;
            IsNodePublicIPAccessEnabled = isNodePublicIPAccessEnabled;
            ServerNames = serverNames;
            SourceResourceId = sourceResourceId;
            SourceLocation = sourceLocation;
            PointInTimeUTC = pointInTimeUTC;
            ReadReplicas = readReplicas;
            EarliestRestoreOn = earliestRestoreOn;
            PrivateEndpointConnections = privateEndpointConnections;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="CosmosDBForPostgreSqlClusterData"/> for deserialization. </summary>
        internal CosmosDBForPostgreSqlClusterData()
        {
        }

        /// <summary> The administrator's login name of the servers in the cluster. </summary>
        public string AdministratorLogin { get; }
        /// <summary> The password of the administrator login. Required for creation. </summary>
        public string AdministratorLoginPassword { get; set; }
        /// <summary> Provisioning state of the cluster. </summary>
        public string ProvisioningState { get; }
        /// <summary> A state of a cluster/server that is visible to user. </summary>
        public string State { get; }
        /// <summary> The major PostgreSQL version on all cluster servers. </summary>
        public string PostgresqlVersion { get; set; }
        /// <summary> The Citus extension version on all cluster servers. </summary>
        public string CitusVersion { get; set; }
        /// <summary> Maintenance window of a cluster. </summary>
        public CosmosDBForPostgreSqlMaintenanceWindow MaintenanceWindow { get; set; }
        /// <summary> Preferred primary availability zone (AZ) for all cluster servers. </summary>
        public string PreferredPrimaryZone { get; set; }
        /// <summary> If shards on coordinator is enabled or not for the cluster. </summary>
        public bool? IsShardsOnCoordinatorEnabled { get; set; }
        /// <summary> If high availability (HA) is enabled or not for the cluster. </summary>
        public bool? IsHAEnabled { get; set; }
        /// <summary> The edition of a coordinator server (default: GeneralPurpose). Required for creation. </summary>
        public string CoordinatorServerEdition { get; set; }
        /// <summary> The storage of a server in MB. Required for creation. See https://learn.microsoft.com/azure/cosmos-db/postgresql/resources-compute for more information. </summary>
        public int? CoordinatorStorageQuotaInMb { get; set; }
        /// <summary> The vCores count of a server (max: 96). Required for creation. See https://learn.microsoft.com/azure/cosmos-db/postgresql/resources-compute for more information. </summary>
        public int? CoordinatorVCores { get; set; }
        /// <summary> If public access is enabled on coordinator. </summary>
        public bool? IsCoordinatorPublicIPAccessEnabled { get; set; }
        /// <summary> The edition of a node server (default: MemoryOptimized). </summary>
        public string NodeServerEdition { get; set; }
        /// <summary> Worker node count of the cluster. When node count is 0, it represents a single node configuration with the ability to create distributed tables on that node. 2 or more worker nodes represent multi-node configuration. Node count value cannot be 1. Required for creation. </summary>
        public int? NodeCount { get; set; }
        /// <summary> The storage in MB on each worker node. See https://learn.microsoft.com/azure/cosmos-db/postgresql/resources-compute for more information. </summary>
        public int? NodeStorageQuotaInMb { get; set; }
        /// <summary> The compute in vCores on each worker node (max: 104). See https://learn.microsoft.com/azure/cosmos-db/postgresql/resources-compute for more information. </summary>
        public int? NodeVCores { get; set; }
        /// <summary> If public access is enabled on worker nodes. </summary>
        public bool? IsNodePublicIPAccessEnabled { get; set; }
        /// <summary> The list of server names in the cluster. </summary>
        public IReadOnlyList<ServerNameItem> ServerNames { get; }
        /// <summary> The resource id of source cluster for read replica clusters. </summary>
        public ResourceIdentifier SourceResourceId { get; set; }
        /// <summary> The Azure region of source cluster for read replica clusters. </summary>
        public AzureLocation? SourceLocation { get; set; }
        /// <summary> Date and time in UTC (ISO8601 format) for cluster restore. </summary>
        public DateTimeOffset? PointInTimeUTC { get; set; }
        /// <summary> The array of read replica clusters. </summary>
        public IReadOnlyList<string> ReadReplicas { get; }
        /// <summary> The earliest restore point time (ISO8601 format) for the cluster. </summary>
        public DateTimeOffset? EarliestRestoreOn { get; }
        /// <summary> The private endpoint connections for a cluster. </summary>
        public IReadOnlyList<CosmosDBForPostgreSqlSimplePrivateEndpointConnection> PrivateEndpointConnections { get; }
    }
}
