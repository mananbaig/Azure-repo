// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Temp.Batch.Models
{
    /// <summary> Information used to connect to an Azure Fileshare. </summary>
    public partial class AzureFileShareConfiguration
    {
        /// <summary> Initializes a new instance of AzureFileShareConfiguration. </summary>
        /// <param name="accountName"> The Azure Storage account name. </param>
        /// <param name="azureFileUrl"> This is of the form 'https://{account}.file.core.windows.net/'. </param>
        /// <param name="accountKey"> The Azure Storage account key. </param>
        /// <param name="relativeMountPath"> All file systems are mounted relative to the Batch mounts directory, accessible via the AZ_BATCH_NODE_MOUNTS_DIR environment variable. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/>, <paramref name="azureFileUrl"/>, <paramref name="accountKey"/> or <paramref name="relativeMountPath"/> is null. </exception>
        public AzureFileShareConfiguration(string accountName, string azureFileUrl, string accountKey, string relativeMountPath)
        {
            Argument.AssertNotNull(accountName, nameof(accountName));
            Argument.AssertNotNull(azureFileUrl, nameof(azureFileUrl));
            Argument.AssertNotNull(accountKey, nameof(accountKey));
            Argument.AssertNotNull(relativeMountPath, nameof(relativeMountPath));

            AccountName = accountName;
            AzureFileUrl = azureFileUrl;
            AccountKey = accountKey;
            RelativeMountPath = relativeMountPath;
        }

        /// <summary> Initializes a new instance of AzureFileShareConfiguration. </summary>
        /// <param name="accountName"> The Azure Storage account name. </param>
        /// <param name="azureFileUrl"> This is of the form 'https://{account}.file.core.windows.net/'. </param>
        /// <param name="accountKey"> The Azure Storage account key. </param>
        /// <param name="relativeMountPath"> All file systems are mounted relative to the Batch mounts directory, accessible via the AZ_BATCH_NODE_MOUNTS_DIR environment variable. </param>
        /// <param name="mountOptions"> These are 'net use' options in Windows and 'mount' options in Linux. </param>
        internal AzureFileShareConfiguration(string accountName, string azureFileUrl, string accountKey, string relativeMountPath, string mountOptions)
        {
            AccountName = accountName;
            AzureFileUrl = azureFileUrl;
            AccountKey = accountKey;
            RelativeMountPath = relativeMountPath;
            MountOptions = mountOptions;
        }

        /// <summary> The Azure Storage account name. </summary>
        public string AccountName { get; set; }
        /// <summary> This is of the form 'https://{account}.file.core.windows.net/'. </summary>
        public string AzureFileUrl { get; set; }
        /// <summary> The Azure Storage account key. </summary>
        public string AccountKey { get; set; }
        /// <summary> All file systems are mounted relative to the Batch mounts directory, accessible via the AZ_BATCH_NODE_MOUNTS_DIR environment variable. </summary>
        public string RelativeMountPath { get; set; }
        /// <summary> These are 'net use' options in Windows and 'mount' options in Linux. </summary>
        public string MountOptions { get; set; }
    }
}
