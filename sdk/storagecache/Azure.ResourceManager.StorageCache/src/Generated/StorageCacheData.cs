// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Net;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.StorageCache.Models;

namespace Azure.ResourceManager.StorageCache
{
    /// <summary> A class representing the StorageCache data model. </summary>
    public partial class StorageCacheData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of StorageCacheData. </summary>
        /// <param name="location"> The location. </param>
        public StorageCacheData(AzureLocation location) : base(location)
        {
            MountAddresses = new ChangeTrackingList<IPAddress>();
            Zones = new ChangeTrackingList<string>();
            PrimingJobs = new ChangeTrackingList<PrimingJob>();
            SpaceAllocation = new ChangeTrackingList<StorageTargetSpaceAllocation>();
        }

        /// <summary> Initializes a new instance of StorageCacheData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> The identity of the cache, if configured. </param>
        /// <param name="sku"> SKU for the Cache. </param>
        /// <param name="cacheSizeGB"> The size of this Cache, in GB. </param>
        /// <param name="health"> Health of the Cache. </param>
        /// <param name="mountAddresses"> Array of IP addresses that can be used by clients mounting this Cache. </param>
        /// <param name="provisioningState"> ARM provisioning state, see https://github.com/Azure/azure-resource-manager-rpc/blob/master/v1.0/Addendum.md#provisioningstate-property. </param>
        /// <param name="subnet"> Subnet used for the Cache. </param>
        /// <param name="upgradeStatus"> Upgrade status of the Cache. </param>
        /// <param name="upgradeSettings"> Upgrade settings of the Cache. </param>
        /// <param name="networkSettings"> Specifies network settings of the cache. </param>
        /// <param name="encryptionSettings"> Specifies encryption settings of the cache. </param>
        /// <param name="securitySettings"> Specifies security settings of the cache. </param>
        /// <param name="directoryServicesSettings"> Specifies Directory Services settings of the cache. </param>
        /// <param name="zones"> Availability zones for resources. This field should only contain a single element in the array. </param>
        /// <param name="primingJobs"> Specifies the priming jobs defined in the cache. </param>
        /// <param name="spaceAllocation"> Specifies the space allocation percentage for each storage target in the cache. </param>
        internal StorageCacheData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ManagedServiceIdentity identity, StorageCacheSkuInfo sku, int? cacheSizeGB, StorageCacheHealth health, IReadOnlyList<IPAddress> mountAddresses, StorageCacheProvisioningStateType? provisioningState, ResourceIdentifier subnet, StorageCacheUpgradeStatus upgradeStatus, StorageCacheUpgradeSettings upgradeSettings, StorageCacheNetworkSettings networkSettings, StorageCacheEncryptionSettings encryptionSettings, StorageCacheSecuritySettings securitySettings, StorageCacheDirectorySettings directoryServicesSettings, IList<string> zones, IReadOnlyList<PrimingJob> primingJobs, IReadOnlyList<StorageTargetSpaceAllocation> spaceAllocation) : base(id, name, resourceType, systemData, tags, location)
        {
            Identity = identity;
            Sku = sku;
            CacheSizeGB = cacheSizeGB;
            Health = health;
            MountAddresses = mountAddresses;
            ProvisioningState = provisioningState;
            Subnet = subnet;
            UpgradeStatus = upgradeStatus;
            UpgradeSettings = upgradeSettings;
            NetworkSettings = networkSettings;
            EncryptionSettings = encryptionSettings;
            SecuritySettings = securitySettings;
            DirectoryServicesSettings = directoryServicesSettings;
            Zones = zones;
            PrimingJobs = primingJobs;
            SpaceAllocation = spaceAllocation;
        }

        /// <summary> The identity of the cache, if configured. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> SKU for the Cache. </summary>
        internal StorageCacheSkuInfo Sku { get; set; }
        /// <summary> SKU name for this Cache. </summary>
        public string SkuName
        {
            get => Sku is null ? default : Sku.Name;
            set
            {
                if (Sku is null)
                    Sku = new StorageCacheSkuInfo();
                Sku.Name = value;
            }
        }

        /// <summary> The size of this Cache, in GB. </summary>
        public int? CacheSizeGB { get; set; }
        /// <summary> Health of the Cache. </summary>
        public StorageCacheHealth Health { get; }
        /// <summary> Array of IP addresses that can be used by clients mounting this Cache. </summary>
        public IReadOnlyList<IPAddress> MountAddresses { get; }
        /// <summary> ARM provisioning state, see https://github.com/Azure/azure-resource-manager-rpc/blob/master/v1.0/Addendum.md#provisioningstate-property. </summary>
        public StorageCacheProvisioningStateType? ProvisioningState { get; }
        /// <summary> Subnet used for the Cache. </summary>
        public ResourceIdentifier Subnet { get; set; }
        /// <summary> Upgrade status of the Cache. </summary>
        public StorageCacheUpgradeStatus UpgradeStatus { get; }
        /// <summary> Upgrade settings of the Cache. </summary>
        public StorageCacheUpgradeSettings UpgradeSettings { get; set; }
        /// <summary> Specifies network settings of the cache. </summary>
        public StorageCacheNetworkSettings NetworkSettings { get; set; }
        /// <summary> Specifies encryption settings of the cache. </summary>
        public StorageCacheEncryptionSettings EncryptionSettings { get; set; }
        /// <summary> Specifies security settings of the cache. </summary>
        internal StorageCacheSecuritySettings SecuritySettings { get; set; }
        /// <summary> NFS access policies defined for this cache. </summary>
        public IList<NfsAccessPolicy> SecurityAccessPolicies
        {
            get
            {
                if (SecuritySettings is null)
                    SecuritySettings = new StorageCacheSecuritySettings();
                return SecuritySettings.AccessPolicies;
            }
        }

        /// <summary> Specifies Directory Services settings of the cache. </summary>
        public StorageCacheDirectorySettings DirectoryServicesSettings { get; set; }
        /// <summary> Availability zones for resources. This field should only contain a single element in the array. </summary>
        public IList<string> Zones { get; }
        /// <summary> Specifies the priming jobs defined in the cache. </summary>
        public IReadOnlyList<PrimingJob> PrimingJobs { get; }
        /// <summary> Specifies the space allocation percentage for each storage target in the cache. </summary>
        public IReadOnlyList<StorageTargetSpaceAllocation> SpaceAllocation { get; }
    }
}
