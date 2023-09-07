// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Redis.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Redis
{
    /// <summary>
    /// A class representing the Redis data model.
    /// A single Redis item in List or Get Operation.
    /// </summary>
    public partial class RedisData : TrackedResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RedisData"/>. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> The SKU of the Redis cache to deploy. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> is null. </exception>
        public RedisData(AzureLocation location, RedisSku sku) : base(location)
        {
            Argument.AssertNotNull(sku, nameof(sku));

            Zones = new ChangeTrackingList<string>();
            TenantSettings = new ChangeTrackingDictionary<string, string>();
            Sku = sku;
            LinkedServers = new ChangeTrackingList<SubResource>();
            Instances = new ChangeTrackingList<RedisInstanceDetails>();
            PrivateEndpointConnections = new ChangeTrackingList<RedisPrivateEndpointConnectionData>();
        }

        /// <summary> Initializes a new instance of <see cref="RedisData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="zones"> A list of availability zones denoting where the resource needs to come from. </param>
        /// <param name="identity"> The identity of the resource. </param>
        /// <param name="redisConfiguration"> All Redis Settings. Few possible keys: rdb-backup-enabled,rdb-storage-connection-string,rdb-backup-frequency,maxmemory-delta,maxmemory-policy,notify-keyspace-events,maxmemory-samples,slowlog-log-slower-than,slowlog-max-len,list-max-ziplist-entries,list-max-ziplist-value,hash-max-ziplist-entries,hash-max-ziplist-value,set-max-intset-entries,zset-max-ziplist-entries,zset-max-ziplist-value etc. </param>
        /// <param name="redisVersion"> Redis version. This should be in the form 'major[.minor]' (only 'major' is required) or the value 'latest' which refers to the latest stable Redis version that is available. Supported versions: 4.0, 6.0 (latest). Default value is 'latest'. </param>
        /// <param name="enableNonSslPort"> Specifies whether the non-ssl Redis server port (6379) is enabled. </param>
        /// <param name="replicasPerMaster"> The number of replicas to be created per primary. </param>
        /// <param name="replicasPerPrimary"> The number of replicas to be created per primary. </param>
        /// <param name="tenantSettings"> A dictionary of tenant settings. </param>
        /// <param name="shardCount"> The number of shards to be created on a Premium Cluster Cache. </param>
        /// <param name="minimumTlsVersion"> Optional: requires clients to use a specified TLS version (or higher) to connect (e,g, '1.0', '1.1', '1.2'). </param>
        /// <param name="publicNetworkAccess"> Whether or not public endpoint access is allowed for this cache.  Value is optional but if passed in, must be 'Enabled' or 'Disabled'. If 'Disabled', private endpoints are the exclusive access method. Default value is 'Enabled'. </param>
        /// <param name="sku"> The SKU of the Redis cache to deploy. </param>
        /// <param name="subnetId"> The full resource ID of a subnet in a virtual network to deploy the Redis cache in. Example format: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/Microsoft.{Network|ClassicNetwork}/VirtualNetworks/vnet1/subnets/subnet1. </param>
        /// <param name="staticIP"> Static IP address. Optionally, may be specified when deploying a Redis cache inside an existing Azure Virtual Network; auto assigned by default. </param>
        /// <param name="provisioningState"> Redis instance provisioning status. </param>
        /// <param name="hostName"> Redis host name. </param>
        /// <param name="port"> Redis non-SSL port. </param>
        /// <param name="sslPort"> Redis SSL port. </param>
        /// <param name="accessKeys"> The keys of the Redis cache - not set if this object is not the response to Create or Update redis cache. </param>
        /// <param name="linkedServers"> List of the linked servers associated with the cache. </param>
        /// <param name="instances"> List of the Redis instances associated with the cache. </param>
        /// <param name="privateEndpointConnections"> List of private endpoint connection associated with the specified redis cache. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RedisData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, IList<string> zones, ManagedServiceIdentity identity, RedisCommonConfiguration redisConfiguration, string redisVersion, bool? enableNonSslPort, int? replicasPerMaster, int? replicasPerPrimary, IDictionary<string, string> tenantSettings, int? shardCount, RedisTlsVersion? minimumTlsVersion, RedisPublicNetworkAccess? publicNetworkAccess, RedisSku sku, ResourceIdentifier subnetId, IPAddress staticIP, RedisProvisioningState? provisioningState, string hostName, int? port, int? sslPort, RedisAccessKeys accessKeys, IReadOnlyList<SubResource> linkedServers, IReadOnlyList<RedisInstanceDetails> instances, IReadOnlyList<RedisPrivateEndpointConnectionData> privateEndpointConnections, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Zones = zones;
            Identity = identity;
            RedisConfiguration = redisConfiguration;
            RedisVersion = redisVersion;
            EnableNonSslPort = enableNonSslPort;
            ReplicasPerMaster = replicasPerMaster;
            ReplicasPerPrimary = replicasPerPrimary;
            TenantSettings = tenantSettings;
            ShardCount = shardCount;
            MinimumTlsVersion = minimumTlsVersion;
            PublicNetworkAccess = publicNetworkAccess;
            Sku = sku;
            SubnetId = subnetId;
            StaticIP = staticIP;
            ProvisioningState = provisioningState;
            HostName = hostName;
            Port = port;
            SslPort = sslPort;
            AccessKeys = accessKeys;
            LinkedServers = linkedServers;
            Instances = instances;
            PrivateEndpointConnections = privateEndpointConnections;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="RedisData"/> for deserialization. </summary>
        internal RedisData()
        {
        }

        /// <summary> A list of availability zones denoting where the resource needs to come from. </summary>
        public IList<string> Zones { get; }
        /// <summary> The identity of the resource. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> All Redis Settings. Few possible keys: rdb-backup-enabled,rdb-storage-connection-string,rdb-backup-frequency,maxmemory-delta,maxmemory-policy,notify-keyspace-events,maxmemory-samples,slowlog-log-slower-than,slowlog-max-len,list-max-ziplist-entries,list-max-ziplist-value,hash-max-ziplist-entries,hash-max-ziplist-value,set-max-intset-entries,zset-max-ziplist-entries,zset-max-ziplist-value etc. </summary>
        public RedisCommonConfiguration RedisConfiguration { get; set; }
        /// <summary> Redis version. This should be in the form 'major[.minor]' (only 'major' is required) or the value 'latest' which refers to the latest stable Redis version that is available. Supported versions: 4.0, 6.0 (latest). Default value is 'latest'. </summary>
        public string RedisVersion { get; set; }
        /// <summary> Specifies whether the non-ssl Redis server port (6379) is enabled. </summary>
        public bool? EnableNonSslPort { get; set; }
        /// <summary> The number of replicas to be created per primary. </summary>
        public int? ReplicasPerMaster { get; set; }
        /// <summary> The number of replicas to be created per primary. </summary>
        public int? ReplicasPerPrimary { get; set; }
        /// <summary> A dictionary of tenant settings. </summary>
        public IDictionary<string, string> TenantSettings { get; }
        /// <summary> The number of shards to be created on a Premium Cluster Cache. </summary>
        public int? ShardCount { get; set; }
        /// <summary> Optional: requires clients to use a specified TLS version (or higher) to connect (e,g, '1.0', '1.1', '1.2'). </summary>
        public RedisTlsVersion? MinimumTlsVersion { get; set; }
        /// <summary> Whether or not public endpoint access is allowed for this cache.  Value is optional but if passed in, must be 'Enabled' or 'Disabled'. If 'Disabled', private endpoints are the exclusive access method. Default value is 'Enabled'. </summary>
        public RedisPublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary> The SKU of the Redis cache to deploy. </summary>
        public RedisSku Sku { get; set; }
        /// <summary> The full resource ID of a subnet in a virtual network to deploy the Redis cache in. Example format: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/Microsoft.{Network|ClassicNetwork}/VirtualNetworks/vnet1/subnets/subnet1. </summary>
        public ResourceIdentifier SubnetId { get; set; }
        /// <summary> Static IP address. Optionally, may be specified when deploying a Redis cache inside an existing Azure Virtual Network; auto assigned by default. </summary>
        public IPAddress StaticIP { get; set; }
        /// <summary> Redis instance provisioning status. </summary>
        public RedisProvisioningState? ProvisioningState { get; }
        /// <summary> Redis host name. </summary>
        public string HostName { get; }
        /// <summary> Redis non-SSL port. </summary>
        public int? Port { get; }
        /// <summary> Redis SSL port. </summary>
        public int? SslPort { get; }
        /// <summary> The keys of the Redis cache - not set if this object is not the response to Create or Update redis cache. </summary>
        public RedisAccessKeys AccessKeys { get; }
        /// <summary> List of the linked servers associated with the cache. </summary>
        public IReadOnlyList<SubResource> LinkedServers { get; }
        /// <summary> List of the Redis instances associated with the cache. </summary>
        public IReadOnlyList<RedisInstanceDetails> Instances { get; }
        /// <summary> List of private endpoint connection associated with the specified redis cache. </summary>
        public IReadOnlyList<RedisPrivateEndpointConnectionData> PrivateEndpointConnections { get; }
    }
}
