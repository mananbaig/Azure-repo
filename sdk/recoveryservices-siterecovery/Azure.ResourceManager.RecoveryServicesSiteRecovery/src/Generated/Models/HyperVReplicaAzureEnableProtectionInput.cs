// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> HyperVReplicaAzure specific enable protection input. </summary>
    public partial class HyperVReplicaAzureEnableProtectionInput : EnableProtectionProviderSpecificInput
    {
        /// <summary> Initializes a new instance of HyperVReplicaAzureEnableProtectionInput. </summary>
        public HyperVReplicaAzureEnableProtectionInput()
        {
            DisksToInclude = new ChangeTrackingList<string>();
            DisksToIncludeForManagedDisks = new ChangeTrackingList<HyperVReplicaAzureDiskInputDetails>();
            TargetVmTags = new ChangeTrackingDictionary<string, string>();
            SeedManagedDiskTags = new ChangeTrackingDictionary<string, string>();
            TargetManagedDiskTags = new ChangeTrackingDictionary<string, string>();
            TargetNicTags = new ChangeTrackingDictionary<string, string>();
            InstanceType = "HyperVReplicaAzure";
        }

        /// <summary> The Hyper-V host VM Id. </summary>
        public string HvHostVmId { get; set; }
        /// <summary> The VM Name. </summary>
        public string VmName { get; set; }
        /// <summary> The OS type associated with VM. </summary>
        public string OSType { get; set; }
        /// <summary> The OS disk VHD id associated with VM. </summary>
        public string VhdId { get; set; }
        /// <summary> The storage account Id. </summary>
        public string TargetStorageAccountId { get; set; }
        /// <summary> The selected target Azure network Id. </summary>
        public string TargetAzureNetworkId { get; set; }
        /// <summary> The selected target Azure subnet Id. </summary>
        public string TargetAzureSubnetId { get; set; }
        /// <summary> The selected option to enable RDP\SSH on target vm after failover. String value of SrsDataContract.EnableRDPOnTargetOption enum. </summary>
        public string EnableRdpOnTargetOption { get; set; }
        /// <summary> The target azure VM Name. </summary>
        public string TargetAzureVmName { get; set; }
        /// <summary> The storage account to be used for logging during replication. </summary>
        public string LogStorageAccountId { get; set; }
        /// <summary> The list of VHD Ids of disks to be protected. </summary>
        public IList<string> DisksToInclude { get; }
        /// <summary> The Id of the target resource group (for classic deployment) in which the failover VM is to be created. </summary>
        public string TargetAzureV1ResourceGroupId { get; set; }
        /// <summary> The Id of the target resource group (for resource manager deployment) in which the failover VM is to be created. </summary>
        public string TargetAzureV2ResourceGroupId { get; set; }
        /// <summary> A value indicating whether managed disks should be used during failover. </summary>
        public string UseManagedDisks { get; set; }
        /// <summary> The target availability set ARM Id for resource manager deployment. </summary>
        public string TargetAvailabilitySetId { get; set; }
        /// <summary> The target availability zone. </summary>
        public string TargetAvailabilityZone { get; set; }
        /// <summary> License type. </summary>
        public LicenseType? LicenseType { get; set; }
        /// <summary> The SQL Server license type. </summary>
        public SqlServerLicenseType? SqlServerLicenseType { get; set; }
        /// <summary> The target VM size. </summary>
        public string TargetVmSize { get; set; }
        /// <summary> The proximity placement group ARM Id. </summary>
        public string TargetProximityPlacementGroupId { get; set; }
        /// <summary> A value indicating whether managed disks should be used during replication. </summary>
        public string UseManagedDisksForReplication { get; set; }
        /// <summary> The DiskType. </summary>
        public DiskAccountType? DiskType { get; set; }
        /// <summary> The disks to include list for managed disks. </summary>
        public IList<HyperVReplicaAzureDiskInputDetails> DisksToIncludeForManagedDisks { get; }
        /// <summary> The DiskEncryptionSet ARM Id. </summary>
        public string DiskEncryptionSetId { get; set; }
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
