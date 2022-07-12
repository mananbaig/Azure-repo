// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.NetApp.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Volume resource
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class VolumeGroupVolumeProperties : IResource
    {
        /// <summary>
        /// Initializes a new instance of the VolumeGroupVolumeProperties
        /// class.
        /// </summary>
        public VolumeGroupVolumeProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VolumeGroupVolumeProperties
        /// class.
        /// </summary>
        /// <param name="creationToken">Creation Token or File Path</param>
        /// <param name="usageThreshold">usageThreshold</param>
        /// <param name="subnetId">The Azure Resource URI for a delegated
        /// subnet. Must have the delegation Microsoft.NetApp/volumes</param>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="fileSystemId">FileSystem ID</param>
        /// <param name="serviceLevel">serviceLevel</param>
        /// <param name="exportPolicy">exportPolicy</param>
        /// <param name="protocolTypes">protocolTypes</param>
        /// <param name="provisioningState">Azure lifecycle management</param>
        /// <param name="snapshotId">Snapshot ID</param>
        /// <param name="backupId">Backup ID</param>
        /// <param name="baremetalTenantId">Baremetal Tenant ID</param>
        /// <param name="networkFeatures">Network features</param>
        /// <param name="networkSiblingSetId">Network Sibling Set ID</param>
        /// <param name="storageToNetworkProximity">Storage to Network
        /// Proximity</param>
        /// <param name="mountTargets">mountTargets</param>
        /// <param name="volumeType">What type of volume is this. For
        /// destination volumes in Cross Region Replication, set type to
        /// DataProtection</param>
        /// <param name="dataProtection">DataProtection</param>
        /// <param name="isRestoring">Restoring</param>
        /// <param name="snapshotDirectoryVisible">If enabled (true) the volume
        /// will contain a read-only snapshot directory which provides access
        /// to each of the volume's snapshots (default to true).</param>
        /// <param name="kerberosEnabled">Describe if a volume is
        /// KerberosEnabled. To be use with swagger version 2020-05-01 or
        /// later</param>
        /// <param name="securityStyle">The security style of volume, default
        /// unix, defaults to ntfs for dual protocol or CIFS protocol. Possible
        /// values include: 'ntfs', 'unix'</param>
        /// <param name="smbEncryption">Enables encryption for in-flight smb3
        /// data. Only applicable for SMB/DualProtocol volume. To be used with
        /// swagger version 2020-08-01 or later</param>
        /// <param name="smbContinuouslyAvailable">Enables continuously
        /// available share property for smb volume. Only applicable for SMB
        /// volume</param>
        /// <param name="throughputMibps">Maximum throughput in Mibps that can
        /// be achieved by this volume and this will be accepted as input only
        /// for manual qosType volume</param>
        /// <param name="encryptionKeySource">Source of key used to encrypt
        /// data in volume. Possible values (case-insensitive) are:
        /// 'Microsoft.NetApp'. Possible values include:
        /// 'Microsoft.NetApp'</param>
        /// <param name="ldapEnabled">Specifies whether LDAP is enabled or not
        /// for a given NFS volume.</param>
        /// <param name="coolAccess">Specifies whether Cool Access(tiering) is
        /// enabled for the volume.</param>
        /// <param name="coolnessPeriod">Specifies the number of days after
        /// which data that is not accessed by clients will be tiered.</param>
        /// <param name="unixPermissions">UNIX permissions for NFS volume
        /// accepted in octal 4 digit format. First digit selects the set user
        /// ID(4), set group ID (2) and sticky (1) attributes. Second digit
        /// selects permission for the owner of the file: read (4), write (2)
        /// and execute (1). Third selects permissions for other users in the
        /// same group. the fourth for other users not in the group. 0755 -
        /// gives read/write/execute permissions to owner and read/execute to
        /// group and other users.</param>
        /// <param name="cloneProgress">When a volume is being restored from
        /// another volume's snapshot, will show the percentage completion of
        /// this cloning process. When this value is empty/null there is no
        /// cloning process currently happening on this volume. This value will
        /// update every 5 minutes during cloning.</param>
        /// <param name="avsDataStore">avsDataStore</param>
        /// <param name="isDefaultQuotaEnabled">Specifies if default quota is
        /// enabled for the volume.</param>
        /// <param name="defaultUserQuotaInKiBs">Default user quota for volume
        /// in KiBs. If isDefaultQuotaEnabled is set, the minimum value of 4
        /// KiBs applies .</param>
        /// <param name="defaultGroupQuotaInKiBs">Default group quota for
        /// volume in KiBs. If isDefaultQuotaEnabled is set, the minimum value
        /// of 4 KiBs applies.</param>
        /// <param name="maximumNumberOfFiles">Maximum number of files allowed.
        /// Needs a service request in order to be changed. Only allowed to be
        /// changed if volume quota is more than 4TiB.</param>
        /// <param name="volumeGroupName">Volume Group Name</param>
        /// <param name="capacityPoolResourceId">Pool Resource Id used in case
        /// of creating a volume through volume group</param>
        /// <param name="proximityPlacementGroup">Proximity placement group
        /// associated with the volume</param>
        /// <param name="t2Network">T2 network information</param>
        /// <param name="volumeSpecName">Volume spec name is the application
        /// specific designation or identifier for the particular volume in a
        /// volume group for e.g. data, log</param>
        /// <param name="encrypted">Specifies if the volume is encrypted or
        /// not. Only available on volumes created or updated after
        /// 2022-01-01.</param>
        /// <param name="placementRules">Volume placement rules</param>
        /// <param name="enableSubvolumes">Flag indicating whether subvolume
        /// operations are enabled on the volume. Possible values include:
        /// 'Enabled', 'Disabled'</param>
        public VolumeGroupVolumeProperties(string creationToken, long usageThreshold, string subnetId, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string fileSystemId = default(string), string serviceLevel = default(string), VolumePropertiesExportPolicy exportPolicy = default(VolumePropertiesExportPolicy), IList<string> protocolTypes = default(IList<string>), string provisioningState = default(string), string snapshotId = default(string), string backupId = default(string), string baremetalTenantId = default(string), string networkFeatures = default(string), string networkSiblingSetId = default(string), string storageToNetworkProximity = default(string), IList<MountTargetProperties> mountTargets = default(IList<MountTargetProperties>), string volumeType = default(string), VolumePropertiesDataProtection dataProtection = default(VolumePropertiesDataProtection), bool? isRestoring = default(bool?), bool? snapshotDirectoryVisible = default(bool?), bool? kerberosEnabled = default(bool?), string securityStyle = default(string), bool? smbEncryption = default(bool?), bool? smbContinuouslyAvailable = default(bool?), double? throughputMibps = default(double?), string encryptionKeySource = default(string), bool? ldapEnabled = default(bool?), bool? coolAccess = default(bool?), int? coolnessPeriod = default(int?), string unixPermissions = default(string), int? cloneProgress = default(int?), string avsDataStore = default(string), bool? isDefaultQuotaEnabled = default(bool?), long? defaultUserQuotaInKiBs = default(long?), long? defaultGroupQuotaInKiBs = default(long?), long? maximumNumberOfFiles = default(long?), string volumeGroupName = default(string), string capacityPoolResourceId = default(string), string proximityPlacementGroup = default(string), string t2Network = default(string), string volumeSpecName = default(string), bool? encrypted = default(bool?), IList<PlacementKeyValuePairs> placementRules = default(IList<PlacementKeyValuePairs>), string enableSubvolumes = default(string))
        {
            Id = id;
            Name = name;
            Type = type;
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
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets resource Id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets or sets resource name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets resource type
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets or sets resource tags
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets fileSystem ID
        /// </summary>
        /// <remarks>
        /// Unique FileSystem Identifier.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.fileSystemId")]
        public string FileSystemId { get; private set; }

        /// <summary>
        /// Gets or sets creation Token or File Path
        /// </summary>
        /// <remarks>
        /// A unique file path for the volume. Used when creating mount targets
        /// </remarks>
        [JsonProperty(PropertyName = "properties.creationToken")]
        public string CreationToken { get; set; }

        /// <summary>
        /// Gets or sets serviceLevel
        /// </summary>
        /// <remarks>
        /// Possible values include: 'Standard', 'Premium', 'Ultra',
        /// 'StandardZRS'
        /// </remarks>
        [JsonProperty(PropertyName = "properties.serviceLevel")]
        public string ServiceLevel { get; set; }

        /// <summary>
        /// Gets or sets usageThreshold
        /// </summary>
        /// <remarks>
        /// Maximum storage quota allowed for a file system in bytes. This is a
        /// soft quota used for alerting only. Minimum size is 100 GiB. Upper
        /// limit is 100TiB. Specified in bytes.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.usageThreshold")]
        public long UsageThreshold { get; set; }

        /// <summary>
        /// Gets or sets exportPolicy
        /// </summary>
        /// <remarks>
        /// Set of export policy rules
        /// </remarks>
        [JsonProperty(PropertyName = "properties.exportPolicy")]
        public VolumePropertiesExportPolicy ExportPolicy { get; set; }

        /// <summary>
        /// Gets or sets protocolTypes
        /// </summary>
        /// <remarks>
        /// Set of protocol types, default NFSv3, CIFS for SMB protocol
        /// </remarks>
        [JsonProperty(PropertyName = "properties.protocolTypes")]
        public IList<string> ProtocolTypes { get; set; }

        /// <summary>
        /// Gets azure lifecycle management
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets snapshot ID
        /// </summary>
        /// <remarks>
        /// UUID v4 or resource identifier used to identify the Snapshot.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.snapshotId")]
        public string SnapshotId { get; set; }

        /// <summary>
        /// Gets or sets backup ID
        /// </summary>
        /// <remarks>
        /// UUID v4 or resource identifier used to identify the Backup.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.backupId")]
        public string BackupId { get; set; }

        /// <summary>
        /// Gets baremetal Tenant ID
        /// </summary>
        /// <remarks>
        /// Unique Baremetal Tenant Identifier.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.baremetalTenantId")]
        public string BaremetalTenantId { get; private set; }

        /// <summary>
        /// Gets or sets the Azure Resource URI for a delegated subnet. Must
        /// have the delegation Microsoft.NetApp/volumes
        /// </summary>
        [JsonProperty(PropertyName = "properties.subnetId")]
        public string SubnetId { get; set; }

        /// <summary>
        /// Gets or sets network features
        /// </summary>
        /// <remarks>
        /// Basic network, or Standard features available to the volume.
        /// Possible values include: 'Basic', 'Standard'
        /// </remarks>
        [JsonProperty(PropertyName = "properties.networkFeatures")]
        public string NetworkFeatures { get; set; }

        /// <summary>
        /// Gets network Sibling Set ID
        /// </summary>
        /// <remarks>
        /// Network Sibling Set ID for the the group of volumes sharing
        /// networking resources.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.networkSiblingSetId")]
        public string NetworkSiblingSetId { get; private set; }

        /// <summary>
        /// Gets storage to Network Proximity
        /// </summary>
        /// <remarks>
        /// Provides storage to network proximity information for the volume.
        /// Possible values include: 'Default', 'T1', 'T2'
        /// </remarks>
        [JsonProperty(PropertyName = "properties.storageToNetworkProximity")]
        public string StorageToNetworkProximity { get; private set; }

        /// <summary>
        /// Gets mountTargets
        /// </summary>
        /// <remarks>
        /// List of mount targets
        /// </remarks>
        [JsonProperty(PropertyName = "properties.mountTargets")]
        public IList<MountTargetProperties> MountTargets { get; private set; }

        /// <summary>
        /// Gets or sets what type of volume is this. For destination volumes
        /// in Cross Region Replication, set type to DataProtection
        /// </summary>
        [JsonProperty(PropertyName = "properties.volumeType")]
        public string VolumeType { get; set; }

        /// <summary>
        /// Gets or sets dataProtection
        /// </summary>
        /// <remarks>
        /// DataProtection type volumes include an object containing details of
        /// the replication
        /// </remarks>
        [JsonProperty(PropertyName = "properties.dataProtection")]
        public VolumePropertiesDataProtection DataProtection { get; set; }

        /// <summary>
        /// Gets or sets restoring
        /// </summary>
        [JsonProperty(PropertyName = "properties.isRestoring")]
        public bool? IsRestoring { get; set; }

        /// <summary>
        /// Gets or sets if enabled (true) the volume will contain a read-only
        /// snapshot directory which provides access to each of the volume's
        /// snapshots (default to true).
        /// </summary>
        [JsonProperty(PropertyName = "properties.snapshotDirectoryVisible")]
        public bool? SnapshotDirectoryVisible { get; set; }

        /// <summary>
        /// Gets or sets describe if a volume is KerberosEnabled. To be use
        /// with swagger version 2020-05-01 or later
        /// </summary>
        [JsonProperty(PropertyName = "properties.kerberosEnabled")]
        public bool? KerberosEnabled { get; set; }

        /// <summary>
        /// Gets or sets the security style of volume, default unix, defaults
        /// to ntfs for dual protocol or CIFS protocol. Possible values
        /// include: 'ntfs', 'unix'
        /// </summary>
        [JsonProperty(PropertyName = "properties.securityStyle")]
        public string SecurityStyle { get; set; }

        /// <summary>
        /// Gets or sets enables encryption for in-flight smb3 data. Only
        /// applicable for SMB/DualProtocol volume. To be used with swagger
        /// version 2020-08-01 or later
        /// </summary>
        [JsonProperty(PropertyName = "properties.smbEncryption")]
        public bool? SmbEncryption { get; set; }

        /// <summary>
        /// Gets or sets enables continuously available share property for smb
        /// volume. Only applicable for SMB volume
        /// </summary>
        [JsonProperty(PropertyName = "properties.smbContinuouslyAvailable")]
        public bool? SmbContinuouslyAvailable { get; set; }

        /// <summary>
        /// Gets or sets maximum throughput in Mibps that can be achieved by
        /// this volume and this will be accepted as input only for manual
        /// qosType volume
        /// </summary>
        [JsonProperty(PropertyName = "properties.throughputMibps")]
        public double? ThroughputMibps { get; set; }

        /// <summary>
        /// Gets or sets source of key used to encrypt data in volume. Possible
        /// values (case-insensitive) are: 'Microsoft.NetApp'. Possible values
        /// include: 'Microsoft.NetApp'
        /// </summary>
        [JsonProperty(PropertyName = "properties.encryptionKeySource")]
        public string EncryptionKeySource { get; set; }

        /// <summary>
        /// Gets or sets specifies whether LDAP is enabled or not for a given
        /// NFS volume.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ldapEnabled")]
        public bool? LdapEnabled { get; set; }

        /// <summary>
        /// Gets or sets specifies whether Cool Access(tiering) is enabled for
        /// the volume.
        /// </summary>
        [JsonProperty(PropertyName = "properties.coolAccess")]
        public bool? CoolAccess { get; set; }

        /// <summary>
        /// Gets or sets specifies the number of days after which data that is
        /// not accessed by clients will be tiered.
        /// </summary>
        [JsonProperty(PropertyName = "properties.coolnessPeriod")]
        public int? CoolnessPeriod { get; set; }

        /// <summary>
        /// Gets or sets UNIX permissions for NFS volume accepted in octal 4
        /// digit format. First digit selects the set user ID(4), set group ID
        /// (2) and sticky (1) attributes. Second digit selects permission for
        /// the owner of the file: read (4), write (2) and execute (1). Third
        /// selects permissions for other users in the same group. the fourth
        /// for other users not in the group. 0755 - gives read/write/execute
        /// permissions to owner and read/execute to group and other users.
        /// </summary>
        [JsonProperty(PropertyName = "properties.unixPermissions")]
        public string UnixPermissions { get; set; }

        /// <summary>
        /// Gets when a volume is being restored from another volume's
        /// snapshot, will show the percentage completion of this cloning
        /// process. When this value is empty/null there is no cloning process
        /// currently happening on this volume. This value will update every 5
        /// minutes during cloning.
        /// </summary>
        [JsonProperty(PropertyName = "properties.cloneProgress")]
        public int? CloneProgress { get; private set; }

        /// <summary>
        /// Gets or sets avsDataStore
        /// </summary>
        /// <remarks>
        /// Specifies whether the volume is enabled for Azure VMware Solution
        /// (AVS) datastore purpose. Possible values include: 'Enabled',
        /// 'Disabled'
        /// </remarks>
        [JsonProperty(PropertyName = "properties.avsDataStore")]
        public string AvsDataStore { get; set; }

        /// <summary>
        /// Gets or sets specifies if default quota is enabled for the volume.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isDefaultQuotaEnabled")]
        public bool? IsDefaultQuotaEnabled { get; set; }

        /// <summary>
        /// Gets or sets default user quota for volume in KiBs. If
        /// isDefaultQuotaEnabled is set, the minimum value of 4 KiBs applies .
        /// </summary>
        [JsonProperty(PropertyName = "properties.defaultUserQuotaInKiBs")]
        public long? DefaultUserQuotaInKiBs { get; set; }

        /// <summary>
        /// Gets or sets default group quota for volume in KiBs. If
        /// isDefaultQuotaEnabled is set, the minimum value of 4 KiBs applies.
        /// </summary>
        [JsonProperty(PropertyName = "properties.defaultGroupQuotaInKiBs")]
        public long? DefaultGroupQuotaInKiBs { get; set; }

        /// <summary>
        /// Gets maximum number of files allowed. Needs a service request in
        /// order to be changed. Only allowed to be changed if volume quota is
        /// more than 4TiB.
        /// </summary>
        [JsonProperty(PropertyName = "properties.maximumNumberOfFiles")]
        public long? MaximumNumberOfFiles { get; private set; }

        /// <summary>
        /// Gets volume Group Name
        /// </summary>
        [JsonProperty(PropertyName = "properties.volumeGroupName")]
        public string VolumeGroupName { get; private set; }

        /// <summary>
        /// Gets or sets pool Resource Id used in case of creating a volume
        /// through volume group
        /// </summary>
        [JsonProperty(PropertyName = "properties.capacityPoolResourceId")]
        public string CapacityPoolResourceId { get; set; }

        /// <summary>
        /// Gets or sets proximity placement group associated with the volume
        /// </summary>
        [JsonProperty(PropertyName = "properties.proximityPlacementGroup")]
        public string ProximityPlacementGroup { get; set; }

        /// <summary>
        /// Gets T2 network information
        /// </summary>
        [JsonProperty(PropertyName = "properties.t2Network")]
        public string T2Network { get; private set; }

        /// <summary>
        /// Gets or sets volume spec name is the application specific
        /// designation or identifier for the particular volume in a volume
        /// group for e.g. data, log
        /// </summary>
        [JsonProperty(PropertyName = "properties.volumeSpecName")]
        public string VolumeSpecName { get; set; }

        /// <summary>
        /// Gets specifies if the volume is encrypted or not. Only available on
        /// volumes created or updated after 2022-01-01.
        /// </summary>
        [JsonProperty(PropertyName = "properties.encrypted")]
        public bool? Encrypted { get; private set; }

        /// <summary>
        /// Gets or sets volume placement rules
        /// </summary>
        /// <remarks>
        /// Application specific placement rules for the particular volume
        /// </remarks>
        [JsonProperty(PropertyName = "properties.placementRules")]
        public IList<PlacementKeyValuePairs> PlacementRules { get; set; }

        /// <summary>
        /// Gets or sets flag indicating whether subvolume operations are
        /// enabled on the volume. Possible values include: 'Enabled',
        /// 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.enableSubvolumes")]
        public string EnableSubvolumes { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (CreationToken == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CreationToken");
            }
            if (SubnetId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SubnetId");
            }
            if (FileSystemId != null)
            {
                if (FileSystemId.Length > 36)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "FileSystemId", 36);
                }
                if (FileSystemId.Length < 36)
                {
                    throw new ValidationException(ValidationRules.MinLength, "FileSystemId", 36);
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(FileSystemId, "^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "FileSystemId", "^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}$");
                }
            }
            if (CreationToken != null)
            {
                if (CreationToken.Length > 80)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "CreationToken", 80);
                }
                if (CreationToken.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "CreationToken", 1);
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(CreationToken, "^[a-zA-Z][a-zA-Z0-9\\-]{0,79}$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "CreationToken", "^[a-zA-Z][a-zA-Z0-9\\-]{0,79}$");
                }
            }
            if (UsageThreshold > 109951162777600)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "UsageThreshold", 109951162777600);
            }
            if (UsageThreshold < 107374182400)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "UsageThreshold", 107374182400);
            }
            if (SnapshotId != null)
            {
                if (SnapshotId.Length > 36)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "SnapshotId", 36);
                }
                if (SnapshotId.Length < 36)
                {
                    throw new ValidationException(ValidationRules.MinLength, "SnapshotId", 36);
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(SnapshotId, "^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}|(\\\\?([^\\/]*[\\/])*)([^\\/]+)$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "SnapshotId", "^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}|(\\\\?([^\\/]*[\\/])*)([^\\/]+)$");
                }
            }
            if (BackupId != null)
            {
                if (BackupId.Length > 36)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "BackupId", 36);
                }
                if (BackupId.Length < 36)
                {
                    throw new ValidationException(ValidationRules.MinLength, "BackupId", 36);
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(BackupId, "^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}|(\\\\?([^\\/]*[\\/])*)([^\\/]+)$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "BackupId", "^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}|(\\\\?([^\\/]*[\\/])*)([^\\/]+)$");
                }
            }
            if (NetworkSiblingSetId != null)
            {
                if (NetworkSiblingSetId.Length > 36)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "NetworkSiblingSetId", 36);
                }
                if (NetworkSiblingSetId.Length < 36)
                {
                    throw new ValidationException(ValidationRules.MinLength, "NetworkSiblingSetId", 36);
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(NetworkSiblingSetId, "^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "NetworkSiblingSetId", "^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}$");
                }
            }
            if (MountTargets != null)
            {
                foreach (var element in MountTargets)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (DataProtection != null)
            {
                DataProtection.Validate();
            }
            if (CoolnessPeriod != null)
            {
                if (CoolnessPeriod > 63)
                {
                    throw new ValidationException(ValidationRules.InclusiveMaximum, "CoolnessPeriod", 63);
                }
                if (CoolnessPeriod < 7)
                {
                    throw new ValidationException(ValidationRules.InclusiveMinimum, "CoolnessPeriod", 7);
                }
            }
            if (UnixPermissions != null)
            {
                if (UnixPermissions.Length > 4)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "UnixPermissions", 4);
                }
                if (UnixPermissions.Length < 4)
                {
                    throw new ValidationException(ValidationRules.MinLength, "UnixPermissions", 4);
                }
            }
            if (PlacementRules != null)
            {
                foreach (var element1 in PlacementRules)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
        }
    }
}
