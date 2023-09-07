// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> VMware Azure specific enable protection input. </summary>
    public partial class InMageAzureV2EnableProtectionContent : EnableProtectionProviderSpecificContent
    {
        /// <summary> Initializes a new instance of <see cref="InMageAzureV2EnableProtectionContent"/>. </summary>
        public InMageAzureV2EnableProtectionContent()
        {
            DisksToInclude = new ChangeTrackingList<InMageAzureV2DiskDetails>();
            TargetVmTags = new ChangeTrackingDictionary<string, string>();
            SeedManagedDiskTags = new ChangeTrackingDictionary<string, string>();
            TargetManagedDiskTags = new ChangeTrackingDictionary<string, string>();
            TargetNicTags = new ChangeTrackingDictionary<string, string>();
            InstanceType = "InMageAzureV2";
        }

        /// <summary> Initializes a new instance of <see cref="InMageAzureV2EnableProtectionContent"/>. </summary>
        /// <param name="instanceType"> The class type. </param>
        /// <param name="masterTargetId"> The Master target Id. </param>
        /// <param name="processServerId"> The Process Server Id. </param>
        /// <param name="storageAccountId"> The storage account Id. </param>
        /// <param name="runAsAccountId"> The CS account Id. </param>
        /// <param name="multiVmGroupId"> The multi VM group Id. </param>
        /// <param name="multiVmGroupName"> The multi VM group name. </param>
        /// <param name="disksToInclude"> The disks to include list. </param>
        /// <param name="targetAzureNetworkId"> The selected target Azure network Id. </param>
        /// <param name="targetAzureSubnetId"> The selected target Azure subnet Id. </param>
        /// <param name="enableRdpOnTargetOption"> The selected option to enable RDP\SSH on target VM after failover. String value of SrsDataContract.EnableRDPOnTargetOption enum. </param>
        /// <param name="targetAzureVmName"> The target azure VM Name. </param>
        /// <param name="logStorageAccountId"> The storage account to be used for logging during replication. </param>
        /// <param name="targetAzureV1ResourceGroupId"> The Id of the target resource group (for classic deployment) in which the failover VM is to be created. </param>
        /// <param name="targetAzureV2ResourceGroupId"> The Id of the target resource group (for resource manager deployment) in which the failover VM is to be created. </param>
        /// <param name="diskType"> The DiskType. </param>
        /// <param name="targetAvailabilitySetId"> The target availability set ARM Id for resource manager deployment. </param>
        /// <param name="targetAvailabilityZone"> The target availability zone. </param>
        /// <param name="targetProximityPlacementGroupId"> The proximity placement group ARM Id. </param>
        /// <param name="licenseType"> License type. </param>
        /// <param name="sqlServerLicenseType"> The SQL Server license type. </param>
        /// <param name="targetVmSize"> The target VM size. </param>
        /// <param name="diskEncryptionSetId"> The DiskEncryptionSet ARM Id. </param>
        /// <param name="targetVmTags"> The target VM tags. </param>
        /// <param name="seedManagedDiskTags"> The tags for the seed managed disks. </param>
        /// <param name="targetManagedDiskTags"> The tags for the target managed disks. </param>
        /// <param name="targetNicTags"> The tags for the target NICs. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InMageAzureV2EnableProtectionContent(string instanceType, string masterTargetId, Guid? processServerId, ResourceIdentifier storageAccountId, string runAsAccountId, string multiVmGroupId, string multiVmGroupName, IList<InMageAzureV2DiskDetails> disksToInclude, ResourceIdentifier targetAzureNetworkId, ResourceIdentifier targetAzureSubnetId, string enableRdpOnTargetOption, string targetAzureVmName, ResourceIdentifier logStorageAccountId, ResourceIdentifier targetAzureV1ResourceGroupId, ResourceIdentifier targetAzureV2ResourceGroupId, SiteRecoveryDiskAccountType? diskType, ResourceIdentifier targetAvailabilitySetId, string targetAvailabilityZone, ResourceIdentifier targetProximityPlacementGroupId, SiteRecoveryLicenseType? licenseType, SiteRecoverySqlServerLicenseType? sqlServerLicenseType, string targetVmSize, ResourceIdentifier diskEncryptionSetId, IDictionary<string, string> targetVmTags, IDictionary<string, string> seedManagedDiskTags, IDictionary<string, string> targetManagedDiskTags, IDictionary<string, string> targetNicTags, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(instanceType, serializedAdditionalRawData)
        {
            MasterTargetId = masterTargetId;
            ProcessServerId = processServerId;
            StorageAccountId = storageAccountId;
            RunAsAccountId = runAsAccountId;
            MultiVmGroupId = multiVmGroupId;
            MultiVmGroupName = multiVmGroupName;
            DisksToInclude = disksToInclude;
            TargetAzureNetworkId = targetAzureNetworkId;
            TargetAzureSubnetId = targetAzureSubnetId;
            EnableRdpOnTargetOption = enableRdpOnTargetOption;
            TargetAzureVmName = targetAzureVmName;
            LogStorageAccountId = logStorageAccountId;
            TargetAzureV1ResourceGroupId = targetAzureV1ResourceGroupId;
            TargetAzureV2ResourceGroupId = targetAzureV2ResourceGroupId;
            DiskType = diskType;
            TargetAvailabilitySetId = targetAvailabilitySetId;
            TargetAvailabilityZone = targetAvailabilityZone;
            TargetProximityPlacementGroupId = targetProximityPlacementGroupId;
            LicenseType = licenseType;
            SqlServerLicenseType = sqlServerLicenseType;
            TargetVmSize = targetVmSize;
            DiskEncryptionSetId = diskEncryptionSetId;
            TargetVmTags = targetVmTags;
            SeedManagedDiskTags = seedManagedDiskTags;
            TargetManagedDiskTags = targetManagedDiskTags;
            TargetNicTags = targetNicTags;
            InstanceType = instanceType ?? "InMageAzureV2";
        }

        /// <summary> The Master target Id. </summary>
        public string MasterTargetId { get; set; }
        /// <summary> The Process Server Id. </summary>
        public Guid? ProcessServerId { get; set; }
        /// <summary> The storage account Id. </summary>
        public ResourceIdentifier StorageAccountId { get; set; }
        /// <summary> The CS account Id. </summary>
        public string RunAsAccountId { get; set; }
        /// <summary> The multi VM group Id. </summary>
        public string MultiVmGroupId { get; set; }
        /// <summary> The multi VM group name. </summary>
        public string MultiVmGroupName { get; set; }
        /// <summary> The disks to include list. </summary>
        public IList<InMageAzureV2DiskDetails> DisksToInclude { get; }
        /// <summary> The selected target Azure network Id. </summary>
        public ResourceIdentifier TargetAzureNetworkId { get; set; }
        /// <summary> The selected target Azure subnet Id. </summary>
        public ResourceIdentifier TargetAzureSubnetId { get; set; }
        /// <summary> The selected option to enable RDP\SSH on target VM after failover. String value of SrsDataContract.EnableRDPOnTargetOption enum. </summary>
        public string EnableRdpOnTargetOption { get; set; }
        /// <summary> The target azure VM Name. </summary>
        public string TargetAzureVmName { get; set; }
        /// <summary> The storage account to be used for logging during replication. </summary>
        public ResourceIdentifier LogStorageAccountId { get; set; }
        /// <summary> The Id of the target resource group (for classic deployment) in which the failover VM is to be created. </summary>
        public ResourceIdentifier TargetAzureV1ResourceGroupId { get; set; }
        /// <summary> The Id of the target resource group (for resource manager deployment) in which the failover VM is to be created. </summary>
        public ResourceIdentifier TargetAzureV2ResourceGroupId { get; set; }
        /// <summary> The DiskType. </summary>
        public SiteRecoveryDiskAccountType? DiskType { get; set; }
        /// <summary> The target availability set ARM Id for resource manager deployment. </summary>
        public ResourceIdentifier TargetAvailabilitySetId { get; set; }
        /// <summary> The target availability zone. </summary>
        public string TargetAvailabilityZone { get; set; }
        /// <summary> The proximity placement group ARM Id. </summary>
        public ResourceIdentifier TargetProximityPlacementGroupId { get; set; }
        /// <summary> License type. </summary>
        public SiteRecoveryLicenseType? LicenseType { get; set; }
        /// <summary> The SQL Server license type. </summary>
        public SiteRecoverySqlServerLicenseType? SqlServerLicenseType { get; set; }
        /// <summary> The target VM size. </summary>
        public string TargetVmSize { get; set; }
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
