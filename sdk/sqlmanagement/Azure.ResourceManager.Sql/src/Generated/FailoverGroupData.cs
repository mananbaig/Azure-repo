// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing the FailoverGroup data model.
    /// A failover group.
    /// </summary>
    public partial class FailoverGroupData : ResourceData
    {
        /// <summary> Initializes a new instance of FailoverGroupData. </summary>
        public FailoverGroupData()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            PartnerServers = new ChangeTrackingList<PartnerServerInfo>();
            FailoverDatabases = new ChangeTrackingList<ResourceIdentifier>();
        }

        /// <summary> Initializes a new instance of FailoverGroupData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="readWriteEndpoint"> Read-write endpoint of the failover group instance. </param>
        /// <param name="readOnlyEndpoint"> Read-only endpoint of the failover group instance. </param>
        /// <param name="replicationRole"> Local replication role of the failover group instance. </param>
        /// <param name="replicationState"> Replication state of the failover group instance. </param>
        /// <param name="partnerServers"> List of partner server information for the failover group. </param>
        /// <param name="failoverDatabases"> List of databases in the failover group. </param>
        internal FailoverGroupData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AzureLocation? location, IDictionary<string, string> tags, FailoverGroupReadWriteEndpoint readWriteEndpoint, FailoverGroupReadOnlyEndpoint readOnlyEndpoint, FailoverGroupReplicationRole? replicationRole, string replicationState, IList<PartnerServerInfo> partnerServers, IList<ResourceIdentifier> failoverDatabases) : base(id, name, resourceType, systemData)
        {
            Location = location;
            Tags = tags;
            ReadWriteEndpoint = readWriteEndpoint;
            ReadOnlyEndpoint = readOnlyEndpoint;
            ReplicationRole = replicationRole;
            ReplicationState = replicationState;
            PartnerServers = partnerServers;
            FailoverDatabases = failoverDatabases;
        }

        /// <summary> Resource location. </summary>
        public AzureLocation? Location { get; }
        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Read-write endpoint of the failover group instance. </summary>
        public FailoverGroupReadWriteEndpoint ReadWriteEndpoint { get; set; }
        /// <summary> Read-only endpoint of the failover group instance. </summary>
        public FailoverGroupReadOnlyEndpoint ReadOnlyEndpoint { get; set; }
        /// <summary> Local replication role of the failover group instance. </summary>
        public FailoverGroupReplicationRole? ReplicationRole { get; }
        /// <summary> Replication state of the failover group instance. </summary>
        public string ReplicationState { get; }
        /// <summary> List of partner server information for the failover group. </summary>
        public IList<PartnerServerInfo> PartnerServers { get; }
        /// <summary> List of databases in the failover group. </summary>
        public IList<ResourceIdentifier> FailoverDatabases { get; }
    }
}
