// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> The BackupResourceEncryptionConfigExtendedCreateOrUpdateContent. </summary>
    public partial class BackupResourceEncryptionConfigExtendedCreateOrUpdateContent : TrackedResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="BackupResourceEncryptionConfigExtendedCreateOrUpdateContent"/>. </summary>
        /// <param name="location"> The location. </param>
        public BackupResourceEncryptionConfigExtendedCreateOrUpdateContent(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="BackupResourceEncryptionConfigExtendedCreateOrUpdateContent"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="properties"> BackupResourceEncryptionConfigResource properties. </param>
        /// <param name="eTag"> Optional ETag. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BackupResourceEncryptionConfigExtendedCreateOrUpdateContent(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, BackupResourceEncryptionConfig properties, ETag? eTag, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Properties = properties;
            ETag = eTag;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="BackupResourceEncryptionConfigExtendedCreateOrUpdateContent"/> for deserialization. </summary>
        internal BackupResourceEncryptionConfigExtendedCreateOrUpdateContent()
        {
        }

        /// <summary> BackupResourceEncryptionConfigResource properties. </summary>
        public BackupResourceEncryptionConfig Properties { get; set; }
        /// <summary> Optional ETag. </summary>
        public ETag? ETag { get; set; }
    }
}
