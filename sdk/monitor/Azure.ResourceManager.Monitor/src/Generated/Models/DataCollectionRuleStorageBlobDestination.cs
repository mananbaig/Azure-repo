// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The DataCollectionRuleStorageBlobDestination. </summary>
    public partial class DataCollectionRuleStorageBlobDestination
    {
        /// <summary> Initializes a new instance of DataCollectionRuleStorageBlobDestination. </summary>
        public DataCollectionRuleStorageBlobDestination()
        {
        }

        /// <summary> Initializes a new instance of DataCollectionRuleStorageBlobDestination. </summary>
        /// <param name="containerName"> The container name of the Storage Blob. </param>
        /// <param name="storageAccountResourceId"> The resource ID of the storage account. </param>
        /// <param name="name">
        /// A friendly name for the destination.
        /// This name should be unique across all destinations (regardless of type) within the data collection rule.
        /// </param>
        internal DataCollectionRuleStorageBlobDestination(string containerName, ResourceIdentifier storageAccountResourceId, string name)
        {
            ContainerName = containerName;
            StorageAccountResourceId = storageAccountResourceId;
            Name = name;
        }

        /// <summary> The container name of the Storage Blob. </summary>
        public string ContainerName { get; set; }
        /// <summary> The resource ID of the storage account. </summary>
        public ResourceIdentifier StorageAccountResourceId { get; set; }
        /// <summary>
        /// A friendly name for the destination.
        /// This name should be unique across all destinations (regardless of type) within the data collection rule.
        /// </summary>
        public string Name { get; set; }
    }
}
