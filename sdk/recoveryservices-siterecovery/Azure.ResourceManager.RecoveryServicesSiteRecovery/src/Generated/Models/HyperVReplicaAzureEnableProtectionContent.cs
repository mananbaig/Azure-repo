// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> HyperVReplicaAzure specific enable protection input. </summary>
    public partial class HyperVReplicaAzureEnableProtectionContent : EnableProtectionProviderSpecificContent
    {
        /// <summary> Initializes a new instance of <see cref="HyperVReplicaAzureEnableProtectionContent"/>. </summary>
        public HyperVReplicaAzureEnableProtectionContent()
        {
            DisksToInclude = new ChangeTrackingList<string>();
            DisksToIncludeForManagedDisks = new ChangeTrackingList<HyperVReplicaAzureDiskDetails>();
            TargetVmTags = new ChangeTrackingDictionary<string, string>();
            SeedManagedDiskTags = new ChangeTrackingDictionary<string, string>();
            TargetManagedDiskTags = new ChangeTrackingDictionary<string, string>();
            TargetNicTags = new ChangeTrackingDictionary<string, string>();
            InstanceType = "HyperVReplicaAzure";
        }

        /// <summary> Initializes a new instance of <see cref="HyperVReplicaAzureEnableProtectionContent"/>. </summary>
        /// <param name="instanceType"> The class type. </param>
        /// <param name="hyperVHostVmId"> The Hyper-V host VM Id. </param>
        /// <param name="vmName"> The VM Name. </param>
        /// <param name="osType"> The OS type associated with VM. </param>
        /// <param name="vhdId"> The OS disk VHD id associated with VM. </param>
        /// <param name="targetStorageAccountId"> The storage account Id. </param>
        /// <param name="targetAzureNetworkId"> The selected target Azure network Id. </param>
        /// <param name="targetAzureSubnetId"> The selected target Azure subnet Id. </param>
        /// <param name="enableRdpOnTargetOption"> The selected option to enable RDP\SSH on target vm after failover. String value of SrsDataContract.EnableRDPOnTargetOption enum. </param>
        /// <param name="targetAzureVmName"> The target azure VM Name. </param>
        /// <param name="logStorageAccountId"> The storage account to be used for logging during replication. </param>
        /// <param name="disksToInclude"> The list of VHD Ids of disks to be protected. </param>
        /// <param name="targetAzureV1ResourceGroupId"> The Id of the target resource group (for classic deployment) in which the failover VM is to be created. </param>
        /// <param name="targetAzureV2ResourceGroupId"> The Id of the target resource group (for resource manager deployment) in which the failover VM is to be created. </param>
        /// <param name="useManagedDisks"> A value indicating whether managed disks should be used during failover. </param>
        /// <param name="targetAvailabilitySetId"> The target availability set ARM Id for resource manager deployment. </param>
        /// <param name="targetAvailabilityZone"> The target availability zone. </param>
        /// <param name="licenseType"> License type. </param>
        /// <param name="sqlServerLicenseType"> The SQL Server license type. </param>
        /// <param name="targetVmSize"> The target VM size. </param>
        /// <param name="targetProximityPlacementGroupId"> The proximity placement group ARM Id. </param>
        /// <param name="useManagedDisksForReplication"> A value indicating whether managed disks should be used during replication. </param>
        /// <param name="diskType"> The DiskType. </param>
        /// <param name="disksToIncludeForManagedDisks"> The disks to include list for managed disks. </param>
        /// <param name="diskEncryptionSetId"> The DiskEncryptionSet ARM Id. </param>
        /// <param name="targetVmTags"> The target VM tags. </param>
        /// <param name="seedManagedDiskTags"> The tags for the seed managed disks. </param>
        /// <param name="targetManagedDiskTags"> The tags for the target managed disks. </param>
        /// <param name="targetNicTags"> The tags for the target NICs. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HyperVReplicaAzureEnableProtectionContent(string instanceType, string hyperVHostVmId, string vmName, string osType, string vhdId, ResourceIdentifier targetStorageAccountId, ResourceIdentifier targetAzureNetworkId, ResourceIdentifier targetAzureSubnetId, string enableRdpOnTargetOption, string targetAzureVmName, ResourceIdentifier logStorageAccountId, IList<string> disksToInclude, ResourceIdentifier targetAzureV1ResourceGroupId, ResourceIdentifier targetAzureV2ResourceGroupId, string useManagedDisks, ResourceIdentifier targetAvailabilitySetId, string targetAvailabilityZone, SiteRecoveryLicenseType? licenseType, SiteRecoverySqlServerLicenseType? sqlServerLicenseType, string targetVmSize, ResourceIdentifier targetProximityPlacementGroupId, string useManagedDisksForReplication, SiteRecoveryDiskAccountType? diskType, IList<HyperVReplicaAzureDiskDetails> disksToIncludeForManagedDisks, ResourceIdentifier diskEncryptionSetId, IDictionary<string, string> targetVmTags, IDictionary<string, string> seedManagedDiskTags, IDictionary<string, string> targetManagedDiskTags, IDictionary<string, string> targetNicTags, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(instanceType, serializedAdditionalRawData)
        {
            HyperVHostVmId = hyperVHostVmId;
            VmName = vmName;
            OSType = osType;
            VhdId = vhdId;
            TargetStorageAccountId = targetStorageAccountId;
            TargetAzureNetworkId = targetAzureNetworkId;
            TargetAzureSubnetId = targetAzureSubnetId;
            EnableRdpOnTargetOption = enableRdpOnTargetOption;
            TargetAzureVmName = targetAzureVmName;
            LogStorageAccountId = logStorageAccountId;
            DisksToInclude = disksToInclude;
            TargetAzureV1ResourceGroupId = targetAzureV1ResourceGroupId;
            TargetAzureV2ResourceGroupId = targetAzureV2ResourceGroupId;
            UseManagedDisks = useManagedDisks;
            TargetAvailabilitySetId = targetAvailabilitySetId;
            TargetAvailabilityZone = targetAvailabilityZone;
            LicenseType = licenseType;
            SqlServerLicenseType = sqlServerLicenseType;
            TargetVmSize = targetVmSize;
            TargetProximityPlacementGroupId = targetProximityPlacementGroupId;
            UseManagedDisksForReplication = useManagedDisksForReplication;
            DiskType = diskType;
            DisksToIncludeForManagedDisks = disksToIncludeForManagedDisks;
            DiskEncryptionSetId = diskEncryptionSetId;
            TargetVmTags = targetVmTags;
            SeedManagedDiskTags = seedManagedDiskTags;
            TargetManagedDiskTags = targetManagedDiskTags;
            TargetNicTags = targetNicTags;
            InstanceType = instanceType ?? "HyperVReplicaAzure";
        }

        /// <summary> The Hyper-V host VM Id. </summary>
        public string HyperVHostVmId { get; set; }
        /// <summary> The VM Name. </summary>
        public string VmName { get; set; }
        /// <summary> The OS type associated with VM. </summary>
        public string OSType { get; set; }
        /// <summary> The OS disk VHD id associated with VM. </summary>
        public string VhdId { get; set; }
        /// <summary> The storage account Id. </summary>
        public ResourceIdentifier TargetStorageAccountId { get; set; }
        /// <summary> The selected target Azure network Id. </summary>
        public ResourceIdentifier TargetAzureNetworkId { get; set; }
        /// <summary> The selected target Azure subnet Id. </summary>
        public ResourceIdentifier TargetAzureSubnetId { get; set; }
        /// <summary> The selected option to enable RDP\SSH on target vm after failover. String value of SrsDataContract.EnableRDPOnTargetOption enum. </summary>
        public string EnableRdpOnTargetOption { get; set; }
        /// <summary> The target azure VM Name. </summary>
        public string TargetAzureVmName { get; set; }
        /// <summary> The storage account to be used for logging during replication. </summary>
        public ResourceIdentifier LogStorageAccountId { get; set; }
        /// <summary> The list of VHD Ids of disks to be protected. </summary>
        public IList<string> DisksToInclude { get; }
        /// <summary> The Id of the target resource group (for classic deployment) in which the failover VM is to be created. </summary>
        public ResourceIdentifier TargetAzureV1ResourceGroupId { get; set; }
        /// <summary> The Id of the target resource group (for resource manager deployment) in which the failover VM is to be created. </summary>
        public ResourceIdentifier TargetAzureV2ResourceGroupId { get; set; }
        /// <summary> A value indicating whether managed disks should be used during failover. </summary>
        public string UseManagedDisks { get; set; }
        /// <summary> The target availability set ARM Id for resource manager deployment. </summary>
        public ResourceIdentifier TargetAvailabilitySetId { get; set; }
        /// <summary> The target availability zone. </summary>
        public string TargetAvailabilityZone { get; set; }
        /// <summary> License type. </summary>
        public SiteRecoveryLicenseType? LicenseType { get; set; }
        /// <summary> The SQL Server license type. </summary>
        public SiteRecoverySqlServerLicenseType? SqlServerLicenseType { get; set; }
        /// <summary> The target VM size. </summary>
        public string TargetVmSize { get; set; }
        /// <summary> The proximity placement group ARM Id. </summary>
        public ResourceIdentifier TargetProximityPlacementGroupId { get; set; }
        /// <summary> A value indicating whether managed disks should be used during replication. </summary>
        public string UseManagedDisksForReplication { get; set; }
        /// <summary> The DiskType. </summary>
        public SiteRecoveryDiskAccountType? DiskType { get; set; }
        /// <summary> The disks to include list for managed disks. </summary>
        public IList<HyperVReplicaAzureDiskDetails> DisksToIncludeForManagedDisks { get; }
        /// <summary> The DiskEncryptionSet ARM Id. </summary>
        public ResourceIdentifier DiskEncryptionSetId { get; set; }
        /// <summary> The target VM tags. </summary>
        public IDictionary<string, string> TargetVmTags { get; }
        /// <summary> The tags for the seed managed disks. </summary>
        public IDictionary<string, string> SeedManagedDiskTags { get; }
        /// <summary> The tags for the target managed disks. </summary>
        public IDictionary<string, string> TargetManagedDiskTags { get; }
        /// <summary> The tags for the target NICs. </summary>
        public IDictionary<string, string> TargetNicTags { get; }
    }
}
