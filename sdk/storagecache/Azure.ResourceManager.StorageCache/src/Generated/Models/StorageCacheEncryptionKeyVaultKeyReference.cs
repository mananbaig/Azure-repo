// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.StorageCache.Models
{
    /// <summary> Describes a reference to key vault key. </summary>
    public partial class StorageCacheEncryptionKeyVaultKeyReference
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="StorageCacheEncryptionKeyVaultKeyReference"/>. </summary>
        /// <param name="keyUri"> The URL referencing a key encryption key in key vault. </param>
        /// <param name="sourceVault"> Describes a resource Id to source key vault. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="keyUri"/> or <paramref name="sourceVault"/> is null. </exception>
        public StorageCacheEncryptionKeyVaultKeyReference(Uri keyUri, WritableSubResource sourceVault)
        {
            Argument.AssertNotNull(keyUri, nameof(keyUri));
            Argument.AssertNotNull(sourceVault, nameof(sourceVault));

            KeyUri = keyUri;
            SourceVault = sourceVault;
        }

        /// <summary> Initializes a new instance of <see cref="StorageCacheEncryptionKeyVaultKeyReference"/>. </summary>
        /// <param name="keyUri"> The URL referencing a key encryption key in key vault. </param>
        /// <param name="sourceVault"> Describes a resource Id to source key vault. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageCacheEncryptionKeyVaultKeyReference(Uri keyUri, WritableSubResource sourceVault, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            KeyUri = keyUri;
            SourceVault = sourceVault;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="StorageCacheEncryptionKeyVaultKeyReference"/> for deserialization. </summary>
        internal StorageCacheEncryptionKeyVaultKeyReference()
        {
        }

        /// <summary> The URL referencing a key encryption key in key vault. </summary>
        public Uri KeyUri { get; set; }
        /// <summary> Describes a resource Id to source key vault. </summary>
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
    }
}
