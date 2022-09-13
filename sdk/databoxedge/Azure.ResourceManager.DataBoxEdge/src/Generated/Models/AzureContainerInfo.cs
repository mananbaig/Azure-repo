// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> Azure container mapping of the endpoint. </summary>
    public partial class AzureContainerInfo
    {
        /// <summary> Initializes a new instance of AzureContainerInfo. </summary>
        /// <param name="storageAccountCredentialId"> ID of the storage account credential used to access storage. </param>
        /// <param name="containerName"> Container name (Based on the data format specified, this represents the name of Azure Files/Page blob/Block blob). </param>
        /// <param name="dataFormat"> Storage format used for the file represented by the share. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="storageAccountCredentialId"/> or <paramref name="containerName"/> is null. </exception>
        public AzureContainerInfo(ResourceIdentifier storageAccountCredentialId, string containerName, AzureContainerDataFormat dataFormat)
        {
            if (storageAccountCredentialId == null)
            {
                throw new ArgumentNullException(nameof(storageAccountCredentialId));
            }
            if (containerName == null)
            {
                throw new ArgumentNullException(nameof(containerName));
            }

            StorageAccountCredentialId = storageAccountCredentialId;
            ContainerName = containerName;
            DataFormat = dataFormat;
        }

        /// <summary> ID of the storage account credential used to access storage. </summary>
        public ResourceIdentifier StorageAccountCredentialId { get; set; }
        /// <summary> Container name (Based on the data format specified, this represents the name of Azure Files/Page blob/Block blob). </summary>
        public string ContainerName { get; set; }
        /// <summary> Storage format used for the file represented by the share. </summary>
        public AzureContainerDataFormat DataFormat { get; set; }
    }
}
