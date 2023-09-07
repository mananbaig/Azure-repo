// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.FluidRelay.Models
{
    /// <summary> All Customer-managed key encryption properties for the resource. </summary>
    public partial class CmkEncryptionProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CmkEncryptionProperties"/>. </summary>
        public CmkEncryptionProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CmkEncryptionProperties"/>. </summary>
        /// <param name="keyEncryptionKeyIdentity"> All identity configuration for Customer-managed key settings defining which identity should be used to auth to Key Vault. </param>
        /// <param name="keyEncryptionKeyUri"> key encryption key Url, with or without a version. Ex: https://contosovault.vault.azure.net/keys/contosokek/562a4bb76b524a1493a6afe8e536ee78 or https://contosovault.vault.azure.net/keys/contosokek. Key auto rotation is enabled by providing a key uri without version. Otherwise, customer is responsible for rotating the key. The keyEncryptionKeyIdentity(either SystemAssigned or UserAssigned) should have permission to access this key url. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CmkEncryptionProperties(CmkIdentity keyEncryptionKeyIdentity, Uri keyEncryptionKeyUri, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            KeyEncryptionKeyIdentity = keyEncryptionKeyIdentity;
            KeyEncryptionKeyUri = keyEncryptionKeyUri;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> All identity configuration for Customer-managed key settings defining which identity should be used to auth to Key Vault. </summary>
        public CmkIdentity KeyEncryptionKeyIdentity { get; set; }
        /// <summary> key encryption key Url, with or without a version. Ex: https://contosovault.vault.azure.net/keys/contosokek/562a4bb76b524a1493a6afe8e536ee78 or https://contosovault.vault.azure.net/keys/contosokek. Key auto rotation is enabled by providing a key uri without version. Otherwise, customer is responsible for rotating the key. The keyEncryptionKeyIdentity(either SystemAssigned or UserAssigned) should have permission to access this key url. </summary>
        public Uri KeyEncryptionKeyUri { get; set; }
    }
}
