// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> VMwareCbt protected disk details. </summary>
    public partial class VMwareCbtProtectedDiskDetails
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="VMwareCbtProtectedDiskDetails"/>. </summary>
        internal VMwareCbtProtectedDiskDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VMwareCbtProtectedDiskDetails"/>. </summary>
        /// <param name="diskId"> The disk id. </param>
        /// <param name="diskName"> The disk name. </param>
        /// <param name="diskType"> The disk type. </param>
        /// <param name="diskPath"> The disk path. </param>
        /// <param name="isOSDisk"> A value indicating whether the disk is the OS disk. </param>
        /// <param name="capacityInBytes"> The disk capacity in bytes. </param>
        /// <param name="logStorageAccountId"> The log storage account ARM Id. </param>
        /// <param name="logStorageAccountSasSecretName"> The key vault secret name of the log storage account. </param>
        /// <param name="diskEncryptionSetId"> The DiskEncryptionSet ARM Id. </param>
        /// <param name="seedManagedDiskId"> The ARM Id of the seed managed disk. </param>
        /// <param name="seedBlobUri"> The uri of the seed blob. </param>
        /// <param name="targetManagedDiskId"> The ARM Id of the target managed disk. </param>
        /// <param name="targetBlobUri"> The uri of the target blob. </param>
        /// <param name="targetDiskName"> The name for the target managed disk. </param>
        /// <param name="gatewayOperationDetails"> A value indicating the gateway operation details. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VMwareCbtProtectedDiskDetails(string diskId, string diskName, SiteRecoveryDiskAccountType? diskType, string diskPath, string isOSDisk, long? capacityInBytes, ResourceIdentifier logStorageAccountId, string logStorageAccountSasSecretName, ResourceIdentifier diskEncryptionSetId, string seedManagedDiskId, Uri seedBlobUri, string targetManagedDiskId, Uri targetBlobUri, string targetDiskName, GatewayOperationDetails gatewayOperationDetails, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DiskId = diskId;
            DiskName = diskName;
            DiskType = diskType;
            DiskPath = diskPath;
            IsOSDisk = isOSDisk;
            CapacityInBytes = capacityInBytes;
            LogStorageAccountId = logStorageAccountId;
            LogStorageAccountSasSecretName = logStorageAccountSasSecretName;
            DiskEncryptionSetId = diskEncryptionSetId;
            SeedManagedDiskId = seedManagedDiskId;
            SeedBlobUri = seedBlobUri;
            TargetManagedDiskId = targetManagedDiskId;
            TargetBlobUri = targetBlobUri;
            TargetDiskName = targetDiskName;
            GatewayOperationDetails = gatewayOperationDetails;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The disk id. </summary>
        public string DiskId { get; }
        /// <summary> The disk name. </summary>
        public string DiskName { get; }
        /// <summary> The disk type. </summary>
        public SiteRecoveryDiskAccountType? DiskType { get; }
        /// <summary> The disk path. </summary>
        public string DiskPath { get; }
        /// <summary> A value indicating whether the disk is the OS disk. </summary>
        public string IsOSDisk { get; }
        /// <summary> The disk capacity in bytes. </summary>
        public long? CapacityInBytes { get; }
        /// <summary> The log storage account ARM Id. </summary>
        public ResourceIdentifier LogStorageAccountId { get; }
        /// <summary> The key vault secret name of the log storage account. </summary>
        public string LogStorageAccountSasSecretName { get; }
        /// <summary> The DiskEncryptionSet ARM Id. </summary>
        public ResourceIdentifier DiskEncryptionSetId { get; }
        /// <summary> The ARM Id of the seed managed disk. </summary>
        public string SeedManagedDiskId { get; }
        /// <summary> The uri of the seed blob. </summary>
        public Uri SeedBlobUri { get; }
        /// <summary> The ARM Id of the target managed disk. </summary>
        public string TargetManagedDiskId { get; }
        /// <summary> The uri of the target blob. </summary>
        public Uri TargetBlobUri { get; }
        /// <summary> The name for the target managed disk. </summary>
        public string TargetDiskName { get; }
        /// <summary> A value indicating the gateway operation details. </summary>
        public GatewayOperationDetails GatewayOperationDetails { get; }
    }
}
