// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> InMageAzureV2 Managed disk details. </summary>
    public partial class InMageAzureV2ManagedDiskDetails
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="InMageAzureV2ManagedDiskDetails"/>. </summary>
        internal InMageAzureV2ManagedDiskDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="InMageAzureV2ManagedDiskDetails"/>. </summary>
        /// <param name="diskId"> The disk id. </param>
        /// <param name="seedManagedDiskId"> Seed managed disk Id. </param>
        /// <param name="replicaDiskType"> The replica disk type. </param>
        /// <param name="diskEncryptionSetId"> The DiskEncryptionSet ARM ID. </param>
        /// <param name="targetDiskName"> The target disk name. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InMageAzureV2ManagedDiskDetails(string diskId, string seedManagedDiskId, string replicaDiskType, ResourceIdentifier diskEncryptionSetId, string targetDiskName, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DiskId = diskId;
            SeedManagedDiskId = seedManagedDiskId;
            ReplicaDiskType = replicaDiskType;
            DiskEncryptionSetId = diskEncryptionSetId;
            TargetDiskName = targetDiskName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The disk id. </summary>
        public string DiskId { get; }
        /// <summary> Seed managed disk Id. </summary>
        public string SeedManagedDiskId { get; }
        /// <summary> The replica disk type. </summary>
        public string ReplicaDiskType { get; }
        /// <summary> The DiskEncryptionSet ARM ID. </summary>
        public ResourceIdentifier DiskEncryptionSetId { get; }
        /// <summary> The target disk name. </summary>
        public string TargetDiskName { get; }
    }
}
