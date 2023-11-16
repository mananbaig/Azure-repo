// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Encryption settings. </summary>
    public partial class NetAppAccountEncryption
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="NetAppAccountEncryption"/>. </summary>
        public NetAppAccountEncryption()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NetAppAccountEncryption"/>. </summary>
        /// <param name="keySource"> The encryption keySource (provider). Possible values (case-insensitive):  Microsoft.NetApp, Microsoft.KeyVault. </param>
        /// <param name="keyVaultProperties"> Properties provided by KeVault. Applicable if keySource is 'Microsoft.KeyVault'. </param>
        /// <param name="identity"> Identity used to authenticate to KeyVault. Applicable if keySource is 'Microsoft.KeyVault'. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetAppAccountEncryption(NetAppKeySource? keySource, NetAppKeyVaultProperties keyVaultProperties, NetAppEncryptionIdentity identity, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            KeySource = keySource;
            KeyVaultProperties = keyVaultProperties;
            Identity = identity;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The encryption keySource (provider). Possible values (case-insensitive):  Microsoft.NetApp, Microsoft.KeyVault. </summary>
        public NetAppKeySource? KeySource { get; set; }
        /// <summary> Properties provided by KeVault. Applicable if keySource is 'Microsoft.KeyVault'. </summary>
        public NetAppKeyVaultProperties KeyVaultProperties { get; set; }
        /// <summary> Identity used to authenticate to KeyVault. Applicable if keySource is 'Microsoft.KeyVault'. </summary>
        public NetAppEncryptionIdentity Identity { get; set; }
    }
}
