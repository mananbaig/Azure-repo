// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> VMwareCbt specific enable migration input. </summary>
    public partial class VMwareCbtEnableMigrationInput : EnableMigrationProviderSpecificInput
    {
        /// <summary> Initializes a new instance of VMwareCbtEnableMigrationInput. </summary>
        /// <param name="vmwareMachineId"> The ARM Id of the VM discovered in VMware. </param>
        /// <param name="disksToInclude"> The disks to include list. </param>
        /// <param name="dataMoverRunAsAccountId"> The data mover run as account Id. </param>
        /// <param name="snapshotRunAsAccountId"> The snapshot run as account Id. </param>
        /// <param name="targetResourceGroupId"> The target resource group ARM Id. </param>
        /// <param name="targetNetworkId"> The target network ARM Id. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vmwareMachineId"/>, <paramref name="disksToInclude"/>, <paramref name="dataMoverRunAsAccountId"/>, <paramref name="snapshotRunAsAccountId"/>, <paramref name="targetResourceGroupId"/> or <paramref name="targetNetworkId"/> is null. </exception>
        public VMwareCbtEnableMigrationInput(string vmwareMachineId, IEnumerable<VMwareCbtDiskInput> disksToInclude, string dataMoverRunAsAccountId, string snapshotRunAsAccountId, string targetResourceGroupId, string targetNetworkId)
        {
            if (vmwareMachineId == null)
            {
                throw new ArgumentNullException(nameof(vmwareMachineId));
            }
            if (disksToInclude == null)
            {
                throw new ArgumentNullException(nameof(disksToInclude));
            }
            if (dataMoverRunAsAccountId == null)
            {
                throw new ArgumentNullException(nameof(dataMoverRunAsAccountId));
            }
            if (snapshotRunAsAccountId == null)
            {
                throw new ArgumentNullException(nameof(snapshotRunAsAccountId));
            }
            if (targetResourceGroupId == null)
            {
                throw new ArgumentNullException(nameof(targetResourceGroupId));
            }
            if (targetNetworkId == null)
            {
                throw new ArgumentNullException(nameof(targetNetworkId));
            }

            VmwareMachineId = vmwareMachineId;
            DisksToInclude = disksToInclude.ToList();
            DataMoverRunAsAccountId = dataMoverRunAsAccountId;
            SnapshotRunAsAccountId = snapshotRunAsAccountId;
            TargetResourceGroupId = targetResourceGroupId;
            TargetNetworkId = targetNetworkId;
            TargetVmTags = new ChangeTrackingDictionary<string, string>();
            SeedDiskTags = new ChangeTrackingDictionary<string, string>();
            TargetDiskTags = new ChangeTrackingDictionary<string, string>();
            TargetNicTags = new ChangeTrackingDictionary<string, string>();
            InstanceType = "VMwareCbt";
        }

        /// <summary> The ARM Id of the VM discovered in VMware. </summary>
        public string VmwareMachineId { get; }
        /// <summary> The disks to include list. </summary>
        public IList<VMwareCbtDiskInput> DisksToInclude { get; }
        /// <summary> License type. </summary>
        public LicenseType? LicenseType { get; set; }
        /// <summary> The SQL Server license type. </summary>
        public SqlServerLicenseType? SqlServerLicenseType { get; set; }
        /// <summary> The data mover run as account Id. </summary>
        public string DataMoverRunAsAccountId { get; }
        /// <summary> The snapshot run as account Id. </summary>
        public string SnapshotRunAsAccountId { get; }
        /// <summary> The target VM name. </summary>
        public string TargetVmName { get; set; }
        /// <summary> The target VM size. </summary>
        public string TargetVmSize { get; set; }
        /// <summary> The target resource group ARM Id. </summary>
        public string TargetResourceGroupId { get; }
        /// <summary> The target network ARM Id. </summary>
        public string TargetNetworkId { get; }
        /// <summary> The selected test network ARM Id. </summary>
        public string TestNetworkId { get; set; }
        /// <summary> The target subnet name. </summary>
        public string TargetSubnetName { get; set; }
        /// <summary> The selected test subnet name. </summary>
        public string TestSubnetName { get; set; }
        /// <summary> The target availability set ARM Id. </summary>
        public string TargetAvailabilitySetId { get; set; }
        /// <summary> The target availability zone. </summary>
        public string TargetAvailabilityZone { get; set; }
        /// <summary> The target proximity placement group ARM Id. </summary>
        public string TargetProximityPlacementGroupId { get; set; }
        /// <summary> The target boot diagnostics storage account ARM Id. </summary>
        public string TargetBootDiagnosticsStorageAccountId { get; set; }
        /// <summary> A value indicating whether auto resync is to be done. </summary>
        public string PerformAutoResync { get; set; }
        /// <summary> The target VM tags. </summary>
        public IDictionary<string, string> TargetVmTags { get; }
        /// <summary> The tags for the seed disks. </summary>
        public IDictionary<string, string> SeedDiskTags { get; }
        /// <summary> The tags for the target disks. </summary>
        public IDictionary<string, string> TargetDiskTags { get; }
        /// <summary> The tags for the target NICs. </summary>
        public IDictionary<string, string> TargetNicTags { get; }
    }
}
