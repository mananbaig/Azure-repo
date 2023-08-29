// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.PostgreSql.FlexibleServers.Models;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers
{
    /// <summary>
    /// A class representing the PostgreSqlFlexibleServer data model.
    /// Represents a server.
    /// </summary>
    public partial class PostgreSqlFlexibleServerData : TrackedResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PostgreSqlFlexibleServerData"/>. </summary>
        /// <param name="location"> The location. </param>
        public PostgreSqlFlexibleServerData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="PostgreSqlFlexibleServerData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> The SKU (pricing tier) of the server. </param>
        /// <param name="identity"> Describes the identity of the application. </param>
        /// <param name="administratorLogin"> The administrator's login name of a server. Can only be specified when the server is being created (and is required for creation). </param>
        /// <param name="administratorLoginPassword"> The administrator login password (required for server creation). </param>
        /// <param name="version"> PostgreSQL Server version. </param>
        /// <param name="minorVersion"> The minor version of the server. </param>
        /// <param name="state"> A state of a server that is visible to user. </param>
        /// <param name="fullyQualifiedDomainName"> The fully qualified domain name of a server. </param>
        /// <param name="storage"> Storage properties of a server. </param>
        /// <param name="authConfig"> AuthConfig properties of a server. </param>
        /// <param name="dataEncryption"> Data encryption properties of a server. </param>
        /// <param name="backup"> Backup properties of a server. </param>
        /// <param name="network"> Network properties of a server. This Network property is required to be passed only in case you want the server to be Private access server. </param>
        /// <param name="highAvailability"> High availability properties of a server. </param>
        /// <param name="maintenanceWindow"> Maintenance window properties of a server. </param>
        /// <param name="sourceServerResourceId"> The source server resource ID to restore from. It's required when 'createMode' is 'PointInTimeRestore' or 'GeoRestore' or 'Replica' or 'ReviveDropped'. This property is returned only for Replica server. </param>
        /// <param name="pointInTimeUtc"> Restore point creation time (ISO8601 format), specifying the time to restore from. It's required when 'createMode' is 'PointInTimeRestore' or 'GeoRestore' or 'ReviveDropped'. </param>
        /// <param name="availabilityZone"> availability zone information of the server. </param>
        /// <param name="replicationRole"> Replication role of the server. </param>
        /// <param name="replicaCapacity"> Replicas allowed for a server. </param>
        /// <param name="createMode"> The mode to create a new PostgreSQL server. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PostgreSqlFlexibleServerData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, PostgreSqlFlexibleServerSku sku, PostgreSqlFlexibleServerUserAssignedIdentity identity, string administratorLogin, string administratorLoginPassword, PostgreSqlFlexibleServerVersion? version, string minorVersion, PostgreSqlFlexibleServerState? state, string fullyQualifiedDomainName, PostgreSqlFlexibleServerStorage storage, PostgreSqlFlexibleServerAuthConfig authConfig, PostgreSqlFlexibleServerDataEncryption dataEncryption, PostgreSqlFlexibleServerBackupProperties backup, PostgreSqlFlexibleServerNetwork network, PostgreSqlFlexibleServerHighAvailability highAvailability, PostgreSqlFlexibleServerMaintenanceWindow maintenanceWindow, ResourceIdentifier sourceServerResourceId, DateTimeOffset? pointInTimeUtc, string availabilityZone, PostgreSqlFlexibleServerReplicationRole? replicationRole, int? replicaCapacity, PostgreSqlFlexibleServerCreateMode? createMode, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Sku = sku;
            Identity = identity;
            AdministratorLogin = administratorLogin;
            AdministratorLoginPassword = administratorLoginPassword;
            Version = version;
            MinorVersion = minorVersion;
            State = state;
            FullyQualifiedDomainName = fullyQualifiedDomainName;
            Storage = storage;
            AuthConfig = authConfig;
            DataEncryption = dataEncryption;
            Backup = backup;
            Network = network;
            HighAvailability = highAvailability;
            MaintenanceWindow = maintenanceWindow;
            SourceServerResourceId = sourceServerResourceId;
            PointInTimeUtc = pointInTimeUtc;
            AvailabilityZone = availabilityZone;
            ReplicationRole = replicationRole;
            ReplicaCapacity = replicaCapacity;
            CreateMode = createMode;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="PostgreSqlFlexibleServerData"/> for deserialization. </summary>
        internal PostgreSqlFlexibleServerData()
        {
        }

        /// <summary> The SKU (pricing tier) of the server. </summary>
        public PostgreSqlFlexibleServerSku Sku { get; set; }
        /// <summary> Describes the identity of the application. </summary>
        public PostgreSqlFlexibleServerUserAssignedIdentity Identity { get; set; }
        /// <summary> The administrator's login name of a server. Can only be specified when the server is being created (and is required for creation). </summary>
        public string AdministratorLogin { get; set; }
        /// <summary> The administrator login password (required for server creation). </summary>
        public string AdministratorLoginPassword { get; set; }
        /// <summary> PostgreSQL Server version. </summary>
        public PostgreSqlFlexibleServerVersion? Version { get; set; }
        /// <summary> The minor version of the server. </summary>
        public string MinorVersion { get; }
        /// <summary> A state of a server that is visible to user. </summary>
        public PostgreSqlFlexibleServerState? State { get; }
        /// <summary> The fully qualified domain name of a server. </summary>
        public string FullyQualifiedDomainName { get; }
        /// <summary> Storage properties of a server. </summary>
        public PostgreSqlFlexibleServerStorage Storage { get; set; }
        /// <summary> AuthConfig properties of a server. </summary>
        public PostgreSqlFlexibleServerAuthConfig AuthConfig { get; set; }
        /// <summary> Data encryption properties of a server. </summary>
        public PostgreSqlFlexibleServerDataEncryption DataEncryption { get; set; }
        /// <summary> Backup properties of a server. </summary>
        public PostgreSqlFlexibleServerBackupProperties Backup { get; set; }
        /// <summary> Network properties of a server. This Network property is required to be passed only in case you want the server to be Private access server. </summary>
        public PostgreSqlFlexibleServerNetwork Network { get; set; }
        /// <summary> High availability properties of a server. </summary>
        public PostgreSqlFlexibleServerHighAvailability HighAvailability { get; set; }
        /// <summary> Maintenance window properties of a server. </summary>
        public PostgreSqlFlexibleServerMaintenanceWindow MaintenanceWindow { get; set; }
        /// <summary> The source server resource ID to restore from. It's required when 'createMode' is 'PointInTimeRestore' or 'GeoRestore' or 'Replica' or 'ReviveDropped'. This property is returned only for Replica server. </summary>
        public ResourceIdentifier SourceServerResourceId { get; set; }
        /// <summary> Restore point creation time (ISO8601 format), specifying the time to restore from. It's required when 'createMode' is 'PointInTimeRestore' or 'GeoRestore' or 'ReviveDropped'. </summary>
        public DateTimeOffset? PointInTimeUtc { get; set; }
        /// <summary> availability zone information of the server. </summary>
        public string AvailabilityZone { get; set; }
        /// <summary> Replication role of the server. </summary>
        public PostgreSqlFlexibleServerReplicationRole? ReplicationRole { get; set; }
        /// <summary> The mode to create a new PostgreSQL server. </summary>
        public PostgreSqlFlexibleServerCreateMode? CreateMode { get; set; }
    }
}
