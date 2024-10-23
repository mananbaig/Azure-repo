// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.Redis;

/// <summary>
/// RedisLinkedServerWithProperty.
/// </summary>
public partial class RedisLinkedServerWithProperty : ProvisionableResource
{
    /// <summary>
    /// The name of the linked server that is being added to the Redis cache.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Fully qualified resourceId of the linked redis cache.
    /// </summary>
    public BicepValue<ResourceIdentifier> LinkedRedisCacheId { get => _linkedRedisCacheId; set => _linkedRedisCacheId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _linkedRedisCacheId;

    /// <summary>
    /// Location of the linked redis cache.
    /// </summary>
    public BicepValue<AzureLocation> LinkedRedisCacheLocation { get => _linkedRedisCacheLocation; set => _linkedRedisCacheLocation.Assign(value); }
    private readonly BicepValue<AzureLocation> _linkedRedisCacheLocation;

    /// <summary>
    /// Role of the linked server.
    /// </summary>
    public BicepValue<RedisLinkedServerRole> ServerRole { get => _serverRole; set => _serverRole.Assign(value); }
    private readonly BicepValue<RedisLinkedServerRole> _serverRole;

    /// <summary>
    /// The unchanging DNS name which will always point to current geo-primary
    /// cache among the linked redis caches for seamless Geo Failover
    /// experience.
    /// </summary>
    public BicepValue<string> GeoReplicatedPrimaryHostName { get => _geoReplicatedPrimaryHostName; }
    private readonly BicepValue<string> _geoReplicatedPrimaryHostName;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// The changing DNS name that resolves to the current geo-primary cache
    /// among the linked redis caches before or after the Geo Failover.
    /// </summary>
    public BicepValue<string> PrimaryHostName { get => _primaryHostName; }
    private readonly BicepValue<string> _primaryHostName;

    /// <summary>
    /// Terminal state of the link between primary and secondary redis cache.
    /// </summary>
    public BicepValue<string> ProvisioningState { get => _provisioningState; }
    private readonly BicepValue<string> _provisioningState;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent RedisResource.
    /// </summary>
    public RedisResource? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<RedisResource> _parent;

    /// <summary>
    /// Creates a new RedisLinkedServerWithProperty.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the RedisLinkedServerWithProperty
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the RedisLinkedServerWithProperty.</param>
    public RedisLinkedServerWithProperty(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.Cache/redis/linkedServers", resourceVersion ?? "2024-03-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _linkedRedisCacheId = BicepValue<ResourceIdentifier>.DefineProperty(this, "LinkedRedisCacheId", ["properties", "linkedRedisCacheId"], isRequired: true);
        _linkedRedisCacheLocation = BicepValue<AzureLocation>.DefineProperty(this, "LinkedRedisCacheLocation", ["properties", "linkedRedisCacheLocation"], isRequired: true);
        _serverRole = BicepValue<RedisLinkedServerRole>.DefineProperty(this, "ServerRole", ["properties", "serverRole"], isRequired: true);
        _geoReplicatedPrimaryHostName = BicepValue<string>.DefineProperty(this, "GeoReplicatedPrimaryHostName", ["properties", "geoReplicatedPrimaryHostName"], isOutput: true);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _primaryHostName = BicepValue<string>.DefineProperty(this, "PrimaryHostName", ["properties", "primaryHostName"], isOutput: true);
        _provisioningState = BicepValue<string>.DefineProperty(this, "ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<RedisResource>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported RedisLinkedServerWithProperty resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-03-01.
        /// </summary>
        public static readonly string V2024_03_01 = "2024-03-01";

        /// <summary>
        /// 2023-08-01.
        /// </summary>
        public static readonly string V2023_08_01 = "2023-08-01";

        /// <summary>
        /// 2023-04-01.
        /// </summary>
        public static readonly string V2023_04_01 = "2023-04-01";

        /// <summary>
        /// 2022-06-01.
        /// </summary>
        public static readonly string V2022_06_01 = "2022-06-01";

        /// <summary>
        /// 2022-05-01.
        /// </summary>
        public static readonly string V2022_05_01 = "2022-05-01";

        /// <summary>
        /// 2021-06-01.
        /// </summary>
        public static readonly string V2021_06_01 = "2021-06-01";

        /// <summary>
        /// 2020-12-01.
        /// </summary>
        public static readonly string V2020_12_01 = "2020-12-01";

        /// <summary>
        /// 2020-06-01.
        /// </summary>
        public static readonly string V2020_06_01 = "2020-06-01";

        /// <summary>
        /// 2019-07-01.
        /// </summary>
        public static readonly string V2019_07_01 = "2019-07-01";

        /// <summary>
        /// 2018-03-01.
        /// </summary>
        public static readonly string V2018_03_01 = "2018-03-01";

        /// <summary>
        /// 2017-10-01.
        /// </summary>
        public static readonly string V2017_10_01 = "2017-10-01";

        /// <summary>
        /// 2017-02-01.
        /// </summary>
        public static readonly string V2017_02_01 = "2017-02-01";

        /// <summary>
        /// 2016-04-01.
        /// </summary>
        public static readonly string V2016_04_01 = "2016-04-01";

        /// <summary>
        /// 2015-08-01.
        /// </summary>
        public static readonly string V2015_08_01 = "2015-08-01";

        /// <summary>
        /// 2015-03-01.
        /// </summary>
        public static readonly string V2015_03_01 = "2015-03-01";

        /// <summary>
        /// 2014-04-01.
        /// </summary>
        public static readonly string V2014_04_01 = "2014-04-01";
    }

    /// <summary>
    /// Creates a reference to an existing RedisLinkedServerWithProperty.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the RedisLinkedServerWithProperty
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the RedisLinkedServerWithProperty.</param>
    /// <returns>The existing RedisLinkedServerWithProperty resource.</returns>
    public static RedisLinkedServerWithProperty FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
