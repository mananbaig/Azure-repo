// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DataProtectionBackup.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataProtectionBackup
{
    /// <summary>
    /// A class representing the DataProtectionBackupInstance data model.
    /// BackupInstance Resource
    /// </summary>
    public partial class DataProtectionBackupInstanceData : ResourceData
    {
        /// <summary> Initializes a new instance of DataProtectionBackupInstanceData. </summary>
        public DataProtectionBackupInstanceData()
        {
            Tags = new Core.ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of DataProtectionBackupInstanceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> BackupInstanceResource properties. </param>
        /// <param name="tags"> Proxy Resource tags. </param>
        internal DataProtectionBackupInstanceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DataProtectionBackupInstanceProperties properties, IDictionary<string, string> tags) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            Tags = tags;
        }

        /// <summary> BackupInstanceResource properties. </summary>
        public DataProtectionBackupInstanceProperties Properties { get; set; }
        /// <summary> Proxy Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
