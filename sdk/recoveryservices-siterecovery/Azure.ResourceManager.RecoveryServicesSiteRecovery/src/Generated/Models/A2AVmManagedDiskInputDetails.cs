// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> A2A managed disk input details. </summary>
    public partial class A2AVmManagedDiskInputDetails
    {
        /// <summary> Initializes a new instance of A2AVmManagedDiskInputDetails. </summary>
        /// <param name="diskId"> The disk Id. </param>
        /// <param name="primaryStagingAzureStorageAccountId"> The primary staging storage account Arm Id. </param>
        /// <param name="recoveryResourceGroupId"> The target resource group Arm Id. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="diskId"/>, <paramref name="primaryStagingAzureStorageAccountId"/> or <paramref name="recoveryResourceGroupId"/> is null. </exception>
        public A2AVmManagedDiskInputDetails(string diskId, string primaryStagingAzureStorageAccountId, string recoveryResourceGroupId)
        {
            if (diskId == null)
            {
                throw new ArgumentNullException(nameof(diskId));
            }
            if (primaryStagingAzureStorageAccountId == null)
            {
                throw new ArgumentNullException(nameof(primaryStagingAzureStorageAccountId));
            }
            if (recoveryResourceGroupId == null)
            {
                throw new ArgumentNullException(nameof(recoveryResourceGroupId));
            }

            DiskId = diskId;
            PrimaryStagingAzureStorageAccountId = primaryStagingAzureStorageAccountId;
            RecoveryResourceGroupId = recoveryResourceGroupId;
        }

        /// <summary> The disk Id. </summary>
        public string DiskId { get; }
        /// <summary> The primary staging storage account Arm Id. </summary>
        public string PrimaryStagingAzureStorageAccountId { get; }
        /// <summary> The target resource group Arm Id. </summary>
        public string RecoveryResourceGroupId { get; }
        /// <summary> The replica disk type. Its an optional value and will be same as source disk type if not user provided. </summary>
        public string RecoveryReplicaDiskAccountType { get; set; }
        /// <summary> The target disk type after failover. Its an optional value and will be same as source disk type if not user provided. </summary>
        public string RecoveryTargetDiskAccountType { get; set; }
        /// <summary> The recovery disk encryption set Id. </summary>
        public string RecoveryDiskEncryptionSetId { get; set; }
        /// <summary> The recovery disk encryption information (for one / single pass flows). </summary>
        public DiskEncryptionInfo DiskEncryptionInfo { get; set; }
    }
}
