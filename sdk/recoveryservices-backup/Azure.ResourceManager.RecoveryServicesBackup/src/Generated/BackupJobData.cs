// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.RecoveryServicesBackup.Models;

namespace Azure.ResourceManager.RecoveryServicesBackup
{
    /// <summary>
    /// A class representing the BackupJob data model.
    /// Defines workload agnostic properties for a job.
    /// </summary>
    public partial class BackupJobData : TrackedResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="BackupJobData"/>. </summary>
        /// <param name="location"> The location. </param>
        public BackupJobData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="BackupJobData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="properties">
        /// JobResource properties
        /// Please note <see cref="BackupGenericJob"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="IaasVmBackupJob"/>, <see cref="IaasVmBackupJobV2"/>, <see cref="StorageBackupJob"/>, <see cref="WorkloadBackupJob"/>, <see cref="DpmBackupJob"/>, <see cref="MabBackupJob"/> and <see cref="VaultBackupJob"/>.
        /// </param>
        /// <param name="eTag"> Optional ETag. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BackupJobData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, BackupGenericJob properties, ETag? eTag, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Properties = properties;
            ETag = eTag;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="BackupJobData"/> for deserialization. </summary>
        internal BackupJobData()
        {
        }

        /// <summary>
        /// JobResource properties
        /// Please note <see cref="BackupGenericJob"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="IaasVmBackupJob"/>, <see cref="IaasVmBackupJobV2"/>, <see cref="StorageBackupJob"/>, <see cref="WorkloadBackupJob"/>, <see cref="DpmBackupJob"/>, <see cref="MabBackupJob"/> and <see cref="VaultBackupJob"/>.
        /// </summary>
        public BackupGenericJob Properties { get; set; }
        /// <summary> Optional ETag. </summary>
        public ETag? ETag { get; set; }
    }
}
