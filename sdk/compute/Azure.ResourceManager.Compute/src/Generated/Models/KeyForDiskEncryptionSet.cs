// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Key Vault Key Url to be used for server side encryption of Managed Disks and Snapshots. </summary>
    public partial class KeyForDiskEncryptionSet
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="KeyForDiskEncryptionSet"/>. </summary>
        /// <param name="keyUri"> Fully versioned Key Url pointing to a key in KeyVault. Version segment of the Url is required regardless of rotationToLatestKeyVersionEnabled value. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="keyUri"/> is null. </exception>
        public KeyForDiskEncryptionSet(Uri keyUri)
        {
            Argument.AssertNotNull(keyUri, nameof(keyUri));

            KeyUri = keyUri;
        }

        /// <summary> Initializes a new instance of <see cref="KeyForDiskEncryptionSet"/>. </summary>
        /// <param name="sourceVault"> Resource id of the KeyVault containing the key or secret. This property is optional and cannot be used if the KeyVault subscription is not the same as the Disk Encryption Set subscription. </param>
        /// <param name="keyUri"> Fully versioned Key Url pointing to a key in KeyVault. Version segment of the Url is required regardless of rotationToLatestKeyVersionEnabled value. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal KeyForDiskEncryptionSet(WritableSubResource sourceVault, Uri keyUri, Dictionary<string, BinaryData> rawData)
        {
            SourceVault = sourceVault;
            KeyUri = keyUri;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="KeyForDiskEncryptionSet"/> for deserialization. </summary>
        internal KeyForDiskEncryptionSet()
        {
        }

        /// <summary> Resource id of the KeyVault containing the key or secret. This property is optional and cannot be used if the KeyVault subscription is not the same as the Disk Encryption Set subscription. </summary>
        internal WritableSubResource SourceVault { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier SourceVaultId
        {
            get => SourceVault is null ? default : SourceVault.Id;
            set
            {
                if (SourceVault is null)
                    SourceVault = new WritableSubResource();
                SourceVault.Id = value;
            }
        }

        /// <summary> Fully versioned Key Url pointing to a key in KeyVault. Version segment of the Url is required regardless of rotationToLatestKeyVersionEnabled value. </summary>
        public Uri KeyUri { get; set; }
    }
}
