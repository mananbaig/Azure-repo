// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Volume resource. </summary>
    public partial class VolumeGroupVolumeProperties
    {
        /// <summary> Initializes a new instance of VolumeGroupVolumeProperties. </summary>
        /// <param name="creationToken"> A unique file path for the volume. Used when creating mount targets. </param>
        /// <param name="usageThreshold"> Maximum storage quota allowed for a file system in bytes. This is a soft quota used for alerting only. Minimum size is 100 GiB. Upper limit is 100TiB. Specified in bytes. </param>
        /// <param name="subnetId"> The Azure Resource URI for a delegated subnet. Must have the delegation Microsoft.NetApp/volumes. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="creationToken"/> or <paramref name="subnetId"/> is null. </exception>
        public VolumeGroupVolumeProperties(string creationToken, long usageThreshold, string subnetId)
        {
            if (creationToken == null)
            {
                throw new ArgumentNullException(nameof(creationToken));
            }
            if (subnetId == null)
            {
                throw new ArgumentNullException(nameof(subnetId));
            }

            Tags = new ChangeTrackingDictionary<string, string>();
            CreationToken = creationToken;
            UsageThreshold = usageThreshold;
            ProtocolTypes = new ChangeTrackingList<string>();
            SubnetId = subnetId;
            MountTargets = new ChangeTrackingList<MountTargetProperties>();
            PlacementRules = new ChangeTrackingList<PlacementKeyValuePairs>();
        }

        /// <summary> Initializes a new instance of VolumeGroupVolumeProperties. </summary>
        /// <param name="id"> Resource Id. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="fileSystemId"> Unique FileSystem Identifier. </param>
        /// <param name="creationToken"> A unique file path for the volume. Used when creating mount targets. </param>
        /// <param name="serviceLevel"> The service level of the file system. </param>
        /// <param name="usageThreshold"> Maximum storage quota allowed for a file system in bytes. This is a soft quota used for alerting only. Minimum size is 100 GiB. Upper limit is 100TiB. Specified in bytes. </param>
        /// <param name="exportPolicy"> Set of export policy rules. </param>
        /// <param name="protocolTypes"> Set of protocol types, default NFSv3, CIFS for SMB protocol. </param>
        /// <param name="provisioningState"> Azure lifecycle management. </param>
        /// <param name="snapshotId"> UUID v4 or resource identifier used to identify the Snapshot. </param>
        /// <param name="backupId"> UUID v4 or resource identifier used to identify the Backup. </param>
        /// <param name="baremetalTenantId"> Unique Baremetal Tenant Identifier. </param>
        /// <param name="subnetId"> The Azure Resource URI for a delegated subnet. Must have the delegation Microsoft.NetApp/volumes. </param>
        /// <param name="networkFeatures"> Basic network, or Standard features available to the volume. </param>
        /// <param name="networkSiblingSetId"> Network Sibling Set ID for the the group of volumes sharing networking resources. </param>
        /// <param name="storageToNetworkProximity"> Provides storage to network proximity information for the volume. </param>
        /// <param name="mountTargets"> List of mount targets. </param>
        /// <param name="volumeType"> What type of volume is this. For destination volumes in Cross Region Replication, set type to DataProtection. </param>
        /// <param name="dataProtection"> DataProtection type volumes include an object containing details of the replication. </param>
        /// <param name="isRestoring"> Restoring. </param>
        /// <param name="snapshotDirectoryVisible"> If enabled (true) the volume will contain a read-only snapshot directory which provides access to each of the volume&apos;s snapshots (default to true). </param>
        /// <param name="kerberosEnabled"> Describe if a volume is KerberosEnabled. To be use with swagger version 2020-05-01 or later. </param>
        /// <param name="securityStyle"> The security style of volume, default unix, defaults to ntfs for dual protocol or CIFS protocol. </param>
        /// <param name="smbEncryption"> Enables encryption for in-flight smb3 data. Only applicable for SMB/DualProtocol volume. To be used with swagger version 2020-08-01 or later. </param>
        /// <param name="smbContinuouslyAvailable"> Enables continuously available share property for smb volume. Only applicable for SMB volume. </param>
        /// <param name="throughputMibps"> Maximum throughput in MiB/s that can be achieved by this volume and this will be accepted as input only for manual qosType volume. </param>
        /// <param name="encryptionKeySource"> Source of key used to encrypt data in volume. Applicable if NetApp account has encryption.keySource = &apos;Microsoft.KeyVault&apos;. Possible values (case-insensitive) are: &apos;Microsoft.NetApp, Microsoft.KeyVault&apos;. </param>
        /// <param name="keyVaultPrivateEndpointResourceId"> The resource ID of private endpoint for KeyVault. It must reside in the same VNET as the volume. Only applicable if encryptionKeySource = &apos;Microsoft.KeyVault&apos;. </param>
        /// <param name="ldapEnabled"> Specifies whether LDAP is enabled or not for a given NFS volume. </param>
        /// <param name="coolAccess"> Specifies whether Cool Access(tiering) is enabled for the volume. </param>
        /// <param name="coolnessPeriod"> Specifies the number of days after which data that is not accessed by clients will be tiered. </param>
        /// <param name="unixPermissions"> UNIX permissions for NFS volume accepted in octal 4 digit format. First digit selects the set user ID(4), set group ID (2) and sticky (1) attributes. Second digit selects permission for the owner of the file: read (4), write (2) and execute (1). Third selects permissions for other users in the same group. the fourth for other users not in the group. 0755 - gives read/write/execute permissions to owner and read/execute to group and other users. </param>
        /// <param name="cloneProgress"> When a volume is being restored from another volume&apos;s snapshot, will show the percentage completion of this cloning process. When this value is empty/null there is no cloning process currently happening on this volume. This value will update every 5 minutes during cloning. </param>
        /// <param name="avsDataStore"> Specifies whether the volume is enabled for Azure VMware Solution (AVS) datastore purpose. </param>
        /// <param name="isDefaultQuotaEnabled"> Specifies if default quota is enabled for the volume. </param>
        /// <param name="defaultUserQuotaInKiBs"> Default user quota for volume in KiBs. If isDefaultQuotaEnabled is set, the minimum value of 4 KiBs applies . </param>
        /// <param name="defaultGroupQuotaInKiBs"> Default group quota for volume in KiBs. If isDefaultQuotaEnabled is set, the minimum value of 4 KiBs applies. </param>
        /// <param name="maximumNumberOfFiles"> Maximum number of files allowed. Needs a service request in order to be changed. Only allowed to be changed if volume quota is more than 4TiB. </param>
        /// <param name="volumeGroupName"> Volume Group Name. </param>
        /// <param name="capacityPoolResourceId"> Pool Resource Id used in case of creating a volume through volume group. </param>
        /// <param name="proximityPlacementGroup"> Proximity placement group associated with the volume. </param>
        /// <param name="t2Network"> T2 network information. </param>
        /// <param name="volumeSpecName"> Volume spec name is the application specific designation or identifier for the particular volume in a volume group for e.g. data, log. </param>
        /// <param name="encrypted"> Specifies if the volume is encrypted or not. Only available on volumes created or updated after 2022-01-01. </param>
        /// <param name="placementRules"> Application specific placement rules for the particular volume. </param>
        /// <param name="enableSubvolumes"> Flag indicating whether subvolume operations are enabled on the volume. </param>
        internal VolumeGroupVolumeProperties(string id, string name, string resourceType, IDictionary<string, string> tags, string fileSystemId, string creationToken, ServiceLevel? serviceLevel, long usageThreshold, VolumePropertiesExportPolicy exportPolicy, IList<string> protocolTypes, string provisioningState, string snapshotId, string backupId, string baremetalTenantId, string subnetId, NetworkFeature? networkFeatures, string networkSiblingSetId, VolumeStorageToNetworkProximity? storageToNetworkProximity, IReadOnlyList<MountTargetProperties> mountTargets, string volumeType, VolumePropertiesDataProtection dataProtection, bool? isRestoring, bool? snapshotDirectoryVisible, bool? kerberosEnabled, SecurityStyle? securityStyle, bool? smbEncryption, bool? smbContinuouslyAvailable, float? throughputMibps, EncryptionKeySource? encryptionKeySource, string keyVaultPrivateEndpointResourceId, bool? ldapEnabled, bool? coolAccess, int? coolnessPeriod, string unixPermissions, int? cloneProgress, AvsDataStore? avsDataStore, bool? isDefaultQuotaEnabled, long? defaultUserQuotaInKiBs, long? defaultGroupQuotaInKiBs, long? maximumNumberOfFiles, string volumeGroupName, string capacityPoolResourceId, string proximityPlacementGroup, string t2Network, string volumeSpecName, bool? encrypted, IList<PlacementKeyValuePairs> placementRules, EnableSubvolume? enableSubvolumes)
        {
            Id = id;
            Name = name;
            ResourceType = resourceType;
            Tags = tags;
            FileSystemId = fileSystemId;
            CreationToken = creationToken;
            ServiceLevel = serviceLevel;
            UsageThreshold = usageThreshold;
            ExportPolicy = exportPolicy;
            ProtocolTypes = protocolTypes;
            ProvisioningState = provisioningState;
            SnapshotId = snapshotId;
            BackupId = backupId;
            BaremetalTenantId = baremetalTenantId;
            SubnetId = subnetId;
            NetworkFeatures = networkFeatures;
            NetworkSiblingSetId = networkSiblingSetId;
            StorageToNetworkProximity = storageToNetworkProximity;
            MountTargets = mountTargets;
            VolumeType = volumeType;
            DataProtection = dataProtection;
            IsRestoring = isRestoring;
            SnapshotDirectoryVisible = snapshotDirectoryVisible;
            KerberosEnabled = kerberosEnabled;
            SecurityStyle = securityStyle;
            SmbEncryption = smbEncryption;
            SmbContinuouslyAvailable = smbContinuouslyAvailable;
            ThroughputMibps = throughputMibps;
            EncryptionKeySource = encryptionKeySource;
            KeyVaultPrivateEndpointResourceId = keyVaultPrivateEndpointResourceId;
            LdapEnabled = ldapEnabled;
            CoolAccess = coolAccess;
            CoolnessPeriod = coolnessPeriod;
            UnixPermissions = unixPermissions;
            CloneProgress = cloneProgress;
            AvsDataStore = avsDataStore;
            IsDefaultQuotaEnabled = isDefaultQuotaEnabled;
            DefaultUserQuotaInKiBs = defaultUserQuotaInKiBs;
            DefaultGroupQuotaInKiBs = defaultGroupQuotaInKiBs;
            MaximumNumberOfFiles = maximumNumberOfFiles;
            VolumeGroupName = volumeGroupName;
            CapacityPoolResourceId = capacityPoolResourceId;
            ProximityPlacementGroup = proximityPlacementGroup;
            T2Network = t2Network;
            VolumeSpecName = volumeSpecName;
            Encrypted = encrypted;
            PlacementRules = placementRules;
            EnableSubvolumes = enableSubvolumes;
        }

        /// <summary> Resource Id. </summary>
        public string Id { get; }
        /// <summary> Resource name. </summary>
        public string Name { get; set; }
        /// <summary> Resource type. </summary>
        public string ResourceType { get; }
        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Unique FileSystem Identifier. </summary>
        public string FileSystemId { get; }
        /// <summary> A unique file path for the volume. Used when creating mount targets. </summary>
        public string CreationToken { get; set; }
        /// <summary> The service level of the file system. </summary>
        public ServiceLevel? ServiceLevel { get; set; }
        /// <summary> Maximum storage quota allowed for a file system in bytes. This is a soft quota used for alerting only. Minimum size is 100 GiB. Upper limit is 100TiB. Specified in bytes. </summary>
        public long UsageThreshold { get; set; }
        /// <summary> Set of export policy rules. </summary>
        internal VolumePropertiesExportPolicy ExportPolicy { get; set; }
        /// <summary> Export policy rule. </summary>
        public IList<ExportPolicyRule> ExportRules
        {
            get
            {
                if (ExportPolicy is null)
                    ExportPolicy = new VolumePropertiesExportPolicy();
                return ExportPolicy.Rules;
            }
        }

        /// <summary> Set of protocol types, default NFSv3, CIFS for SMB protocol. </summary>
        public IList<string> ProtocolTypes { get; }
        /// <summary> Azure lifecycle management. </summary>
        public string ProvisioningState { get; }
        /// <summary> UUID v4 or resource identifier used to identify the Snapshot. </summary>
        public string SnapshotId { get; set; }
        /// <summary> UUID v4 or resource identifier used to identify the Backup. </summary>
        public string BackupId { get; set; }
        /// <summary> Unique Baremetal Tenant Identifier. </summary>
        public string BaremetalTenantId { get; }
        /// <summary> The Azure Resource URI for a delegated subnet. Must have the delegation Microsoft.NetApp/volumes. </summary>
        public string SubnetId { get; set; }
        /// <summary> Basic network, or Standard features available to the volume. </summary>
        public NetworkFeature? NetworkFeatures { get; set; }
        /// <summary> Network Sibling Set ID for the the group of volumes sharing networking resources. </summary>
        public string NetworkSiblingSetId { get; }
        /// <summary> Provides storage to network proximity information for the volume. </summary>
        public VolumeStorageToNetworkProximity? StorageToNetworkProximity { get; }
        /// <summary> List of mount targets. </summary>
        public IReadOnlyList<MountTargetProperties> MountTargets { get; }
        /// <summary> What type of volume is this. For destination volumes in Cross Region Replication, set type to DataProtection. </summary>
        public string VolumeType { get; set; }
        /// <summary> DataProtection type volumes include an object containing details of the replication. </summary>
        public VolumePropertiesDataProtection DataProtection { get; set; }
        /// <summary> Restoring. </summary>
        public bool? IsRestoring { get; set; }
        /// <summary> If enabled (true) the volume will contain a read-only snapshot directory which provides access to each of the volume&apos;s snapshots (default to true). </summary>
        public bool? SnapshotDirectoryVisible { get; set; }
        /// <summary> Describe if a volume is KerberosEnabled. To be use with swagger version 2020-05-01 or later. </summary>
        public bool? KerberosEnabled { get; set; }
        /// <summary> The security style of volume, default unix, defaults to ntfs for dual protocol or CIFS protocol. </summary>
        public SecurityStyle? SecurityStyle { get; set; }
        /// <summary> Enables encryption for in-flight smb3 data. Only applicable for SMB/DualProtocol volume. To be used with swagger version 2020-08-01 or later. </summary>
        public bool? SmbEncryption { get; set; }
        /// <summary> Enables continuously available share property for smb volume. Only applicable for SMB volume. </summary>
        public bool? SmbContinuouslyAvailable { get; set; }
        /// <summary> Maximum throughput in MiB/s that can be achieved by this volume and this will be accepted as input only for manual qosType volume. </summary>
        public float? ThroughputMibps { get; set; }
        /// <summary> Source of key used to encrypt data in volume. Applicable if NetApp account has encryption.keySource = &apos;Microsoft.KeyVault&apos;. Possible values (case-insensitive) are: &apos;Microsoft.NetApp, Microsoft.KeyVault&apos;. </summary>
        public EncryptionKeySource? EncryptionKeySource { get; set; }
        /// <summary> The resource ID of private endpoint for KeyVault. It must reside in the same VNET as the volume. Only applicable if encryptionKeySource = &apos;Microsoft.KeyVault&apos;. </summary>
        public string KeyVaultPrivateEndpointResourceId { get; set; }
        /// <summary> Specifies whether LDAP is enabled or not for a given NFS volume. </summary>
        public bool? LdapEnabled { get; set; }
        /// <summary> Specifies whether Cool Access(tiering) is enabled for the volume. </summary>
        public bool? CoolAccess { get; set; }
        /// <summary> Specifies the number of days after which data that is not accessed by clients will be tiered. </summary>
        public int? CoolnessPeriod { get; set; }
        /// <summary> UNIX permissions for NFS volume accepted in octal 4 digit format. First digit selects the set user ID(4), set group ID (2) and sticky (1) attributes. Second digit selects permission for the owner of the file: read (4), write (2) and execute (1). Third selects permissions for other users in the same group. the fourth for other users not in the group. 0755 - gives read/write/execute permissions to owner and read/execute to group and other users. </summary>
        public string UnixPermissions { get; set; }
        /// <summary> When a volume is being restored from another volume&apos;s snapshot, will show the percentage completion of this cloning process. When this value is empty/null there is no cloning process currently happening on this volume. This value will update every 5 minutes during cloning. </summary>
        public int? CloneProgress { get; }
        /// <summary> Specifies whether the volume is enabled for Azure VMware Solution (AVS) datastore purpose. </summary>
        public AvsDataStore? AvsDataStore { get; set; }
        /// <summary> Specifies if default quota is enabled for the volume. </summary>
        public bool? IsDefaultQuotaEnabled { get; set; }
        /// <summary> Default user quota for volume in KiBs. If isDefaultQuotaEnabled is set, the minimum value of 4 KiBs applies . </summary>
        public long? DefaultUserQuotaInKiBs { get; set; }
        /// <summary> Default group quota for volume in KiBs. If isDefaultQuotaEnabled is set, the minimum value of 4 KiBs applies. </summary>
        public long? DefaultGroupQuotaInKiBs { get; set; }
        /// <summary> Maximum number of files allowed. Needs a service request in order to be changed. Only allowed to be changed if volume quota is more than 4TiB. </summary>
        public long? MaximumNumberOfFiles { get; }
        /// <summary> Volume Group Name. </summary>
        public string VolumeGroupName { get; }
        /// <summary> Pool Resource Id used in case of creating a volume through volume group. </summary>
        public string CapacityPoolResourceId { get; set; }
        /// <summary> Proximity placement group associated with the volume. </summary>
        public string ProximityPlacementGroup { get; set; }
        /// <summary> T2 network information. </summary>
        public string T2Network { get; }
        /// <summary> Volume spec name is the application specific designation or identifier for the particular volume in a volume group for e.g. data, log. </summary>
        public string VolumeSpecName { get; set; }
        /// <summary> Specifies if the volume is encrypted or not. Only available on volumes created or updated after 2022-01-01. </summary>
        public bool? Encrypted { get; }
        /// <summary> Application specific placement rules for the particular volume. </summary>
        public IList<PlacementKeyValuePairs> PlacementRules { get; }
        /// <summary> Flag indicating whether subvolume operations are enabled on the volume. </summary>
        public EnableSubvolume? EnableSubvolumes { get; set; }
    }
}
