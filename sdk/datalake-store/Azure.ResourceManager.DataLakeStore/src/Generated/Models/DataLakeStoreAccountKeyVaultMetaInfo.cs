// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataLakeStore.Models
{
    /// <summary> Metadata information used by account encryption. </summary>
    public partial class DataLakeStoreAccountKeyVaultMetaInfo
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DataLakeStoreAccountKeyVaultMetaInfo"/>. </summary>
        /// <param name="keyVaultResourceId"> The resource identifier for the user managed Key Vault being used to encrypt. </param>
        /// <param name="encryptionKeyName"> The name of the user managed encryption key. </param>
        /// <param name="encryptionKeyVersion"> The version of the user managed encryption key. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="keyVaultResourceId"/>, <paramref name="encryptionKeyName"/> or <paramref name="encryptionKeyVersion"/> is null. </exception>
        public DataLakeStoreAccountKeyVaultMetaInfo(string keyVaultResourceId, string encryptionKeyName, string encryptionKeyVersion)
        {
            Argument.AssertNotNull(keyVaultResourceId, nameof(keyVaultResourceId));
            Argument.AssertNotNull(encryptionKeyName, nameof(encryptionKeyName));
            Argument.AssertNotNull(encryptionKeyVersion, nameof(encryptionKeyVersion));

            KeyVaultResourceId = keyVaultResourceId;
            EncryptionKeyName = encryptionKeyName;
            EncryptionKeyVersion = encryptionKeyVersion;
        }

        /// <summary> Initializes a new instance of <see cref="DataLakeStoreAccountKeyVaultMetaInfo"/>. </summary>
        /// <param name="keyVaultResourceId"> The resource identifier for the user managed Key Vault being used to encrypt. </param>
        /// <param name="encryptionKeyName"> The name of the user managed encryption key. </param>
        /// <param name="encryptionKeyVersion"> The version of the user managed encryption key. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DataLakeStoreAccountKeyVaultMetaInfo(string keyVaultResourceId, string encryptionKeyName, string encryptionKeyVersion, Dictionary<string, BinaryData> rawData)
        {
            KeyVaultResourceId = keyVaultResourceId;
            EncryptionKeyName = encryptionKeyName;
            EncryptionKeyVersion = encryptionKeyVersion;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="DataLakeStoreAccountKeyVaultMetaInfo"/> for deserialization. </summary>
        internal DataLakeStoreAccountKeyVaultMetaInfo()
        {
        }

        /// <summary> The resource identifier for the user managed Key Vault being used to encrypt. </summary>
        public string KeyVaultResourceId { get; set; }
        /// <summary> The name of the user managed encryption key. </summary>
        public string EncryptionKeyName { get; set; }
        /// <summary> The version of the user managed encryption key. </summary>
        public string EncryptionKeyVersion { get; set; }
    }
}
