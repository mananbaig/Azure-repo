// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> InMageRcm disk input. </summary>
    public partial class InMageRcmDisksDefaultContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="InMageRcmDisksDefaultContent"/>. </summary>
        /// <param name="logStorageAccountId"> The log storage account ARM Id. </param>
        /// <param name="diskType"> The disk type. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="logStorageAccountId"/> is null. </exception>
        public InMageRcmDisksDefaultContent(ResourceIdentifier logStorageAccountId, SiteRecoveryDiskAccountType diskType)
        {
            Argument.AssertNotNull(logStorageAccountId, nameof(logStorageAccountId));

            LogStorageAccountId = logStorageAccountId;
            DiskType = diskType;
        }

        /// <summary> Initializes a new instance of <see cref="InMageRcmDisksDefaultContent"/>. </summary>
        /// <param name="logStorageAccountId"> The log storage account ARM Id. </param>
        /// <param name="diskType"> The disk type. </param>
        /// <param name="diskEncryptionSetId"> The DiskEncryptionSet ARM Id. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InMageRcmDisksDefaultContent(ResourceIdentifier logStorageAccountId, SiteRecoveryDiskAccountType diskType, ResourceIdentifier diskEncryptionSetId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            LogStorageAccountId = logStorageAccountId;
            DiskType = diskType;
            DiskEncryptionSetId = diskEncryptionSetId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="InMageRcmDisksDefaultContent"/> for deserialization. </summary>
        internal InMageRcmDisksDefaultContent()
        {
        }

        /// <summary> The log storage account ARM Id. </summary>
        public ResourceIdentifier LogStorageAccountId { get; }
        /// <summary> The disk type. </summary>
        public SiteRecoveryDiskAccountType DiskType { get; }
        /// <summary> The DiskEncryptionSet ARM Id. </summary>
        public ResourceIdentifier DiskEncryptionSetId { get; set; }
    }
}
